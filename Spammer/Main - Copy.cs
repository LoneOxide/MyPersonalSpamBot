using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Spammer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Underline_Click(object sender, EventArgs e)
        {

        }

        private void UI_Name_Click(object sender, EventArgs e)
        {

        }

        private void TextLabel_Click(object sender, EventArgs e)
        {

        }

        private void VersionNumber_Click(object sender, EventArgs e)
        {

        }

        private void PayPal_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.paypal.me/AddisonChua");
        }
    }
}
