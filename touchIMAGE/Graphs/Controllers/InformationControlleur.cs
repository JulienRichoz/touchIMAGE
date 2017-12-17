using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetadataExtractor;
using System.Drawing;

namespace touchIMAGE.Graphs.Controllers
{
    class InformationControlleur
    {

        /// <summary>
        /// Set all informations in the information panel
        /// </summary>
        /// <param name="FilePath"></param>

        public static void PrintAllInformation(string FilePath)
        {
            ImagePrintInformation(FilePath);

            // Disable buttons controls if is not a JPG file

            if (ProgramData.SelectedFile.FileMetaData != null)
            {
                PrintAllInformationInPanelsMetaDataModify(FilePath);
                Program.MainForm.pnl_information_container.EnableButtonsMetaData();
                RefresFavorite();
            }
            else
            {
                Program.MainForm.pnl_information_container.DisableButtonsMetaData();
            }
        }

        /// <summary>
        /// Refresh the value of the favorite
        /// </summary>

        private static void RefresFavorite()
        {
            Program.MainForm.pnl_information_container.RefreshFavorite();
        }

        /// <summary>
        /// Refresh all values in the modify panels 
        /// </summary>
        /// <param name="FilePath"></param>

        private static void PrintAllInformationInPanelsMetaDataModify(string FilePath)
        {
            if (Program.MainForm.pnl_information_container.pnl_Tags != null)
                Program.MainForm.pnl_information_container.pnl_Tags.RefreshTags();

            if (Program.MainForm.pnl_information_container.pnl_Comment != null)
                Program.MainForm.pnl_information_container.pnl_Comment.RefreshComment();

            if (Program.MainForm.pnl_information_container.pnl_Date != null)
                Program.MainForm.pnl_information_container.pnl_Date.RefreshDate();

        }

        /// <summary>
        /// Set and Print all file metaData informations list in the infomration panel
        /// </summary>
        /// <param name="FilePathName"></param>

        private static void ImagePrintInformation(string FilePathName)
        {
            var directories = ImageMetadataReader.ReadMetadata(FilePathName);
            int HeihtPosition = 0;

            // Clear all controls to init
            touchIMAGE.Program.MainForm.pnl_information_container.pnl_ContainerAutoSize.Controls.Clear();
            
            // Title Image
            Program.MainForm.pnl_information_container.lbl_FileName.Text = Fonctions.IO.getFileName(FilePathName);

            // Image Preview
            Image img;
            using (var bmpTemp = new Bitmap(FilePathName))
            {
                img = new Bitmap(bmpTemp);
            }

            Program.MainForm.pnl_information_container.pic_Preview.BackgroundImage = img;
            


            // All metaData informations
            foreach (var directory in directories)
                foreach (var tag in directory.Tags)
                {
                    if (!(tag.Name.Contains("Unknown tag")))
                    {
                        System.Windows.Forms.Label TagName = new System.Windows.Forms.Label();
                        System.Windows.Forms.Label TagDescription = new System.Windows.Forms.Label();


                        // Prepare MetaData Name
                        TagName.AutoSize = true;
                        TagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        TagName.Location = new System.Drawing.Point(0, HeihtPosition);
                        TagName.Text = tag.Name + ":";


                        // Prepare MetaData Description
                        TagDescription.AutoSize = true;
                        TagDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        TagDescription.AutoSize = false;
                        TagDescription.AutoEllipsis = true;


                        // Fill the controls with all informations
                        if (tag.Description != null)
                        {
                            TagDescription.Text = tag.Description.ToString();
                            touchIMAGE.Program.MainForm.pnl_information_container.pnl_ContainerAutoSize.Controls.Add(TagName);
                            TagDescription.Location = new System.Drawing.Point(TagName.Width, HeihtPosition);
                            TagDescription.Size = new System.Drawing.Size(touchIMAGE.Program.MainForm.pnl_information_container.Animation.Size - TagName.Width - 30 , 15);
                            touchIMAGE.Program.MainForm.pnl_information_container.pnl_ContainerAutoSize.Controls.Add(TagDescription);
                            HeihtPosition += 20;
                        }
                    }
                }
            return;
        }
    }
}
