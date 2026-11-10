using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Griffindotoyproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=SENURI;Initial Catalog=Griffindo;Integrated Security=True");
        SqlDataAdapter SqlDa = new SqlDataAdapter();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {

                string selectUsers = "SELECT * FROM Login WHERE username = '" + username + "' AND password = '" + password + "'";


                connection.Open();
                SqlDa = new SqlDataAdapter(selectUsers, connection);


                DataTable dt = new DataTable();
                SqlDa.Fill(dt);


                if (dt.Rows.Count > 0)
                {

                    string role = dt.Rows[0]["Role"].ToString();


                    if (role == "Admin")
                    {
                        Adminmenu adminMenuForm = new Adminmenu();
                        adminMenuForm.Show();
                        this.Hide();
                    }

                    else if (role == "Employee")
                    {
                        Employeemenu employeeMenuForm = new Employeemenu();
                        employeeMenuForm.Show();
                        this.Hide();
                    }
                }
                else
                {

                    MessageBox.Show("Invalid Login details, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is always closed
                connection.Close();
            }
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
