using Org.BouncyCastle.Asn1.X509;
using Sunny.UI;
using Supermarket.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.View.Forms.Casher.Casher_Form_SubComponent
{
    public partial class SettingForm : Form
    {
        Form parentForm;
        Model.Casher casher;
        Model.Admin admin;
        public SettingForm(Form parentForm, Model.Casher casher)
        {
            InitializeComponent();
            this.casher = casher;
            this.parentForm = parentForm;
            txtEmail.Text = casher.Email;
            txtFirstName.Text = casher.FirstName;
            txtLastName.Text = casher.LastName;
            txtLocation.Text = casher.Location;
            txtPhone.Text = casher.Phone;
        }
        public SettingForm(Form parentForm, Model.Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.parentForm = parentForm;
            txtEmail.Text = admin.Email;
            txtFirstName.Text = admin.FirstName;
            txtLastName.Text = admin.LastName;
            txtLocation.Text = admin.Location;
            txtPhone.Text = admin.Phone;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using(Context context = new Context())
            {
                if(admin == null)
                {
                    if (txtCPass.Text == casher.Password)
                    {
                        Model.Casher casherData = context.Cashers.Find(casher.Id);
                        casherData.Phone = txtPhone.Text;
                        casherData.FirstName = txtFirstName.Text;
                        casherData.LastName = txtLastName.Text;
                        if(txtNewPass.Text != string.Empty || txtNewPass.Text != null)
                            casherData.Password = txtCPass.Text;
                        casherData.Email = txtEmail.Text;
                        casherData.Location = txtLocation.Text;
                        context.SaveChanges();
                        UIMessageBox.ShowInfo("Change Saved.", true, true);
                    }
                    else
                    {
                        UIMessageBox.ShowInfo("Enter Comformation password.", true, true);
                    }

                }
                else
                {
                    if (txtCPass.Text == admin.Password)
                    {
                        Model.Admin adminData = context.Admins.Find(admin.Id);
                        adminData.Phone = txtPhone.Text;
                        adminData.FirstName = txtFirstName.Text;
                        adminData.LastName = txtLastName.Text;
                        if (txtNewPass.Text != string.Empty || txtNewPass.Text != null)
                            adminData.Password = txtCPass.Text;
                        adminData.Email = txtEmail.Text;
                        adminData.Location = txtLocation.Text;
                        context.SaveChanges();
                        UIMessageBox.ShowInfo("Change Saved.", true, true);
                    }
                    else
                    {
                        UIMessageBox.ShowInfo("Enter Comformation password.", true, true);
                    }

                }
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFirstName.Text != null && txtFirstName.Text != String.Empty)
            {
                if (CustomValid.isValidName(txtFirstName.Text) == false)
                {
                    errorProvider1.SetError(txtFirstName, "Letter(a-z or A-Z) from 2-250 char");
                }
                else
                {
                    errorProvider1.SetError(txtFirstName, string.Empty);
                }
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text != null && txtLastName.Text != String.Empty)
            {
                if (CustomValid.isValidName(txtLastName.Text) == false)
                {
                    errorProvider1.SetError(txtLastName, "Letter(a-z or A-Z) from 1-40 char");
                }
                else
                {
                    errorProvider1.SetError(txtLastName, string.Empty);
                }
            }
        }

        private void txtNewPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPass.Text != null && txtNewPass.Text != String.Empty)
            {
                if (CustomValid.isValidPass(txtNewPass.Text) == false)
                {
                    errorProvider1.SetError(txtNewPass, "Enter valid pass (7 char).");
                }
                else
                {
                    errorProvider1.SetError(txtNewPass, string.Empty);
                }
            }
        }

        private void txtCPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtCPass.Text != null && txtCPass.Text != String.Empty)
            {
                if (CustomValid.isValidPass(txtCPass.Text) == false)
                {
                    errorProvider1.SetError(txtCPass, "Any char (7 char).");
                }
                else
                {
                    errorProvider1.SetError(txtCPass, string.Empty);
                }
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text != null && txtEmail.Text != String.Empty)
            {
                if (CustomValid.isValidEmail(txtEmail.Text) == false)
                {
                    errorProvider1.SetError(txtEmail, "Ex jone@gmail.com");
                }
                else
                {
                    errorProvider1.SetError(txtEmail, string.Empty);
                }
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone.Text != null && txtPhone.Text != String.Empty)
            {
                if (CustomValid.isValidPhone(txtPhone.Text) == false)
                {
                    errorProvider1.SetError(txtPhone, "Ex +9322622565");
                }
                else
                {
                    errorProvider1.SetError(txtPhone, string.Empty);
                }
            }
        }

        private void txtLocation_Validating(object sender, CancelEventArgs e)
        {
            if (txtLocation.Text != null && txtLocation.Text != String.Empty)
            {
                if (CustomValid.isValidLocation(txtLocation.Text) == false)
                {
                    errorProvider1.SetError(txtLocation, "Ex Addis Abeba char 1-250");
                }
                else
                {
                    errorProvider1.SetError(txtLocation, string.Empty);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtLocation.Text = string.Empty;
            txtNewPass.Text = string.Empty;
            txtPhone.Text = String.Empty;
            txtCPass.Text = String.Empty;
            txtEmail.Text = string.Empty;

        }

        private void pbEye_Click(object sender, EventArgs e)
        {
            if (txtNewPass.PasswordChar == '●')
            {
                txtNewPass.PasswordChar = '\0';
            }
            else
            {
                txtNewPass.PasswordChar = '●';
            }
        }

        private void pbEye2_Click(object sender, EventArgs e)
        {
            if (txtCPass.PasswordChar == '●')
            {
                txtCPass.PasswordChar = '\0';
            }
            else
            {
                txtCPass.PasswordChar = '●';
            }
        }
    }
}
