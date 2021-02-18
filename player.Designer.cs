namespace CLEAVELAND_ONYANGO_AWD_PROJECT_2019
{
    partial class Player
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnguest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(59, 43);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(310, 57);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "PLAYER LOGIN";
            this.btnlogin.UseVisualStyleBackColor = true;
            // 
            // btnregister
            // 
            this.btnregister.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.Location = new System.Drawing.Point(59, 166);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(310, 50);
            this.btnregister.TabIndex = 1;
            this.btnregister.Text = "PLAYER REGISTRATION";
            this.btnregister.UseVisualStyleBackColor = true;
            // 
            // btnguest
            // 
            this.btnguest.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguest.Location = new System.Drawing.Point(59, 279);
            this.btnguest.Name = "btnguest";
            this.btnguest.Size = new System.Drawing.Size(310, 52);
            this.btnguest.TabIndex = 2;
            this.btnguest.Text = "PLAY AS GUEST";
            this.btnguest.UseVisualStyleBackColor = true;
            this.btnguest.Click += new System.EventHandler(this.btnguest_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 371);
            this.Controls.Add(this.btnguest);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Player";
            this.ShowIcon = false;
            this.Text = "player";
            this.Load += new System.EventHandler(this.Player_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnguest;
    }
}