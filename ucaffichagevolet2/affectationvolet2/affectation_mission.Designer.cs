namespace affectationvolet2
{
    partial class affichage_affectation
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
            this.grpPompier = new System.Windows.Forms.GroupBox();
            this.panelPompier = new System.Windows.Forms.Panel();
            this.grpEngin = new System.Windows.Forms.GroupBox();
            this.panelEngin = new System.Windows.Forms.Panel();
            this.lblPompiers = new System.Windows.Forms.Label();
            this.lblEngins = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.grpPompier.SuspendLayout();
            this.grpEngin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPompier
            // 
            this.grpPompier.Controls.Add(this.panelPompier);
            this.grpPompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.grpPompier.Location = new System.Drawing.Point(717, 60);
            this.grpPompier.Name = "grpPompier";
            this.grpPompier.Size = new System.Drawing.Size(685, 296);
            this.grpPompier.TabIndex = 9;
            this.grpPompier.TabStop = false;
            // 
            // panelPompier
            // 
            this.panelPompier.AutoScroll = true;
            this.panelPompier.ForeColor = System.Drawing.Color.White;
            this.panelPompier.Location = new System.Drawing.Point(6, 15);
            this.panelPompier.Name = "panelPompier";
            this.panelPompier.Size = new System.Drawing.Size(673, 275);
            this.panelPompier.TabIndex = 0;
            // 
            // grpEngin
            // 
            this.grpEngin.Controls.Add(this.panelEngin);
            this.grpEngin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.grpEngin.Location = new System.Drawing.Point(15, 60);
            this.grpEngin.Name = "grpEngin";
            this.grpEngin.Size = new System.Drawing.Size(685, 296);
            this.grpEngin.TabIndex = 8;
            this.grpEngin.TabStop = false;
            // 
            // panelEngin
            // 
            this.panelEngin.AutoScroll = true;
            this.panelEngin.ForeColor = System.Drawing.Color.White;
            this.panelEngin.Location = new System.Drawing.Point(6, 15);
            this.panelEngin.Name = "panelEngin";
            this.panelEngin.Size = new System.Drawing.Size(673, 275);
            this.panelEngin.TabIndex = 0;
            // 
            // lblPompiers
            // 
            this.lblPompiers.AutoSize = true;
            this.lblPompiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPompiers.ForeColor = System.Drawing.Color.White;
            this.lblPompiers.Location = new System.Drawing.Point(980, 32);
            this.lblPompiers.Name = "lblPompiers";
            this.lblPompiers.Size = new System.Drawing.Size(307, 29);
            this.lblPompiers.TabIndex = 5;
            this.lblPompiers.Text = "👨‍🚒 Pompiers sélectionné :";
            // 
            // lblEngins
            // 
            this.lblEngins.AutoSize = true;
            this.lblEngins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEngins.ForeColor = System.Drawing.Color.White;
            this.lblEngins.Location = new System.Drawing.Point(206, 32);
            this.lblEngins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEngins.Name = "lblEngins";
            this.lblEngins.Size = new System.Drawing.Size(290, 29);
            this.lblEngins.TabIndex = 7;
            this.lblEngins.Text = "🚒 Engins sélectionnés :";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblCaserne.ForeColor = System.Drawing.Color.White;
            this.lblCaserne.Location = new System.Drawing.Point(652, 9);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(159, 33);
            this.lblCaserne.TabIndex = 6;
            this.lblCaserne.Text = "Caserne : ";
            // 
            // affichage_affectation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.grpPompier);
            this.Controls.Add(this.grpEngin);
            this.Controls.Add(this.lblPompiers);
            this.Controls.Add(this.lblEngins);
            this.Controls.Add(this.lblCaserne);
            this.Name = "affichage_affectation";
            this.Size = new System.Drawing.Size(1417, 364);
            this.Load += new System.EventHandler(this.affectation_mission_Load);
            this.grpPompier.ResumeLayout(false);
            this.grpEngin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPompier;
        private System.Windows.Forms.Panel panelPompier;
        private System.Windows.Forms.GroupBox grpEngin;
        private System.Windows.Forms.Panel panelEngin;
        private System.Windows.Forms.Label lblPompiers;
        private System.Windows.Forms.Label lblEngins;
        private System.Windows.Forms.Label lblCaserne;
    }
}
