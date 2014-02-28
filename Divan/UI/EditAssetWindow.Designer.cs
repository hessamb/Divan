namespace Divan
{
    partial class EditAssetWindow
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("زیردارایی ۱.۱.۱");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("زیردارایی ۱.۱", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("زیردارایی ۱.۲");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("زیردارایی ۱.۳.۱");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("زیردارایی ۱.۳", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("زیردارایی ۱", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("زیردارایی ۲.۱");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("زیردارایی ۲", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("زیردارایی ۳");
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSearchtxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.subAssets = new System.Windows.Forms.GroupBox();
            this.subAssetsTree = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.attachmentList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.propsGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.removeSubAssetBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteFileBut = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.subAssets.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(23, 22, 23, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12, 11, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(494, 605);
            this.flowLayoutPanel1.TabIndex = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSearchtxt);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.checkedListBox2);
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 172);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "برچسب‌ها:";
            // 
            // labelSearchtxt
            // 
            this.labelSearchtxt.Location = new System.Drawing.Point(8, 46);
            this.labelSearchtxt.Name = "labelSearchtxt";
            this.labelSearchtxt.Size = new System.Drawing.Size(222, 22);
            this.labelSearchtxt.TabIndex = 2;
            this.labelSearchtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(128, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 14);
            this.label14.TabIndex = 4;
            this.label14.Text = "برچسب‌های دیگر:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(274, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 14);
            this.label13.TabIndex = 4;
            this.label13.Text = "برچسب‌های تعریف‌گر نوع دارایی:";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "برچسب ۱",
            "برچسب ۲",
            "برچسب ۳",
            "برچسب ۴",
            "برچسب ۵",
            "برچسب ۶",
            "برچسب ۷"});
            this.checkedListBox2.Location = new System.Drawing.Point(8, 75);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(222, 89);
            this.checkedListBox2.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "خودرو",
            "ساختمان",
            "سند",
            "طلب مالی"});
            this.checkedListBox1.Location = new System.Drawing.Point(238, 41);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(221, 123);
            this.checkedListBox1.TabIndex = 1;
            // 
            // subAssets
            // 
            this.subAssets.Controls.Add(this.removeSubAssetBut);
            this.subAssets.Controls.Add(this.button1);
            this.subAssets.Controls.Add(this.subAssetsTree);
            this.subAssets.Location = new System.Drawing.Point(232, -1);
            this.subAssets.Name = "subAssets";
            this.subAssets.Size = new System.Drawing.Size(235, 173);
            this.subAssets.TabIndex = 3;
            this.subAssets.TabStop = false;
            this.subAssets.Text = "زیردارایی‌ها:";
            // 
            // subAssetsTree
            // 
            this.subAssetsTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subAssetsTree.Location = new System.Drawing.Point(6, 22);
            this.subAssetsTree.Name = "subAssetsTree";
            treeNode1.Name = "Node6";
            treeNode1.Text = "زیردارایی ۱.۱.۱";
            treeNode2.Name = "Node3";
            treeNode2.Text = "زیردارایی ۱.۱";
            treeNode3.Name = "Node4";
            treeNode3.Text = "زیردارایی ۱.۲";
            treeNode4.Name = "Node7";
            treeNode4.Text = "زیردارایی ۱.۳.۱";
            treeNode5.Name = "Node5";
            treeNode5.Text = "زیردارایی ۱.۳";
            treeNode6.Name = "Node0";
            treeNode6.Text = "زیردارایی ۱";
            treeNode7.Name = "Node8";
            treeNode7.Text = "زیردارایی ۲.۱";
            treeNode8.Name = "Node1";
            treeNode8.Text = "زیردارایی ۲";
            treeNode9.Name = "Node2";
            treeNode9.Text = "زیردارایی ۳";
            this.subAssetsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode8,
            treeNode9});
            this.subAssetsTree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subAssetsTree.RightToLeftLayout = true;
            this.subAssetsTree.Size = new System.Drawing.Size(221, 114);
            this.subAssetsTree.TabIndex = 1;
            this.subAssetsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.subAssetsTree.Enter += new System.EventHandler(this.subAssetsTree_Leave);
            this.subAssetsTree.Leave += new System.EventHandler(this.subAssetsTree_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.attachmentList);
            this.groupBox3.Controls.Add(this.deleteFileBut);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Location = new System.Drawing.Point(8, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 169);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "فایل‌های ضمیمه:";
            // 
            // attachmentList
            // 
            this.attachmentList.FormattingEnabled = true;
            this.attachmentList.ItemHeight = 14;
            this.attachmentList.Location = new System.Drawing.Point(8, 21);
            this.attachmentList.Name = "attachmentList";
            this.attachmentList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.attachmentList.Size = new System.Drawing.Size(204, 116);
            this.attachmentList.TabIndex = 1;
            this.attachmentList.SelectedIndexChanged += new System.EventHandler(this.attachmentList_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(12, 560);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 34);
            this.panel2.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.propsGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات اولیه:";
            // 
            // propsGrid
            // 
            this.propsGrid.AllowUserToAddRows = false;
            this.propsGrid.AllowUserToDeleteRows = false;
            this.propsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.value});
            this.propsGrid.Location = new System.Drawing.Point(7, 24);
            this.propsGrid.Name = "propsGrid";
            this.propsGrid.ReadOnly = true;
            this.propsGrid.RowHeadersVisible = false;
            this.propsGrid.Size = new System.Drawing.Size(452, 150);
            this.propsGrid.TabIndex = 13;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 46;
            // 
            // value
            // 
            this.value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value.HeaderText = "مقدار";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.subAssets);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(12, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 175);
            this.panel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button3.Image = global::Divan.Properties.Resources.accept;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(101, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 25);
            this.button3.TabIndex = 1;
            this.button3.Text = "تایید";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button4.Image = global::Divan.Properties.Resources.cross;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(7, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 25);
            this.button4.TabIndex = 2;
            this.button4.Text = "انصراف";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // removeSubAssetBut
            // 
            this.removeSubAssetBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeSubAssetBut.Enabled = false;
            this.removeSubAssetBut.Image = global::Divan.Properties.Resources.delete;
            this.removeSubAssetBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeSubAssetBut.Location = new System.Drawing.Point(80, 142);
            this.removeSubAssetBut.Name = "removeSubAssetBut";
            this.removeSubAssetBut.Size = new System.Drawing.Size(71, 25);
            this.removeSubAssetBut.TabIndex = 3;
            this.removeSubAssetBut.Text = "حذف";
            this.removeSubAssetBut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeSubAssetBut.UseVisualStyleBackColor = true;
            this.removeSubAssetBut.Click += new System.EventHandler(this.removeSubAssetBut_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::Divan.Properties.Resources.add;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(156, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "افزودن";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteFileBut
            // 
            this.deleteFileBut.Enabled = false;
            this.deleteFileBut.Image = global::Divan.Properties.Resources.delete;
            this.deleteFileBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteFileBut.Location = new System.Drawing.Point(64, 138);
            this.deleteFileBut.Name = "deleteFileBut";
            this.deleteFileBut.Size = new System.Drawing.Size(71, 25);
            this.deleteFileBut.TabIndex = 4;
            this.deleteFileBut.Text = "حذف";
            this.deleteFileBut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteFileBut.UseVisualStyleBackColor = true;
            this.deleteFileBut.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Image = global::Divan.Properties.Resources.add;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(141, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 25);
            this.button5.TabIndex = 3;
            this.button5.Text = "افزودن";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // EditAsset
            // 
            this.AcceptButton = this.button3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(494, 605);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditAsset";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش دارایی";
            this.Load += new System.EventHandler(this.NewAsset_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.subAssets.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox subAssets;
        private System.Windows.Forms.Button removeSubAssetBut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView subAssetsTree;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox labelSearchtxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox attachmentList;
        private System.Windows.Forms.Button deleteFileBut;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView propsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Panel panel1;
    }
}