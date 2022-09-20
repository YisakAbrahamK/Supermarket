using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public EnterNewPass(Panel pnlContainer)
        {
            InitializeComponent();
            this.pnlContainer = pnlContainer;
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
    }
}
