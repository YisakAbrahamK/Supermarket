using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.Panals
{
    public partial class EnterNewPass : UserControl
    {
        Form sininForm;
        public EnterNewPass(Form sininForm)
        {
            this.sininForm = sininForm;
            InitializeComponent();
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtConfirmNewPass.Text == txtNewPass.Text)
            {
                this.Dispose();
                Panel pnlSignIn = ((Panel)sininForm.Controls.Find("pnlSignIn", true)[0]);
                pnlSignIn.Show();
            }
        }
    }
}
