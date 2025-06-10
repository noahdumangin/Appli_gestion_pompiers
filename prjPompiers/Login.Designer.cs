namespace prjPompiers
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.grblogin = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtmdp = new System.Windows.Forms.TextBox();
            this.btnanul = new System.Windows.Forms.Button();
            this.btnvalider = new System.Windows.Forms.Button();
            this.pbZ = new System.Windows.Forms.PictureBox();
            this.lblmdp = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lbllogin = new System.Windows.Forms.Label();
            this.grblogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZ)).BeginInit();
            this.SuspendLayout();
            // 
            // grblogin
            // 
            this.grblogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.grblogin.Controls.Add(this.lblid);
            this.grblogin.Controls.Add(this.txtmdp);
            this.grblogin.Controls.Add(this.btnanul);
            this.grblogin.Controls.Add(this.btnvalider);
            this.grblogin.Controls.Add(this.pbZ);
            this.grblogin.Controls.Add(this.lblmdp);
            this.grblogin.Controls.Add(this.txtLogin);
            this.grblogin.Controls.Add(this.lbllogin);
            this.grblogin.Location = new System.Drawing.Point(12, 12);
            this.grblogin.Name = "grblogin";
            this.grblogin.Size = new System.Drawing.Size(777, 441);
            this.grblogin.TabIndex = 0;
            this.grblogin.TabStop = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.SystemColors.Control;
            this.lblid.Location = new System.Drawing.Point(84, 22);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(360, 29);
            this.lblid.TabIndex = 7;
            this.lblid.Text = "Veuillez saisir vos identifiants :";
            // 
            // txtmdp
            // 
            this.txtmdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmdp.Location = new System.Drawing.Point(278, 132);
            this.txtmdp.Name = "txtmdp";
            this.txtmdp.PasswordChar = '*';
            this.txtmdp.Size = new System.Drawing.Size(144, 32);
            this.txtmdp.TabIndex = 6;
            // 
            // btnanul
            // 
            this.btnanul.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanul.Location = new System.Drawing.Point(584, 174);
            this.btnanul.Name = "btnanul";
            this.btnanul.Size = new System.Drawing.Size(117, 38);
            this.btnanul.TabIndex = 5;
            this.btnanul.Text = "Annuler";
            this.btnanul.UseVisualStyleBackColor = true;
            this.btnanul.Click += new System.EventHandler(this.btnanul_Click);
            // 
            // btnvalider
            // 
            this.btnvalider.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalider.Location = new System.Drawing.Point(236, 174);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(117, 38);
            this.btnvalider.TabIndex = 4;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // pbZ
            // 
            this.pbZ.ErrorImage = null;
            this.pbZ.Image = ((System.Drawing.Image)(resources.GetObject("pbZ.Image")));
            this.pbZ.Location = new System.Drawing.Point(21, 218);
            this.pbZ.Name = "pbZ";
            this.pbZ.Size = new System.Drawing.Size(734, 209);
            this.pbZ.TabIndex = 3;
            this.pbZ.TabStop = false;
            // 
            // lblmdp
            // 
            this.lblmdp.AutoSize = true;
            this.lblmdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmdp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblmdp.Location = new System.Drawing.Point(84, 135);
            this.lblmdp.Name = "lblmdp";
            this.lblmdp.Size = new System.Drawing.Size(179, 29);
            this.lblmdp.TabIndex = 2;
            this.lblmdp.Text = "Mot de passe :";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(192, 75);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(161, 32);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.SystemColors.Control;
            this.lbllogin.Location = new System.Drawing.Point(84, 78);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(89, 29);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "Login :";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 458);
            this.Controls.Add(this.grblogin);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.grblogin.ResumeLayout(false);
            this.grblogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grblogin;
        private System.Windows.Forms.Button btnanul;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Label lblmdp;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox txtmdp;
        private System.Windows.Forms.PictureBox pbZ;
        private System.Windows.Forms.Label lblid;
    }
}