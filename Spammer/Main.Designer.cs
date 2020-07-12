namespace Spammer
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label Interval;
            this.UI_Name = new System.Windows.Forms.Label();
            this.PrefixLable = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrefixText = new System.Windows.Forms.RichTextBox();
            this.InputText = new System.Windows.Forms.RichTextBox();
            this.StartSpam = new System.Windows.Forms.Button();
            this.StopSpam = new System.Windows.Forms.Button();
            this.VersionNumber = new System.Windows.Forms.Label();
            this.PayPal_Link = new System.Windows.Forms.LinkLabel();
            this.CheckUpdateLabel = new System.Windows.Forms.LinkLabel();
            this.PrefixHelp = new System.Windows.Forms.Button();
            this.InputTextHelp = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IntervalHelp = new System.Windows.Forms.Button();
            this.interval10 = new System.Windows.Forms.Button();
            this.Interval100 = new System.Windows.Forms.Button();
            this.Interval1000 = new System.Windows.Forms.Button();
            Interval = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Interval
            // 
            Interval.AutoSize = true;
            Interval.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Interval.ForeColor = System.Drawing.Color.Red;
            Interval.Location = new System.Drawing.Point(281, 93);
            Interval.Name = "Interval";
            Interval.Size = new System.Drawing.Size(65, 19);
            Interval.TabIndex = 13;
            Interval.Text = "Interval";
            // 
            // UI_Name
            // 
            this.UI_Name.AutoSize = true;
            this.UI_Name.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(65)))), ((int)(((byte)(113)))));
            this.UI_Name.Location = new System.Drawing.Point(12, 5);
            this.UI_Name.Name = "UI_Name";
            this.UI_Name.Size = new System.Drawing.Size(97, 23);
            this.UI_Name.TabIndex = 0;
            this.UI_Name.Text = "SP4MM3R";
            this.UI_Name.Click += new System.EventHandler(this.UI_Name_Click);
            // 
            // PrefixLable
            // 
            this.PrefixLable.AutoSize = true;
            this.PrefixLable.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrefixLable.ForeColor = System.Drawing.Color.Red;
            this.PrefixLable.Location = new System.Drawing.Point(13, 93);
            this.PrefixLable.Name = "PrefixLable";
            this.PrefixLable.Size = new System.Drawing.Size(52, 19);
            this.PrefixLable.TabIndex = 1;
            this.PrefixLable.Text = "Prefix";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel.ForeColor = System.Drawing.Color.Red;
            this.TextLabel.Location = new System.Drawing.Point(13, 157);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(78, 19);
            this.TextLabel.TabIndex = 2;
            this.TextLabel.Text = "Input Text";
            this.TextLabel.Click += new System.EventHandler(this.TextLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(13, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Made By : AddisonIsGone";
            // 
            // PrefixText
            // 
            this.PrefixText.Location = new System.Drawing.Point(13, 116);
            this.PrefixText.Name = "PrefixText";
            this.PrefixText.Size = new System.Drawing.Size(143, 23);
            this.PrefixText.TabIndex = 4;
            this.PrefixText.Text = "";
            // 
            // InputText
            // 
            this.InputText.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputText.Location = new System.Drawing.Point(13, 179);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(395, 70);
            this.InputText.TabIndex = 5;
            this.InputText.Text = "";
            // 
            // StartSpam
            // 
            this.StartSpam.Font = new System.Drawing.Font("Bahnschrift Light", 8.5F);
            this.StartSpam.Location = new System.Drawing.Point(425, 179);
            this.StartSpam.Name = "StartSpam";
            this.StartSpam.Size = new System.Drawing.Size(95, 32);
            this.StartSpam.TabIndex = 6;
            this.StartSpam.Text = "Start";
            this.StartSpam.UseVisualStyleBackColor = true;
            this.StartSpam.Click += new System.EventHandler(this.StartSpam_Click);
            // 
            // StopSpam
            // 
            this.StopSpam.Font = new System.Drawing.Font("Bahnschrift Light", 8.5F);
            this.StopSpam.Location = new System.Drawing.Point(425, 217);
            this.StopSpam.Name = "StopSpam";
            this.StopSpam.Size = new System.Drawing.Size(95, 32);
            this.StopSpam.TabIndex = 7;
            this.StopSpam.Text = "Stop";
            this.StopSpam.UseVisualStyleBackColor = true;
            this.StopSpam.Click += new System.EventHandler(this.StopSpam_Click);
            // 
            // VersionNumber
            // 
            this.VersionNumber.AutoSize = true;
            this.VersionNumber.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionNumber.ForeColor = System.Drawing.Color.Red;
            this.VersionNumber.Location = new System.Drawing.Point(493, 5);
            this.VersionNumber.Name = "VersionNumber";
            this.VersionNumber.Size = new System.Drawing.Size(36, 19);
            this.VersionNumber.TabIndex = 8;
            this.VersionNumber.Text = "V0.1";
            this.VersionNumber.Click += new System.EventHandler(this.VersionNumber_Click);
            // 
            // PayPal_Link
            // 
            this.PayPal_Link.AutoSize = true;
            this.PayPal_Link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.PayPal_Link.Location = new System.Drawing.Point(14, 50);
            this.PayPal_Link.Name = "PayPal_Link";
            this.PayPal_Link.Size = new System.Drawing.Size(85, 13);
            this.PayPal_Link.TabIndex = 9;
            this.PayPal_Link.TabStop = true;
            this.PayPal_Link.Text = "Paypal Donation";
            this.PayPal_Link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.PayPal_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PayPal_Link_LinkClicked);
            // 
            // CheckUpdateLabel
            // 
            this.CheckUpdateLabel.AutoSize = true;
            this.CheckUpdateLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.CheckUpdateLabel.Location = new System.Drawing.Point(453, 28);
            this.CheckUpdateLabel.Name = "CheckUpdateLabel";
            this.CheckUpdateLabel.Size = new System.Drawing.Size(76, 13);
            this.CheckUpdateLabel.TabIndex = 10;
            this.CheckUpdateLabel.TabStop = true;
            this.CheckUpdateLabel.Text = "Check Update";
            this.CheckUpdateLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.CheckUpdateLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PrefixHelp
            // 
            this.PrefixHelp.Font = new System.Drawing.Font("Bahnschrift Light", 6F);
            this.PrefixHelp.Location = new System.Drawing.Point(71, 93);
            this.PrefixHelp.Name = "PrefixHelp";
            this.PrefixHelp.Size = new System.Drawing.Size(20, 19);
            this.PrefixHelp.TabIndex = 11;
            this.PrefixHelp.Text = "?";
            this.PrefixHelp.UseVisualStyleBackColor = true;
            this.PrefixHelp.Click += new System.EventHandler(this.PrefixHelp_Click);
            // 
            // InputTextHelp
            // 
            this.InputTextHelp.Font = new System.Drawing.Font("Bahnschrift Light", 6F);
            this.InputTextHelp.Location = new System.Drawing.Point(97, 157);
            this.InputTextHelp.Name = "InputTextHelp";
            this.InputTextHelp.Size = new System.Drawing.Size(20, 19);
            this.InputTextHelp.TabIndex = 12;
            this.InputTextHelp.Text = "?";
            this.InputTextHelp.UseVisualStyleBackColor = true;
            this.InputTextHelp.Click += new System.EventHandler(this.InputTextHelp_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IntervalHelp
            // 
            this.IntervalHelp.Font = new System.Drawing.Font("Bahnschrift Light", 6F);
            this.IntervalHelp.Location = new System.Drawing.Point(352, 93);
            this.IntervalHelp.Name = "IntervalHelp";
            this.IntervalHelp.Size = new System.Drawing.Size(20, 19);
            this.IntervalHelp.TabIndex = 14;
            this.IntervalHelp.Text = "?";
            this.IntervalHelp.UseVisualStyleBackColor = true;
            this.IntervalHelp.Click += new System.EventHandler(this.IntervalHelp_Click);
            // 
            // interval10
            // 
            this.interval10.Font = new System.Drawing.Font("Bahnschrift Light", 8.5F);
            this.interval10.Location = new System.Drawing.Point(282, 118);
            this.interval10.Name = "interval10";
            this.interval10.Size = new System.Drawing.Size(64, 28);
            this.interval10.TabIndex = 15;
            this.interval10.Text = "10";
            this.interval10.UseVisualStyleBackColor = true;
            this.interval10.Click += new System.EventHandler(this.interval10_Click);
            // 
            // Interval100
            // 
            this.Interval100.Font = new System.Drawing.Font("Bahnschrift Light", 8.5F);
            this.Interval100.Location = new System.Drawing.Point(352, 118);
            this.Interval100.Name = "Interval100";
            this.Interval100.Size = new System.Drawing.Size(64, 28);
            this.Interval100.TabIndex = 16;
            this.Interval100.Text = "100";
            this.Interval100.UseVisualStyleBackColor = true;
            this.Interval100.Click += new System.EventHandler(this.Interval100_Click);
            // 
            // Interval1000
            // 
            this.Interval1000.Font = new System.Drawing.Font("Bahnschrift Light", 8.5F);
            this.Interval1000.Location = new System.Drawing.Point(425, 118);
            this.Interval1000.Name = "Interval1000";
            this.Interval1000.Size = new System.Drawing.Size(64, 28);
            this.Interval1000.TabIndex = 17;
            this.Interval1000.Text = "1000";
            this.Interval1000.UseVisualStyleBackColor = true;
            this.Interval1000.Click += new System.EventHandler(this.Interval1000_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(532, 258);
            this.Controls.Add(this.Interval1000);
            this.Controls.Add(this.Interval100);
            this.Controls.Add(this.interval10);
            this.Controls.Add(this.IntervalHelp);
            this.Controls.Add(Interval);
            this.Controls.Add(this.InputTextHelp);
            this.Controls.Add(this.PrefixHelp);
            this.Controls.Add(this.CheckUpdateLabel);
            this.Controls.Add(this.PayPal_Link);
            this.Controls.Add(this.VersionNumber);
            this.Controls.Add(this.StopSpam);
            this.Controls.Add(this.StartSpam);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.PrefixText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.PrefixLable);
            this.Controls.Add(this.UI_Name);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "SP4MM3R_";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Name;
        private System.Windows.Forms.Label PrefixLable;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox PrefixText;
        private System.Windows.Forms.RichTextBox InputText;
        private System.Windows.Forms.Button StartSpam;
        private System.Windows.Forms.Button StopSpam;
        private System.Windows.Forms.Label VersionNumber;
        private System.Windows.Forms.LinkLabel PayPal_Link;
        private System.Windows.Forms.LinkLabel CheckUpdateLabel;
        private System.Windows.Forms.Button PrefixHelp;
        private System.Windows.Forms.Button InputTextHelp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button IntervalHelp;
        private System.Windows.Forms.Button interval10;
        private System.Windows.Forms.Button Interval100;
        private System.Windows.Forms.Button Interval1000;
    }
}

