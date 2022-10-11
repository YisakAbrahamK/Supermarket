namespace Supermarket.Panals
{
    partial class EnterNewPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterNewPass));
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.txtCPassword = new Sunny.UI.UITextBox();
            this.btnSeeConfirm = new System.Windows.Forms.PictureBox();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.btnSee = new System.Windows.Forms.PictureBox();
            this.btnSave = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.txtCPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeeConfirm)).BeginInit();
            this.txtPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSee)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(124, 59);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(139, 90);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 48);
            this.label4.TabIndex = 30;
            this.label4.Text = "Recover password";
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Blue;
            this.uiPanel1.Controls.Add(this.txtCPassword);
            this.uiPanel1.Controls.Add(this.txtPassword);
            this.uiPanel1.Controls.Add(this.btnSave);
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
            this.uiPanel1.TabIndex = 51;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtCPassword
            // 
            this.txtCPassword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtCPassword.Controls.Add(this.btnSeeConfirm);
            this.txtCPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPassword.Location = new System.Drawing.Point(33, 361);
            this.txtCPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.Padding = new System.Windows.Forms.Padding(50, 0, 5, 0);
            this.txtCPassword.PasswordChar = '●';
            this.txtCPassword.Radius = 40;
            this.txtCPassword.ShowText = false;
            this.txtCPassword.Size = new System.Drawing.Size(311, 46);
            this.txtCPassword.Style = Sunny.UI.UIStyle.Custom;
            this.txtCPassword.TabIndex = 53;
            this.txtCPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCPassword.Watermark = "Comfirm password";
            this.txtCPassword.WatermarkActiveColor = System.Drawing.Color.White;
            this.txtCPassword.WatermarkColor = System.Drawing.Color.DarkGray;
            this.txtCPassword.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnSeeConfirm
            // 
            this.btnSeeConfirm.BackColor = System.Drawing.Color.White;
            this.btnSeeConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeConfirm.Image = global::Supermarket.Properties.Resources.eye_svgrepo_com;
            this.btnSeeConfirm.Location = new System.Drawing.Point(12, 12);
            this.btnSeeConfirm.Name = "btnSeeConfirm";
            this.btnSeeConfirm.Size = new System.Drawing.Size(37, 25);
            this.btnSeeConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSeeConfirm.TabIndex = 41;
            this.btnSeeConfirm.TabStop = false;
            this.btnSeeConfirm.Click += new System.EventHandler(this.btnSeeConfirm_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtPassword.Controls.Add(this.btnSee);
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(33, 291);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(50, 0, 5, 0);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Radius = 40;
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(311, 46);
            this.txtPassword.Style = Sunny.UI.UIStyle.Custom;
            this.txtPassword.TabIndex = 52;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "New password";
            this.txtPassword.WatermarkActiveColor = System.Drawing.Color.White;
            this.txtPassword.WatermarkColor = System.Drawing.Color.DarkGray;
            this.txtPassword.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(126, 516);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 40;
            this.btnSave.Size = new System.Drawing.Size(128, 44);
            this.btnSave.Style = Sunny.UI.UIStyle.Custom;
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // EnterNewPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.uiPanel1);
            this.Name = "EnterNewPass";
            this.Size = new System.Drawing.Size(397, 624);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.txtCPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSeeConfirm)).EndInit();
            this.txtPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITextBox txtCPassword;
        private System.Windows.Forms.PictureBox btnSeeConfirm;
        private Sunny.UI.UITextBox txtPassword;
        private System.Windows.Forms.PictureBox btnSee;
        private Sunny.UI.UIButton btnSave;
    }
}
