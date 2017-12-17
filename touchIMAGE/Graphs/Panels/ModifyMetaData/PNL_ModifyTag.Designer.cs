namespace touchIMAGE.Graphs.Panels.ModifyMetaData
{
    partial class PNL_ModifyTag
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmd_Del = new System.Windows.Forms.Button();
            this.lst_Items = new System.Windows.Forms.ListBox();
            this.cmd_Add = new System.Windows.Forms.Button();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.cmd_Abort = new System.Windows.Forms.Button();
            this.cmd_Modify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(15, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 1);
            this.pictureBox1.TabIndex = 36;
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
            this.cmd_Del.Location = new System.Drawing.Point(243, 8);
            this.cmd_Del.Name = "cmd_Del";
            this.cmd_Del.Size = new System.Drawing.Size(26, 25);
            this.cmd_Del.TabIndex = 35;
            this.cmd_Del.UseVisualStyleBackColor = false;
            this.cmd_Del.Click += new System.EventHandler(this.cmd_Del_Click);
            // 
            // lst_Items
            // 
            this.lst_Items.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Items.FormattingEnabled = true;
            this.lst_Items.HorizontalScrollbar = true;
            this.lst_Items.ItemHeight = 15;
            this.lst_Items.Location = new System.Drawing.Point(15, 40);
            this.lst_Items.MinimumSize = new System.Drawing.Size(4, 30);
            this.lst_Items.Name = "lst_Items";
            this.lst_Items.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_Items.Size = new System.Drawing.Size(254, 105);
            this.lst_Items.TabIndex = 34;
            this.lst_Items.SelectedIndexChanged += new System.EventHandler(this.lst_Items_SelectedIndexChanged);
            this.lst_Items.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lst_Items_KeyDown);
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
            this.cmd_Add.Location = new System.Drawing.Point(211, 8);
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.Size = new System.Drawing.Size(26, 25);
            this.cmd_Add.TabIndex = 33;
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
            this.txt_Value.Location = new System.Drawing.Point(15, 12);
            this.txt_Value.Multiline = true;
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(186, 18);
            this.txt_Value.TabIndex = 32;
            this.txt_Value.TextChanged += new System.EventHandler(this.txt_Value_TextChanged);
            this.txt_Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Value_KeyPress);
            // 
            // cmd_Abort
            // 
            this.cmd_Abort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_Abort.BackColor = System.Drawing.Color.Transparent;
            this.cmd_Abort.BackgroundImage = global::touchIMAGE.Properties.Resources.Abort;
            this.cmd_Abort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Abort.FlatAppearance.BorderSize = 0;
            this.cmd_Abort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Abort.Location = new System.Drawing.Point(204, 151);
            this.cmd_Abort.Name = "cmd_Abort";
            this.cmd_Abort.Size = new System.Drawing.Size(32, 24);
            this.cmd_Abort.TabIndex = 38;
            this.cmd_Abort.UseVisualStyleBackColor = false;
            this.cmd_Abort.Click += new System.EventHandler(this.cmd_Abort_Click);
            // 
            // cmd_Modify
            // 
            this.cmd_Modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_Modify.BackColor = System.Drawing.Color.Transparent;
            this.cmd_Modify.BackgroundImage = global::touchIMAGE.Properties.Resources.ok;
            this.cmd_Modify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Modify.FlatAppearance.BorderSize = 0;
            this.cmd_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Modify.Location = new System.Drawing.Point(242, 151);
            this.cmd_Modify.Name = "cmd_Modify";
            this.cmd_Modify.Size = new System.Drawing.Size(27, 24);
            this.cmd_Modify.TabIndex = 37;
            this.cmd_Modify.UseVisualStyleBackColor = false;
            this.cmd_Modify.Click += new System.EventHandler(this.cmd_Modify_Click);
            // 
            // PNL_ModifyTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmd_Del);
            this.Controls.Add(this.lst_Items);
            this.Controls.Add(this.cmd_Add);
            this.Controls.Add(this.txt_Value);
            this.Controls.Add(this.cmd_Abort);
            this.Controls.Add(this.cmd_Modify);
            this.Name = "PNL_ModifyTag";
            this.Size = new System.Drawing.Size(285, 184);
            this.Load += new System.EventHandler(this.PNL_ModifyTag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmd_Del;
        private System.Windows.Forms.Button cmd_Add;
        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.Button cmd_Abort;
        private System.Windows.Forms.Button cmd_Modify;
        private System.Windows.Forms.ListBox lst_Items;
    }
}
