using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace touchIMAGE.Graphs.Classes.FolderView
{
    public partial class PNL_Folder : UserControl
    {
        public PNL_Folder()
        {
            InitializeComponent();
            this.folderName = ProgramData.rootFolder; 
            this.lbl_FolderName.Text = Fonctions.IO.getFolderName(ProgramData.rootFolder);
            root = this;
            inside = 0;
            spectreWidth = new SpectreWidth();
        }

        public PNL_Folder(string FolderName, int insider)
        {
            InitializeComponent();
            this.folderName = FolderName;
            this.lbl_FolderName.Text = Fonctions.IO.getFolderName(FolderName);
            inside = insider + 1;
            root.spectreWidth.AddElement(this);
        }

        private static PNL_Folder root;
        public int inside;

        public SpectreWidth spectreWidth;
        private Boolean Is_Selected;
        private Boolean Is_Opened = false;
        private static PNL_Folder currentFolder = null;
        private PNL_Folder[] subPanels;
        private string folderName;

        static readonly Color SELECTED_NODE_BACK_COLOR = System.Drawing.Color.CornflowerBlue;
        static readonly Color LEAVE_NODE_BACK_COLOR = System.Drawing.Color.White;

        /// <summary>
        /// Change style when Mouse Enter in the folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Node_MouseEnter(object sender, EventArgs e)
        {
            // Change the backcolor of the controls
            pic_Folder.BackColor = SELECTED_NODE_BACK_COLOR;
            lbl_FolderName.BackColor = SELECTED_NODE_BACK_COLOR;
            pnl_Node.BackColor = SELECTED_NODE_BACK_COLOR;
        }

        /// <summary>
        /// Change style when mouse leave the folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void Node_MouseLeave(object sender, EventArgs e)
        {
            // Change backcolor when leave the controls 
            lbl_FolderName.BackColor = LEAVE_NODE_BACK_COLOR;
            pnl_Node.BackColor = LEAVE_NODE_BACK_COLOR;
            pic_Folder.BackColor = LEAVE_NODE_BACK_COLOR;
        }

        /// <summary>
        /// Change status of the control in selected or not selected when folder image is clicked
        /// </summary>
        /// <returns></returns>
        /// 

        private Boolean ChangeState()
        {
            if (Is_Selected)
            {
                if ((currentFolder != null) && (currentFolder.folderName == this.folderName))
                {
                    pic_Folder.BackgroundImage = touchIMAGE.Properties.Resources.folder_Blue_Selected;
                    if (Is_Opened)
                    {
                        root.spectreWidth.DeleteElement(this);
                        this.pnl_Children.Controls.Clear();
                        Is_Opened = false;
                    }
                    return false;
                }

                if (!Is_Opened)
                {
                    pic_Folder.BackgroundImage = touchIMAGE.Properties.Resources.folder_Blue;
                }

                root.spectreWidth.DeleteElement(this);
                this.pnl_Children.Controls.Clear();
                Is_Opened = false;
                return false;
            }
            else
            {
                pic_Folder.BackgroundImage = touchIMAGE.Properties.Resources.folder_Blue_Selected;
                return true;
            }
        }

        /// <summary>
        /// Change the focus in the treeView if the folder selected is not the same
        /// </summary>

        private void DeselectedCurrentFolder()
        {
            pic_Folder.BackgroundImage = touchIMAGE.Properties.Resources.folder_Blue;
            Is_Selected = false;
        }

        /// <summary>
        /// Create sub folder panel and change the node status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         
        private void Node_MouseClick(object sender, EventArgs e)
        {
            if ((currentFolder != null) && (folderName != currentFolder.folderName))
            {
                currentFolder.DeselectedCurrentFolder();
            }

            if (Is_Selected)
            {
                Is_Selected = ChangeState();
            }
            else
            {              
                ProgramData.SelectedFolder = folderName;

                // Skip if the directory do not exsist
                if (!touchIMAGE.Fonctions.IO.DirectoryExsiste(ProgramData.SelectedFolder))
                {
                    MessageBox.Show("Folder not exists");
                    return;
                }

                // Control View
                touchIMAGE.Graphs.Controllers.NavigationFolderController.RefershImageListAndHeader();

                if (!Is_Opened) createPanels();
                Is_Selected = ChangeState();
                currentFolder = this;
            }
        }

        /// <summary>
        /// Create the sub directory for the selected folder
        /// </summary>
        /// 
        private void createPanels()
        {
            string[] subDir = new string[0];

            try
            {
                subDir = touchIMAGE.Fonctions.IO.getDirectories(ProgramData.SelectedFolder);
            }
            catch
            {
                subDir = new string[0];
            }

            if (subDir.Length == 0)
                    return;

            this.Is_Opened = true;

            this.subPanels = new PNL_Folder[subDir.Length];

            for (int i = subDir.Length - 1; i >= 0; i--)
            {
                this.subPanels[subDir.Length - 1 - i] = new PNL_Folder(subDir[i], this.inside);
                this.subPanels[subDir.Length - 1 - i].Dock = DockStyle.Top;
                this.subPanels[subDir.Length - 1 - i].BackColor = System.Drawing.Color.Transparent;
            }

            this.pnl_Children.Controls.AddRange(this.subPanels);
        }

        /// <summary>
        /// Find the max lenght of the folder and resize the control if necessary
        /// </summary>

        public class SpectreWidth
        {
            private List<int> _peacksValues;
            private List<string> _peacksKey;

            private int _mainSize;

            public List<int> PeacksValue
            {
                get { return _peacksValues; }
                set { _peacksValues = value; }
            }

            public List<string> PeacksKey
            {
                get { return _peacksKey; }
                set { _peacksKey = value; }
            }

            public int MainSize
            {
                get { return _mainSize; }
                set
                {
                    _mainSize = value;
                    root.Parent.Width = value;
                }
            }

            public int Max
            {
                get
                {
                    if (_peacksValues.Count != 0)
                        return _peacksValues.Max();
                    else
                        return MainSize;
                }
            }

            private int GetSize(PNL_Folder panel)
            {
                return (panel.inside * 10) + panel.pic_Folder.Width + panel.lbl_FolderName.Width + 10;
            }

            public void AddElement(PNL_Folder panel)
            {
                int size = GetSize(panel);
                _peacksValues.Add(GetSize(panel));
                _peacksKey.Add(panel.folderName);
                Resize();
                return;
            }

            public void DeleteElement(PNL_Folder panel)
            {
                foreach (PNL_Folder moment in panel.pnl_Children.Controls)
                {
                    string key = moment.folderName;
                    int index = _peacksKey.IndexOf(key);
                    _peacksValues.RemoveAt(index);
                    _peacksKey.RemoveAt(index);
                    DeleteElement(moment);
                }

                Resize();
                return;
            }

            private void Resize()
            {
                root.Parent.Width = Max;
                //Program.MainForm.pnl_navigation_container.pnl_navigation_folder.Refresh();
            }

            public void Init(int value)
            {
                PeacksKey.Add(root.folderName);
                PeacksValue.Add(value);
            }

            public void Refresh(int value)
            {
                if (PeacksValue.Count != 0)
                {
                    PeacksValue[0] = value;
                    Resize();
                }
            }

            public void Restore()
            {
                if (PeacksValue.Count != 0)
                {
                    Resize();
                }
            }

                public SpectreWidth()
            {
                _peacksValues = new List<int>();
                _peacksKey = new List<string>();
            }
        }
    }


}

