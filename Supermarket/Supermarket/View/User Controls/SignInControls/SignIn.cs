using Supermarket.Model;
using Supermarket.Panals;
using Supermarket.View.Forms;
using Supermarket.View.Forms.Admin;
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
            SendRecoveryCode enterEmail = new SendRecoveryCode(pnlContainer, txtEmail.Text,cbRole.SelectedItem.ToString());
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
            if(cbRole.SelectedItem.ToString()!=null || cbRole.SelectedItem.ToString() != "")
            {
                if (cbRole.SelectedItem.ToString() == "Admin")
                {
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Admin"].ConnectionString);
                    string cmdText = "SELECT * FROM Admins";
                    SqlCommand cmd = new SqlCommand(cmdText,connection);
                    connection.Open();
                    SqlDataReader AdminData = cmd.ExecuteReader();
                    Boolean UserExist=false;

                    Admin admin = new Admin();
                    while (AdminData.Read())
                    {
                        if (txtEmail.Text == AdminData["Email"].ToString() && txtPassword.Text == AdminData["Password"].ToString())
                        {
                            admin.Email = AdminData["Email"].ToString();
                            admin.Gender = Boolean.Parse(AdminData["Gender"].ToString());
                            admin.Id = int.Parse(AdminData["Id"].ToString());
                            admin.Location = AdminData["Location"].ToString();
                            admin.Password = AdminData["Password"].ToString();
                            admin.FirstName = AdminData["FirstName"].ToString();
                            admin.LastName = AdminData["LastName"].ToString();
                            admin.Phone = AdminData["Phone"].ToString();

                            AdminForm adminForm = new AdminForm(admin);
                            adminForm.Show();
                            UserExist = true;
                            connection.Close();
                            return;
                        }
                    }

                    if (UserExist == false)
                    {
                        MessageBox.Show("The user does not exist.");
                        connection.Close();
                    }

                }
                else
                {
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Casher"].ConnectionString);
                    string cmdText = "SELECT * FROM Cashers";
                    SqlCommand cmd = new SqlCommand(cmdText, connection);
                    connection.Open();
                    SqlDataReader CasherData = cmd.ExecuteReader();
                    Boolean UserExist = false;

                    Casher casher = new Casher();
                    while (CasherData.Read())
                    {
                        if (txtEmail.Text == CasherData["Email"].ToString() && txtPassword.Text == CasherData["Password"].ToString())
                        {
                            casher.Email = CasherData["Email"].ToString();
                            casher.Gender = Boolean.Parse(CasherData["Gender"].ToString());
                            casher.Id = int.Parse(CasherData["Id"].ToString());
                            casher.Location = CasherData["Location"].ToString();
                            casher.Password = CasherData["Password"].ToString();
                            casher.FirstName = CasherData["FirstName"].ToString();
                            casher.LastName = CasherData["LastName"].ToString();
                            casher.Phone = CasherData["Phone"].ToString();
                            CashierForm cashierForm = new CashierForm(casher);
                            cashierForm.Show();
                            UserExist = true;
                            connection.Close();
                            return;
                        }
                    }

                    if (UserExist == false)
                    {
                        MessageBox.Show("The user does not exist.");
                        connection.Close();
                    }
                }
            }

        }
    }
}
