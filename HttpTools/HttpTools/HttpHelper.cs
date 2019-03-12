// HttpTools.HttpHelper
using HttpTools;
using System;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

public class HttpHelper
{
  private Encoding encoding = Encoding.Default;

  private Encoding postencoding = Encoding.Default;

  private HttpWebRequest request = null;

  private HttpWebResponse response = null;

  public HttpResult GetHtml(HttpItem item)
  {
    HttpResult httpResult = new HttpResult();
    try
    {
      this.SetRequest(item);
    }
    catch (Exception ex)
    {
      HttpResult httpResult2 = new HttpResult();
      httpResult2.Cookie = string.Empty;
      httpResult2.Header = null;
      httpResult2.Html = ex.Message;
      httpResult2.StatusDescription = "配置参数时出错：" + ex.Message;
      return httpResult2;
    }
    try
    {
      using (this.response = (HttpWebResponse)this.request.GetResponse())
      {
        httpResult.StatusCode = this.response.StatusCode;
        httpResult.StatusDescription = this.response.StatusDescription;
        httpResult.Header = this.response.Headers;
        if (this.response.Cookies != null)
        {
          httpResult.CookieCollection = this.response.Cookies;
        }
        if (((NameValueCollection)this.response.Headers)["set-cookie"] != null)
        {
          httpResult.Cookie = ((NameValueCollection)this.response.Headers)["set-cookie"];
        }
        byte[] array = null;
        using (MemoryStream memoryStream = new MemoryStream())
        {
          if (this.response.ContentEncoding != null && this.response.ContentEncoding.Equals("gzip", StringComparison.InvariantCultureIgnoreCase))
          {
            new GZipStream(this.response.GetResponseStream(), CompressionMode.Decompress).CopyTo(memoryStream, 10240);
          }
          else
          {
            this.response.GetResponseStream().CopyTo(memoryStream, 10240);
          }
          array = memoryStream.ToArray();
        }
        if (array != null & array.Length > 0)
        {
          if (item.ResultType == ResultType.Byte)
          {
            httpResult.ResultByte = array;
          }
          if (this.encoding == null)
          {
            Match match = Regex.Match(Encoding.Default.GetString(array), "<meta([^<]*)charset=([^<]*)[\"']", RegexOptions.IgnoreCase);
            string text = (match.Groups.Count > 1) ? match.Groups[2].Value.ToLower() : string.Empty;
            if (text.Length > 2)
            {
              this.encoding = Encoding.GetEncoding(text.Trim().Replace("\"", "").Replace("'", "")
                .Replace(";", "")
                .Replace("iso-8859-1", "utf-8"));
            }
            else if (string.IsNullOrWhiteSpace(this.response.CharacterSet))
            {
              this.encoding = Encoding.UTF8;
            }
            else
            {
              this.encoding = Encoding.GetEncoding(this.response.CharacterSet);
            }
          }
          httpResult.Html = this.encoding.GetString(array);
        }
        else
        {
          httpResult.Html = "本次请求并未返回任何数据";
        }
      }
    }
    catch (WebException ex2)
    {
      this.response = (HttpWebResponse)ex2.Response;
      httpResult.Html = ex2.Message;
      if (this.response != null)
      {
        httpResult.StatusCode = this.response.StatusCode;
        httpResult.StatusDescription = this.response.StatusDescription;
      }
    }
    catch (Exception ex)
    {
      httpResult.Html = ex.Message;
    }
    if (item.IsToLower)
    {
      httpResult.Html = httpResult.Html.ToLower();
    }
    return httpResult;
  }

