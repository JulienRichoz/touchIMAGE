using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace touchIMAGE.Graphs.Panels.ModifyMetaData
{
    public partial class PNL_ModifyTag : UserControl
    {
        public PNL_ModifyTag()
        {
            InitializeComponent();
        }

        #region Onload

        private void PNL_ModifyTag_Load(object sender, EventArgs e)
        {
            //Load Current Tags and fill the control
            ReadAndFill();
        }

        #endregion
                
        #region Events Fonctions

        // Check if the Add buitton must be enabled
        // Is enabled if exsiste value in the text control

        private void txt_Value_TextChanged(object sender, EventArgs e)
        {            
            cmd_Add.Enabled = (txt_Value.TextLength != 0 ? true : false);
        }

        // Check if the Del button must be enabled
        // Is enabled if list items is not empty

        private void lst_Items_SelectedIndexChanged(object sender, EventArgs e)
        {            
            cmd_Del.Enabled = (lst_Items.Items.Count != 0 ? true : false);
        }

        // Delete the selected items in the list by button

        private void cmd_Del_Click(object sender, EventArgs e)
        {
            lst_Items.Items.Remove(lst_Items.SelectedItem);
        }

        // Add the new tag in the list by button

        private void cmd_Add_Click(object sender, EventArgs e)
        {
            AddItems();
        }

        // Remove selected tag in the list by Keyboard

        private void lst_Items_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) && (cmd_Del.Enabled))
            {
                lst_Items.Items.Remove(lst_Items.SelectedItem);
            }
        }

        // Add a new tag in the list by Keyboar

        private void txt_Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)(Keys.Enter)) && (cmd_Add.Enabled))
            {
                AddItems();
            }
        }

        #endregion

        #region class fonctions

        // Check if the new tag is not in the list

        private Boolean ItemVerify(string value)
        {
            return lst_Items.Items.Contains(value) ? true : false;
        }

        // RegEx for the new tags

        private string ItemFiltre(string value)
        {
            return Regex.Replace(value, "[^a-zA-Z]+", "");
        }

        // Read the tags in the selected file and fill the control

        private void ReadAndFill()
        {
            lst_Items.Items.Clear();
            foreach (string tag in ProgramData.SelectedFile.FileMetaData.Tags)
                lst_Items.Items.Add(tag);
        }

        //Refreah all tags in the controls for the selected file

        public void RefreshTags()
        {
            ReadAndFill();
        }

        // Verify and add a new items in the liss

        private void AddItems()
        {
            if (!ItemVerify(ItemFiltre(txt_Value.Text)))
                lst_Items.Items.Add(ItemFiltre(txt_Value.Text));
            txt_Value.Text = "";
        }


        #endregion

        // Close the control tag

        private void cmd_Abort_Click(object sender, EventArgs e)
        {
            Program.MainForm.pnl_information_container.pnl_information_modify.Animation.ClosePanel();
        }

        // Add the new tags in the file

        private void cmd_Modify_Click(object sender, EventArgs e)
        {
            string[] NewTags = new string[lst_Items.Items.Count];

            int i = 0;
            foreach (string item in lst_Items.Items)
            {
                NewTags[i] = item;
                i++;
            }

            ProgramData.SelectedFile.FileMetaData.WriteTags(NewTags);
        }
    }
}
