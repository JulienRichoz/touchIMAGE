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
using System.Threading;
using System.Reflection;
using touchIMAGE.Fonctions;

namespace touchIMAGE
{
    public partial class frm_Main : Windows10
    {
        public frm_Main()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Refresh All animation in the panel and create a double buffering
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void frm_Main_Load(object sender, EventArgs e)
        {
            pnl_information_container.Animation.RefreshEl();
            pnl_footer_container.Animation.RefreshEl();
            pnl_information_container.pnl_information_modify.Animation.RefreshEl();
            SetDoubleBuffering(touchIMAGE.Program.MainForm.lst_Images, true);
            SetDoubleBuffering(touchIMAGE.Program.MainForm.pnl_information_container.pnl_ContainerAutoSize, true);
        }

        /// <summary>
        /// Create a double buffering 
        /// </summary>
        /// <param name="control"></param>
        /// <param name="value"></param>

        public static void SetDoubleBuffering(System.Windows.Forms.Control control, bool value)
        {
            //Enable double buffeing for ListView Img_List to prevent the flikering 
            System.Reflection.PropertyInfo controlProperty = typeof(System.Windows.Forms.Control)
            .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            controlProperty.SetValue(control, value, null);
        }

        /// <summary>
        /// Fill the information panel when click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void lst_Images_Click(object sender, EventArgs e)
        {
            string fileName = lst_Images.Items[lst_Images.SelectedIndices[0]].ImageKey;

            // Skip if the file do nto exisist
            if (!touchIMAGE.Fonctions.IO.FileExsiste(fileName))
            {
                MessageBox.Show("File not exists");
                return;
            }

            ProgramData.SelectedFile = new FileData(fileName);
            Graphs.Controllers.InformationControlleur.PrintAllInformation(fileName);
            Program.MainForm.pnl_information_container.cmd_OpenClose.Enabled = true;
            
        }

        /// <summary>
        /// Refresh the View List
        /// </summary>

        public void RefreshImageList()
        {
            touchIMAGE.Graphs.Controllers.NavigationFolderController.RefershImageListAndHeader();
        }

        /// <summary>
        /// Open the selected image in the ImageVision Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void lst_Images_DoubleClick(object sender, EventArgs e)
        {
            Graphs.Forms.ImageVision VisionWindow = new Graphs.Forms.ImageVision();
            VisionWindow.Show();
        }
    }
}
