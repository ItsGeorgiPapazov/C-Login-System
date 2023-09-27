
namespace GP_Login_System
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.FormElipse = new Guna.UI2.WinForms.Guna2Elipse();
            this.Panel_Header = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LogoPicture1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Button_MinimizeForm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button_CloseForm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Credits = new System.Windows.Forms.Label();
            this.ResizeBox = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl();
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl();
            this.FormShadow = new Guna.UI2.WinForms.Guna2ShadowForm();
            this.StartupAnimation = new System.Windows.Forms.Timer();
            this.Panel_Portal = new GP_Login_System.Portal();
            this.Panel_Register = new GP_Login_System.Register();
            this.Panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormElipse
            // 
            this.FormElipse.BorderRadius = 20;
            this.FormElipse.TargetControl = this;
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Header.Controls.Add(this.TitleLabel);
            this.Panel_Header.Controls.Add(this.LogoPicture1);
            this.Panel_Header.Controls.Add(this.Button_MinimizeForm);
            this.Panel_Header.Controls.Add(this.Button_CloseForm);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.ShadowDecoration.Parent = this.Panel_Header;
            this.Panel_Header.Size = new System.Drawing.Size(678, 46);
            this.Panel_Header.TabIndex = 0;
            this.Panel_Header.UseTransparentBackground = true;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TitleLabel.Location = new System.Drawing.Point(58, 16);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(147, 13);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "GP LOGIN SYSTEM - LOGIN";
            // 
            // LogoPicture1
            // 
            this.LogoPicture1.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture1.Image")));
            this.LogoPicture1.Location = new System.Drawing.Point(16, 6);
            this.LogoPicture1.Name = "LogoPicture1";
            this.LogoPicture1.ShadowDecoration.Parent = this.LogoPicture1;
            this.LogoPicture1.Size = new System.Drawing.Size(30, 30);
            this.LogoPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicture1.TabIndex = 2;
            this.LogoPicture1.TabStop = false;
            // 
            // Button_MinimizeForm
            // 
            this.Button_MinimizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_MinimizeForm.Animated = true;
            this.Button_MinimizeForm.AutoRoundedCorners = true;
            this.Button_MinimizeForm.BorderRadius = 14;
            this.Button_MinimizeForm.CheckedState.Parent = this.Button_MinimizeForm;
            this.Button_MinimizeForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_MinimizeForm.CustomImages.Parent = this.Button_MinimizeForm;
            this.Button_MinimizeForm.FillColor = System.Drawing.Color.Transparent;
            this.Button_MinimizeForm.FillColor2 = System.Drawing.Color.Transparent;
            this.Button_MinimizeForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_MinimizeForm.ForeColor = System.Drawing.Color.White;
            this.Button_MinimizeForm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.Button_MinimizeForm.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(118)))));
            this.Button_MinimizeForm.HoverState.Parent = this.Button_MinimizeForm;
            this.Button_MinimizeForm.Image = ((System.Drawing.Image)(resources.GetObject("Button_MinimizeForm.Image")));
            this.Button_MinimizeForm.ImageSize = new System.Drawing.Size(15, 15);
            this.Button_MinimizeForm.Location = new System.Drawing.Point(606, 6);
            this.Button_MinimizeForm.Name = "Button_MinimizeForm";
            this.Button_MinimizeForm.ShadowDecoration.Parent = this.Button_MinimizeForm;
            this.Button_MinimizeForm.Size = new System.Drawing.Size(30, 30);
            this.Button_MinimizeForm.TabIndex = 3;
            this.Button_MinimizeForm.Click += new System.EventHandler(this.Button_MinimizeForm_Click);
            // 
            // Button_CloseForm
            // 
            this.Button_CloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_CloseForm.Animated = true;
            this.Button_CloseForm.AutoRoundedCorners = true;
            this.Button_CloseForm.BorderRadius = 14;
            this.Button_CloseForm.CheckedState.Parent = this.Button_CloseForm;
            this.Button_CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_CloseForm.CustomImages.Parent = this.Button_CloseForm;
            this.Button_CloseForm.FillColor = System.Drawing.Color.Transparent;
            this.Button_CloseForm.FillColor2 = System.Drawing.Color.Transparent;
            this.Button_CloseForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_CloseForm.ForeColor = System.Drawing.Color.White;
            this.Button_CloseForm.HoverState.FillColor = System.Drawing.Color.Red;
            this.Button_CloseForm.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(68)))));
            this.Button_CloseForm.HoverState.Parent = this.Button_CloseForm;
            this.Button_CloseForm.Image = ((System.Drawing.Image)(resources.GetObject("Button_CloseForm.Image")));
            this.Button_CloseForm.ImageSize = new System.Drawing.Size(15, 15);
            this.Button_CloseForm.Location = new System.Drawing.Point(638, 6);
            this.Button_CloseForm.Name = "Button_CloseForm";
            this.Button_CloseForm.ShadowDecoration.Parent = this.Button_CloseForm;
            this.Button_CloseForm.Size = new System.Drawing.Size(30, 30);
            this.Button_CloseForm.TabIndex = 2;
            this.Button_CloseForm.Click += new System.EventHandler(this.Button_CloseForm_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.Credits);
            this.guna2GradientPanel1.Controls.Add(this.ResizeBox);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 362);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(678, 49);
            this.guna2GradientPanel1.TabIndex = 1;
            this.guna2GradientPanel1.UseTransparentBackground = true;
            // 
            // Credits
            // 
            this.Credits.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Credits.AutoSize = true;
            this.Credits.BackColor = System.Drawing.Color.Transparent;
            this.Credits.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(112)))));
            this.Credits.Location = new System.Drawing.Point(206, 11);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(214, 26);
            this.Credits.TabIndex = 3;
            this.Credits.Text = "Coded and Designed by Georgi Papazov\r\n© All rights reserved 2023.";
            this.Credits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResizeBox
            // 
            this.ResizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResizeBox.BackColor = System.Drawing.Color.Transparent;
            this.ResizeBox.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.ResizeBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ResizeBox.ForeColor = System.Drawing.Color.Empty;
            this.ResizeBox.Location = new System.Drawing.Point(656, 26);
            this.ResizeBox.Name = "ResizeBox";
            this.ResizeBox.Size = new System.Drawing.Size(20, 20);
            this.ResizeBox.TabIndex = 0;
            this.ResizeBox.TargetControl = this;
            this.ResizeBox.UseTransparentBackground = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.LogoPicture1;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.TitleLabel;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.TargetControl = this.Panel_Header;
            // 
            // StartupAnimation
            // 
            this.StartupAnimation.Interval = 30;
            this.StartupAnimation.Tick += new System.EventHandler(this.StartupAnimation_Tick);
            // 
            // Panel_Portal
            // 
            this.Panel_Portal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_Portal.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Portal.Location = new System.Drawing.Point(0, 46);
            this.Panel_Portal.Name = "Panel_Portal";
            this.Panel_Portal.Size = new System.Drawing.Size(678, 314);
            this.Panel_Portal.TabIndex = 2;
            // 
            // Panel_Register
            // 
            this.Panel_Register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_Register.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Register.Location = new System.Drawing.Point(0, 46);
            this.Panel_Register.Name = "Panel_Register";
            this.Panel_Register.Size = new System.Drawing.Size(678, 314);
            this.Panel_Register.TabIndex = 3;
            this.Panel_Register.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 411);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.Panel_Header);
            this.Controls.Add(this.Panel_Portal);
            this.Controls.Add(this.Panel_Register);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(629, 396);
            this.Name = "Login";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login To GP Login System";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse FormElipse;
        private Guna.UI2.WinForms.Guna2GradientPanel Panel_Header;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton Button_CloseForm;
        private Guna.UI2.WinForms.Guna2GradientButton Button_MinimizeForm;
        private Guna.UI2.WinForms.Guna2PictureBox LogoPicture1;
        private System.Windows.Forms.Label TitleLabel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2ShadowForm FormShadow;
        private System.Windows.Forms.Timer StartupAnimation;
        private Guna.UI2.WinForms.Guna2ResizeBox ResizeBox;
        private System.Windows.Forms.Label Credits;
        public Portal Panel_Portal;
        public Register Panel_Register;
    }
}

