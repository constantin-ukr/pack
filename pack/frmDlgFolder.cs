using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pack
{
    public partial class frmDlgFolder : Form
    {
        private String _path;
        private String _defaultPath;
        private String _extension;

        public String PathWhereToPack
        {
            get
            {
                return _path;
            }
        }

        public string Extension
        {
            set { _extension = value; }
        }


        private void CreateFirstNode()
        {
            List<string> listNode = new List<string>();

            listNode.AddRange(Program.webServiceClient.GetFolders(Program.realPath));

            List<TreeNode> coll = new List<TreeNode>();

            foreach (var str in listNode)
            {
                TreeNode tNode = new TreeNode(str, 0, 2);
                tNode.Nodes.Add(new TreeNode("..."));
                coll.Add(tNode);
            }

            TreeNode startNode = new TreeNode(Program.realPath, 0, 2);
            startNode.Nodes.AddRange(coll.ToArray());

            tv_Explorer.Nodes.Add(startNode);
        }

        public frmDlgFolder()
        {
            InitializeComponent();
        }


        public frmDlgFolder(String path)
            : this()
        {
            _defaultPath = path;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbx_ArName.Text.TrimEnd()))
            {
                txbx_ArName.Text = String.Format("temp{0}", DateTime.Now.ToShortDateString());
            }

            _path = tv_Explorer.SelectedNode.FullPath + "\\" + txbx_ArName.Text + "." +
                _extension;
            DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            _path = String.Empty;
            DialogResult = DialogResult.Cancel;
        }

        private void frmDlgFolder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                _path = String.Empty;
                DialogResult = DialogResult.Cancel;
            }
        }

        private void frmDlgFolder_Load(object sender, EventArgs e)
        {
            CreateFirstNode();

            FindPath(_defaultPath);

            txbx_ArName.Text = String.Format("temp{0}.{1:00}.{2:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        private void tv_Explorer_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeView tr = sender as TreeView;

            if (tr == null)
                return;

            string Fullpath = string.Empty;

            if (tr.Nodes.Count > 0)
                Fullpath = e.Node.FullPath;

            List<string> listNode = new List<string>();

            listNode.AddRange(Program.webServiceClient.GetFolders(Fullpath));

            List<TreeNode> coll = new List<TreeNode>();

            foreach (var str in listNode)
            {
                TreeNode tNode = new TreeNode(str, 0, 2);
                tNode.Nodes.Add(new TreeNode("..."));
                coll.Add(tNode);
            }

            e.Node.Nodes.Clear();
            e.Node.Nodes.AddRange(coll.ToArray());

            tr.SelectedNode = new TreeNode(e.Node.FullPath, 0, 2);
        }

        private void FindPath(String path)
        {
            string[] nodes = path.Split('\\');

            nodes[1] = nodes[0] + "\\" + nodes[1];
            tv_Explorer.BeforeExpand += tv_Explorer_BeforeExpand;

            tv_Explorer.SelectedNode = tv_Explorer.TopNode;

            if (nodes[1] != tv_Explorer.TopNode.Text)
                return;
            tv_Explorer.SelectedNode.Expand();
            

            for (int i = 2; i < nodes.Length - 1; i++)
            {
                TreeNodeCollection coll = tv_Explorer.SelectedNode.Nodes;

                foreach (TreeNode item in coll)
                {
                    if (item.Text == nodes[i])
                    {
                        tv_Explorer.SelectedNode = item;
                        break;
                    } 
                }

                tv_Explorer.SelectedNode.Expand();
            }
        }
    }
}
