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

namespace Supermarket.View.User_Controls
{
    public partial class CasherCard : UserControl
    {
        public Model.Casher casher { get; set; }

        public PictureBox Delete
        {
            get { return picDelete; }
        }

        public CasherCard(Model.Casher casher)
        {
            InitializeComponent();
            this.casher = casher;
            lblEmail.Text = casher.Email;
            lblName.Text = casher.FirstName + " " + casher.LastName;
        }

    }
}
