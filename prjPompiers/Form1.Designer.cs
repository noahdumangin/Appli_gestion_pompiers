namespace prjPompiers
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctFond = new System.Windows.Forms.PictureBox();
            this.pctLeave = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbList = new System.Windows.Forms.GroupBox();
            this.flpMission = new System.Windows.Forms.FlowLayoutPanel();
            this.chkEnCours = new System.Windows.Forms.CheckBox();
            this.gpMission = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctFond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLeave)).BeginInit();
            this.grbList.SuspendLayout();
            this.gpMission.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctFond
            // 
            this.pctFond.Location = new System.Drawing.Point(-5, -3);
            this.pctFond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctFond.Name = "pctFond";
            this.pctFond.Size = new System.Drawing.Size(2149, 1101);
            this.pctFond.TabIndex = 0;
            this.pctFond.TabStop = false;
            // 
            // pctLeave
            // 
            this.pctLeave.Location = new System.Drawing.Point(21, 925);
            this.pctLeave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctLeave.Name = "pctLeave";
            this.pctLeave.Size = new System.Drawing.Size(100, 86);
            this.pctLeave.TabIndex = 0;
            this.pctLeave.TabStop = false;
            this.pctLeave.Click += new System.EventHandler(this.pctLeave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(148, 963);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quitter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.label1);
            this.grbList.Controls.Add(this.pctLeave);
            this.grbList.Location = new System.Drawing.Point(25, 22);
            this.grbList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbList.Name = "grbList";
            this.grbList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbList.Size = new System.Drawing.Size(436, 1036);
            this.grbList.TabIndex = 1;
            this.grbList.TabStop = false;
            // 
            // flpMission
            // 
            this.flpMission.AutoScroll = true;
            this.flpMission.Location = new System.Drawing.Point(563, 81);
            this.flpMission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpMission.Name = "flpMission";
            this.flpMission.Size = new System.Drawing.Size(1138, 977);
            this.flpMission.TabIndex = 2;
            // 
            // chkEnCours
            // 
            this.chkEnCours.AutoSize = true;
            this.chkEnCours.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnCours.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkEnCours.Location = new System.Drawing.Point(76, 28);
            this.chkEnCours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkEnCours.Name = "chkEnCours";
            this.chkEnCours.Size = new System.Drawing.Size(167, 28);
            this.chkEnCours.TabIndex = 0;
            this.chkEnCours.Text = "Missions en cours ";
            this.chkEnCours.UseVisualStyleBackColor = true;
            this.chkEnCours.CheckedChanged += new System.EventHandler(this.chkEnCours_CheckedChanged_1);
            // 
            // gpMission
            // 
            this.gpMission.Controls.Add(this.label2);
            this.gpMission.Controls.Add(this.chkEnCours);
            this.gpMission.Location = new System.Drawing.Point(563, 22);
            this.gpMission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpMission.Name = "gpMission";
            this.gpMission.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpMission.Size = new System.Drawing.Size(1138, 78);
            this.gpMission.TabIndex = 3;
            this.gpMission.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(284, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tableau de bord des Missions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1924, 1109);
            this.Controls.Add(this.gpMission);
            this.Controls.Add(this.flpMission);
            this.Controls.Add(this.grbList);
            this.Controls.Add(this.pctFond);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Tableau de bord";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLeave)).EndInit();
            this.grbList.ResumeLayout(false);
            this.grbList.PerformLayout();
            this.gpMission.ResumeLayout(false);
            this.gpMission.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctFond;
        private System.Windows.Forms.PictureBox pctLeave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.FlowLayoutPanel flpMission;
        private System.Windows.Forms.CheckBox chkEnCours;
        private System.Windows.Forms.GroupBox gpMission;
        private System.Windows.Forms.Label label2;
    }
}

