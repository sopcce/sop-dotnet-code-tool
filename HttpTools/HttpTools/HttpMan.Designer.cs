using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HttpTools
{
  partial class HttpMan
  {
    /// <summary>
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    public delegate void WriteResult(string txt);

    public const string txtUrlContent = "请填写请求url";

    public const string txtHeaderContent = "Key:Value格式，可写多个，多个请换行";

    public const string txtProxyIpContent = "例如：8.8.8.8:8080";

    public const string txtPostDataContent = "请填写Post数据";

    public const string txtCookiesContent = "请填写请求时要发送的Cookie";

    public const string txtRefererContent = "请填写Referer";

 
    private Label label1;

    private Panel panel1;

    private TextBox txtUrl;

    private Panel panel2;

    private ComboBox ccbEncode;

    private Label label2;

    private ComboBox cbbSSLTLS;

    private ComboBox comboBox6;

    private ComboBox cbbUserAgent;

    private ComboBox ccbWriteTimeout;

    private ComboBox cbbMethod;

    private Label label11;

    private Label label9;

    private Label label7;

    private Label label5;

    private Label label3;

    private ComboBox cbbGZip;

    private Label label10;

    private ComboBox cbbHttpVersion;

    private Label label8;

    private ComboBox cbbContentType;

    private Label label6;

    private ComboBox cbbLinkTimeOut;

    private Label label4;

    private Panel panel3;

    private TextBox txtHeader;

    private Label label12;

    private Panel panel4;

    private TextBox txtReferer;

    private Label label14;

    private TextBox txtProxyIp;

    private Label label13;

    private Panel panel5;

    private TextBox txtPostData;

    private Label label15;

    private Panel panel6;

    private TextBox txtCookie;

    private Label label16;

    private Button btnGo;

    private Panel panel8;

    private Label Label17;

    private Button btnCopy;

    private LinkLabel linkLabel2;
    /// <summary>
    /// 清理所有正在使用的资源。
    /// </summary>
    /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows 窗体设计器生成的代码

    /// <summary>
    /// 设计器支持所需的方法 - 不要修改
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    //private void InitializeComponent()
    //{
    //  //this.SuspendLayout();
    //  //// 
    //  //// Form1
    //  //// 
    //  //this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    //  //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //  //this.ClientSize = new System.Drawing.Size(1707, 997);
    //  //this.Name = "Form1";
    //  //this.Text = "Form1";
    //  //this.Load += new System.EventHandler(this.Form1_Load);
    //  //this.ResumeLayout(false);

    //}
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtUrl = new System.Windows.Forms.TextBox();
      this.btnGo = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.cbbSSLTLS = new System.Windows.Forms.ComboBox();
      this.comboBox6 = new System.Windows.Forms.ComboBox();
      this.cbbUserAgent = new System.Windows.Forms.ComboBox();
      this.ccbWriteTimeout = new System.Windows.Forms.ComboBox();
      this.cbbMethod = new System.Windows.Forms.ComboBox();
      this.label11 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.cbbGZip = new System.Windows.Forms.ComboBox();
      this.label10 = new System.Windows.Forms.Label();
      this.cbbHttpVersion = new System.Windows.Forms.ComboBox();
      this.label8 = new System.Windows.Forms.Label();
      this.cbbContentType = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.cbbLinkTimeOut = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.ccbEncode = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.txtHeader = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.txtReferer = new System.Windows.Forms.TextBox();
      this.label14 = new System.Windows.Forms.Label();
      this.txtProxyIp = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.panel5 = new System.Windows.Forms.Panel();
      this.txtPostData = new System.Windows.Forms.TextBox();
      this.label15 = new System.Windows.Forms.Label();
      this.panel6 = new System.Windows.Forms.Panel();
      this.txtCookie = new System.Windows.Forms.TextBox();
      this.label16 = new System.Windows.Forms.Label();
      this.btnCopy = new System.Windows.Forms.Button();
      this.panel8 = new System.Windows.Forms.Panel();
      this.txtResult = new System.Windows.Forms.RichTextBox();
      this.linkLabel2 = new System.Windows.Forms.LinkLabel();
      this.Label17 = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.FToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItem_Quit = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
      this.更新UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel6.SuspendLayout();
      this.panel8.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(4, 23);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "请求URL:";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.txtUrl);
      this.panel1.Controls.Add(this.btnGo);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(16, 49);
      this.panel1.Margin = new System.Windows.Forms.Padding(4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(936, 57);
      this.panel1.TabIndex = 1;
      // 
      // txtUrl
      // 
      this.txtUrl.Location = new System.Drawing.Point(113, 16);
      this.txtUrl.Margin = new System.Windows.Forms.Padding(4);
      this.txtUrl.Name = "txtUrl";
      this.txtUrl.Size = new System.Drawing.Size(680, 26);
      this.txtUrl.TabIndex = 1;
      // 
      // btnGo
      // 
      this.btnGo.Location = new System.Drawing.Point(801, 11);
      this.btnGo.Margin = new System.Windows.Forms.Padding(4);
      this.btnGo.Name = "btnGo";
      this.btnGo.Size = new System.Drawing.Size(131, 31);
      this.btnGo.TabIndex = 18;
      this.btnGo.Text = "发送请求数据";
      this.btnGo.UseVisualStyleBackColor = true;
      this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.cbbSSLTLS);
      this.panel2.Controls.Add(this.comboBox6);
      this.panel2.Controls.Add(this.cbbUserAgent);
      this.panel2.Controls.Add(this.ccbWriteTimeout);
      this.panel2.Controls.Add(this.cbbMethod);
      this.panel2.Controls.Add(this.label11);
      this.panel2.Controls.Add(this.label9);
      this.panel2.Controls.Add(this.label7);
      this.panel2.Controls.Add(this.label5);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Controls.Add(this.cbbGZip);
      this.panel2.Controls.Add(this.label10);
      this.panel2.Controls.Add(this.cbbHttpVersion);
      this.panel2.Controls.Add(this.label8);
      this.panel2.Controls.Add(this.cbbContentType);
      this.panel2.Controls.Add(this.label6);
      this.panel2.Controls.Add(this.cbbLinkTimeOut);
      this.panel2.Controls.Add(this.label4);
      this.panel2.Controls.Add(this.ccbEncode);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Location = new System.Drawing.Point(16, 116);
      this.panel2.Margin = new System.Windows.Forms.Padding(4);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(936, 196);
      this.panel2.TabIndex = 2;
      this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
      // 
      // cbbSSLTLS
      // 
      this.cbbSSLTLS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbbSSLTLS.FormattingEnabled = true;
      this.cbbSSLTLS.Items.AddRange(new object[] {
            "默认",
            "Ssl(3.0)",
            "Tls(1.0)",
            "Tls(1.1)",
            "Tls(1.2)"});
      this.cbbSSLTLS.Location = new System.Drawing.Point(591, 119);
      this.cbbSSLTLS.Margin = new System.Windows.Forms.Padding(4);
      this.cbbSSLTLS.Name = "cbbSSLTLS";
      this.cbbSSLTLS.Size = new System.Drawing.Size(312, 24);
      this.cbbSSLTLS.TabIndex = 11;
      // 
      // comboBox6
      // 
      this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox6.FormattingEnabled = true;
      this.comboBox6.Items.AddRange(new object[] {
            "GET",
            "POST"});
      this.comboBox6.Location = new System.Drawing.Point(591, 153);
      this.comboBox6.Margin = new System.Windows.Forms.Padding(4);
      this.comboBox6.Name = "comboBox6";
      this.comboBox6.Size = new System.Drawing.Size(312, 24);
      this.comboBox6.TabIndex = 9;
      this.comboBox6.Visible = false;
      // 
      // cbbUserAgent
      // 
      this.cbbUserAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbbUserAgent.FormattingEnabled = true;
      this.cbbUserAgent.Items.AddRange(new object[] {
            "Mozilla/5.0(compatible;MSIE 9.0; Windows NT 6.1; Trident/5.0)",
            "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0",
            "Mozilla/4.0 (compatible;MSIE 8.0; Windows NT6.0)",
            "Opera/9.27 (Windows NT 5.2; U;zh-cn)"});
      this.cbbUserAgent.Location = new System.Drawing.Point(591, 84);
      this.cbbUserAgent.Margin = new System.Windows.Forms.Padding(4);
      this.cbbUserAgent.Name = "cbbUserAgent";
      this.cbbUserAgent.Size = new System.Drawing.Size(312, 24);
      this.cbbUserAgent.TabIndex = 7;
      // 
      // ccbWriteTimeout
      // 
      this.ccbWriteTimeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ccbWriteTimeout.FormattingEnabled = true;
      this.ccbWriteTimeout.Items.AddRange(new object[] {
            "10秒",
            "30秒",
            "45秒",
            "60秒",
            "100秒"});
      this.ccbWriteTimeout.Location = new System.Drawing.Point(591, 49);
      this.ccbWriteTimeout.Margin = new System.Windows.Forms.Padding(4);
      this.ccbWriteTimeout.Name = "ccbWriteTimeout";
      this.ccbWriteTimeout.Size = new System.Drawing.Size(312, 24);
      this.ccbWriteTimeout.TabIndex = 5;
      // 
      // cbbMethod
      // 
      this.cbbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbbMethod.FormattingEnabled = true;
      this.cbbMethod.Items.AddRange(new object[] {
            "GET",
            "POST"});
      this.cbbMethod.Location = new System.Drawing.Point(591, 15);
      this.cbbMethod.Margin = new System.Windows.Forms.Padding(4);
      this.cbbMethod.Name = "cbbMethod";
      this.cbbMethod.Size = new System.Drawing.Size(312, 24);
      this.cbbMethod.TabIndex = 3;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(483, 123);
      this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(104, 16);
      this.label11.TabIndex = 0;
      this.label11.Text = "SSL/TLS设置:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(483, 157);
      this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(80, 16);
      this.label9.TabIndex = 0;
      this.label9.Text = "请求方式:";
      this.label9.Visible = false;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(483, 88);
      this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(88, 16);
      this.label7.TabIndex = 0;
      this.label7.Text = "UserAgent:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(483, 53);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(80, 16);
      this.label5.TabIndex = 0;
      this.label5.Text = "写入超时:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(483, 19);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(80, 16);
      this.label3.TabIndex = 0;
      this.label3.Text = "请求方式:";
      // 
      // cbbGZip
      // 
      this.cbbGZip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbbGZip.FormattingEnabled = true;
      this.cbbGZip.Items.AddRange(new object[] {
            "自动",
            "True"});
      this.cbbGZip.Location = new System.Drawing.Point(113, 153);
      this.cbbGZip.Margin = new System.Windows.Forms.Padding(4);
      this.cbbGZip.Name = "cbbGZip";
      this.cbbGZip.Size = new System.Drawing.Size(312, 24);
      this.cbbGZip.TabIndex = 10;
      this.cbbGZip.Visible = false;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(4, 157);
      this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(80, 16);
      this.label10.TabIndex = 0;
      this.label10.Text = "GZIP设置:";
      this.label10.Visible = false;
      // 
      // cbbHttpVersion
      // 
      this.cbbHttpVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbbHttpVersion.FormattingEnabled = true;
      this.cbbHttpVersion.Items.AddRange(new object[] {
            "不设置",
            "HTTP/1.1",
            "HTTP/1.0"});
      this.cbbHttpVersion.Location = new System.Drawing.Point(113, 119);
      this.cbbHttpVersion.Margin = new System.Windows.Forms.Padding(4);
      this.cbbHttpVersion.Name = "cbbHttpVersion";
      this.cbbHttpVersion.Size = new System.Drawing.Size(312, 24);
      this.cbbHttpVersion.TabIndex = 8;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(4, 123);
      this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(80, 16);
      this.label8.TabIndex = 0;
      this.label8.Text = "HTTP版本:";
      // 
      // cbbContentType
      // 
      this.cbbContentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbbContentType.FormattingEnabled = true;
      this.cbbContentType.Items.AddRange(new object[] {
            "text/html",
            "application/x-www-form-urlencoded",
            "application/json",
            "text/json"});
      this.cbbContentType.Location = new System.Drawing.Point(113, 84);
      this.cbbContentType.Margin = new System.Windows.Forms.Padding(4);
      this.cbbContentType.Name = "cbbContentType";
      this.cbbContentType.Size = new System.Drawing.Size(312, 24);
      this.cbbContentType.TabIndex = 6;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(4, 88);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(104, 16);
      this.label6.TabIndex = 0;
      this.label6.Text = "ContentType:";
      // 
      // cbbLinkTimeOut
      // 
      this.cbbLinkTimeOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbbLinkTimeOut.FormattingEnabled = true;
      this.cbbLinkTimeOut.Items.AddRange(new object[] {
            "10秒",
            "30秒",
            "45秒",
            "60秒",
            "100秒"});
      this.cbbLinkTimeOut.Location = new System.Drawing.Point(113, 49);
      this.cbbLinkTimeOut.Margin = new System.Windows.Forms.Padding(4);
      this.cbbLinkTimeOut.Name = "cbbLinkTimeOut";
      this.cbbLinkTimeOut.Size = new System.Drawing.Size(312, 24);
      this.cbbLinkTimeOut.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(4, 53);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(80, 16);
      this.label4.TabIndex = 0;
      this.label4.Text = "链接超时:";
      // 
      // ccbEncode
      // 
      this.ccbEncode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ccbEncode.FormattingEnabled = true;
      this.ccbEncode.Items.AddRange(new object[] {
            "自动识别",
            "Default",
            "UTF-8",
            "GBK",
            "GB2312",
            "ASCII",
            "Unicode"});
      this.ccbEncode.Location = new System.Drawing.Point(113, 15);
      this.ccbEncode.Margin = new System.Windows.Forms.Padding(4);
      this.ccbEncode.Name = "ccbEncode";
      this.ccbEncode.Size = new System.Drawing.Size(312, 24);
      this.ccbEncode.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(4, 19);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 16);
      this.label2.TabIndex = 0;
      this.label2.Text = "编码方式:";
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.txtHeader);
      this.panel3.Controls.Add(this.label12);
      this.panel3.Location = new System.Drawing.Point(17, 321);
      this.panel3.Margin = new System.Windows.Forms.Padding(4);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(935, 107);
      this.panel3.TabIndex = 3;
      // 
      // txtHeader
      // 
      this.txtHeader.Location = new System.Drawing.Point(112, 4);
      this.txtHeader.Margin = new System.Windows.Forms.Padding(4);
      this.txtHeader.Multiline = true;
      this.txtHeader.Name = "txtHeader";
      this.txtHeader.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtHeader.Size = new System.Drawing.Size(789, 95);
      this.txtHeader.TabIndex = 12;
      this.txtHeader.TextChanged += new System.EventHandler(this.txtHeader_TextChanged);
      this.txtHeader.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeader_KeyPress);
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(5, 41);
      this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(96, 16);
      this.label12.TabIndex = 0;
      this.label12.Text = "设定Header:";
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.txtReferer);
      this.panel4.Controls.Add(this.label14);
      this.panel4.Controls.Add(this.txtProxyIp);
      this.panel4.Controls.Add(this.label13);
      this.panel4.Location = new System.Drawing.Point(17, 436);
      this.panel4.Margin = new System.Windows.Forms.Padding(4);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(935, 77);
      this.panel4.TabIndex = 4;
      // 
      // txtReferer
      // 
      this.txtReferer.Location = new System.Drawing.Point(112, 40);
      this.txtReferer.Margin = new System.Windows.Forms.Padding(4);
      this.txtReferer.Name = "txtReferer";
      this.txtReferer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtReferer.Size = new System.Drawing.Size(789, 26);
      this.txtReferer.TabIndex = 14;
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(5, 44);
      this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(72, 16);
      this.label14.TabIndex = 0;
      this.label14.Text = "Referer:";
      // 
      // txtProxyIp
      // 
      this.txtProxyIp.Location = new System.Drawing.Point(112, 4);
      this.txtProxyIp.Margin = new System.Windows.Forms.Padding(4);
      this.txtProxyIp.Name = "txtProxyIp";
      this.txtProxyIp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtProxyIp.Size = new System.Drawing.Size(789, 26);
      this.txtProxyIp.TabIndex = 13;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(5, 8);
      this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(64, 16);
      this.label13.TabIndex = 0;
      this.label13.Text = "代理IP:";
      // 
      // panel5
      // 
      this.panel5.Controls.Add(this.txtPostData);
      this.panel5.Controls.Add(this.label15);
      this.panel5.Location = new System.Drawing.Point(16, 521);
      this.panel5.Margin = new System.Windows.Forms.Padding(4);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(935, 107);
      this.panel5.TabIndex = 5;
      // 
      // txtPostData
      // 
      this.txtPostData.Location = new System.Drawing.Point(112, 4);
      this.txtPostData.Margin = new System.Windows.Forms.Padding(4);
      this.txtPostData.Multiline = true;
      this.txtPostData.Name = "txtPostData";
      this.txtPostData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtPostData.Size = new System.Drawing.Size(789, 95);
      this.txtPostData.TabIndex = 15;
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(5, 44);
      this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(80, 16);
      this.label15.TabIndex = 0;
      this.label15.Text = "Post数据:";
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.txtCookie);
      this.panel6.Controls.Add(this.label16);
      this.panel6.Location = new System.Drawing.Point(17, 636);
      this.panel6.Margin = new System.Windows.Forms.Padding(4);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(935, 113);
      this.panel6.TabIndex = 6;
      // 
      // txtCookie
      // 
      this.txtCookie.Location = new System.Drawing.Point(112, 4);
      this.txtCookie.Margin = new System.Windows.Forms.Padding(4);
      this.txtCookie.Multiline = true;
      this.txtCookie.Name = "txtCookie";
      this.txtCookie.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtCookie.Size = new System.Drawing.Size(789, 95);
      this.txtCookie.TabIndex = 16;
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(5, 39);
      this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(64, 16);
      this.label16.TabIndex = 0;
      this.label16.Text = "Cookie:";
      // 
      // btnCopy
      // 
      this.btnCopy.Location = new System.Drawing.Point(216, 11);
      this.btnCopy.Margin = new System.Windows.Forms.Padding(4);
      this.btnCopy.Name = "btnCopy";
      this.btnCopy.Size = new System.Drawing.Size(176, 39);
      this.btnCopy.TabIndex = 19;
      this.btnCopy.Text = "复制";
      this.btnCopy.UseVisualStyleBackColor = true;
      this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
      // 
      // panel8
      // 
      this.panel8.Controls.Add(this.txtResult);
      this.panel8.Controls.Add(this.btnCopy);
      this.panel8.Controls.Add(this.linkLabel2);
      this.panel8.Controls.Add(this.Label17);
      this.panel8.Location = new System.Drawing.Point(961, 50);
      this.panel8.Margin = new System.Windows.Forms.Padding(4);
      this.panel8.Name = "panel8";
      this.panel8.Size = new System.Drawing.Size(521, 699);
      this.panel8.TabIndex = 19;
      // 
      // txtResult
      // 
      this.txtResult.Location = new System.Drawing.Point(22, 66);
      this.txtResult.Name = "txtResult";
      this.txtResult.Size = new System.Drawing.Size(483, 619);
      this.txtResult.TabIndex = 13;
      this.txtResult.Text = "";
      // 
      // linkLabel2
      // 
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.Location = new System.Drawing.Point(98, 25);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new System.Drawing.Size(72, 16);
      this.linkLabel2.TabIndex = 2;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "JSON视图";
      // 
      // Label17
      // 
      this.Label17.AutoSize = true;
      this.Label17.Location = new System.Drawing.Point(19, 25);
      this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label17.Name = "Label17";
      this.Label17.Size = new System.Drawing.Size(72, 16);
      this.Label17.TabIndex = 0;
      this.Label17.Text = "请求结果";
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FToolStripMenuItem_File,
            this.ToolStripMenuItem_Help});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1509, 29);
      this.menuStrip1.TabIndex = 20;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // FToolStripMenuItem_File
      // 
      this.FToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Quit});
      this.FToolStripMenuItem_File.Name = "FToolStripMenuItem_File";
      this.FToolStripMenuItem_File.Size = new System.Drawing.Size(73, 25);
      this.FToolStripMenuItem_File.Text = "文件(&F)";
      // 
      // ToolStripMenuItem_Quit
      // 
      this.ToolStripMenuItem_Quit.Name = "ToolStripMenuItem_Quit";
      this.ToolStripMenuItem_Quit.Size = new System.Drawing.Size(143, 28);
      this.ToolStripMenuItem_Quit.Text = "退出(&Q)";
      // 
      // ToolStripMenuItem_Help
      // 
      this.ToolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更新UToolStripMenuItem,
            this.ToolStripMenuItem_About});
      this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
      this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(76, 25);
      this.ToolStripMenuItem_Help.Text = "帮助(&H)";
      // 
      // 更新UToolStripMenuItem
      // 
      this.更新UToolStripMenuItem.Name = "更新UToolStripMenuItem";
      this.更新UToolStripMenuItem.Size = new System.Drawing.Size(142, 28);
      this.更新UToolStripMenuItem.Text = "更新(&U)";
      this.更新UToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Update_Click);
      // 
      // ToolStripMenuItem_About
      // 
      this.ToolStripMenuItem_About.Name = "ToolStripMenuItem_About";
      this.ToolStripMenuItem_About.Size = new System.Drawing.Size(142, 28);
      this.ToolStripMenuItem_About.Text = "关于(&A)";
      // 
      // HttpMan
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
      this.ClientSize = new System.Drawing.Size(1509, 775);
      this.Controls.Add(this.panel8);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.panel6);
      this.Controls.Add(this.panel5);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.MaximumSize = new System.Drawing.Size(1527, 823);
      this.Name = "HttpMan";
      this.Text = "Http模拟请求工具(V1.4)";
      this.Load += new System.EventHandler(this.HttpMan_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.panel8.ResumeLayout(false);
      this.panel8.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem FToolStripMenuItem_File;
    private ToolStripMenuItem ToolStripMenuItem_Quit;
    private ToolStripMenuItem ToolStripMenuItem_Help;
    private ToolStripMenuItem 更新UToolStripMenuItem;
    private ToolStripMenuItem ToolStripMenuItem_About;
    private RichTextBox txtResult;
  }
}

