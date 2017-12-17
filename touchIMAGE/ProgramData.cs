// Davide Carboni et Julien richoz
// Main data of programm
// Cretated: 13.12.2017
// Modifiy:
// v.1.0


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using XperiCode.JpegMetadata;
using touchIMAGE.Fonctions;

namespace touchIMAGE
{

    public class FiltreDate
    {
        public DateTime Date_Start;
        public DateTime Date_End;
        public Boolean IsRange = false;
    }

    public class ProgramData
    {
        public static string rootFolder = Settings.Default.RootPath;
        public static string[] filtre_Format = new[] { "*.jpg", "*.png", "*.gif", "*.bmp" };
        public static string[] filtre_Tag = new string[0];
        public static FiltreDate filtre_Date = null;
        public static Boolean filtreFavorite = false;
        public static string SelectedFolder;
        public static FileData SelectedFile;
    }

    public class FolderData: ProgramData
    {
        private string _folderFullName;
        private string _folderRealName;        
        private string _folderLastModify;
        private string[] _files;
        private int _filesCount;

        public string FolderFullName { get => _folderFullName; }
        public string FolderRealName { get => _folderRealName; }
        public string FolderLastModify { get => _folderLastModify; }
        public string[] Files { get => _files; }
        public int FilesCount { get => _filesCount; }
        
        // Get Set
        
        public void GetFiles()
        {
            // get the files with the selected filter

            if (filtreFavorite)
            {
                if (filtre_Date == null)
                {
                    if (filtre_Tag.Length == 0)
                        this._files = touchIMAGE.Fonctions.IO.getFiles(FolderFullName, filtre_Format, filtreFavorite);
                    else
                        this._files = touchIMAGE.Fonctions.IO.getFiles(this.FolderFullName, filtre_Format, filtreFavorite, filtre_Tag);
                }
                else
                {
                    if (!filtre_Date.IsRange)
                        if (filtre_Tag.Length == 0)
                            this._files = touchIMAGE.Fonctions.IO.getFiles(this.FolderFullName, filtre_Format, filtreFavorite, filtre_Date.Date_Start);
                        else
                            this._files = touchIMAGE.Fonctions.IO.getFiles(this.FolderFullName, filtre_Format, filtreFavorite, filtre_Date.Date_Start, filtre_Tag);
                    else
                        if (filtre_Tag.Length == 0)
                            this._files = touchIMAGE.Fonctions.IO.getFiles(this.FolderFullName, filtre_Format, filtreFavorite, filtre_Date.Date_Start, filtre_Date.Date_End);
                    else
                        this._files = touchIMAGE.Fonctions.IO.getFiles(this.FolderFullName, filtre_Format, filtreFavorite, filtre_Date.Date_Start, filtre_Date.Date_End, filtre_Tag);
                }
            }
            else
            {
                if (filtre_Date == null)
                {
                    if (filtre_Tag.Length == 0)
                        this._files = touchIMAGE.Fonctions.IO.getFiles(this.FolderFullName, filtre_Format);
                    else
                        this._files = touchIMAGE.Fonctions.IO.getFiles(this.FolderFullName, filtre_Format, filtre_Tag);
                }
                else
                {
                    if (!filtre_Date.IsRange)
                        if (filtre_Tag.Length == 0)
                            this._files = touchIMAGE.Fonctions.IO.getFiles(this.FolderFullName, filtre_Format, filtre_Date.Date_Start);
                        else
                            this._files = touchIMAGE.Fonctions.IO.getFiles(this.FolderFullName, filtre_Format, filtre_Tag, filtre_Date.Date_Start);
                    else
                       if (filtre_Tag.Length == 0)
                        this._files = touchIMAGE.Fonctions.IO.getFiles(this.FolderFullName, filtre_Format, filtre_Date.Date_Start, filtre_Date.Date_End);
                    else
                        this._files = touchIMAGE.Fonctions.IO.getFiles(this.FolderFullName, filtre_Format, filtre_Tag, filtre_Date.Date_Start, filtre_Date.Date_End);
                }
            }
            
            this._filesCount = Files.Length;
        }

        public FolderData(string FolderName)
        {
            this._folderFullName = FolderName;
            this._folderRealName = Fonctions.IO.getFolderName(FolderName);
            this._folderLastModify = Fonctions.IO.getLastFolderModifyData(FolderName);
        }        
    }

    public class FileData
    {
        private string _fileName;
        private Fonctions.MetaData_ReadWrite _fileMetaData;

        public string FileName { get => _fileName; set => _fileName = value; }
        public Fonctions.MetaData_ReadWrite FileMetaData { get => _fileMetaData; set => _fileMetaData = value; }

        // Verify if the file is jpeg

        private Boolean VerifyJPEG(string FilePath)
        {
            try
            {
                using (System.Drawing.Image img = System.Drawing.Image.FromFile(FilePath))
                {
                    return img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            catch (OutOfMemoryException)
            {
                return false;
            }
        }

        public FileData(string FilePath)
        {
            FileName = FilePath;
            FileMetaData = (VerifyJPEG(FilePath) ? new Fonctions.MetaData_ReadWrite(FilePath) : null);
        }
    }

    
}
