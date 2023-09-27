using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace GP_Login_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Form drop shadow
            FormShadow.SetShadowForm(this);

            // fade in animation when the form is open (Timer loop)
            StartupAnimation.Start();

            

        }

        private void Button_CloseForm_Click(object sender, EventArgs e)
        {
            // Close button
            this.Close();
        }

        private void Button_MinimizeForm_Click(object sender, EventArgs e)
        {
            // Minimize button
            this.WindowState = FormWindowState.Minimized;
        }

        private void StartupAnimation_Tick(object sender, EventArgs e)
        {
            this.Opacity += .05;
            if (this.Opacity == 1)
            {
                StartupAnimation.Stop();                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
