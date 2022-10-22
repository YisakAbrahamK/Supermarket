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

namespace Supermarket.View.User_Controls
{
    public partial class TransactionCard : UserControl
    {

        public Transaction transaction { get; set; }

        public TransactionCard(Transaction transaction)
        {
            InitializeComponent();
            this.transaction = transaction;
            lbldate.Text = transaction.PurchaseDate.ToShortDateString();
            lblId.Text = transaction.Id.ToString(); 
            lblTotal.Text = string.Format("{0:C}", transaction.Total);
            CasherName.Text = transaction.Casher.FirstName + " " + transaction.Casher.LastName;
        }
    }
}
