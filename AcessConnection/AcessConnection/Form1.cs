using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AcessConnection
{
    public partial class frmDatabase : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;

        public frmDatabase()
        {
            InitializeComponent();
        }
        void GetCustomer()
        {
            var connString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\RUPP\\Year3\\Customer.mdb";
            conn = new OleDbConnection(connString);
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM Customer", connString);
            conn.Open();
            adapter.Fill(dt);
            dgvCustomer.DataSource = dt;
            conn.Close();
        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            GetCustomer();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = "Insert into Customer(Name,Title,BirthDate,City,Country) values(@name,@title,@birthDate,@city,@country)";
                
                
            cmd = new OleDbCommand(query,conn);
            cmd.Parameters.AddWithValue("@name",txtName.Text);
            cmd.Parameters.AddWithValue("@title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@birthDate", dateTimePicker.Value);
            cmd.Parameters.AddWithValue("@city", txtCity.Text);
            cmd.Parameters.AddWithValue("@country", txtCountry.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Insert Successful!!");
            GetCustomer();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Customer Set Name=@name,Title=@title,BirthDate=@birthDate,City=@city,Country=@country Where ID=@id";
             
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@birthDate", dateTimePicker.Value);
            cmd.Parameters.AddWithValue("@cit", txtCity.Text);
            cmd.Parameters.AddWithValue("@country", txtCountry.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated Successful!!");
            GetCustomer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete from Customer Where ID = @id";

            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));
            conn.Open();
            cmd.ExecuteNonQuery();  
            conn.Close();
            MessageBox.Show("Delete Successful!!");
            GetCustomer();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCustomer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            txtTitle.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
            txtCity.Text = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
            txtCountry.Text = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
        }

        private void bttClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtTitle.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtName.Focus();
        }

        private void bttButton_Hover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Aqua;
        }

        private void bttButton_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = SystemColors.Control;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton1.Text;
        }
    }
}
