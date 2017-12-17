
using System.IO;
using System.Text.RegularExpressions;
using XperiCode.JpegMetadata;

namespace touchIMAGE.Fonctions
{
    public class FileRename
    {
        //Function to rename File in this format: "ParentFolder_YYYY-MM-DD_HH.MM.SS"
        public static void renameFile(string parentFolder) //path have to be in format: @"C:\dir\..."
        {
            // Skip if the directory not exists
            if (!Fonctions.IO.DirectoryExsiste(parentFolder))
                return;

            string fRename = null;
            string year = null;
            string month = null;
            string day = null;
            string hour = null;
            string minute = null;
            string seconde = null;
            string correctDate = null;
            string fExt = null; //file Extension
            int i = 0;

            //Get info of the parentfolder and concatene the space
            DirectoryInfo d = new DirectoryInfo(parentFolder);
            string folder = d.Name;
            folder = Regex.Replace(folder, @"\s+", "");       //Regex is love Regex is life (by Julien Richoz parce que Davide ne veut pas avoir 2)

            //Copy all jpeg files from pathFile to files array
            FileInfo[] infos = d.GetFiles("*.jpg");
            //loop through all files
            foreach (FileInfo f in infos)
            {
                //Get the extension of the file
                fExt = Path.GetExtension(f.Name);
                //Get the date taken of the files via Metadata
                var adapter = new JpegMetadataAdapter(f.FullName);
                string dateFile = adapter.Metadata.DateTaken;

                //Sort the string date
                if (dateFile.Length > 13)
                {
                    year = dateFile.Substring(6, 4);
                    month = dateFile.Substring(3, 2);
                    day = dateFile.Substring(0, 2);
                    hour = dateFile.Substring(11, 2);
                    minute = dateFile.Substring(14, 2);
                    if (dateFile.Length > 16)
                    {
                        seconde = dateFile.Substring(17, 2);
                    }
                    else
                    {
                        seconde = null;
                    }
                    correctDate = year + "-" + month + "-" + day + "_" + hour + "." + minute;
                    if (seconde != null) correctDate += "." + seconde;
                }
                else
                {
                    i++;
                    correctDate = "NoDateTaken" + i.ToString(); //Inform the user that there is no date taken. Added +i to avoid duplication
                }

                fRename = folder + "_" + correctDate + fExt;
                string destFile = d + "\\" + fRename;
                if (!File.Exists(destFile)) File.Move(f.FullName, destFile);

            }
        }
    }
}
