using Supermarket.Model;
using Supermarket.View.Forms.Admin;
using Supermarket.View.User_Controls.SignInControls;
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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Supermarket.Panals
{
    public partial class EnterNewPass : UserControl
    {
        Panel pnlContainer;
        string email;
        string role;
        public EnterNewPass(Panel pnlContainer,string email,string role)
        {
            InitializeComponent();
            this.pnlContainer = pnlContainer;
            this.email = email;
            this.role = role;
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '●')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void btnSeeConfirm_Click(object sender, EventArgs e)
        {
            if (txtCPassword.PasswordChar == '●')
            {
                txtCPassword.PasswordChar = '\0';
            }
            else
            {
                txtCPassword.PasswordChar = '●';
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[role].ConnectionString);
            string cmdText = $"UPDATE {role}s SET Password='{txtPassword.Text}' WHERE Email='{email}'";
            SqlCommand cmd = new SqlCommand(cmdText, connection);
            connection.Open();
            int RowAffected = cmd.ExecuteNonQuery();

            SignIn signIn = new SignIn(pnlContainer, email);
            this.Dispose();
            pnlContainer.Controls.Add(signIn);
            signIn.Dock = DockStyle.Fill;
            signIn.Show();
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text != null && txtPassword.Text != String.Empty)
            {
                if (CustomValid.isValidPass(txtPassword.Text) == false)
                {
                    errorProvider1.SetError(txtPassword, "Any 7 char");
                }
                else
                {
                    errorProvider1.SetError(txtPassword, string.Empty);
                }
            }
        }

        private void txtCPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtCPassword.Text != null && txtCPassword.Text != String.Empty)
            {
                if (CustomValid.isValidPass(txtCPassword.Text) == false)
                {
                    errorProvider1.SetError(txtCPassword, "Any 7 char");
                }
                else
                {
                    errorProvider1.SetError(txtCPassword, string.Empty);
                }
            }
        }
    }
 }
