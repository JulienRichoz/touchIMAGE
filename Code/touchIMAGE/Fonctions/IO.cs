using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace touchIMAGE.Fonctions
{
    public class IO
    {
        /// <summary>
        /// Get the files form the selected directory
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <returns></returns>

        public static string[] getFiles(string FolderPath)
        {
            return Directory.GetFiles(FolderPath);
        }


        /// <summary>
        /// Get the files from the selected directory that match the filter
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <param name="Format"></param>
        /// <returns></returns>

        public static string[] getFiles(string FolderPath, string[] Format)
        {
            string[] filesIMages = Format.SelectMany(f => Directory.GetFiles(FolderPath, f)).ToArray();
            List<string> newListFiles = new List<string>();
            foreach (string file in filesIMages)
            {
                if (IsImageFile(file))
                    if (!newListFiles.Contains(file))
                        newListFiles.Add(file);
            }

            return newListFiles.ToArray();
        }

        /// <summary>
        /// Get the files from the selected directory that match the filter
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <param name="Format"></param>
        /// <param name="Tags"></param>
        /// <returns></returns>

        public static string[] getFiles(string FolderPath, string[] Format, string[] Tags)
        {
            string[] filesToSearch = getFiles(FolderPath, Format);
            List<string> newListFiles = new List<string>();

            foreach (string file in filesToSearch)
            {
                Fonctions.MetaData_ReadWrite metadata = new MetaData_ReadWrite(file);

                if (metadata.Tags != null) // no tags available (not jpeg)
                {
                    foreach (string tag in metadata.Tags)
                        if (Array.Exists(Tags, element => element == tag))
                            if (!newListFiles.Contains(file))
                                newListFiles.Add(file);
                }
                else
                    newListFiles.Add(file);
            }            
            
            return newListFiles.ToArray();
        }

        /// <summary>
        /// Get the files from the selected directory that match the filter
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>

        private static Boolean DateCompare(DateTime t1, DateTime t2)
        {
            int result = DateTime.Compare(t1, t2);

            if (result > 0)
                return true;
            if (result < 0)
                return false;

            return false;
        }

        /// <summary>
        /// Get the files from the selected directory that match the filter
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <param name="Format"></param>
        /// <param name="Tags"></param>
        /// <param name="Date"></param>
        /// <returns></returns>

        public static string[] getFiles(string FolderPath, string[] Format, string[] Tags,  DateTime Date)
        {
            string[] filesToSearch = getFiles(FolderPath, Format);
            List<string> newListFiles = new List<string>();

            foreach (string file in filesToSearch)
            {
                Fonctions.MetaData_ReadWrite metadata = new MetaData_ReadWrite(file);

                if (metadata.Tags != null) // no tags available
                {
                    foreach (string tag in metadata.Tags)
                        if (Array.Exists(Tags, element => element == tag))
                            if (metadata.Date != "") // no date available (not jpeg)
                            {
                                if (DateCompare(Convert.ToDateTime(metadata.Date), Date))
                                    if (!newListFiles.Contains(file))
                                        newListFiles.Add(file);
                            }
                            else
                            {
                                if (!newListFiles.Contains(file))
                                        newListFiles.Add(file);
                            }
                }
                else
                    newListFiles.Add(file);

            }
            return newListFiles.ToArray();
        }

        /// <summary>
        /// Get the files from the selected directory that match the filter
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <param name="Format"></param>
        /// <param name="Tags"></param>
        /// <param name="DateStart"></param>
        /// <param name="DateEnd"></param>
        /// <returns></returns>


        public static string[] getFiles(string FolderPath, string[] Format, string[] Tags, DateTime DateStart, DateTime DateEnd)
        {
            string[] filesToSearch = getFiles(FolderPath, Format);
            List<string> newListFiles = new List<string>();

            foreach (string file in filesToSearch)
            {
                Fonctions.MetaData_ReadWrite metadata = new MetaData_ReadWrite(file);

                if (metadata.Tags != null) // no tags available
                {

                    foreach (string tag in metadata.Tags)
                        if (Array.Exists(Tags, element => element == tag))
                            if (metadata.Date != "") // no date available 
                            {
                                if ((DateCompare(Convert.ToDateTime(metadata.Date), DateStart)) && (!DateCompare(Convert.ToDateTime(metadata.Date), DateEnd)))
                                    if (!newListFiles.Contains(file))
                                        newListFiles.Add(file);
                            }
                            else
                            {
                                if (!newListFiles.Contains(file))
                                    newListFiles.Add(file);
                            }
                }
                else
                    newListFiles.Add(file);

            }

            return newListFiles.ToArray();
        }

        /// <summary>
        /// Get the files from the selected directory that match the filter
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <param name="Format"></param>
        /// <param name="Date"></param>
        /// <returns></returns>


        public static string[] getFiles(string FolderPath, string[] Format, DateTime Date)
        {
            string[] filesToSearch = getFiles(FolderPath, Format);
            List<string> newListFiles = new List<string>();

            foreach (string file in filesToSearch)
            {
                Fonctions.MetaData_ReadWrite metadata = new MetaData_ReadWrite(file);

                if (metadata.Date != "") // no date available 
                {
                    if (DateCompare(Convert.ToDateTime(metadata.Date), Date))
                        newListFiles.Add(file);
                }
                else
                {
                    newListFiles.Add(file);
                }
            }
            

            return newListFiles.ToArray();
        }


        /// <summary>
        /// Get the files from the selected directory that match the filter
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <param name="Format"></param>
        /// <param name="DateStart"></param>
        /// <param name="DateEnd"></param>
        /// <returns></returns>


        public static string[] getFiles(string FolderPath, string[] Format, DateTime DateStart, DateTime DateEnd)
        {
            string[] filesToSearch = getFiles(FolderPath, Format);
            List<string> newListFiles = new List<string>();

            foreach (string file in filesToSearch)
            {
                Fonctions.MetaData_ReadWrite metadata = new MetaData_ReadWrite(file);

                if (metadata.Date != "") // no date availablle
                {
                    if ((DateCompare(Convert.ToDateTime(metadata.Date), DateStart)) && (!DateCompare(Convert.ToDateTime(metadata.Date), DateEnd)))
                        newListFiles.Add(file);
                }
                else
                {
                    newListFiles.Add(file);
                }
            }

            return newListFiles.ToArray();
        }

        /// <summary>
        /// Get the files from the selected directory that match the filter
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <param name="Format"></param>
        /// <param name="Favorite"></param>
        /// <returns></returns>


        public static string[] getFiles(string FolderPath, string[] Format, Boolean Favorite)
        {
            string[] filesToSearch = getFiles(FolderPath, Format);
            List<string> newListFiles = new List<string>();
            
            foreach (string file in filesToSearch)
            {
                Fonctions.MetaData_ReadWrite metadata = new MetaData_ReadWrite(file);
                if (metadata.Favorite)
                    newListFiles.Add(file);
            }

            return newListFiles.ToArray();
        }

        /// <summary>
        /// Get the files from the selected directory that match the filter
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <param name="Format"></param>
        /// <param name="Favorite"></param>
        /// <param name="Tags"></param>
        /// <returns></returns>

        public static string[] getFiles(string FolderPath, string[] Format, Boolean Favorite, string[] Tags)
        {
            string[] filesToSearch = getFiles(FolderPath, Format);
            List<string> newListFiles = new List<string>();

            foreach (string file in filesToSearch)
            {
                Fonctions.MetaData_ReadWrite metadata = new MetaData_ReadWrite(file);

                if (metadata.Tags != null) // no tags available (not jpeg)
                {

                    foreach (string tag in metadata.Tags)
                        if ((Array.Exists(Tags, element => element == tag)) && (metadata.Favorite))
                            if (!newListFiles.Contains(file))
                                newListFiles.Add(file);
                }
                else
                    newListFiles.Add(file);

            }

            return newListFiles.ToArray();
        }

        /// <summary>
        /// Get the files from the selected directory that match the filter
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <param name="Format"></param>
        /// <param name="Favorite"></param>
        /// <param name="Date"></param>
        /// <returns></returns>

        public static string[] getFiles(string FolderPath, string[] Format, Boolean Favorite, DateTime Date)
        {
            string[] filesToSearch = getFiles(FolderPath, Format);
            List<string> newListFiles = new List<string>();

            foreach (string file in filesToSearch)
            {
                Fonctions.MetaData_ReadWrite metadata = new MetaData_ReadWrite(file);

                if (metadata.Date != "") // no date available
                {
                    if ( (DateCompare(Convert.ToDateTime(metadata.Date), Date))  && (metadata.Favorite) )
                        newListFiles.Add(file);
                }
                else
                {
                    if (metadata.Favorite)
                        newListFiles.Add(file);
                }
            }


            return newListFiles.ToArray();
        }

        /// <summary>
        /// Get the files from the selected directory that match the filter
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <param name="Format"></param>
        /// <param name="Favorite"></param>
        /// <param name="DateStart"></param>
        /// <param name="DateEnd"></param>
        /// <returns></returns>

        public static string[] getFiles(string FolderPath, string[] Format, Boolean Favorite, DateTime DateStart, DateTime DateEnd)
        {
            string[] filesToSearch = getFiles(FolderPath, Format);
            List<string> newListFiles = new List<string>();

            foreach (string file in filesToSearch)
            {
                Fonctions.MetaData_ReadWrite metadata = new MetaData_ReadWrite(file);

                if (metadata.Date != "") // no date available 
                {
                    if ((DateCompare(Convert.ToDateTime(metadata.Date), DateStart)) && (!DateCompare(Convert.ToDateTime(metadata.Date), DateEnd)) && (metadata.Favorite) )
                        newListFiles.Add(file);
                }
                else
                {
                    if (metadata.Favorite)
                        newListFiles.Add(file);
                }
            }

            return newListFiles.ToArray();
        }

        /// <summary>
        /// Get the files from the selected directory that match the filter
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <param name="Format"></param>
        /// <param name="Favorite"></param>
        /// <param name="DateStart"></param>
        /// <param name="DateEnd"></param>
        /// <param name="tags"></param>
        /// <returns></returns>

        public static string[] getFiles(string FolderPath, string[] Format, Boolean Favorite, DateTime DateStart, DateTime DateEnd, string[] Tags)
        {
            string[] filesToSearch = getFiles(FolderPath, Format);
            List<string> newListFiles = new List<string>();

            foreach (string file in filesToSearch)
            {
                Fonctions.MetaData_ReadWrite metadata = new MetaData_ReadWrite(file);

                if (metadata.Tags != null) // no tags available (not jpeg)
                {

                    foreach (string tag in metadata.Tags)
                    {
                        if (Array.Exists(Tags, element => element == tag))
                        {
                            if (metadata.Date != "") // no date available
                            {
                                if ((DateCompare(Convert.ToDateTime(metadata.Date), DateStart)) && (!DateCompare(Convert.ToDateTime(metadata.Date), DateEnd)) && (metadata.Favorite))
                                    newListFiles.Add(file);
                            }
                            else
                            {
                                if (metadata.Favorite)
                                    newListFiles.Add(file);
                            }
                        }
                    }
                }
                else
                    newListFiles.Add(file);
            }

            return newListFiles.ToArray();
        }

        /// <summary>
        /// Get the files from the selected directory that match the filter
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <param name="Format"></param>
        /// <param name="Favorite"></param>
        /// <param name="Date"></param>
        /// <returns></returns>

        public static string[] getFiles(string FolderPath, string[] Format, Boolean Favorite, DateTime Date, string[] Tags)
        {
            string[] filesToSearch = getFiles(FolderPath, Format);
            List<string> newListFiles = new List<string>();

            foreach (string file in filesToSearch)
            {
                Fonctions.MetaData_ReadWrite metadata = new MetaData_ReadWrite(file);

                if (metadata.Tags != null) // no tags available (not jpeg)
                {

                    foreach (string tag in metadata.Tags)
                    {
                        if (Array.Exists(Tags, element => element == tag))
                        {

                            if (metadata.Date != "") // no date available
                            {
                                if ((DateCompare(Convert.ToDateTime(metadata.Date), Date)) && (metadata.Favorite))
                                    if (!newListFiles.Contains(file))
                                        newListFiles.Add(file);
                            }
                            else
                            {
                                if (metadata.Favorite)
                                    if (!newListFiles.Contains(file))
                                        newListFiles.Add(file);
                            }
                        }
                    }
                }
                else
                    newListFiles.Add(file);
            }


            return newListFiles.ToArray();
        }

        /// <summary>
        /// Get the real Name from the selected file
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns></returns>

        public static string getFileName(string FilePath)
        {
            FileInfo info = new FileInfo(FilePath);

            return info.Name;
        }


        /// <summary>
        /// Get the directiries from the selected folder
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <returns></returns>

        public static string[] getDirectories(string FolderPath)
        {
            return Directory.GetDirectories(FolderPath);
        }

        /// <summary>
        /// Get the real name from the selected directory
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <returns></returns>

        public static string getFolderName(string FolderPath)
        {
            DirectoryInfo info = new DirectoryInfo(FolderPath);

            return info.Name.ToString();
        }

        /// <summary>
        /// Get the folder Parent name from the selected directory
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <returns></returns>

        public static string getFolderParentName(string FolderPath)
        {
            return Directory.GetParent(FolderPath).FullName;
        }

        /// <summary>
        /// Get the last folder modify data from the selected directory
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <returns></returns>

        public static string getLastFolderModifyData(string FolderPath)
        {
            return Directory.GetLastWriteTime(FolderPath).ToString();
        }


        /// <summary>
        /// Check if the directory exsite
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <returns></returns>

        public static Boolean DirectoryExsiste(string FolderPath)
        {
            return Directory.Exists(FolderPath);
        }


        /// <summary>
        /// Check if the file exsite
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns></returns>
        public static Boolean FileExsiste(string FilePath)
        {
            FileInfo info = new FileInfo(FilePath);

            return info.Exists;
        }


        /// <summary>
        /// Check if the file is an image
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>


        public static Boolean IsImageFile(string FileName)
        {
            try
            {
                System.Drawing.Image imgInput = System.Drawing.Image.FromFile(FileName);
                System.Drawing.Graphics gInput = System.Drawing.Graphics.FromImage(imgInput);
                System.Drawing.Imaging.ImageFormat thisFormat = imgInput.RawFormat;
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
