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

namespace Supermarket.View.User_Controls.SignInControls
{
    public partial class TransactionDetailViewCard : UserControl
    {
        public TransactionDetailViewCard(string name,string UPC, int quantity,double total)
        {
            InitializeComponent();
            lblName.Text = name;
            lblQuantity.Text = quantity.ToString();
            lblTotal.Text = string.Format("{0:C}", total);
            lblUPC.Text = UPC;
        }

        public TransactionDetailViewCard()
        {
            InitializeComponent();
        }
    }
}
