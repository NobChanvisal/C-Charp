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

namespace Database{

    public partial class frmTitle : Form
    {
        OleDbConnection conn;
        public frmTitle()
        {
            InitializeComponent();
        }

        private void frmTitle_Load(object sender, EventArgs e)
        {
            var connString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\DB\books.accdb;
                Persist Security Info=False;";
            conn = new OleDbConnection(connString);
            conn.Open();
            txtConn.Text = conn.ToString();
        }
    }
}
