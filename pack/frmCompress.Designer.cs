namespace pack
{
    partial class frmCompress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompress));
            this.tv_Explorer = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbx_FilesToCompress = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_kickItem = new System.Windows.Forms.Button();
            this.chbx_IsUsePassword = new System.Windows.Forms.CheckBox();
            this.grbx_Password = new System.Windows.Forms.GroupBox();
            this.txbx_Password = new System.Windows.Forms.TextBox();
            this.chbx_visiblePassword = new System.Windows.Forms.CheckBox();
            this.btn_runPack = new System.Windows.Forms.Button();
            this.cb_ComprLevel = new System.Windows.Forms.ComboBox();
            this.cb_ArFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_ComprMethod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbxDelFilesAfterZip = new System.Windows.Forms.CheckBox();
            this.grbx_Password.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv_Explorer
            // 
            this.tv_Explorer.ImageIndex = 0;
            this.tv_Explorer.ImageList = this.imageList1;
            this.tv_Explorer.Location = new System.Drawing.Point(3, 3);
            this.tv_Explorer.Name = "tv_Explorer";
            this.tv_Explorer.SelectedImageIndex = 0;
            this.tv_Explorer.Size = new System.Drawing.Size(438, 355);
            this.tv_Explorer.TabIndex = 0;
            this.tv_Explorer.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tv_Explorer_BeforeExpand);
            this.tv_Explorer.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Explorer_NodeMouseClick);
            this.tv_Explorer.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Explorer_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Download-Folder-icon.png");
            this.imageList1.Images.SetKeyName(1, "Folder-icon.png");
            this.imageList1.Images.SetKeyName(2, "script-minus-icon-icon.png");
            this.imageList1.Images.SetKeyName(3, "7zipOk.png");
            // 
            // lbx_FilesToCompress
            // 
            this.lbx_FilesToCompress.FormattingEnabled = true;
            this.lbx_FilesToCompress.Location = new System.Drawing.Point(3, 364);
            this.lbx_FilesToCompress.Name = "lbx_FilesToCompress";
            this.lbx_FilesToCompress.ScrollAlwaysVisible = true;
            this.lbx_FilesToCompress.Size = new System.Drawing.Size(560, 147);
            this.lbx_FilesToCompress.TabIndex = 1;
            this.lbx_FilesToCompress.SelectedIndexChanged += new System.EventHandler(this.lbx_FilesToCompress_SelectedIndexChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(454, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(109, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Додати файл";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_kickItem
            // 
            this.btn_kickItem.Image = ((System.Drawing.Image)(resources.GetObject("btn_kickItem.Image")));
            this.btn_kickItem.Location = new System.Drawing.Point(507, 489);
            this.btn_kickItem.Name = "btn_kickItem";
            this.btn_kickItem.Size = new System.Drawing.Size(34, 22);
            this.btn_kickItem.TabIndex = 4;
            this.btn_kickItem.UseVisualStyleBackColor = true;
            this.btn_kickItem.Click += new System.EventHandler(this.btn_kickItem_Click);
            // 
            // chbx_IsUsePassword
            // 
            this.chbx_IsUsePassword.AutoSize = true;
            this.chbx_IsUsePassword.Location = new System.Drawing.Point(447, 208);
            this.chbx_IsUsePassword.Name = "chbx_IsUsePassword";
            this.chbx_IsUsePassword.Size = new System.Drawing.Size(124, 17);
            this.chbx_IsUsePassword.TabIndex = 5;
            this.chbx_IsUsePassword.Text = "Встановити пароль";
            this.chbx_IsUsePassword.UseVisualStyleBackColor = true;
            this.chbx_IsUsePassword.CheckedChanged += new System.EventHandler(this.chbx_IsUsePassword_CheckedChanged);
            // 
            // grbx_Password
            // 
            this.grbx_Password.Controls.Add(this.txbx_Password);
            this.grbx_Password.Controls.Add(this.chbx_visiblePassword);
            this.grbx_Password.Location = new System.Drawing.Point(448, 231);
            this.grbx_Password.Name = "grbx_Password";
            this.grbx_Password.Size = new System.Drawing.Size(115, 70);
            this.grbx_Password.TabIndex = 6;
            this.grbx_Password.TabStop = false;
            this.grbx_Password.Text = "Пароль";
            // 
            // txbx_Password
            // 
            this.txbx_Password.Location = new System.Drawing.Point(6, 43);
            this.txbx_Password.MaxLength = 10;
            this.txbx_Password.Name = "txbx_Password";
            this.txbx_Password.PasswordChar = '*';
            this.txbx_Password.Size = new System.Drawing.Size(104, 20);
            this.txbx_Password.TabIndex = 1;
            // 
            // chbx_visiblePassword
            // 
            this.chbx_visiblePassword.AutoSize = true;
            this.chbx_visiblePassword.Location = new System.Drawing.Point(7, 20);
            this.chbx_visiblePassword.Name = "chbx_visiblePassword";
            this.chbx_visiblePassword.Size = new System.Drawing.Size(75, 17);
            this.chbx_visiblePassword.TabIndex = 0;
            this.chbx_visiblePassword.Text = "Показати";
            this.chbx_visiblePassword.UseVisualStyleBackColor = true;
            this.chbx_visiblePassword.CheckedChanged += new System.EventHandler(this.chbx_visiblePassword_CheckedChanged);
            // 
            // btn_runPack
            // 
            this.btn_runPack.Location = new System.Drawing.Point(454, 335);
            this.btn_runPack.Name = "btn_runPack";
            this.btn_runPack.Size = new System.Drawing.Size(109, 23);
            this.btn_runPack.TabIndex = 7;
            this.btn_runPack.Text = "Упакувати";
            this.btn_runPack.UseVisualStyleBackColor = true;
            this.btn_runPack.Click += new System.EventHandler(this.btn_runPack_Click);
            // 
            // cb_ComprLevel
            // 
            this.cb_ComprLevel.FormattingEnabled = true;
            this.cb_ComprLevel.Location = new System.Drawing.Point(454, 102);
            this.cb_ComprLevel.Name = "cb_ComprLevel";
            this.cb_ComprLevel.Size = new System.Drawing.Size(109, 21);
            this.cb_ComprLevel.TabIndex = 11;
            // 
            // cb_ArFormat
            // 
            this.cb_ArFormat.FormattingEnabled = true;
            this.cb_ArFormat.Location = new System.Drawing.Point(454, 51);
            this.cb_ArFormat.Name = "cb_ArFormat";
            this.cb_ArFormat.Size = new System.Drawing.Size(109, 21);
            this.cb_ArFormat.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Тип архіву:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Рівень стиснення:";
            // 
            // cb_ComprMethod
            // 
            this.cb_ComprMethod.FormattingEnabled = true;
            this.cb_ComprMethod.Location = new System.Drawing.Point(454, 157);
            this.cb_ComprMethod.Name = "cb_ComprMethod";
            this.cb_ComprMethod.Size = new System.Drawing.Size(109, 21);
            this.cb_ComprMethod.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Метод стиснення:";
            // 
            // chbxDelFilesAfterZip
            // 
            this.chbxDelFilesAfterZip.AutoSize = true;
            this.chbxDelFilesAfterZip.Location = new System.Drawing.Point(447, 307);
            this.chbxDelFilesAfterZip.Name = "chbxDelFilesAfterZip";
            this.chbxDelFilesAfterZip.Size = new System.Drawing.Size(108, 17);
            this.chbxDelFilesAfterZip.TabIndex = 16;
            this.chbxDelFilesAfterZip.Text = "видалити файли";
            this.chbxDelFilesAfterZip.UseVisualStyleBackColor = true;
            // 
            // frmCompress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 518);
            this.Controls.Add(this.chbxDelFilesAfterZip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_ComprMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_ComprLevel);
            this.Controls.Add(this.cb_ArFormat);
            this.Controls.Add(this.btn_runPack);
            this.Controls.Add(this.grbx_Password);
            this.Controls.Add(this.chbx_IsUsePassword);
            this.Controls.Add(this.btn_kickItem);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbx_FilesToCompress);
            this.Controls.Add(this.tv_Explorer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompress";
            this.Text = "frmCommpress";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCompress_FormClosed);
            this.Load += new System.EventHandler(this.frmCompress_Load);
            this.grbx_Password.ResumeLayout(false);
            this.grbx_Password.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_Explorer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox lbx_FilesToCompress;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.CheckBox chbx_IsUsePassword;
        private System.Windows.Forms.GroupBox grbx_Password;
        private System.Windows.Forms.TextBox txbx_Password;
        private System.Windows.Forms.CheckBox chbx_visiblePassword;
        private System.Windows.Forms.Button btn_runPack;
        private System.Windows.Forms.ComboBox cb_ComprLevel;
        private System.Windows.Forms.ComboBox cb_ArFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_kickItem;
        private System.Windows.Forms.ComboBox cb_ComprMethod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbxDelFilesAfterZip;
    }
}