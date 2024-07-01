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

namespace ISAD_Asss
{
 
    public partial class CustomerForm : Form
    {
        SqlCommand cmd;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void BTN_backToHome_Click(object sender, EventArgs e)
        {
            Home Home_form = new Home();

            // Show the new form
            Home_form.Show();
            this.Hide();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            myOper.myConnection();
            LoadCustomers();
        }

        private void BTN_InsertCus_Click(object sender, EventArgs e)
        {
            string cusName = txtCusName.Text;
            string cusCon = txtCusCon.Text;
            string query = "INSERT INTO tbCustomers (cusName, cusCon) VALUES ('" + cusName + "','" + cusCon + "' )";
            
            SqlCommand cmd = new SqlCommand(query, myOper.con);
            cmd.ExecuteNonQuery();
            LoadCustomers();
            myOper.con.Close();
        }

        string query = "SELECT * FROM tbCustomers";
        private void LoadCustomers()
        {
            string query = "SELECT * FROM tbCustomers";

            try
            {
                using (cmd = new SqlCommand(query, myOper.con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        DGV_Customer.DataSource = dt; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myOper.con.Close();
        }

        private void BTN_clearCus_Click(object sender, EventArgs e)
        {
            txtCusID.Clear();
            txtCusCon.Clear();
            txtCusName.Clear();
        }

        private void DGV_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DGV_Customer.Rows[e.RowIndex];
            txtCusID.Text = selectedRow.Cells[0].Value.ToString();
            txtCusName.Text = selectedRow.Cells[1].Value.ToString();
            txtCusCon.Text = selectedRow.Cells[2].Value.ToString();
        }

        private void BTN_UpdateCus_Click(object sender, EventArgs e)
        {
            string query = "UPDATE tbCustomers SET cusName = @cusName, cusCon = @cusCon WHERE cusID = @cusID";
            try
            {         
                myOper.con.Open();
                using (cmd = new SqlCommand(query, myOper.con))
                {
                    
                    cmd.Parameters.AddWithValue("@cusID", Convert.ToInt32(txtCusID.Text));
                    cmd.Parameters.AddWithValue("@cusName", txtCusName.Text);
                    cmd.Parameters.AddWithValue("@cusCon", txtCusCon.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if the update was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Customer update failed. Please check the customer ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            LoadCustomers();
            myOper.con.Close();
        }

        private void BTN_DeleteCus_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM tbCustomers WHERE cusID = @cusID";
            myOper.con.Open();
            try
            {
                using (cmd = new SqlCommand(query, myOper.con))
                {
                    cmd.Parameters.AddWithValue("@cusID", Convert.ToInt32(txtCusID.Text));
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Customer delete failed. Please check the customer ID.");
                    }
                }
                LoadCustomers(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            myOper.con.Close(); 
        }
    }
}

