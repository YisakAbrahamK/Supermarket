using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.View.Forms.Admin.Admin_Form_Subcomponents
{
    public partial class ExpdateForm : Form
    {
        Form parentForm;
        public ExpdateForm(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            parentForm.Resize += (Object sender, EventArgs e) =>
            {
                refrashSize();
            };
        }
        public void refrashSize()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Width = flowLayoutPanel1.Width - 27;
            }
            flowLayoutPanel1.HorizontalScroll.Maximum = 0;
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.VerticalScroll.Visible = false;
            flowLayoutPanel1.AutoScroll = true;
        }

        private void ExpdateForm_Resize(object sender, EventArgs e)
        {
            txtSearch.Invalidate();
            txtSearch.Refresh();
        }
    }
}
