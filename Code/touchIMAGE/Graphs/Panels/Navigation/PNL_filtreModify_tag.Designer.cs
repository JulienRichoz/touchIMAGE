namespace touchIMAGE.Graphs.Panels.Navigation
{
    partial class PNL_filtreModify_tag
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
            this.lst_Selected = new System.Windows.Forms.ListBox();
            this.cmd_Add = new System.Windows.Forms.Button();
            this.txt_Value = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(15, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 1);
            this.pictureBox1.TabIndex = 21;
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
            this.cmd_Del.Location = new System.Drawing.Point(263, 16);
            this.cmd_Del.Name = "cmd_Del";
            this.cmd_Del.Size = new System.Drawing.Size(26, 25);
            this.cmd_Del.TabIndex = 19;
            this.cmd_Del.UseVisualStyleBackColor = false;
            this.cmd_Del.Click += new System.EventHandler(this.cmd_Del_Click);
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
            this.lst_Selected.Location = new System.Drawing.Point(15, 45);
            this.lst_Selected.MinimumSize = new System.Drawing.Size(4, 30);
            this.lst_Selected.Name = "lst_Selected";
            this.lst_Selected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_Selected.Size = new System.Drawing.Size(274, 105);
            this.lst_Selected.TabIndex = 18;
            this.lst_Selected.SelectedIndexChanged += new System.EventHandler(this.lst_Selected_SelectedIndexChanged);
            this.lst_Selected.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lst_Selected_KeyDown);
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
            this.cmd_Add.Location = new System.Drawing.Point(231, 17);
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.Size = new System.Drawing.Size(26, 25);
            this.cmd_Add.TabIndex = 17;
            this.cmd_Add.UseVisualStyleBackColor = false;
            this.cmd_Add.Click += new System.EventHandler(this.cmd_Add_Click);
            // 
            // txt_Value
            // 
            this.txt_Value.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Value.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Value.Location = new System.Drawing.Point(15, 18);
            this.txt_Value.Multiline = true;
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(206, 18);
            this.txt_Value.TabIndex = 16;
            this.txt_Value.TextChanged += new System.EventHandler(this.txt_Value_TextChanged);
            this.txt_Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Value_KeyPress);
            // 
            // PNL_filtreModify_tag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmd_Del);
            this.Controls.Add(this.lst_Selected);
            this.Controls.Add(this.cmd_Add);
            this.Controls.Add(this.txt_Value);
            this.Name = "PNL_filtreModify_tag";
            this.Size = new System.Drawing.Size(306, 163);
            this.Load += new System.EventHandler(this.PNL_FiltreModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmd_Del;
        public System.Windows.Forms.ListBox lst_Selected;
        private System.Windows.Forms.Button cmd_Add;
        private System.Windows.Forms.TextBox txt_Value;
    }
}
