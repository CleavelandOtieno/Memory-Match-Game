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

namespace CLEAVELAND_ONYANGO_AWD_2019
{
    public partial class playerREGISTRATION : Form
    {
        private OleDbConnection gameDBconnect = new OleDbConnection();
        public playerREGISTRATION()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            gameDBconnect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cleav\Desktop\SHOOL\CLEAVELAND ONYANGO-AWD PROJECT\CLEAVELAND ONYANGO-AWD 2019-GAME DB.accdb;
Persist Security Info=False;";
        }

        private void playerREGISTRATION_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == "" || txtLname.Text == "" || txtUname.Text == "" || txtEAddress.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("please fill in all fields......");
                this.Hide();
                playerREGISTRATION pr = new playerREGISTRATION();
                pr.ShowDialog();
            }
            try
            {
                gameDBconnect.Open();
                string fname = txtFname.Text.ToString();
                string lname = txtLname.Text.ToString();
                string username = txtUname.Text.ToString();
                string DoB = datecap.Text.ToString();
                string Eaddress = txtEAddress.Text.ToString();
                string pass = txtPass.Text.ToString();

                OleDbCommand regCommand = new OleDbCommand();
                regCommand.Connection = gameDBconnect;
                regCommand.CommandText = "INSERT INTO playerRegistration(playerFirstName,playerLastName,UserName,DateOfBirth,emailAddress,[Password]) values ('" + fname + "','" + lname + "','" + username + "','" + DoB + "','" + Eaddress + "','" + pass + "')";
                regCommand.ExecuteNonQuery();
                DialogResult savedata = MessageBox.Show("stored successful", "", MessageBoxButtons.OK);
                if (savedata == DialogResult.OK)
                {
                    txtFname.Text = string.Empty;
                    txtLname.Text = string.Empty;
                    txtUname.Text = string.Empty;
                    datecap.Text = string.Empty;
                    txtEAddress.Text = string.Empty;
                    txtPass.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to" + ex.Message);
            }
            finally
            {
                gameDBconnect.Close();
            }
        
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            this.Hide();
            playerLOGIN plog = new playerLOGIN();
            plog.ShowDialog();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectPlayer sp = new selectPlayer();
            sp.ShowDialog();
        }
    }
}
