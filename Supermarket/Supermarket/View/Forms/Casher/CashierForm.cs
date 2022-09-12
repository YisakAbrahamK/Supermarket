using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.View.Forms
{
    public partial class CashierForm : Form
    {
        InvoiceForm invoiceForm;
        CashierTransactionHistoryForm cashierTransactionHistoryForm = new CashierTransactionHistoryForm();

        public CashierForm()
        {
            InitializeComponent();
            invoiceForm = new InvoiceForm(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            if(pnlContainer.Controls.Count > 0)
            {
                pnlContainer.Controls.RemoveAt(0);
            }
            invoiceForm.TopLevel = false;
            pnlContainer.Controls.Add(invoiceForm);
            invoiceForm.Dock = DockStyle.Fill;
            invoiceForm.Show();


            //FOR PANEL INVOICE

            addEventForNavs(pnlInvoice);
            pnlInvoice.RectColor = Color.DarkSlateGray;
            pnlInvoice.FillColor = Color.DarkSlateGray;
            //FOR PANEL HISTORY

            addEventForNavs(pnlHistory);
            pnlHistory.RectColor = Color.DarkSlateGray;
            pnlHistory.FillColor = Color.DarkSlateGray;

            //FOR PANAL SETTING

            addEventForNavs(pnlSetting);
            pnlSetting.RectColor = Color.DarkSlateGray;
            pnlSetting.FillColor = Color.DarkSlateGray;


        }

        private void selectOneChoice(UIPanel uiPanal)
        {
            pnlInvoice.RadiusSides = UICornerRadiusSides.All;
            pnlHistory.RadiusSides = UICornerRadiusSides.All;
            pnlSetting.RadiusSides = UICornerRadiusSides.All;
            uiPanal.RadiusSides = UICornerRadiusSides.RightBottom | UICornerRadiusSides.LeftBottom | UICornerRadiusSides.LeftTop;
        }

        private void mouseEnterForNavs(UIPanel uiPanal)
        {
            uiPanal.FillColor = Color.Gray;
            foreach (Control control in uiPanal.Controls)
            {
                control.BackColor = Color.Gray;
            }
        }

        private void mouseLeaveForNavs(UIPanel uiPanal)
        {
            uiPanal.FillColor = Color.DarkSlateGray;
            foreach(Control control in uiPanal.Controls)
            {
                control.BackColor= Color.DarkSlateGray;
            }
        }

        private void addEventForNavs(UIPanel uiPanal)
        {
            uiPanal.Click += (Object s, EventArgs ee) =>
            {
                selectOneChoice(uiPanal);
                if (uiPanal.Name == "pnlInvoice")
                {
                    loadNavClickForm(this.invoiceForm);
                    lblActiveSelected.Text = "Invoice";
                }else if(uiPanal.Name == "pnlHistory")
                {
                    loadNavClickForm(this.cashierTransactionHistoryForm);
                    lblActiveSelected.Text = "Transaction";
                }
            };
            uiPanal.MouseEnter += (Object s, EventArgs ee) =>
            {
                mouseEnterForNavs(uiPanal);
            };
            uiPanal.MouseLeave += (Object s, EventArgs ee) =>
            {
                mouseLeaveForNavs(uiPanal);
            };
            foreach (Control control in uiPanal.Controls)
            {
                control.Click += (Object s, EventArgs ee) =>
                {
                    selectOneChoice(uiPanal);
                    if (uiPanal.Name == "pnlInvoice")
                    {
                        loadNavClickForm(this.invoiceForm);
                        lblActiveSelected.Text = "Invoice";
                    }
                    else if (uiPanal.Name == "pnlHistory")
                    {
                        loadNavClickForm(this.cashierTransactionHistoryForm);
                        lblActiveSelected.Text = "Transaction";
                    }
                };
                control.MouseLeave += (Object s, EventArgs ee) =>
                {
                    mouseLeaveForNavs(uiPanal);
                };
                control.MouseEnter += (Object s, EventArgs ee) =>
                {
                    mouseEnterForNavs(uiPanal);
                };
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHistory_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.RemoveAt(0);
            cashierTransactionHistoryForm.TopLevel = false;
            pnlContainer.Controls.Add(cashierTransactionHistoryForm);
            cashierTransactionHistoryForm.Dock = DockStyle.Fill;
            cashierTransactionHistoryForm.Show();
        }

        private void loadNavClickForm(Form form)
        {
            pnlContainer.Controls.RemoveAt(0);
            form.TopLevel = false;
            pnlContainer.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
