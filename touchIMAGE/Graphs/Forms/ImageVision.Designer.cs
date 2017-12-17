namespace touchIMAGE.Graphs.Forms
{
    partial class ImageVision
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Container = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(563, 1);
            // 
            // cmdMaximize
            // 
            this.cmdMaximize.Location = new System.Drawing.Point(517, 1);
            // 
            // cmdMinimize
            // 
            this.cmdMinimize.Location = new System.Drawing.Point(471, 1);
            // 
            // lblTitre
            // 
            this.lblTitre.Location = new System.Drawing.Point(37, 10);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.BackgroundImage = global::touchIMAGE.Properties.Resources.Logo;
            this.picIcon.Location = new System.Drawing.Point(4, 2);
            // 
            // pnl_Container
            // 
            this.pnl_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Container.Location = new System.Drawing.Point(1, 32);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(607, 444);
            this.pnl_Container.TabIndex = 13;
            // 
            // ImageVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 477);
            this.ContainerColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pnl_Container);
            this.Name = "ImageVision";
            this.Text = "ImageVision";
            this.TitleImage = global::touchIMAGE.Properties.Resources.Logo;
            this.Load += new System.EventHandler(this.ImageVision_Load);
            this.Controls.SetChildIndex(this.picIcon, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.cmdMinimize, 0);
            this.Controls.SetChildIndex(this.cmdMaximize, 0);
            this.Controls.SetChildIndex(this.cmdClose, 0);
            this.Controls.SetChildIndex(this.pnl_Container, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Container;
    }
}