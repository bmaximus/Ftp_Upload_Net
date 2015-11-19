namespace FTP_3xc
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblHost_Name = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.chkLstFtpData = new System.Windows.Forms.CheckedListBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblEtl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.prgDownload = new System.Windows.Forms.ProgressBar();
            this.txtTransferRate = new System.Windows.Forms.TextBox();
            this.txtEstimatedTimeLeft = new System.Windows.Forms.TextBox();
            this.txtDownloadedBytes = new System.Windows.Forms.TextBox();
            this.lblDownloadedBytes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.Location = new System.Drawing.Point(9, 9);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(186, 13);
            this.lblInstruction1.TabIndex = 0;
            this.lblInstruction1.Text = "Please insert the following  information";
            // 
            // txtHostName
            // 
            this.txtHostName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtHostName.Location = new System.Drawing.Point(72, 35);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(128, 20);
            this.txtHostName.TabIndex = 1;
            this.txtHostName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLogin
            // 
            this.txtLogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtLogin.Location = new System.Drawing.Point(72, 61);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(128, 20);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPassword.Location = new System.Drawing.Point(72, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(128, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHost_Name
            // 
            this.lblHost_Name.AutoSize = true;
            this.lblHost_Name.Location = new System.Drawing.Point(9, 38);
            this.lblHost_Name.Name = "lblHost_Name";
            this.lblHost_Name.Size = new System.Drawing.Size(60, 13);
            this.lblHost_Name.TabIndex = 4;
            this.lblHost_Name.Text = "Host Name";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(9, 64);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Login";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 90);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // btnConnect
            // 
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(72, 113);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(128, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // chkLstFtpData
            // 
            this.chkLstFtpData.FormattingEnabled = true;
            this.chkLstFtpData.Location = new System.Drawing.Point(12, 143);
            this.chkLstFtpData.Name = "chkLstFtpData";
            this.chkLstFtpData.Size = new System.Drawing.Size(188, 94);
            this.chkLstFtpData.TabIndex = 8;
            // 
            // btnDownload
            // 
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownload.Location = new System.Drawing.Point(223, 185);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(138, 23);
            this.btnDownload.TabIndex = 10;
            this.btnDownload.Text = "Download Selected";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(223, 214);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblEtl
            // 
            this.lblEtl.AutoSize = true;
            this.lblEtl.Location = new System.Drawing.Point(223, 89);
            this.lblEtl.Name = "lblEtl";
            this.lblEtl.Size = new System.Drawing.Size(67, 13);
            this.lblEtl.TabIndex = 14;
            this.lblEtl.Text = "Est. time left:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Transfer Rate:";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(223, 8);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(102, 13);
            this.lblProgress.TabIndex = 12;
            this.lblProgress.Text = "Download Progress:";
            // 
            // prgDownload
            // 
            this.prgDownload.ForeColor = System.Drawing.Color.ForestGreen;
            this.prgDownload.Location = new System.Drawing.Point(223, 27);
            this.prgDownload.Name = "prgDownload";
            this.prgDownload.Size = new System.Drawing.Size(138, 23);
            this.prgDownload.TabIndex = 15;
            // 
            // txtTransferRate
            // 
            this.txtTransferRate.Enabled = false;
            this.txtTransferRate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTransferRate.Location = new System.Drawing.Point(304, 60);
            this.txtTransferRate.Name = "txtTransferRate";
            this.txtTransferRate.Size = new System.Drawing.Size(57, 20);
            this.txtTransferRate.TabIndex = 16;
            this.txtTransferRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEstimatedTimeLeft
            // 
            this.txtEstimatedTimeLeft.Enabled = false;
            this.txtEstimatedTimeLeft.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEstimatedTimeLeft.Location = new System.Drawing.Point(304, 86);
            this.txtEstimatedTimeLeft.Name = "txtEstimatedTimeLeft";
            this.txtEstimatedTimeLeft.Size = new System.Drawing.Size(57, 20);
            this.txtEstimatedTimeLeft.TabIndex = 17;
            this.txtEstimatedTimeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDownloadedBytes
            // 
            this.txtDownloadedBytes.Enabled = false;
            this.txtDownloadedBytes.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDownloadedBytes.Location = new System.Drawing.Point(304, 112);
            this.txtDownloadedBytes.Name = "txtDownloadedBytes";
            this.txtDownloadedBytes.Size = new System.Drawing.Size(57, 20);
            this.txtDownloadedBytes.TabIndex = 19;
            this.txtDownloadedBytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDownloadedBytes
            // 
            this.lblDownloadedBytes.Location = new System.Drawing.Point(223, 115);
            this.lblDownloadedBytes.Name = "lblDownloadedBytes";
            this.lblDownloadedBytes.Size = new System.Drawing.Size(67, 34);
            this.lblDownloadedBytes.TabIndex = 18;
            this.lblDownloadedBytes.Text = "Downloaded Bytes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 247);
            this.Controls.Add(this.txtDownloadedBytes);
            this.Controls.Add(this.lblDownloadedBytes);
            this.Controls.Add(this.txtEstimatedTimeLeft);
            this.Controls.Add(this.txtTransferRate);
            this.Controls.Add(this.prgDownload);
            this.Controls.Add(this.lblEtl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.chkLstFtpData);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblHost_Name);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.lblInstruction1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblHost_Name;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckedListBox chkLstFtpData;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblEtl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar prgDownload;
        private System.Windows.Forms.TextBox txtTransferRate;
        private System.Windows.Forms.TextBox txtEstimatedTimeLeft;
        private System.Windows.Forms.TextBox txtDownloadedBytes;
        private System.Windows.Forms.Label lblDownloadedBytes;
    }
}

