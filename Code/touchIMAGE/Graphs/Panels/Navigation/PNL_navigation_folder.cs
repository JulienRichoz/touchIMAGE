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
    public partial class PNL_navigation_folder : UserControl
    {
        public PNL_navigation_folder()
        {
            InitializeComponent();
        }

        private void PNL_navigation_folder_Load(object sender, EventArgs e)
        {
            //Initialize the first size of panel root int the treeView
            this.pnl_TreeView.pnl_Root.spectreWidth.Init(this.Width - 5);
        }

        /// <summary>
        /// Resize the folder Tree View 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void pnl_Container_Resize(object sender, EventArgs e)
        {

            if (this.pnl_Container.Width > this.pnl_TreeView.Width)
                this.pnl_TreeView.pnl_Root.spectreWidth.Refresh(this.Width);
            else
            {
                this.pnl_TreeView.pnl_Root.spectreWidth.Refresh(this.Width);
                this.pnl_TreeView.pnl_Root.spectreWidth.Restore();
            }
        }
    }
}
