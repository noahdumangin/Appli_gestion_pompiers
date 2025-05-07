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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pctFond = new System.Windows.Forms.PictureBox();
            this.pctLeave = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userControlPanel1 = new UserControlVolet1.UserControlPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pctFond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLeave)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctFond
            // 
            this.pctFond.Location = new System.Drawing.Point(-3, 2);
            this.pctFond.Name = "pctFond";
            this.pctFond.Size = new System.Drawing.Size(1195, 726);
            this.pctFond.TabIndex = 0;
            this.pctFond.TabStop = false;
            // 
            // pctLeave
            // 
            this.pctLeave.Location = new System.Drawing.Point(18, 527);
            this.pctLeave.Name = "pctLeave";
            this.pctLeave.Size = new System.Drawing.Size(113, 108);
            this.pctLeave.TabIndex = 0;
            this.pctLeave.TabStop = false;
            this.pctLeave.Click += new System.EventHandler(this.pctLeave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userControlPanel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pctLeave);
            this.groupBox1.Location = new System.Drawing.Point(55, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 653);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // userControlPanel1
            // 
            this.userControlPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControlPanel1.BackgroundImage")));
            this.userControlPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControlPanel1.Location = new System.Drawing.Point(18, 38);
            this.userControlPanel1.Name = "userControlPanel1";
            this.userControlPanel1.Size = new System.Drawing.Size(456, 125);
            this.userControlPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1195, 726);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pctFond);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLeave)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctFond;
        private System.Windows.Forms.PictureBox pctLeave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private UserControlVolet1.UserControlPanel userControlPanel1;
    }
}

