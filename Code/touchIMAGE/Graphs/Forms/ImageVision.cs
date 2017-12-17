using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DCI_Elements;

namespace touchIMAGE.Graphs.Forms
{
    public partial class ImageVision : Windows10
    {
        public ImageVision()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fill the control with the selected file image and change the title in the Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ImageVision_Load(object sender, EventArgs e)
        {
            pnl_Container.BackgroundImage = Image.FromFile(ProgramData.SelectedFile.FileName);
            pnl_Container.BackgroundImageLayout = ImageLayout.Zoom;
            lblTitre.Text = Fonctions.IO.getFileName(ProgramData.SelectedFile.FileName);
        }
    }
}
