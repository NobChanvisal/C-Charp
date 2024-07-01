using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDataEntry
{
    public partial class stuForm : Form
    {
        String gender;
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        OleDbCommandBuilder builder;
        DataTable dt;
        public stuForm()
        {
            InitializeComponent();
            getStudent();
        }

        public void getStudent()
        {
            
            var connString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\RUPP\\Year3\\Student.mdb";
            conn = new OleDbConnection(connString);
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM Students", connString);
            conn.Open();
            adapter.Fill(dt);
            dgvStudent.DataSource = dt;
            conn.Close();

        }
        public void courseFilter()
        {
            conn.Open();
            string query = "Select *From Students Where Course = '"+cbBoxCourseFilter.SelectedItem.ToString()+"'";
                
            adapter = new OleDbDataAdapter(query,conn);
            builder = new OleDbCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgvStudent.DataSource = ds.Tables[0];
            conn.Close() ;
        }
        public void shiftFilter()
        {
            conn.Open();
            string query = "Select *From Students Where Shift = '" + cbBoxShiftFilter.SelectedItem.ToString() + "'";
            
            adapter = new OleDbDataAdapter(query, conn);
            builder = new OleDbCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgvStudent.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void cbBoxCourse_Selete(object sender, EventArgs e)
        {
            
        }

        private void bttClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtAddres.Clear();
            cbBoxShift.Text = string.Empty;
            cbBoxCourse.Text = string.Empty;
            radioBttnMale.Checked = false;
            radioBtnFemale.Checked = false;
            txtSearch.Clear();
            txtID.Focus();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            string textboxSender = ((TextBox)sender).Name;
            if(e.KeyChar == 13)
            {
                switch(textboxSender)
                {
                    case "txtID":
                        txtName.Focus(); break;
                        
                    case "txtName":
                        txtPhone.Focus(); break;
                    case "txtPhone":
                        txtAddres.Focus(); break;
                }
            }
        }

        private void stuForm_Load(object sender, EventArgs e)
        {
            getStudent();
        }

        private void bttInsert_Click(object sender, EventArgs e)
        {
            string query = "Insert into Students(Name,Gender,Phone,Shift,Course,Address) values(@name,@gender,@phone,@shift,@course,@address)";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@phone",txtPhone.Text);
            cmd.Parameters.AddWithValue("@shift", cbBoxShift.Text);
            cmd.Parameters.AddWithValue("@course", cbBoxCourse.Text);
            cmd.Parameters.AddWithValue("@address", txtAddres.Text);
            
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            getStudent();
            MessageBox.Show("Insert Successful");
        }

        private void bttButton_Hover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Aqua;
        }

        private void bttButton_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = SystemColors.Control;
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Students Set Name=@name,Gender=@gender,Phone=@phone,Shift=@shift,Course=@course,Address=@address Where ID=@id";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@shift", cbBoxShift.Text);
            cmd.Parameters.AddWithValue("@course", cbBoxCourse.Text);
            cmd.Parameters.AddWithValue("@address", txtAddres.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            getStudent();
            MessageBox.Show("Update Successful");
        }

        private void dgvStudent_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvStudent.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvStudent.CurrentRow.Cells[1].Value.ToString();
            gender = dgvStudent.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgvStudent.CurrentRow.Cells[3].Value.ToString();
            cbBoxShift.Text = dgvStudent.CurrentRow.Cells[4].Value.ToString();
            cbBoxCourse.Text = dgvStudent.CurrentRow.Cells[5].Value.ToString();
            txtAddres.Text = dgvStudent.CurrentRow.Cells[6].Value.ToString();
        }

        private void radioBttnMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";  
        }

        private void radioBtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete From Students Where ID = @id";
            cmd = new OleDbCommand(query,conn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            getStudent();
            MessageBox.Show("Delete Successful");
        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Name Like '%" + txtSearch.Text + "'";
            dgvStudent.DataSource = dv;
        }

        private void cbBoxCourseFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseFilter();
            if(cbBoxCourseFilter.SelectedItem.ToString() == "All")
            getStudent();
        }

        private void cbBoxShiftFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            shiftFilter();
            if (cbBoxShiftFilter.SelectedItem.ToString() == "All")
                getStudent();
        }

        private void grpBoxEntry_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
