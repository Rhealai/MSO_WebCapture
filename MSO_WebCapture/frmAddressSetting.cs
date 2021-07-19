using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSO_WebCapture
{
    public partial class frmAddressSetting : Form
    {
        public frmAddressSetting()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] aryWebIP = new string[4];
            aryWebIP[0] = tbAds1.Text;
            aryWebIP[1] = tbAds2.Text;
            aryWebIP[2] = tbAds3.Text;
            aryWebIP[3] = tbAds4.Text;

            string strWebIP = aryWebIP[0] + '.' + aryWebIP[1] + '.' + aryWebIP[2] + '.' + aryWebIP[3];
            Properties.Settings.Default.WebIP = strWebIP;
            Properties.Settings.Default.OscWebPage = strWebIP;
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void frmAddressSetting_Load(object sender, EventArgs e)
        {
            string strWebIP = Properties.Settings.Default.WebIP;
            string[] aryWebIP = strWebIP.Split('.');
            tbAds1.Text = aryWebIP[0];
            tbAds2.Text = aryWebIP[1];
            tbAds3.Text = aryWebIP[2];
            tbAds4.Text = aryWebIP[3];

        }
    }
}
