
namespace Youtube_Downloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.TextBox();
            this.mp3 = new System.Windows.Forms.RadioButton();
            this.mp4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ULTIMATE YOUTUBE DOWNLOADER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseWaitCursor = true;
            // 
            // Link
            // 
            this.Link.Location = new System.Drawing.Point(195, 170);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(334, 27);
            this.Link.TabIndex = 2;
            this.Link.UseWaitCursor = true;
            // 
            // mp3
            // 
            this.mp3.AutoSize = true;
            this.mp3.BackColor = System.Drawing.Color.Transparent;
            this.mp3.Checked = true;
            this.mp3.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mp3.ForeColor = System.Drawing.Color.Black;
            this.mp3.Location = new System.Drawing.Point(400, 203);
            this.mp3.Name = "mp3";
            this.mp3.Size = new System.Drawing.Size(51, 20);
            this.mp3.TabIndex = 3;
            this.mp3.TabStop = true;
            this.mp3.Text = "MP3";
            this.mp3.UseVisualStyleBackColor = false;
            this.mp3.UseWaitCursor = true;
            this.mp3.CheckedChanged += new System.EventHandler(this.mp3_CheckedChanged);
            // 
            // mp4
            // 
            this.mp4.AutoSize = true;
            this.mp4.BackColor = System.Drawing.Color.Transparent;
            this.mp4.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mp4.Location = new System.Drawing.Point(478, 203);
            this.mp4.Name = "mp4";
            this.mp4.Size = new System.Drawing.Size(51, 20);
            this.mp4.TabIndex = 4;
            this.mp4.Text = "MP4";
            this.mp4.UseVisualStyleBackColor = false;
            this.mp4.UseWaitCursor = true;
            this.mp4.CheckedChanged += new System.EventHandler(this.mp4_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(53, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(476, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "CONVERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Red;
            this.progressBar.Location = new System.Drawing.Point(53, 310);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(476, 39);
            this.progressBar.TabIndex = 8;
            this.progressBar.UseWaitCursor = true;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(53, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "YOUTUBE LINK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mp4);
            this.Controls.Add(this.mp3);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.Name = "Form1";
            this.Text = "Youtube To Mp3";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Link;
        private System.Windows.Forms.RadioButton mp3;
        private System.Windows.Forms.RadioButton mp4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label2;
    }
}

