using Sunny.UI;
using Supermarket.Model;
using Supermarket.View.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Supermarket.View.Forms.Admin.Admin_Form_Subcomponents
{
    public partial class CasherForm : Form
    {
        Form adminForm;
        int selectedCasherId = -1;
        public CasherForm(Form adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
            adminForm.SizeChanged += (Object sender, EventArgs EventArgs) => {
                refrashSize();
            };
            loadSearchCasherData();
            refrashSize();
        }

        private void saaToggle1_CheckChanged(object sender, EventArgs e)
        {
            if( saaToggle1.Checked)
            {
                btnAddAndEdit.Text = "Add";
            }
            else
            {
                btnAddAndEdit.Text = "Update";
            }
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

        private void CasherForm_Load(object sender, EventArgs e)
        {
            refrashSize();
        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            txtSearch.Invalidate();
            txtSearch.Refresh();
        }

        private void btnAddAndEdit_Click(object sender, EventArgs e)
        {
            if (btnAddAndEdit.Text == "Add")
            {
                Model.Casher casher = new Model.Casher();
                casher.FirstName =txtFirstName.Text;
                casher.LastName =txtLastName.Text;
                casher.Location = txtLocation.Text;
                casher.Password = txtNewPass.Text;
                casher.Email = txtmail.Text;
                casher.Phone = txtPhone.Text;
                if (rbMale.Checked==true)
                {
                    casher.Gender = true;
                }
                else
                {
                    casher.Gender = true;
                }
                using (Context context = new Context())
                {
                    context.Cashers.Add(casher);
                    context.SaveChanges();
                    UIMessageBox.ShowInfo("Casher Added.", true, true);
                    loadSearchCasherData();
                    refrashSize();
                }
            }
            else
            {
                if (selectedCasherId >= 0)
                {
                    using (Context context = new Context())
                    {
                        Model.Casher casher = context.Cashers.Find(selectedCasherId);
                        casher.FirstName = txtFirstName.Text;
                        casher.LastName = txtLastName.Text;
                        casher.Location = txtLocation.Text;
                        if(txtNewPass.Text!=string.Empty)
                            casher.Password = txtNewPass.Text;
                        casher.Email = txtmail.Text;
                        casher.Phone = txtPhone.Text;
                        if (rbMale.Checked == true)
                        {
                            casher.Gender = true;
                        }
                        else
                        {
                            casher.Gender = false;
                        }
                        context.SaveChanges();
                        UIMessageBox.ShowInfo("Casher Edited.", true, true);
                        loadSearchCasherData();
                        refrashSize();
                    }
                }
                else
                {
                    UIMessageBox.ShowInfo("Select Casher Before edit.", true, true);
                }

            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text=String.Empty;
            txtLastName.Text=String.Empty;
            txtLocation.Text=String.Empty;
            txtmail.Text=String.Empty;
            txtNewPass.Text = String.Empty;
            txtPhone.Text = String.Empty;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtSearch.Text == "" || txtSearch.Text == null || txtSearch.Text == " ")
                {
                    loadSearchCasherData();
                    refrashSize();
                }
            }
        }

        private void loadSearchCasherData()
        {
            int numberOfCard = flowLayoutPanel1.Controls.Count;
            for (int i = 0; i < numberOfCard; i++)
                flowLayoutPanel1.Controls[0].Dispose();
            var cashers = Model.Casher.Search(txtSearch.Texts);
            if (cashers != null)
            {
                foreach (Model.Casher casher in cashers)
                {
                    CasherCard casherCard = new CasherCard(casher);
                    flowLayoutPanel1.Controls.Add(casherCard);
                    casherCard.Click += (object se, EventArgs ee) =>
                    {
                        selectedCasherId = casher.Id;
                        txtFirstName.Text = casher.FirstName;
                        txtLastName.Text = casher.LastName;
                        txtLocation.Text = casher.Location;
                        txtmail.Text = casher.Email;
                        txtPhone.Text = casher.Phone;
                        txtNewPass.Text = String.Empty;
                        if (casher.Gender == true)
                        {
                            rbMale.Checked = true;
                        }
                        else
                        {
                            rbFemale.Checked = true;
                        }
                    };
                    foreach (Control control in casherCard.Controls)
                    {
                        control.Click += (object se, EventArgs ee) =>
                        {
                            selectedCasherId = casher.Id;
                            txtFirstName.Text = casher.FirstName;
                            txtLastName.Text = casher.LastName;
                            txtLocation.Text = casher.Location;
                            txtmail.Text = casher.Email;
                            txtPhone.Text = casher.Phone;
                            txtNewPass.Text = String.Empty;
                            if (casher.Gender == true)
                            {
                                rbMale.Checked = true;
                            }
                            else
                            {
                                rbFemale.Checked = true;
                            }
                        };
                        foreach (Control subControl in control.Controls)
                        {
                            subControl.Click += (object se, EventArgs ee) =>
                            {
                                selectedCasherId = casher.Id;
                                txtFirstName.Text = casher.FirstName;
                                txtLastName.Text = casher.LastName;
                                txtLocation.Text = casher.Location;
                                txtmail.Text = casher.Email;
                                txtPhone.Text = casher.Phone;
                                txtNewPass.Text = String.Empty;
                                if (casher.Gender == true)
                                {
                                    rbMale.Checked = true;
                                }
                                else
                                {
                                    rbFemale.Checked = true;
                                }
                            };
                        }
                    }
                    casherCard.Delete.Click += (object se, EventArgs ee) =>
                    {
                        using (Context context = new Context())
                        {
                            Model.Casher c = context.Cashers.Find(casher.Id);
                            var transactions = context.Transactions.Where(t => t.Id == c.Id);
                            foreach (Model.Transaction transaction in transactions)
                            {
                                context.Transactions.Remove(transaction);
                            }
                            context.Cashers.Remove(c);
                            context.SaveChanges();
                            loadSearchCasherData();
                        }
                    };
                }
            }
            else
            {
                UIMessageBox.ShowInfo("No result found.", true, true);
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFirstName.Text != null && txtFirstName.Text != String.Empty)
            {
                if (CustomValid.isValidName(txtFirstName.Text) == false)
                {
                    errorProvider1.SetError(txtFirstName, "Enter any char(1-40)");
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
                    errorProvider1.SetError(txtLastName, "Enter any char(1-40)");
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
                    errorProvider1.SetError(txtNewPass, "Enter any 7 char");
                }
                else
                {
                    errorProvider1.SetError(txtNewPass, string.Empty);
                }
            }
        }

        private void txtmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtmail.Text != null && txtmail.Text != String.Empty)
            {
                if (CustomValid.isValidEmail(txtmail.Text) == false)
                {
                    errorProvider1.SetError(txtmail, "Eg fon@gmail.com");
                }
                else
                {
                    errorProvider1.SetError(txtmail, string.Empty);
                }
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone.Text != null && txtPhone.Text != String.Empty)
            {
                if (CustomValid.isValidPhone(txtPhone.Text) == false)
                {
                    errorProvider1.SetError(txtPhone, "Eg +251932900261 or 0932900261");
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
                    errorProvider1.SetError(txtLocation, "Eg Addis Abeba");
                }
                else
                {
                    errorProvider1.SetError(txtLocation, string.Empty);
                }
            }
        }

        private void pbSee_Click(object sender, EventArgs e)
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
    }
}
