namespace MSO_WebCapture
{
    partial class frmEnvSetting
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbFilesStorage = new System.Windows.Forms.TextBox();
            this.tbSer1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "檔案名稱設定";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "存檔位置";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(192, 108);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "確定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbFilesStorage
            // 
            this.tbFilesStorage.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbFilesStorage.Location = new System.Drawing.Point(132, 66);
            this.tbFilesStorage.Name = "tbFilesStorage";
            this.tbFilesStorage.Size = new System.Drawing.Size(198, 23);
            this.tbFilesStorage.TabIndex = 2;
            this.tbFilesStorage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFilesStorage.DoubleClick += new System.EventHandler(this.tbFilesStorage_DoubleClick);
            // 
            // tbSer1
            // 
            this.tbSer1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbSer1.Location = new System.Drawing.Point(132, 24);
            this.tbSer1.Name = "tbSer1";
            this.tbSer1.Size = new System.Drawing.Size(198, 23);
            this.tbSer1.TabIndex = 2;
            this.tbSer1.Text = "0000-0000000-0000";
            this.tbSer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmEnvSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 148);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbFilesStorage);
            this.Controls.Add(this.tbSer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEnvSetting";
            this.Text = "設定頁面";
            this.Load += new System.EventHandler(this.frmEnvSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbFilesStorage;
        internal System.Windows.Forms.TextBox tbSer1;
    }
}