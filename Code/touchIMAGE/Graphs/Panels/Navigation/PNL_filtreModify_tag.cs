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

namespace touchIMAGE.Graphs.Panels.Navigation
{
    public partial class PNL_filtreModify_tag : UserControl
    {
        public PNL_filtreModify_tag()
        {
            InitializeComponent();
        }

        private List<string> tags;

        private void txt_Value_TextChanged(object sender, EventArgs e)
        {
            cmd_Add.Enabled = (txt_Value.TextLength != 0 ? true : false);
        }

        private void cmd_Add_Click(object sender, EventArgs e)
        {
            AddItems();
        }

        private void PNL_FiltreModify_Load(object sender, EventArgs e)
        {
            cmd_Del.Enabled = (lst_Selected.Items.Count != 0 ? true : false);
        }

        private void cmd_Del_Click(object sender, EventArgs e)
        {
            RemoveItems();
        }

        private void lst_Selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd_Del.Enabled = (lst_Selected.Items.Count != 0 ? true : false);
        }

        private void txt_Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)(Keys.Enter)) && (cmd_Add.Enabled))
                AddItems();
        }

        private void lst_Selected_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) && (cmd_Del.Enabled))
                RemoveItems();
        }

        private Boolean ItemVerify(string value)
        {
            return lst_Selected.Items.Contains(value) ? true : false;
        }

        private string ItemFiltre(string value)
        {
            return Regex.Replace(value, "[^a-zA-Z]+", "");
        }

        private void AddItems()
        {
            if (!ItemVerify(ItemFiltre(txt_Value.Text)))
            {
                lst_Selected.Items.Add(ItemFiltre(txt_Value.Text));
                RefreshViewImages();
            }
            txt_Value.Text = "";
        }

        private void RemoveItems()
        {
            lst_Selected.Items.Remove(lst_Selected.SelectedItem);
            RefreshViewImages();
        }

        public void LoadData()
        {
            tags = new List<string>();

            foreach (string value in lst_Selected.Items)
                tags.Add(value);

            ProgramData.filter_Tag =  tags.ToArray();
            Program.MainForm.RefreshImageList();
        }

        private void RefreshViewImages()
        {
            LoadData();
        }

    }
}
