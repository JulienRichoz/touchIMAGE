using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace touchIMAGE.Graphs.Panels.Navigation
{
    public partial class PNL_navigation_filtre : UserControl
    {
        public PNL_navigation_filtre()
        {
            InitializeComponent();
        }

        PNL_filtreModify_date pnl_filtreDate = new PNL_filtreModify_date();
        PNL_filtreModify_format pnl_filtreFormat = new PNL_filtreModify_format();
        PNL_filtreModify_tag pnl_filtreTag = new PNL_filtreModify_tag();

        private Button OldSelectedButton;

        private void cmd_Format_Click(object sender, EventArgs e)
        {
            EnableButton(cmd_Format);
            AddControl(pnl_filtreFormat);
        }

        private void cmd_Tags_Click(object sender, EventArgs e)
        {
            EnableButton(cmd_Tags);
            AddControl(pnl_filtreTag);
        }

        private void cmd_Date_Click(object sender, EventArgs e)
        {
            EnableButton(cmd_Date);
            AddControl(pnl_filtreDate);
        }

        private void AddControl(UserControl panel)
        {
            // Clear the container controls
            pnl_FiltreContainer.Controls.Clear();
            // Add the selected control
            panel.Dock = DockStyle.Fill;
            pnl_FiltreContainer.Controls.Add(panel);

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
                case "cmd_Format": background = Properties.Resources.add_commSelected; break;
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
                case "cmd_Format": background = Properties.Resources.add_comm; break;
                case "cmd_Date": background = Properties.Resources.add_date; break;
                case "cmd_Tags": background = Properties.Resources.add_tag; break;
                default: background = btn.BackgroundImage; break;
            }

            btn.BackgroundImage = background;
        }

        private void cmd_Favorite_Click(object sender, EventArgs e)
        {
            if (ProgramData.filter_Favorite)
            {
                cmd_Favorite.BackgroundImage = Properties.Resources.add_favorite;
                ProgramData.filter_Favorite = false;
            }
            else
            {

                cmd_Favorite.BackgroundImage = Properties.Resources.del_favorite;
                ProgramData.filter_Favorite = true;
            }

            touchIMAGE.Graphs.Controllers.NavigationFolderController.RefershImageListAndHeader();

        }
    }
}
