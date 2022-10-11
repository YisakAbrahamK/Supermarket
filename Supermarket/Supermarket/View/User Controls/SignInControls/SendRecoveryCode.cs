using MimeKit;
using MailKit.Net.Smtp;
using System;
using System.Windows.Forms;
using MailKit.Security;

namespace Supermarket.Panals
{
    public partial class SendRecoveryCode : UserControl
    {
        int second;
        int minute;
        int recoveryCode;
        Panel pnlContainer;
        string role;

        public SendRecoveryCode(Panel pnlContainer,string email,string role)
        {
            this.pnlContainer = pnlContainer;
            InitializeComponent();
            txtEmail.Text = email;
            this.role = role;
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            recoveryCode=random.Next(10000, 99999);
            minute = 2;
            second = 0;
            btnSend.Enabled= false;
            if (btnSend.Text == "Resend")
            {
                txtCode.Enabled = true;
                btnSend.Enabled = false;
                lblSent.Text = "Sent";
            }
            MimeMessage mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("Supermarket Management System", "yisakabrahamk@gmail.com"));
            mimeMessage.To.Add(MailboxAddress.Parse(txtEmail.Text));
            mimeMessage.Subject="Password recovery code.";
            mimeMessage.Body = new TextPart("plain")
            {
                Text = "Recovery Code: "+recoveryCode.ToString()
            };
            SmtpClient client = new SmtpClient();
            try
            {
                client.Connect("smtp.gmail.com",587, SecureSocketOptions.StartTls);
                client.Authenticate("yisakabrahamk@gmail.com", "dfdazobkltviwugc");
                client.Send(mimeMessage);
                lblSent.Enabled= true;
            }catch(Exception ex)
            {
                lblSent.Enabled = true;
                lblSent.Text= "Not sent.";
                Console.Write(ex.Message);
                btnSend.Text = "Resend";
                btnSend.Enabled = true;
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
            if (btnSend.Text != "Resend")
            {
                tVerifyPassword.Enabled = true;
                tVerifyPassword.Start();
            }
        }

        private void tVerifyPassword_Tick(object sender, EventArgs e)
        {
            if (second > 0)
            {
                second--;
            }
            else
            {
                if (minute == 0)
                {
                    txtCode.Enabled = false;
                    btnSend.Enabled = false;
                    tVerifyPassword.Stop();
                    btnSend.Text = "Resend";
                    btnSend.Enabled = true;
                    lblSent.Enabled = false;
                }
                else
                {
                    second = 60;
                    minute--;
                    //for test
                    //txtRecoveryCode.Text = recoveryCode.ToString();
                }

            }
            lblTimer.Text = "0"+minute.ToString()+":"+((second<10)?("0"+second.ToString()):second.ToString());
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (recoveryCode.ToString() == txtCode.Text)
            {
               EnterNewPass enterNewPass = new EnterNewPass(pnlContainer,txtEmail.Text,role);
               this.Dispose();
               pnlContainer.Controls.Add(enterNewPass);
               enterNewPass.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("Recovery code was not correct", "Incorrect Code");
            }
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            if (txtCode.PasswordChar == '●')
            {
                txtCode.PasswordChar = '\0';
            }
            else
            {
                txtCode.PasswordChar = '●';
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}

