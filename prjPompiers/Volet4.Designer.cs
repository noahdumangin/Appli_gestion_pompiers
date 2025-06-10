namespace prjPompiers
{
    partial class Volet4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Volet4));
            this.lblExit = new System.Windows.Forms.Label();
            this.pbretour = new System.Windows.Forms.PictureBox();
            this.lblnewpomp = new System.Windows.Forms.Label();
            this.pbajout = new System.Windows.Forms.PictureBox();
            this.cboPompier = new System.Windows.Forms.ComboBox();
            this.lblPompier = new System.Windows.Forms.Label();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.pbGIF = new System.Windows.Forms.PictureBox();
            this.grbProfil = new System.Windows.Forms.GroupBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.pbGrade = new System.Windows.Forms.PictureBox();
            this.lblbip = new System.Windows.Forms.Label();
            this.grbPompier = new System.Windows.Forms.GroupBox();
            this.lblTelep = new System.Windows.Forms.Label();
            this.lblemboche = new System.Windows.Forms.Label();
            this.rdbPro = new System.Windows.Forms.RadioButton();
            this.rdbVolontaire = new System.Windows.Forms.RadioButton();
            this.lblsexe = new System.Windows.Forms.Label();
            this.lblPrn = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.btninfos = new System.Windows.Forms.Button();
            this.grbinfos = new System.Windows.Forms.GroupBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.cbograde = new System.Windows.Forms.ComboBox();
            this.btnjour = new System.Windows.Forms.Button();
            this.cbconger = new System.Windows.Forms.CheckBox();
            this.lstaff = new System.Windows.Forms.ListBox();
            this.lblhabilp = new System.Windows.Forms.Label();
            this.lsthabil = new System.Windows.Forms.ListBox();
            this.lblhabil = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.cbocas = new System.Windows.Forms.ComboBox();
            this.lblcas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbretour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbajout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGIF)).BeginInit();
            this.grbProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrade)).BeginInit();
            this.grbPompier.SuspendLayout();
            this.grbinfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.Control;
            this.lblExit.Location = new System.Drawing.Point(134, 972);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(213, 58);
            this.lblExit.TabIndex = 8;
            this.lblExit.Text = "Retour au tableau\r\n de bord";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // pbretour
            // 
            this.pbretour.Image = ((System.Drawing.Image)(resources.GetObject("pbretour.Image")));
            this.pbretour.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbretour.InitialImage")));
            this.pbretour.Location = new System.Drawing.Point(33, 966);
            this.pbretour.Name = "pbretour";
            this.pbretour.Size = new System.Drawing.Size(73, 64);
            this.pbretour.TabIndex = 7;
            this.pbretour.TabStop = false;
            this.pbretour.Click += new System.EventHandler(this.pbretour_Click_1);
            // 
            // lblnewpomp
            // 
            this.lblnewpomp.AutoSize = true;
            this.lblnewpomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpomp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnewpomp.Location = new System.Drawing.Point(28, 562);
            this.lblnewpomp.Name = "lblnewpomp";
            this.lblnewpomp.Size = new System.Drawing.Size(354, 29);
            this.lblnewpomp.TabIndex = 6;
            this.lblnewpomp.Text = "Ajout d\'un nouveau pompier";
            this.lblnewpomp.Click += new System.EventHandler(this.lblnewpomp_Click);
            // 
            // pbajout
            // 
            this.pbajout.Image = ((System.Drawing.Image)(resources.GetObject("pbajout.Image")));
            this.pbajout.Location = new System.Drawing.Point(76, 633);
            this.pbajout.Name = "pbajout";
            this.pbajout.Size = new System.Drawing.Size(239, 199);
            this.pbajout.TabIndex = 5;
            this.pbajout.TabStop = false;
            this.pbajout.Click += new System.EventHandler(this.pbajout_Click);
            // 
            // cboPompier
            // 
            this.cboPompier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPompier.FormattingEnabled = true;
            this.cboPompier.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboPompier.Location = new System.Drawing.Point(76, 408);
            this.cboPompier.Name = "cboPompier";
            this.cboPompier.Size = new System.Drawing.Size(219, 34);
            this.cboPompier.TabIndex = 4;
            this.cboPompier.SelectionChangeCommitted += new System.EventHandler(this.cboPompier_SelectionChangeCommitted);
            // 
            // lblPompier
            // 
            this.lblPompier.AutoSize = true;
            this.lblPompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPompier.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPompier.Location = new System.Drawing.Point(45, 349);
            this.lblPompier.Name = "lblPompier";
            this.lblPompier.Size = new System.Drawing.Size(302, 29);
            this.lblPompier.TabIndex = 3;
            this.lblPompier.Text = "Sélectionner un pompier :";
            // 
            // cboCaserne
            // 
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(72, 259);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(223, 34);
            this.cboCaserne.TabIndex = 2;
            this.cboCaserne.SelectionChangeCommitted += new System.EventHandler(this.cboCaserne_SelectionChangeCommitted);
            // 
            // pbGIF
            // 
            this.pbGIF.Image = ((System.Drawing.Image)(resources.GetObject("pbGIF.Image")));
            this.pbGIF.Location = new System.Drawing.Point(109, 33);
            this.pbGIF.Name = "pbGIF";
            this.pbGIF.Size = new System.Drawing.Size(168, 153);
            this.pbGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGIF.TabIndex = 0;
            this.pbGIF.TabStop = false;
            // 
            // grbProfil
            // 
            this.grbProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.grbProfil.Controls.Add(this.lblExit);
            this.grbProfil.Controls.Add(this.pbretour);
            this.grbProfil.Controls.Add(this.lblnewpomp);
            this.grbProfil.Controls.Add(this.pbajout);
            this.grbProfil.Controls.Add(this.cboPompier);
            this.grbProfil.Controls.Add(this.lblPompier);
            this.grbProfil.Controls.Add(this.cboCaserne);
            this.grbProfil.Controls.Add(this.lblCaserne);
            this.grbProfil.Controls.Add(this.pbGIF);
            this.grbProfil.ForeColor = System.Drawing.Color.White;
            this.grbProfil.Location = new System.Drawing.Point(12, 11);
            this.grbProfil.Name = "grbProfil";
            this.grbProfil.Size = new System.Drawing.Size(390, 1069);
            this.grbProfil.TabIndex = 8;
            this.grbProfil.TabStop = false;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCaserne.Location = new System.Drawing.Point(28, 211);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(319, 29);
            this.lblCaserne.TabIndex = 1;
            this.lblCaserne.Text = "Sélectionnez une caserne :";
            // 
            // pbGrade
            // 
            this.pbGrade.Location = new System.Drawing.Point(1006, 46);
            this.pbGrade.Name = "pbGrade";
            this.pbGrade.Size = new System.Drawing.Size(278, 221);
            this.pbGrade.TabIndex = 9;
            this.pbGrade.TabStop = false;
            // 
            // lblbip
            // 
            this.lblbip.AutoSize = true;
            this.lblbip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbip.ForeColor = System.Drawing.SystemColors.Control;
            this.lblbip.Location = new System.Drawing.Point(598, 264);
            this.lblbip.Name = "lblbip";
            this.lblbip.Size = new System.Drawing.Size(64, 29);
            this.lblbip.TabIndex = 5;
            this.lblbip.Text = "Bip :";
            // 
            // grbPompier
            // 
            this.grbPompier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.grbPompier.Controls.Add(this.pbGrade);
            this.grbPompier.Controls.Add(this.lblbip);
            this.grbPompier.Controls.Add(this.lblTelep);
            this.grbPompier.Controls.Add(this.lblemboche);
            this.grbPompier.Controls.Add(this.rdbPro);
            this.grbPompier.Controls.Add(this.rdbVolontaire);
            this.grbPompier.Controls.Add(this.lblsexe);
            this.grbPompier.Controls.Add(this.lblPrn);
            this.grbPompier.Controls.Add(this.lblNom);
            this.grbPompier.Controls.Add(this.lblMatricule);
            this.grbPompier.Location = new System.Drawing.Point(431, 11);
            this.grbPompier.Name = "grbPompier";
            this.grbPompier.Size = new System.Drawing.Size(1482, 343);
            this.grbPompier.TabIndex = 9;
            this.grbPompier.TabStop = false;
            this.grbPompier.Visible = false;
            // 
            // lblTelep
            // 
            this.lblTelep.AutoSize = true;
            this.lblTelep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelep.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelep.Location = new System.Drawing.Point(598, 202);
            this.lblTelep.Name = "lblTelep";
            this.lblTelep.Size = new System.Drawing.Size(146, 29);
            this.lblTelep.TabIndex = 1;
            this.lblTelep.Text = "Téléphone :";
            // 
            // lblemboche
            // 
            this.lblemboche.AutoSize = true;
            this.lblemboche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemboche.ForeColor = System.Drawing.SystemColors.Control;
            this.lblemboche.Location = new System.Drawing.Point(25, 278);
            this.lblemboche.Name = "lblemboche";
            this.lblemboche.Size = new System.Drawing.Size(225, 29);
            this.lblemboche.TabIndex = 7;
            this.lblemboche.Text = "Date d\'embauche :";
            // 
            // rdbPro
            // 
            this.rdbPro.AutoSize = true;
            this.rdbPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPro.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbPro.Location = new System.Drawing.Point(603, 129);
            this.rdbPro.Name = "rdbPro";
            this.rdbPro.Size = new System.Drawing.Size(188, 33);
            this.rdbPro.TabIndex = 6;
            this.rdbPro.TabStop = true;
            this.rdbPro.Text = "Professionnel";
            this.rdbPro.UseVisualStyleBackColor = true;
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVolontaire.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbVolontaire.Location = new System.Drawing.Point(603, 62);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(148, 33);
            this.rdbVolontaire.TabIndex = 5;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // lblsexe
            // 
            this.lblsexe.AutoSize = true;
            this.lblsexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexe.ForeColor = System.Drawing.SystemColors.Control;
            this.lblsexe.Location = new System.Drawing.Point(25, 202);
            this.lblsexe.Name = "lblsexe";
            this.lblsexe.Size = new System.Drawing.Size(84, 29);
            this.lblsexe.TabIndex = 4;
            this.lblsexe.Text = "Sexe :";
            // 
            // lblPrn
            // 
            this.lblPrn.AutoSize = true;
            this.lblPrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrn.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrn.Location = new System.Drawing.Point(25, 133);
            this.lblPrn.Name = "lblPrn";
            this.lblPrn.Size = new System.Drawing.Size(116, 29);
            this.lblPrn.TabIndex = 3;
            this.lblPrn.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNom.Location = new System.Drawing.Point(25, 62);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(81, 29);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMatricule.Location = new System.Drawing.Point(236, 18);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(130, 29);
            this.lblMatricule.TabIndex = 0;
            this.lblMatricule.Text = "Matricule :";
            // 
            // btninfos
            // 
            this.btninfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninfos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btninfos.Location = new System.Drawing.Point(1595, 360);
            this.btninfos.Name = "btninfos";
            this.btninfos.Size = new System.Drawing.Size(300, 41);
            this.btninfos.TabIndex = 11;
            this.btninfos.Text = "Gestion des informations";
            this.btninfos.UseVisualStyleBackColor = true;
            this.btninfos.Visible = false;
            this.btninfos.Click += new System.EventHandler(this.btninfos_Click);
            // 
            // grbinfos
            // 
            this.grbinfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.grbinfos.Controls.Add(this.btnclose);
            this.grbinfos.Controls.Add(this.cbograde);
            this.grbinfos.Controls.Add(this.btnjour);
            this.grbinfos.Controls.Add(this.cbconger);
            this.grbinfos.Controls.Add(this.lstaff);
            this.grbinfos.Controls.Add(this.lblhabilp);
            this.grbinfos.Controls.Add(this.lsthabil);
            this.grbinfos.Controls.Add(this.lblhabil);
            this.grbinfos.Controls.Add(this.lblGrade);
            this.grbinfos.Controls.Add(this.cbocas);
            this.grbinfos.Controls.Add(this.lblcas);
            this.grbinfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbinfos.ForeColor = System.Drawing.SystemColors.Control;
            this.grbinfos.Location = new System.Drawing.Point(431, 407);
            this.grbinfos.Name = "grbinfos";
            this.grbinfos.Size = new System.Drawing.Size(1482, 673);
            this.grbinfos.TabIndex = 10;
            this.grbinfos.TabStop = false;
            this.grbinfos.Text = "Gérer les informations";
            this.grbinfos.Visible = false;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btnclose.Location = new System.Drawing.Point(1279, 570);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(160, 35);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "Fermer";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // cbograde
            // 
            this.cbograde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbograde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbograde.FormattingEnabled = true;
            this.cbograde.Location = new System.Drawing.Point(1190, 63);
            this.cbograde.Name = "cbograde";
            this.cbograde.Size = new System.Drawing.Size(190, 34);
            this.cbograde.TabIndex = 9;
            // 
            // btnjour
            // 
            this.btnjour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btnjour.Location = new System.Drawing.Point(1275, 495);
            this.btnjour.Name = "btnjour";
            this.btnjour.Size = new System.Drawing.Size(164, 42);
            this.btnjour.TabIndex = 8;
            this.btnjour.Text = "Mettre à jour";
            this.btnjour.UseVisualStyleBackColor = true;
            this.btnjour.Click += new System.EventHandler(this.btnjour_Click);
            // 
            // cbconger
            // 
            this.cbconger.AutoSize = true;
            this.cbconger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbconger.Location = new System.Drawing.Point(1142, 403);
            this.cbconger.Name = "cbconger";
            this.cbconger.Size = new System.Drawing.Size(142, 33);
            this.cbconger.TabIndex = 7;
            this.cbconger.Text = "En congé";
            this.cbconger.UseVisualStyleBackColor = true;
            // 
            // lstaff
            // 
            this.lstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstaff.FormattingEnabled = true;
            this.lstaff.ItemHeight = 26;
            this.lstaff.Location = new System.Drawing.Point(78, 354);
            this.lstaff.Name = "lstaff";
            this.lstaff.Size = new System.Drawing.Size(1016, 290);
            this.lstaff.TabIndex = 6;
            // 
            // lblhabilp
            // 
            this.lblhabilp.AutoSize = true;
            this.lblhabilp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhabilp.Location = new System.Drawing.Point(68, 314);
            this.lblhabilp.Name = "lblhabilp";
            this.lblhabilp.Size = new System.Drawing.Size(262, 29);
            this.lblhabilp.TabIndex = 5;
            this.lblhabilp.Text = "Affectations passées :";
            // 
            // lsthabil
            // 
            this.lsthabil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsthabil.FormattingEnabled = true;
            this.lsthabil.ItemHeight = 26;
            this.lsthabil.Location = new System.Drawing.Point(72, 166);
            this.lsthabil.Name = "lsthabil";
            this.lsthabil.Size = new System.Drawing.Size(1271, 134);
            this.lsthabil.TabIndex = 4;
            // 
            // lblhabil
            // 
            this.lblhabil.AutoSize = true;
            this.lblhabil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhabil.Location = new System.Drawing.Point(68, 129);
            this.lblhabil.Name = "lblhabil";
            this.lblhabil.Size = new System.Drawing.Size(166, 29);
            this.lblhabil.TabIndex = 3;
            this.lblhabil.Text = "Habilitations :";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(1037, 63);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(96, 29);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "Grade :";
            // 
            // cbocas
            // 
            this.cbocas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocas.FormattingEnabled = true;
            this.cbocas.Location = new System.Drawing.Point(440, 63);
            this.cbocas.Name = "cbocas";
            this.cbocas.Size = new System.Drawing.Size(222, 34);
            this.cbocas.TabIndex = 2;
            // 
            // lblcas
            // 
            this.lblcas.AutoSize = true;
            this.lblcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcas.Location = new System.Drawing.Point(68, 63);
            this.lblcas.Name = "lblcas";
            this.lblcas.Size = new System.Drawing.Size(312, 29);
            this.lblcas.TabIndex = 1;
            this.lblcas.Text = "Caserne de rattachement :";
            // 
            // Volet4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1091);
            this.Controls.Add(this.grbProfil);
            this.Controls.Add(this.grbPompier);
            this.Controls.Add(this.btninfos);
            this.Controls.Add(this.grbinfos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Volet4";
            this.Text = "Volet4";
            this.Load += new System.EventHandler(this.Volet4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbretour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbajout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGIF)).EndInit();
            this.grbProfil.ResumeLayout(false);
            this.grbProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrade)).EndInit();
            this.grbPompier.ResumeLayout(false);
            this.grbPompier.PerformLayout();
            this.grbinfos.ResumeLayout(false);
            this.grbinfos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox pbretour;
        private System.Windows.Forms.Label lblnewpomp;
        private System.Windows.Forms.PictureBox pbajout;
        private System.Windows.Forms.ComboBox cboPompier;
        private System.Windows.Forms.Label lblPompier;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.PictureBox pbGIF;
        private System.Windows.Forms.GroupBox grbProfil;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.PictureBox pbGrade;
        private System.Windows.Forms.Label lblbip;
        private System.Windows.Forms.GroupBox grbPompier;
        private System.Windows.Forms.Label lblTelep;
        private System.Windows.Forms.Label lblemboche;
        private System.Windows.Forms.RadioButton rdbPro;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.Label lblsexe;
        private System.Windows.Forms.Label lblPrn;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMatricule;
        public System.Windows.Forms.Button btninfos;
        public System.Windows.Forms.GroupBox grbinfos;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ComboBox cbograde;
        private System.Windows.Forms.Button btnjour;
        private System.Windows.Forms.CheckBox cbconger;
        private System.Windows.Forms.ListBox lstaff;
        private System.Windows.Forms.Label lblhabilp;
        private System.Windows.Forms.ListBox lsthabil;
        private System.Windows.Forms.Label lblhabil;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox cbocas;
        private System.Windows.Forms.Label lblcas;
    }
}