using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ISAD_Asss
{
    public partial class StaffForm : Form
    {
        private string gender;
        SqlCommand cmd;
        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            myOper.myConnection();
            LoadStaffs();
        }
        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMale.Checked)
            {
                gender = "M";
            }
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFemale.Checked)
            {
                gender = "F";
            }
        }
        private void LoadStaffs()
        {
            string query = "SELECT * FROM tbStaffs";

            try
            {
                using (cmd = new SqlCommand(query, myOper.con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        DGV_Staff.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myOper.con.Close();
        }

        private void BTN_InsertStaff_Click(object sender, EventArgs e)
        {
            string staffID = txtStaffID.Text;
            string staffName = txtStaffName.Text;
            string staffSalary = txtStaffSalary.Text;
            string staffPosition = cmBoxPosition.SelectedItem?.ToString();
            DateTime dateOfBirth = dtDOB.Value;


            if (staffID == "" ||
                staffName == "" ||
                staffSalary == "" ||
                staffPosition == "" ||
                staffPosition == null)
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "INSERT INTO tbStaffs (staffID,fullName, gen, Dob, position, salary) VALUES (@id,@name, @gender,@dateOfBirth, @position, @salary)";
                try
                {
                    myOper.con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, myOper.con))
                    {
                        cmd.Parameters.AddWithValue("@id", staffID);
                        cmd.Parameters.AddWithValue("@name", staffName);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@position", staffPosition);
                        cmd.Parameters.AddWithValue("@salary", staffSalary);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Insert Data successfully!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                myOper.con.Close();
            }
                
                LoadStaffs();
                
            }
        }
    }
