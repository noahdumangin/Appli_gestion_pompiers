namespace prjPompiers
{
    partial class loading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loading));
            this.pbload = new System.Windows.Forms.PictureBox();
            this.lbl_load = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbload)).BeginInit();
            this.SuspendLayout();
            // 
            // pbload
            // 
            this.pbload.Image = ((System.Drawing.Image)(resources.GetObject("pbload.Image")));
            this.pbload.Location = new System.Drawing.Point(12, 37);
            this.pbload.Name = "pbload";
            this.pbload.Size = new System.Drawing.Size(412, 224);
            this.pbload.TabIndex = 0;
            this.pbload.TabStop = false;
            // 
            // lbl_load
            // 
            this.lbl_load.AutoSize = true;
            this.lbl_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_load.Location = new System.Drawing.Point(39, 9);
            this.lbl_load.Name = "lbl_load";
            this.lbl_load.Size = new System.Drawing.Size(347, 25);
            this.lbl_load.TabIndex = 1;
            this.lbl_load.Text = "Affectation des pompiers et des engins";
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(441, 287);
            this.Controls.Add(this.lbl_load);
            this.Controls.Add(this.pbload);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbload;
        private System.Windows.Forms.Label lbl_load;
        private System.Windows.Forms.Timer timer1;
    }
}