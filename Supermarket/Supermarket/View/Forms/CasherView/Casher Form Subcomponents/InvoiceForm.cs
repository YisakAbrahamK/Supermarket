using Org.BouncyCastle.Asn1.Ocsp;
using Sunny.UI;
using Supermarket.Migrations;
using Supermarket.Model;
using Supermarket.View.User_Controls.SignInControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transaction = Supermarket.Model.Transaction;

namespace Supermarket.View.Forms
{
    public partial class InvoiceForm : Form
    {
        Form casherForm;
        Model.Casher casher;
        public InvoiceForm(Form casherForm, Model.Casher casher)
        {
            this.casherForm = casherForm;
            InitializeComponent();
            this.ResizeRedraw = true;
            casherForm.SizeChanged += (Object o, EventArgs e) =>
            {
                //Reduce Graphics Flicker with Double Buffering for Forms and Controls
                refreshSize();
            };
            this.casher = casher;
        }

        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {
            txtSearch.Invalidate();
            txtSearch.Refresh();
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            refreshSize();
        }

        private void flowLayoutPanel2_Resize(object sender, EventArgs e)
        {
            refreshSize();
        }

        public void refreshSize()
        {
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                control.Width = flowLayoutPanel2.Width - 40;
            }
            flowLayoutPanel2.HorizontalScroll.Maximum = 0;
            flowLayoutPanel2.AutoScroll = false;
            flowLayoutPanel2.VerticalScroll.Visible = false;
            flowLayoutPanel2.AutoScroll = true;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Width = flowLayoutPanel1.Width - 40;
            }
            flowLayoutPanel1.HorizontalScroll.Maximum = 0;
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.VerticalScroll.Visible = false;
            flowLayoutPanel1.AutoScroll = true;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            loadAllProduct();
            //Product.lodeTestdata();
            //foreach (Product product in Product.getAllProduct())
            //{
            //    ProductViewCard productViewCard = new ProductViewCard(product);
            //    flowLayoutPanel1.Controls.Add(productViewCard);
            //    productViewCard.Show();
            //    productViewCard.ButtonAdd.Click += (object se, EventArgs ee) =>
            //    {
            //        CartView cartView = new CartView(product);
            //        flowLayoutPanel2.Controls.Add(cartView);
            //        cartView.Show();
            //        cartView.PictureBoxDelete.Click += (object see, EventArgs eee) =>
            //        {
            //            cartView.Dispose();
            //            calculateSummary();
            //        };
            //        cartView.UpDownQuantity.ValueChanged += (object see, int value) =>
            //        {
            //            calculateSummary();
            //        };
            //        calculateSummary();
            //        refreshSize();
            //    };
            //}
        }

        private void calculateSummary()
        {
            double summaryTotal=0;
            double summarySubtotal=0;
            double summaryTax = 0;
            double change=0;
            foreach (CartView cartView in flowLayoutPanel2.Controls)
            {
                summaryTotal += cartView.total;
                summarySubtotal += cartView.subtotal;
                summaryTax += cartView.tax;
            }
            lblSubtotal.Text= string.Format("{0:C}", summarySubtotal);
            lblTotal.Text = string.Format("{0:C}", Math.Round(summaryTotal));
            lblTax.Text = string.Format("{0:C}", summaryTax);
            change = ((txtCash.Texts == "") ? 0 : double.Parse(txtCash.Texts)) - Math.Round(summaryTotal);
            if (change < 0)
            {
                lblChange.Text = "-ve change";
            }
            else
            {
                lblChange.Text = string.Format("{0:C}", change);
            }

            int numberOfTotalQuantity = 0;
            foreach (CartView cart in flowLayoutPanel2.Controls)
            {
                numberOfTotalQuantity += cart.UpDownQuantity.Value;
            }
            lblTotalQuantity.Text = numberOfTotalQuantity.ToString();
        }

        private void txtCash__TextChanged(object sender, EventArgs e)
        {
            if(Double.TryParse(txtCash.Texts,out double cash)||txtCash.Texts==""||txtCash.Texts==null && lblTotalQuantity.Text!="0")
            {
                calculateSummary();
            }
            else
            {
                UIMessageBox.ShowInfo("Enter valid cash amount.", true, true);
            }
        }

        private void loadAllProduct()
        {
            using(Context context = new Context())
            {
                var products = context.products.ToList();
                foreach (Product product in products)
                {
                    if (product.Quantity == 0)
                        continue;
                    ProductViewCard productViewCard = new ProductViewCard(product);
                    flowLayoutPanel1.Controls.Add(productViewCard);
                    productViewCard.Show();
                    productViewCard.ButtonAdd.Click += (object se, EventArgs ee) =>
                    {
                        CartView cartView = new CartView(product);
                        flowLayoutPanel2.Controls.Add(cartView);
                        cartView.Show();
                        cartView.PictureBoxDelete.Click += (object see, EventArgs eee) =>
                        {
                            cartView.Dispose();
                            calculateSummary();
                        };
                        cartView.UpDownQuantity.ValueChanged += (object see, int value) =>
                        {
                            calculateSummary();
                        };
                        calculateSummary();
                        refreshSize();
                    };
                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if(txtSearch.Text == "" || txtSearch.Text == null || txtSearch.Text == " ")
                {
                    loadSearchProductData();
                }
            }
        }

        private void loadSearchProductData()
        {
            int numberOfCard = flowLayoutPanel1.Controls.Count;
            for (int i = 0; i < numberOfCard; i++)
                flowLayoutPanel1.Controls[0].Dispose();
            var products = Product.Search(txtSearch.Texts);
            if(products != null)
            {
                foreach (Product product in products)
                {
                    if (product.Quantity == 0)
                        continue;
                    ProductViewCard productViewCard = new ProductViewCard(product);
                    flowLayoutPanel1.Controls.Add(productViewCard);
                    productViewCard.Show();
                    productViewCard.ButtonAdd.Click += (object se, EventArgs ee) =>
                    {
                        CartView cartView = new CartView(product);
                        flowLayoutPanel2.Controls.Add(cartView);
                        cartView.Show();
                        cartView.PictureBoxDelete.Click += (object see, EventArgs eee) =>
                        {
                            cartView.Dispose();
                            calculateSummary();
                        };
                        cartView.UpDownQuantity.ValueChanged += (object see, int value) =>
                        {
                            calculateSummary();
                        };
                        calculateSummary();
                        refreshSize();
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
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (lblTotalQuantity.Text != "0")
            {
                decimal changeVal=-1;
                try
                {
                    changeVal = Decimal.Parse(lblChange.Text, NumberStyles.Currency);
                }
                catch (Exception ee)
                {

                }
                if(changeVal >= 0)
                {
                    // after passing error and pre conditions
                    Transaction t = addTransaction();
                    UIMessageBox.ShowInfo("Transaction added successfully.", true, true);
                    loadSearchProductData();
                    updateCartData();
                }
                else
                {
                    UIMessageBox.ShowInfo("The cash is not enough.", true, true);
                }
            }
            else
            {
                UIMessageBox.ShowInfo("No product is added into the cart.", true, true);
            }
        }

        Transaction addTransaction()
        {
            Transaction transaction = new Transaction();
            transaction.Quantity= int.Parse(lblTotalQuantity.Text, NumberStyles.Integer);
            transaction.Subtotal= double.Parse(lblSubtotal.Text, NumberStyles.Currency);
            transaction.Tax = double.Parse(lblTax.Text, NumberStyles.Currency);
            transaction.Total = double.Parse(lblTotal.Text, NumberStyles.Currency);
            transaction.PaidAmount= double.Parse(txtCash.Texts);
            transaction.Change= double.Parse(lblChange.Text, NumberStyles.Currency);
            transaction.PurchaseDate = DateTime.Now;
            using (Context context = new Context())
            {
                DbContextTransaction dbTransaction = context.Database.BeginTransaction();
                transaction.Casher = context.Cashers.Find(casher.Id);
                context.Transactions.Add(transaction);
                foreach (CartView cartView in flowLayoutPanel2.Controls)
                {
                    TransactionDetail transactionDetail = new TransactionDetail();
                    transactionDetail.Total = cartView.total;
                    transactionDetail.Tax = cartView.tax;
                    transactionDetail.Subtotal = cartView.subtotal;
                    transactionDetail.Quantity = cartView.UpDownQuantity.Value;
                    transactionDetail.Transaction = context.Transactions.Find(transaction.Id);
                    transactionDetail.product = context.products.Find(cartView.product.Id);
                    context.TransactionDetails.Add(transactionDetail);
                }
                context.SaveChanges();
                dbTransaction.Commit();
            }
            return transaction;
        }

        void removeCart()
        {
            int numberOfCart = flowLayoutPanel2.Controls.Count;
            for (int i = 0; i < numberOfCart; i++)
                flowLayoutPanel2.Controls[0].Dispose();
        }

        void updateCartData()
        {
            //this is called after a product purchase button is clicked
            foreach (CartView cartView in flowLayoutPanel2.Controls)
            {
                cartView.Quantity-=cartView.UpDownQuantity.Value;
                if (cartView.Quantity == 0)
                    cartView.Dispose();
            }
        }
    }
}
