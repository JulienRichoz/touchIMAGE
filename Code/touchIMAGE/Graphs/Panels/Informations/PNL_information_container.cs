using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace touchIMAGE.Graphs.Panels.Informations
{
    public partial class PNL_information_container : UserControl
    {
        public PNL_information_container()
        {
            InitializeComponent();
        }

        private Button OldSelectedButton;

        public Graphs.Panels.ModifyMetaData.PNL_ModifyComment pnl_Comment;
        public Graphs.Panels.ModifyMetaData.PNL_ModifyDate pnl_Date;
        public Graphs.Panels.ModifyMetaData.PNL_ModifyTag pnl_Tags;

        /// <summary>
        /// Animation Open/Close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void cmd_OpenClose_Click(object sender, EventArgs e)
        {
            if (Animation.Is_Opened)
            {
                Animation.ClosePanel();
                cmd_OpenClose.BackColor = System.Drawing.Color.Transparent;
            }
            else
            {
                Animation.OpenPanel();
                cmd_OpenClose.BackColor = System.Drawing.Color.Linen;
            }
        }

        private void cmd_Comment_Click(object sender, EventArgs e)
        {
            // Skip if the file not exists
            if (!touchIMAGE.Fonctions.IO.FileExsiste(ProgramData.SelectedFile.FileName))
                return;

            // Save the current button to restore after
            EnableButton(cmd_Comment);
            pnl_information_modify.pnl_Container.Controls.Clear();
            pnl_Comment = new ModifyMetaData.PNL_ModifyComment();
            pnl_Comment.Dock = DockStyle.Fill;
            pnl_information_modify.pnl_Container.Controls.Add(pnl_Comment);
            if (!pnl_information_modify.Animation.Is_Opened) pnl_information_modify.Animation.OpenPanel();
        }

        private void cmd_Favorite_Click(object sender, EventArgs e)
        {
            // Skip if the file not exists
            if (!touchIMAGE.Fonctions.IO.FileExsiste(ProgramData.SelectedFile.FileName))
                return;

            ProgramData.SelectedFile.FileMetaData.Favorite = (ProgramData.SelectedFile.FileMetaData.Favorite ? false : true);
            ProgramData.SelectedFile.FileMetaData.WriteFavorite(ProgramData.SelectedFile.FileMetaData.Favorite);
            RefreshFavorite();
        }

        private void cmd_Date_Click(object sender, EventArgs e)
        {
            // Skip if the file not exists
            if (!touchIMAGE.Fonctions.IO.FileExsiste(ProgramData.SelectedFile.FileName))
                return;

            // Save the current button to restore after
            EnableButton(cmd_Date);
            pnl_information_modify.pnl_Container.Controls.Clear();
            pnl_Date = new ModifyMetaData.PNL_ModifyDate();
            pnl_Date.Dock = DockStyle.Fill;
            pnl_information_modify.pnl_Container.Controls.Add(pnl_Date);
            if (!pnl_information_modify.Animation.Is_Opened) pnl_information_modify.Animation.OpenPanel();
        }

        private void cmd_Tags_Click(object sender, EventArgs e)
        {
            // Skip if the file not exists
            if (!touchIMAGE.Fonctions.IO.FileExsiste(ProgramData.SelectedFile.FileName))
                return;

            // Save the current button to restore after
            EnableButton(cmd_Tags);
            pnl_information_modify.pnl_Container.Controls.Clear();
            pnl_Tags = new ModifyMetaData.PNL_ModifyTag();
            pnl_Tags.Dock = DockStyle.Fill;
            pnl_information_modify.pnl_Container.Controls.Add(pnl_Tags);
            if (!pnl_information_modify.Animation.Is_Opened) pnl_information_modify.Animation.OpenPanel();
        }

        public void RefreshFavorite()
        {
            cmd_Favorite.BackgroundImage = (ProgramData.SelectedFile.FileMetaData.Favorite ? Properties.Resources.del_favorite : Properties.Resources.add_favorite);
        }

        public void EnableButtonsMetaData()
        {
            cmd_Comment.Enabled = true;
            cmd_Date.Enabled = true;
            cmd_Favorite.Enabled = true;
            cmd_Tags.Enabled = true;
        }

        public void DisableButtonsMetaData()
        {
            cmd_Comment.Enabled = false;
            cmd_Date.Enabled = false;
            cmd_Favorite.Enabled = false;
            cmd_Tags.Enabled = false;
        }

        // Change Background image when button is selected

        private void EnableButton(Button btn)
        {
            //Restore the old button if necessary

            if (OldSelectedButton != null)
                RestoreButton(OldSelectedButton);
            
            // save the current button
            OldSelectedButton = btn;

            Image background = null;

            // select the new background image for the selected button
            switch (btn.Name)
            {
                case "cmd_Comment": background = Properties.Resources.add_commSelected; break;
                case "cmd_Date": background = Properties.Resources.add_dateSelected; break;
                case "cmd_Tags": background = Properties.Resources.add_tagSelected; break;
                default: background = btn.BackgroundImage; break;
            }

            btn.BackgroundImage = background;
        }


        // Restore old background image when a new button is selected

        private void RestoreButton(Button btn)
        {
            Image background = null;

            // select the old background image for the old button
            switch (btn.Name)
            {
                case "cmd_Comment": background = Properties.Resources.add_comm; break;
                case "cmd_Date": background = Properties.Resources.add_date; break;
                case "cmd_Tags": background = Properties.Resources.add_tag; break;
                default: background = btn.BackgroundImage; break;
            }

            btn.BackgroundImage = background;
        }

    }
}
