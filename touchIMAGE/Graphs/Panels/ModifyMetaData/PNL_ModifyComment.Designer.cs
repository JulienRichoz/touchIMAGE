namespace touchIMAGE.Graphs.Panels.ModifyMetaData
{
    partial class PNL_ModifyComment
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
            this.cmd_Abort = new System.Windows.Forms.Button();
            this.cmd_Modify = new System.Windows.Forms.Button();
            this.rch_Comment = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmd_Abort
            // 
            this.cmd_Abort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_Abort.BackColor = System.Drawing.Color.Transparent;
            this.cmd_Abort.BackgroundImage = global::touchIMAGE.Properties.Resources.Abort;
            this.cmd_Abort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Abort.FlatAppearance.BorderSize = 0;
            this.cmd_Abort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Abort.Location = new System.Drawing.Point(204, 149);
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
            this.cmd_Modify.Location = new System.Drawing.Point(242, 149);
            this.cmd_Modify.Name = "cmd_Modify";
            this.cmd_Modify.Size = new System.Drawing.Size(27, 24);
            this.cmd_Modify.TabIndex = 37;
            this.cmd_Modify.UseVisualStyleBackColor = false;
            this.cmd_Modify.Click += new System.EventHandler(this.cmd_Modify_Click);
            // 
            // rch_Comment
            // 
            this.rch_Comment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rch_Comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rch_Comment.Location = new System.Drawing.Point(19, 14);
            this.rch_Comment.Name = "rch_Comment";
            this.rch_Comment.Size = new System.Drawing.Size(250, 129);
            this.rch_Comment.TabIndex = 40;
            this.rch_Comment.Text = "No Comments";
            // 
            // PNL_ModifyComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rch_Comment);
            this.Controls.Add(this.cmd_Abort);
            this.Controls.Add(this.cmd_Modify);
            this.Name = "PNL_ModifyComment";
            this.Size = new System.Drawing.Size(285, 182);
            this.Load += new System.EventHandler(this.PNL_ModifyComment_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmd_Abort;
        private System.Windows.Forms.Button cmd_Modify;
        private System.Windows.Forms.RichTextBox rch_Comment;
    }
}
