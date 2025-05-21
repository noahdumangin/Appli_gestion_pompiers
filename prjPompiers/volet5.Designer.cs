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
            this.grpTitre = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpStat1caserne = new System.Windows.Forms.GroupBox();
            this.lbl1caserne = new System.Windows.Forms.Label();
            this.cbo1caserne = new System.Windows.Forms.ComboBox();
            this.dgv1caserne = new System.Windows.Forms.DataGridView();
            this.grpTitre.SuspendLayout();
            this.grpStat1caserne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1caserne)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTitre
            // 
            this.grpTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.grpTitre.Controls.Add(this.label2);
            this.grpTitre.ForeColor = System.Drawing.Color.White;
            this.grpTitre.Location = new System.Drawing.Point(29, 16);
            this.grpTitre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpTitre.Name = "grpTitre";
            this.grpTitre.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpTitre.Size = new System.Drawing.Size(1005, 66);
            this.grpTitre.TabIndex = 0;
            this.grpTitre.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(357, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "STATISTIQUES";
            // 
            // grpStat1caserne
            // 
            this.grpStat1caserne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.grpStat1caserne.Controls.Add(this.dgv1caserne);
            this.grpStat1caserne.Controls.Add(this.cbo1caserne);
            this.grpStat1caserne.Controls.Add(this.lbl1caserne);
            this.grpStat1caserne.ForeColor = System.Drawing.Color.White;
            this.grpStat1caserne.Location = new System.Drawing.Point(29, 112);
            this.grpStat1caserne.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpStat1caserne.Name = "grpStat1caserne";
            this.grpStat1caserne.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpStat1caserne.Size = new System.Drawing.Size(1005, 230);
            this.grpStat1caserne.TabIndex = 1;
            this.grpStat1caserne.TabStop = false;
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
            // cbo1caserne
            // 
            this.cbo1caserne.FormattingEnabled = true;
            this.cbo1caserne.Location = new System.Drawing.Point(196, 32);
            this.cbo1caserne.Name = "cbo1caserne";
            this.cbo1caserne.Size = new System.Drawing.Size(180, 21);
            this.cbo1caserne.TabIndex = 2;
            // 
            // dgv1caserne
            // 
            this.dgv1caserne.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.dgv1caserne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1caserne.Location = new System.Drawing.Point(27, 68);
            this.dgv1caserne.Name = "dgv1caserne";
            this.dgv1caserne.Size = new System.Drawing.Size(944, 134);
            this.dgv1caserne.TabIndex = 3;
            // 
            // volet5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 607);
            this.Controls.Add(this.grpStat1caserne);
            this.Controls.Add(this.grpTitre);
            this.Name = "volet5";
            this.Text = "volet 5";
            this.Load += new System.EventHandler(this.volet5_Load);
            this.grpTitre.ResumeLayout(false);
            this.grpTitre.PerformLayout();
            this.grpStat1caserne.ResumeLayout(false);
            this.grpStat1caserne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1caserne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTitre;
        private System.Windows.Forms.GroupBox grpStat1caserne;
        private System.Windows.Forms.Label lbl1caserne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo1caserne;
        private System.Windows.Forms.DataGridView dgv1caserne;
    }
}