using Supermarket.Panals;
using Supermarket.View.Forms;
using Supermarket.View.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.View.User_Controls.SignInControls
{
    public partial class SignIn : UserControl
    {
        Panel pnlContainer;

        public SignIn(Panel pnlContainer)
        {
            InitializeComponent();
            this.pnlContainer = pnlContainer;
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            SendRecoveryCode enterEmail = new SendRecoveryCode(pnlContainer, txtPassword.Text);
            this.Dispose();
            pnlContainer.Controls.Add(enterEmail);
            enterEmail.Dock = DockStyle.Fill;
            enterEmail.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '●')
            {
                txtPassword.PasswordChar= '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CashierForm cashierForm = new CashierForm();
            cashierForm.Show();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
    }
}
