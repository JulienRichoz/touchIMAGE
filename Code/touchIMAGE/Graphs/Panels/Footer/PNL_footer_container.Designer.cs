namespace touchIMAGE.Graphs.Panels.Footer
{
    partial class PNL_footer_container
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
            this.Animation = new DCI_Elements.AnimationComponents();
            this.cmd_OpenClose = new System.Windows.Forms.Button();
            this.img_line = new System.Windows.Forms.PictureBox();
            this.trk_ImageSize = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_Change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_ImageSize)).BeginInit();
            this.SuspendLayout();
            // 
            // Animation
            // 
            this.Animation.Animation = DCI_Elements.AnimationComponents.ANIMATION.Dinamic;
            this.Animation.CloseBearingSize = 10;
            this.Animation.CloseSpeed = 10;
            this.Animation.CloseStep = 15;
            this.Animation.Is_Opened = false;
            this.Animation.Is_Operating = false;
            this.Animation.Magnetic = false;
            this.Animation.Object = this;
            this.Animation.OnLoad = DCI_Elements.AnimationComponents.ON_LOAD.Is_Closed;
            this.Animation.OpenBearingSize = 10;
            this.Animation.OpenSpeed = 10;
            this.Animation.OpenStep = 15;
            this.Animation.Position = DCI_Elements.AnimationComponents.POSITION.In_The_Top;
            this.Animation.Size = 50;
            // 
            // cmd_OpenClose
            // 
            this.cmd_OpenClose.BackColor = System.Drawing.Color.Transparent;
            this.cmd_OpenClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmd_OpenClose.FlatAppearance.BorderSize = 0;
            this.cmd_OpenClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_OpenClose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cmd_OpenClose.Location = new System.Drawing.Point(0, 1);
            this.cmd_OpenClose.Name = "cmd_OpenClose";
            this.cmd_OpenClose.Size = new System.Drawing.Size(545, 18);
            this.cmd_OpenClose.TabIndex = 4;
            this.cmd_OpenClose.Text = "●●●";
            this.cmd_OpenClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmd_OpenClose.UseVisualStyleBackColor = false;
            this.cmd_OpenClose.Click += new System.EventHandler(this.cmd_OpenClose_Click);
            // 
            // img_line
            // 
            this.img_line.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.img_line.Dock = System.Windows.Forms.DockStyle.Top;
            this.img_line.Location = new System.Drawing.Point(0, 0);
            this.img_line.Name = "img_line";
            this.img_line.Size = new System.Drawing.Size(545, 1);
            this.img_line.TabIndex = 3;
            this.img_line.TabStop = false;
            // 
            // trk_ImageSize
            // 
            this.trk_ImageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trk_ImageSize.LargeChange = 50;
            this.trk_ImageSize.Location = new System.Drawing.Point(423, 25);
            this.trk_ImageSize.Maximum = 250;
            this.trk_ImageSize.Minimum = 50;
            this.trk_ImageSize.Name = "trk_ImageSize";
            this.trk_ImageSize.Size = new System.Drawing.Size(104, 45);
            this.trk_ImageSize.SmallChange = 50;
            this.trk_ImageSize.TabIndex = 5;
            this.trk_ImageSize.TickFrequency = 50;
            this.trk_ImageSize.Value = 120;
            this.trk_ImageSize.Scroll += new System.EventHandler(this.trk_ImageSize_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Change Image Size";
            // 
            // cmd_Change
            // 
            this.cmd_Change.Location = new System.Drawing.Point(22, 33);
            this.cmd_Change.Name = "cmd_Change";
            this.cmd_Change.Size = new System.Drawing.Size(117, 23);
            this.cmd_Change.TabIndex = 7;
            this.cmd_Change.Text = "Change Folder";
            this.cmd_Change.UseVisualStyleBackColor = true;
            this.cmd_Change.Click += new System.EventHandler(this.cmd_Change_Click);
            // 
            // PNL_footer_container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cmd_Change);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trk_ImageSize);
            this.Controls.Add(this.cmd_OpenClose);
            this.Controls.Add(this.img_line);
            this.Name = "PNL_footer_container";
            this.Size = new System.Drawing.Size(545, 100);
            ((System.ComponentModel.ISupportInitialize)(this.img_line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_ImageSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DCI_Elements.AnimationComponents Animation;
        private System.Windows.Forms.Button cmd_OpenClose;
        private System.Windows.Forms.PictureBox img_line;
        private System.Windows.Forms.TrackBar trk_ImageSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_Change;
    }
}