  private void SetRequest(HttpItem item)
  {
    this.SetCer(item);
    if (item.Header != null && item.Header.Count > 0)
    {
      string[] allKeys = item.Header.AllKeys;
      foreach (string name in allKeys)
      {
        this.request.Headers.Add(name, ((NameValueCollection)item.Header)[name]);
      }
    }
    this.SetProxy(item);
    if (item.ProtocolVersion != (Version)null)
    {
      this.request.ProtocolVersion = item.ProtocolVersion;
    }
    this.request.ServicePoint.Expect100Continue = item.Expect100Continue;
    this.request.Method = item.Method;
    this.request.Timeout = item.Timeout;
    this.request.KeepAlive = item.KeepAlive;
    this.request.ReadWriteTimeout = item.ReadWriteTimeout;
    if (!string.IsNullOrWhiteSpace(item.Host))
    {
      this.request.Host = item.Host;
    }
    this.request.Accept = item.Accept;
    this.request.ContentType = item.ContentType;
    this.request.UserAgent = item.UserAgent;
    this.encoding = item.Encoding;
    this.SetCookie(item);
    this.request.Referer = item.Referer;
    this.request.AllowAutoRedirect = item.Allowautoredirect;
    this.SetPostData(item);
    if (item.Connectionlimit > 0)
    {
      this.request.ServicePoint.ConnectionLimit = item.Connectionlimit;
    }
  }

  private void SetCer(HttpItem item)
  {
    if (!string.IsNullOrWhiteSpace(item.CerPath))
    {
      ServicePointManager.ServerCertificateValidationCallback = this.CheckValidationResult;
      this.request = (HttpWebRequest)WebRequest.Create(item.Url);
      this.SetCerList(item);
      this.request.ClientCertificates.Add(new X509Certificate(item.CerPath));
    }
    else
    {
      this.request = (HttpWebRequest)WebRequest.Create(item.Url);
      this.SetCerList(item);
    }
  }

  private void SetCerList(HttpItem item)
  {
    if (item.ClentCertificates != null && item.ClentCertificates.Count > 0)
    {
      X509CertificateCollection.X509CertificateEnumerator enumerator = item.ClentCertificates.GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
        {
          X509Certificate current = enumerator.Current;
          this.request.ClientCertificates.Add(current);
        }
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
        {
          disposable.Dispose();
        }
      }
    }
  }

  private void SetCookie(HttpItem item)
  {
    if (!string.IsNullOrWhiteSpace(item.Cookie))
    {
      this.request.Headers[HttpRequestHeader.Cookie] = item.Cookie;
    }
    if (item.CookieCollection != null)
    {
      this.request.CookieContainer = new CookieContainer();
      this.request.CookieContainer.Add(item.CookieCollection);
    }
  }

  private void SetPostData(HttpItem item)
  {
    if (this.request.Method.Trim().ToLower().Contains("post") || this.request.Method.Trim().ToLower().Contains("put"))
    {
      if (item.PostEncoding != null)
      {
        this.postencoding = item.PostEncoding;
      }
      byte[] array = null;
      if (item.PostDataType == PostDataType.Byte && item.PostdataByte != null && item.PostdataByte.Length > 0)
      {
        array = item.PostdataByte;
      }
      else if (item.PostDataType == PostDataType.FilePath && !string.IsNullOrWhiteSpace(item.Postdata))
      {
        StreamReader streamReader = new StreamReader(item.Postdata, this.postencoding);
        array = this.postencoding.GetBytes(streamReader.ReadToEnd());
        streamReader.Close();
      }
      else if (!string.IsNullOrWhiteSpace(item.Postdata))
      {
        array = this.postencoding.GetBytes(item.Postdata);
      }
      if (array != null)
      {
        this.request.ContentLength = array.Length;
        this.request.GetRequestStream().Write(array, 0, array.Length);
      }
      else
      {
        this.request.ContentLength = 0L;
      }
    }
    else
    {
      this.request.ContentLength = 0L;
    }
  }

  private void SetProxy(HttpItem item)
  {
    if (!string.IsNullOrWhiteSpace(item.ProxyIp))
    {
      if (item.ProxyIp.Contains(":"))
      {
        string[] array = item.ProxyIp.Split(':');
        WebProxy webProxy = new WebProxy(array[0].Trim(), Convert.ToInt32(array[1].Trim()));
        webProxy.Credentials = new NetworkCredential(item.ProxyUserName, item.ProxyPwd);
        this.request.Proxy = webProxy;
      }
      else
      {
        WebProxy webProxy = new WebProxy(item.ProxyIp, false);
        webProxy.Credentials = new NetworkCredential(item.ProxyUserName, item.ProxyPwd);
        this.request.Proxy = webProxy;
      }
      this.request.Credentials = CredentialCache.DefaultNetworkCredentials;
    }
  }

  public bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
  {
    return true;
  }
}
