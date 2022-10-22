namespace Supermarket.View.Forms
{
    partial class TransactionHistoryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSearchTran = new System.Windows.Forms.Panel();
            this.slSearch = new Sunny.UI.UISymbolLabel();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.rjDatePicker2 = new RJCodeAdvance.RJControls.RJDatePicker();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.rjDatePicker1 = new RJCodeAdvance.RJControls.RJDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSearchTran.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiTableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 734);
            this.panel1.TabIndex = 1;
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 2;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.uiTableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 1;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(1212, 734);
            this.uiTableLayoutPanel1.TabIndex = 0;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.pnlSearchTran);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 728);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(786, 628);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pnlSearchTran
            // 
            this.pnlSearchTran.Controls.Add(this.slSearch);
            this.pnlSearchTran.Controls.Add(this.uiPanel4);
            this.pnlSearchTran.Controls.Add(this.uiPanel1);
            this.pnlSearchTran.Controls.Add(this.label1);
            this.pnlSearchTran.Controls.Add(this.txtSearch);
            this.pnlSearchTran.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchTran.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchTran.Name = "pnlSearchTran";
            this.pnlSearchTran.Size = new System.Drawing.Size(786, 100);
            this.pnlSearchTran.TabIndex = 1;
            // 
            // slSearch
            // 
            this.slSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.slSearch.BackColor = System.Drawing.SystemColors.Control;
            this.slSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.slSearch.ForeColor = System.Drawing.Color.White;
            this.slSearch.Location = new System.Drawing.Point(366, 34);
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
            // uiPanel4
            // 
            this.uiPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPanel4.Controls.Add(this.rjDatePicker2);
            this.uiPanel4.FillColor = System.Drawing.Color.DarkSlateGray;
            this.uiPanel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(622, 27);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Radius = 41;
            this.uiPanel4.RectColor = System.Drawing.Color.DarkSlateGray;
            this.uiPanel4.Size = new System.Drawing.Size(149, 45);
            this.uiPanel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel4.StyleCustomMode = true;
            this.uiPanel4.TabIndex = 51;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // rjDatePicker2
            // 
            this.rjDatePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjDatePicker2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker2.BorderSize = 0;
            this.rjDatePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDatePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDatePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rjDatePicker2.Location = new System.Drawing.Point(16, 6);
            this.rjDatePicker2.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker2.Name = "rjDatePicker2";
            this.rjDatePicker2.Size = new System.Drawing.Size(116, 35);
            this.rjDatePicker2.SkinColor = System.Drawing.Color.DarkSlateGray;
            this.rjDatePicker2.TabIndex = 46;
            this.rjDatePicker2.TextColor = System.Drawing.Color.White;
            this.rjDatePicker2.ValueChanged += new System.EventHandler(this.rjDatePicker2_ValueChanged);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPanel1.Controls.Add(this.rjDatePicker1);
            this.uiPanel1.FillColor = System.Drawing.Color.DarkSlateGray;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(429, 27);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 41;
            this.uiPanel1.RectColor = System.Drawing.Color.DarkSlateGray;
            this.uiPanel1.Size = new System.Drawing.Size(149, 45);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.StyleCustomMode = true;
            this.uiPanel1.TabIndex = 50;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rjDatePicker1.Location = new System.Drawing.Point(15, 6);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(116, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.DarkSlateGray;
            this.rjDatePicker1.TabIndex = 46;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
            this.rjDatePicker1.ValueChanged += new System.EventHandler(this.rjDatePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(581, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "To";
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
            this.txtSearch.Size = new System.Drawing.Size(403, 46);
            this.txtSearch.TabIndex = 44;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Resize += new System.EventHandler(this.txtSearch_Resize);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uiPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(795, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 728);
            this.panel3.TabIndex = 1;
            // 
            // uiPanel2
            // 
            this.uiPanel2.AutoSize = true;
            this.uiPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiPanel2.Controls.Add(this.flowLayoutPanel2);
            this.uiPanel2.Controls.Add(this.label8);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.FillColor = System.Drawing.SystemColors.Control;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Radius = 100;
            this.uiPanel2.RectColor = System.Drawing.SystemColors.Control;
            this.uiPanel2.Size = new System.Drawing.Size(414, 728);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.StyleCustomMode = true;
            this.uiPanel2.TabIndex = 49;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(24, 103);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(381, 574);
            this.flowLayoutPanel2.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(17, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(378, 60);
            this.label8.TabIndex = 45;
            this.label8.Text = "Detail";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransactionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 734);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionHistoryForm";
            this.Text = "CashierHistoryForm";
            this.Load += new System.EventHandler(this.CashierTransactionHistoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlSearchTran.ResumeLayout(false);
            this.pnlSearchTran.PerformLayout();
            this.uiPanel4.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.uiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlSearchTran;
        private RJCodeAdvance.RJControls.RJTextBox txtSearch;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UIPanel uiPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePicker1;
        private Sunny.UI.UIPanel uiPanel4;
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePicker2;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UISymbolLabel slSearch;
    }
}