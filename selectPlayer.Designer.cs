namespace CLEAVELAND_ONYANGO_AWD_2019
{
    partial class selectPlayer
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
            this.btnregistration = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnguest = new System.Windows.Forms.Button();
            this.pbLoadGame = new CLEAVELAND_ONYANGO_AWD_2019.myClasses.myProgressBar();
            this.SuspendLayout();
            // 
            // btnregistration
            // 
            this.btnregistration.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistration.Location = new System.Drawing.Point(12, 310);
            this.btnregistration.Name = "btnregistration";
            this.btnregistration.Size = new System.Drawing.Size(260, 40);
            this.btnregistration.TabIndex = 0;
            this.btnregistration.Text = "PLAYER REGISTRATION";
            this.btnregistration.UseVisualStyleBackColor = true;
            this.btnregistration.Click += new System.EventHandler(this.btnregistration_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(12, 264);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(260, 40);
            this.btnlogin.TabIndex = 1;
            this.btnlogin.Text = "PLAYER LOGIN";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnguest
            // 
            this.btnguest.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguest.Location = new System.Drawing.Point(11, 356);
            this.btnguest.Name = "btnguest";
            this.btnguest.Size = new System.Drawing.Size(260, 40);
            this.btnguest.TabIndex = 2;
            this.btnguest.Text = "PLAY AS GUEST";
            this.btnguest.UseVisualStyleBackColor = true;
            this.btnguest.Click += new System.EventHandler(this.btnguest_Click);
            // 
            // pbLoadGame
            // 
            this.pbLoadGame.Location = new System.Drawing.Point(12, 12);
            this.pbLoadGame.Name = "pbLoadGame";
            this.pbLoadGame.Size = new System.Drawing.Size(259, 246);
            this.pbLoadGame.TabIndex = 3;
            // 
            // selectPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 406);
            this.Controls.Add(this.pbLoadGame);
            this.Controls.Add(this.btnguest);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnregistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "selectPlayer";
            this.ShowIcon = false;
            this.Text = "PLAYER";
            this.Load += new System.EventHandler(this.selectPlayer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnregistration;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnguest;
        private myClasses.myProgressBar pbLoadGame;
    }
}