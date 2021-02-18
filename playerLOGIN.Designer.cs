namespace CLEAVELAND_ONYANGO_AWD_2019
{
    partial class playerLOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerLOGIN));
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblUname = new System.Windows.Forms.Label();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(147, 66);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(353, 30);
            this.txtPass.TabIndex = 15;
            // 
            // txtUname
            // 
            this.txtUname.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUname.Location = new System.Drawing.Point(147, 18);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(353, 30);
            this.txtUname.TabIndex = 14;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(12, 66);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(97, 22);
            this.lblpass.TabIndex = 13;
            this.lblpass.Text = "Password";
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.Location = new System.Drawing.Point(12, 21);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(105, 22);
            this.lblUname.TabIndex = 12;
            this.lblUname.Text = "UserName";
            // 
            // btnplay
            // 
            this.btnplay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnplay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplay.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.Image = global::CLEAVELAND_ONYANGO_AWD_2019.Properties.Resources.go;
            this.btnplay.Location = new System.Drawing.Point(192, 114);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(80, 80);
            this.btnplay.TabIndex = 16;
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnback
            // 
            this.btnback.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(16, 146);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(50, 50);
            this.btnback.TabIndex = 21;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // playerLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 208);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblUname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "playerLOGIN";
            this.ShowIcon = false;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.playerLOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnback;
    }
}