namespace touchIMAGE.Graphs.Classes.FolderView
{
    partial class PNL_TreeView
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
            this.pnl_Root = new touchIMAGE.Graphs.Classes.FolderView.PNL_Folder();
            this.SuspendLayout();
            // 
            // pnl_Root
            // 
            this.pnl_Root.AutoSize = true;
            this.pnl_Root.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Root.Location = new System.Drawing.Point(0, 0);
            this.pnl_Root.Name = "pnl_Root";
            this.pnl_Root.Size = new System.Drawing.Size(222, 23);
            this.pnl_Root.TabIndex = 0;
            // 
            // PNL_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnl_Root);
            this.Name = "PNL_TreeView";
            this.Size = new System.Drawing.Size(222, 341);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Classes.FolderView.PNL_Folder pnl_Root;
    }
}
