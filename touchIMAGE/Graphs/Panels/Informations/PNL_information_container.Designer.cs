namespace touchIMAGE.Graphs.Panels.Informations
{
    partial class PNL_information_container
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PNL_information_container));
            this.cmd_OpenClose = new System.Windows.Forms.Button();
            this.Animation = new DCI_Elements.AnimationComponents();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbl_Tag = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Favorite = new System.Windows.Forms.Label();
            this.lbl_Comment = new System.Windows.Forms.Label();
            this.cmd_Tags = new System.Windows.Forms.Button();
            this.cmd_Date = new System.Windows.Forms.Button();
            this.cmd_Favorite = new System.Windows.Forms.Button();
            this.cmd_Comment = new System.Windows.Forms.Button();
            this.pic_Preview = new System.Windows.Forms.PictureBox();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.pnl_ContainerAutoSize = new System.Windows.Forms.Panel();
            this.img_line = new System.Windows.Forms.PictureBox();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.pnl_information_modify = new touchIMAGE.Graphs.Panels.Informations.PNL_information_modify();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Preview)).BeginInit();
            this.pnl_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_line)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_OpenClose
            // 
            this.cmd_OpenClose.BackColor = System.Drawing.Color.Transparent;
            this.cmd_OpenClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmd_OpenClose.Enabled = false;
            this.cmd_OpenClose.FlatAppearance.BorderSize = 0;
            this.cmd_OpenClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_OpenClose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cmd_OpenClose.Location = new System.Drawing.Point(1, 0);
            this.cmd_OpenClose.Name = "cmd_OpenClose";
            this.cmd_OpenClose.Size = new System.Drawing.Size(14, 581);
            this.cmd_OpenClose.TabIndex = 2;
            this.cmd_OpenClose.Text = " ●●●";
            this.cmd_OpenClose.UseVisualStyleBackColor = false;
            this.cmd_OpenClose.Click += new System.EventHandler(this.cmd_OpenClose_Click);
            // 
            // Animation
            // 
            this.Animation.Animation = DCI_Elements.AnimationComponents.ANIMATION.Dinamic;
            this.Animation.CloseBearingSize = 0;
            this.Animation.CloseSpeed = 1;
            this.Animation.CloseStep = 300;
            this.Animation.Is_Opened = false;
            this.Animation.Is_Operating = false;
            this.Animation.Magnetic = false;
            this.Animation.Object = this;
            this.Animation.OnLoad = DCI_Elements.AnimationComponents.ON_LOAD.Is_Closed;
            this.Animation.OpenBearingSize = 0;
            this.Animation.OpenSpeed = 1;
            this.Animation.OpenStep = 300;
            this.Animation.Position = DCI_Elements.AnimationComponents.POSITION.In_The_Left;
            this.Animation.Size = 300;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lbl_FileName);
            this.pnlHeader.Controls.Add(this.lbl_Tag);
            this.pnlHeader.Controls.Add(this.lbl_Date);
            this.pnlHeader.Controls.Add(this.lbl_Favorite);
            this.pnlHeader.Controls.Add(this.lbl_Comment);
            this.pnlHeader.Controls.Add(this.cmd_Tags);
            this.pnlHeader.Controls.Add(this.cmd_Date);
            this.pnlHeader.Controls.Add(this.cmd_Favorite);
            this.pnlHeader.Controls.Add(this.cmd_Comment);
            this.pnlHeader.Controls.Add(this.pic_Preview);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(15, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(285, 267);
            this.pnlHeader.TabIndex = 7;
            // 
            // lbl_Tag
            // 
            this.lbl_Tag.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Tag.AutoSize = true;
            this.lbl_Tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tag.Location = new System.Drawing.Point(162, 250);
            this.lbl_Tag.Name = "lbl_Tag";
            this.lbl_Tag.Size = new System.Drawing.Size(21, 9);
            this.lbl_Tag.TabIndex = 16;
            this.lbl_Tag.Text = "TAG";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(97, 249);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(26, 9);
            this.lbl_Date.TabIndex = 15;
            this.lbl_Date.Text = "DATE";
            // 
            // lbl_Favorite
            // 
            this.lbl_Favorite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Favorite.AutoSize = true;
            this.lbl_Favorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Favorite.Location = new System.Drawing.Point(25, 249);
            this.lbl_Favorite.Name = "lbl_Favorite";
            this.lbl_Favorite.Size = new System.Drawing.Size(44, 9);
            this.lbl_Favorite.TabIndex = 14;
            this.lbl_Favorite.Text = "FAVORITE";
            // 
            // lbl_Comment
            // 
            this.lbl_Comment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Comment.AutoSize = true;
            this.lbl_Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comment.Location = new System.Drawing.Point(214, 249);
            this.lbl_Comment.Name = "lbl_Comment";
            this.lbl_Comment.Size = new System.Drawing.Size(47, 9);
            this.lbl_Comment.TabIndex = 13;
            this.lbl_Comment.Text = "COMMENT";
            // 
            // cmd_Tags
            // 
            this.cmd_Tags.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmd_Tags.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_Tags.BackgroundImage")));
            this.cmd_Tags.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Tags.FlatAppearance.BorderSize = 0;
            this.cmd_Tags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Tags.Location = new System.Drawing.Point(158, 217);
            this.cmd_Tags.Name = "cmd_Tags";
            this.cmd_Tags.Size = new System.Drawing.Size(30, 30);
            this.cmd_Tags.TabIndex = 12;
            this.cmd_Tags.UseVisualStyleBackColor = true;
            this.cmd_Tags.Click += new System.EventHandler(this.cmd_Tags_Click);
            // 
            // cmd_Date
            // 
            this.cmd_Date.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmd_Date.BackgroundImage = global::touchIMAGE.Properties.Resources.add_date;
            this.cmd_Date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Date.FlatAppearance.BorderSize = 0;
            this.cmd_Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Date.Location = new System.Drawing.Point(94, 217);
            this.cmd_Date.Name = "cmd_Date";
            this.cmd_Date.Size = new System.Drawing.Size(30, 30);
            this.cmd_Date.TabIndex = 11;
            this.cmd_Date.UseVisualStyleBackColor = true;
            this.cmd_Date.Click += new System.EventHandler(this.cmd_Date_Click);
            // 
            // cmd_Favorite
            // 
            this.cmd_Favorite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmd_Favorite.BackgroundImage = global::touchIMAGE.Properties.Resources.add_favorite;
            this.cmd_Favorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Favorite.FlatAppearance.BorderSize = 0;
            this.cmd_Favorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Favorite.Location = new System.Drawing.Point(31, 217);
            this.cmd_Favorite.Name = "cmd_Favorite";
            this.cmd_Favorite.Size = new System.Drawing.Size(30, 30);
            this.cmd_Favorite.TabIndex = 10;
            this.cmd_Favorite.UseVisualStyleBackColor = true;
            this.cmd_Favorite.Click += new System.EventHandler(this.cmd_Favorite_Click);
            // 
            // cmd_Comment
            // 
            this.cmd_Comment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmd_Comment.BackgroundImage = global::touchIMAGE.Properties.Resources.add_comm;
            this.cmd_Comment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Comment.FlatAppearance.BorderSize = 0;
            this.cmd_Comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Comment.Location = new System.Drawing.Point(221, 217);
            this.cmd_Comment.Name = "cmd_Comment";
            this.cmd_Comment.Size = new System.Drawing.Size(30, 30);
            this.cmd_Comment.TabIndex = 9;
            this.cmd_Comment.UseVisualStyleBackColor = true;
            this.cmd_Comment.Click += new System.EventHandler(this.cmd_Comment_Click);
            // 
            // pic_Preview
            // 
            this.pic_Preview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Preview.Location = new System.Drawing.Point(7, 54);
            this.pic_Preview.Name = "pic_Preview";
            this.pic_Preview.Size = new System.Drawing.Size(269, 142);
            this.pic_Preview.TabIndex = 8;
            this.pic_Preview.TabStop = false;
            // 
            // pnl_Container
            // 
            this.pnl_Container.AutoScroll = true;
            this.pnl_Container.Controls.Add(this.pnl_ContainerAutoSize);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(15, 267);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnl_Container.Size = new System.Drawing.Size(285, 314);
            this.pnl_Container.TabIndex = 8;
            // 
            // pnl_ContainerAutoSize
            // 
            this.pnl_ContainerAutoSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ContainerAutoSize.AutoSize = true;
            this.pnl_ContainerAutoSize.Location = new System.Drawing.Point(4, 6);
            this.pnl_ContainerAutoSize.Name = "pnl_ContainerAutoSize";
            this.pnl_ContainerAutoSize.Size = new System.Drawing.Size(276, 59);
            this.pnl_ContainerAutoSize.TabIndex = 0;
            // 
            // img_line
            // 
            this.img_line.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.img_line.Dock = System.Windows.Forms.DockStyle.Left;
            this.img_line.Location = new System.Drawing.Point(0, 0);
            this.img_line.Name = "img_line";
            this.img_line.Size = new System.Drawing.Size(1, 581);
            this.img_line.TabIndex = 1;
            this.img_line.TabStop = false;
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FileName.Location = new System.Drawing.Point(6, 13);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(270, 23);
            this.lbl_FileName.TabIndex = 17;
            this.lbl_FileName.Text = "File Name";
            this.lbl_FileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_information_modify
            // 
            this.pnl_information_modify.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnl_information_modify.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_information_modify.Location = new System.Drawing.Point(15, 267);
            this.pnl_information_modify.Name = "pnl_information_modify";
            this.pnl_information_modify.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.pnl_information_modify.Size = new System.Drawing.Size(285, 0);
            this.pnl_information_modify.TabIndex = 9;
            // 
            // PNL_information_container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_information_modify);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.cmd_OpenClose);
            this.Controls.Add(this.img_line);
            this.Name = "PNL_information_container";
            this.Size = new System.Drawing.Size(300, 581);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Preview)).EndInit();
            this.pnl_Container.ResumeLayout(false);
            this.pnl_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_line)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox img_line;
        public DCI_Elements.AnimationComponents Animation;
        public System.Windows.Forms.Panel pnl_Container;
        public System.Windows.Forms.Panel pnl_ContainerAutoSize;
        public System.Windows.Forms.PictureBox pic_Preview;
        private System.Windows.Forms.Button cmd_Comment;
        private System.Windows.Forms.Button cmd_Tags;
        private System.Windows.Forms.Button cmd_Date;
        private System.Windows.Forms.Button cmd_Favorite;
        public System.Windows.Forms.Panel pnlHeader;
        public PNL_information_modify pnl_information_modify;
        private System.Windows.Forms.Label lbl_Comment;
        private System.Windows.Forms.Label lbl_Favorite;
        private System.Windows.Forms.Label lbl_Tag;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.Button cmd_OpenClose;
        public System.Windows.Forms.Label lbl_FileName;
    }
}
