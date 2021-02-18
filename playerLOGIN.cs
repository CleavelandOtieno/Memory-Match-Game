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

namespace CLEAVELAND_ONYANGO_AWD_2019
{
    public partial class playerLOGIN : Form
    {
        public static string currentplayer = "";
        
        private OleDbConnection gameDBconnect = new OleDbConnection();
        public playerLOGIN()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        gameDBconnect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cleav\Desktop\SHOOL\CLEAVELAND ONYANGO-AWD PROJECT\CLEAVELAND ONYANGO-AWD 2019-GAME DB.accdb;
Persist Security Info=False;";
        }

        private void playerLOGIN_Load(object sender, EventArgs e)
        {
            
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "" || txtUname.Text == "")
            {
                MessageBox.Show("please enter username and password......");
                this.Hide();
                playerLOGIN pl = new playerLOGIN();
                pl.ShowDialog();
            }

                currentplayer = txtUname.Text;
                try
                {
                    gameDBconnect.Open();
                    string username = txtUname.Text.ToString();
                    string pass = txtPass.Text.ToString();

                    OleDbCommand logCommand = new OleDbCommand();
                    logCommand.Connection = gameDBconnect;
                    logCommand.CommandText = "SELECT * FROM playerRegistration WHERE UserName= '" + username + "' AND [Password]='" + pass + "' ";
                    OleDbDataReader readdata = logCommand.ExecuteReader();
                    int countlogtime = 0;
                    while (readdata.Read())
                    {
                        countlogtime = countlogtime + 1;
                    }
                    if (countlogtime == 1)
                    {
                        DialogResult playgame1 = MessageBox.Show("username and password is correct!", "", MessageBoxButtons.OK);
                        if (playgame1 == DialogResult.OK)
                        {
                            this.Hide();
                            levelCard lc = new levelCard();
                            lc.ShowDialog();

                        }
                    }
                    else
                    if (countlogtime > 1)
                    {
                        DialogResult playgame2 = MessageBox.Show("Duplicate username and password!", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        DialogResult playgame3 = MessageBox.Show("username or password is incorrect,try again!", "", MessageBoxButtons.OK);
                        if (playgame3 == DialogResult.OK)
                        {
                          
                        this.Hide();
                      playerLOGIN pl = new playerLOGIN();
                        pl.ShowDialog();
                        }
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

      

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectPlayer sp = new selectPlayer();
            sp.ShowDialog();
            
        }
    }
}
