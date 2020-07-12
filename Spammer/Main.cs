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
            //Paypal Donation Link
            Process.Start("https://www.paypal.me/AddisonChua");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Update Check
            Process.Start("http://bit.ly/SP4MM3R");
        }

        private void PrefixHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Key to be pressed to chat in game                                                    (Leave the prefix blank if not needed)", "Prefix Help");
        }

        private void InputTextHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The text that you want to spam", "Input Text Help");
        }

        //Start Spammer
        private void StartSpam_Click(object sender, EventArgs e)

        {
            timer1.Enabled = true;
        }


        //Stop Spammer
        private void StopSpam_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Spam function
            SendKeys.Send(PrefixText.Text);
            SendKeys.Send(InputText.Text);
            SendKeys.Send("{Enter}");
           

        }

        private void IntervalHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Milliseconds diffence between 2 texts                                                    [1000 Ms = 1 Second]", "Interval Help");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void interval10_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10;
        }

        private void Interval100_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void Interval1000_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
