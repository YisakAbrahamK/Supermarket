using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.View.Forms
{
    public partial class InvoiceForm : Form
    {
        Form casherForm;
        public InvoiceForm(Form casherForm)
        {
            this.casherForm = casherForm;
            InitializeComponent();
            this.ResizeRedraw = true;
            casherForm.SizeChanged += (Object o, EventArgs e) =>
            {
                foreach (Control control in flowLayoutPanel2.Controls)
                {
                    control.Width = flowLayoutPanel2.Width - 40;
                }
                flowLayoutPanel2.HorizontalScroll.Maximum = 0;
                flowLayoutPanel2.AutoScroll = false;
                flowLayoutPanel2.VerticalScroll.Visible = false;
                flowLayoutPanel2.AutoScroll = true;
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    control.Width = flowLayoutPanel1.Width - 40;
                }
                flowLayoutPanel1.HorizontalScroll.Maximum = 0;
                flowLayoutPanel1.AutoScroll = false;
                flowLayoutPanel1.VerticalScroll.Visible = false;
                flowLayoutPanel1.AutoScroll = true;
            };
        }

        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {
            txtSearch.Invalidate();
            txtSearch.Refresh();
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Width = flowLayoutPanel1.Width - 40;
            }
            flowLayoutPanel1.HorizontalScroll.Maximum = 0;
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.VerticalScroll.Visible = false;
            flowLayoutPanel1.AutoScroll = true;
        }

        private void flowLayoutPanel2_Resize(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                control.Width = flowLayoutPanel2.Width - 40;
            }
            flowLayoutPanel2.HorizontalScroll.Maximum = 0;
            flowLayoutPanel2.AutoScroll = false;
            flowLayoutPanel2.VerticalScroll.Visible = false;
            flowLayoutPanel2.AutoScroll = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Resize(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


        }
    }
}
