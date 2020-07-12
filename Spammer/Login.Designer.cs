namespace Spammer
{
    partial class Login
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
            this.UI_Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VersionNumber = new System.Windows.Forms.Label();
            this.Key = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetKey = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PayPal_Link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // UI_Name
            // 
            this.UI_Name.AutoSize = true;
            this.UI_Name.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(65)))), ((int)(((byte)(113)))));
            this.UI_Name.Location = new System.Drawing.Point(12, 9);
            this.UI_Name.Name = "UI_Name";
            this.UI_Name.Size = new System.Drawing.Size(97, 23);
            this.UI_Name.TabIndex = 1;
            this.UI_Name.Text = "SP4MM3R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Made By : AddisonIsGone";
            // 
            // VersionNumber
            // 
            this.VersionNumber.AutoSize = true;
            this.VersionNumber.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionNumber.ForeColor = System.Drawing.Color.Red;
            this.VersionNumber.Location = new System.Drawing.Point(247, 0);
            this.VersionNumber.Name = "VersionNumber";
            this.VersionNumber.Size = new System.Drawing.Size(36, 19);
            this.VersionNumber.TabIndex = 9;
            this.VersionNumber.Text = "V0.1";
            // 
            // Key
            // 
            this.Key.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Key.Location = new System.Drawing.Point(16, 114);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(256, 33);
            this.Key.TabIndex = 10;
            this.Key.Text = "";
            this.Key.TextChanged += new System.EventHandler(this.Key_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter Key :";
            // 
            // GetKey
            // 
            this.GetKey.Location = new System.Drawing.Point(197, 153);
            this.GetKey.Name = "GetKey";
            this.GetKey.Size = new System.Drawing.Size(75, 23);
            this.GetKey.TabIndex = 12;
            this.GetKey.Text = "Get Key";
            this.GetKey.UseVisualStyleBackColor = true;
            this.GetKey.Click += new System.EventHandler(this.GetKey_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(16, 153);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 13;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PayPal_Link
            // 
            this.PayPal_Link.AutoSize = true;
            this.PayPal_Link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.PayPal_Link.Location = new System.Drawing.Point(6, 248);
            this.PayPal_Link.Name = "PayPal_Link";
            this.PayPal_Link.Size = new System.Drawing.Size(85, 13);
            this.PayPal_Link.TabIndex = 14;
            this.PayPal_Link.TabStop = true;
            this.PayPal_Link.Text = "Paypal Donation";
            this.PayPal_Link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(284, 270);
            this.Controls.Add(this.PayPal_Link);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.GetKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.VersionNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UI_Name);
            this.Name = "Login";
            this.ShowIcon = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label VersionNumber;
        private System.Windows.Forms.RichTextBox Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetKey;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel PayPal_Link;
    }
}