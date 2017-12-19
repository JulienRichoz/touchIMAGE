using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace touchIMAGE.Graphs.Controllers
{
    public class ListViewImageController
    {
        #region variables

        private static System.Windows.Forms.ImageList ImageList;
        private static Thread th;

        // files list in to the folder 
        private static string[] files;

        // thumbnail size
        public static int ListSizeWith = 120;
        public static int ListSizeHeight = 100;

        #endregion

        #region functions

        #region create thumbnail image

        /// <summary>
        /// Create thumbnail image
        /// </summary>
        /// <param name="width"></param>
        /// <param name="img"></param>
        /// <returns></returns>

        private static Image getThumbnaiImage(int width, Image img)
        {
            int xoffset;
            int yoffset;
            int Width;
            int Height;

            // Verify the original image size with the new thumbanil box size
            // Calculates the proportions of the image and fits it in the box

            if (img.Width < width && img.Height < width)
            {
                xoffset = (int)((width - img.Width) / 2);
                yoffset = (int)((width - img.Height) / 2);
                Width = width;
                Height = width;
            }
            else
            {
                if (img.Width == img.Height) //square image
                {
                    xoffset = 0;
                    yoffset = 0;
                    Width = width;
                    Height = width;
                }
                else
                {
                    xoffset = 0;
                    yoffset = 0;
                    Width = 0;
                    Height = 0;
                                        
                    if (img.Width < img.Height) // vertical image
                    {
                        Height = width;
                        Width = (int)(width * img.Width / img.Height);                        
                        xoffset = (int)((width - Width) / 2);
                    }

                    if (img.Width > img.Height) // horizontal image
                    {
                        Width = width;
                        Height = (int)(width * img.Height / img.Width);                        
                        yoffset = (int)((width - Height) / 2);
                    }
                }
            }

            // Change resolution and fix the new image in the box

            Bitmap thumb;

            using (var tempImage = img)
            {
                // Create the new thumbnail
                thumb = new Bitmap(width, width);
                using (Graphics g = Graphics.FromImage(thumb))
                {
                    // Fill the box with the new image
                    g.DrawImage(tempImage, xoffset, yoffset, Width, Height);
                    // Draw rectangle frame in the box
                    g.DrawRectangle(Pens.CornflowerBlue, 0, 0, thumb.Width - 1, thumb.Height - 1);
                }
            }
            return thumb;
        }

        #endregion

        #region populate

        /// <summary>
        /// Populate the listView with all thumbnail images
        /// </summary>
        /// <param name="FolderData"></param>

        public static void Populate(FolderData FolderData)
        {
            FolderData.GetFiles();
            files = FolderData.Files;         // The list of files
            StopThread();                    // Stop the execution of the thread
            ClearList();                     // Clear the current List  
            //Preview();                      // Fil the listView with the icon empty image           
            FillListViewBK();      // Fill the ListView with the real images in background 
            Fill(new object());
            return;
        }

        /// <summary>
        /// Stop the thread if is in running mode
        /// </summary>

        private static void StopThread()
        {
            if (th != null)
                if (th.ThreadState == ThreadState.Running)
                {
                    touchIMAGE.Program.MainForm.lst_Images.EndUpdate();
                    th.Abort();
                }
            return;
        }

        /// <summary>
        /// Clear the ListView
        /// </summary>

        private static void ClearList()
        {
            touchIMAGE.Program.MainForm.lst_Images.Clear();
            touchIMAGE.Program.MainForm.lst_Images.View = View.LargeIcon;
            return;
        }

        /// <summary>
        /// Start the Background thread to fill the listView
        /// </summary>
        /// 
        private static void FillListViewBK()
        {
            th = new Thread(Fill);
            //th.Priority = ThreadPriority.Highest;
            th.Start();
            return;
        }

        /// <summary>
        /// Prints a preview list of images
        /// </summary>

        private static void Preview()
        {
            // Create the list images
            ImageList = new System.Windows.Forms.ImageList();
            ImageList.ImageSize = new Size(ListSizeWith, ListSizeHeight);
            ImageList.ColorDepth = ColorDepth.Depth32Bit;

            // Assign the list images to the listView 
            touchIMAGE.Program.MainForm.lst_Images.LargeImageList = ImageList;

            // Fill the list images with the empty image icon and put it in the list view
            foreach (string file in files)
            {
                ImageList.Images.Add(file, getThumbnaiImage(ImageList.ImageSize.Width, touchIMAGE.Properties.Resources.no_image));
                touchIMAGE.Program.MainForm.lst_Images.Items.Add(file,touchIMAGE.Fonctions.IO.getFileName(file), 0);
            }

            // Refresh the listView on the screen
            touchIMAGE.Program.MainForm.lst_Images.Refresh();
            return;
        }

        /// <summary>
        /// Fill the listview with the real thumbnail image
        //  Remove the icom empty image and replace the same with the real image
        /// </summary>
        /// <param name="o"></param>

        private static void Fill(object o)
        {
            foreach (string file in files)
            {                
                touchIMAGE.Program.MainForm.lst_Images.BeginUpdate(); // Suspend the sreen update
                touchIMAGE.Program.MainForm.lst_Images.Items.RemoveByKey(file); //Remove the empty icon image form the listView
                ImageList.Images.RemoveByKey(file); // Remove the empty icon image from the list image
                ImageList.Images.Add(file, getThumbnaiImage(ImageList.ImageSize.Width, Image.FromFile(file))); // Add the real image in the same place into the listimage
                touchIMAGE.Program.MainForm.lst_Images.Items.Add(touchIMAGE.Fonctions.IO.getFileName(file), file);  // Add the new entry with the associated image in to the listView
                touchIMAGE.Program.MainForm.lst_Images.EndUpdate();// Restart the screen update
                touchIMAGE.Program.MainForm.lst_Images.Refresh();// Refresh the listview in to the screen
            }
            return;
        }
    }

    #endregion

    #endregion
}
