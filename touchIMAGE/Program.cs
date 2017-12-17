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
                    if (!Fonctions.IO.DirectoryExsiste(touchIMAGE.Settings.Default.RootPath))
                    {
                        IsFolder = true;
                        touchIMAGE.Settings.Default.RootPath = "";
                        touchIMAGE.Settings.Default.Save();
                    }
                    else
                    {
                        IsFolder = false;
                    }
                }

            }
            while (IsFolder);

            if (IsExit == false)
            {
                MainForm = new frm_Main();
                Application.Run(MainForm);
            }

        }
    }
}
