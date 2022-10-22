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
    public partial class ProductCard : UserControl
    {
        public Product product { get; set; }

        public PictureBox picBoxDelete
        {
            get { return picDelete; }
        }


        public ProductCard(Product product)
        {
            InitializeComponent();
            this.product = product;
            lblName.Text=product.Name;
            lblPrice.Text= string.Format("{0:C}", product.Price);
            lblUpc.Text = product.UPC;
        }

        private void saaCheckBox1_CheckChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void picDelete_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
