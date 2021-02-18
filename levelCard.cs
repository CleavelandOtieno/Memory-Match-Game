using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLEAVELAND_ONYANGO_AWD_2019
{
    public partial class levelCard : Form
    {
        public levelCard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void rbbtnAnimal_CheckedChanged(object sender, EventArgs e)
        {
            rbbtnFruit.Checked = false;
            rbbtnPlant.Checked = false;
        }

        private void rbbtnPlant_CheckedChanged(object sender, EventArgs e)
        {
            rbbtnFruit.Checked = false;
            rbbtnAnimal.Checked = false;
        }

        private void rbbtnFruit_CheckedChanged(object sender, EventArgs e)
        {
            rbbtnAnimal.Checked = false;
            rbbtnPlant.Checked = false;
        }

        private void rbbtnsix_CheckedChanged(object sender, EventArgs e)
        {
            rbbtnABeginner.Checked = false;
            rbbtnCompetent.Checked = false;
        }

        private void rbbtntwelve_CheckedChanged(object sender, EventArgs e)
        {
            rbbtnNovice.Checked = false;
            rbbtnCompetent.Checked = false;
        }

        private void rbbtntwentyfour_CheckedChanged(object sender, EventArgs e)
        {
            rbbtnABeginner.Checked = false;
            rbbtnNovice.Checked = false;
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            if (rbbtnAnimal.Checked && rbbtnCompetent.Checked)
            {
                this.Hide();
                gameGUIA guia = new gameGUIA();
                guia.ShowDialog();
            }
            else if (rbbtnAnimal.Checked && rbbtnNovice.Checked)
            {
                this.Hide();
                gameGUIA_6 guia6 = new gameGUIA_6();
                guia6.ShowDialog();
            }
            else if (rbbtnAnimal.Checked && rbbtnABeginner.Checked)
            {
                this.Hide();
                gameGUIA_12 guia12 = new gameGUIA_12();
                guia12.ShowDialog();
            }
            else if (rbbtnPlant.Checked && rbbtnCompetent.Checked)
            {
                this.Hide();
                gameGUIP guip = new gameGUIP();
                guip.ShowDialog();
            }
            else if (rbbtnPlant.Checked && rbbtnNovice.Checked)
            {
                this.Hide();
                gameGUIP_6 guip6 = new gameGUIP_6();
                guip6.ShowDialog();
            }
            else if (rbbtnPlant.Checked && rbbtnABeginner.Checked)
            {
                this.Hide();
                gameGUIP_12 guip12 = new gameGUIP_12();
                guip12.ShowDialog();
            }
            else if (rbbtnFruit.Checked && rbbtnCompetent.Checked)
            {
                this.Hide();
                gameGUIF guif = new gameGUIF();
                guif.ShowDialog();
            }
            else if (rbbtnFruit.Checked && rbbtnNovice.Checked)
            {
                this.Hide();
                gameGUIF_6 guif6 = new gameGUIF_6();
                guif6.ShowDialog();
            }
            else if (rbbtnFruit.Checked && rbbtnABeginner.Checked)
            {
                this.Hide();
                gameGUIF_12 guif12 = new gameGUIF_12();
                guif12.ShowDialog();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectPlayer sp = new selectPlayer();
            sp.ShowDialog();
        }

        private void levelCard_Load(object sender, EventArgs e)
        {

        }
    }
}
