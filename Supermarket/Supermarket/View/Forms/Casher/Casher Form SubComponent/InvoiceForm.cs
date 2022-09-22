using Sunny.UI;
using Supermarket.Model;
using Supermarket.View.User_Controls.SignInControls;
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

namespace Supermarket.View.Forms
{
    public partial class InvoiceForm : Form
    {
        Form casherForm;
        public InvoiceForm(Form casherForm)
        {
            this.casherForm = casherForm;
            InitializeComponent();
            this.ResizeRedraw = true;
            casherForm.SizeChanged += (Object o, EventArgs e) =>
            {
                //Reduce Graphics Flicker with Double Buffering for Forms and Controls
                refreshSize();
            };
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

            Product.lodeTestdata();
            foreach (Product product in Product.getAllProduct())
            {
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
            lblTotal.Text=string.Format("{0:C}",Math.Round(summaryTotal));
            lblSubtotal.Text = string.Format("{0:C}", summarySubtotal);
            lblTax.Text = string.Format("{0:C}", summaryTax);
            change = ((txtCash.Texts == "") ? 0 : Math.Round(double.Parse(txtCash.Texts))) - Math.Round(summaryTotal);
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
            calculateSummary();
        }
    }
}
