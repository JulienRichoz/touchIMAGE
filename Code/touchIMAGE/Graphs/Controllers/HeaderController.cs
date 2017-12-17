using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace touchIMAGE.Graphs.Controllers
{
    public class HeaderController
    {
        /// <summary>
        /// Refresh all values in the Header
        /// </summary>
        /// <param name="FolderData"></param>
        
        public static void RefreshHeader(FolderData FolderData)
        {
            Program.MainForm.pnl_header_container.lbl_FolderName.Text = FolderData.FolderRealName;
            Program.MainForm.pnl_header_container.lbl_Description.Text = "Last Write: " + FolderData.FolderLastModify;
            Program.MainForm.pnl_header_container.lbl_FileNumber.Text = "Files: " + FolderData.FilesCount;
            return;
        }
    }
}
