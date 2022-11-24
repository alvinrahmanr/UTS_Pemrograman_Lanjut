
namespace LoginRegister
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
            this.picbox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UsernameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox1
            // 
            this.picbox1.Image = ((System.Drawing.Image)(resources.GetObject("picbox1.Image")));
            this.picbox1.Location = new System.Drawing.Point(312, 141);
            this.picbox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picbox1.Name = "picbox1";
            this.picbox1.ShadowDecoration.Parent = this.picbox1;
            this.picbox1.Size = new System.Drawing.Size(614, 756);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox1.TabIndex = 0;
            this.picbox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = false;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Label1.Location = new System.Drawing.Point(1072, 141);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(273, 45);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Welcome back!";
            // 
            // UsernameTB
            // 
            this.UsernameTB.Animated = true;
            this.UsernameTB.AutoRoundedCorners = true;
            this.UsernameTB.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.UsernameTB.BorderRadius = 44;
            this.UsernameTB.BorderThickness = 2;
            this.UsernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTB.DefaultText = "";
            this.UsernameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTB.DisabledState.Parent = this.UsernameTB;
            this.UsernameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTB.FocusedState.Parent = this.UsernameTB;
            this.UsernameTB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTB.HoverState.Parent = this.UsernameTB;
            this.UsernameTB.IconLeft = ((System.Drawing.Image)(resources.GetObject("UsernameTB.IconLeft")));
            this.UsernameTB.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.UsernameTB.Location = new System.Drawing.Point(960, 234);
            this.UsernameTB.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.PasswordChar = '\0';
            this.UsernameTB.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UsernameTB.PlaceholderText = "Email";
            this.UsernameTB.SelectedText = "";
            this.UsernameTB.ShadowDecoration.Parent = this.UsernameTB;
            this.UsernameTB.Size = new System.Drawing.Size(498, 91);
            this.UsernameTB.TabIndex = 2;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Animated = true;
            this.PasswordTB.AutoRoundedCorners = true;
            this.PasswordTB.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.PasswordTB.BorderRadius = 44;
            this.PasswordTB.BorderThickness = 2;
            this.PasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTB.DefaultText = "";
            this.PasswordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTB.DisabledState.Parent = this.PasswordTB;
            this.PasswordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTB.FocusedState.Parent = this.PasswordTB;
            this.PasswordTB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTB.HoverState.Parent = this.PasswordTB;
            this.PasswordTB.IconLeft = ((System.Drawing.Image)(resources.GetObject("PasswordTB.IconLeft")));
            this.PasswordTB.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.PasswordTB.Location = new System.Drawing.Point(960, 347);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '\0';
            this.PasswordTB.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PasswordTB.PlaceholderText = "Password";
            this.PasswordTB.SelectedText = "";
            this.PasswordTB.ShadowDecoration.Parent = this.PasswordTB;
            this.PasswordTB.Size = new System.Drawing.Size(498, 91);
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.UseSystemPasswordChar = true;
            // 
            // loginbtn
            // 
            this.loginbtn.Animated = true;
            this.loginbtn.AutoRoundedCorners = true;
            this.loginbtn.BorderRadius = 44;
            this.loginbtn.CheckedState.Parent = this.loginbtn;
            this.loginbtn.CustomImages.Parent = this.loginbtn;
            this.loginbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.loginbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(44)))));
            this.loginbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.HoverState.Parent = this.loginbtn;
            this.loginbtn.Location = new System.Drawing.Point(1066, 509);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(6);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.ShadowDecoration.Parent = this.loginbtn;
            this.loginbtn.Size = new System.Drawing.Size(286, 91);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1724, 1123);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.picbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picbox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label1;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTB;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTB;
        private Guna.UI2.WinForms.Guna2GradientButton loginbtn;
    }
}

