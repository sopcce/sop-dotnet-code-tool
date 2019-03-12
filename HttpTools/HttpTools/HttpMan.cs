using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpTools
{
  public partial class HttpMan : Form
  {
    public HttpMan()
    {
      InitializeComponent();
    }

   
    private void txtHeader_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == '\u0001')
      {
        ((TextBox)sender).SelectAll();
        e.Handled = true;
      }
    }
 
    private void btnGo_Click(object sender, EventArgs e)
    {
      this.txtResult.Text = "请等待";
      Dictionary<string, string> dictionary = new Dictionary<string, string>();
      string text = this.txtHeader.Text;
      if (text == "Key:Value格式，可写多个，多个请换行")
      {
        text = "";
      }
      else
      {
        dictionary.Add("txtHeader", text);
      }
      string text2 = this.txtProxyIp.Text;
      if (text2 == "例如：8.8.8.8:8080")
      {
        text2 = "";
      }
      else
      {
        dictionary.Add("txtProxyIp", text2);
      }
      string text3 = this.txtPostData.Text;
      if (text3 == "请填写Post数据")
      {
        text3 = "";
      }
      else
      {
        dictionary.Add("txtPostData", text3);
      }
      string text4 = this.txtCookie.Text;
      if (text4 == "请填写请求时要发送的Cookie")
      {
        text4 = "";
      }
      else
      {
        dictionary.Add("txtCookie", text4);
      }
      string text5 = this.txtUrl.Text;
      if (text5 == "请填写请求url")
      {
        text5 = "";
      }
      else
      {
        dictionary.Add("txtUrl", text5);
      }
      string text6 = this.txtReferer.Text;
      if (text6 == "请填写Referer")
      {
        text6 = "";
      }
      else
      {
        dictionary.Add("txtReferer", text6);
      }
      string text7 = ccbEncode.SelectedItem?.ToString();
      if (text7 == "自动识别")
      {
        text7 = "";
      }
      else
      {
        dictionary.Add("ccbEncode", text7);
      }
      dictionary.Add("cbbContentType", this.cbbContentType.SelectedItem?.ToString());
      string text8 = this.cbbGZip.SelectedItem.ToString();
      if (text8 == "自动")
      {
        text8 = "";
      }
      else
      {
        dictionary.Add("cbbGZip", text8);
      }
      string text9 = this.cbbHttpVersion.SelectedItem?.ToString();
      if (text9 == "不设置")
      {
        text9 = "";
      }
      else
      {
        dictionary.Add("cbbHttpVersion", text9);
      }
      dictionary.Add("cbbLinkTimeOut", this.cbbLinkTimeOut.SelectedItem?.ToString());
      dictionary.Add("cbbMethod", this.cbbMethod.SelectedItem?.ToString());
      string text10 = this.cbbSSLTLS.SelectedItem?.ToString();
      if (text10 == "不设置")
      {
        text10 = "";
      }
      else
      {
        dictionary.Add("cbbSSLTLS", text10);
      }
      dictionary.Add("cbbUserAgent", this.cbbUserAgent.SelectedItem.ToString());
      dictionary.Add("ccbWriteTimeout", this.ccbWriteTimeout.SelectedItem.ToString());
      if (dictionary.Keys.Contains("cbbSSLTLS"))
      {
        switch (dictionary["cbbSSLTLS"])
        {
          case "Ssl(3.0)":
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            break;
          case "Tls(1.0)":
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            break;
          case "Tls(1.1)":
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
            break;
          case "Tls(1.2)":
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            break;
        }
      }

      HttpItem httpItem = new HttpItem();
      if (dictionary.Keys.Contains("txtUrl"))
      {
        httpItem.Url = dictionary["txtUrl"];
      }
      if (dictionary.Keys.Contains("ccbEncode") && dictionary["ccbEncode"].Trim().Length > 0)
      {
        httpItem.Encoding = Encoding.GetEncoding(dictionary["ccbEncode"]);
      }
      if (dictionary.Keys.Contains("cbbMethod"))
      {
        httpItem.Method = dictionary["cbbMethod"];
      }
      if (dictionary.Keys.Contains("cbbLinkTimeOut"))
      {
        httpItem.Timeout = int.Parse(dictionary["cbbLinkTimeOut"].Replace("秒", "")) * 1000;
      }
      if (dictionary.Keys.Contains("ccbWriteTimeout"))
      {
        httpItem.ReadWriteTimeout = int.Parse(dictionary["ccbWriteTimeout"].Replace("秒", "")) * 1000;
      }
      if (dictionary.Keys.Contains("cbbContentType"))
      {
        httpItem.ContentType = dictionary["cbbContentType"];
      }
      if (dictionary.Keys.Contains("cbbUserAgent"))
      {
        httpItem.UserAgent = dictionary["cbbUserAgent"];
      }
      if (dictionary.Keys.Contains("cbbHttpVersion"))
      {
        switch (dictionary["cbbHttpVersion"])
        {
          case "HTTP/1.1":
            httpItem.ProtocolVersion = HttpVersion.Version11;
            break;
          case "HTTP/1.0":
            httpItem.ProtocolVersion = HttpVersion.Version10;
            break;
        }
      }
      if (dictionary.Keys.Contains("txtHeader"))
      {
        string text11 = dictionary["txtHeader"];
        string[] array = text11.Split(Environment.NewLine.ToCharArray());
        string[] array2 = array;
        foreach (string text12 in array2)
        {
          string[] array3 = new string[2];
          if (text12.Contains(":"))
          {
            array3 = text12.Split(':');
            goto IL_0644;
          }
          if (text12.Contains("："))
          {
            array3 = text12.Split('：');
            goto IL_0644;
          }
          continue;
          IL_0644:
          httpItem.Header.Add(array3[0], array3[1]);
        }
      }
      if (dictionary.Keys.Contains("txtProxyIp"))
      {
        httpItem.ProxyIp = dictionary["txtProxyIp"];
      }
      if (dictionary.Keys.Contains("txtReferer"))
      {
        httpItem.Referer = dictionary["txtReferer"];
      }
      if (dictionary.Keys.Contains("txtPostData"))
      {
        httpItem.Postdata = dictionary["txtPostData"];
      }
      if (dictionary.Keys.Contains("txtCookie"))
      {
        httpItem.Cookie = dictionary["txtCookie"];
      }
      ThreadPool.QueueUserWorkItem(delegate (object o)
      {
        HttpMan form = this;
        HttpItem item = (HttpItem)o;
        HttpHelper httpHelper = new HttpHelper();
        HttpResult result = httpHelper.GetHtml(item);
        WriteResult method = delegate
        {
          form.txtResult.Text = result.Html;
        };
        base.Invoke(method, result.Html);
      }, httpItem);
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
      this.txtResult.SelectAll();
      Clipboard.SetDataObject(this.txtResult.SelectedText);
      MessageBox.Show("复制成功");
    }

    

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("http://www.bejson.com/jsoneditoronline/");
    }

    private void ToolStripMenuItem_Update_Click(object sender, EventArgs e)
    {
      Process.Start("http://www.bejson.com/othertools/profession_request_tools/");
    }

    private void HttpMan_Load(object sender, EventArgs e)
    {
      this.cbbContentType.SelectedIndex = 0;
      this.cbbGZip.SelectedIndex = 0;
      this.cbbHttpVersion.SelectedIndex = 0;
      this.cbbLinkTimeOut.SelectedIndex = 0;
      this.cbbMethod.SelectedIndex = 0;
      this.cbbSSLTLS.SelectedIndex = 0;
      this.cbbUserAgent.SelectedIndex = 0;
      this.ccbEncode.SelectedIndex = 0;
      this.ccbWriteTimeout.SelectedIndex = 0;
      this.txtHeader.Text = "Key:Value格式，可写多个，多个请换行";
      this.txtProxyIp.Text = "例如：8.8.8.8:8080";
      this.txtPostData.Text = "请填写Post数据";
      this.txtCookie.Text = "请填写请求时要发送的Cookie";
      this.txtUrl.Text = "请填写请求url";
      this.txtReferer.Text = "请填写Referer";

    }



  }
}
