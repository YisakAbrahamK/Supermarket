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
    public partial class ExpCard : UserControl
    {
        public Product Product { get; set; }
        public ExpCard(Product product)
        {
            InitializeComponent();
            this.Product = product;
            lblExpDate.Text= product.ExpiredDate.ToShortDateString();
            lblName.Text= product.Name;
            lblShelfNumber.Text = product.ShelfNumber.ToString();
            lblUpc.Text= product.UPC.ToString();
            lblRdate.Text= product.ExpiredDate.Subtract(DateTime.Now).Days.ToString();
        }
    }
}
