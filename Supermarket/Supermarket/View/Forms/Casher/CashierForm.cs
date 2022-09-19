using Sunny.UI;
using Supermarket.View.Forms.Casher.Casher_Form_SubComponent;
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
        CashierTransactionHistoryForm cashierTransactionHistoryForm;
        SettingForm settingForm;

        public CashierForm()
        {
            InitializeComponent();
            invoiceForm = new InvoiceForm(this);
            cashierTransactionHistoryForm = new CashierTransactionHistoryForm(this);
            settingForm = new SettingForm(this);
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            invoiceForm.TopLevel = false;
            pnlContainer.Controls.Add(invoiceForm);
            invoiceForm.Dock = DockStyle.Fill;
            invoiceForm.Show();


            //FOR PANEL INVOICE

            addEventForNavs(pnlInvoice);

            //FOR PANEL HISTORY

            addEventForNavs(pnlHistory);


            //FOR PANAL SETTING

            addEventForNavs(pnlSetting);



        }

        private void addEventForNavs(UIPanel uiPanal)
        {
            uiPanal.Click += (Object s, EventArgs ee) =>
            {
                navClickEventAction(uiPanal);
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
                    navClickEventAction(uiPanal);
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

        private void navClickEventAction(UIPanel uiPanal)
        {
            selectOneChoice(uiPanal); //will change the radius values to indicate the change
            if (uiPanal.Name == "pnlInvoice")
            {
                loadNavClickForm(this.invoiceForm);
                lblActiveSelected.Text = "Invoice";
                invoiceForm.refreshSize();
            }
            else if (uiPanal.Name == "pnlHistory")
            {
                loadNavClickForm(this.cashierTransactionHistoryForm);
                lblActiveSelected.Text = "Transaction";
                cashierTransactionHistoryForm.refrashSize();
            }
            else if (uiPanal.Name == "pnlSetting")
            {
                loadNavClickForm(this.settingForm);
                lblActiveSelected.Text = "Setting";    
            }
        }

        private void selectOneChoice(UIPanel uiPanal)
        {
            //this funvtion will change the RadiusSides values to indicate the user choice
            pnlInvoice.RadiusSides = UICornerRadiusSides.All;
            pnlHistory.RadiusSides = UICornerRadiusSides.All;
            pnlSetting.RadiusSides = UICornerRadiusSides.All;
            uiPanal.RadiusSides = UICornerRadiusSides.RightBottom | UICornerRadiusSides.LeftBottom | UICornerRadiusSides.LeftTop;
        }

        private void loadNavClickForm(Form form)
        {
            pnlContainer.Controls.RemoveAt(0);
            if(form.TopLevel==true)
                form.TopLevel = false;
            pnlContainer.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
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
            foreach (Control control in uiPanal.Controls)
            {
                control.BackColor = Color.DarkSlateGray;
            }
        }
    }
}
