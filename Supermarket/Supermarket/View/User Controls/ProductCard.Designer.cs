namespace Supermarket.View.User_Controls
{
    partial class ProductCard
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
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saaCheckBox1 = new SaaUI.SaaCheckBox();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiPanel1.BackColor = System.Drawing.Color.White;
            this.uiPanel1.Controls.Add(this.saaCheckBox1);
            this.uiPanel1.Controls.Add(this.label5);
            this.uiPanel1.Controls.Add(this.label6);
            this.uiPanel1.Controls.Add(this.label4);
            this.uiPanel1.Controls.Add(this.label3);
            this.uiPanel1.Controls.Add(this.picDelete);
            this.uiPanel1.Controls.Add(this.label1);
            this.uiPanel1.Controls.Add(this.label2);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.FillColor = System.Drawing.SystemColors.Control;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 50;
            this.uiPanel1.RectColor = System.Drawing.Color.White;
            this.uiPanel1.Size = new System.Drawing.Size(394, 153);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.StyleCustomMode = true;
            this.uiPanel1.TabIndex = 67;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(18, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 71;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(100, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 32);
            this.label6.TabIndex = 70;
            this.label6.Text = "$75";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(18, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 69;
            this.label4.Text = "UPC";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 68;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // picDelete
            // 
            this.picDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDelete.BackColor = System.Drawing.SystemColors.Control;
            this.picDelete.Image = global::Supermarket.Properties.Resources.DELETE;
            this.picDelete.Location = new System.Drawing.Point(333, 9);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(40, 36);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDelete.TabIndex = 67;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(96, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 66;
            this.label1.Text = "123456789";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(100, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 32);
            this.label2.TabIndex = 65;
            this.label2.Text = "Sun Chipse";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // saaCheckBox1
            // 
            this.saaCheckBox1.AutoResize = true;
            this.saaCheckBox1.BackColor = System.Drawing.SystemColors.Control;
            this.saaCheckBox1.BorderColor = System.Drawing.Color.Green;
            this.saaCheckBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.saaCheckBox1.BorderThickness = 1;
            this.saaCheckBox1.BoxColor = System.Drawing.Color.Green;
            this.saaCheckBox1.BoxColor2 = System.Drawing.Color.Green;
            this.saaCheckBox1.BoxColorAngle = 90F;
            this.saaCheckBox1.BoxHeight = 20;
            this.saaCheckBox1.BoxOffset = 0;
            this.saaCheckBox1.BoxWidth = 20;
            this.saaCheckBox1.Checked = false;
            this.saaCheckBox1.Location = new System.Drawing.Point(23, 19);
            this.saaCheckBox1.MaximumSize = new System.Drawing.Size(22, 24);
            this.saaCheckBox1.MinimumSize = new System.Drawing.Size(22, 24);
            this.saaCheckBox1.MouseClicks = SaaUI.CheckBoxMouseClick.LeftClick;
            this.saaCheckBox1.Name = "saaCheckBox1";
            this.saaCheckBox1.OffTextX = 0;
            this.saaCheckBox1.OffTextY = 3;
            this.saaCheckBox1.Size = new System.Drawing.Size(22, 24);
            this.saaCheckBox1.TabIndex = 72;
            this.saaCheckBox1.TickColor = System.Drawing.Color.White;
            this.saaCheckBox1.TickJoints = System.Drawing.Drawing2D.LineJoin.Round;
            this.saaCheckBox1.TickOffX1 = 0;
            this.saaCheckBox1.TickOffX2 = 0;
            this.saaCheckBox1.TickOffX3 = 0;
            this.saaCheckBox1.TickOffY1 = 0;
            this.saaCheckBox1.TickOffY2 = 0;
            this.saaCheckBox1.TickOffY3 = 0;
            this.saaCheckBox1.TickPath = true;
            this.saaCheckBox1.TickPathColor = System.Drawing.Color.LightBlue;
            this.saaCheckBox1.TickStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.saaCheckBox1.TickThickness = 3;
            this.saaCheckBox1.CheckChanged += new SaaUI.SaaCheckBox.OnCheckChanged(this.saaCheckBox1_CheckChanged);
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(394, 153);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private SaaUI.SaaCheckBox saaCheckBox1;
    }
}
