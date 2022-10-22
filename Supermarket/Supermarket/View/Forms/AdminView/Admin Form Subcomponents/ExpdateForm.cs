using Sunny.UI;
using Supermarket.Model;
using Supermarket.View.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Supermarket.View.Forms.Admin.Admin_Form_Subcomponents
{
    public partial class ExpdateForm : Form
    {
        Form parentForm;
        public ExpdateForm(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            parentForm.Resize += (Object sender, EventArgs e) =>
            {
                refrashSize();
            };
            loadSearchProductData();
            refrashSize();
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

        private void ExpdateForm_Resize(object sender, EventArgs e)
        {
            txtSearch.Invalidate();
            txtSearch.Refresh();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtSearch.Text == "" || txtSearch.Text == null || txtSearch.Text == " ")
                {
                    loadSearchProductData();
                    refrashSize();
                }
            }
        }

        private void loadSearchProductData()
        {
            int numberOfCard = flowLayoutPanel1.Controls.Count;
            for (int i = 0; i < numberOfCard; i++)
                flowLayoutPanel1.Controls[0].Dispose();
            var products = Product.Search(txtSearch.Texts);
            if (products != null)
            {
                foreach (Product product in products)
                {
                    if (product.Quantity == 0)
                        continue;
                    ExpCard expCard = new ExpCard(product);
                    flowLayoutPanel1.Controls.Add(expCard);
                }
            }
            else
            {
                UIMessageBox.ShowInfo("No result found.", true, true);
            }
        }

        private void slSearch_Click(object sender, EventArgs e)
        {
            loadSearchProductData();
            refrashSize();
        }
    }
}
