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
            this.pctPDF = new System.Windows.Forms.PictureBox();
            this.pctType = new System.Windows.Forms.PictureBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pctRes = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pctRes);
            this.groupBox1.Controls.Add(this.lblResum);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.pctPDF);
            this.groupBox1.Controls.Add(this.pctType);
            this.groupBox1.Controls.Add(this.lblCaserne);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Location = new System.Drawing.Point(9, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1224, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblResum
            // 
            this.lblResum.AutoSize = true;
            this.lblResum.Location = new System.Drawing.Point(285, 171);
            this.lblResum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResum.Name = "lblResum";
            this.lblResum.Size = new System.Drawing.Size(32, 20);
            this.lblResum.TabIndex = 6;
            this.lblResum.Text = "--> ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(285, 103);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(134, 20);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type de Mission : ";
            // 
            // pctPDF
            // 
            this.pctPDF.Location = new System.Drawing.Point(1060, 16);
            this.pctPDF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctPDF.Name = "pctPDF";
            this.pctPDF.Size = new System.Drawing.Size(122, 114);
            this.pctPDF.TabIndex = 4;
            this.pctPDF.TabStop = false;
            // 
            // pctType
            // 
            this.pctType.Location = new System.Drawing.Point(56, 74);
            this.pctType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctType.Name = "pctType";
            this.pctType.Size = new System.Drawing.Size(147, 137);
            this.pctType.TabIndex = 3;
            this.pctType.TabStop = false;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(564, 29);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(81, 20);
            this.lblCaserne.TabIndex = 2;
            this.lblCaserne.Text = "Caserne : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(285, 31);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(123, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date de début : ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(51, 31);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(92, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Id Mission : ";
            // 
            // pctRes
            // 
            this.pctRes.Location = new System.Drawing.Point(1060, 130);
            this.pctRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctRes.Name = "pctRes";
            this.pctRes.Size = new System.Drawing.Size(122, 114);
            this.pctRes.TabIndex = 7;
            this.pctRes.TabStop = false;
            // 
            // UserControlMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlMission";
            this.Size = new System.Drawing.Size(1242, 295);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox pctPDF;
        private System.Windows.Forms.PictureBox pctType;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblResum;
        private System.Windows.Forms.PictureBox pctRes;
    }
}
