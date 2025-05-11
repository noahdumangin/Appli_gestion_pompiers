namespace UserControlVolet1
{
    partial class UCMission
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMission = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pctPDF = new System.Windows.Forms.PictureBox();
            this.pctInfo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pctInfo);
            this.groupBox1.Controls.Add(this.lblMission);
            this.groupBox1.Controls.Add(this.pctPDF);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.lblCaserne);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.pctLogo);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMission.Location = new System.Drawing.Point(483, 92);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(386, 25);
            this.lblMission.TabIndex = 5;
            this.lblMission.Text = "--> Accident de la route Voiture contre Vélo";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(157, 92);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(64, 25);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "label4";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.Location = new System.Drawing.Point(523, 15);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(98, 25);
            this.lblCaserne.TabIndex = 3;
            this.lblCaserne.Text = "Caserne :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(304, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Début le : ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(158, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(116, 25);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id Mission : ";
            // 
            // pctLogo
            // 
            this.pctLogo.Location = new System.Drawing.Point(27, 41);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(112, 113);
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // pctPDF
            // 
            this.pctPDF.Location = new System.Drawing.Point(875, 15);
            this.pctPDF.Name = "pctPDF";
            this.pctPDF.Size = new System.Drawing.Size(71, 74);
            this.pctPDF.TabIndex = 1;
            this.pctPDF.TabStop = false;
            // 
            // pctInfo
            // 
            this.pctInfo.Location = new System.Drawing.Point(875, 116);
            this.pctInfo.Name = "pctInfo";
            this.pctInfo.Size = new System.Drawing.Size(71, 71);
            this.pctInfo.TabIndex = 2;
            this.pctInfo.TabStop = false;
            // 
            // UCMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCMission";
            this.Size = new System.Drawing.Size(968, 197);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.PictureBox pctPDF;
        private System.Windows.Forms.PictureBox pctInfo;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Label lblType;
    }
}
