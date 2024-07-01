using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ISAD_Asss
{
    class myOper
    {
        public static SqlConnection con;
        public static void myConnection()
        {
            string conStr = "Data Source=DESKTOP-1PASJN5\\SQLEXPRESS01;Initial Catalog=M1_2024;Integrated Security=True;";
            try
            {
                con = new SqlConnection(conStr);
                con.Open();
                //MessageBox.Show("succcefull connection...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
