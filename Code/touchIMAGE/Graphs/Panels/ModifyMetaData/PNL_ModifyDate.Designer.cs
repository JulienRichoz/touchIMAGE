namespace touchIMAGE.Graphs.Panels.ModifyMetaData
{
    partial class PNL_ModifyDate
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
            this.dta_DateTaken = new System.Windows.Forms.DateTimePicker();
            this.cmd_Abort = new System.Windows.Forms.Button();
            this.cmd_Modify = new System.Windows.Forms.Button();
            this.lbl_FlashMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dta_DateTaken
            // 
            this.dta_DateTaken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dta_DateTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dta_DateTaken.Location = new System.Drawing.Point(12, 41);
            this.dta_DateTaken.Name = "dta_DateTaken";
            this.dta_DateTaken.Size = new System.Drawing.Size(262, 21);
            this.dta_DateTaken.TabIndex = 49;
            // 
            // cmd_Abort
            // 
            this.cmd_Abort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_Abort.BackColor = System.Drawing.Color.Transparent;
            this.cmd_Abort.BackgroundImage = global::touchIMAGE.Properties.Resources.Abort;
            this.cmd_Abort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Abort.FlatAppearance.BorderSize = 0;
            this.cmd_Abort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Abort.Location = new System.Drawing.Point(204, 132);
            this.cmd_Abort.Name = "cmd_Abort";
            this.cmd_Abort.Size = new System.Drawing.Size(32, 24);
            this.cmd_Abort.TabIndex = 51;
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
            this.cmd_Modify.Location = new System.Drawing.Point(242, 132);
            this.cmd_Modify.Name = "cmd_Modify";
            this.cmd_Modify.Size = new System.Drawing.Size(27, 24);
            this.cmd_Modify.TabIndex = 50;
            this.cmd_Modify.UseVisualStyleBackColor = false;
            this.cmd_Modify.Click += new System.EventHandler(this.cmd_Modify_Click);
            // 
            // lbl_FlashMessage
            // 
            this.lbl_FlashMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_FlashMessage.AutoSize = true;
            this.lbl_FlashMessage.Location = new System.Drawing.Point(14, 16);
            this.lbl_FlashMessage.Name = "lbl_FlashMessage";
            this.lbl_FlashMessage.Size = new System.Drawing.Size(90, 13);
            this.lbl_FlashMessage.TabIndex = 52;
            this.lbl_FlashMessage.Text = "No date available";
            this.lbl_FlashMessage.Visible = false;
            // 
            // PNL_ModifyDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_FlashMessage);
            this.Controls.Add(this.cmd_Abort);
            this.Controls.Add(this.cmd_Modify);
            this.Controls.Add(this.dta_DateTaken);
            this.Name = "PNL_ModifyDate";
            this.Size = new System.Drawing.Size(285, 165);
            this.Load += new System.EventHandler(this.PNL_ModifyDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dta_DateTaken;
        private System.Windows.Forms.Button cmd_Abort;
        private System.Windows.Forms.Button cmd_Modify;
        private System.Windows.Forms.Label lbl_FlashMessage;
    }
}
