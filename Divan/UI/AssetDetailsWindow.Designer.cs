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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGrid_primaryInfo = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGrid_labelInstance = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subAssets = new System.Windows.Forms.GroupBox();
            this.treeView_subAsset = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.مشاهدهمشخصاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_attachments = new System.Windows.Forms.Button();
            this.changeState = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.فقطازلیستپاککنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفازداخلداراییهایدیگرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_primaryInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_labelInstance)).BeginInit();
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
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGrid_primaryInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 181);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات اولیه:";
            // 
            // dataGrid_primaryInfo
            // 
            this.dataGrid_primaryInfo.AllowUserToAddRows = false;
            this.dataGrid_primaryInfo.AllowUserToDeleteRows = false;
            this.dataGrid_primaryInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_primaryInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.value});
            this.dataGrid_primaryInfo.Location = new System.Drawing.Point(7, 24);
            this.dataGrid_primaryInfo.Name = "dataGrid_primaryInfo";
            this.dataGrid_primaryInfo.ReadOnly = true;
            this.dataGrid_primaryInfo.RowHeadersVisible = false;
            this.dataGrid_primaryInfo.Size = new System.Drawing.Size(452, 150);
            this.dataGrid_primaryInfo.TabIndex = 13;
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
            this.groupBox2.Controls.Add(this.dataGrid_labelInstance);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 174);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "برچسب‌ها و مقادیر:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGrid_labelInstance
            // 
            this.dataGrid_labelInstance.AllowUserToAddRows = false;
            this.dataGrid_labelInstance.AllowUserToDeleteRows = false;
            this.dataGrid_labelInstance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_labelInstance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGrid_labelInstance.Location = new System.Drawing.Point(9, 24);
            this.dataGrid_labelInstance.Name = "dataGrid_labelInstance";
            this.dataGrid_labelInstance.ReadOnly = true;
            this.dataGrid_labelInstance.RowHeadersVisible = false;
            this.dataGrid_labelInstance.Size = new System.Drawing.Size(452, 150);
            this.dataGrid_labelInstance.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "برچسب";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 72;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "مقدار";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // subAssets
            // 
            this.subAssets.Controls.Add(this.treeView_subAsset);
            this.subAssets.Location = new System.Drawing.Point(12, 381);
            this.subAssets.Name = "subAssets";
            this.subAssets.Size = new System.Drawing.Size(467, 181);
            this.subAssets.TabIndex = 10;
            this.subAssets.TabStop = false;
            this.subAssets.Text = "زیردارایی‌ها:";
            // 
            // treeView_subAsset
            // 
            this.treeView_subAsset.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView_subAsset.Location = new System.Drawing.Point(7, 22);
            this.treeView_subAsset.Name = "treeView_subAsset";
            this.treeView_subAsset.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeView_subAsset.RightToLeftLayout = true;
            this.treeView_subAsset.Size = new System.Drawing.Size(452, 152);
            this.treeView_subAsset.TabIndex = 18;
            this.treeView_subAsset.DoubleClick += new System.EventHandler(this.subAssetsTree_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مشاهدهمشخصاتToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 26);
            // 
            // مشاهدهمشخصاتToolStripMenuItem
            // 
            this.مشاهدهمشخصاتToolStripMenuItem.Image = global::Divan.Properties.Resources.icon_package;
            this.مشاهدهمشخصاتToolStripMenuItem.Name = "مشاهدهمشخصاتToolStripMenuItem";
            this.مشاهدهمشخصاتToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.مشاهدهمشخصاتToolStripMenuItem.Text = "مشاهده مشخصات زیردارایی";
            this.مشاهدهمشخصاتToolStripMenuItem.Click += new System.EventHandler(this.مشاهدهمشخصاتToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_attachments);
            this.panel2.Controls.Add(this.changeState);
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.edit);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(12, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 38);
            this.panel2.TabIndex = 11;
            // 
            // button_attachments
            // 
            this.button_attachments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_attachments.Image = global::Divan.Properties.Resources.icon_package_get;
            this.button_attachments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_attachments.Location = new System.Drawing.Point(85, 9);
            this.button_attachments.Name = "button_attachments";
            this.button_attachments.Size = new System.Drawing.Size(113, 25);
            this.button_attachments.TabIndex = 24;
            this.button_attachments.Text = "فایل‌های ضمیمه";
            this.button_attachments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_attachments.UseVisualStyleBackColor = true;
            this.button_attachments.Click += new System.EventHandler(this.button1_Click_1);
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
            this.delete.Location = new System.Drawing.Point(204, 9);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(60, 25);
            this.delete.TabIndex = 22;
            this.delete.Text = "حذف";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edit.Image = global::Divan.Properties.Resources.pencil;
            this.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit.Location = new System.Drawing.Point(270, 9);
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
            this.contextMenuStrip2.Size = new System.Drawing.Size(246, 48);
            // 
            // فقطازلیستپاککنToolStripMenuItem
            // 
            this.فقطازلیستپاککنToolStripMenuItem.Name = "فقطازلیستپاککنToolStripMenuItem";
            this.فقطازلیستپاککنToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.فقطازلیستپاککنToolStripMenuItem.Text = "فقط حذف از لیست";
            this.فقطازلیستپاککنToolStripMenuItem.Click += new System.EventHandler(this.فقطازلیستپاککنToolStripMenuItem_Click);
            // 
            // حذفازداخلداراییهایدیگرToolStripMenuItem
            // 
            this.حذفازداخلداراییهایدیگرToolStripMenuItem.Name = "حذفازداخلداراییهایدیگرToolStripMenuItem";
            this.حذفازداخلداراییهایدیگرToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.حذفازداخلداراییهایدیگرToolStripMenuItem.Text = "حذف از لیست و داخل دارایی‌های دیگر";
            this.حذفازداخلداراییهایدیگرToolStripMenuItem.Click += new System.EventHandler(this.فقطازلیستپاککنToolStripMenuItem_Click);
            // 
            // AssetDetailsWindow
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
            this.Name = "AssetDetailsWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مشخصات دارایی";
            this.Load += new System.EventHandler(this.NewAsset_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_primaryInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_labelInstance)).EndInit();
            this.subAssets.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGrid_primaryInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox subAssets;
        private System.Windows.Forms.TreeView treeView_subAsset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهمشخصاتToolStripMenuItem;
        private System.Windows.Forms.Button changeState;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem فقطازلیستپاککنToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفازداخلداراییهایدیگرToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGrid_labelInstance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button_attachments;
    }
}