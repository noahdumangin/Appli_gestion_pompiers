namespace prjPompiers
{
    partial class volet5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(volet5));
            this.grpTitre = new System.Windows.Forms.GroupBox();
            this.pbgif = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpStat1caserne = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEngin = new System.Windows.Forms.Label();
            this.lblPlusutilise = new System.Windows.Forms.Label();
            this.dgv1caserne = new System.Windows.Forms.DataGridView();
            this.cbo1caserne = new System.Windows.Forms.ComboBox();
            this.lbl1caserne = new System.Windows.Forms.Label();
            this.grpEnsembleCaserne = new System.Windows.Forms.GroupBox();
            this.dgvAllCaserne = new System.Windows.Forms.DataGridView();
            this.grpTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbgif)).BeginInit();
            this.grpStat1caserne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1caserne)).BeginInit();
            this.grpEnsembleCaserne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCaserne)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTitre
            // 
            this.grpTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.grpTitre.Controls.Add(this.pbgif);
            this.grpTitre.Controls.Add(this.label2);
            this.grpTitre.ForeColor = System.Drawing.Color.White;
            this.grpTitre.Location = new System.Drawing.Point(29, 16);
            this.grpTitre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpTitre.Name = "grpTitre";
            this.grpTitre.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpTitre.Size = new System.Drawing.Size(1222, 118);
            this.grpTitre.TabIndex = 0;
            this.grpTitre.TabStop = false;
            // 
            // pbgif
            // 
            this.pbgif.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbgif.ErrorImage")));
            this.pbgif.ImageLocation = "";
            this.pbgif.Location = new System.Drawing.Point(325, 18);
            this.pbgif.Name = "pbgif";
            this.pbgif.Size = new System.Drawing.Size(103, 85);
            this.pbgif.TabIndex = 2;
            this.pbgif.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(521, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "STATISTIQUES";
            // 
            // grpStat1caserne
            // 
            this.grpStat1caserne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.grpStat1caserne.Controls.Add(this.lblNombre);
            this.grpStat1caserne.Controls.Add(this.lblEngin);
            this.grpStat1caserne.Controls.Add(this.lblPlusutilise);
            this.grpStat1caserne.Controls.Add(this.dgv1caserne);
            this.grpStat1caserne.Controls.Add(this.cbo1caserne);
            this.grpStat1caserne.Controls.Add(this.lbl1caserne);
            this.grpStat1caserne.ForeColor = System.Drawing.Color.White;
            this.grpStat1caserne.Location = new System.Drawing.Point(29, 171);
            this.grpStat1caserne.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpStat1caserne.Name = "grpStat1caserne";
            this.grpStat1caserne.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpStat1caserne.Size = new System.Drawing.Size(1222, 230);
            this.grpStat1caserne.TabIndex = 1;
            this.grpStat1caserne.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblNombre.Location = new System.Drawing.Point(752, 119);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 17);
            this.lblNombre.TabIndex = 6;
            // 
            // lblEngin
            // 
            this.lblEngin.AutoSize = true;
            this.lblEngin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblEngin.Location = new System.Drawing.Point(893, 68);
            this.lblEngin.Name = "lblEngin";
            this.lblEngin.Size = new System.Drawing.Size(0, 17);
            this.lblEngin.TabIndex = 5;
            // 
            // lblPlusutilise
            // 
            this.lblPlusutilise.AutoSize = true;
            this.lblPlusutilise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblPlusutilise.Location = new System.Drawing.Point(752, 68);
            this.lblPlusutilise.Name = "lblPlusutilise";
            this.lblPlusutilise.Size = new System.Drawing.Size(141, 17);
            this.lblPlusutilise.TabIndex = 4;
            this.lblPlusutilise.Text = "Engin le plus utilisé : ";
            // 
            // dgv1caserne
            // 
            this.dgv1caserne.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.dgv1caserne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1caserne.Location = new System.Drawing.Point(33, 68);
            this.dgv1caserne.Name = "dgv1caserne";
            this.dgv1caserne.Size = new System.Drawing.Size(649, 134);
            this.dgv1caserne.TabIndex = 3;
            // 
            // cbo1caserne
            // 
            this.cbo1caserne.FormattingEnabled = true;
            this.cbo1caserne.Location = new System.Drawing.Point(196, 32);
            this.cbo1caserne.Name = "cbo1caserne";
            this.cbo1caserne.Size = new System.Drawing.Size(180, 21);
            this.cbo1caserne.TabIndex = 2;
            this.cbo1caserne.SelectionChangeCommitted += new System.EventHandler(this.cbo1caserne_SelectionChangeCommitted);
            // 
            // lbl1caserne
            // 
            this.lbl1caserne.AutoSize = true;
            this.lbl1caserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl1caserne.Location = new System.Drawing.Point(24, 32);
            this.lbl1caserne.Name = "lbl1caserne";
            this.lbl1caserne.Size = new System.Drawing.Size(166, 17);
            this.lbl1caserne.TabIndex = 0;
            this.lbl1caserne.Text = "Choisissez une caserne :";
            // 
            // grpEnsembleCaserne
            // 
            this.grpEnsembleCaserne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.grpEnsembleCaserne.Controls.Add(this.dgvAllCaserne);
            this.grpEnsembleCaserne.ForeColor = System.Drawing.Color.White;
            this.grpEnsembleCaserne.Location = new System.Drawing.Point(29, 417);
            this.grpEnsembleCaserne.Name = "grpEnsembleCaserne";
            this.grpEnsembleCaserne.Size = new System.Drawing.Size(1221, 279);
            this.grpEnsembleCaserne.TabIndex = 2;
            this.grpEnsembleCaserne.TabStop = false;
            // 
            // dgvAllCaserne
            // 
            this.dgvAllCaserne.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.dgvAllCaserne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllCaserne.Location = new System.Drawing.Point(27, 33);
            this.dgvAllCaserne.Name = "dgvAllCaserne";
            this.dgvAllCaserne.Size = new System.Drawing.Size(1172, 129);
            this.dgvAllCaserne.TabIndex = 0;
            // 
            // volet5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 708);
            this.Controls.Add(this.grpEnsembleCaserne);
            this.Controls.Add(this.grpStat1caserne);
            this.Controls.Add(this.grpTitre);
            this.Name = "volet5";
            this.Text = "volet 5";
            this.Load += new System.EventHandler(this.volet5_Load);
            this.grpTitre.ResumeLayout(false);
            this.grpTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbgif)).EndInit();
            this.grpStat1caserne.ResumeLayout(false);
            this.grpStat1caserne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1caserne)).EndInit();
            this.grpEnsembleCaserne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCaserne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTitre;
        private System.Windows.Forms.GroupBox grpStat1caserne;
        private System.Windows.Forms.Label lbl1caserne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo1caserne;
        private System.Windows.Forms.DataGridView dgv1caserne;
        private System.Windows.Forms.Label lblPlusutilise;
        private System.Windows.Forms.PictureBox pbgif;
        private System.Windows.Forms.Label lblEngin;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpEnsembleCaserne;
        private System.Windows.Forms.DataGridView dgvAllCaserne;
    }
}