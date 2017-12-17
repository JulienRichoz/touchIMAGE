namespace touchIMAGE.Graphs.Panels.Informations
{
    partial class PNL_information_modify
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
            this.Animation = new DCI_Elements.AnimationComponents();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Animation
            // 
            this.Animation.Animation = DCI_Elements.AnimationComponents.ANIMATION.Dinamic;
            this.Animation.CloseBearingSize = 3;
            this.Animation.CloseSpeed = 1;
            this.Animation.CloseStep = 35;
            this.Animation.Is_Opened = false;
            this.Animation.Is_Operating = false;
            this.Animation.Magnetic = false;
            this.Animation.Object = this;
            this.Animation.OnLoad = DCI_Elements.AnimationComponents.ON_LOAD.Is_Closed;
            this.Animation.OpenBearingSize = 3;
            this.Animation.OpenSpeed = 1;
            this.Animation.OpenStep = 35;
            this.Animation.Position = DCI_Elements.AnimationComponents.POSITION.In_The_Bottom;
            this.Animation.Size = 180;
            // 
            // pnl_Container
            // 
            this.pnl_Container.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 1);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(240, 250);
            this.pnl_Container.TabIndex = 10;
            // 
            // PNL_information_modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.pnl_Container);
            this.Name = "PNL_information_modify";
            this.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Size = new System.Drawing.Size(240, 252);
            this.ResumeLayout(false);

        }

        #endregion
        public DCI_Elements.AnimationComponents Animation;
        public System.Windows.Forms.Panel pnl_Container;
    }
}
