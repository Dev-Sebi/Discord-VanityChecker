using System;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace VanityChecker
{
    public partial class Form1 : Form
    {
        private string fileContent;

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("This version has no RateLimit control, please be carefull to not Abuse the Discord API!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(input.Text == "")
            {
                MessageBox.Show("No Input Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                input.Enabled = false;
                clear_input.Enabled = false;
                clear_valid.Enabled = false;
                clear_invalid.Enabled = false;
                Form1.ActiveForm.Text = "Checking...";
                String results_valid = "";
                String results_invalid = "";
                String all = input.Text;
                string[] vanitys = all.Split('\n');
                string tmp = "";
                foreach (string s in vanitys)
                {
                    if(s.StartsWith("https://discord.gg/"))
                    {
                        tmp = s.Replace("https://discord.gg/", "");
                    }
                    if (s.StartsWith("https://discord.com/invite/"))
                    {
                        tmp = s.Replace("https://discord.com/invite/", "");
                    }
                    else
                    {
                        tmp = s;
                    }
                    try
                    {
                        WebRequest request = WebRequest.Create("https://discord.com/api/v9/invites/" + s);
                        WebResponse response = request.GetResponse();
                        request.Method = "GET";
                        response.Close();
                        if (((HttpWebResponse)response).StatusDescription == "OK")
                        {
                            //valid
                            results_valid += "https://discord.gg/" + s + '\n';
                        }
                        else
                        {
                            //invalid
                            results_invalid += s + '\n';
                        }
                    }
                    catch(Exception ex)
                    {
                        //invalid
                        results_invalid += s + '\n';
                    }
                    valid.Text = results_valid;
                    invalid.Text = results_invalid;
                    input.Enabled = true;
                    clear_input.Enabled = true;
                    clear_valid.Enabled = true;
                    clear_invalid.Enabled = true;
                    Form1.ActiveForm.Text = "Discord Vanity Checker - By Sebi";
                }
            }
        }

        private void btn_openfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            input.Text = fileContent;
        }

        private void btn_invalid_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(invalid.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(valid.Text);
        }

        private void clear_input_Click(object sender, EventArgs e)
        {
            input.Text = "";
        }
        private void clear_invalid_Click(object sender, EventArgs e)
        {
            invalid.Text = "";
        }

        private void clear_valid_Click(object sender, EventArgs e)
        {
            valid.Text = "";
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            if (input.Text == "")
            {
                clear_input.Enabled = false;
            }
            else
            {
                clear_input.Enabled = true;
            }
        }

        private void invalid_TextChanged(object sender, EventArgs e)
        {
            if (invalid.Text == "")
            {
                clear_invalid.Enabled = false;
            }
            else
            {
                clear_invalid.Enabled = true;
            }
        }

        private void valid_TextChanged(object sender, EventArgs e)
        {
            if (valid.Text == "")
            {
                clear_valid.Enabled = false;
            }
            else
            {
                clear_valid.Enabled = true;
            }
        }
    }
}
