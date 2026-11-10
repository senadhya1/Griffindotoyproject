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
    public partial class Employeeregistration : Form
    {
        public Employeeregistration()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=SENURI;Initial Catalog=Griffindo;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataAdapter SqlDa = new SqlDataAdapter();


        private void loadEmpIds()
        {
            try
            {
                connection.Open();
                string selectQuery = "SELECT EmpId FROM Employeeregistration;";
                SqlDa = new SqlDataAdapter(selectQuery, connection);
                DataTable dt = new DataTable();
                SqlDa.Fill(dt);

                cmbEmpID.Items.Clear();
                cmbEmpID.Items.Add("-Select EmpId-");

                foreach (DataRow dr in dt.Rows)
                {
                    cmbEmpID.Items.Add(dr["EmpId"]);
                }

                cmbEmpID.SelectedIndex = 0;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpHireDate.Value = DateTime.Now;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtAddress.Clear();
            txtPhone.Clear();
            txtNIC.Clear();

            cmbEmpID.SelectedIndex = 0;
        }
        private void Employeeregistration_Load(object sender, EventArgs e)
        {
            loadEmpIds();
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Exit??", "Confirm to Exit", MessageBoxButtons.YesNo,
MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                (txtFirstName.Text == string.Empty ||
                txtLastName.Text == string.Empty ||
                dtpHireDate.Value == DateTime.Now ||
                txtAddress.Text == string.Empty ||
                txtPhone.Text == string.Empty ||
                txtNIC.Text == string.Empty ||
                
                cmbStatus.SelectedIndex == 0) ||
                (rbFemale.Checked == false && rbMale.Checked == false)
                )
                {
                    MessageBox.Show("Please Fill the Required Feilds !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string FirstName = txtFirstName.Text;
                    string LastName = txtLastName.Text;
                    DateTime HireDate = dtpHireDate.Value;
                    string NIC = txtNIC.Text;

                    string Gender;
                    if (rbMale.Checked)
                    {
                        Gender = "Male";
                    }
                    else
                    {
                        Gender = "Female";
                    }
                    string Addres = txtAddress.Text;
                    int Phone = Convert.ToInt32(txtPhone.Text);
                    string Status = cmbStatus.Text;
                    connection.Open();
                    string insertQuery = "INSERT INTO Employeeregistration VALUES('" + FirstName + "', '" + LastName + "', '" + HireDate + "', '" + Gender + "', '" + Addres + "', '" + NIC + "', " + Phone + ", '" + Status + "');";
                    command = new SqlCommand(insertQuery, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    loadEmpIds();
                    ClearForm();

                    MessageBox.Show("Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void cmbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpID.SelectedIndex > 0)
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM Employeeregistration WHERE EmpId = '" + cmbEmpID.Text + "';";
                    SqlDa = new SqlDataAdapter(selectQuery, connection);
                    DataTable dataTable = new DataTable();
                    SqlDa.Fill(dataTable);

                    foreach (DataRow dr in dataTable.Rows)
                    {
                        txtFirstName.Text = dr["FirstName"].ToString();
                        txtLastName.Text = dr["LastName"].ToString();
                        dtpHireDate.Value = Convert.ToDateTime(dr["HireDate"]);
                        txtNIC.Text = dr["NIC"].ToString();

                        string Gender = dr["Gender"].ToString();
                        if (Gender == "Male")
                        {
                            rbMale.Checked = true;
                        }
                        else
                        {
                            rbFemale.Checked = true;
                        }

                        txtAddress.Text = dr["Addres"].ToString();
                        txtPhone.Text = "0" + dr["Phone"].ToString();
                        cmbStatus.Text = dr["Status"].ToString();
                    }
                    connection.Close();
                }
                else
                {
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                (txtFirstName.Text == string.Empty ||
                txtLastName.Text == string.Empty ||
                dtpHireDate.Value == DateTime.Now ||
                txtAddress.Text == string.Empty ||
                txtPhone.Text == string.Empty ||
                txtNIC.Text == string.Empty ||
                cmbStatus.SelectedIndex == 0) ||
                (rbFemale.Checked == false && rbMale.Checked == false)
                )
                {
                    MessageBox.Show("Please Fill the Required Feilds !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cmbEmpID.SelectedIndex > 0)
                    {
                        int EmpId = Convert.ToInt32(cmbEmpID.Text);
                        string FirstName = txtFirstName.Text;
                        string LastName = txtLastName.Text;
                        DateTime HireDate = dtpHireDate.Value;
                        string NIC = txtNIC.Text;

                        string Gender;
                        if (rbMale.Checked)
                        {
                            Gender = "Male";
                        }
                        else
                        {
                            Gender = "Female";
                        }

                        string Addres = txtAddress.Text;
                        int Phone = Convert.ToInt32(txtPhone.Text);
                        string Status = cmbStatus.Text;

                        string updateQuery = "UPDATE Employeeregistration SET FirstName = '" + FirstName + "', LastName = '" + LastName + "', HireDate = '" + HireDate + "', Gender = '" + Gender + "', Addres = '" + Addres + "', NIC = '" + NIC + "', Phone = " + Phone + ", Status = '" + Status + "' WHERE EmpID = " + EmpId + "; ";
                        connection.Open();
                        command = new SqlCommand(updateQuery, connection);
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Record Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Please Select an Employee ID to Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult deleteResponse = MessageBox.Show("Are you sure you want to Delete this record?", "Confirm to Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (deleteResponse == DialogResult.Yes)
            {
                try
                {
                    if (cmbEmpID.SelectedIndex > 0)
                    {
                        int EmpId = Convert.ToInt32(cmbEmpID.Text);
                        string deleteQuery = "DELETE FROM Employeeregistration WHERE EmpId = " + EmpId + ";";

                        connection.Open();
                        command = new SqlCommand(deleteQuery, connection);
                        command.ExecuteNonQuery();
                        connection.Close();

                        ClearForm();
                        loadEmpIds();

                        MessageBox.Show("Record Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Please Select an Employee ID to Delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                // Do nothing 
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblEmpId.Visible = true;
            cmbEmpID.Visible = true;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;

            btnClear.Visible = false;
            btnRegister.Visible = false;


            btnSearch.Visible = false;

            loadEmpIds();
            ClearForm();

            cmbEmpID.Focus();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult logoutResponse = MessageBox.Show("Are you sure you want to Logout??", "Confirm to Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logoutResponse == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
            else
            {
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.TextLength < 10)
            {
                txtPhone.ForeColor = Color.Red;
            }
            else
            {
                txtPhone.ForeColor = Color.Green;
            }
        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtNIC.TextLength == 10 || txtNIC.TextLength == 12)
            {
                txtNIC.ForeColor = Color.Green;
            }
            else
            {
                txtNIC.ForeColor = Color.Red;
            }
        }
    }
}

