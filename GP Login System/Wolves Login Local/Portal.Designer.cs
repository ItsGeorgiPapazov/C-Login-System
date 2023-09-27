
namespace GP_Login_System
{
    partial class Portal
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portal));
            this.RevealPassword = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LogLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Register = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button_Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Textbox_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Textbox_Login = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginEvent = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RevealPassword
            // 
            this.RevealPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RevealPassword.Animated = true;
            this.RevealPassword.AutoRoundedCorners = true;
            this.RevealPassword.BackColor = System.Drawing.Color.Transparent;
            this.RevealPassword.BorderRadius = 14;
            this.RevealPassword.CheckedState.Parent = this.RevealPassword;
            this.RevealPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevealPassword.CustomImages.Parent = this.RevealPassword;
            this.RevealPassword.FillColor = System.Drawing.Color.Transparent;
            this.RevealPassword.FillColor2 = System.Drawing.Color.Transparent;
            this.RevealPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RevealPassword.ForeColor = System.Drawing.Color.White;
            this.RevealPassword.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("RevealPassword.HoverState.Image")));
            this.RevealPassword.HoverState.Parent = this.RevealPassword;
            this.RevealPassword.Image = ((System.Drawing.Image)(resources.GetObject("RevealPassword.Image")));
            this.RevealPassword.ImageSize = new System.Drawing.Size(21, 21);
            this.RevealPassword.Location = new System.Drawing.Point(467, 182);
            this.RevealPassword.Name = "RevealPassword";
            this.RevealPassword.ShadowDecoration.Parent = this.RevealPassword;
            this.RevealPassword.Size = new System.Drawing.Size(31, 31);
            this.RevealPassword.TabIndex = 11;
            this.RevealPassword.UseTransparentBackground = true;
            this.RevealPassword.Click += new System.EventHandler(this.RevealPassword_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.LogLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(180, 281);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 30);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // LogLabel
            // 
            this.LogLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogLabel.AutoSize = true;
            this.LogLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(171)))), ((int)(((byte)(197)))));
            this.LogLabel.Location = new System.Drawing.Point(125, 7);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(68, 15);
            this.LogLabel.TabIndex = 4;
            this.LogLabel.Text = "LOGIN LOG";
            this.LogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(232, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "LOGIN TO GP LOGIN SYSTEM";
            // 
            // Button_Register
            // 
            this.Button_Register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Register.Animated = true;
            this.Button_Register.BorderRadius = 23;
            this.Button_Register.CheckedState.Parent = this.Button_Register;
            this.Button_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Register.CustomImages.Parent = this.Button_Register;
            this.Button_Register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(83)))));
            this.Button_Register.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(4)))));
            this.Button_Register.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Register.ForeColor = System.Drawing.Color.White;
            this.Button_Register.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.Button_Register.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            this.Button_Register.HoverState.Parent = this.Button_Register;
            this.Button_Register.Image = ((System.Drawing.Image)(resources.GetObject("Button_Register.Image")));
            this.Button_Register.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Button_Register.ImageOffset = new System.Drawing.Point(2, 0);
            this.Button_Register.Location = new System.Drawing.Point(340, 233);
            this.Button_Register.Name = "Button_Register";
            this.Button_Register.ShadowDecoration.Parent = this.Button_Register;
            this.Button_Register.Size = new System.Drawing.Size(158, 45);
            this.Button_Register.TabIndex = 17;
            this.Button_Register.Text = "REGISTER";
            this.Button_Register.TextOffset = new System.Drawing.Point(-3, 1);
            this.Button_Register.Click += new System.EventHandler(this.Button_Register_Click);
            this.Button_Register.MouseEnter += new System.EventHandler(this.Button_Register_MouseEnter);
            this.Button_Register.MouseLeave += new System.EventHandler(this.Button_Register_MouseLeave);
            // 
            // Button_Login
            // 
            this.Button_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Login.Animated = true;
            this.Button_Login.BorderRadius = 23;
            this.Button_Login.CheckedState.Parent = this.Button_Login;
            this.Button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Login.CustomImages.Parent = this.Button_Login;
            this.Button_Login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Login.ForeColor = System.Drawing.Color.White;
            this.Button_Login.HoverState.Parent = this.Button_Login;
            this.Button_Login.Image = ((System.Drawing.Image)(resources.GetObject("Button_Login.Image")));
            this.Button_Login.ImageOffset = new System.Drawing.Point(-2, 0);
            this.Button_Login.ImageSize = new System.Drawing.Size(25, 25);
            this.Button_Login.Location = new System.Drawing.Point(180, 233);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.ShadowDecoration.Parent = this.Button_Login;
            this.Button_Login.Size = new System.Drawing.Size(154, 45);
            this.Button_Login.TabIndex = 14;
            this.Button_Login.Text = "LOGIN";
            this.Button_Login.TextOffset = new System.Drawing.Point(-3, 1);
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            this.Button_Login.MouseEnter += new System.EventHandler(this.Button_Login_MouseEnter);
            this.Button_Login.MouseLeave += new System.EventHandler(this.Button_Login_MouseLeave);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(305, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(65, 65);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(199, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "PASSWORD";
            // 
            // Textbox_Password
            // 
            this.Textbox_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Textbox_Password.Animated = true;
            this.Textbox_Password.AutoRoundedCorners = true;
            this.Textbox_Password.BackColor = System.Drawing.Color.Transparent;
            this.Textbox_Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.Textbox_Password.BorderRadius = 14;
            this.Textbox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_Password.DefaultText = "";
            this.Textbox_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Textbox_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Textbox_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_Password.DisabledState.Parent = this.Textbox_Password;
            this.Textbox_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_Password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.Textbox_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(117)))), ((int)(((byte)(179)))));
            this.Textbox_Password.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.Textbox_Password.FocusedState.Parent = this.Textbox_Password;
            this.Textbox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(203)))));
            this.Textbox_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(117)))), ((int)(((byte)(179)))));
            this.Textbox_Password.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.Textbox_Password.HoverState.Parent = this.Textbox_Password;
            this.Textbox_Password.Location = new System.Drawing.Point(180, 182);
            this.Textbox_Password.Name = "Textbox_Password";
            this.Textbox_Password.PasswordChar = '•';
            this.Textbox_Password.PlaceholderText = "Password";
            this.Textbox_Password.SelectedText = "";
            this.Textbox_Password.ShadowDecoration.Parent = this.Textbox_Password;
            this.Textbox_Password.Size = new System.Drawing.Size(279, 31);
            this.Textbox_Password.TabIndex = 9;
            this.Textbox_Password.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(199, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "LOGIN";
            // 
            // Textbox_Login
            // 
            this.Textbox_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Textbox_Login.Animated = true;
            this.Textbox_Login.AutoRoundedCorners = true;
            this.Textbox_Login.BackColor = System.Drawing.Color.Transparent;
            this.Textbox_Login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.Textbox_Login.BorderRadius = 14;
            this.Textbox_Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_Login.DefaultText = "";
            this.Textbox_Login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Textbox_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Textbox_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_Login.DisabledState.Parent = this.Textbox_Login;
            this.Textbox_Login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.Textbox_Login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(117)))), ((int)(((byte)(179)))));
            this.Textbox_Login.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.Textbox_Login.FocusedState.Parent = this.Textbox_Login;
            this.Textbox_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(203)))));
            this.Textbox_Login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(117)))), ((int)(((byte)(179)))));
            this.Textbox_Login.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.Textbox_Login.HoverState.Parent = this.Textbox_Login;
            this.Textbox_Login.Location = new System.Drawing.Point(180, 122);
            this.Textbox_Login.Name = "Textbox_Login";
            this.Textbox_Login.PasswordChar = '\0';
            this.Textbox_Login.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(126)))), ((int)(((byte)(152)))));
            this.Textbox_Login.PlaceholderText = "Login";
            this.Textbox_Login.SelectedText = "";
            this.Textbox_Login.ShadowDecoration.Parent = this.Textbox_Login;
            this.Textbox_Login.Size = new System.Drawing.Size(318, 31);
            this.Textbox_Login.TabIndex = 8;
            this.Textbox_Login.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // LoginEvent
            // 
            this.LoginEvent.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LoginEvent_DoWork);
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.RevealPassword);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button_Register);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Textbox_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Textbox_Login);
            this.Name = "Portal";
            this.Size = new System.Drawing.Size(678, 314);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton RevealPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton Button_Register;
        private Guna.UI2.WinForms.Guna2GradientButton Button_Login;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox Textbox_Password;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Textbox_Login;
        private System.ComponentModel.BackgroundWorker LoginEvent;
    }
}
