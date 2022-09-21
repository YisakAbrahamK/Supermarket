using RJCodeAdvance.RJControls;
using SaaUI;
using Sunny.UI;
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
    public partial class CartView : UserControl
    {
       
        Product product;

        private UISymbolLabel _LabelDelete;

        public UISymbolLabel LabelDelete
        {
            get { return uiSymbolLabel2; }
        }

        private SaaCheckBox _CartCheckBox;
        public SaaCheckBox CartCheckBox
        {
            get { return saaCheckBox1;}
        }



        public CartView(Product product)
        {
            
            InitializeComponent();
            this.product = product;
            lblProductName.Text = product.Name;
            lblUPC.Text = product.UPC.ToString();

        }


        private void iudQuantity_ValueChanged(object sender, int value)
        {
            lblTotal.Text = (iudQuantity.Value * product.Price).ToString();

        }
    }
}
