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
    public partial class playerStats : Form
    {
        private OleDbConnection gameDBconnect = new OleDbConnection();
        public playerStats()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            gameDBconnect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cleav\Desktop\SHOOL\CLEAVELAND ONYANGO-AWD PROJECT\CLEAVELAND ONYANGO-AWD 2019-GAME DB.accdb;
Persist Security Info=False;";
        }

        private void btnloadchart_Click(object sender, EventArgs e)
        {
            btnloadtable.Visible = true;
            btnloadchart.Visible = false;
            try
            {
                gameDBconnect.Open();
                OleDbCommand chartCommand = new OleDbCommand();
                chartCommand.Connection = gameDBconnect;
                chartCommand.CommandText = "SELECT userName,PlayerScore FROM playerScores";
                OleDbDataReader readdata = chartCommand.ExecuteReader();
                while (readdata.Read())
                {
                    scoreChart.Series["Scores"].Points.AddXY(readdata["userName"].ToString(), readdata["PlayerScore"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed due to" + ex.Message);
            }
            finally
            {
                gameDBconnect.Close();
            }
        }

        private void btnloadtable_Click(object sender, EventArgs e)
        {
            btnloadchart.Visible = true;
            btnloadtable.Visible = false;
            try
            {
                gameDBconnect.Open();
                OleDbCommand tablecommand = new OleDbCommand();
                tablecommand.Connection = gameDBconnect;
                string query = "SELECT * FROM playerScores ORDER BY PlayerScore DESC";
                tablecommand.CommandText = query;

                OleDbDataAdapter odb = new OleDbDataAdapter(tablecommand);
                DataTable dtb = new DataTable();
                odb.Fill(dtb);
                dbPlayerScores.DataSource = dtb;

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

        private void playerStats_Load(object sender, EventArgs e)
        {
            btnloadtable.Visible =false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            DialogResult restart = MessageBox.Show("you are about to begin a new game........", "", MessageBoxButtons.YesNo);
            if (restart == DialogResult.Yes)
            {

                this.Hide();
                levelCard lc = new levelCard();
                lc.ShowDialog();

            }
            else if (restart == DialogResult.No)
            {
                //players data will be stored automatically
                playerStats_Load(sender, e);
            }
        }
    }
}
