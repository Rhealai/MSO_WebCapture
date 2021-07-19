namespace MSO_WebCapture
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.webPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.smiStartLink = new System.Windows.Forms.ToolStripMenuItem();
            this.smiConnected = new System.Windows.Forms.ToolStripMenuItem();
            this.smiSetIP = new System.Windows.Forms.ToolStripMenuItem();
            this.smiStartQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.smiFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.smiBrowserOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.smiWebCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.smiSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.smiEnvSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.smiAddressTest = new System.Windows.Forms.ToolStripMenuItem();
            this.smiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.smiTestingAddress = new System.Windows.Forms.ToolStripTextBox();
            this.webPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webPanel
            // 
            this.webPanel.BackColor = System.Drawing.SystemColors.Control;
            this.webPanel.Controls.Add(this.statusStrip1);
            this.webPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPanel.Location = new System.Drawing.Point(0, 27);
            this.webPanel.Name = "webPanel";
            this.webPanel.Size = new System.Drawing.Size(852, 573);
            this.webPanel.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(852, 20);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 15);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiStart,
            this.smiFunction,
            this.smiSetting,
            this.smiAbout,
            this.smiTestingAddress});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smiStart
            // 
            this.smiStart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiStartLink,
            this.smiStartQuit});
            this.smiStart.Name = "smiStart";
            this.smiStart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.smiStart.Size = new System.Drawing.Size(58, 23);
            this.smiStart.Text = "開始(&S)";
            // 
            // smiStartLink
            // 
            this.smiStartLink.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiConnected,
            this.smiSetIP});
            this.smiStartLink.Name = "smiStartLink";
            this.smiStartLink.Size = new System.Drawing.Size(134, 22);
            this.smiStartLink.Text = "連接示波器";
            // 
            // smiConnected
            // 
            this.smiConnected.Name = "smiConnected";
            this.smiConnected.Size = new System.Drawing.Size(158, 22);
            this.smiConnected.Text = "連接(&L)";
            this.smiConnected.Click += new System.EventHandler(this.smiConnected_Click);
            // 
            // smiSetIP
            // 
            this.smiSetIP.Name = "smiSetIP";
            this.smiSetIP.Size = new System.Drawing.Size(158, 22);
            this.smiSetIP.Text = "示波器畫面位址";
            this.smiSetIP.Click += new System.EventHandler(this.smiSetIP_Click);
            // 
            // smiStartQuit
            // 
            this.smiStartQuit.Name = "smiStartQuit";
            this.smiStartQuit.Size = new System.Drawing.Size(134, 22);
            this.smiStartQuit.Text = "離開";
            this.smiStartQuit.Click += new System.EventHandler(this.smiStartQuit_Click);
            // 
            // smiFunction
            // 
            this.smiFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiBrowserOperation,
            this.smiWebCapture});
            this.smiFunction.Name = "smiFunction";
            this.smiFunction.ShortcutKeyDisplayString = "";
            this.smiFunction.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.smiFunction.Size = new System.Drawing.Size(57, 23);
            this.smiFunction.Text = "功能(&F)";
            // 
            // smiBrowserOperation
            // 
            this.smiBrowserOperation.Checked = true;
            this.smiBrowserOperation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smiBrowserOperation.Name = "smiBrowserOperation";
            this.smiBrowserOperation.Size = new System.Drawing.Size(152, 22);
            this.smiBrowserOperation.Text = "操作瀏覽";
            this.smiBrowserOperation.Click += new System.EventHandler(this.smiBrowserOperation_Click);
            // 
            // smiWebCapture
            // 
            this.smiWebCapture.Name = "smiWebCapture";
            this.smiWebCapture.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.smiWebCapture.ShowShortcutKeys = false;
            this.smiWebCapture.Size = new System.Drawing.Size(152, 22);
            this.smiWebCapture.Text = "畫面擷取(&F9)";
            this.smiWebCapture.Click += new System.EventHandler(this.smiWebCapture_Click);
            // 
            // smiSetting
            // 
            this.smiSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiEnvSetting,
            this.smiAddressTest});
            this.smiSetting.Name = "smiSetting";
            this.smiSetting.Size = new System.Drawing.Size(43, 23);
            this.smiSetting.Text = "設定";
            // 
            // smiEnvSetting
            // 
            this.smiEnvSetting.Name = "smiEnvSetting";
            this.smiEnvSetting.Size = new System.Drawing.Size(152, 22);
            this.smiEnvSetting.Text = "環境設定";
            this.smiEnvSetting.Click += new System.EventHandler(this.smiEnvSetting_Click);
            // 
            // smiAddressTest
            // 
            this.smiAddressTest.Name = "smiAddressTest";
            this.smiAddressTest.Size = new System.Drawing.Size(152, 22);
            this.smiAddressTest.Text = "位址測試";
            this.smiAddressTest.Click += new System.EventHandler(this.smiAddressTesting_Click);
            // 
            // smiAbout
            // 
            this.smiAbout.Name = "smiAbout";
            this.smiAbout.Size = new System.Drawing.Size(43, 23);
            this.smiAbout.Text = "關於";
            this.smiAbout.Visible = false;
            // 
            // smiTestingAddress
            // 
            this.smiTestingAddress.Name = "smiTestingAddress";
            this.smiTestingAddress.Size = new System.Drawing.Size(300, 23);
            this.smiTestingAddress.Visible = false;
            this.smiTestingAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 600);
            this.Controls.Add(this.webPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MSO_Capture Application (0.3 Beta)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.webPanel.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smiStart;
        private System.Windows.Forms.ToolStripMenuItem smiStartLink;
        private System.Windows.Forms.ToolStripMenuItem smiConnected;
        private System.Windows.Forms.ToolStripMenuItem smiStartQuit;
        private System.Windows.Forms.ToolStripMenuItem smiSetIP;
        private System.Windows.Forms.ToolStripMenuItem smiSetting;
        private System.Windows.Forms.ToolStripMenuItem smiEnvSetting;
        private System.Windows.Forms.ToolStripMenuItem smiAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem smiFunction;
        private System.Windows.Forms.ToolStripMenuItem smiBrowserOperation;
        private System.Windows.Forms.ToolStripMenuItem smiWebCapture;
        private System.Windows.Forms.Panel webPanel;
        private System.Windows.Forms.ToolStripTextBox smiTestingAddress;
        private System.Windows.Forms.ToolStripMenuItem smiAddressTest;
    }
}

