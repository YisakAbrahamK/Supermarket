using Sunny.UI;
using Supermarket.Model;
using Supermarket.View.User_Controls;
using Supermarket.View.User_Controls.SignInControls;
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
    public partial class ProductForm : Form
    {
        Form parentForm;
        int selectedProductId=-1;
        public ProductForm(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            loadSearchProductData();
        }

        private void saaToggle1_CheckChanged(object sender, EventArgs e)
        {
            if( saaToggle1.Checked)
            {
                btnAddAndEdit.Text = "Add";
            }
            else
            {
                btnAddAndEdit.Text = "Update";
            }
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

        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {
            txtSearch.Invalidate();
            txtSearch.Refresh();
        }

        private void ProductForm_Resize(object sender, EventArgs e)
        {
            refrashSize();
        }

        private void btnAddAndEdit_Click(object sender, EventArgs e)
        {
            if(btnAddAndEdit.Text == "Add")
            {
                Product product = new Product();
                product.Tax = double.Parse(txtTax.Text);
                product.Name = txtName.Text;
                product.ExpiredDate=dtpExpDate.Value;
                product.Price = double.Parse(txtPrice.Text);
                product.UPC = txtUPC.Text;
                product.ShelfNumber = int.Parse(txtShelfNumber.Text);
                product.Quantity= int.Parse(txtQuantity.Text);
                using (Context context = new Context())
                {
                    context.products.Add(product);
                    context.SaveChanges();
                    UIMessageBox.ShowInfo("Product Added.", true, true);
                    loadSearchProductData();
                    refrashSize();
                }
            }
            else
            {
                if (selectedProductId >= 0)
                {
                    using (Context context = new Context())
                    {
                        Product product = context.products.Find(selectedProductId);
                        product.Tax = double.Parse(txtTax.Text);
                        product.Name = txtName.Text;
                        product.ExpiredDate = dtpExpDate.Value;
                        product.Price = double.Parse(txtPrice.Text);
                        product.UPC = txtUPC.Text;
                        product.ShelfNumber = int.Parse(txtShelfNumber.Text);
                        product.Quantity = int.Parse(txtQuantity.Text);
                        context.SaveChanges();
                        UIMessageBox.ShowInfo("Product Edited.", true, true);
                        loadSearchProductData();
                        refrashSize();
                    }
                }
                else
                {
                    UIMessageBox.ShowInfo("Select Product Before edit.", true, true);
                }

            }
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
                    ProductCard productCard = new ProductCard(product);
                    flowLayoutPanel1.Controls.Add(productCard);
                    productCard.Show();
                    productCard.Click+= (object se, EventArgs ee) =>
                    {
                        txtName.Text = product.Name;
                        txtPrice.Text = product.Price.ToString();
                        txtQuantity.Text = product.Quantity.ToString();
                        txtTax.Text = product.Tax.ToString();
                        txtUPC.Text = product.UPC.ToString();
                        txtShelfNumber.Text = product.ShelfNumber.ToString();
                        dtpExpDate.Value=product.ExpiredDate;
                        selectedProductId = product.Id;
                    };
                    foreach(Control control in productCard.Controls)
                    {
                        control.Click+= (object se, EventArgs ee) =>
                        {
                            txtName.Text = product.Name;
                            txtPrice.Text = product.Price.ToString();
                            txtQuantity.Text = product.Quantity.ToString();
                            txtTax.Text = product.Tax.ToString();
                            txtUPC.Text = product.UPC.ToString();
                            txtShelfNumber.Text = product.ShelfNumber.ToString();
                            dtpExpDate.Value = product.ExpiredDate;
                            selectedProductId = product.Id;

                        };
                        foreach(Control subControl in control.Controls)
                        {
                            subControl.Click+= (object se, EventArgs ee) =>
                            {
                                txtName.Text = product.Name;
                                txtPrice.Text = product.Price.ToString();
                                txtQuantity.Text = product.Quantity.ToString();
                                txtTax.Text = product.Tax.ToString();
                                txtUPC.Text = product.UPC.ToString();
                                txtShelfNumber.Text = product.ShelfNumber.ToString();
                                dtpExpDate.Value = product.ExpiredDate;
                                selectedProductId = product.Id;

                            };
                        }
                    }
                    productCard.picBoxDelete.Click += (object se, EventArgs ee) =>
                    {
                        using(Context context = new Context())
                        {
                            Product p = context.products.Find(product.Id);
                            var transactionDetails = context.TransactionDetails.Where(td => td.product.Id == p.Id);
                            foreach(TransactionDetail  transactionDetail in transactionDetails)
                            {
                                context.TransactionDetails.Remove(transactionDetail);
                            }
                            context.products.Remove(p);
                            context.SaveChanges();
                            loadSearchProductData();
                            refrashSize();
                        }
                    };
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

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtShelfNumber.Text = string.Empty;
            txtUPC.Text = string.Empty;
            txtTax.Text = string.Empty;
            dtpExpDate.Value = DateTime.Now;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text != null && txtName.Text != String.Empty)
            {
                if (CustomValid.isValidName(txtName.Text) == false)
                {
                    errorProvider1.SetError(txtName, "Letter(a-z or A-Z) from 2-250 char");
                }
                else
                {
                    errorProvider1.SetError(txtName, string.Empty);
                }
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrice.Text != null && txtPrice.Text != String.Empty)
            {
                if (CustomValid.isValidDecimalPoint(txtPrice.Text) == false)
                {
                    errorProvider1.SetError(txtPrice, "Eg 4.5");
                }
                else
                {
                    errorProvider1.SetError(txtPrice, string.Empty);
                }
            }
        }

        private void txtTax_Validating(object sender, CancelEventArgs e)
        {
            if (txtTax.Text != null && txtTax.Text != String.Empty)
            {
                if (CustomValid.isValidDecimalPoint(txtTax.Text) == false)
                {
                    errorProvider1.SetError(txtTax, "Eg 4.5");
                }
                else
                {
                    errorProvider1.SetError(txtTax, string.Empty);
                }
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != null && txtQuantity.Text != String.Empty)
            {
                if (CustomValid.isValidInt(txtQuantity.Text) == false)
                {
                    errorProvider1.SetError(txtQuantity, "Eg 4.5");
                }
                else
                {
                    errorProvider1.SetError(txtQuantity, string.Empty);
                }
            }
        }

        private void txtUPC_Validating(object sender, CancelEventArgs e)
        {
            if (txtUPC.Text != null && txtUPC.Text != String.Empty)
            {
                if (CustomValid.isValidUPC(txtUPC.Text) == false)
                {
                    errorProvider1.SetError(txtUPC, "Eg 121232564578");
                }
                else
                {
                    errorProvider1.SetError(txtUPC, string.Empty);
                }
            }
        }

        private void txtShelfNumber_Validating(object sender, CancelEventArgs e)
        {
            if (txtShelfNumber.Text != null && txtShelfNumber.Text != String.Empty)
            {
                if (CustomValid.isValidInt(txtShelfNumber.Text) == false)
                {
                    errorProvider1.SetError(txtShelfNumber, "Eg 12");
                }
                else
                {
                    errorProvider1.SetError(txtShelfNumber, string.Empty);
                }
            }
        }
    }
}
