using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace touchIMAGE
{
    static class Program
    {
        public static frm_Main MainForm;

        public static Boolean IsFolder = false;
        public static Boolean IsExit = false;
        public static Boolean ChangeFolder = false;

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            do
            {


                if (touchIMAGE.Settings.Default.RootPath == "")
                {
                    IsFolder = true;
                    touchIMAGE.Graphs.Forms.Init Init = new Graphs.Forms.Init();
                    Application.Run(Init);                    
                }
                else
                {
                    if ((!Fonctions.IO.DirectoryExsiste(touchIMAGE.Settings.Default.RootPath)) || (ChangeFolder))
                    {
                        IsFolder = true;
                        touchIMAGE.Settings.Default.RootPath = "";
                        touchIMAGE.Settings.Default.Save();
                        ChangeFolder = false;
                    }
                    else
                    {
                        IsFolder = false;
                    }
                }

                if ( (IsFolder == false) && (!IsExit))
                {
                    MainForm = new frm_Main();
                    Application.Run(MainForm);
                    if (ChangeFolder)
                        IsExit = false;
                }

            }

            while (!IsExit);

            

        }
    }
}
