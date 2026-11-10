using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Griffindotoyproject
{
    public partial class Employeemenu : Form
    {
        public Employeemenu()
        {
            InitializeComponent();
        }

        private void lblLeaveManagement_Click(object sender, EventArgs e)
        {
            LeaveManagement LeaveManagement = new LeaveManagement();
            LeaveManagement.Show();


            this.Hide();
        }
    }
}
