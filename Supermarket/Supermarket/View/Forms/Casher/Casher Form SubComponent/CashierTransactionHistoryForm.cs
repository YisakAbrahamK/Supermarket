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
    public partial class CashierTransactionHistoryForm : Form
    {
        public CashierTransactionHistoryForm()
        {
            InitializeComponent();
        }

        private void CashierTransactionHistoryForm_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_Resize(object sender, EventArgs e)
        {
            txtSearch.Invalidate();
            txtSearch.Refresh();
        }
    }
}
