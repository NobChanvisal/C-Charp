using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAD_Asss
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void BTN_logIn_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "Admin" && txtPW.Text == "Admin123")
            {
                
                // Create an instance of the new form
                Home Home_form = new Home();

                // Show the new form
                Home_form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
