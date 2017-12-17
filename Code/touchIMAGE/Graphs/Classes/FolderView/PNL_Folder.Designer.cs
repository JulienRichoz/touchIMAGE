namespace touchIMAGE.Graphs.Classes.FolderView
{
    partial class PNL_Folder
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
            this.pnl_Children = new System.Windows.Forms.Panel();
            this.lbl_FolderName = new System.Windows.Forms.Label();
            this.pnl_Node = new System.Windows.Forms.Panel();
            this.pic_Folder = new System.Windows.Forms.PictureBox();
            this.pnl_Node.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Folder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Children
            // 
            this.pnl_Children.AutoSize = true;
            this.pnl_Children.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Children.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Children.Location = new System.Drawing.Point(0, 23);
            this.pnl_Children.Name = "pnl_Children";
            this.pnl_Children.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnl_Children.Size = new System.Drawing.Size(450, 3);
            this.pnl_Children.TabIndex = 1;
            // 
            // lbl_FolderName
            // 
            this.lbl_FolderName.AutoSize = true;
            this.lbl_FolderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_FolderName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_FolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_FolderName.Location = new System.Drawing.Point(42, 3);
            this.lbl_FolderName.Name = "lbl_FolderName";
            this.lbl_FolderName.Size = new System.Drawing.Size(89, 17);
            this.lbl_FolderName.TabIndex = 16;
            this.lbl_FolderName.Text = "Folder Name";
            this.lbl_FolderName.Click += new System.EventHandler(this.Node_MouseClick);
            this.lbl_FolderName.MouseEnter += new System.EventHandler(this.Node_MouseEnter);
            this.lbl_FolderName.MouseLeave += new System.EventHandler(this.Node_MouseLeave);
            // 
            // pnl_Node
            // 
            this.pnl_Node.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_Node.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Node.Controls.Add(this.lbl_FolderName);
            this.pnl_Node.Controls.Add(this.pic_Folder);
            this.pnl_Node.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Node.Location = new System.Drawing.Point(0, 0);
            this.pnl_Node.Name = "pnl_Node";
            this.pnl_Node.Padding = new System.Windows.Forms.Padding(3);
            this.pnl_Node.Size = new System.Drawing.Size(450, 23);
            this.pnl_Node.TabIndex = 0;
            this.pnl_Node.Click += new System.EventHandler(this.Node_MouseClick);
            this.pnl_Node.MouseEnter += new System.EventHandler(this.Node_MouseEnter);
            this.pnl_Node.MouseLeave += new System.EventHandler(this.Node_MouseLeave);
            // 
            // pic_Folder
            // 
            this.pic_Folder.BackgroundImage = global::touchIMAGE.Properties.Resources.folder_Blue;
            this.pic_Folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Folder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_Folder.Location = new System.Drawing.Point(3, 3);
            this.pic_Folder.Name = "pic_Folder";
            this.pic_Folder.Size = new System.Drawing.Size(39, 17);
            this.pic_Folder.TabIndex = 15;
            this.pic_Folder.TabStop = false;
            this.pic_Folder.Click += new System.EventHandler(this.Node_MouseClick);
            this.pic_Folder.MouseEnter += new System.EventHandler(this.Node_MouseEnter);
            this.pic_Folder.MouseLeave += new System.EventHandler(this.Node_MouseLeave);
            // 
            // PNL_Folder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnl_Children);
            this.Controls.Add(this.pnl_Node);
            this.Name = "PNL_Folder";
            this.Size = new System.Drawing.Size(450, 26);
            this.pnl_Node.ResumeLayout(false);
            this.pnl_Node.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Folder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Children;
        public System.Windows.Forms.Panel pnl_Node;
        public System.Windows.Forms.Label lbl_FolderName;
        public System.Windows.Forms.PictureBox pic_Folder;
    }
}
