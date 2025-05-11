namespace UserControlMissions
{
    partial class UserControlMission
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
            this.lblResum = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.pctRes = new System.Windows.Forms.PictureBox();
            this.pctPDF = new System.Windows.Forms.PictureBox();
            this.pctType = new System.Windows.Forms.PictureBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctType)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResum);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.pctRes);
            this.groupBox1.Controls.Add(this.pctPDF);
            this.groupBox1.Controls.Add(this.pctType);
            this.groupBox1.Controls.Add(this.lblCaserne);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblResum
            // 
            this.lblResum.AutoSize = true;
            this.lblResum.Location = new System.Drawing.Point(190, 111);
            this.lblResum.Name = "lblResum";
            this.lblResum.Size = new System.Drawing.Size(22, 13);
            this.lblResum.TabIndex = 6;
            this.lblResum.Text = "--> ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(190, 67);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(93, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type de Mission : ";
            // 
            // pctRes
            // 
            this.pctRes.Location = new System.Drawing.Point(738, 86);
            this.pctRes.Name = "pctRes";
            this.pctRes.Size = new System.Drawing.Size(63, 65);
            this.pctRes.TabIndex = 0;
            this.pctRes.TabStop = false;
            // 
            // pctPDF
            // 
            this.pctPDF.Location = new System.Drawing.Point(738, 20);
            this.pctPDF.Name = "pctPDF";
            this.pctPDF.Size = new System.Drawing.Size(63, 60);
            this.pctPDF.TabIndex = 4;
            this.pctPDF.TabStop = false;
            // 
            // pctType
            // 
            this.pctType.Location = new System.Drawing.Point(37, 48);
            this.pctType.Name = "pctType";
            this.pctType.Size = new System.Drawing.Size(98, 89);
            this.pctType.TabIndex = 3;
            this.pctType.TabStop = false;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(376, 19);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(55, 13);
            this.lblCaserne.TabIndex = 2;
            this.lblCaserne.Text = "Caserne : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(190, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(84, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date de début : ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(34, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(63, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Id Mission : ";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(828, 192);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox pctRes;
        private System.Windows.Forms.PictureBox pctPDF;
        private System.Windows.Forms.PictureBox pctType;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblResum;
    }
}
