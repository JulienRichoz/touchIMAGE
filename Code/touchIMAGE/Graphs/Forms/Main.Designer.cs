namespace touchIMAGE
{
    partial class frm_Main
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter = new System.Windows.Forms.Splitter();
            this.pnl_MainContainer = new System.Windows.Forms.Panel();
            this.lst_Images = new System.Windows.Forms.ListView();
            this.pnl_information_container = new touchIMAGE.Graphs.Panels.Informations.PNL_information_container();
            this.pnl_header_container = new touchIMAGE.Graphs.Panels.Header.PNL_header_container();
            this.pnl_navigation_container = new touchIMAGE.Graphs.Panels.Navigation.PNL_navigation_container();
            this.pnl_footer_container = new touchIMAGE.Graphs.Panels.Footer.PNL_footer_container();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.pnl_MainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(929, 1);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // cmdMaximize
            // 
            this.cmdMaximize.Location = new System.Drawing.Point(883, 1);
            this.cmdMaximize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // cmdMinimize
            // 
            this.cmdMinimize.Location = new System.Drawing.Point(837, 1);
            this.cmdMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // lblTitre
            // 
            this.lblTitre.Location = new System.Drawing.Point(51, 10);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Size = new System.Drawing.Size(62, 13);
            this.lblTitre.Text = "toucIMAGE";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.BackgroundImage = global::touchIMAGE.Properties.Resources.Logo;
            this.picIcon.Location = new System.Drawing.Point(10, 2);
            this.picIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picIcon.Size = new System.Drawing.Size(38, 28);
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter.Location = new System.Drawing.Point(263, 0);
            this.splitter.MinExtra = 200;
            this.splitter.MinSize = 200;
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(1, 579);
            this.splitter.TabIndex = 2;
            this.splitter.TabStop = false;
            // 
            // pnl_MainContainer
            // 
            this.pnl_MainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_MainContainer.BackColor = System.Drawing.Color.White;
            this.pnl_MainContainer.Controls.Add(this.lst_Images);
            this.pnl_MainContainer.Controls.Add(this.pnl_information_container);
            this.pnl_MainContainer.Controls.Add(this.pnl_header_container);
            this.pnl_MainContainer.Controls.Add(this.splitter);
            this.pnl_MainContainer.Controls.Add(this.pnl_navigation_container);
            this.pnl_MainContainer.Controls.Add(this.pnl_footer_container);
            this.pnl_MainContainer.Location = new System.Drawing.Point(1, 32);
            this.pnl_MainContainer.Name = "pnl_MainContainer";
            this.pnl_MainContainer.Size = new System.Drawing.Size(973, 597);
            this.pnl_MainContainer.TabIndex = 13;
            // 
            // lst_Images
            // 
            this.lst_Images.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_Images.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_Images.Location = new System.Drawing.Point(264, 98);
            this.lst_Images.MultiSelect = false;
            this.lst_Images.Name = "lst_Images";
            this.lst_Images.Size = new System.Drawing.Size(696, 481);
            this.lst_Images.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lst_Images.TabIndex = 5;
            this.lst_Images.UseCompatibleStateImageBehavior = false;
            this.lst_Images.Click += new System.EventHandler(this.lst_Images_Click);
            this.lst_Images.DoubleClick += new System.EventHandler(this.lst_Images_DoubleClick);
            // 
            // pnl_information_container
            // 
            this.pnl_information_container.BackColor = System.Drawing.Color.Transparent;
            this.pnl_information_container.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_information_container.Location = new System.Drawing.Point(960, 98);
            this.pnl_information_container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_information_container.Name = "pnl_information_container";
            this.pnl_information_container.Size = new System.Drawing.Size(13, 481);
            this.pnl_information_container.TabIndex = 4;
            // 
            // pnl_header_container
            // 
            this.pnl_header_container.AutoScroll = true;
            this.pnl_header_container.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header_container.Location = new System.Drawing.Point(264, 0);
            this.pnl_header_container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_header_container.Name = "pnl_header_container";
            this.pnl_header_container.Size = new System.Drawing.Size(709, 98);
            this.pnl_header_container.TabIndex = 3;
            // 
            // pnl_navigation_container
            // 
            this.pnl_navigation_container.BackColor = System.Drawing.Color.Transparent;
            this.pnl_navigation_container.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_navigation_container.Location = new System.Drawing.Point(0, 0);
            this.pnl_navigation_container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_navigation_container.Name = "pnl_navigation_container";
            this.pnl_navigation_container.Size = new System.Drawing.Size(263, 579);
            this.pnl_navigation_container.TabIndex = 1;
            // 
            // pnl_footer_container
            // 
            this.pnl_footer_container.BackColor = System.Drawing.Color.White;
            this.pnl_footer_container.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer_container.Location = new System.Drawing.Point(0, 579);
            this.pnl_footer_container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_footer_container.Name = "pnl_footer_container";
            this.pnl_footer_container.Size = new System.Drawing.Size(973, 18);
            this.pnl_footer_container.TabIndex = 0;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(975, 630);
            this.ContainerColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnl_MainContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(845, 630);
            this.Name = "frm_Main";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Form1";
            this.TitleImage = global::touchIMAGE.Properties.Resources.Logo;
            this.TitleImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TitleText = "toucIMAGE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Main_FormClosed);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.Controls.SetChildIndex(this.pnl_MainContainer, 0);
            this.Controls.SetChildIndex(this.picIcon, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.cmdMinimize, 0);
            this.Controls.SetChildIndex(this.cmdMaximize, 0);
            this.Controls.SetChildIndex(this.cmdClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.pnl_MainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Graphs.Panels.Footer.PNL_footer_container pnl_footer_container;
        private System.Windows.Forms.Splitter splitter;
        public System.Windows.Forms.Panel pnl_MainContainer;
        public System.Windows.Forms.ListView lst_Images;
        public Graphs.Panels.Navigation.PNL_navigation_container pnl_navigation_container;
        public Graphs.Panels.Header.PNL_header_container pnl_header_container;
        public Graphs.Panels.Informations.PNL_information_container pnl_information_container;
    }
}

