namespace Divan
{
    partial class AssetDetailsWindow
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("سال خطکشی: ۱۳۹۲");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("خطکشی: متوسط", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("۱۳۸۶ : تاریخ آسفالت");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("آسفالت: متوسط", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("تابلو راهنما: دارد");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("خیابان: متوسط", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("زیردارایی ۱.۱.۱");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("زیردارایی ۱.۱", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("زیردارایی ۱.۲");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("زیردارایی ۱.۳.۱");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("زیردارایی ۱.۳", new System.Windows.Forms.TreeNode[] {
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("زیردارایی ۱", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("زیردارایی ۲.۱");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("زیردارایی ۲", new System.Windows.Forms.TreeNode[] {
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("زیردارایی ۳");
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.propsGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelsTree = new System.Windows.Forms.TreeView();
            this.subAssets = new System.Windows.Forms.GroupBox();
            this.subAssetsTree = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.مشاهدهمشخصاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changeState = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.فقطازلیستپاککنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفازداخلداراییهایدیگرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propsGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.subAssets.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.subAssets);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(23, 22, 23, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12, 11, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(494, 627);
            this.flowLayoutPanel1.TabIndex = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.propsGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 181);
            this.groupBox1.TabIndex = 8;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelsTree);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 174);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "برچسب‌ها و مقادیر:";
            // 
            // labelsTree
            // 
            this.labelsTree.Location = new System.Drawing.Point(7, 21);
            this.labelsTree.Name = "labelsTree";
            treeNode7.Name = "Node1";
            treeNode7.Text = "سال خطکشی: ۱۳۹۲";
            treeNode8.Name = "Node3";
            treeNode8.Text = "خطکشی: متوسط";
            treeNode9.Name = "Node0";
            treeNode9.Text = "۱۳۸۶ : تاریخ آسفالت";
            treeNode10.Name = "Node4";
            treeNode10.Text = "آسفالت: متوسط";
            treeNode11.Name = "Node5";
            treeNode11.Text = "تابلو راهنما: دارد";
            treeNode12.Name = "Node0";
            treeNode12.Text = "خیابان: متوسط";
            this.labelsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.labelsTree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelsTree.RightToLeftLayout = true;
            this.labelsTree.Size = new System.Drawing.Size(452, 147);
            this.labelsTree.TabIndex = 18;
            // 
            // subAssets
            // 
            this.subAssets.Controls.Add(this.subAssetsTree);
            this.subAssets.Location = new System.Drawing.Point(12, 381);
            this.subAssets.Name = "subAssets";
            this.subAssets.Size = new System.Drawing.Size(467, 181);
            this.subAssets.TabIndex = 10;
            this.subAssets.TabStop = false;
            this.subAssets.Text = "زیردارایی‌ها:";
            // 
            // subAssetsTree
            // 
            this.subAssetsTree.ContextMenuStrip = this.contextMenuStrip1;
            this.subAssetsTree.Location = new System.Drawing.Point(7, 22);
            this.subAssetsTree.Name = "subAssetsTree";
            treeNode13.Name = "Node6";
            treeNode13.Text = "زیردارایی ۱.۱.۱";
            treeNode14.Name = "Node3";
            treeNode14.Text = "زیردارایی ۱.۱";
            treeNode15.Name = "Node4";
            treeNode15.Text = "زیردارایی ۱.۲";
            treeNode31.Name = "Node7";
            treeNode31.Text = "زیردارایی ۱.۳.۱";
            treeNode32.Name = "Node5";
            treeNode32.Text = "زیردارایی ۱.۳";
            treeNode33.Name = "Node0";
            treeNode33.Text = "زیردارایی ۱";
            treeNode34.Name = "Node8";
            treeNode34.Text = "زیردارایی ۲.۱";
            treeNode35.Name = "Node1";
            treeNode35.Text = "زیردارایی ۲";
            treeNode36.Name = "Node2";
            treeNode36.Text = "زیردارایی ۳";
            this.subAssetsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode35,
            treeNode36});
            this.subAssetsTree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subAssetsTree.RightToLeftLayout = true;
            this.subAssetsTree.Size = new System.Drawing.Size(452, 152);
            this.subAssetsTree.TabIndex = 18;
            this.subAssetsTree.DoubleClick += new System.EventHandler(this.subAssetsTree_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مشاهدهمشخصاتToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 26);
            // 
            // مشاهدهمشخصاتToolStripMenuItem
            // 
            this.مشاهدهمشخصاتToolStripMenuItem.Image = global::Divan.Properties.Resources.icon_package;
            this.مشاهدهمشخصاتToolStripMenuItem.Name = "مشاهدهمشخصاتToolStripMenuItem";
            this.مشاهدهمشخصاتToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.مشاهدهمشخصاتToolStripMenuItem.Text = "مشاهده مشخصات زیردارایی";
            this.مشاهدهمشخصاتToolStripMenuItem.Click += new System.EventHandler(this.مشاهدهمشخصاتToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.changeState);
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.history);
            this.panel2.Controls.Add(this.edit);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(12, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 38);
            this.panel2.TabIndex = 11;
            // 
            // changeState
            // 
            this.changeState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changeState.Image = global::Divan.Properties.Resources.action_refresh_blue;
            this.changeState.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeState.Location = new System.Drawing.Point(346, 9);
            this.changeState.Name = "changeState";
            this.changeState.Size = new System.Drawing.Size(113, 25);
            this.changeState.TabIndex = 23;
            this.changeState.Text = "ثبت تغییر وضعیت";
            this.changeState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.changeState.UseVisualStyleBackColor = true;
            this.changeState.Click += new System.EventHandler(this.changeState_Click);
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.Image = global::Divan.Properties.Resources.delete;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Location = new System.Drawing.Point(87, 9);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(60, 25);
            this.delete.TabIndex = 22;
            this.delete.Text = "حذف";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // history
            // 
            this.history.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.history.Image = global::Divan.Properties.Resources.icon_clock;
            this.history.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.history.Location = new System.Drawing.Point(229, 9);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(111, 25);
            this.history.TabIndex = 21;
            this.history.Text = "تاریخچه تغییرات";
            this.history.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // edit
            // 
            this.edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edit.Image = global::Divan.Properties.Resources.pencil;
            this.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit.Location = new System.Drawing.Point(153, 9);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(70, 25);
            this.edit.TabIndex = 21;
            this.edit.Text = "ویرایش";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button4.Image = global::Divan.Properties.Resources.cross;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(7, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 25);
            this.button4.TabIndex = 20;
            this.button4.Text = "بستن";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فقطازلیستپاککنToolStripMenuItem,
            this.حذفازداخلداراییهایدیگرToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip2.Size = new System.Drawing.Size(256, 70);
            // 
            // فقطازلیستپاککنToolStripMenuItem
            // 
            this.فقطازلیستپاککنToolStripMenuItem.Name = "فقطازلیستپاککنToolStripMenuItem";
            this.فقطازلیستپاککنToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.فقطازلیستپاککنToolStripMenuItem.Text = "فقط حذف از لیست";
            this.فقطازلیستپاککنToolStripMenuItem.Click += new System.EventHandler(this.فقطازلیستپاککنToolStripMenuItem_Click);
            // 
            // حذفازداخلداراییهایدیگرToolStripMenuItem
            // 
            this.حذفازداخلداراییهایدیگرToolStripMenuItem.Name = "حذفازداخلداراییهایدیگرToolStripMenuItem";
            this.حذفازداخلداراییهایدیگرToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.حذفازداخلداراییهایدیگرToolStripMenuItem.Text = "حذف از لیست و داخل دارایی‌های دیگر";
            this.حذفازداخلداراییهایدیگرToolStripMenuItem.Click += new System.EventHandler(this.فقطازلیستپاککنToolStripMenuItem_Click);
            // 
            // AssetDetails
            // 
            this.AcceptButton = this.changeState;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(494, 627);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AssetDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مشخصات دارایی";
            this.Load += new System.EventHandler(this.NewAsset_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propsGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.subAssets.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView propsGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox subAssets;
        private System.Windows.Forms.TreeView subAssetsTree;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TreeView labelsTree;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهمشخصاتToolStripMenuItem;
        private System.Windows.Forms.Button changeState;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem فقطازلیستپاککنToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفازداخلداراییهایدیگرToolStripMenuItem;
    }
}