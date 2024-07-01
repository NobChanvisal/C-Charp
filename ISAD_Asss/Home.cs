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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BTN_Customer_Click(object sender, EventArgs e)
        {
            CustomerForm customer_form = new CustomerForm();

            // Show the new form
            customer_form.Show();
            this.Hide();
        }

        private void BTN_staff_Click(object sender, EventArgs e)
        {
            StaffForm staff_form = new StaffForm();

            // Show the new form
            staff_form.Show();
            this.Hide();
        }
    }
}
