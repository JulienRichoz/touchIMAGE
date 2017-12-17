using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace touchIMAGE.Graphs.Panels.Footer
{
    public partial class PNL_footer_container : UserControl
    {
        public PNL_footer_container()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open close animation
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

        /// <summary>
        /// Change the size of thumbnailImage in the List View Image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void trk_ImageSize_Scroll(object sender, EventArgs e)
        {
            int Width = 0;
            int Height = 0;

            Width = trk_ImageSize.Value;
            Height = Width - (Width/100) * 20;

            touchIMAGE.Graphs.Controllers.ListViewImageController.ListSizeWith = Width;
            touchIMAGE.Graphs.Controllers.ListViewImageController.ListSizeHeight = Height;

            if ( (Width % 25) == 0)
                touchIMAGE.Graphs.Controllers.NavigationFolderController.RefershImageListAndHeader();
        }
    }
}
