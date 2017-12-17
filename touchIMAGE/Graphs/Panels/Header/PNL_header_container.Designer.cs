namespace touchIMAGE.Graphs.Panels.Header
{
    partial class PNL_header_container
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
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.lnk_FilesRename = new System.Windows.Forms.LinkLabel();
            this.lbl_FileNumber = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_FolderName = new System.Windows.Forms.Label();
            this.img_line = new System.Windows.Forms.PictureBox();
            this.pnl_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_line)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_Container.AutoSize = true;
            this.pnl_Container.Controls.Add(this.lnk_FilesRename);
            this.pnl_Container.Controls.Add(this.lbl_FileNumber);
            this.pnl_Container.Controls.Add(this.lbl_Description);
            this.pnl_Container.Controls.Add(this.lbl_FolderName);
            this.pnl_Container.Location = new System.Drawing.Point(0, 0);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Padding = new System.Windows.Forms.Padding(5);
            this.pnl_Container.Size = new System.Drawing.Size(532, 103);
            this.pnl_Container.TabIndex = 3;
            // 
            // lnk_FilesRename
            // 
            this.lnk_FilesRename.AutoSize = true;
            this.lnk_FilesRename.Location = new System.Drawing.Point(9, 74);
            this.lnk_FilesRename.Name = "lnk_FilesRename";
            this.lnk_FilesRename.Size = new System.Drawing.Size(134, 13);
            this.lnk_FilesRename.TabIndex = 3;
            this.lnk_FilesRename.TabStop = true;
            this.lnk_FilesRename.Text = "Rename all file in the folder";
            this.lnk_FilesRename.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_FilesRename_LinkClicked);
            // 
            // lbl_FileNumber
            // 
            this.lbl_FileNumber.AutoSize = true;
            this.lbl_FileNumber.Location = new System.Drawing.Point(5, 53);
            this.lbl_FileNumber.Name = "lbl_FileNumber";
            this.lbl_FileNumber.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.lbl_FileNumber.Size = new System.Drawing.Size(67, 18);
            this.lbl_FileNumber.TabIndex = 2;
            this.lbl_FileNumber.Text = "File Number";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(5, 36);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.lbl_Description.Size = new System.Drawing.Size(64, 17);
            this.lbl_Description.TabIndex = 1;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_FolderName
            // 
            this.lbl_FolderName.AutoSize = true;
            this.lbl_FolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FolderName.Location = new System.Drawing.Point(5, 5);
            this.lbl_FolderName.Name = "lbl_FolderName";
            this.lbl_FolderName.Size = new System.Drawing.Size(246, 31);
            this.lbl_FolderName.TabIndex = 0;
            this.lbl_FolderName.Text = "No Selected Folder";
            // 
            // img_line
            // 
            this.img_line.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.img_line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.img_line.Location = new System.Drawing.Point(0, 105);
            this.img_line.Name = "img_line";
            this.img_line.Size = new System.Drawing.Size(532, 1);
            this.img_line.TabIndex = 2;
            this.img_line.TabStop = false;
            // 
            // PNL_header_container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.img_line);
            this.Name = "PNL_header_container";
            this.Size = new System.Drawing.Size(532, 106);
            this.pnl_Container.ResumeLayout(false);
            this.pnl_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_line)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Container;
        public System.Windows.Forms.Label lbl_FileNumber;
        public System.Windows.Forms.Label lbl_Description;
        public System.Windows.Forms.Label lbl_FolderName;
        private System.Windows.Forms.PictureBox img_line;
        private System.Windows.Forms.LinkLabel lnk_FilesRename;
    }
}
