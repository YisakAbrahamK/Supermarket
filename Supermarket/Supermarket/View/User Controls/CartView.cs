using RJCodeAdvance.RJControls;
using SaaUI;
using Sunny.UI;
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
    public partial class CartView : UserControl
    {

        public double total { get; set; } = 0;
        public double tax { get; set; } = 0;
        public double subtotal { get; set; } = 0;

        public Product product;

        private PictureBox _PictureBoxDelete;
        public PictureBox PictureBoxDelete
        {
            get { return picDelete; }
        }

        private SaaCheckBox _CartCheckBox;
        public SaaCheckBox CartCheckBox
        {
            get { return saaCheckBox1;}
        }

        private UIIntegerUpDown _UpDownQuantity { get; set; }

        public UIIntegerUpDown UpDownQuantity
        {
            get { return iudQuantity; }
        }


        public CartView(Product product)
        {
            
            InitializeComponent();
            this.product = product;
            lblProductName.Text = product.Name;
            lblUPC.Text = product.UPC.ToString();
            lblTotal.Text = string.Format("{0:C}", ((product.Price) + (product.Price * (product.Tax / 100))));
            lblSubtotal.Text = string.Format("{0:C}", product.Price);
            calculateValues();
        }


        private void iudQuantity_ValueChanged(object sender, int value)
        {
            calculateValues();
        }

        private void calculateValues()
        {
            subtotal = (iudQuantity.Value * product.Price);
            lblSubtotal.Text = string.Format("{0:C}", subtotal);
            tax = subtotal * (product.Tax / 100);
            total = subtotal + tax;
            lblTotal.Text = string.Format("{0:C}", total);
        }
    }
}
