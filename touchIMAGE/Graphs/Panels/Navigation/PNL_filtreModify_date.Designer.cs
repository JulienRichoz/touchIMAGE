namespace touchIMAGE.Graphs.Panels.Navigation
{
    partial class PNL_filtreModify_date
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
            this.animationContent = new DCI_Elements.AnimationComponents();
            this.animationHeader = new DCI_Elements.AnimationComponents();
            this.dta_Piker_Start = new System.Windows.Forms.DateTimePicker();
            this.dta_Piker_End = new System.Windows.Forms.DateTimePicker();
            this.lbl_Start = new System.Windows.Forms.Label();
            this.lbl_End = new System.Windows.Forms.Label();
            this.chk_EnableDataEnd = new System.Windows.Forms.CheckBox();
            this.chk_EnableDataStart = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // animationContent
            // 
            this.animationContent.Animation = DCI_Elements.AnimationComponents.ANIMATION.Dinamic;
            this.animationContent.CloseBearingSize = 10;
            this.animationContent.CloseSpeed = 1;
            this.animationContent.CloseStep = 20;
            this.animationContent.Is_Opened = false;
            this.animationContent.Is_Operating = false;
            this.animationContent.Magnetic = false;
            this.animationContent.Object = this;
            this.animationContent.OnLoad = DCI_Elements.AnimationComponents.ON_LOAD.Is_Closed;
            this.animationContent.OpenBearingSize = 10;
            this.animationContent.OpenSpeed = 1;
            this.animationContent.OpenStep = 20;
            this.animationContent.Position = DCI_Elements.AnimationComponents.POSITION.In_The_Bottom;
            this.animationContent.Size = 90;
            // 
            // animationHeader
            // 
            this.animationHeader.Animation = DCI_Elements.AnimationComponents.ANIMATION.Static;
            this.animationHeader.CloseBearingSize = 3;
            this.animationHeader.CloseSpeed = 1;
            this.animationHeader.CloseStep = 2;
            this.animationHeader.Is_Opened = true;
            this.animationHeader.Is_Operating = false;
            this.animationHeader.Magnetic = false;
            this.animationHeader.Object = null;
            this.animationHeader.OnLoad = DCI_Elements.AnimationComponents.ON_LOAD.Is_Opened;
            this.animationHeader.OpenBearingSize = 5;
            this.animationHeader.OpenSpeed = 1;
            this.animationHeader.OpenStep = 2;
            this.animationHeader.Position = DCI_Elements.AnimationComponents.POSITION.In_The_Bottom;
            this.animationHeader.Size = 30;
            // 
            // dta_Piker_Start
            // 
            this.dta_Piker_Start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dta_Piker_Start.Enabled = false;
            this.dta_Piker_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dta_Piker_Start.Location = new System.Drawing.Point(37, 27);
            this.dta_Piker_Start.Name = "dta_Piker_Start";
            this.dta_Piker_Start.Size = new System.Drawing.Size(233, 21);
            this.dta_Piker_Start.TabIndex = 25;
            this.dta_Piker_Start.ValueChanged += new System.EventHandler(this.dta_Piker_Start_ValueChanged);
            // 
            // dta_Piker_End
            // 
            this.dta_Piker_End.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dta_Piker_End.Enabled = false;
            this.dta_Piker_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dta_Piker_End.Location = new System.Drawing.Point(37, 74);
            this.dta_Piker_End.Name = "dta_Piker_End";
            this.dta_Piker_End.Size = new System.Drawing.Size(233, 21);
            this.dta_Piker_End.TabIndex = 27;
            this.dta_Piker_End.ValueChanged += new System.EventHandler(this.dta_Piker_End_ValueChanged);
            // 
            // lbl_Start
            // 
            this.lbl_Start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Start.AutoSize = true;
            this.lbl_Start.Location = new System.Drawing.Point(7, 31);
            this.lbl_Start.Name = "lbl_Start";
            this.lbl_Start.Size = new System.Drawing.Size(27, 13);
            this.lbl_Start.TabIndex = 28;
            this.lbl_Start.Text = "from";
            // 
            // lbl_End
            // 
            this.lbl_End.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_End.AutoSize = true;
            this.lbl_End.Location = new System.Drawing.Point(14, 80);
            this.lbl_End.Name = "lbl_End";
            this.lbl_End.Size = new System.Drawing.Size(16, 13);
            this.lbl_End.TabIndex = 29;
            this.lbl_End.Text = "to";
            // 
            // chk_EnableDataEnd
            // 
            this.chk_EnableDataEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_EnableDataEnd.AutoSize = true;
            this.chk_EnableDataEnd.Enabled = false;
            this.chk_EnableDataEnd.Location = new System.Drawing.Point(276, 78);
            this.chk_EnableDataEnd.Name = "chk_EnableDataEnd";
            this.chk_EnableDataEnd.Size = new System.Drawing.Size(15, 14);
            this.chk_EnableDataEnd.TabIndex = 30;
            this.chk_EnableDataEnd.UseVisualStyleBackColor = true;
            this.chk_EnableDataEnd.CheckedChanged += new System.EventHandler(this.chk_EnableDataEnd_CheckedChanged);
            // 
            // chk_EnableDataStart
            // 
            this.chk_EnableDataStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_EnableDataStart.AutoSize = true;
            this.chk_EnableDataStart.Location = new System.Drawing.Point(276, 31);
            this.chk_EnableDataStart.Name = "chk_EnableDataStart";
            this.chk_EnableDataStart.Size = new System.Drawing.Size(15, 14);
            this.chk_EnableDataStart.TabIndex = 31;
            this.chk_EnableDataStart.UseVisualStyleBackColor = true;
            this.chk_EnableDataStart.CheckedChanged += new System.EventHandler(this.chk_EnableDataStart_CheckedChanged);
            // 
            // PNL_filtreModify_date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chk_EnableDataStart);
            this.Controls.Add(this.lbl_End);
            this.Controls.Add(this.lbl_Start);
            this.Controls.Add(this.dta_Piker_End);
            this.Controls.Add(this.dta_Piker_Start);
            this.Controls.Add(this.chk_EnableDataEnd);
            this.Name = "PNL_filtreModify_date";
            this.Size = new System.Drawing.Size(306, 128);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DCI_Elements.AnimationComponents animationContent;
        private System.Windows.Forms.Label lbl_End;
        private System.Windows.Forms.Label lbl_Start;
        private System.Windows.Forms.DateTimePicker dta_Piker_End;
        private System.Windows.Forms.DateTimePicker dta_Piker_Start;
        private DCI_Elements.AnimationComponents animationHeader;
        private System.Windows.Forms.CheckBox chk_EnableDataEnd;
        private System.Windows.Forms.CheckBox chk_EnableDataStart;
    }
}
