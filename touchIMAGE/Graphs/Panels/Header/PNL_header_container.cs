using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace touchIMAGE.Graphs.Panels.Header
{
    public partial class PNL_header_container : UserControl
    {
        public PNL_header_container()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Rename all file in the selected folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void lnk_FilesRename_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Rename all file in the selected directory
            touchIMAGE.Fonctions.FileRename.renameFile(ProgramData.SelectedFolder);
            // refresh the view
            touchIMAGE.Graphs.Controllers.NavigationFolderController.RefershImageListAndHeader();

        }
    }
}
