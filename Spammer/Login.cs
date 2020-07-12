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
using System.Net;

namespace Spammer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();


        }

        private void GetKey_Click(object sender, EventArgs e)
        {
            //Get Key
            Process.Start("http://festyy.com/wQVqyi");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string receive = wc.DownloadString("https://pastebin.com/raw/zSXtDhbY");
            string friend = wc.DownloadString("https://pastebin.com/raw/C45bAa1N");

            //Public UUID --------------------------

            if (receive.Contains(Key.Text))
            {

                MessageBox.Show("Welcome To SP4MM3R -[by AddisonIsGone]-", "Welcome");
                this.Hide();
                Main ss = new Main();
                ss.Show();


            }
            else
            {

                MessageBox.Show("Key is incorrect", "Incorrect");


            }

           





        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Key_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
