namespace Supermarket.View.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.picClose = new Sunny.UI.UISymbolLabel();
            this.saaGlowing3 = new SaaUI.SaaGlowing();
            this.saaGlowing2 = new SaaUI.SaaGlowing();
            this.saaGlowing1 = new SaaUI.SaaGlowing();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Black;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(390, 624);
            this.pnlContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.uiPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(396, 710);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlContainer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 624);
            this.panel2.TabIndex = 1;
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Blue;
            this.uiPanel1.Controls.Add(this.picClose);
            this.uiPanel1.Controls.Add(this.saaGlowing3);
            this.uiPanel1.Controls.Add(this.saaGlowing2);
            this.uiPanel1.Controls.Add(this.saaGlowing1);
            this.uiPanel1.FillColor = System.Drawing.Color.DarkSlateGray;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(4, 5);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 50;
            this.uiPanel1.RectColor = System.Drawing.Color.White;
            this.uiPanel1.Size = new System.Drawing.Size(388, 60);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.DarkSlateGray;
            this.picClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.picClose.ForeColor = System.Drawing.Color.PaleGreen;
            this.picClose.Location = new System.Drawing.Point(325, 10);
            this.picClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.picClose.Name = "picClose";
            this.picClose.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.picClose.Size = new System.Drawing.Size(47, 44);
            this.picClose.Style = Sunny.UI.UIStyle.Custom;
            this.picClose.StyleCustomMode = true;
            this.picClose.Symbol = 61527;
            this.picClose.SymbolColor = System.Drawing.Color.White;
            this.picClose.SymbolSize = 45;
            this.picClose.TabIndex = 59;
            this.picClose.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // saaGlowing3
            // 
            this.saaGlowing3.BackColor = System.Drawing.Color.Transparent;
            this.saaGlowing3.Color = System.Drawing.Color.White;
            this.saaGlowing3.ForceTransparence = true;
            this.saaGlowing3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saaGlowing3.GrowingSpeed = 5;
            this.saaGlowing3.Location = new System.Drawing.Point(71, 7);
            this.saaGlowing3.Name = "saaGlowing3";
            this.saaGlowing3.Size = new System.Drawing.Size(47, 47);
            this.saaGlowing3.Stop = false;
            this.saaGlowing3.TabIndex = 12;
            this.saaGlowing3.Text = "saaGlowing3";
            // 
            // saaGlowing2
            // 
            this.saaGlowing2.BackColor = System.Drawing.Color.Transparent;
            this.saaGlowing2.Color = System.Drawing.Color.Aqua;
            this.saaGlowing2.ForceTransparence = true;
            this.saaGlowing2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saaGlowing2.GrowingSpeed = 4;
            this.saaGlowing2.Location = new System.Drawing.Point(124, 7);
            this.saaGlowing2.Name = "saaGlowing2";
            this.saaGlowing2.Size = new System.Drawing.Size(47, 47);
            this.saaGlowing2.Stop = false;
            this.saaGlowing2.TabIndex = 11;
            this.saaGlowing2.Text = "saaGlowing2";
            // 
            // saaGlowing1
            // 
            this.saaGlowing1.BackColor = System.Drawing.Color.Transparent;
            this.saaGlowing1.Color = System.Drawing.Color.Red;
            this.saaGlowing1.ForceTransparence = true;
            this.saaGlowing1.ForeColor = System.Drawing.Color.Red;
            this.saaGlowing1.GrowingSpeed = 3;
            this.saaGlowing1.Location = new System.Drawing.Point(18, 7);
            this.saaGlowing1.Name = "saaGlowing1";
            this.saaGlowing1.Size = new System.Drawing.Size(47, 47);
            this.saaGlowing1.Stop = false;
            this.saaGlowing1.TabIndex = 0;
            this.saaGlowing1.Text = "saaGlowing1";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(396, 710);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm2";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UIPanel uiPanel1;
        private SaaUI.SaaGlowing saaGlowing2;
        private Sunny.UI.UISymbolLabel picClose;
        private SaaUI.SaaGlowing saaGlowing3;
        private SaaUI.SaaGlowing saaGlowing1;
    }
}