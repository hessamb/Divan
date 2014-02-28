namespace Divan
{
    partial class ChangeStateWindow
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("سال خطکشی: 1390");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("خطکشی: متوسط", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("تاریخ آسفالت: 1387");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("آسفالت: متوسط", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("تابلو راهنما: دارد");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("خیابان: متوسط", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode5});
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.propsGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelLbl = new System.Windows.Forms.Label();
            this.valueTxt = new System.Windows.Forms.TextBox();
            this.labelsTree = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.مشاهدهمشخصاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propsGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(23, 22, 23, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12, 11, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(494, 528);
            this.flowLayoutPanel1.TabIndex = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.propsGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 181);
            this.groupBox1.TabIndex = 12;
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
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Controls.Add(this.labelsTree);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 271);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "برچسب‌ها و مقادیر:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelLbl);
            this.flowLayoutPanel2.Controls.Add(this.valueTxt);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 21);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(452, 26);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // labelLbl
            // 
            this.labelLbl.AutoSize = true;
            this.labelLbl.Location = new System.Drawing.Point(407, 6);
            this.labelLbl.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelLbl.Name = "labelLbl";
            this.labelLbl.Size = new System.Drawing.Size(42, 14);
            this.labelLbl.TabIndex = 0;
            this.labelLbl.Text = "خیابان:";
            // 
            // valueTxt
            // 
            this.valueTxt.Location = new System.Drawing.Point(226, 3);
            this.valueTxt.Name = "valueTxt";
            this.valueTxt.Size = new System.Drawing.Size(175, 22);
            this.valueTxt.TabIndex = 1;
            this.valueTxt.Text = "متوسط";
            // 
            // labelsTree
            // 
            this.labelsTree.Location = new System.Drawing.Point(7, 53);
            this.labelsTree.Name = "labelsTree";
            treeNode1.Name = "Node1";
            treeNode1.Text = "سال خطکشی: 1390";
            treeNode2.Name = "Node3";
            treeNode2.Text = "خطکشی: متوسط";
            treeNode3.Name = "Node0";
            treeNode3.Text = "تاریخ آسفالت: 1387";
            treeNode4.Name = "Node4";
            treeNode4.Text = "آسفالت: متوسط";
            treeNode5.Name = "Node5";
            treeNode5.Text = "تابلو راهنما: دارد";
            treeNode6.Name = "Node0";
            treeNode6.Text = "خیابان: متوسط";
            this.labelsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.labelsTree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelsTree.RightToLeftLayout = true;
            this.labelsTree.Size = new System.Drawing.Size(452, 212);
            this.labelsTree.TabIndex = 18;
            this.labelsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.labelsTree_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.okBtn);
            this.panel2.Location = new System.Drawing.Point(12, 478);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 38);
            this.panel2.TabIndex = 11;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.cancelBtn.Image = global::Divan.Properties.Resources.cross;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(7, 6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(87, 25);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "انصراف";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.okBtn.Image = global::Divan.Properties.Resources.accept;
            this.okBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okBtn.Location = new System.Drawing.Point(101, 6);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(87, 25);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "تایید";
            this.okBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.okBtn.UseVisualStyleBackColor = true;
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
            // ChangeState
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(494, 528);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChangeState";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت تغییر وضعیت دارایی";
            this.Load += new System.EventHandler(this.NewAsset_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propsGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView labelsTree;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهمشخصاتToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label labelLbl;
        private System.Windows.Forms.TextBox valueTxt;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView propsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
    }
}