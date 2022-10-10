namespace Supermarket.View.Forms.Admin.Admin_Form_Subcomponents
{
    partial class DashbordForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleCard1 = new Supermarket.View.User_Controls.Dashbord_Cards.SimpleCard();
            this.dashSimpleCard2 = new Supermarket.View.User_Controls.Dashbord_Cards.DashSimpleCard();
            this.dashSimpleCard1 = new Supermarket.View.User_Controls.Dashbord_Cards.DashSimpleCard();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.simpleCard1);
            this.flowLayoutPanel1.Controls.Add(this.dashSimpleCard2);
            this.flowLayoutPanel1.Controls.Add(this.dashSimpleCard1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1327, 793);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 207);
            this.label2.TabIndex = 70;
            this.label2.Text = "Daily";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // simpleCard1
            // 
            this.simpleCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleCard1.Location = new System.Drawing.Point(199, 3);
            this.simpleCard1.Name = "simpleCard1";
            this.simpleCard1.Size = new System.Drawing.Size(383, 201);
            this.simpleCard1.TabIndex = 71;
            // 
            // dashSimpleCard2
            // 
            this.dashSimpleCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashSimpleCard2.Location = new System.Drawing.Point(588, 3);
            this.dashSimpleCard2.Name = "dashSimpleCard2";
            this.dashSimpleCard2.Size = new System.Drawing.Size(388, 201);
            this.dashSimpleCard2.TabIndex = 69;
            // 
            // dashSimpleCard1
            // 
            this.dashSimpleCard1.Location = new System.Drawing.Point(3, 210);
            this.dashSimpleCard1.Name = "dashSimpleCard1";
            this.dashSimpleCard1.Size = new System.Drawing.Size(388, 175);
            this.dashSimpleCard1.TabIndex = 72;
            // 
            // DashbordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 793);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashbordForm";
            this.Text = "DashbordForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private User_Controls.Dashbord_Cards.SimpleCard simpleCard1;
        private User_Controls.Dashbord_Cards.DashSimpleCard dashSimpleCard2;
        private User_Controls.Dashbord_Cards.DashSimpleCard dashSimpleCard1;
    }
}