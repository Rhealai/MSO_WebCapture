namespace MSO_WebCapture
{
    partial class frmAddressSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbAds1 = new System.Windows.Forms.TextBox();
            this.tbAds2 = new System.Windows.Forms.TextBox();
            this.tbAds3 = new System.Windows.Forms.TextBox();
            this.tbAds4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "位址:               .               .               . ";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(114, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 26);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "確認";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbAds1
            // 
            this.tbAds1.Location = new System.Drawing.Point(69, 7);
            this.tbAds1.Name = "tbAds1";
            this.tbAds1.Size = new System.Drawing.Size(51, 22);
            this.tbAds1.TabIndex = 1;
            // 
            // tbAds2
            // 
            this.tbAds2.Location = new System.Drawing.Point(131, 7);
            this.tbAds2.Name = "tbAds2";
            this.tbAds2.Size = new System.Drawing.Size(51, 22);
            this.tbAds2.TabIndex = 2;
            // 
            // tbAds3
            // 
            this.tbAds3.Location = new System.Drawing.Point(195, 7);
            this.tbAds3.Name = "tbAds3";
            this.tbAds3.Size = new System.Drawing.Size(51, 22);
            this.tbAds3.TabIndex = 3;
            // 
            // tbAds4
            // 
            this.tbAds4.Location = new System.Drawing.Point(258, 7);
            this.tbAds4.Name = "tbAds4";
            this.tbAds4.Size = new System.Drawing.Size(51, 22);
            this.tbAds4.TabIndex = 4;
            // 
            // frmAddressSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 83);
            this.Controls.Add(this.tbAds4);
            this.Controls.Add(this.tbAds3);
            this.Controls.Add(this.tbAds2);
            this.Controls.Add(this.tbAds1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Name = "frmAddressSetting";
            this.Text = "示波器畫面位址設定";
            this.Load += new System.EventHandler(this.frmAddressSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbAds1;
        private System.Windows.Forms.TextBox tbAds2;
        private System.Windows.Forms.TextBox tbAds3;
        private System.Windows.Forms.TextBox tbAds4;
    }
}