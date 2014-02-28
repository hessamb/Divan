namespace Divan
{
    partial class EditLabelWindow
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("سال خطکشی");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("خطکشی", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("تاریخ آسفالت");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("آسفالت", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("تابلو راهنما");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("خیابان", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode5});
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.domainGroup = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.continiousProps = new System.Windows.Forms.Panel();
            this.domainGrid = new System.Windows.Forms.DataGridView();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subAssets = new System.Windows.Forms.GroupBox();
            this.subAssetsTree = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.مشاهدهمشخصاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSubAssetBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.autoChangableCh = new System.Windows.Forms.CheckBox();
            this.AutoChangableProps = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.domainGroup.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.continiousProps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainGrid)).BeginInit();
            this.subAssets.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.AutoChangableProps.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.domainGroup);
            this.flowLayoutPanel1.Controls.Add(this.autoChangableCh);
            this.flowLayoutPanel1.Controls.Add(this.AutoChangableProps);
            this.flowLayoutPanel1.Controls.Add(this.subAssets);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(23, 22, 23, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12, 11, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(493, 619);
            this.flowLayoutPanel1.TabIndex = 100;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(11, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(467, 31);
            this.panel3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "دامنه حالت: گسسته";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "نوع برچسب: مقدارپذیر";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "نام برچسب: خیابان";
            // 
            // domainGroup
            // 
            this.domainGroup.AutoSize = true;
            this.domainGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.domainGroup.Controls.Add(this.flowLayoutPanel2);
            this.domainGroup.Location = new System.Drawing.Point(10, 51);
            this.domainGroup.Name = "domainGroup";
            this.domainGroup.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.domainGroup.Size = new System.Drawing.Size(468, 183);
            this.domainGroup.TabIndex = 1;
            this.domainGroup.TabStop = false;
            this.domainGroup.Text = "دامنه مقادیر";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.continiousProps);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 21);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(456, 147);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // continiousProps
            // 
            this.continiousProps.Controls.Add(this.domainGrid);
            this.continiousProps.Location = new System.Drawing.Point(3, 3);
            this.continiousProps.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.continiousProps.Name = "continiousProps";
            this.continiousProps.Size = new System.Drawing.Size(450, 144);
            this.continiousProps.TabIndex = 2;
            // 
            // domainGrid
            // 
            this.domainGrid.AllowUserToDeleteRows = false;
            this.domainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.domainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order,
            this.name});
            this.domainGrid.Location = new System.Drawing.Point(0, 0);
            this.domainGrid.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.domainGrid.Name = "domainGrid";
            this.domainGrid.ReadOnly = true;
            this.domainGrid.Size = new System.Drawing.Size(450, 144);
            this.domainGrid.TabIndex = 3;
            // 
            // order
            // 
            this.order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.order.HeaderText = "ترتیب";
            this.order.Name = "order";
            this.order.ReadOnly = true;
            this.order.Width = 58;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // subAssets
            // 
            this.subAssets.Controls.Add(this.subAssetsTree);
            this.subAssets.Controls.Add(this.removeSubAssetBut);
            this.subAssets.Controls.Add(this.button1);
            this.subAssets.Location = new System.Drawing.Point(11, 356);
            this.subAssets.Name = "subAssets";
            this.subAssets.Size = new System.Drawing.Size(467, 203);
            this.subAssets.TabIndex = 2;
            this.subAssets.TabStop = false;
            this.subAssets.Text = "زیربرچسب‌ها:";
            // 
            // subAssetsTree
            // 
            this.subAssetsTree.ContextMenuStrip = this.contextMenuStrip1;
            this.subAssetsTree.Location = new System.Drawing.Point(8, 16);
            this.subAssetsTree.Name = "subAssetsTree";
            treeNode1.Name = "Node1";
            treeNode1.Text = "سال خطکشی";
            treeNode2.Name = "Node3";
            treeNode2.Text = "خطکشی";
            treeNode3.Name = "Node0";
            treeNode3.Text = "تاریخ آسفالت";
            treeNode4.Name = "Node4";
            treeNode4.Text = "آسفالت";
            treeNode5.Name = "Node5";
            treeNode5.Text = "تابلو راهنما";
            treeNode6.Name = "Node0";
            treeNode6.Text = "خیابان";
            this.subAssetsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.subAssetsTree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subAssetsTree.RightToLeftLayout = true;
            this.subAssetsTree.Size = new System.Drawing.Size(382, 180);
            this.subAssetsTree.TabIndex = 3;
            this.subAssetsTree.DoubleClick += new System.EventHandler(this.مشاهدهمشخصاتToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مشاهدهمشخصاتToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(223, 26);
            // 
            // مشاهدهمشخصاتToolStripMenuItem
            // 
            this.مشاهدهمشخصاتToolStripMenuItem.Image = global::Divan.Properties.Resources.note;
            this.مشاهدهمشخصاتToolStripMenuItem.Name = "مشاهدهمشخصاتToolStripMenuItem";
            this.مشاهدهمشخصاتToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.مشاهدهمشخصاتToolStripMenuItem.Text = "مشاهده مشخصات زیربرچسب";
            this.مشاهدهمشخصاتToolStripMenuItem.Click += new System.EventHandler(this.مشاهدهمشخصاتToolStripMenuItem_Click);
            // 
            // removeSubAssetBut
            // 
            this.removeSubAssetBut.Enabled = false;
            this.removeSubAssetBut.Image = global::Divan.Properties.Resources.delete;
            this.removeSubAssetBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeSubAssetBut.Location = new System.Drawing.Point(396, 53);
            this.removeSubAssetBut.Name = "removeSubAssetBut";
            this.removeSubAssetBut.Size = new System.Drawing.Size(64, 25);
            this.removeSubAssetBut.TabIndex = 2;
            this.removeSubAssetBut.Text = "حذف";
            this.removeSubAssetBut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeSubAssetBut.UseVisualStyleBackColor = true;
            this.removeSubAssetBut.Click += new System.EventHandler(this.removeSubAssetBut_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Divan.Properties.Resources.add;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(396, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "افزودن";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(11, 565);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 38);
            this.panel2.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Image = global::Divan.Properties.Resources.page_code;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(351, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 25);
            this.button5.TabIndex = 1;
            this.button5.Text = "ضمیمه کردن کد";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button4.Image = global::Divan.Properties.Resources.cross;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(7, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 25);
            this.button4.TabIndex = 3;
            this.button4.Text = "انصراف";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button3.Image = global::Divan.Properties.Resources.accept;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(101, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "تایید";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // autoChangableCh
            // 
            this.autoChangableCh.AutoSize = true;
            this.autoChangableCh.Checked = true;
            this.autoChangableCh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoChangableCh.Location = new System.Drawing.Point(147, 240);
            this.autoChangableCh.Name = "autoChangableCh";
            this.autoChangableCh.Size = new System.Drawing.Size(331, 18);
            this.autoChangableCh.TabIndex = 16;
            this.autoChangableCh.Text = "حالت این برچسب در طول زمان باید به صورت خودکار تغییر کند";
            this.autoChangableCh.UseVisualStyleBackColor = true;
            this.autoChangableCh.CheckedChanged += new System.EventHandler(this.autoChangableCh_CheckedChanged);
            // 
            // AutoChangableProps
            // 
            this.AutoChangableProps.Controls.Add(this.textBox2);
            this.AutoChangableProps.Location = new System.Drawing.Point(11, 264);
            this.AutoChangableProps.Name = "AutoChangableProps";
            this.AutoChangableProps.Size = new System.Drawing.Size(467, 86);
            this.AutoChangableProps.TabIndex = 17;
            this.AutoChangableProps.TabStop = false;
            this.AutoChangableProps.Text = "معادله یا کد تغییر مستمر";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 21);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(453, 57);
            this.textBox2.TabIndex = 0;
            // 
            // EditLabel
            // 
            this.AcceptButton = this.button3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(493, 619);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditLabel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش برچسب";
            this.Load += new System.EventHandler(this.NewAsset_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.domainGroup.ResumeLayout(false);
            this.domainGroup.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.continiousProps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.domainGrid)).EndInit();
            this.subAssets.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.AutoChangableProps.ResumeLayout(false);
            this.AutoChangableProps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox domainGroup;
        private System.Windows.Forms.DataGridView domainGrid;
        private System.Windows.Forms.GroupBox subAssets;
        private System.Windows.Forms.Button removeSubAssetBut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TreeView subAssetsTree;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel continiousProps;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهمشخصاتToolStripMenuItem;
        private System.Windows.Forms.CheckBox autoChangableCh;
        private System.Windows.Forms.GroupBox AutoChangableProps;
        private System.Windows.Forms.TextBox textBox2;
    }
}