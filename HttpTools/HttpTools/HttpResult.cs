// HttpTools.HttpResult

using System.Net;

namespace HttpTools
{
  public class HttpResult
  {
    public string Cookie
    {
      get;
      set;
    }

    public CookieCollection CookieCollection
    {
      get;
      set;
    }

    public string Html
    {
      get;
      set;
    }

    public byte[] ResultByte
    {
      get;
      set;
    }

    public WebHeaderCollection Header
    {
      get;
      set;
    }

    public string StatusDescription
    {
      get;
      set;
    }

    public HttpStatusCode StatusCode
    {
      get;
      set;
    }
  }
}
