using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLEAVELAND_ONYANGO_AWD_PROJECT_2019
{
    public partial class levelCards : Form
    {
      
        public levelCards()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void levelCards_Load(object sender, EventArgs e)
        {

        }

        private void rdbtnanimals_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnfruits.Checked= false;
            rdbtnplants.Checked = false;
        }

        private void rdbtnfruits_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnplants.Checked = false;
            rdbtnanimals.Checked = false;
        }

        private void rdbtnplants_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnanimals.Checked = false;
            rdbtnfruits.Checked = false;
        }

        private void rdbtnsix_CheckedChanged(object sender, EventArgs e)
        {
            rdbtntwelve.Checked = false;
            rdbtntwentyfour.Checked = false;
        }

        private void rdbtntwelve_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnsix.Checked = false;
            rdbtntwentyfour.Checked = false;
        }

        private void rdbtntwentyfour_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnsix.Checked = false;
            rdbtntwelve.Checked = false;
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            if(rdbtnanimals.Checked && rdbtntwentyfour.Checked)
            {
                this.Hide();
                GameUIanimal guia = new GameUIanimal();
                guia.ShowDialog();
            }else if(rdbtnplants.Checked && rdbtntwentyfour.Checked)
            {
                this.Hide();
                GameUIplant guip = new GameUIplant();
                guip.ShowDialog();
            }else if(rdbtnfruits.Checked && rdbtntwentyfour.Checked)
            {
                this.Hide();
                GameUIfruit guif = new GameUIfruit();
                guif.ShowDialog();
            }
        }
    }
}
