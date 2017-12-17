namespace touchIMAGE.Graphs.Panels.Navigation
{
    partial class PNL_navigation_filtre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PNL_navigation_filtre));
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.pnl_FiltreContainer = new System.Windows.Forms.Panel();
            this.pnl_FiltreIcon = new System.Windows.Forms.Panel();
            this.lbl_Tag = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Favorite = new System.Windows.Forms.Label();
            this.lbl_Comment = new System.Windows.Forms.Label();
            this.cmd_Tags = new System.Windows.Forms.Button();
            this.cmd_Date = new System.Windows.Forms.Button();
            this.cmd_Favorite = new System.Windows.Forms.Button();
            this.cmd_Format = new System.Windows.Forms.Button();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.img_line = new System.Windows.Forms.PictureBox();
            this.pnl_Container.SuspendLayout();
            this.pnl_FiltreIcon.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_line)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.AutoScroll = true;
            this.pnl_Container.Controls.Add(this.pnl_FiltreContainer);
            this.pnl_Container.Controls.Add(this.pnl_FiltreIcon);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 40);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(304, 274);
            this.pnl_Container.TabIndex = 5;
            // 
            // pnl_FiltreContainer
            // 
            this.pnl_FiltreContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_FiltreContainer.Location = new System.Drawing.Point(0, 60);
            this.pnl_FiltreContainer.Name = "pnl_FiltreContainer";
            this.pnl_FiltreContainer.Size = new System.Drawing.Size(304, 214);
            this.pnl_FiltreContainer.TabIndex = 2;
            // 
            // pnl_FiltreIcon
            // 
            this.pnl_FiltreIcon.Controls.Add(this.lbl_Tag);
            this.pnl_FiltreIcon.Controls.Add(this.lbl_Date);
            this.pnl_FiltreIcon.Controls.Add(this.lbl_Favorite);
            this.pnl_FiltreIcon.Controls.Add(this.lbl_Comment);
            this.pnl_FiltreIcon.Controls.Add(this.cmd_Tags);
            this.pnl_FiltreIcon.Controls.Add(this.cmd_Date);
            this.pnl_FiltreIcon.Controls.Add(this.cmd_Favorite);
            this.pnl_FiltreIcon.Controls.Add(this.cmd_Format);
            this.pnl_FiltreIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_FiltreIcon.Location = new System.Drawing.Point(0, 0);
            this.pnl_FiltreIcon.Name = "pnl_FiltreIcon";
            this.pnl_FiltreIcon.Size = new System.Drawing.Size(304, 60);
            this.pnl_FiltreIcon.TabIndex = 0;
            // 
            // lbl_Tag
            // 
            this.lbl_Tag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Tag.AutoSize = true;
            this.lbl_Tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tag.Location = new System.Drawing.Point(172, 41);
            this.lbl_Tag.Name = "lbl_Tag";
            this.lbl_Tag.Size = new System.Drawing.Size(21, 9);
            this.lbl_Tag.TabIndex = 32;
            this.lbl_Tag.Text = "TAG";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(108, 40);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(26, 9);
            this.lbl_Date.TabIndex = 31;
            this.lbl_Date.Text = "DATE";
            // 
            // lbl_Favorite
            // 
            this.lbl_Favorite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Favorite.AutoSize = true;
            this.lbl_Favorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Favorite.Location = new System.Drawing.Point(35, 40);
            this.lbl_Favorite.Name = "lbl_Favorite";
            this.lbl_Favorite.Size = new System.Drawing.Size(44, 9);
            this.lbl_Favorite.TabIndex = 30;
            this.lbl_Favorite.Text = "FAVORITE";
            // 
            // lbl_Comment
            // 
            this.lbl_Comment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Comment.AutoSize = true;
            this.lbl_Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comment.Location = new System.Drawing.Point(229, 40);
            this.lbl_Comment.Name = "lbl_Comment";
            this.lbl_Comment.Size = new System.Drawing.Size(39, 9);
            this.lbl_Comment.TabIndex = 29;
            this.lbl_Comment.Text = "FORMAT";
            // 
            // cmd_Tags
            // 
            this.cmd_Tags.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Tags.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_Tags.BackgroundImage")));
            this.cmd_Tags.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Tags.FlatAppearance.BorderSize = 0;
            this.cmd_Tags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Tags.Location = new System.Drawing.Point(168, 8);
            this.cmd_Tags.Name = "cmd_Tags";
            this.cmd_Tags.Size = new System.Drawing.Size(30, 30);
            this.cmd_Tags.TabIndex = 28;
            this.cmd_Tags.UseVisualStyleBackColor = true;
            this.cmd_Tags.Click += new System.EventHandler(this.cmd_Tags_Click);
            // 
            // cmd_Date
            // 
            this.cmd_Date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Date.BackgroundImage = global::touchIMAGE.Properties.Resources.add_date;
            this.cmd_Date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Date.FlatAppearance.BorderSize = 0;
            this.cmd_Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Date.Location = new System.Drawing.Point(105, 8);
            this.cmd_Date.Name = "cmd_Date";
            this.cmd_Date.Size = new System.Drawing.Size(30, 30);
            this.cmd_Date.TabIndex = 27;
            this.cmd_Date.UseVisualStyleBackColor = true;
            this.cmd_Date.Click += new System.EventHandler(this.cmd_Date_Click);
            // 
            // cmd_Favorite
            // 
            this.cmd_Favorite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Favorite.BackgroundImage = global::touchIMAGE.Properties.Resources.add_favorite;
            this.cmd_Favorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Favorite.FlatAppearance.BorderSize = 0;
            this.cmd_Favorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Favorite.Location = new System.Drawing.Point(41, 8);
            this.cmd_Favorite.Name = "cmd_Favorite";
            this.cmd_Favorite.Size = new System.Drawing.Size(30, 30);
            this.cmd_Favorite.TabIndex = 26;
            this.cmd_Favorite.UseVisualStyleBackColor = true;
            this.cmd_Favorite.Click += new System.EventHandler(this.cmd_Favorite_Click);
            // 
            // cmd_Format
            // 
            this.cmd_Format.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Format.BackgroundImage = global::touchIMAGE.Properties.Resources.add_comm;
            this.cmd_Format.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Format.FlatAppearance.BorderSize = 0;
            this.cmd_Format.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Format.Location = new System.Drawing.Point(231, 8);
            this.cmd_Format.Name = "cmd_Format";
            this.cmd_Format.Size = new System.Drawing.Size(30, 30);
            this.cmd_Format.TabIndex = 25;
            this.cmd_Format.UseVisualStyleBackColor = true;
            this.cmd_Format.Click += new System.EventHandler(this.cmd_Format_Click);
            // 
            // pnl_Header
            // 
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(304, 40);
            this.pnl_Header.TabIndex = 3;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(133, 14);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(29, 13);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Filtre";
            // 
            // img_line
            // 
            this.img_line.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.img_line.Dock = System.Windows.Forms.DockStyle.Top;
            this.img_line.Location = new System.Drawing.Point(0, 40);
            this.img_line.Name = "img_line";
            this.img_line.Size = new System.Drawing.Size(304, 1);
            this.img_line.TabIndex = 4;
            this.img_line.TabStop = false;
            // 
            // PNL_navigation_filtre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.img_line);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Header);
            this.Name = "PNL_navigation_filtre";
            this.Size = new System.Drawing.Size(304, 314);
            this.pnl_Container.ResumeLayout(false);
            this.pnl_FiltreIcon.ResumeLayout(false);
            this.pnl_FiltreIcon.PerformLayout();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_line)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox img_line;
        private System.Windows.Forms.Panel pnl_FiltreIcon;
        private System.Windows.Forms.Label lbl_Tag;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Favorite;
        private System.Windows.Forms.Label lbl_Comment;
        private System.Windows.Forms.Button cmd_Tags;
        private System.Windows.Forms.Button cmd_Date;
        private System.Windows.Forms.Button cmd_Favorite;
        private System.Windows.Forms.Button cmd_Format;
        private System.Windows.Forms.Panel pnl_FiltreContainer;
    }
}
