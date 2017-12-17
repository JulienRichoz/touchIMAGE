namespace touchIMAGE.Graphs.Panels.Navigation
{
    partial class PNL_navigation_folder
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
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.img_line = new System.Windows.Forms.PictureBox();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.pnl_TreeView = new touchIMAGE.Graphs.Classes.FolderView.PNL_TreeView();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_line)).BeginInit();
            this.pnl_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(287, 40);
            this.pnl_Header.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(122, 14);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(41, 13);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Folders";
            // 
            // img_line
            // 
            this.img_line.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.img_line.Dock = System.Windows.Forms.DockStyle.Top;
            this.img_line.Location = new System.Drawing.Point(0, 40);
            this.img_line.Name = "img_line";
            this.img_line.Size = new System.Drawing.Size(287, 1);
            this.img_line.TabIndex = 1;
            this.img_line.TabStop = false;
            // 
            // pnl_Container
            // 
            this.pnl_Container.AutoScroll = true;
            this.pnl_Container.Controls.Add(this.pnl_TreeView);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 41);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(287, 326);
            this.pnl_Container.TabIndex = 2;
            // 
            // pnl_TreeView
            // 
            this.pnl_TreeView.AutoSize = true;
            this.pnl_TreeView.Location = new System.Drawing.Point(3, 6);
            this.pnl_TreeView.Name = "pnl_TreeView";
            this.pnl_TreeView.Size = new System.Drawing.Size(276, 23);
            this.pnl_TreeView.TabIndex = 0;
            // 
            // PNL_navigation_folder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.img_line);
            this.Controls.Add(this.pnl_Header);
            this.Name = "PNL_navigation_folder";
            this.Size = new System.Drawing.Size(287, 367);
            this.Load += new System.EventHandler(this.PNL_navigation_folder_Load);
            this.Resize += new System.EventHandler(this.pnl_Container_Resize);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_line)).EndInit();
            this.pnl_Container.ResumeLayout(false);
            this.pnl_Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox img_line;
        private Classes.FolderView.PNL_TreeView pnl_TreeView;
        public System.Windows.Forms.Panel pnl_Container;
    }
}
