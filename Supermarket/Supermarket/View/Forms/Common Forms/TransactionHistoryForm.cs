using Sunny.UI;
using Supermarket.Migrations;
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
using Transaction = Supermarket.Model.Transaction;

namespace Supermarket.View.Forms
{
    public partial class TransactionHistoryForm : Form
    {
        Form parentForm;
        Object roleObject;
        string role;
        public TransactionHistoryForm(Form parentForm,string role,Object roleObject)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.roleObject=roleObject;
            this.role = role;
            parentForm.SizeChanged += (Object o, EventArgs e) =>
            {
                refrashSize();
            };
        }
    

        private void CashierTransactionHistoryForm_Load(object sender, EventArgs e)
        {
            refrashSize();
            loadSearchTransactionData();
        }

        private void txtSearch_Resize(object sender, EventArgs e)
        {
            txtSearch.Invalidate();
            txtSearch.Refresh();
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

 

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtSearch.Text == "" || txtSearch.Text == null || txtSearch.Text == " ")
                {
                    loadSearchTransactionData();
                    refrashSize();
                }
            }
        }

        private void loadSearchTransactionData()
        {
            int numberOfCard = flowLayoutPanel1.Controls.Count;
            for (int i = 0; i < numberOfCard; i++)
                flowLayoutPanel1.Controls[0].Dispose();
            if (role == "Casher")
            {
                Model.Casher casher = (Model.Casher)roleObject;
                var transactions = Model.Casher.transactionSearch(txtSearch.Texts,casher);
                if (transactions != null)
                {
                    foreach (Transaction transaction in transactions)
                    {
                        TransactionCard transactionCard = new TransactionCard(transaction); 
                        flowLayoutPanel1.Controls.Add(transactionCard);
                        transactionCard.Show();
                        transactionCard.Click += (object se, EventArgs ee) =>
                        {
                            //after transaction card click
                            loadTransactionDetail(transaction);
                        };
                        foreach (Control control in transactionCard.Controls)
                        {
                            control.Click += (object o, EventArgs e) => {
                                //after transaction card control click
                                loadTransactionDetail(transaction);
                            };
                        }
                    }
                }
                //else
                //{
                //    UIMessageBox.ShowInfo("No result found.", true, true);
                //}
            }
            else
            {
                var transactions = Model.Admin.transactionSearch(txtSearch.Texts);
                if (transactions != null)
                {
                    foreach (Transaction transaction in transactions)
                    {
                        TransactionCard transactionCard = new TransactionCard(transaction);
                        flowLayoutPanel1.Controls.Add(transactionCard);
                        transactionCard.Show();
                        transactionCard.Click += (object se, EventArgs ee) =>
                        {
                            //after transaction card click
                            loadTransactionDetail(transaction);
                        };
                        foreach (Control control in transactionCard.Controls)
                        {
                            control.Click += (object o, EventArgs e) => {
                                //after transaction card control click
                                loadTransactionDetail(transaction);
                            };
                        }
                    }
                }
            }

        }

        private void slSearch_Click(object sender, EventArgs e)
        {
            loadSearchTransactionData();
        }

        void searchTransactionByDate()
        {
            int numberOfCard = flowLayoutPanel1.Controls.Count;
            for (int i = 0; i < numberOfCard; i++)
                flowLayoutPanel1.Controls[0].Dispose();
            if (role == "Casher")
            {
                Model.Casher casher = (Model.Casher)roleObject;
                var transactions = Model.Casher.transactionSearchByDate(rjDatePicker1.Value,rjDatePicker2.Value,casher);
                if (transactions != null)
                {
                    foreach (Transaction transaction in transactions)
                    {
                        TransactionCard transactionCard = new TransactionCard(transaction);
                        flowLayoutPanel1.Controls.Add(transactionCard);
                        transactionCard.Show();
                        transactionCard.Click += (object se, EventArgs ee) =>
                        {
                            //after transaction card click
                            loadTransactionDetail(transaction);
                        };
                        foreach (Control control in transactionCard.Controls)
                        {
                            control.Click += (object o, EventArgs e) => {
                                //after transaction card control click
                                loadTransactionDetail(transaction);
                            };
                        }
                    }
                }
            }
            else
            {
                var transactions = Model.Admin.transactionSearchByDate(rjDatePicker1.Value, rjDatePicker2.Value);
                if (transactions != null)
                {
                    foreach (Transaction transaction in transactions)
                    {
                        TransactionCard transactionCard = new TransactionCard(transaction);
                        flowLayoutPanel1.Controls.Add(transactionCard);
                        transactionCard.Show();
                        transactionCard.Click += (object se, EventArgs ee) =>
                        {
                            //after transaction card click
                            loadTransactionDetail(transaction);
                        };
                        foreach (Control control in transactionCard.Controls)
                        {
                            control.Click += (object o, EventArgs e) => {
                                //after transaction card control click
                                loadTransactionDetail(transaction);
                            };
                        }
                    }
                }
            }
        }

        private void rjDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            searchTransactionByDate();
            refrashSize();
        }

        private void rjDatePicker2_ValueChanged(object sender, EventArgs e)
        {
            searchTransactionByDate();
            refrashSize();
        }
        
        void loadTransactionDetail(Transaction transaction)
        {
            int numberOfCard = flowLayoutPanel2.Controls.Count;
            for (int i = 0; i < numberOfCard; i++)
                flowLayoutPanel2.Controls[0].Dispose();
            using(Context context = new Context())
            {
                var t = from p in context.products  // outer sequence
                        join td in context.TransactionDetails //inner sequence 
                        on p.Id equals td.product.Id // key selector 
                        where td.Transaction.Id == transaction.Id
                        select new
                        { // result selector 
                            ProductName = p.Name,
                            UPC = p.UPC,
                            Quantity = td.Quantity,
                            Total = td.Total
                       };
       

                foreach (var obj in t)
                {
                    TransactionDetailViewCard transactiondetailviewcard = new TransactionDetailViewCard(obj.ProductName,obj.UPC,obj.Quantity,obj.Total);
                    flowLayoutPanel2.Controls.Add(transactiondetailviewcard);
                    refrashSize2();
                }
            }

        }

        public void refrashSize2()
        {
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                control.Width = flowLayoutPanel2.Width - 27;
                control.Height = 195;
            }
            flowLayoutPanel2.HorizontalScroll.Maximum = 0;
            flowLayoutPanel2.AutoScroll = false;
            flowLayoutPanel2.VerticalScroll.Visible = false;
            flowLayoutPanel2.AutoScroll = true;
        }
    }
}
