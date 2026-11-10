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
    public partial class Adminmenu : Form
    {
        public Adminmenu()
        {
            InitializeComponent();
        }

        private void Adminmenu_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterEmployee_Click(object sender, EventArgs e)
        {
            Employeeregistration employeeRegisterForm = new Employeeregistration();
            employeeRegisterForm.Show();


            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
            else
            {

                return;
            }
        }
    }
}