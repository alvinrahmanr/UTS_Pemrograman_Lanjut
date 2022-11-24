
namespace LoginRegister
{
    partial class SignUp
    {
        
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.signupbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PasswordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.fnameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picbox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lnameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTB2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTB = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signupbtn
            // 
            this.signupbtn.Animated = true;
            this.signupbtn.AutoRoundedCorners = true;
            this.signupbtn.BorderRadius = 45;
            this.signupbtn.CheckedState.Parent = this.signupbtn;
            this.signupbtn.CustomImages.Parent = this.signupbtn;
            this.signupbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.signupbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(44)))));
            this.signupbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.ForeColor = System.Drawing.Color.White;
            this.signupbtn.HoverState.Parent = this.signupbtn;
            this.signupbtn.Location = new System.Drawing.Point(1128, 717);
            this.signupbtn.Margin = new System.Windows.Forms.Padding(6);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.ShadowDecoration.Parent = this.signupbtn;
            this.signupbtn.Size = new System.Drawing.Size(306, 93);
            this.signupbtn.TabIndex = 12;
            this.signupbtn.Text = "Sign Up";
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Animated = true;
            this.PasswordTB.AutoRoundedCorners = true;
            this.PasswordTB.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.PasswordTB.BorderRadius = 45;
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
            this.PasswordTB.Location = new System.Drawing.Point(1024, 261);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '\0';
            this.PasswordTB.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PasswordTB.PlaceholderText = "Password";
            this.PasswordTB.SelectedText = "";
            this.PasswordTB.ShadowDecoration.Parent = this.PasswordTB;
            this.PasswordTB.Size = new System.Drawing.Size(531, 93);
            this.PasswordTB.TabIndex = 10;
            this.PasswordTB.UseSystemPasswordChar = true;
            // 
            // fnameTB
            // 
            this.fnameTB.Animated = true;
            this.fnameTB.AutoRoundedCorners = true;
            this.fnameTB.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.fnameTB.BorderRadius = 45;
            this.fnameTB.BorderThickness = 2;
            this.fnameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fnameTB.DefaultText = "";
            this.fnameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fnameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fnameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fnameTB.DisabledState.Parent = this.fnameTB;
            this.fnameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fnameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fnameTB.FocusedState.Parent = this.fnameTB;
            this.fnameTB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fnameTB.HoverState.Parent = this.fnameTB;
            this.fnameTB.IconLeft = ((System.Drawing.Image)(resources.GetObject("fnameTB.IconLeft")));
            this.fnameTB.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.fnameTB.Location = new System.Drawing.Point(1024, 146);
            this.fnameTB.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.fnameTB.Name = "fnameTB";
            this.fnameTB.PasswordChar = '\0';
            this.fnameTB.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fnameTB.PlaceholderText = "First name";
            this.fnameTB.SelectedText = "";
            this.fnameTB.ShadowDecoration.Parent = this.fnameTB;
            this.fnameTB.Size = new System.Drawing.Size(301, 93);
            this.fnameTB.TabIndex = 11;
            // 
            // Label1
            // 
            this.Label1.AutoSize = false;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Label1.Location = new System.Drawing.Point(1222, 61);
            this.Label1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(136, 46);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Join us!";
            // 
            // picbox1
            // 
            this.picbox1.Image = ((System.Drawing.Image)(resources.GetObject("picbox1.Image")));
            this.picbox1.Location = new System.Drawing.Point(333, 144);
            this.picbox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.picbox1.Name = "picbox1";
            this.picbox1.ShadowDecoration.Parent = this.picbox1;
            this.picbox1.Size = new System.Drawing.Size(654, 774);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox1.TabIndex = 6;
            this.picbox1.TabStop = false;
            // 
            // lnameTB
            // 
            this.lnameTB.Animated = true;
            this.lnameTB.AutoRoundedCorners = true;
            this.lnameTB.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lnameTB.BorderRadius = 45;
            this.lnameTB.BorderThickness = 2;
            this.lnameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lnameTB.DefaultText = "";
            this.lnameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lnameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lnameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lnameTB.DisabledState.Parent = this.lnameTB;
            this.lnameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lnameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lnameTB.FocusedState.Parent = this.lnameTB;
            this.lnameTB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lnameTB.HoverState.Parent = this.lnameTB;
            this.lnameTB.IconLeft = ((System.Drawing.Image)(resources.GetObject("lnameTB.IconLeft")));
            this.lnameTB.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.lnameTB.Location = new System.Drawing.Point(1330, 146);
            this.lnameTB.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.lnameTB.Name = "lnameTB";
            this.lnameTB.PasswordChar = '\0';
            this.lnameTB.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lnameTB.PlaceholderText = "Last";
            this.lnameTB.SelectedText = "";
            this.lnameTB.ShadowDecoration.Parent = this.lnameTB;
            this.lnameTB.Size = new System.Drawing.Size(226, 93);
            this.lnameTB.TabIndex = 11;
            // 
            // PasswordTB2
            // 
            this.PasswordTB2.Animated = true;
            this.PasswordTB2.AutoRoundedCorners = true;
            this.PasswordTB2.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.PasswordTB2.BorderRadius = 45;
            this.PasswordTB2.BorderThickness = 2;
            this.PasswordTB2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTB2.DefaultText = "";
            this.PasswordTB2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTB2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTB2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTB2.DisabledState.Parent = this.PasswordTB2;
            this.PasswordTB2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTB2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTB2.FocusedState.Parent = this.PasswordTB2;
            this.PasswordTB2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTB2.HoverState.Parent = this.PasswordTB2;
            this.PasswordTB2.IconLeft = ((System.Drawing.Image)(resources.GetObject("PasswordTB2.IconLeft")));
            this.PasswordTB2.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.PasswordTB2.Location = new System.Drawing.Point(1024, 376);
            this.PasswordTB2.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.PasswordTB2.Name = "PasswordTB2";
            this.PasswordTB2.PasswordChar = '\0';
            this.PasswordTB2.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PasswordTB2.PlaceholderText = "Password";
            this.PasswordTB2.SelectedText = "";
            this.PasswordTB2.ShadowDecoration.Parent = this.PasswordTB2;
            this.PasswordTB2.Size = new System.Drawing.Size(531, 93);
            this.PasswordTB2.TabIndex = 10;
            this.PasswordTB2.UseSystemPasswordChar = true;
            // 
            // EmailTB
            // 
            this.EmailTB.Animated = true;
            this.EmailTB.AutoRoundedCorners = true;
            this.EmailTB.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.EmailTB.BorderRadius = 45;
            this.EmailTB.BorderThickness = 2;
            this.EmailTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTB.DefaultText = "";
            this.EmailTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTB.DisabledState.Parent = this.EmailTB;
            this.EmailTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTB.FocusedState.Parent = this.EmailTB;
            this.EmailTB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTB.HoverState.Parent = this.EmailTB;
            this.EmailTB.IconLeft = ((System.Drawing.Image)(resources.GetObject("EmailTB.IconLeft")));
            this.EmailTB.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.EmailTB.IconLeftSize = new System.Drawing.Size(15, 15);
            this.EmailTB.Location = new System.Drawing.Point(1024, 491);
            this.EmailTB.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.PasswordChar = '\0';
            this.EmailTB.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmailTB.PlaceholderText = "Email";
            this.EmailTB.SelectedText = "";
            this.EmailTB.ShadowDecoration.Parent = this.EmailTB;
            this.EmailTB.Size = new System.Drawing.Size(531, 93);
            this.EmailTB.TabIndex = 10;
            // 
            // usernameTB
            // 
            this.usernameTB.Animated = true;
            this.usernameTB.AutoRoundedCorners = true;
            this.usernameTB.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.usernameTB.BorderRadius = 45;
            this.usernameTB.BorderThickness = 2;
            this.usernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTB.DefaultText = "";
            this.usernameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTB.DisabledState.Parent = this.usernameTB;
            this.usernameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTB.FocusedState.Parent = this.usernameTB;
            this.usernameTB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTB.HoverState.Parent = this.usernameTB;
            this.usernameTB.IconLeft = ((System.Drawing.Image)(resources.GetObject("usernameTB.IconLeft")));
            this.usernameTB.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.usernameTB.Location = new System.Drawing.Point(1024, 606);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.PasswordChar = '\0';
            this.usernameTB.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usernameTB.PlaceholderText = "Username";
            this.usernameTB.SelectedText = "";
            this.usernameTB.ShadowDecoration.Parent = this.usernameTB;
            this.usernameTB.Size = new System.Drawing.Size(531, 93);
            this.usernameTB.TabIndex = 10;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1838, 1150);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.PasswordTB2);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.lnameTB);
            this.Controls.Add(this.fnameTB);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.picbox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton signupbtn;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTB;
        private Guna.UI2.WinForms.Guna2TextBox fnameTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label1;
        private Guna.UI2.WinForms.Guna2PictureBox picbox1;
        private Guna.UI2.WinForms.Guna2TextBox lnameTB;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTB2;
        private Guna.UI2.WinForms.Guna2TextBox EmailTB;
        private Guna.UI2.WinForms.Guna2TextBox usernameTB;
    }
}