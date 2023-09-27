using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace GP_Login_System
{
    public partial class Register : UserControl
    {
        public Register()
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

            if (Textbox_RePassword.PasswordChar == '•')
            {
                Textbox_RePassword.PasswordChar = '\0';
            }
            else if (Textbox_RePassword.PasswordChar == '\0')
            {
                Textbox_RePassword.PasswordChar = '•';
            }
        }

        private void Button_BackToLogin_Click(object sender, EventArgs e)
        {
            if (Program.LoginSys.Panel_Portal.Visible == false)
            {
                Program.LoginSys.Panel_Register.Visible = false;
                Program.LoginSys.Panel_Register.SendToBack();
                Program.LoginSys.Panel_Portal.Visible = true;
                Program.LoginSys.Panel_Portal.BringToFront();
            }
        }

        private void Button_Register_MouseEnter(object sender, EventArgs e)
        {
            Button_Register.BorderRadius = 13;
        }

        private void Button_Register_MouseLeave(object sender, EventArgs e)
        {
            Button_Register.BorderRadius = 23;
        }

        private void Button_BackToLogin_MouseEnter(object sender, EventArgs e)
        {
            Button_BackToLogin.BorderRadius = 13;
        }

        private void Button_BackToLogin_MouseLeave(object sender, EventArgs e)
        {
            Button_BackToLogin.BorderRadius = 23;
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            if (Textbox_Email.Text.Trim() == String.Empty || Textbox_Password.Text.Trim() == String.Empty || Textbox_RePassword.Text.Trim() == String.Empty
                || Textbox_Username.Text.Trim() == String.Empty)
            {
                this.Invoke(new Action(() => {
                    LogLabel.Visible = true;
                    LogLabel.ForeColor = Color.DeepSkyBlue;
                    LogLabel.Text = "MAKE SURE ALL THE AREAS ARE FILLED.";
                }));
            }
            else
            {
                if (Textbox_RePassword.Text == Textbox_Password.Text)
                {
                    this.Invoke(new Action(() => {
                        LogLabel.Visible = true;
                        LogLabel.ForeColor = Color.DeepSkyBlue;
                        LogLabel.Text = "REGISTERING A NEW ACCOUNT..";
                        RegisterEvent.RunWorkerAsync();
                    }));
                }
                else
                {
                    this.Invoke(new Action(() => {
                        LogLabel.Visible = true;
                        LogLabel.ForeColor = Color.Red;
                        LogLabel.Text = "THE PASSWORDS YOU PROVIDED DO NOT MATCH.";
                    }));
                }
            }
            
        }

        private void RegisterEvent_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
            string RootFolder = @"%APPDATA%\GPLogin\Users\";
            RootFolder = Environment.ExpandEnvironmentVariables(RootFolder);

            string UserFolder = RootFolder + Textbox_Username.Text + @"\";
            string UserLoginFolder = UserFolder + "Login";
            string UpperCaseUser = Textbox_Username.Text.ToUpper();


            if (!Directory.Exists(UserLoginFolder))
            {
                Directory.CreateDirectory(UserLoginFolder);

                if (!Directory.Exists(RootFolder))
                {
                    Directory.CreateDirectory(RootFolder);
                }
                if (!Directory.Exists(UserFolder))
                {
                    Directory.CreateDirectory(UserFolder);
                }

                var sw = new StreamWriter(UserLoginFolder + "\\Login.txt");

                sw.WriteLine(Textbox_Username.Text);
                sw.WriteLine(Textbox_Password.Text);
                sw.WriteLine(Textbox_Email.Text);
                sw.Close();

                this.Invoke(new Action(() => {
                    LogLabel.Visible = true;
                    LogLabel.ForeColor = Color.Goldenrod;
                    LogLabel.Text = "USER WAS REGISTERED SUCCESSFULLY. WELCOME TO GP LOGIN SYSTEM - " + UpperCaseUser;
                }));
            }
            else if (Directory.Exists(UserLoginFolder))
            {
                this.Invoke(new Action(() => {
                    LogLabel.Visible = true;
                    LogLabel.ForeColor = Color.Red;
                    LogLabel.Text = "THIS USER IS ALREADY A MEMBER OF GP LOGIN SYSTEM.";
                }));
            }                        
        }

        private void RegisterEvent_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }
    }
}
