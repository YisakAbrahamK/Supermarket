namespace Supermarket.View.User_Controls.SignInControls
{
    partial class SignIn
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new Sunny.UI.UIButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.tkRole = new SaaUI.SaaCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.txtEmail = new Sunny.UI.UITextBox();
            this.txtPassword = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.txtEmail.SuspendLayout();
            this.txtPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Image = global::Supermarket.Properties.Resources.WhiteUser;
            this.pictureBox1.Location = new System.Drawing.Point(112, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(132, 482);
            this.btnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Radius = 40;
            this.btnLogin.Size = new System.Drawing.Size(128, 44);
            this.btnLogin.Style = Sunny.UI.UIStyle.Custom;
            this.btnLogin.TabIndex = 41;
            this.btnLogin.Text = "Login";
            this.btnLogin.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::Supermarket.Properties.Resources.email_svgrepo_com;
            this.pictureBox4.Location = new System.Drawing.Point(11, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Supermarket.Properties.Resources.eye_svgrepo_com;
            this.pictureBox3.Location = new System.Drawing.Point(11, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblForgotPassword.Location = new System.Drawing.Point(107, 553);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(230, 47);
            this.lblForgotPassword.TabIndex = 35;
            this.lblForgotPassword.Text = "Forgot password?";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // tkRole
            // 
            this.tkRole.AutoResize = true;
            this.tkRole.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tkRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.tkRole.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.tkRole.BorderThickness = 1;
            this.tkRole.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.tkRole.BoxColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.tkRole.BoxColorAngle = 90F;
            this.tkRole.BoxHeight = 20;
            this.tkRole.BoxOffset = 0;
            this.tkRole.BoxWidth = 20;
            this.tkRole.Checked = false;
            this.tkRole.ForeColor = System.Drawing.Color.White;
            this.tkRole.Location = new System.Drawing.Point(58, 405);
            this.tkRole.MaximumSize = new System.Drawing.Size(22, 24);
            this.tkRole.MinimumSize = new System.Drawing.Size(22, 24);
            this.tkRole.MouseClicks = SaaUI.CheckBoxMouseClick.LeftClick;
            this.tkRole.Name = "tkRole";
            this.tkRole.OffTextX = 0;
            this.tkRole.OffTextY = 3;
            this.tkRole.Size = new System.Drawing.Size(22, 24);
            this.tkRole.TabIndex = 48;
            this.tkRole.TickColor = System.Drawing.Color.White;
            this.tkRole.TickJoints = System.Drawing.Drawing2D.LineJoin.Round;
            this.tkRole.TickOffX1 = 0;
            this.tkRole.TickOffX2 = 0;
            this.tkRole.TickOffX3 = 0;
            this.tkRole.TickOffY1 = 0;
            this.tkRole.TickOffY2 = 0;
            this.tkRole.TickOffY3 = 0;
            this.tkRole.TickPath = true;
            this.tkRole.TickPathColor = System.Drawing.Color.LightBlue;
            this.tkRole.TickStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.tkRole.TickThickness = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Admin";
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Blue;
            this.uiPanel1.Controls.Add(this.pictureBox1);
            this.uiPanel1.Controls.Add(this.label1);
            this.uiPanel1.Controls.Add(this.tkRole);
            this.uiPanel1.Controls.Add(this.lblForgotPassword);
            this.uiPanel1.Controls.Add(this.txtPassword);
            this.uiPanel1.Controls.Add(this.txtEmail);
            this.uiPanel1.Controls.Add(this.btnLogin);
            this.uiPanel1.FillColor = System.Drawing.Color.DarkSlateGray;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(9, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 70;
            this.uiPanel1.RectColor = System.Drawing.SystemColors.Control;
            this.uiPanel1.Size = new System.Drawing.Size(375, 620);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 43;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtEmail.Controls.Add(this.pictureBox4);
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(46, 277);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(50, 0, 5, 0);
            this.txtEmail.Radius = 40;
            this.txtEmail.RectColor = System.Drawing.SystemColors.Control;
            this.txtEmail.ShowText = false;
            this.txtEmail.Size = new System.Drawing.Size(291, 46);
            this.txtEmail.Style = Sunny.UI.UIStyle.Custom;
            this.txtEmail.StyleCustomMode = true;
            this.txtEmail.TabIndex = 42;
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.Watermark = "Email";
            this.txtEmail.WatermarkActiveColor = System.Drawing.Color.White;
            this.txtEmail.WatermarkColor = System.Drawing.Color.DarkGray;
            this.txtEmail.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtPassword.Controls.Add(this.pictureBox3);
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(46, 344);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(50, 0, 5, 0);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Radius = 40;
            this.txtPassword.RectColor = System.Drawing.SystemColors.Control;
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(291, 46);
            this.txtPassword.Style = Sunny.UI.UIStyle.Custom;
            this.txtPassword.StyleCustomMode = true;
            this.txtPassword.TabIndex = 45;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "Password";
            this.txtPassword.WatermarkActiveColor = System.Drawing.Color.White;
            this.txtPassword.WatermarkColor = System.Drawing.Color.DarkGray;
            this.txtPassword.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.Controls.Add(this.uiPanel1);
            this.Name = "SignIn";
            this.Size = new System.Drawing.Size(394, 628);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.txtEmail.ResumeLayout(false);
            this.txtPassword.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIButton btnLogin;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblForgotPassword;
        private SaaUI.SaaCheckBox tkRole;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox txtEmail;
    }
}
