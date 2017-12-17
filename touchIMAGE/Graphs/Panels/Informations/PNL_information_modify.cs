using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace touchIMAGE.Graphs.Panels.Informations
{
    public partial class PNL_information_modify : UserControl
    {
        public PNL_information_modify()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Animation Open/Close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void cmd_OpenClose_Click(object sender, EventArgs e)
        {
            if (Animation.Is_Opened)
            {
                Animation.ClosePanel();
            }
            else
            {
                Animation.OpenPanel();
            }
        }
    }
}
