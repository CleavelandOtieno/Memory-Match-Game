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
    public partial class frmopengame : Form
    {
        public frmopengame()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
           
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            
            Task.Run(() =>
            {
                for(int num = 0; num <= 100; num++)
                {
                    //pass the increment values 
                    new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(this.progressupdate)).Start(num);
                    System.Threading.Thread.Sleep(60);
                    //this.Hide();

                }
                
                //this.WindowState = FormWindowState.Minimized;
                Player player = new Player();
                player.ShowDialog();
                

            });
            

        }
        public void progressupdate(object progress)
        {
            pBar_openGame.Invoke((MethodInvoker)delegate { pBar_openGame.updateProgress(Convert.ToInt32(progress)); });
            
        }

        
    }
}
