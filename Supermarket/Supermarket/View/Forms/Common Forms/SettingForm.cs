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
        public SettingForm(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void uiPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
