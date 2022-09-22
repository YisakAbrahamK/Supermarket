using RJCodeAdvance.RJControls;
using Supermarket.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.View.User_Controls.SignInControls
{
    public partial class ProductViewCard : UserControl
    {
       

        private RJButton _ButtonAdd;

        public RJButton ButtonAdd
        {
            get { return btnAdd; }
            
        }

        public ProductViewCard(Product product)
        {
              
            InitializeComponent();
            lblUPC.Text = product.UPC.ToString();
            lblPrice.Text = string.Format("{0:C}", product.Price);
            lblTax.Text = (product.Tax/100).ToString("P",CultureInfo.CurrentCulture);
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
