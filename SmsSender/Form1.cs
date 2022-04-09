using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Net;




namespace SmsSender
{
    public partial class Form1 : Form
    {

        string APIKey;
        string MessageProfileID;


        public Form1()
        {
            
            InitializeComponent();

            verifApiKey();
            verifProfileID();
            

        }


        private async void button1_Click(object sender, EventArgs e)
        {

            if (verifApiKey() && verifProfileID())
            {
                var url = "https://api.telnyx.com/v2/messages";

                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Method = "POST";

                httpRequest.ContentType = "application/json";
                httpRequest.Headers["Authorization"] = "Bearer " + APIKey;



                var data = "{";
                data += "             \"from\": \"" + senderTextBox.Text + "\",";


                data += "             \"to\": \"" + numberTextBox.Text + "\",";

                data += "             \"text\": \"" + smsTextBox.Text + "\",";

                data += "             \"messaging_profile_id\": \"" + MessageProfileID + "\"";

                data += "             }";

                


                

                

                //smsTextBox.Text = data;

                using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                {
                    streamWriter.Write(data);
                }

                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }

                Console.WriteLine(httpResponse.StatusCode);

                messageStatusLabel.ForeColor = System.Drawing.Color.Green;
                messageStatusLabel.Text = DateTime.Now.ToString("HH:mm:ss") + " -----> SMS SENT";



            } else
            {
                messageStatusLabel.ForeColor = System.Drawing.Color.Red;
                messageStatusLabel.Text = "Message not sent, please verify API Infos !";
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
        }

        bool verifApiKey()
        {
            if (File.Exists("apikey.txt"))
            {

                TextReader tr = new StreamReader("apikey.txt");
                // read lines of text
                string readApiKey = tr.ReadLine();

                if (readApiKey.Contains("KEY"))
                {
                    APIKey = readApiKey;

                    apiKeyStatusLabel.ForeColor = System.Drawing.Color.Green;
                    apiKeyStatusLabel.Text = "API Key : Found";

                    tr.Close();
                    return true;
                }

                apiKeyStatusLabel.ForeColor = System.Drawing.Color.Red;
                apiKeyStatusLabel.Text = "API Key : Not Found";
                // close the stream
                tr.Close();
                
                return false;

            }
            apiKeyStatusLabel.ForeColor = System.Drawing.Color.Red;
            apiKeyStatusLabel.Text = "API Key : Not Found";
            return false;
        }





        bool verifProfileID()
        {
            if (File.Exists("profileID.txt"))
            {

                TextReader tr = new StreamReader("profileID.txt");
                // read lines of text
                string readProfileID = tr.ReadLine();

                if (readProfileID.Contains("-") && readProfileID.Length > 8)
                {
                    MessageProfileID = readProfileID;

                    msgProfileIDStatusLabel.ForeColor = System.Drawing.Color.Green;
                    msgProfileIDStatusLabel.Text = "Msg Profile ID : Found";

                    tr.Close();
                    return true;
                }

                msgProfileIDStatusLabel.ForeColor = System.Drawing.Color.Red;
                msgProfileIDStatusLabel.Text = "Msg Profile ID : Not Found";
                // close the stream
                tr.Close();

                return false;

            }
            msgProfileIDStatusLabel.ForeColor = System.Drawing.Color.Red;
            msgProfileIDStatusLabel.Text = "Msg Profile ID : Not Found";

            return false;
        }




        private void refreshButton_Click(object sender, EventArgs e)
        {
            verifApiKey();
            verifProfileID();

        }
    }
}
