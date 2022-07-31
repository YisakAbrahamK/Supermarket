using MimeKit;
using MailKit;
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
        Form sininForm;

        public SendRecoveryCode(Form sininForm,string email)
        {
            this.sininForm = sininForm;
            InitializeComponent();
            txtEmail.Text = email;
        }
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            System.Random random = new System.Random();
            recoveryCode=random.Next(10000, 99999);
            minute = 2;
            second = 0;
            btnSendCode.Enabled= false;
            if (btnSendCode.Text == "Resend")
            {
                txtRecoveryCode.Enabled = true;
                btnVerify.Enabled = true;
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
                txtRecoveryCode.Text = ex.Message;
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
            tVerifyPassword.Enabled = true;
            tVerifyPassword.Start();
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
                    txtRecoveryCode.Enabled = false;
                    btnVerify.Enabled = false;
                    tVerifyPassword.Stop();
                    btnSendCode.Text = "Resend";
                    btnSendCode.Enabled = true;
                }
                else
                {
                    second = 60;
                    minute--;
                    lblSent.Enabled = false;
                    //for test
                    //txtRecoveryCode.Text = recoveryCode.ToString();
                }

            }
            lblTimer.Text = "0"+minute.ToString()+":"+((second<10)?("0"+second.ToString()):second.ToString());
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (recoveryCode.ToString() == txtRecoveryCode.Text)
            {
                EnterNewPass enterNewPass = new EnterNewPass(sininForm);

                //Panel pnl = ((Panel) sininForm.Controls.Find("pnlSignIn", true)[0]);
                //pnl.Hide();
                this.Dispose();
                Panel pnlMainLogin = ((Panel)sininForm.Controls.Find("pnlMainLogin", true)[0]);
                enterNewPass.Dock = DockStyle.Fill;
                pnlMainLogin.Controls.Add(enterNewPass);
            }
            else
            {
                MessageBox.Show("Recovery code was not correct", "Incorrect Code");
            }
        }

    }
}

