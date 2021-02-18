namespace CLEAVELAND_ONYANGO_AWD_2019
{
    partial class gameGUIF_6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameGUIF_6));
            this.cardfliptimer = new System.Windows.Forms.Timer(this.components);
            this.gamestarttimer = new System.Windows.Forms.Timer(this.components);
            this.playgameIntervaltimer = new System.Windows.Forms.Timer(this.components);
            this.gamestartIntervaltimer = new System.Windows.Forms.Timer(this.components);
            this.lblscorecount = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblgamestart = new System.Windows.Forms.Label();
            this.lblcurrentusername = new System.Windows.Forms.Label();
            this.pnlcardholder = new System.Windows.Forms.Panel();
            this.lblgametime = new System.Windows.Forms.Label();
            this.lblguestusername = new System.Windows.Forms.Label();
            this.playgametimer = new System.Windows.Forms.Timer(this.components);
            this.btnchart = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnrestart = new System.Windows.Forms.Button();
            this.picboxnameCard3 = new System.Windows.Forms.PictureBox();
            this.picboxCard3 = new System.Windows.Forms.PictureBox();
            this.picboxnameCard2 = new System.Windows.Forms.PictureBox();
            this.picboxCard2 = new System.Windows.Forms.PictureBox();
            this.picboxnameCard1 = new System.Windows.Forms.PictureBox();
            this.picboxCard1 = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            this.pnlcardholder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxnameCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxnameCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxnameCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // cardfliptimer
            // 
            this.cardfliptimer.Interval = 500;
            this.cardfliptimer.Tick += new System.EventHandler(this.cardfliptimer_Tick);
            // 
            // gamestarttimer
            // 
            this.gamestarttimer.Interval = 5000;
            this.gamestarttimer.Tick += new System.EventHandler(this.gamestarttimer_Tick);
            // 
            // playgameIntervaltimer
            // 
            this.playgameIntervaltimer.Interval = 500;
            this.playgameIntervaltimer.Tick += new System.EventHandler(this.playgameIntervaltimer_Tick);
            // 
            // gamestartIntervaltimer
            // 
            this.gamestartIntervaltimer.Interval = 1000;
            this.gamestartIntervaltimer.Tick += new System.EventHandler(this.gamestartIntervaltimer_Tick);
            // 
            // lblscorecount
            // 
            this.lblscorecount.AutoSize = true;
            this.lblscorecount.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscorecount.Location = new System.Drawing.Point(157, 65);
            this.lblscorecount.Name = "lblscorecount";
            this.lblscorecount.Size = new System.Drawing.Size(0, 39);
            this.lblscorecount.TabIndex = 69;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(392, 65);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(196, 39);
            this.lbltime.TabIndex = 62;
            this.lbltime.Text = "TIME LEFT:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 65);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(139, 39);
            this.lblScore.TabIndex = 61;
            this.lblScore.Text = "SCORE:";
            // 
            // lblgamestart
            // 
            this.lblgamestart.AutoSize = true;
            this.lblgamestart.Font = new System.Drawing.Font("Lucida Sans", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgamestart.Location = new System.Drawing.Point(282, 12);
            this.lblgamestart.Name = "lblgamestart";
            this.lblgamestart.Size = new System.Drawing.Size(0, 72);
            this.lblgamestart.TabIndex = 71;
            // 
            // lblcurrentusername
            // 
            this.lblcurrentusername.AutoSize = true;
            this.lblcurrentusername.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurrentusername.Location = new System.Drawing.Point(208, 12);
            this.lblcurrentusername.Name = "lblcurrentusername";
            this.lblcurrentusername.Size = new System.Drawing.Size(204, 32);
            this.lblcurrentusername.TabIndex = 65;
            this.lblcurrentusername.Text = "current player";
            // 
            // pnlcardholder
            // 
            this.pnlcardholder.Controls.Add(this.picboxnameCard3);
            this.pnlcardholder.Controls.Add(this.picboxCard3);
            this.pnlcardholder.Controls.Add(this.picboxnameCard2);
            this.pnlcardholder.Controls.Add(this.picboxCard2);
            this.pnlcardholder.Controls.Add(this.picboxnameCard1);
            this.pnlcardholder.Controls.Add(this.picboxCard1);
            this.pnlcardholder.Location = new System.Drawing.Point(12, 107);
            this.pnlcardholder.Name = "pnlcardholder";
            this.pnlcardholder.Size = new System.Drawing.Size(643, 166);
            this.pnlcardholder.TabIndex = 72;
            // 
            // lblgametime
            // 
            this.lblgametime.AutoSize = true;
            this.lblgametime.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgametime.Location = new System.Drawing.Point(594, 65);
            this.lblgametime.Name = "lblgametime";
            this.lblgametime.Size = new System.Drawing.Size(0, 39);
            this.lblgametime.TabIndex = 70;
            // 
            // lblguestusername
            // 
            this.lblguestusername.AutoSize = true;
            this.lblguestusername.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguestusername.Location = new System.Drawing.Point(168, 9);
            this.lblguestusername.Name = "lblguestusername";
            this.lblguestusername.Size = new System.Drawing.Size(333, 32);
            this.lblguestusername.TabIndex = 67;
            this.lblguestusername.Text = "current guest username";
            // 
            // playgametimer
            // 
            this.playgametimer.Interval = 10000;
            this.playgametimer.Tick += new System.EventHandler(this.playgametimer_Tick);
            // 
            // btnchart
            // 
            this.btnchart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnchart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnchart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnchart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchart.Image = global::CLEAVELAND_ONYANGO_AWD_2019.Properties.Resources.chart;
            this.btnchart.Location = new System.Drawing.Point(552, 12);
            this.btnchart.Name = "btnchart";
            this.btnchart.Size = new System.Drawing.Size(50, 50);
            this.btnchart.TabIndex = 68;
            this.btnchart.UseVisualStyleBackColor = true;
            this.btnchart.Click += new System.EventHandler(this.btnchart_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnlogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Image = global::CLEAVELAND_ONYANGO_AWD_2019.Properties.Resources.logout;
            this.btnlogout.Location = new System.Drawing.Point(68, 12);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(50, 50);
            this.btnlogout.TabIndex = 66;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnrestart
            // 
            this.btnrestart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnrestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnrestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnrestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestart.Image = ((System.Drawing.Image)(resources.GetObject("btnrestart.Image")));
            this.btnrestart.Location = new System.Drawing.Point(608, 12);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(50, 50);
            this.btnrestart.TabIndex = 63;
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // picboxnameCard3
            // 
            this.picboxnameCard3.Location = new System.Drawing.Point(537, 3);
            this.picboxnameCard3.Name = "picboxnameCard3";
            this.picboxnameCard3.Size = new System.Drawing.Size(100, 150);
            this.picboxnameCard3.TabIndex = 5;
            this.picboxnameCard3.TabStop = false;
            this.picboxnameCard3.Tag = "3";
            this.picboxnameCard3.Click += new System.EventHandler(this.picboxnameCard3_Click);
            // 
            // picboxCard3
            // 
            this.picboxCard3.Location = new System.Drawing.Point(431, 3);
            this.picboxCard3.Name = "picboxCard3";
            this.picboxCard3.Size = new System.Drawing.Size(100, 150);
            this.picboxCard3.TabIndex = 4;
            this.picboxCard3.TabStop = false;
            this.picboxCard3.Tag = "3";
            this.picboxCard3.Click += new System.EventHandler(this.picboxCard3_Click);
            // 
            // picboxnameCard2
            // 
            this.picboxnameCard2.Location = new System.Drawing.Point(325, 3);
            this.picboxnameCard2.Name = "picboxnameCard2";
            this.picboxnameCard2.Size = new System.Drawing.Size(100, 150);
            this.picboxnameCard2.TabIndex = 3;
            this.picboxnameCard2.TabStop = false;
            this.picboxnameCard2.Tag = "2";
            this.picboxnameCard2.Click += new System.EventHandler(this.picboxnameCard2_Click);
            // 
            // picboxCard2
            // 
            this.picboxCard2.Location = new System.Drawing.Point(219, 3);
            this.picboxCard2.Name = "picboxCard2";
            this.picboxCard2.Size = new System.Drawing.Size(100, 150);
            this.picboxCard2.TabIndex = 2;
            this.picboxCard2.TabStop = false;
            this.picboxCard2.Tag = "2";
            this.picboxCard2.Click += new System.EventHandler(this.picboxCard2_Click);
            // 
            // picboxnameCard1
            // 
            this.picboxnameCard1.Location = new System.Drawing.Point(113, 3);
            this.picboxnameCard1.Name = "picboxnameCard1";
            this.picboxnameCard1.Size = new System.Drawing.Size(100, 150);
            this.picboxnameCard1.TabIndex = 1;
            this.picboxnameCard1.TabStop = false;
            this.picboxnameCard1.Tag = "1";
            this.picboxnameCard1.Click += new System.EventHandler(this.picboxnameCard1_Click);
            // 
            // picboxCard1
            // 
            this.picboxCard1.Location = new System.Drawing.Point(7, 3);
            this.picboxCard1.Name = "picboxCard1";
            this.picboxCard1.Size = new System.Drawing.Size(100, 150);
            this.picboxCard1.TabIndex = 0;
            this.picboxCard1.TabStop = false;
            this.picboxCard1.Tag = "1";
            this.picboxCard1.Click += new System.EventHandler(this.picboxCard1_Click);
            // 
            // btnback
            // 
            this.btnback.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(12, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(50, 50);
            this.btnback.TabIndex = 64;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // gameGUIF_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 290);
            this.Controls.Add(this.btnchart);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.lblscorecount);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblgamestart);
            this.Controls.Add(this.lblcurrentusername);
            this.Controls.Add(this.pnlcardholder);
            this.Controls.Add(this.lblgametime);
            this.Controls.Add(this.lblguestusername);
            this.Controls.Add(this.btnback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gameGUIF_6";
            this.ShowIcon = false;
            this.Text = "FRUITS";
            this.Load += new System.EventHandler(this.gameGUIF_6_Load);
            this.pnlcardholder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxnameCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxnameCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxnameCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxnameCard3;
        private System.Windows.Forms.PictureBox picboxCard3;
        private System.Windows.Forms.PictureBox picboxnameCard2;
        private System.Windows.Forms.PictureBox picboxCard2;
        private System.Windows.Forms.PictureBox picboxCard1;
        private System.Windows.Forms.Button btnchart;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Timer cardfliptimer;
        private System.Windows.Forms.Timer gamestarttimer;
        private System.Windows.Forms.PictureBox picboxnameCard1;
        private System.Windows.Forms.Timer playgameIntervaltimer;
        private System.Windows.Forms.Timer gamestartIntervaltimer;
        private System.Windows.Forms.Label lblscorecount;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblgamestart;
        public System.Windows.Forms.Label lblcurrentusername;
        private System.Windows.Forms.Panel pnlcardholder;
        private System.Windows.Forms.Label lblgametime;
        private System.Windows.Forms.Label lblguestusername;
        private System.Windows.Forms.Timer playgametimer;
        private System.Windows.Forms.Button btnback;
    }
}