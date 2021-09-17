using Discord.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord
{
    public partial class LoginForm : Form
    {
        string mail;
        string login;
        string password;
        private DBConnect db = new DBConnect();
        public LoginForm()
        {
            InitializeComponent();
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            panel2.Left = (this.ClientSize.Width - panel2.Width) / 2;
            panel2.Top = (this.ClientSize.Height - panel2.Height) / 2;
            label6.Left = (this.panel2.Width - label6.Width) / 2;
            for(int i = 1; i <= 31; i++)
            {
                btComboBox1.Items.Add(i);
            }
            for (int i = 2018; i >= 1869; i--)
            {
                btComboBox3.Items.Add(i);
            }
            button1.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = btTextBox1.Texts;
            password = btTextBox2.Texts;
            var all = db.Auth(login, password);
            int id = all.Item1;
            string username = all.Item2;
            byte[] image = all.Item3;
            if (id>0)
            {
                this.Hide();
                var form1 = new Form1(id,username,image);
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
            else
            {
                btTextBox1.BorderColor = Color.Red;
                btTextBox2.BorderColor = Color.Red;
                label3.Text = "EMAIL - Mail or password is invalid.";
                label4.Text = "PASSWORD - Mail or password is invalid.";
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool email = false;
            bool password = false;
            bool username = false;
            if (!string.IsNullOrWhiteSpace(btTextBox3.Texts) && !string.IsNullOrWhiteSpace(btTextBox4.Texts) && !string.IsNullOrWhiteSpace(btTextBox5.Texts) && btComboBox1.SelectedIndex>-1 && btComboBox2.SelectedIndex>-1 && btComboBox3.SelectedIndex>-1 && checkBox1.Checked)
            {
                if(btTextBox4.Texts.Length<2 || btTextBox4.Texts.Length > 32)
                {
                    eerror(btTextBox4, label8, "USERNAME - Must be between 2 and 32 in length");
                    username = false;
                }
                else
                {
                    nerror(btTextBox4, label8, "USERNAME");
                    username = true;
                }
                if (btTextBox5.Texts.Length < 6)
                {
                    eerror(btTextBox5, label9, "PASSWORD - Must be 6 or more in length");
                    password = false;
                }
                else
                {
                    nerror(btTextBox5, label9, "PASSWORD");
                    password = true;
                }
                try
                {
                    var addr = new System.Net.Mail.MailAddress(btTextBox3.Texts);
                    email = true;
                    nerror(btTextBox3, label7, "EMAIL");
                }
                catch
                {
                    email = false;
                    eerror(btTextBox3, label7, "EMAIL - Incorrect");
                }
                if (email && password && username)
                {
                    int error = db.IsUserExist(btTextBox3.Texts);
                    MessageBox.Show(error.ToString());
                    if (error == 0)
                    {
                        if (db.AddUser(btTextBox3.Texts, btTextBox4.Texts, btTextBox5.Texts, btComboBox1.Texts, btComboBox2.Texts, btComboBox3.Texts))
                        {
                            var all = db.Auth(btTextBox3.Texts, btTextBox5.Texts);
                            int id = all.Item1;
                            string nickname = all.Item2;
                            byte[] image = all.Item3;
                            if (id > 0)
                            {
                                this.Hide();
                                var form1 = new Form1(id, nickname, image);
                                form1.Closed += (s, args) => this.Close();
                                form1.Show();
                            }
                        }
                    }
                    else if (error == 1)
                    {
                        eerror(btTextBox3, label7, "EMAIL - Is in use");
                    }
                }
            }
        }
        private void eerror(BTTextBox bTTextBox,Label label, string text)
        {
            bTTextBox.BorderColor = Color.Red;
            label.ForeColor = Color.Red;
            label8.Text = text;
        }
        private void nerror(BTTextBox bTTextBox, Label label, string text)
        {
            bTTextBox.BorderColor = Color.FromArgb(34, 36, 40);
            label.ForeColor = Color.FromArgb(165, 167, 171);
            label.Text = text;
        }
    }
}
