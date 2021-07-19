using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
using CefSharp.Internals;
using CefSharp;


namespace MSO_WebCapture
{
    public partial class MainForm : Form
    {
        [System.Runtime.InteropServices.DllImport(@"gdi32.dll")]
        public static extern int BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

        public MainForm()
        {
            InitializeComponent();
            InitBrowser();
            
            
        }

        public ChromiumWebBrowser browser;

        public void InitBrowser()
        {
            Cef.EnableHighDPISupport();
            CefSettings cefs = new CefSettings();
            //關閉使用Proxy Server
            cefs.CefCommandLineArgs.Add("no-proxy-server", "1");

            //Cef.Initialize(new CefSettings());
            Cef.Initialize(cefs);

            browser = new ChromiumWebBrowser(System.Windows.Forms.Application.StartupPath + "\\index.html");
            webPanel.Controls.Add(browser);
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            webPanel.Enabled = smiBrowserOperation.Checked;
            smiWebCapture.Enabled = !smiBrowserOperation.Checked;

        }

        private void smiBrowserOperation_Click(object sender, EventArgs e)
        {
            smiBrowserOperation.Checked = !smiBrowserOperation.Checked;
            webPanel.Enabled = smiBrowserOperation.Checked;
            smiWebCapture.Enabled = !smiBrowserOperation.Checked;

        }

        private void smiWebCapture_Click(object sender, EventArgs e)
        {
            if (strSerial != null)
            {
                funCaptured();
            }
            else {
                MessageBox.Show("尚未設定檔案名稱","提示");
            }
        }

        private void funCaptured()
        {
            string[] arySerial = strSerial.Split('-');
            try
            {

                String fPath = Properties.Settings.Default.StoragePath;

                toolStripStatusLabel1.Text = "儲存 [" + strSerial + "],畫面到[" + Properties.Settings.Default.StoragePath + "]";
                //-----------------------------------------                

                Graphics g1 = webPanel.CreateGraphics();
                Image myImage = new Bitmap(this.webPanel.Width, this.webPanel.Height, g1);
                Graphics g2 = Graphics.FromImage(myImage);
                IntPtr dc1 = g1.GetHdc();
                IntPtr dc2 = g2.GetHdc();

                BitBlt(dc2, 0, 0, this.webPanel.Width, this.webPanel.Height-20, dc1, 0, 0, 0xCC0020);
                g1.ReleaseHdc(dc1);
                g2.ReleaseHdc(dc2);
                
                myImage.Save(fPath +"/"+ strSerial +".jpg");

                //-----------------------------------------
                string incSerial;
                string strTemp = (Int32.Parse(arySerial[2]) + 10001).ToString();
                incSerial = arySerial[0] + "-" + arySerial[1] + "-" + strTemp.Substring(1, 4);
                strSerial = incSerial;

            }
            catch
            {
                toolStripStatusLabel1.Text = "序號讀取失敗";                
            }            
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                webPanel.Controls.Remove(browser);
                browser.Load(smiTestingAddress.Text);
                webPanel.Controls.Add(browser);
                browser.Dock = DockStyle.Fill;
                Properties.Settings.Default.OscWebPage = smiTestingAddress.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void smiAddressTesting_Click(object sender, EventArgs e)
        {
            smiAddressTest.Checked = !smiAddressTest.Checked;
            smiTestingAddress.Visible = smiAddressTest.Checked;
        }

        private void smiSetIP_Click(object sender, EventArgs e)
        {
            frmAddressSetting frm = new frmAddressSetting();
            frm.ShowDialog();
        }

        private void smiConnected_Click(object sender, EventArgs e)
        {
            //browser.Load(Properties.Settings.Default.WebIP);
            browser.Load(Properties.Settings.Default.OscWebPage);

        }

        private void smiStartQuit_Click(object sender, EventArgs e)
        {
            browser.Dispose();
            Environment.Exit(Environment.ExitCode);
        }

        public string strSerial;
        private void smiEnvSetting_Click(object sender, EventArgs e)
        {
            frmEnvSetting frm = new frmEnvSetting();
            frm.ShowDialog();
            strSerial = frm.tbSer1.Text;

        }
    }
}
