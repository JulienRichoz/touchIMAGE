namespace touchIMAGE.Graphs.Panels.Navigation
{
    partial class PNL_navigation_container
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.img_line = new System.Windows.Forms.PictureBox();
            this.pnl_navigation_folder = new touchIMAGE.Graphs.Panels.Navigation.PNL_navigation_folder();
            this.pnl_navigation_filtre = new touchIMAGE.Graphs.Panels.Navigation.PNL_navigation_filtre();
            ((System.ComponentModel.ISupportInitialize)(this.img_line)).BeginInit();
            this.SuspendLayout();
            // 
            // img_line
            // 
            this.img_line.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.img_line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.img_line.Location = new System.Drawing.Point(0, 322);
            this.img_line.Name = "img_line";
            this.img_line.Size = new System.Drawing.Size(283, 1);
            this.img_line.TabIndex = 5;
            this.img_line.TabStop = false;
            // 
            // pnl_navigation_folder
            // 
            this.pnl_navigation_folder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_navigation_folder.Location = new System.Drawing.Point(0, 0);
            this.pnl_navigation_folder.Name = "pnl_navigation_folder";
            this.pnl_navigation_folder.Size = new System.Drawing.Size(283, 322);
            this.pnl_navigation_folder.TabIndex = 0;
            // 
            // pnl_navigation_filtre
            // 
            this.pnl_navigation_filtre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_navigation_filtre.Location = new System.Drawing.Point(0, 323);
            this.pnl_navigation_filtre.Name = "pnl_navigation_filtre";
            this.pnl_navigation_filtre.Size = new System.Drawing.Size(283, 248);
            this.pnl_navigation_filtre.TabIndex = 6;
            // 
            // PNL_navigation_container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnl_navigation_folder);
            this.Controls.Add(this.img_line);
            this.Controls.Add(this.pnl_navigation_filtre);
            this.Name = "PNL_navigation_container";
            this.Size = new System.Drawing.Size(283, 571);
            ((System.ComponentModel.ISupportInitialize)(this.img_line)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox img_line;
        public PNL_navigation_filtre pnl_navigation_filtre;
        public PNL_navigation_folder pnl_navigation_folder;
    }
}
