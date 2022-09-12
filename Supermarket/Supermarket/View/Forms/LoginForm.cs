using Supermarket.View.User_Controls.SignInControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.View.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SignIn signIn = new SignIn(pnlContainer);
            pnlContainer.Controls.Add(signIn);
            signIn.Dock= DockStyle.Fill;
            signIn.Show();
            makeTheFormMovable();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        void makeTheFormMovable()
        {
            foreach (Control control in this.Controls)
            {
                control.MouseDown += (object sender, MouseEventArgs e) =>
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, 0x112, 0xf012, 0);
                };
                foreach (Control innerControl in control.Controls)
                {
                    innerControl.MouseDown += (object sender, MouseEventArgs e) =>
                    {
                        ReleaseCapture();
                        SendMessage(this.Handle, 0x112, 0xf012, 0);
                    };
                }
            }
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.Location = new Point(341, 7);
            picClose.Size = new Size(52, 52);
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.Location= new Point(341, 14);
            picClose.Size = new Size(49, 42);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saaCard1_Click(object sender, EventArgs e)
        {

        }
    }
}
