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
    public partial class PNL_ModifyComment : UserControl
    {
        #region Constructor

        public PNL_ModifyComment()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void PNL_ModifyComment_Load(object sender, EventArgs e)
        {
            //Load all comments for the selected file and fill the control
            ReadAndFill();
        }

        // Close the control

        private void cmd_Abort_Click(object sender, EventArgs e)
        {
            Program.MainForm.pnl_information_container.pnl_information_modify.Animation.ClosePanel();
        }

        // refresh the commnet and write the value in the file

        private void cmd_Modify_Click(object sender, EventArgs e)
        {
            ProgramData.SelectedFile.FileMetaData.WriteComment(rch_Comment.Text);
        }

        #endregion

        #region Class functions


        // Read the comment from file and fill the control

        private void ReadAndFill()
        {
            rch_Comment.Clear();
            rch_Comment.Text = ProgramData.SelectedFile.FileMetaData.Comment;
        }

        // Refresh the control 

        public void RefreshComment()
        {
            ReadAndFill();
        }

        #endregion

        
    }
}
