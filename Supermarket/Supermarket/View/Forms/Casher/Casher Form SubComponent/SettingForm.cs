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
        Form casherForm;
        public SettingForm(Form casherForm)
        {
            InitializeComponent();
            this.casherForm = casherForm;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void uiPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
