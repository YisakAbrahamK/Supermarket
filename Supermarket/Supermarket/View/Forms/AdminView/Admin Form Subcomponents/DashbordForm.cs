using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.View.Forms.Admin.Admin_Form_Subcomponents
{
    public partial class DashbordForm : Form
    {
        Form ParentForm;
        public DashbordForm( Form ParentForm)
        {
            InitializeComponent();
            this.ParentForm = ParentForm;
        }
    }
}
