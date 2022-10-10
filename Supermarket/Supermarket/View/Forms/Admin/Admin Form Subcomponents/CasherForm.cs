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
    public partial class CasherForm : Form
    {
        Form adminForm;
        public CasherForm(Form adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
            adminForm.SizeChanged += (Object sender, EventArgs EventArgs) => {
                refrashSize();
            };
        }

        private void saaToggle1_CheckChanged(object sender, EventArgs e)
        {
            if( saaToggle1.Checked)
            {
                btnAddAndEdit.Text = "Add";
            }
            else
            {
                btnAddAndEdit.Text = "Update";
            }
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

        private void CasherForm_Load(object sender, EventArgs e)
        {
            refrashSize();
        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            txtSearch.Invalidate();
            txtSearch.Refresh();
        }
    }
}
