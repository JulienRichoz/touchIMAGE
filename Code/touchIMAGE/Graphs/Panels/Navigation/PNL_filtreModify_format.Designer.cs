namespace touchIMAGE.Graphs.Panels.Navigation
{
    partial class PNL_filtreModify_format
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmd_Del = new System.Windows.Forms.Button();
            this.cmd_Add = new System.Windows.Forms.Button();
            this.lst_Selected = new System.Windows.Forms.ListBox();
            this.lst_NotSelected = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(13, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 1);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // cmd_Del
            // 
            this.cmd_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_Del.BackColor = System.Drawing.Color.Transparent;
            this.cmd_Del.BackgroundImage = global::touchIMAGE.Properties.Resources.trash_icon_icons1;
            this.cmd_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Del.Enabled = false;
            this.cmd_Del.FlatAppearance.BorderSize = 0;
            this.cmd_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Del.Location = new System.Drawing.Point(231, 100);
            this.cmd_Del.Name = "cmd_Del";
            this.cmd_Del.Size = new System.Drawing.Size(26, 25);
            this.cmd_Del.TabIndex = 6;
            this.cmd_Del.UseVisualStyleBackColor = false;
            this.cmd_Del.Click += new System.EventHandler(this.cmd_Del_Click);
            // 
            // cmd_Add
            // 
            this.cmd_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_Add.BackColor = System.Drawing.Color.Transparent;
            this.cmd_Add.BackgroundImage = global::touchIMAGE.Properties.Resources.addListElem;
            this.cmd_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Add.Enabled = false;
            this.cmd_Add.FlatAppearance.BorderSize = 0;
            this.cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Add.Location = new System.Drawing.Point(231, 69);
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.Size = new System.Drawing.Size(26, 25);
            this.cmd_Add.TabIndex = 4;
            this.cmd_Add.UseVisualStyleBackColor = false;
            this.cmd_Add.Click += new System.EventHandler(this.cmd_Add_Click);
            // 
            // lst_Selected
            // 
            this.lst_Selected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_Selected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_Selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Selected.FormattingEnabled = true;
            this.lst_Selected.HorizontalScrollbar = true;
            this.lst_Selected.ItemHeight = 15;
            this.lst_Selected.Location = new System.Drawing.Point(15, 100);
            this.lst_Selected.MinimumSize = new System.Drawing.Size(4, 30);
            this.lst_Selected.Name = "lst_Selected";
            this.lst_Selected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_Selected.Size = new System.Drawing.Size(210, 75);
            this.lst_Selected.TabIndex = 5;
            this.lst_Selected.SelectedIndexChanged += new System.EventHandler(this.lst_Selected_SelectedIndexChanged);
            this.lst_Selected.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lst_Selected_KeyDown);
            // 
            // lst_NotSelected
            // 
            this.lst_NotSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_NotSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_NotSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_NotSelected.FormattingEnabled = true;
            this.lst_NotSelected.HorizontalScrollbar = true;
            this.lst_NotSelected.ItemHeight = 15;
            this.lst_NotSelected.Location = new System.Drawing.Point(15, 19);
            this.lst_NotSelected.MinimumSize = new System.Drawing.Size(4, 30);
            this.lst_NotSelected.Name = "lst_NotSelected";
            this.lst_NotSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_NotSelected.Size = new System.Drawing.Size(210, 75);
            this.lst_NotSelected.TabIndex = 13;
            this.lst_NotSelected.SelectedIndexChanged += new System.EventHandler(this.lst_NotSelected_SelectedIndexChanged);
            // 
            // PNL_filtreModify_format
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lst_NotSelected);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmd_Del);
            this.Controls.Add(this.lst_Selected);
            this.Controls.Add(this.cmd_Add);
            this.Name = "PNL_filtreModify_format";
            this.Size = new System.Drawing.Size(274, 183);
            this.Load += new System.EventHandler(this.PNL_FiltreModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmd_Del;
        private System.Windows.Forms.Button cmd_Add;
        public System.Windows.Forms.ListBox lst_Selected;
        public System.Windows.Forms.ListBox lst_NotSelected;
    }
}
