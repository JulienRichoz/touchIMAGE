using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace touchIMAGE.Graphs.Panels.ModifyMetaData
{
    public partial class PNL_ModifyDate : UserControl
    {

        #region Constructor

        public PNL_ModifyDate()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        // Read all informations onload

        private void PNL_ModifyDate_Load(object sender, EventArgs e)
        {
            // Read and Fill the data
            ReadAndFill();
        }

        // Close the control

        private void cmd_Abort_Click(object sender, EventArgs e)
        {
            Program.MainForm.pnl_information_container.pnl_information_modify.Animation.ClosePanel();
        }

        // Write the new data in the file and refresh all elements

        private void cmd_Modify_Click(object sender, EventArgs e)
        {
            ProgramData.SelectedFile.FileMetaData.WriteDate (dta_DateTaken.Value.ToString());
            ReadAndFill();
        }

        #endregion

        #region Class functions

        // Read the date from the selected file and fill the control

        private void ReadAndFill()
        {
            if (ProgramData.SelectedFile.FileMetaData.Date != "")
            {
                dta_DateTaken.Value = Convert.ToDateTime(ProgramData.SelectedFile.FileMetaData.Date);
                lbl_FlashMessage.Visible = false;
            }
            else
                lbl_FlashMessage.Visible = true;
        }

        // Refresh the date in the control

        public void RefreshDate()
        {
            ReadAndFill();
        }

        #endregion     
        
    }
}
