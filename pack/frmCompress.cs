using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using pack.Palau;

namespace pack
{
    public partial class frmCompress : Form
    {
        private void AddItemToListFiles()
        {
            if (tv_Explorer.SelectedNode.Nodes.Count != 0)
                return;

            string fullPath =
                tv_Explorer.SelectedNode.FullPath.Replace(Program.virtualDisk, Program.realPath);

            if (!lbx_FilesToCompress.Items.Contains(fullPath.Replace(Program.virtualDisk, Program.realPath)))
            {
                lbx_FilesToCompress.Items.Add(fullPath);
            }
            else
            {
                lbx_FilesToCompress.SelectedItem = fullPath;
            }
        }

        private void FirstNodeTreeView()
        {
            List<string> listNode = new List<string>();

            listNode.AddRange(Program.webServiceClient.GetFolders(Program.realPath));

            List<TreeNode> coll = new List<TreeNode>();

            foreach (var str in listNode)
            {
                TreeNode tNode = new TreeNode(str, 0, 1);
                tNode.Nodes.Add(new TreeNode("..."));
                coll.Add(tNode);
            }

            listNode.Clear();
            listNode.AddRange(Program.webServiceClient.GetFiles(Program.realPath));

            foreach (var str in listNode)
            {
                TreeNode tNode = new TreeNode(str, 2, 3);
                coll.Add(tNode);
            }

            TreeNode startNode = new TreeNode(Program.realPath);
            startNode.Nodes.AddRange(coll.ToArray());

            tv_Explorer.Nodes.Add(startNode);
        }

        private void RunClient()
        {
            Boolean isRun =
               (from pr in Process.GetProcesses()
                where pr.ProcessName == "ClientZipUnZip"
                select pr.ProcessName).ToList().Count <= 1 ? false : true;

            if (!isRun)
            {
                if (File.Exists(Application.StartupPath + "\\ClientZipUnZip.exe"))
                {
                    Process pr = new Process();
                    pr.StartInfo.UseShellExecute = true;
                    pr.StartInfo.FileName = Application.StartupPath + "\\ClientZipUnZip.exe";
                    pr.Start();
                }
            }

        }

        private void OnInit(String[] args)
        {
            grbx_Password.Visible = false;
            txbx_Password.PasswordChar = '*';
            lbx_FilesToCompress.Items.AddRange(
                (from item in args
                 select item.Replace(Program.virtualDisk, Program.realPath)).ToArray());

            try
            {
                cb_ArFormat.DataSource = GetSettingFormatAndLevel("ArFormat");
                cb_ComprLevel.DataSource = GetSettingFormatAndLevel("ComprLevel");
                cb_ComprMethod.DataSource = GetSettingFormatAndLevel("ComprMethod");
                
                cb_ComprLevel.SelectedIndex = 4;
                cb_ComprMethod.SelectedIndex = 2;
                cb_ArFormat.SelectedIndex = 0;
            }
            catch (Exception eX)
            {

                MessageBox.Show(eX.Message);
            }

            btn_kickItem.Enabled = false;
            btn_runPack.Enabled = true;
        }

        public frmCompress(string[] args)
        {
            InitializeComponent();
            RunClient();
            OnInit(args);
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
                TreeNode tNode = new TreeNode(str, 0, 1);
                tNode.Nodes.Add(new TreeNode("..."));
                coll.Add(tNode);
            }

            listNode.Clear();
            listNode.AddRange(Program.webServiceClient.GetFiles(Fullpath));

            foreach (var str in listNode)
            {
                TreeNode tNode = new TreeNode(str, 2, 3);
                coll.Add(tNode);

            }
            e.Node.Nodes.Clear();
            e.Node.Nodes.AddRange(coll.ToArray());

            tr.SelectedNode = new TreeNode(e.Node.FullPath, 0, 1);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddItemToListFiles();
        }

        private void frmCompress_Load(object sender, EventArgs e)
        {
            FirstNodeTreeView();
        }

        private void tv_Explorer_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            AddItemToListFiles();
        }

        private void btn_kickItem_Click(object sender, EventArgs e)
        {
            try
            {
                lbx_FilesToCompress.Items.RemoveAt(lbx_FilesToCompress.SelectedIndex);
            }
            catch (Exception) { }
        }

        private void chbx_IsUsePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_IsUsePassword.Checked)
                grbx_Password.Visible = true;
            else
            {
                grbx_Password.Visible = false;
                txbx_Password.Text = "";
            }
        }

        private void chbx_visiblePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_visiblePassword.Checked)
            {
                txbx_Password.PasswordChar = new char();
            }
            else
            {
                txbx_Password.PasswordChar = '*';
            }
        }

        private void btn_runPack_Click(object sender, EventArgs e)
        {
            if (lbx_FilesToCompress.Items.Count < 1)
                return;

            string item = lbx_FilesToCompress.Items.OfType<String>().ToList().Last();

            frmDlgFolder frmDlg = new frmDlgFolder(item);
            frmDlg.Extension = (cb_ArFormat.Text.ToLower() == "sevenzip") ? "7z" : cb_ArFormat.Text.ToLower();
            if (frmDlg.ShowDialog() != DialogResult.OK)
                return;

            String pathOut =
                String.Format("{0}", frmDlg.PathWhereToPack);

            Palau.ArrayOfString aos = new Palau.ArrayOfString();
            aos.AddRange(lbx_FilesToCompress.Items.OfType<String>());

            Program.webServiceClient.Zip(cb_ArFormat.Text, cb_ComprLevel.Text, cb_ComprMethod.Text, pathOut, txbx_Password.Text, Program.userIP, chbxDelFilesAfterZip.Checked, aos);

            try
            {
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\n" + Ex.InnerException.Message, "From Dispose");
            }

        }

        private List<String> GetSettingFormatAndLevel(String name)
        {
            /*var query =
                (from list in
                     from keyList in ConfigurationManager.AppSettings.AllKeys
                     where keyList.StartsWith(name)
                     select keyList
                 select ConfigurationManager.AppSettings.GetValues(list)).ToArray();*/

            RegistryKey key = Registry.CurrentUser.OpenSubKey(Program.settingskey);

            var query = from s in key.GetValueNames()
                        where s.StartsWith(name)
                        select s;

            List<string> type = new List<string>();

            /*for (int i = 0; i < query.Length; i++)
            {
                type.Add(query[i][0]);
            }*/

            foreach (var item in query)
            {
                type.Add(key.GetValue(item).ToString());
            }

            return type;
        }

        private void lbx_FilesToCompress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_FilesToCompress.SelectedItem != null)
                btn_kickItem.Enabled = true;
            else
                btn_kickItem.Enabled = false;
        }

        private void tv_Explorer_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.Text = e.Node.FullPath;
        }

        private void frmCompress_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
