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
    public partial class selectPlayer : Form
    {
        public static string guest = "";
        public event EventHandler clickguest;
        public selectPlayer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void selectPlayer_Load(object sender, EventArgs e)
        {
            btnguest.Enabled = false;
            btnlogin.Enabled = false;
            btnregistration.Enabled = false;
            Task.Run(() =>
            {
                for(int num = 0; num <= 100; num++)
                {
                    //parse increment values
                    new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(this.progressupdater)).Start(num);
                    System.Threading.Thread.Sleep(60);
                    
                }
               
            });
        
            btnguest.Enabled = true;
            btnlogin.Enabled = true;
            btnregistration.Enabled = true;

        }
        public void progressupdater(object progress)
        {
            pbLoadGame.Invoke((MethodInvoker)delegate { pbLoadGame.updateprogressbar(Convert.ToInt32(progress));});
           
        }

        private void btnguest_Click(object sender, EventArgs e)
        {
            clickguest = btnguest_Click;
            char[] usernameletters = "abcdefghijklmnopqrstuvwxyz123456789".ToArray();
            Random rdguest = new Random();
            string rdgueststring = "";
            for(int cc = 0; cc < 10; cc++)
            {
                rdgueststring += usernameletters[rdguest.Next(0, 25)].ToString();
            }
            guest = rdgueststring;
            this.Hide();
            levelCard lc = new levelCard();
            lc.ShowDialog();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            playerLOGIN plog = new playerLOGIN();
            plog.ShowDialog();
        }

        private void btnregistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            playerREGISTRATION preg = new playerREGISTRATION();
            preg.ShowDialog();
        }
    }
}
