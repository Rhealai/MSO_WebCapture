using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MSO_WebCapture
{
    public partial class frmEnvSetting : Form
    {
               

        public frmEnvSetting()
        {
            InitializeComponent();
        }



        private void tbFilesStorage_DoubleClick(object sender, EventArgs e)
        {
            String StorePath = Properties.Settings.Default.StoragePath;
            FolderBrowserDialog path = new FolderBrowserDialog();
            //path.RootFolder = StorePath;
            path.SelectedPath = StorePath;

            path.ShowDialog();

            tbFilesStorage.Text = path.SelectedPath;
            Properties.Settings.Default.StoragePath = path.SelectedPath;

            Properties.Settings.Default.Save();
        }

        private void frmEnvSetting_Load(object sender, EventArgs e)
        {
            string strPath = Properties.Settings.Default.StoragePath;
            tbFilesStorage.Text = strPath;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.StoragePath = tbFilesStorage.Text;
            Properties.Settings.Default.Save();          
            this.Close();
        }
    
    }
}
