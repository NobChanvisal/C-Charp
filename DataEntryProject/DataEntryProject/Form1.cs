using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEntryProject
{
    public partial class formDataEntry : Form
    {
        TimeSpan elapsedTime;
        DateTime lastElapsed;
        public formDataEntry()
        {
            InitializeComponent();
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddr.Clear();
            txtCity.Clear();  
            txtState.Clear();
            txtZip.Clear();
            txtName.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime += DateTime.Now - lastElapsed;
            lastElapsed = DateTime.Now;
            txtTimer.Text = Convert.ToString(new TimeSpan (elapsedTime.Hours,elapsedTime.Minutes,elapsedTime.Seconds));   
        }

        private void bttStart_Click(object sender, EventArgs e)
        {
            bttStart.Enabled = false;
            bttPause.Enabled = true;
            timer1.Enabled = true;
            grBoxDataEntry.Enabled = true;
            txtName.Focus ();
            lastElapsed = DateTime.Now;
        }

        private void bttPause_Click(object sender, EventArgs e)
        {
            bttStart.Enabled=true;
            bttPause.Enabled=false;
            timer1.Enabled=false;
            grBoxDataEntry.Enabled=false;
        }

        private void bttAccept_Click(object sender, EventArgs e)
        {
            String dataEntry;
            //This condition use when you don't input data after you click accept btt;
            //it Error Message;
            if(txtName.Text.Equals("") || txtAddr.Text.Equals("") ||txtCity.Text.Equals("")
                || txtState.Text.Equals("") || txtZip.Text.Equals(""))
            {
                MessageBox.Show("Each Box Much Have An Input","Error Message", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            dataEntry = txtName.Text + "\r\n" + txtAddr.Text + "\r\n" + txtCity.Text + "\r\n" +
                        txtState.Text + "\r\n" + txtZip.Text + "\r\n";
            MessageBox.Show(dataEntry,"Data Entry",MessageBoxButtons.OK);
            bttClear.PerformClick();
        }

        private void txt_inputKeyPress(object sender, KeyPressEventArgs e)
        {
            String textBoxSender = ((TextBox)sender).Name;
            if(e.KeyChar == 13)
            {
                switch(textBoxSender)
                {
                    case "txtName":
                        txtAddr.Focus();
                        break;
                    case "txtAddr":
                        txtCity.Focus();
                        break;
                    case "txtCity":
                        txtState.Focus();
                        break;
                    case "txtState":
                        txtZip.Focus();
                        break;
                    case "txtZip":
                        bttAccept.Focus();
                        break;
                }
            }
            /*
            if (textBoxSender.Equals("txtZip"))
            {
                if((e.KeyChar >= '0' && e.KeyChar <= 9) || (e.KeyChar == 8))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled= true;
                }
            }*/
        }

        private void bttButton_Hover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Aqua;
        }

        private void bttButton_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = SystemColors.Control;
        }

    }
}
