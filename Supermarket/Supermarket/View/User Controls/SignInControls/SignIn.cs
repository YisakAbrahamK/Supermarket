using Supermarket.Model;
using Supermarket.Panals;
using Supermarket.View.Forms;
using Supermarket.View.Forms.Admin;
using Supermarket.View.Forms.Admin.Admin_Form_Subcomponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

        public SignIn(Panel pnlContainer,string Email)
        {
            InitializeComponent();
            this.pnlContainer = pnlContainer;
            txtEmail.Text= Email;
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            string role = tkRole.Checked == true ? "Admin" : "Casher";
            SendRecoveryCode enterEmail = new SendRecoveryCode(pnlContainer, txtEmail.Text,role);
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

            if (tkRole.Checked == true)
            {
                Admin admin = Admin.CheckAdmin(txtEmail.Text, txtPassword.Text);
                if(admin!=null)
                {
                    AdminForm adminForm = new AdminForm(admin, (LoginForm)this.FindForm());
                    adminForm.Show();
                    pnlContainer.FindForm().Hide();
                    txtPassword.Text = String.Empty; // to prevent a user with a access to the app not to get the password by loging out.
                }
                else
                {
                    MessageBox.Show("The user does not exist.");
                }
            }
            else
            {
                Casher casher = Casher.CheckCasher(txtEmail.Text, txtPassword.Text);
                if (casher != null)
                {
                    View.Forms.CashierForm cashierForm = new CashierForm(casher, (LoginForm)this.FindForm());
                    cashierForm.Show();
                    pnlContainer.FindForm().Hide();
                    txtPassword.Text = String.Empty; // to prevent a user with a access to the app not to get the password by loging out.
                }
                else
                {
                    MessageBox.Show("The user does not exist.");
                }
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text != null && txtEmail.Text != String.Empty )
            {
                if (CustomValid.isValidEmail(txtEmail.Text) == false)
                {
                    errorProvider1.SetError(txtEmail, "Enter valid email.");
                }
                else
                {
                    errorProvider1.SetError(txtEmail, string.Empty);
                }
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text != null && txtPassword.Text!= String.Empty)
            {
                if (CustomValid.isValidPass(txtPassword.Text) == false)
                {
                    errorProvider1.SetError(txtPassword, "Enter valid pass (7 char).");
                }
                else
                {
                    errorProvider1.SetError(txtPassword, string.Empty);
                }
            }
        }
    }
}
