namespace prjPompiers
{
    partial class Volets3
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
            this.pctboxVROUMVROUM = new System.Windows.Forms.PictureBox();
            this.btnAllRight = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.gdvVROUMVROUM = new System.Windows.Forms.DataGridView();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnALLLeft = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.chkboxMission = new System.Windows.Forms.CheckBox();
            this.chkboxPanne = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxVROUMVROUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvVROUMVROUM)).BeginInit();
            this.SuspendLayout();
            // 
            // pctboxVROUMVROUM
            // 
            this.pctboxVROUMVROUM.Location = new System.Drawing.Point(51, 40);
            this.pctboxVROUMVROUM.Name = "pctboxVROUMVROUM";
            this.pctboxVROUMVROUM.Size = new System.Drawing.Size(663, 539);
            this.pctboxVROUMVROUM.TabIndex = 0;
            this.pctboxVROUMVROUM.TabStop = false;
            //this.pctboxVROUMVROUM.Click += new System.EventHandler(this.pctboxVROUMVROUM_Click);
            // 
            // btnAllRight
            // 
            this.btnAllRight.Location = new System.Drawing.Point(503, 614);
            this.btnAllRight.Name = "btnAllRight";
            this.btnAllRight.Size = new System.Drawing.Size(110, 98);
            this.btnAllRight.TabIndex = 1;
            this.btnAllRight.Text = ">>";
            this.btnAllRight.UseVisualStyleBackColor = true;
            this.btnAllRight.Click += new System.EventHandler(this.btnAllRight_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(369, 613);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(106, 99);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // gdvVROUMVROUM
            // 
            this.gdvVROUMVROUM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvVROUMVROUM.Location = new System.Drawing.Point(720, 140);
            this.gdvVROUMVROUM.Name = "gdvVROUMVROUM";
            this.gdvVROUMVROUM.RowHeadersWidth = 62;
            this.gdvVROUMVROUM.RowTemplate.Height = 28;
            this.gdvVROUMVROUM.Size = new System.Drawing.Size(430, 236);
            this.gdvVROUMVROUM.TabIndex = 3;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(216, 614);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(110, 98);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnALLLeft
            // 
            this.btnALLLeft.Location = new System.Drawing.Point(77, 614);
            this.btnALLLeft.Name = "btnALLLeft";
            this.btnALLLeft.Size = new System.Drawing.Size(110, 98);
            this.btnALLLeft.TabIndex = 5;
            this.btnALLLeft.Text = "<<";
            this.btnALLLeft.UseVisualStyleBackColor = true;
            this.btnALLLeft.Click += new System.EventHandler(this.btnALLLeft_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(746, 420);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(51, 20);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(746, 467);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 20);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "label1";
            // 
            // chkboxMission
            // 
            this.chkboxMission.AutoSize = true;
            this.chkboxMission.Location = new System.Drawing.Point(750, 521);
            this.chkboxMission.Name = "chkboxMission";
            this.chkboxMission.Size = new System.Drawing.Size(116, 24);
            this.chkboxMission.TabIndex = 8;
            this.chkboxMission.Text = "En Mission ";
            this.chkboxMission.UseVisualStyleBackColor = true;
            // 
            // chkboxPanne
            // 
            this.chkboxPanne.AutoSize = true;
            this.chkboxPanne.Location = new System.Drawing.Point(750, 578);
            this.chkboxPanne.Name = "chkboxPanne";
            this.chkboxPanne.Size = new System.Drawing.Size(105, 24);
            this.chkboxPanne.TabIndex = 9;
            this.chkboxPanne.Text = "En Panne";
            this.chkboxPanne.UseVisualStyleBackColor = true;
            // 
            // Volets3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 746);
            this.Controls.Add(this.chkboxPanne);
            this.Controls.Add(this.chkboxMission);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnALLLeft);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.gdvVROUMVROUM);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnAllRight);
            this.Controls.Add(this.pctboxVROUMVROUM);
            this.Name = "Volets3";
            this.Text = "Volets3";
            this.Load += new System.EventHandler(this.Volets3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctboxVROUMVROUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvVROUMVROUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctboxVROUMVROUM;
        private System.Windows.Forms.Button btnAllRight;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.DataGridView gdvVROUMVROUM;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnALLLeft;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.CheckBox chkboxMission;
        private System.Windows.Forms.CheckBox chkboxPanne;
    }
}