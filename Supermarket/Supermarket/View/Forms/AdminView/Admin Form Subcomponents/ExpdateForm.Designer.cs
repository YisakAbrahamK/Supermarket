namespace Supermarket.View.Forms.Admin.Admin_Form_Subcomponents
{
    partial class ExpdateForm
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
            this.pnlSearchTran = new System.Windows.Forms.Panel();
            this.slSearch = new Sunny.UI.UISymbolLabel();
            this.txtSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSearchTran.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearchTran
            // 
            this.pnlSearchTran.BackColor = System.Drawing.Color.White;
            this.pnlSearchTran.Controls.Add(this.slSearch);
            this.pnlSearchTran.Controls.Add(this.txtSearch);
            this.pnlSearchTran.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchTran.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchTran.Name = "pnlSearchTran";
            this.pnlSearchTran.Size = new System.Drawing.Size(1005, 100);
            this.pnlSearchTran.TabIndex = 5;
            // 
            // slSearch
            // 
            this.slSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.slSearch.BackColor = System.Drawing.SystemColors.Control;
            this.slSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.slSearch.ForeColor = System.Drawing.Color.White;
            this.slSearch.Location = new System.Drawing.Point(941, 34);
            this.slSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.slSearch.Name = "slSearch";
            this.slSearch.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.slSearch.Size = new System.Drawing.Size(35, 34);
            this.slSearch.Style = Sunny.UI.UIStyle.Custom;
            this.slSearch.StyleCustomMode = true;
            this.slSearch.Symbol = 61442;
            this.slSearch.SymbolColor = System.Drawing.Color.Black;
            this.slSearch.SymbolSize = 40;
            this.slSearch.TabIndex = 58;
            this.slSearch.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.slSearch.Click += new System.EventHandler(this.slSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.BorderColor = System.Drawing.Color.Gray;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.Green;
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(11, 27);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(40, 7, 60, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.Size = new System.Drawing.Size(981, 46);
            this.txtSearch.TabIndex = 44;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlSearchTran);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 591);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 491);
            this.panel2.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1005, 491);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // ExpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 591);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpdateForm";
            this.Text = "ExpdateForm";
            this.Resize += new System.EventHandler(this.ExpdateForm_Resize);
            this.pnlSearchTran.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearchTran;
        private Sunny.UI.UISymbolLabel slSearch;
        private RJCodeAdvance.RJControls.RJTextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}