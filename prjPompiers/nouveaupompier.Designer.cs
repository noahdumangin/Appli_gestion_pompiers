namespace prjPompiers
{
    partial class nouveaupompier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nouveaupompier));
            this.grbInfos = new System.Windows.Forms.GroupBox();
            this.clbHabil = new System.Windows.Forms.CheckedListBox();
            this.lblHabil = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.txtsexe = new System.Windows.Forms.TextBox();
            this.dtpenboche = new System.Windows.Forms.DateTimePicker();
            this.dtpnaissance = new System.Windows.Forms.DateTimePicker();
            this.lbldat = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.btnanul = new System.Windows.Forms.Button();
            this.lbltype = new System.Windows.Forms.Label();
            this.btnvalider = new System.Windows.Forms.Button();
            this.pibgrade = new System.Windows.Forms.PictureBox();
            this.lblgrade = new System.Windows.Forms.Label();
            this.cbocaserne = new System.Windows.Forms.ComboBox();
            this.lblcaserne = new System.Windows.Forms.Label();
            this.txtBip = new System.Windows.Forms.TextBox();
            this.lblbip = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblsexe = new System.Windows.Forms.Label();
            this.txtprn = new System.Windows.Forms.TextBox();
            this.lblprn = new System.Windows.Forms.Label();
            this.pictureBoxphoto = new System.Windows.Forms.PictureBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.grbInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibgrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfos
            // 
            this.grbInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.grbInfos.Controls.Add(this.clbHabil);
            this.grbInfos.Controls.Add(this.lblHabil);
            this.grbInfos.Controls.Add(this.txttype);
            this.grbInfos.Controls.Add(this.txtsexe);
            this.grbInfos.Controls.Add(this.dtpenboche);
            this.grbInfos.Controls.Add(this.dtpnaissance);
            this.grbInfos.Controls.Add(this.lbldat);
            this.grbInfos.Controls.Add(this.cboGrade);
            this.grbInfos.Controls.Add(this.btnanul);
            this.grbInfos.Controls.Add(this.lbltype);
            this.grbInfos.Controls.Add(this.btnvalider);
            this.grbInfos.Controls.Add(this.pibgrade);
            this.grbInfos.Controls.Add(this.lblgrade);
            this.grbInfos.Controls.Add(this.cbocaserne);
            this.grbInfos.Controls.Add(this.lblcaserne);
            this.grbInfos.Controls.Add(this.txtBip);
            this.grbInfos.Controls.Add(this.lblbip);
            this.grbInfos.Controls.Add(this.txttel);
            this.grbInfos.Controls.Add(this.lbltel);
            this.grbInfos.Controls.Add(this.lbldate);
            this.grbInfos.Controls.Add(this.lblsexe);
            this.grbInfos.Controls.Add(this.txtprn);
            this.grbInfos.Controls.Add(this.lblprn);
            this.grbInfos.Controls.Add(this.pictureBoxphoto);
            this.grbInfos.Controls.Add(this.txtNom);
            this.grbInfos.Controls.Add(this.lblNom);
            this.grbInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfos.ForeColor = System.Drawing.SystemColors.Control;
            this.grbInfos.Location = new System.Drawing.Point(12, 12);
            this.grbInfos.Name = "grbInfos";
            this.grbInfos.Size = new System.Drawing.Size(2024, 1059);
            this.grbInfos.TabIndex = 0;
            this.grbInfos.TabStop = false;
            this.grbInfos.Text = "Infos Pompier";
            // 
            // clbHabil
            // 
            this.clbHabil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbHabil.FormattingEnabled = true;
            this.clbHabil.Location = new System.Drawing.Point(1016, 555);
            this.clbHabil.Name = "clbHabil";
            this.clbHabil.Size = new System.Drawing.Size(557, 463);
            this.clbHabil.TabIndex = 33;
            // 
            // lblHabil
            // 
            this.lblHabil.AutoSize = true;
            this.lblHabil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabil.Location = new System.Drawing.Point(683, 548);
            this.lblHabil.Name = "lblHabil";
            this.lblHabil.Size = new System.Drawing.Size(301, 29);
            this.lblHabil.TabIndex = 32;
            this.lblHabil.Text = "Ajouter des Habilitations :";
            // 
            // txttype
            // 
            this.txttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttype.Location = new System.Drawing.Point(823, 373);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(121, 32);
            this.txttype.TabIndex = 31;
            this.txttype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttype_KeyPress);
            // 
            // txtsexe
            // 
            this.txtsexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsexe.Location = new System.Drawing.Point(186, 337);
            this.txtsexe.Name = "txtsexe";
            this.txtsexe.Size = new System.Drawing.Size(190, 32);
            this.txtsexe.TabIndex = 30;
            this.txtsexe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsexe_KeyPress);
            // 
            // dtpenboche
            // 
            this.dtpenboche.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpenboche.Location = new System.Drawing.Point(287, 546);
            this.dtpenboche.Name = "dtpenboche";
            this.dtpenboche.Size = new System.Drawing.Size(229, 32);
            this.dtpenboche.TabIndex = 29;
            // 
            // dtpnaissance
            // 
            this.dtpnaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpnaissance.Location = new System.Drawing.Point(287, 441);
            this.dtpnaissance.Name = "dtpnaissance";
            this.dtpnaissance.Size = new System.Drawing.Size(229, 32);
            this.dtpnaissance.TabIndex = 28;
            // 
            // lbldat
            // 
            this.lbldat.AutoSize = true;
            this.lbldat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldat.Location = new System.Drawing.Point(44, 441);
            this.lbldat.Name = "lbldat";
            this.lbldat.Size = new System.Drawing.Size(237, 29);
            this.lbldat.TabIndex = 27;
            this.lbldat.Text = "Date de naissance :";
            // 
            // cboGrade
            // 
            this.cboGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(823, 309);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(187, 34);
            this.cboGrade.TabIndex = 26;
            this.cboGrade.SelectedIndexChanged += new System.EventHandler(this.cboGrade_SelectedIndexChanged);
            // 
            // btnanul
            // 
            this.btnanul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btnanul.Location = new System.Drawing.Point(643, 798);
            this.btnanul.Name = "btnanul";
            this.btnanul.Size = new System.Drawing.Size(127, 49);
            this.btnanul.TabIndex = 25;
            this.btnanul.Text = "Annuler";
            this.btnanul.UseVisualStyleBackColor = true;
            this.btnanul.Click += new System.EventHandler(this.btnanul_Click);
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(683, 376);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(83, 29);
            this.lbltype.TabIndex = 22;
            this.lbltype.Text = "Type :";
            // 
            // btnvalider
            // 
            this.btnvalider.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btnvalider.Location = new System.Drawing.Point(477, 795);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(138, 55);
            this.btnvalider.TabIndex = 21;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // pibgrade
            // 
            this.pibgrade.Location = new System.Drawing.Point(1112, 337);
            this.pibgrade.Name = "pibgrade";
            this.pibgrade.Size = new System.Drawing.Size(206, 189);
            this.pibgrade.TabIndex = 20;
            this.pibgrade.TabStop = false;
            // 
            // lblgrade
            // 
            this.lblgrade.AutoSize = true;
            this.lblgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrade.Location = new System.Drawing.Point(683, 314);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(96, 29);
            this.lblgrade.TabIndex = 18;
            this.lblgrade.Text = "Grade :";
            // 
            // cbocaserne
            // 
            this.cbocaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocaserne.FormattingEnabled = true;
            this.cbocaserne.Location = new System.Drawing.Point(1062, 260);
            this.cbocaserne.Name = "cbocaserne";
            this.cbocaserne.Size = new System.Drawing.Size(210, 34);
            this.cbocaserne.TabIndex = 17;
            // 
            // lblcaserne
            // 
            this.lblcaserne.AutoSize = true;
            this.lblcaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaserne.Location = new System.Drawing.Point(683, 260);
            this.lblcaserne.Name = "lblcaserne";
            this.lblcaserne.Size = new System.Drawing.Size(312, 29);
            this.lblcaserne.TabIndex = 16;
            this.lblcaserne.Text = "Caserne de rattachement :";
            // 
            // txtBip
            // 
            this.txtBip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBip.Location = new System.Drawing.Point(114, 725);
            this.txtBip.Name = "txtBip";
            this.txtBip.Size = new System.Drawing.Size(139, 32);
            this.txtBip.TabIndex = 15;
            this.txtBip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBip_KeyPress);
            // 
            // lblbip
            // 
            this.lblbip.AutoSize = true;
            this.lblbip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbip.Location = new System.Drawing.Point(44, 725);
            this.lblbip.Name = "lblbip";
            this.lblbip.Size = new System.Drawing.Size(64, 29);
            this.lblbip.TabIndex = 14;
            this.lblbip.Text = "Bip :";
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(209, 636);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(167, 32);
            this.txttel.TabIndex = 13;
            this.txttel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttel_KeyPress);
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.Location = new System.Drawing.Point(44, 639);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(146, 29);
            this.lbltel.TabIndex = 12;
            this.lbltel.Text = "Téléphone :";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(44, 546);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(225, 29);
            this.lbldate.TabIndex = 10;
            this.lbldate.Text = "Date d\'embauche :";
            // 
            // lblsexe
            // 
            this.lblsexe.AutoSize = true;
            this.lblsexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexe.Location = new System.Drawing.Point(44, 337);
            this.lblsexe.Name = "lblsexe";
            this.lblsexe.Size = new System.Drawing.Size(84, 29);
            this.lblsexe.TabIndex = 7;
            this.lblsexe.Text = "Sexe :";
            // 
            // txtprn
            // 
            this.txtprn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprn.Location = new System.Drawing.Point(186, 248);
            this.txtprn.Name = "txtprn";
            this.txtprn.Size = new System.Drawing.Size(190, 32);
            this.txtprn.TabIndex = 6;
            this.txtprn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprn_KeyPress);
            // 
            // lblprn
            // 
            this.lblprn.AutoSize = true;
            this.lblprn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprn.Location = new System.Drawing.Point(44, 246);
            this.lblprn.Name = "lblprn";
            this.lblprn.Size = new System.Drawing.Size(116, 29);
            this.lblprn.TabIndex = 5;
            this.lblprn.Text = "Prénom :";
            // 
            // pictureBoxphoto
            // 
            this.pictureBoxphoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxphoto.Image")));
            this.pictureBoxphoto.Location = new System.Drawing.Point(811, 16);
            this.pictureBoxphoto.Name = "pictureBoxphoto";
            this.pictureBoxphoto.Size = new System.Drawing.Size(461, 209);
            this.pictureBoxphoto.TabIndex = 4;
            this.pictureBoxphoto.TabStop = false;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(139, 162);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(237, 32);
            this.txtNom.TabIndex = 3;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(44, 162);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(81, 29);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom :";
            // 
            // nouveaupompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1096);
            this.Controls.Add(this.grbInfos);
            this.Name = "nouveaupompier";
            this.Text = "nouveaupompier";
            this.Load += new System.EventHandler(this.nouveaupompier_Load);
            this.grbInfos.ResumeLayout(false);
            this.grbInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibgrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxphoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfos;
        private System.Windows.Forms.TextBox txtprn;
        private System.Windows.Forms.Label lblprn;
        private System.Windows.Forms.PictureBox pictureBoxphoto;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblsexe;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblbip;
        private System.Windows.Forms.TextBox txtBip;
        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.ComboBox cbocaserne;
        private System.Windows.Forms.Label lblcaserne;
        private System.Windows.Forms.PictureBox pibgrade;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Button btnanul;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.DateTimePicker dtpenboche;
        private System.Windows.Forms.DateTimePicker dtpnaissance;
        private System.Windows.Forms.Label lbldat;
        private System.Windows.Forms.TextBox txtsexe;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Label lblHabil;
        private System.Windows.Forms.CheckedListBox clbHabil;
    }
}