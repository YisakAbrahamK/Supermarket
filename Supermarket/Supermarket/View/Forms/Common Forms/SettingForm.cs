using Supermarket.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.View.Forms.Casher.Casher_Form_SubComponent
{
    public partial class SettingForm : Form
    {
        Form parentForm;
        Model.Casher Casher;
        Model.Admin Admin;
        public SettingForm(Form parentForm, Model.Casher casher)
        {
            InitializeComponent();
            this.Casher = casher;
            this.parentForm = parentForm;
            txtEmail.Text = casher.Email;
            txtFirstName.Text = casher.FirstName;
            txtLastName.Text = casher.LastName;
            txtLocation.Text = casher.Location;
            txtPhone.Text = casher.Phone;
        }
        public SettingForm(Form parentForm, Model.Admin Admin)
        {
            InitializeComponent();
            this.Admin = Admin;
            this.parentForm = parentForm;
            txtEmail.Text = Admin.Email;
            txtFirstName.Text = Admin.FirstName;
            txtLastName.Text = Admin.LastName;
            txtLocation.Text = Admin.Location;
            txtPhone.Text = Admin.Phone;

        }

    }
}
