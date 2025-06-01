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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctFond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLeave)).BeginInit();
            this.grbList.SuspendLayout();
            this.gpMission.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctFond
            // 
<<<<<<< HEAD
            this.pctFond.Location = new System.Drawing.Point(-5, -2);
            this.pctFond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctFond.Name = "pctFond";
            this.pctFond.Size = new System.Drawing.Size(1303, 808);
=======
            this.pctFond.Location = new System.Drawing.Point(-6, -4);
            this.pctFond.Name = "pctFond";
            this.pctFond.Size = new System.Drawing.Size(1952, 1244);
>>>>>>> lucas
            this.pctFond.TabIndex = 0;
            this.pctFond.TabStop = false;
            // 
            // pctLeave
            // 
            this.pctLeave.Location = new System.Drawing.Point(18, 630);
            this.pctLeave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctLeave.Name = "pctLeave";
            this.pctLeave.Size = new System.Drawing.Size(75, 70);
            this.pctLeave.TabIndex = 0;
            this.pctLeave.TabStop = false;
            this.pctLeave.Click += new System.EventHandler(this.pctLeave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(113, 662);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quitter";
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.label1);
            this.grbList.Controls.Add(this.pctLeave);
<<<<<<< HEAD
            this.grbList.Location = new System.Drawing.Point(47, 24);
            this.grbList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbList.Name = "grbList";
            this.grbList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbList.Size = new System.Drawing.Size(287, 712);
=======
            this.grbList.Location = new System.Drawing.Point(28, 27);
            this.grbList.Name = "grbList";
            this.grbList.Size = new System.Drawing.Size(490, 1088);
>>>>>>> lucas
            this.grbList.TabIndex = 1;
            this.grbList.TabStop = false;
            // 
            // flpMission
            // 
<<<<<<< HEAD
            this.panMission.AutoScroll = true;
            this.panMission.Controls.Add(this.checkBox1);
            this.panMission.Controls.Add(this.label2);
            this.panMission.Location = new System.Drawing.Point(396, 28);
            this.panMission.Name = "panMission";
            this.panMission.Size = new System.Drawing.Size(841, 708);
            this.panMission.TabIndex = 2;
=======
            this.flpMission.AutoScroll = true;
            this.flpMission.Location = new System.Drawing.Point(633, 101);
            this.flpMission.Name = "flpMission";
            this.flpMission.Size = new System.Drawing.Size(1279, 1014);
            this.flpMission.TabIndex = 2;
>>>>>>> lucas
            // 
            // chkEnCours
            // 
<<<<<<< HEAD
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox1.Location = new System.Drawing.Point(26, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 22);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "En cours ";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
=======
            this.chkEnCours.AutoSize = true;
            this.chkEnCours.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnCours.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkEnCours.Location = new System.Drawing.Point(86, 35);
            this.chkEnCours.Name = "chkEnCours";
            this.chkEnCours.Size = new System.Drawing.Size(202, 33);
            this.chkEnCours.TabIndex = 0;
            this.chkEnCours.Text = "Missions en cours ";
            this.chkEnCours.UseVisualStyleBackColor = true;
            this.chkEnCours.CheckedChanged += new System.EventHandler(this.chkEnCours_CheckedChanged_1);
            // 
            // gpMission
            // 
            this.gpMission.Controls.Add(this.label2);
            this.gpMission.Controls.Add(this.chkEnCours);
            this.gpMission.Location = new System.Drawing.Point(633, 27);
            this.gpMission.Name = "gpMission";
            this.gpMission.Size = new System.Drawing.Size(1279, 97);
            this.gpMission.TabIndex = 3;
            this.gpMission.TabStop = false;
>>>>>>> lucas
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(210, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tableau de bord des Missions ";
=======
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(320, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(598, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tableau de bord des Missions";
>>>>>>> lucas
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1283, 760);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panMission);
=======
            this.ClientSize = new System.Drawing.Size(1924, 1130);
            this.Controls.Add(this.gpMission);
            this.Controls.Add(this.flpMission);
>>>>>>> lucas
            this.Controls.Add(this.grbList);
            this.Controls.Add(this.pctFond);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button button1;
    }
}

