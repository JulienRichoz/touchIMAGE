using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace touchIMAGE.Graphs.Controllers
{
    public class NavigationFolderController
    {        
        /// <summary>
        /// Fill and Refresh the ListViewImages in the Main Program and refresh the header
        /// </summary>

        public static void RefershImageListAndHeader()
        {

            // Skip if the folder do not exsist
            if (!touchIMAGE.Fonctions.IO.DirectoryExsiste(ProgramData.SelectedFolder))
            {
                MessageBox.Show("Error! File or Folder not exist");
                return;
            }

            FolderData folder = new FolderData(ProgramData.SelectedFolder);
            // List View Immages
            Graphs.Controllers.ListViewImageController.Populate(folder);
            //Header
            Graphs.Controllers.HeaderController.RefreshHeader(folder);
        }
    }
}
