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
    public partial class TransactionHistoryForm : Form
    {
        Form parentForm;
        public TransactionHistoryForm(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

            parentForm.SizeChanged += (Object o, EventArgs e) =>
            {
                refrashSize();
            };
        }
    

        private void CashierTransactionHistoryForm_Load(object sender, EventArgs e)
        {
            refrashSize();
        }

        private void txtSearch_Resize(object sender, EventArgs e)
        {
            txtSearch.Invalidate();
            txtSearch.Refresh();
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

        private void uiSymbolLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
