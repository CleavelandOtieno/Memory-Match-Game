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
    public partial class gameGUIA_6 : Form
    {
        private OleDbConnection gameDBconnect = new OleDbConnection();
        List<Point> position = new List<Point>();
        Random location = new Random();
        PictureBox cardimage1;
        PictureBox cardimage2;
        public gameGUIA_6()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            gameDBconnect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cleav\Desktop\SHOOL\CLEAVELAND ONYANGO-AWD PROJECT\CLEAVELAND ONYANGO-AWD 2019-GAME DB.accdb;
Persist Security Info=False;";
        }

        private void gameGUIA_6_Load(object sender, EventArgs e)
        {
            lblgamestart.Text = "5";
            lblscorecount.Text = "0";
            lblgametime.Text = "15";

            lblcurrentusername.Text = playerLOGIN.currentplayer;

            foreach (PictureBox pic in pnlcardholder.Controls)
            {
                pic.Enabled = false;
            }
            gamestarttimer.Start();
            gamestartIntervaltimer.Start();
            lblScore.Visible = false;
            lblscorecount.Visible = false;
            lbltime.Visible = false;
            lblgametime.Visible = false;
            lblscorecount.Visible = false;
            btnback.Visible = false;
            btnrestart.Visible = false;
            lblcurrentusername.Visible = false;
            btnlogout.Visible = false;
            lblguestusername.Visible = false;
            btnchart.Visible = false;

            picboxCard1.Image = Properties.Resources.baboon;
            picboxnameCard1.Image = Properties.Resources.baboon2;
            picboxCard2.Image = Properties.Resources.cow;
            picboxnameCard2.Image = Properties.Resources.cow2;
            picboxCard3.Image = Properties.Resources.fox;
            picboxnameCard3.Image = Properties.Resources.fox2;
        }

        private void gamestartIntervaltimer_Tick(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(lblgamestart.Text);
            time = time - 1;
            lblgamestart.Text = Convert.ToString(time);
            if (time == 0)
            {
                gamestartIntervaltimer.Stop();
                playgametimer.Start();
                playgameIntervaltimer.Start();
                lblgamestart.Visible = false;
                lblScore.Visible = true;
                lblscorecount.Visible = true;
                lbltime.Visible = true;
                lblgametime.Visible = true;
                lblscorecount.Visible = true;
                btnrestart.Visible = true;
                btnback.Visible = true;
                lblcurrentusername.Visible = true;
                btnlogout.Visible = true;
                btnchart.Visible = true;
            }
        }

        private void playgametimer_Tick(object sender, EventArgs e)
        {
            playgametimer.Stop();
        }

        private void playgameIntervaltimer_Tick(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(lblgametime.Text);
            time = time - 1;
            lblgametime.Text = Convert.ToString(time);
            if (time == 0)
            {
                playgameIntervaltimer.Stop();
                picboxCard1.Enabled = false;
                picboxnameCard1.Enabled = false;
                picboxCard2.Enabled = false;
                picboxnameCard2.Enabled = false;
                picboxCard3.Enabled = false;
                picboxnameCard3.Enabled = false;
            }
        }

        private void gamestarttimer_Tick(object sender, EventArgs e)
        {
            gamestarttimer.Stop();
            foreach (PictureBox pic in pnlcardholder.Controls)
            {
                pic.Enabled = true;
                pic.Cursor = Cursors.Hand;
                pic.Image = Properties.Resources.back;
                position.Add(pic.Location);
            }
            foreach (PictureBox pic in pnlcardholder.Controls)
            {
                int nextPosition = location.Next(position.Count);
                Point c = position[nextPosition];
                pic.Location = c;
                position.Remove(c);
            }
        }

        private void cardfliptimer_Tick(object sender, EventArgs e)
        {
            cardfliptimer.Stop();
            lblscorecount.Text = Convert.ToString(Convert.ToInt32(lblscorecount.Text) - 5 + 5);

            cardimage1.Image = Properties.Resources.back;
            cardimage2.Image = Properties.Resources.back;
            cardimage1 = null;
            cardimage2 = null;
        }

        private void picboxCard1_Click(object sender, EventArgs e)
        {
            picboxCard1.Image = Properties.Resources.baboon;
            if (cardimage1 == null)
            {
                cardimage1 = picboxCard1;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxCard1;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard1.Enabled = false;
                    picboxnameCard1.Enabled = false;
                    picboxCard1.Image = Properties.Resources.thumbs;
                    picboxnameCard1.Image = Properties.Resources.thumbs;
                    lblscorecount.Text = Convert.ToString(Convert.ToInt32(lblscorecount.Text) + 10);
                }
                else
                {
                    cardfliptimer.Start();
                }
            }
        }

        private void picboxnameCard1_Click(object sender, EventArgs e)
        {
            picboxnameCard1.Image = Properties.Resources.baboon2;
            if (cardimage1 == null)
            {
                cardimage1 = picboxnameCard1;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxnameCard1;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard1.Enabled = false;
                    picboxnameCard1.Enabled = false;
                    picboxCard1.Image = Properties.Resources.thumbs;
                    picboxnameCard1.Image = Properties.Resources.thumbs;
                    lblscorecount.Text = Convert.ToString(Convert.ToInt32(lblscorecount.Text) + 10);
                }
                else
                {
                    cardfliptimer.Start();
                }
            }

        }

        private void picboxCard2_Click(object sender, EventArgs e)
        {
            picboxCard2.Image = Properties.Resources.cow;
            if (cardimage1 == null)
            {
                cardimage1 = picboxCard2;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxCard2;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard2.Enabled = false;
                    picboxnameCard2.Enabled = false;
                    picboxCard2.Image = Properties.Resources.thumbs;
                    picboxnameCard2.Image = Properties.Resources.thumbs;
                    lblscorecount.Text = Convert.ToString(Convert.ToInt32(lblscorecount.Text) + 10);
                }
                else
                {
                    cardfliptimer.Start();
                }
            }
        }

        private void picboxnameCard2_Click(object sender, EventArgs e)
        {
            picboxnameCard2.Image = Properties.Resources.cow2;
            if (cardimage1 == null)
            {
                cardimage1 = picboxnameCard2;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxnameCard2;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard2.Enabled = false;
                    picboxnameCard2.Enabled = false;
                    picboxCard2.Image = Properties.Resources.thumbs;
                    picboxnameCard2.Image = Properties.Resources.thumbs;
                    lblscorecount.Text = Convert.ToString(Convert.ToInt32(lblscorecount.Text) + 10);
                }
                else
                {
                    cardfliptimer.Start();
                }
            }
        }

        private void picboxCard3_Click(object sender, EventArgs e)
        {
            picboxCard3.Image = Properties.Resources.fox;
            if (cardimage1 == null)
            {
                cardimage1 = picboxCard3;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxCard3;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard3.Enabled = false;
                    picboxnameCard3.Enabled = false;
                    picboxCard3.Image = Properties.Resources.thumbs;
                    picboxnameCard3.Image = Properties.Resources.thumbs;
                    lblscorecount.Text = Convert.ToString(Convert.ToInt32(lblscorecount.Text) + 10);
                }
                else
                {
                    cardfliptimer.Start();
                }
            }
        }

        private void picboxnameCard3_Click(object sender, EventArgs e)
        {
            picboxnameCard3.Image = Properties.Resources.fox2;
            if (cardimage1 == null)
            {
                cardimage1 = picboxnameCard3;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxnameCard3;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard3.Enabled = false;
                    picboxnameCard3.Enabled = false;
                    picboxCard3.Image = Properties.Resources.thumbs;
                    picboxnameCard3.Image = Properties.Resources.thumbs;
                    lblscorecount.Text = Convert.ToString(Convert.ToInt32(lblscorecount.Text) + 10);
                }
                else
                {
                    cardfliptimer.Start();
                }
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            playgametimer.Stop();
            playgameIntervaltimer.Stop();
            DialogResult restart = MessageBox.Show("you wish to cancel the current game?", "", MessageBoxButtons.YesNo);
            if (restart == DialogResult.Yes)
            {

                this.Hide();
                levelCard lc = new levelCard();
                lc.ShowDialog();

            }
            else if (restart == DialogResult.No)
            {
                //players data will be stored automatically
                playgametimer.Start();
                playgameIntervaltimer.Start();
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            lblguestusername.Text = selectPlayer.guest;
            string guestusername = lblguestusername.Text.ToString();
            string scores = lblscorecount.Text.ToString();
            string username = lblcurrentusername.Text.ToString();

            gameDBconnect.Open();
            OleDbCommand saveguestplayer = new OleDbCommand();
            saveguestplayer.Connection = gameDBconnect;
            DialogResult logout = MessageBox.Show("you are logged out!", "", MessageBoxButtons.OK);
            if (logout == DialogResult.OK)
            {
                saveguestplayer.CommandText = "INSERT INTO playerScores(userName,guestUserName,PlayerScore)values ('" + username + "','" + guestusername + "','" + scores + "')";
                saveguestplayer.ExecuteNonQuery();
                gameDBconnect.Close();

                Application.Restart();

            }
        }

        private void btnchart_Click(object sender, EventArgs e)
        {
            playgametimer.Stop();
            playgameIntervaltimer.Stop();
            DialogResult playerstatistic = MessageBox.Show("view player statistics", "", MessageBoxButtons.OK);
            if (playerstatistic == DialogResult.OK)
            {
                this.Hide();
                playerStats ps = new playerStats();
                ps.ShowDialog();
            }
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            lblguestusername.Text = selectPlayer.guest;
            string guestusername = lblguestusername.Text.ToString();
            gameDBconnect.Open();
            string username = lblcurrentusername.Text.ToString();

            string scores = lblscorecount.Text.ToString();
            OleDbCommand saveplayer = new OleDbCommand();
            saveplayer.Connection = gameDBconnect;
            DialogResult restart = MessageBox.Show("you wish to restart game?", "", MessageBoxButtons.YesNo);
            if (restart == DialogResult.Yes)
            {
                saveplayer.CommandText = "INSERT INTO playerScores(userName,guestUserName,PlayerScore)values ('" + username + "','" + guestusername + "','" + scores + "')";
                saveplayer.ExecuteNonQuery();
                gameGUIA_6_Load(sender, e);
                gamestarttimer.Start();
                gamestartIntervaltimer.Start();
                lblgamestart.Visible = true;
                gameDBconnect.Close();
            }
            else if (restart == DialogResult.No)
            {
                gameDBconnect.Close();
            }
        }
    }
}
