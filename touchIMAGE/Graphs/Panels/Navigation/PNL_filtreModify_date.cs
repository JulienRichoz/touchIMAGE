using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace touchIMAGE.Graphs.Panels.Navigation
{
    public partial class PNL_filtreModify_date : UserControl
    {
        public PNL_filtreModify_date()
        {
            InitializeComponent();
        }

        private FiltreDate dates;

        /// <summary>
        /// Load / Syncronise all values with the Main Variables
        /// </summary>

        public void LoadData()
        {
            dates = new FiltreDate();

            if (chk_EnableDataStart.Checked)
            {
                dates = new FiltreDate();
                dates.Date_Start = dta_Piker_Start.Value;

                if (chk_EnableDataEnd.Enabled && chk_EnableDataEnd.Checked)
                {
                    dates.Date_End = dta_Piker_End.Value;
                    dates.IsRange = true;
                }
                else
                {
                    dates.Date_End = dta_Piker_Start.Value;
                    dates.IsRange = false;
                }
            }
            else
                dates = null;

            ProgramData.filter_Date = dates;

            Program.MainForm.RefreshImageList();
        }

        /// <summary>
        /// Enable disable selection if checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void chk_EnableDataEnd_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_EnableDataEnd.Checked)
                dta_Piker_End.Enabled = true;
            else
                dta_Piker_End.Enabled = false;

            RefreshViewImages();
        }

        /// <summary>
        /// Enable data End if the data Start is checked and modify limit value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void chk_EnableDataStart_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_EnableDataStart.Checked)
            {
                dta_Piker_Start.Enabled = true;
                chk_EnableDataEnd.Enabled = true;
                if (chk_EnableDataEnd.Enabled && chk_EnableDataEnd.Checked)
                    dta_Piker_End.Enabled = true;
            }
            else
            {
                dta_Piker_Start.Enabled = false;
                chk_EnableDataEnd.Enabled = false;
                dta_Piker_End.Enabled = false;
            }

            RefreshViewImages();
        }

        /// <summary>
        /// Change the min data limit 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void dta_Piker_Start_ValueChanged(object sender, EventArgs e)
        {
            dta_Piker_End.Value = dta_Piker_End.MinDate = dta_Piker_Start.Value;
            RefreshViewImages();
        }

        /// <summary>
        /// Refresh all values
        /// </summary>

        private void RefreshViewImages()
        {
            LoadData();
        }

        private void dta_Piker_End_ValueChanged(object sender, EventArgs e)
        {
            RefreshViewImages();
        }
    }
}

