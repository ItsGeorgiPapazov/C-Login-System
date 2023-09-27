using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_Login_System
{
    public partial class Portal : UserControl
    {
        public Portal()
        {
            InitializeComponent();
        }

        private void RevealPassword_Click(object sender, EventArgs e)
        {
            
            if (Textbox_Password.PasswordChar == '•')
            {
                Textbox_Password.PasswordChar = '\0';
            }
            else if (Textbox_Password.PasswordChar == '\0')
            {
                Textbox_Password.PasswordChar = '•';
            }
        }

        private void LoginEvent_DoWork(object sender, DoWorkEventArgs e)
        {
            // Login event

            Thread.Sleep(1000);
            string RootFolder = @"%APPDATA%\GPLogin\Users\";
            RootFolder = Environment.ExpandEnvironmentVariables(RootFolder);

            string UserFolder = RootFolder + Textbox_Login.Text + @"\";
            string UserLoginFolder = UserFolder + "Login";

            if (!Directory.Exists(RootFolder))
            {
                Directory.CreateDirectory(RootFolder);
            }

            if (!Directory.Exists(UserFolder))
            {
                // In case the user doesn't exist
                this.Invoke(new Action(() => {
                    LogLabel.Visible = true;
                    LogLabel.ForeColor = Color.Red;
                    LogLabel.Text = "THE USER YOU'VE PROVIDED IS NOT A MEMBER OF GP LOGIN SYSTEM.";
                }));
            }
            else if (Directory.Exists(UserFolder))
            {
                // In case the user exist
                var sr = new StreamReader(UserLoginFolder + "\\Login.txt");
                string encusr = sr.ReadLine();
                string encpass = sr.ReadLine();
                sr.Close();

                if (Textbox_Login.Text == encusr && Textbox_Password.Text == encpass)
                {
                    // Successfully logged in 
                    string UpperCaseUser = Textbox_Login.Text.ToUpper();
                    this.Invoke(new Action(() => {
                        LogLabel.Visible = true;
                        LogLabel.ForeColor = Color.DeepSkyBlue;
                        LogLabel.Text = "WELCOME BACK " + "'" + UpperCaseUser + "'";
                    }));
                }
                else
                {
                    // Wrong username or password
                    this.Invoke(new Action(() => {
                        LogLabel.Visible = true;
                        LogLabel.ForeColor = Color.Red;
                        LogLabel.Text = "THE CREDENTIALS YOU WROTE DO NOT MATCH.";
                    }));
                }
            }
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            if (Textbox_Login.Text.Trim() == String.Empty || Textbox_Password.Text.Trim() == String.Empty)
            {
                // in case username or password is empty 
                LogLabel.Visible = true;
                LogLabel.ForeColor = Color.FromArgb(172, 171, 197);
                LogLabel.Text = "PLEASE MAKE SURE YOU FILL IN YOUR LOGIN INFORMATION.";
            }
            else
            {
                string UpperCaseUser = Textbox_Login.Text.ToUpper();
                LogLabel.Visible = true;
                LogLabel.ForeColor = Color.Goldenrod;
                LogLabel.Text = "CONNECTING TO " + "'" + UpperCaseUser + "'..";
                LoginEvent.RunWorkerAsync();
            }
        }

        private void Button_Login_MouseEnter(object sender, EventArgs e)
        {
            Button_Login.BorderRadius = 13;
        }

        private void Button_Login_MouseLeave(object sender, EventArgs e)
        {
            Button_Login.BorderRadius = 23;
        }

        private void Button_Register_MouseEnter(object sender, EventArgs e)
        {
            Button_Register.BorderRadius = 13;
        }

        private void Button_Register_MouseLeave(object sender, EventArgs e)
        {
            Button_Register.BorderRadius = 23;
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            if (Program.LoginSys.Panel_Register.Visible == false)
            {
                Program.LoginSys.Panel_Portal.Visible = false;
                Program.LoginSys.Panel_Portal.SendToBack();
                Program.LoginSys.Panel_Register.Visible = true;
                Program.LoginSys.Panel_Register.BringToFront();
            }            
        }
    }
}
