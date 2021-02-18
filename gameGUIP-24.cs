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
    public partial class gameGUIP : Form
    {
        private OleDbConnection gameDBconnect = new OleDbConnection();
        List<Point> position = new List<Point>();
        Random location = new Random();
        PictureBox cardimage1;
        PictureBox cardimage2;
        public gameGUIP()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            gameDBconnect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cleav\Desktop\SHOOL\CLEAVELAND ONYANGO-AWD PROJECT\CLEAVELAND ONYANGO-AWD 2019-GAME DB.accdb;
Persist Security Info=False;";
        }

        private void gameGUIP_Load(object sender, EventArgs e)
        {
            lblgamestart.Text = "5";
            lblscoreCount.Text = "0";
            lblgametime.Text = "60";
            lblcurrentusername.Text = playerLOGIN.currentplayer;
            foreach (PictureBox pic in pnlcardholder.Controls)
            {
                pic.Enabled = false;
            }
            gamestarttimer1.Start();
            gamestartintervaltimer1.Start();
            lblScore.Visible = false;
            lblscoreCount.Visible = false;
            lbltime.Visible = false;
            lblgametime.Visible = false;
            lblscoreCount.Visible = false;
            btnback.Visible = false;
            btnrestart.Visible = false;
            lblcurrentusername.Visible = false;
            btnlogout.Visible = false;
            lblcurrentguestusername.Visible = false;
            btnchart.Visible = false;

            picboxCard1.Image = Properties.Resources.aloe;
            picboxnameCard1.Image = Properties.Resources.aloe2;
            picboxCard2.Image = Properties.Resources.bamboo;
            picboxnameCard2.Image = Properties.Resources.bamboo2;
            picboxCard3.Image = Properties.Resources.cactus;
            picboxnameCard3.Image = Properties.Resources.cactus2;
            picboxCard4.Image = Properties.Resources.daisy;
            picboxnameCard4.Image = Properties.Resources.daisy2;
            picboxCard5.Image = Properties.Resources.fern;
            picboxnameCard5.Image = Properties.Resources.fern2;
            picboxCard6.Image = Properties.Resources.ivy;
            picboxnameCard6.Image = Properties.Resources.ivy2;
            picboxCard7.Image = Properties.Resources.lily;
            picboxnameCard7.Image = Properties.Resources.lily2;
            picboxCard8.Image = Properties.Resources.mushroom;
            picboxnameCard8.Image = Properties.Resources.mushroom2;
            picboxCard9.Image = Properties.Resources.palm;
            picboxnameCard9.Image = Properties.Resources.palm2;
            picboxCard10.Image = Properties.Resources.rose;
            picboxnameCard10.Image = Properties.Resources.rose2;
            picboxCard11.Image = Properties.Resources.sunflower;
            picboxnameCard11.Image = Properties.Resources.sunflower2;
            picboxCard12.Image = Properties.Resources.tulip;
            picboxnameCard12.Image = Properties.Resources.tulip2;
        }

        private void gamestarttimer1_Tick(object sender, EventArgs e)
        {
            gamestarttimer1.Stop();
            //will randomize the card positions after the timer begins every time.
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

        private void gamestartintervaltimer1_Tick(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(lblgamestart.Text);//converts the text to integer
            time = time - 1;
            lblgamestart.Text = Convert.ToString(time);//converts the integer to string
            if (time == 0)
            {
                gamestartintervaltimer1.Stop();
                playgametimer1.Start();
                playgameintervaltimer1.Start();
                lblgamestart.Visible = false;
                lblScore.Visible = true;
                lblscoreCount.Visible = true;
                lbltime.Visible = true;
                lblgametime.Visible = true;
                lblscoreCount.Visible = true;
                btnrestart.Visible = true;
                btnback.Visible = true;
                lblcurrentusername.Visible = true;
                btnlogout.Visible = true;
                btnchart.Visible = false;


            }
        }

        private void playgametimer1_Tick(object sender, EventArgs e)
        {
            playgametimer1.Stop();
        }

        private void playgameintervaltimer1_Tick(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(lblgametime.Text);//converts the text to integer
            time = time - 1;
            lblgametime.Text = Convert.ToString(time);//converts the integer to string
            if (time == 0)
            {
                playgameintervaltimer1.Stop();
                picboxCard1.Enabled = false;
                picboxnameCard1.Enabled = false;
                picboxCard2.Enabled = false;
                picboxnameCard2.Enabled = false;
                picboxCard3.Enabled = false;
                picboxnameCard3.Enabled = false;
                picboxCard4.Enabled = false;
                picboxnameCard4.Enabled = false;
                picboxCard5.Enabled = false;
                picboxnameCard5.Enabled = false;
                picboxCard6.Enabled = false;
                picboxnameCard6.Enabled = false;
                picboxCard7.Enabled = false;
                picboxnameCard7.Enabled = false;
                picboxCard8.Enabled = false;
                picboxnameCard8.Enabled = false;
                picboxCard9.Enabled = false;
                picboxnameCard9.Enabled = false;
                picboxCard10.Enabled = false;
                picboxnameCard10.Enabled = false;
                picboxCard11.Enabled = false;
                picboxnameCard11.Enabled = false;
                picboxCard12.Enabled = false;
                picboxnameCard12.Enabled = false;
                

            }
        }

        private void cardfliptimer1_Tick(object sender, EventArgs e)
        {
            cardfliptimer1.Stop();
            lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) - 5 + 5);
            cardimage1.Image = Properties.Resources.back;
            cardimage2.Image = Properties.Resources.back;
            cardimage1 = null;
            cardimage2 = null;
        }

        private void picboxCard1_Click(object sender, EventArgs e)
        {
            picboxCard1.Image = Properties.Resources.aloe;
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
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxnameCard1_Click(object sender, EventArgs e)
        {
            picboxnameCard1.Image = Properties.Resources.aloe2;
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
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxCard2_Click(object sender, EventArgs e)
        {
            picboxCard2.Image = Properties.Resources.bamboo;
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
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxnameCard2_Click(object sender, EventArgs e)
        {
            picboxnameCard2.Image = Properties.Resources.bamboo2;
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
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxCard3_Click(object sender, EventArgs e)
        {
            picboxCard3.Image = Properties.Resources.cactus;
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
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxnameCard3_Click(object sender, EventArgs e)
        {
            picboxnameCard3.Image = Properties.Resources.cactus2;
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
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxCard4_Click(object sender, EventArgs e)
        {
            picboxCard4.Image = Properties.Resources.daisy;
            if (cardimage1 == null)
            {
                cardimage1 = picboxCard4;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxCard4;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard4.Enabled = false;
                    picboxnameCard4.Enabled = false;
                    picboxCard4.Image = Properties.Resources.thumbs;
                    picboxnameCard4.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxnameCard4_Click(object sender, EventArgs e)
        {
            picboxnameCard4.Image = Properties.Resources.daisy2;
            if (cardimage1 == null)
            {
                cardimage1 = picboxnameCard4;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxnameCard4;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard4.Enabled = false;
                    picboxnameCard4.Enabled = false;
                    picboxCard4.Image = Properties.Resources.thumbs;
                    picboxnameCard4.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxCard5_Click(object sender, EventArgs e)
        {
            picboxCard5.Image = Properties.Resources.fern;
            if (cardimage1 == null)
            {
                cardimage1 = picboxCard5;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxCard5;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard5.Enabled = false;
                    picboxnameCard5.Enabled = false;
                    picboxCard5.Image = Properties.Resources.thumbs;
                    picboxnameCard5.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxnameCard5_Click(object sender, EventArgs e)
        {
            picboxnameCard5.Image = Properties.Resources.fern2;
            if (cardimage1 == null)
            {
                cardimage1 = picboxnameCard5;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxnameCard5;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard5.Enabled = false;
                    picboxnameCard5.Enabled = false;
                    picboxCard5.Image = Properties.Resources.thumbs;
                    picboxnameCard5.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxCard6_Click(object sender, EventArgs e)
        {
            picboxCard6.Image = Properties.Resources.ivy;
            if (cardimage1 == null)
            {
                cardimage1 = picboxCard6;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxCard6;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard6.Enabled = false;
                    picboxnameCard6.Enabled = false;
                    picboxCard6.Image = Properties.Resources.thumbs;
                    picboxnameCard6.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxnameCard6_Click(object sender, EventArgs e)
        {
            picboxnameCard6.Image = Properties.Resources.ivy2;
            if (cardimage1 == null)
            {
                cardimage1 = picboxnameCard6;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxnameCard6;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard6.Enabled = false;
                    picboxnameCard6.Enabled = false;
                    picboxCard6.Image = Properties.Resources.thumbs;
                    picboxnameCard6.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxCard7_Click(object sender, EventArgs e)
        {
            picboxCard7.Image = Properties.Resources.lily;
            if (cardimage1 == null)
            {
                cardimage1 = picboxCard7;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxCard7;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard7.Enabled = false;
                    picboxnameCard7.Enabled = false;
                    picboxCard7.Image = Properties.Resources.thumbs;
                    picboxnameCard7.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxnameCard7_Click(object sender, EventArgs e)
        {
            picboxnameCard7.Image = Properties.Resources.lily2;
            if (cardimage1 == null)
            {
                cardimage1 = picboxnameCard7;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxnameCard7;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard7.Enabled = false;
                    picboxnameCard7.Enabled = false;
                    picboxCard7.Image = Properties.Resources.thumbs;
                    picboxnameCard7.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxCard8_Click(object sender, EventArgs e)
        {
            picboxCard8.Image = Properties.Resources.mushroom;
            if (cardimage1 == null)
            {
                cardimage1 = picboxCard8;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxCard8;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard8.Enabled = false;
                    picboxnameCard8.Enabled = false;
                    picboxCard8.Image = Properties.Resources.thumbs;
                    picboxnameCard8.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxnameCard8_Click(object sender, EventArgs e)
        {
            picboxnameCard8.Image = Properties.Resources.mushroom2;
            if (cardimage1 == null)
            {
                cardimage1 = picboxnameCard8;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxnameCard8;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard8.Enabled = false;
                    picboxnameCard8.Enabled = false;
                    picboxCard8.Image = Properties.Resources.thumbs;
                    picboxnameCard8.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxCard9_Click(object sender, EventArgs e)
        {
            picboxCard9.Image = Properties.Resources.palm;
            if (cardimage1 == null)
            {
                cardimage1 = picboxCard9;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxCard9;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard9.Enabled = false;
                    picboxnameCard9.Enabled = false;
                    picboxCard9.Image = Properties.Resources.thumbs;
                    picboxnameCard9.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxnameCard9_Click(object sender, EventArgs e)
        {
            picboxnameCard9.Image = Properties.Resources.palm2;
            if (cardimage1 == null)
            {
                cardimage1 = picboxnameCard9;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxnameCard9;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard9.Enabled = false;
                    picboxnameCard9.Enabled = false;
                    picboxCard9.Image = Properties.Resources.thumbs;
                    picboxnameCard9.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxCard10_Click(object sender, EventArgs e)
        {
            picboxCard10.Image = Properties.Resources.rose;
            if (cardimage1 == null)
            {
                cardimage1 = picboxCard10;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxCard10;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard10.Enabled = false;
                    picboxnameCard10.Enabled = false;
                    picboxCard10.Image = Properties.Resources.thumbs;
                    picboxnameCard10.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxnameCard10_Click(object sender, EventArgs e)
        {
            picboxnameCard10.Image = Properties.Resources.rose2;
            if (cardimage1 == null)
            {
                cardimage1 = picboxnameCard10;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxnameCard10;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard10.Enabled = false;
                    picboxnameCard10.Enabled = false;
                    picboxCard10.Image = Properties.Resources.thumbs;
                    picboxnameCard10.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxCard11_Click(object sender, EventArgs e)
        {
            picboxCard11.Image = Properties.Resources.sunflower;
            if (cardimage1 == null)
            {
                cardimage1 = picboxCard11;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxCard11;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard11.Enabled = false;
                    picboxnameCard11.Enabled = false;
                    picboxCard11.Image = Properties.Resources.thumbs;
                    picboxnameCard11.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxnameCard11_Click(object sender, EventArgs e)
        {
            picboxnameCard11.Image = Properties.Resources.sunflower2;
            if (cardimage1 == null)
            {
                cardimage1 = picboxnameCard11;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxnameCard11;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard11.Enabled = false;
                    picboxnameCard11.Enabled = false;
                    picboxCard11.Image = Properties.Resources.thumbs;
                    picboxnameCard11.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxCard12_Click(object sender, EventArgs e)
        {
            picboxCard12.Image = Properties.Resources.tulip;
            if (cardimage1 == null)
            {
                cardimage1 = picboxCard12;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxCard12;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard12.Enabled = false;
                    picboxnameCard12.Enabled = false;
                    picboxCard12.Image = Properties.Resources.thumbs;
                    picboxnameCard12.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void picboxnameCard12_Click(object sender, EventArgs e)
        {
            picboxnameCard12.Image = Properties.Resources.tulip2;
            if (cardimage1 == null)
            {
                cardimage1 = picboxnameCard12;
            }
            else if (cardimage1 != null && cardimage2 == null)
            {
                cardimage2 = picboxnameCard12;

            }
            //check if all images are not empty
            if (cardimage1 != null && cardimage2 != null)
            {
                if (cardimage1.Tag == cardimage2.Tag)
                {

                    cardimage1 = null;
                    cardimage2 = null;
                    picboxCard12.Enabled = false;
                    picboxnameCard12.Enabled = false;
                    picboxCard12.Image = Properties.Resources.thumbs;
                    picboxnameCard12.Image = Properties.Resources.thumbs;
                    lblscoreCount.Text = Convert.ToString(Convert.ToInt32(lblscoreCount.Text) + 10);
                }
                else
                {
                    cardfliptimer1.Start();
                }
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            playgameintervaltimer1.Stop();
            playgametimer1.Stop();
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
                playgameintervaltimer1.Start();
                playgametimer1.Start();
            }

        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            lblcurrentguestusername.Text = selectPlayer.guest;
            string guestusername = lblcurrentguestusername.Text.ToString();
            gameDBconnect.Open();
            string username = lblcurrentusername.Text.ToString();

            string scores = lblscoreCount.Text.ToString();
            OleDbCommand saveplayer = new OleDbCommand();
            saveplayer.Connection = gameDBconnect;

            DialogResult restart = MessageBox.Show("you wish to restart game?", "", MessageBoxButtons.YesNo);
            if (restart == DialogResult.Yes)
            {
                saveplayer.CommandText = "INSERT INTO playerScores(userName,guestUserName,PlayerScore)values ('" + username + "','" + guestusername + "','" + scores + "')";
                saveplayer.ExecuteNonQuery();
                gameGUIP_Load(sender, e);
                gamestarttimer1.Start();
                gamestartintervaltimer1.Start();
                lblgamestart.Visible = true;
                gameDBconnect.Close();

            }
            else if (restart == DialogResult.No)
            {
                //players data will be stored automatically
                gameDBconnect.Close();
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            lblcurrentguestusername.Text = selectPlayer.guest;
            string guestusername = lblcurrentguestusername.Text.ToString();
            string scores = lblscoreCount.Text.ToString();
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
            DialogResult playerstatistic = MessageBox.Show("view player statistics", "", MessageBoxButtons.OK);
            if (playerstatistic == DialogResult.OK)
            {
                this.Hide();
                playerStats ps = new playerStats();
                ps.ShowDialog();
            }
        }
    }
}
