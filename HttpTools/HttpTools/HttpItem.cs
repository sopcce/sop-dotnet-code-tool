
using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HttpTools
{
  public class HttpItem
  {
    private int _Timeout = 100000;
    public string Url { get; set; }
    public string Method { get; set; } = "GET"; public int Timeout { get { return this._Timeout; } set { this._Timeout = value; } }
    public int ReadWriteTimeout { get; set; } = 30000;
    public string Host { get; set; }
    public bool KeepAlive { get; set; } = true;
    public string Accept { get; set; } = "text/html, application/xhtml+xml, */*";
    public string ContentType { get; set; } = "text/html";
    public string UserAgent { get; set; } = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)";
    public Encoding Encoding { get; set; }
    public PostDataType PostDataType { get; set; } = PostDataType.String;
    public string Postdata { get; set; }
    public byte[] PostdataByte { get; set; }
    public CookieCollection CookieCollection { get; set; }
    public string Cookie { get; set; }
    public string Referer { get; set; }
    public string CerPath { get; set; }
    public bool IsToLower { get; set; } = false;
    public bool Allowautoredirect { get; set; } = false;
    public int Connectionlimit { get; set; } = 1024;
    public string ProxyUserName { get; set; }
    public string ProxyPwd { get; set; }
    public string ProxyIp { get; set; }
    public ResultType ResultType { get; set; } = ResultType.String;
    public WebHeaderCollection Header { get; set; } = new WebHeaderCollection();
    public Version ProtocolVersion { get; set; }
    public bool Expect100Continue { get; set; } = true;
    public X509CertificateCollection ClentCertificates { get; set; }
    public Encoding PostEncoding { get; set; }
  }
  public enum PostDataType { String, Byte, FilePath }
  public enum ResultType { String, Byte }
}