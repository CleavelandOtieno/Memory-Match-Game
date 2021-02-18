namespace CLEAVELAND_ONYANGO_AWD_PROJECT_2019
{
    partial class frmopengame
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
            this.btnStart = new System.Windows.Forms.Button();
            this.pBar_openGame = new CLEAVELAND_ONYANGO_AWD_PROJECT_2019.mySourceCode.openGame();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(142, 318);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 41);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START GAME";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pBar_openGame
            // 
            this.pBar_openGame.Location = new System.Drawing.Point(67, 12);
            this.pBar_openGame.Name = "pBar_openGame";
            this.pBar_openGame.Size = new System.Drawing.Size(300, 300);
            this.pBar_openGame.TabIndex = 0;
            // 
            // frmopengame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 371);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pBar_openGame);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmopengame";
            this.ShowIcon = false;
            this.Text = "Open_game";
            this.ResumeLayout(false);

        }

        #endregion

        private mySourceCode.openGame pBar_openGame;
        private System.Windows.Forms.Button btnStart;
    }
}

