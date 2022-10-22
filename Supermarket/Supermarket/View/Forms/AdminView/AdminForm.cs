using Sunny.UI;
using Supermarket.View.Forms.Admin.Admin_Form_Subcomponents;
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

namespace Supermarket.View.Forms.Admin
{
    public partial class AdminForm : Form
    {
        CasherForm casherForm;
        SettingForm settingForm;
        TransactionHistoryForm transactionHistoryForm;
        ProductForm productForm;
        ExpdateForm expdateForm;
        DashbordForm dashbordForm;
        Model.Admin LogedinAdmin;
        LoginForm loginForm;
        public AdminForm(Model.Admin LogedinAdmin,LoginForm loginForm)
        {
            InitializeComponent();
            casherForm = new CasherForm(this);
            settingForm = new SettingForm(this,LogedinAdmin);
            transactionHistoryForm = new TransactionHistoryForm(this,"Admin",LogedinAdmin);
            productForm = new ProductForm(this);
            expdateForm = new ExpdateForm(this);
            dashbordForm = new DashbordForm(this);
            this.LogedinAdmin = LogedinAdmin;
            this.loginForm = loginForm;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

            loadNavClickForm(dashbordForm);
            //FOR PANEL Dashbord

            addEventForNavs(pnlDashbord);

            //FOR PANEL HISTORY

            addEventForNavs(pnlHistory);

            //FOR PANEL PRODUCT

            addEventForNavs(pnlProduct);

            //FOR PANEL EXPPRODUCT

            addEventForNavs(pnlExpiringProduct);


            //FOR PANEL CASHER

            addEventForNavs(pnlCasher);


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
            if (uiPanal.Name == "pnlDashbord")
            {
                loadNavClickForm(this.dashbordForm);
                lblActiveSelected.Text = "Dashbord";
                //invoiceForm.refreshSize();
            }
            else if (uiPanal.Name == "pnlHistory")
            {
                loadNavClickForm(this.transactionHistoryForm);
                lblActiveSelected.Text = "Transaction";
                transactionHistoryForm.refrashSize();
            }
            else if (uiPanal.Name == "pnlProduct")
            {
                loadNavClickForm(this.productForm);
                lblActiveSelected.Text = "Product";
                productForm.refrashSize();
            }
            else if (uiPanal.Name == "pnlSetting")
            {
                loadNavClickForm(this.settingForm);
                lblActiveSelected.Text = "Setting";
            }
            else if (uiPanal.Name == "pnlCasher")
            {
                loadNavClickForm(this.casherForm);
                lblActiveSelected.Text = "Casher";
                casherForm.refrashSize();
            }
            else if (uiPanal.Name == "pnlExpiringProduct")
            {
                loadNavClickForm(this.expdateForm);
                lblActiveSelected.Text = "Exp Date Lookup";
                expdateForm.refrashSize();
            }
        }

        private void selectOneChoice(UIPanel uiPanal)
        {
            //this funvtion will change the RadiusSides values to indicate the user choice
            pnlDashbord.RadiusSides = UICornerRadiusSides.All;
            pnlProduct.RadiusSides = UICornerRadiusSides.All;
            pnlExpiringProduct.RadiusSides = UICornerRadiusSides.All;
            pnlHistory.RadiusSides = UICornerRadiusSides.All;
            pnlSetting.RadiusSides = UICornerRadiusSides.All;
            pnlCasher.RadiusSides = UICornerRadiusSides.All;
            uiPanal.RadiusSides = UICornerRadiusSides.RightBottom | UICornerRadiusSides.LeftBottom | UICornerRadiusSides.LeftTop;
        }

        private void loadNavClickForm(Form form)
        {
            if(pnlContainer.Controls.Count==1)
                pnlContainer.Controls.RemoveAt(0);
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

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picExitToLogin_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Dispose();
        }
    }
}
