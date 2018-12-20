namespace YoutubeMP3Downloader
{
    partial class YoutubeVideoDownloader
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
            this.convertBtn = new System.Windows.Forms.Button();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.saveDirectoryBtn = new System.Windows.Forms.Button();
            this.videoCheckBox = new System.Windows.Forms.CheckBox();
            this.saveDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // convertBtn
            // 
            this.convertBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.convertBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.convertBtn.Location = new System.Drawing.Point(12, 154);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(363, 23);
            this.convertBtn.TabIndex = 0;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // linkTextBox
            // 
            this.linkTextBox.Location = new System.Drawing.Point(12, 27);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(363, 20);
            this.linkTextBox.TabIndex = 1;
            this.linkTextBox.TextChanged += new System.EventHandler(this.linkTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Paste youtube link here:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 205);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(481, 23);
            this.progressBar.TabIndex = 3;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // saveDirectoryBtn
            // 
            this.saveDirectoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveDirectoryBtn.Location = new System.Drawing.Point(395, 11);
            this.saveDirectoryBtn.Name = "saveDirectoryBtn";
            this.saveDirectoryBtn.Size = new System.Drawing.Size(101, 166);
            this.saveDirectoryBtn.TabIndex = 4;
            this.saveDirectoryBtn.Text = "Save directory.";
            this.saveDirectoryBtn.UseVisualStyleBackColor = true;
            this.saveDirectoryBtn.Click += new System.EventHandler(this.saveDirectoryBtn_Click);
            // 
            // videoCheckBox
            // 
            this.videoCheckBox.AutoSize = true;
            this.videoCheckBox.Location = new System.Drawing.Point(12, 110);
            this.videoCheckBox.Name = "videoCheckBox";
            this.videoCheckBox.Size = new System.Drawing.Size(254, 17);
            this.videoCheckBox.TabIndex = 5;
            this.videoCheckBox.Text = "Click here if you want to download video file too.";
            this.videoCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveDirectoryTextBox
            // 
            this.saveDirectoryTextBox.Location = new System.Drawing.Point(12, 64);
            this.saveDirectoryTextBox.Name = "saveDirectoryTextBox";
            this.saveDirectoryTextBox.ReadOnly = true;
            this.saveDirectoryTextBox.Size = new System.Drawing.Size(363, 20);
            this.saveDirectoryTextBox.TabIndex = 6;
            // 
            // YoutubeVideoDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 240);
            this.Controls.Add(this.saveDirectoryTextBox);
            this.Controls.Add(this.videoCheckBox);
            this.Controls.Add(this.saveDirectoryBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkTextBox);
            this.Controls.Add(this.convertBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YoutubeVideoDownloader";
            this.Text = "YoutubeDownloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button saveDirectoryBtn;
        private System.Windows.Forms.CheckBox videoCheckBox;
        private System.Windows.Forms.TextBox saveDirectoryTextBox;
    }
}

