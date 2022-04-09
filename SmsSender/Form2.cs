using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmsSender
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();


            if (File.Exists("apikey.txt"))
            {

                TextReader tr = new StreamReader("apikey.txt");
                // read lines of text
                apiKeyTextBox.Text = tr.ReadLine();
                // close the stream
                tr.Close();

            }

            if (File.Exists("profileID.txt"))
            {

                TextReader tr = new StreamReader("profileID.txt");
                // read lines of text
                msgProfileTextBox.Text = tr.ReadLine();
                // close the stream
                tr.Close();

            }




        }

        public void saveApiKeyButton_Click(object sender, EventArgs e)
        {
            if (apiKeyTextBox.Text.Length > 0)
            {
                //Form1 forM1 = new Form1();
                //apiKeyTextBox.Text = forM1.apiKeyForm1();


                TextWriter tw = new StreamWriter("apikey.txt");

                // write lines of text to the file
                tw.WriteLine(apiKeyTextBox.Text);
                // close the stream     
                tw.Close();


                saveApiKeyButton.Text = "Saved !";


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (msgProfileTextBox.Text.Length > 0)
            {
                //Form1 forM1 = new Form1();
                //apiKeyTextBox.Text = forM1.apiKeyForm1();


                TextWriter tw = new StreamWriter("profileID.txt");

                // write lines of text to the file
                tw.WriteLine(msgProfileTextBox.Text);
                // close the stream     
                tw.Close();


                msgProfileButton.Text = "Saved !";


            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://portal.telnyx.com/#/app/api-keys");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://portal.telnyx.com/#/app/messaging");
        }
    }
}
