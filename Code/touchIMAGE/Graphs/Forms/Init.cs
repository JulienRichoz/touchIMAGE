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
    public partial class Init : Windows10
    {
        public Init()
        {
            InitializeComponent();
        }

        private Boolean IsBreak = false;

        /// <summary>
        /// Selected the main folder by user at first start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void cmd_Init_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {

                    Settings.Default.RootPath = folderDialog.SelectedPath;
                    Settings.Default.Save();
                    ProgramData.rootFolder = folderDialog.SelectedPath;
                    IsBreak = true;
                    this.Close();
                }
            }
        }


        /// <summary>
        /// Close the Init Window and close the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void Init_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsBreak)
            {
                Program.IsExit = true;
                Program.IsFolder = false;
            }
        }
    }
}
