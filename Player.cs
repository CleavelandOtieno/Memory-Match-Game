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
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Player_Load(object sender, EventArgs e)
        {

        }

        private void btnguest_Click(object sender, EventArgs e)
        {
            this.Hide();
            levelCards lc = new levelCards();
            lc.ShowDialog();
        }
    }
}
