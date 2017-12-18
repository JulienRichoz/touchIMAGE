 using System;
using System.Linq;

using XperiCode.JpegMetadata;

namespace touchIMAGE.Fonctions
{
    /// <summary>
    /// Class to read all metaData in the selected file
    /// </summary>

    public class MetaData_ReadWrite
    {
        #region Variables

        private string fileName;
        private string[] _tags = new string[0];
        private string comment = string.Empty;
        private Boolean _favorite = false;
        private string _date;

        public string[] Tags { get => _tags; set => _tags = value; }
        public string Comment { get => comment; set => comment = value; }
        public Boolean Favorite { get => _favorite; set => _favorite = value; }
        public string Date { get => _date; set => _date = value; }

        #endregion

        #region Tags Functions

        /// <summary>
        /// Get all tags from the current file
        /// </summary>
        /// <returns></returns>

        public string[] ReadTags()
        {
            string[] tags = new string[0];

            try
            {
                var adapter = new JpegMetadataAdapter(@fileName);
                int max = adapter.Metadata.Keywords.Count();
                tags = new string[max];
                for (int i = 0; i < max; i++)
                    tags[i] = adapter.Metadata.Keywords[i];
                return tags;
            }
            catch
            {
                // tag not found
                return null;
            }

        }

        /// <summary>
        ///  Write all tags from to current file
        /// </summary>
        /// <param name="NewTags"></param>

        public void WriteTags(string[] NewTags)
        {
            try
            {
                var adapter = new JpegMetadataAdapter(@fileName);
                adapter.Metadata.Keywords.Clear();

                foreach (string tag in NewTags)
                {
                    adapter.Metadata.Keywords.Add(tag);
                }

                adapter.Save();
                Tags = NewTags;
            }
            catch
            {
                Tags = null;
            }
        }

        #endregion

        #region Comment Functions

        /// <summary>
        /// Read Comment from selected file
        /// </summary>
        /// <returns></returns>

        public string ReadComment()
        {
            try
            {
                var adapter = new JpegMetadataAdapter(@fileName);
                return adapter.Metadata.Comments;
            }
            catch
            {
                return string.Empty;
            }
        }


        /// <summary>
        /// Write Comment into selected file
        /// </summary>
        /// <param name="NewComment"></param>

        public void WriteComment(string NewComment)
        {
            try
            {
                var adapter = new JpegMetadataAdapter(@fileName);
                adapter.Metadata.Comments = NewComment;
                adapter.Save();
                Comment = NewComment;
            }
            catch
            {
                Comment = "";
            }
        }

        #endregion

        #region Date Functions

        /// <summary>
        /// Read the value of the date taken from the selected file
        /// </summary>
        /// <returns></returns>

        public string ReadDate()
        {
            try
            {
                var adapter = new JpegMetadataAdapter(@fileName);
                return adapter.Metadata.DateTaken;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Write the value of the date taken from the selected file
        /// </summary>
        /// <param name="NewDate"></param>

        public void WriteDate(DateTime NewDate)
        {
            try
            {
                var adapter = new JpegMetadataAdapter(@fileName);
                adapter.Metadata.DateTaken = NewDate.ToString();
                adapter.Save();
                Date = NewDate.ToString();
            }
            catch
            {
                Date = null;
            }
        }

        #endregion

        #region Favorite Functions

        /// <summary>
        /// Read if the file is in to favorites
        /// </summary>
        /// <returns></returns>

        public Boolean ReadFovorite()
        {
            try
            {
                var adapter = new JpegMetadataAdapter(@fileName);
                return Convert.ToBoolean(adapter.Metadata.Rating);
            }
            catch
            {
                return true;
            }
        }

        /// <summary>
        /// Add the file as favorite
        /// </summary>
        /// <param name="value"></param>

        public void WriteFavorite(Boolean value)
        {

            try
            {
                var adapter = new JpegMetadataAdapter(@fileName);

                if (value)
                    adapter.Metadata.Rating = 5;
                else
                    adapter.Metadata.Rating = 0;
                adapter.Save();

                Favorite = value;
            }
            catch
            {
                Favorite = false;
            }
        }
        #endregion

        #region Constructor

        public MetaData_ReadWrite(string FilePath)
        {
            fileName = FilePath;
            Tags = ReadTags();
            Comment = ReadComment();
            Date = ReadDate();
            Favorite = ReadFovorite();
        }

        #endregion
    }
}
