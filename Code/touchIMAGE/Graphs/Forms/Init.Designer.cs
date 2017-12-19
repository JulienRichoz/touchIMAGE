namespace touchIMAGE.Graphs.Forms
{
    partial class Init
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
            this.cmd_Init = new System.Windows.Forms.Button();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.pnl_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.lbl_TitleLogoLeft = new System.Windows.Forms.Label();
            this.lbl_TitleLogoRight = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(667, 1);
            // 
            // cmdMaximize
            // 
            this.cmdMaximize.Location = new System.Drawing.Point(621, 1);
            // 
            // cmdMinimize
            // 
            this.cmdMinimize.Location = new System.Drawing.Point(621, 1);
            // 
            // lblTitre
            // 
            this.lblTitre.Location = new System.Drawing.Point(40, 10);
            this.lblTitre.Size = new System.Drawing.Size(68, 13);
            this.lblTitre.Text = "touchIMAGE";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.BackgroundImage = global::touchIMAGE.Properties.Resources.Logo;
            this.picIcon.Location = new System.Drawing.Point(7, 3);
            // 
            // cmd_Init
            // 
            this.cmd_Init.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cmd_Init.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Init.Location = new System.Drawing.Point(173, 166);
            this.cmd_Init.Name = "cmd_Init";
            this.cmd_Init.Size = new System.Drawing.Size(140, 35);
            this.cmd_Init.TabIndex = 14;
            this.cmd_Init.Text = "Select Folder";
            this.cmd_Init.UseVisualStyleBackColor = true;
            this.cmd_Init.Click += new System.EventHandler(this.cmd_Init_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(73, 69);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(259, 70);
            this.lbl_Welcome.TabIndex = 15;
            this.lbl_Welcome.Text = "Welcome";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(120, 139);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(193, 13);
            this.lbl_Description.TabIndex = 16;
            this.lbl_Description.Text = "Select your favorite folder image to start";
            // 
            // lbl_TitleLogoLeft
            // 
            this.lbl_TitleLogoLeft.AutoSize = true;
            this.lbl_TitleLogoLeft.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleLogoLeft.ForeColor = System.Drawing.Color.Orange;
            this.lbl_TitleLogoLeft.Location = new System.Drawing.Point(344, 342);
            this.lbl_TitleLogoLeft.Name = "lbl_TitleLogoLeft";
            this.lbl_TitleLogoLeft.Size = new System.Drawing.Size(168, 70);
            this.lbl_TitleLogoLeft.TabIndex = 17;
            this.lbl_TitleLogoLeft.Text = "touch";
            // 
            // lbl_TitleLogoRight
            // 
            this.lbl_TitleLogoRight.AutoSize = true;
            this.lbl_TitleLogoRight.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleLogoRight.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_TitleLogoRight.Location = new System.Drawing.Point(492, 342);
            this.lbl_TitleLogoRight.Name = "lbl_TitleLogoRight";
            this.lbl_TitleLogoRight.Size = new System.Drawing.Size(202, 70);
            this.lbl_TitleLogoRight.TabIndex = 18;
            this.lbl_TitleLogoRight.Text = "IMAGE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(338, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 317);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ButtonMaximizeVisible = false;
            this.ClientSize = new System.Drawing.Size(713, 449);
            this.ContainerColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_TitleLogoRight);
            this.Controls.Add(this.lbl_TitleLogoLeft);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.cmd_Init);
            this.Name = "Init";
            this.Text = "Init";
            this.TitleImage = global::touchIMAGE.Properties.Resources.Logo;
            this.TitleText = "touchIMAGE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Init_FormClosed);
            this.Controls.SetChildIndex(this.picIcon, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.cmdMinimize, 0);
            this.Controls.SetChildIndex(this.cmdMaximize, 0);
            this.Controls.SetChildIndex(this.cmdClose, 0);
            this.Controls.SetChildIndex(this.cmd_Init, 0);
            this.Controls.SetChildIndex(this.lbl_Welcome, 0);
            this.Controls.SetChildIndex(this.lbl_Description, 0);
            this.Controls.SetChildIndex(this.lbl_TitleLogoLeft, 0);
            this.Controls.SetChildIndex(this.lbl_TitleLogoRight, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmd_Init;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.OpenFileDialog pnl_Dialog;
        private System.Windows.Forms.Label lbl_TitleLogoLeft;
        private System.Windows.Forms.Label lbl_TitleLogoRight;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}