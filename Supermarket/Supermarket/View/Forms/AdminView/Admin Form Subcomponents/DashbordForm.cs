using Supermarket.Model;
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
    public partial class DashbordForm : Form
    {
        Form ParentForm;
        public DashbordForm( Form ParentForm)
        {
            InitializeComponent();
            this.ParentForm = ParentForm;
            loadData();
        }

        private void slReferesh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            using(Context context = new Context())
            {
                var TotalTransactions =context.Transactions.Count();
                var TotalTransactionsAmount = (from t in context.Transactions select t.Total).Sum();
                var itemsInStore = context.products.Count();
                var numberOfExpiredItems =context.products.Where(a => (a.ExpiredDate <= DateTime.Now)).Count();
                lblTransaction.Text = TotalTransactions.ToString();
                lblTransactionAmount.Text = string.Format("{0:C}", TotalTransactionsAmount);
                lblExpiredItem.Text = numberOfExpiredItems.ToString();
                lblItemInStore.Text = itemsInStore.ToString();
            }
        }
    }
}
