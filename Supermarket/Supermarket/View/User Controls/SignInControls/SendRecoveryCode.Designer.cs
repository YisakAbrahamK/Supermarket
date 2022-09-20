namespace Supermarket.Panals
{
    partial class SendRecoveryCode
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendRecoveryCode));
            this.label4 = new System.Windows.Forms.Label();
            this.tVerifyPassword = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblSent = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.saaLine1 = new SaaUI.SaaLine();
            this.btnSend = new Sunny.UI.UIButton();
            this.btnVerify = new Sunny.UI.UIButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.txtCode = new Sunny.UI.UITextBox();
            this.btnSee = new System.Windows.Forms.PictureBox();
            this.txtEmail = new Sunny.UI.UITextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.txtCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSee)).BeginInit();
            this.txtEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 59);
            this.label4.TabIndex = 20;
            this.label4.Text = "Recover password";
            // 
            // tVerifyPassword
            // 
            this.tVerifyPassword.Interval = 1000;
            this.tVerifyPassword.Tick += new System.EventHandler(this.tVerifyPassword_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(234, 322);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(104, 36);
            this.lblTimer.TabIndex = 29;
            this.lblTimer.Text = "05:00";
            // 
            // lblSent
            // 
            this.lblSent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblSent.Enabled = false;
            this.lblSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSent.ForeColor = System.Drawing.Color.White;
            this.lblSent.Location = new System.Drawing.Point(153, 361);
            this.lblSent.Name = "lblSent";
            this.lblSent.Size = new System.Drawing.Size(45, 25);
            this.lblSent.TabIndex = 30;
            this.lblSent.Text = "Sent";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(137, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(139, 90);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            // 
            // saaLine1
            // 
            this.saaLine1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.saaLine1.CustomLineAlignment = 0;
            this.saaLine1.DashCap = System.Drawing.Drawing2D.DashCap.Flat;
            this.saaLine1.DashOffset = 0F;
            this.saaLine1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.saaLine1.EndEdge = 0;
            this.saaLine1.LineAlignment = SaaUI.LineAlign.Center;
            this.saaLine1.LineColor = System.Drawing.Color.DarkGray;
            this.saaLine1.LineEnd = System.Drawing.Drawing2D.LineCap.Round;
            this.saaLine1.LineStart = System.Drawing.Drawing2D.LineCap.Round;
            this.saaLine1.Location = new System.Drawing.Point(14, 389);
            this.saaLine1.Name = "saaLine1";
            this.saaLine1.Size = new System.Drawing.Size(369, 22);
            this.saaLine1.StartEdge = 0;
            this.saaLine1.TabIndex = 49;
            this.saaLine1.Transparent = false;
            this.saaLine1.Vertical = false;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(57, 312);
            this.btnSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSend.Name = "btnSend";
            this.btnSend.Radius = 40;
            this.btnSend.Size = new System.Drawing.Size(128, 44);
            this.btnSend.Style = Sunny.UI.UIStyle.Custom;
            this.btnSend.TabIndex = 51;
            this.btnSend.Text = "Send";
            this.btnSend.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSend.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Location = new System.Drawing.Point(137, 513);
            this.btnVerify.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Radius = 40;
            this.btnVerify.Size = new System.Drawing.Size(128, 44);
            this.btnVerify.Style = Sunny.UI.UIStyle.Custom;
            this.btnVerify.TabIndex = 52;
            this.btnVerify.Text = "Verify";
            this.btnVerify.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Blue;
            this.uiPanel1.Controls.Add(this.txtCode);
            this.uiPanel1.Controls.Add(this.txtEmail);
            this.uiPanel1.Controls.Add(this.btnVerify);
            this.uiPanel1.Controls.Add(this.btnSend);
            this.uiPanel1.FillColor = System.Drawing.Color.DarkSlateGray;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(11, 2);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 70;
            this.uiPanel1.RectColor = System.Drawing.SystemColors.Control;
            this.uiPanel1.Size = new System.Drawing.Size(375, 620);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 50;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtCode.Controls.Add(this.btnSee);
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(50, 435);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCode.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtCode.Name = "txtCode";
            this.txtCode.Padding = new System.Windows.Forms.Padding(50, 0, 5, 0);
            this.txtCode.PasswordChar = '●';
            this.txtCode.Radius = 40;
            this.txtCode.RectColor = System.Drawing.SystemColors.Control;
            this.txtCode.ShowText = false;
            this.txtCode.Size = new System.Drawing.Size(291, 46);
            this.txtCode.Style = Sunny.UI.UIStyle.Custom;
            this.txtCode.StyleCustomMode = true;
            this.txtCode.TabIndex = 51;
            this.txtCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCode.Watermark = "Code";
            this.txtCode.WatermarkActiveColor = System.Drawing.Color.White;
            this.txtCode.WatermarkColor = System.Drawing.Color.DarkGray;
            this.txtCode.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnSee
            // 
            this.btnSee.BackColor = System.Drawing.Color.White;
            this.btnSee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSee.Image = global::Supermarket.Properties.Resources.eye_svgrepo_com;
            this.btnSee.Location = new System.Drawing.Point(12, 12);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(37, 25);
            this.btnSee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSee.TabIndex = 41;
            this.btnSee.TabStop = false;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtEmail.Controls.Add(this.pictureBox4);
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(50, 234);
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
            this.txtEmail.TabIndex = 51;
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.Watermark = "Email";
            this.txtEmail.WatermarkActiveColor = System.Drawing.Color.White;
            this.txtEmail.WatermarkColor = System.Drawing.Color.DarkGray;
            this.txtEmail.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::Supermarket.Properties.Resources.email_svgrepo_com;
            this.pictureBox4.Location = new System.Drawing.Point(12, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // SendRecoveryCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.Controls.Add(this.saaLine1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.lblSent);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiPanel1);
            this.Name = "SendRecoveryCode";
            this.Size = new System.Drawing.Size(397, 624);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.txtCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSee)).EndInit();
            this.txtEmail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tVerifyPassword;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblSent;
        private System.Windows.Forms.PictureBox pictureBox8;
        private SaaUI.SaaLine saaLine1;
        private Sunny.UI.UIButton btnSend;
        private Sunny.UI.UIButton btnVerify;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Sunny.UI.UITextBox txtCode;
        private System.Windows.Forms.PictureBox btnSee;
    }
}
