using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void picClose_MouseEnter(object sender, EventArgs e)
        {

            picClose.Size = picClose.MaximumSize;
            picClose.Location = new Point(585, 18);

        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.Size = picClose.MinimumSize;
            picClose.Location = new Point(585, 23);
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
