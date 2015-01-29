namespace pack
{
    partial class frmDlgFolder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgFolder));
            this.tv_Explorer = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_ArName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tv_Explorer
            // 
            this.tv_Explorer.ImageIndex = 0;
            this.tv_Explorer.ImageList = this.imageList1;
            this.tv_Explorer.Location = new System.Drawing.Point(-1, 2);
            this.tv_Explorer.Name = "tv_Explorer";
            this.tv_Explorer.SelectedImageIndex = 0;
            this.tv_Explorer.Size = new System.Drawing.Size(334, 363);
            this.tv_Explorer.TabIndex = 4;
            this.tv_Explorer.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tv_Explorer_BeforeExpand);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Download-Folder-icon.png");
            this.imageList1.Images.SetKeyName(1, "Upload-Folder-icon.png");
            this.imageList1.Images.SetKeyName(2, "Folder-icon.png");
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(258, 403);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(177, 403);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Назва архіву:";
            // 
            // txbx_ArName
            // 
            this.txbx_ArName.Location = new System.Drawing.Point(77, 368);
            this.txbx_ArName.Name = "txbx_ArName";
            this.txbx_ArName.Size = new System.Drawing.Size(256, 20);
            this.txbx_ArName.TabIndex = 9;
            // 
            // frmDlgFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 430);
            this.Controls.Add(this.txbx_ArName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tv_Explorer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDlgFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolderDialog";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDlgFolder_FormClosing);
            this.Load += new System.EventHandler(this.frmDlgFolder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_Explorer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_ArName;
    }
}