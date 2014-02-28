namespace Divan
{
    partial class LabelsWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.assetsGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.human = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.composition = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.مشاهدهمشخصاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.فقطازلیستپاککنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفازداخلداراییهایدیگرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.assetsGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTxt
            // 
            this.searchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchTxt.Location = new System.Drawing.Point(14, 30);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchTxt.Size = new System.Drawing.Size(506, 22);
            this.searchTxt.TabIndex = 4;
            // 
            // assetsGrid
            // 
            this.assetsGrid.AllowUserToAddRows = false;
            this.assetsGrid.AllowUserToDeleteRows = false;
            this.assetsGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.assetsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.assetsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assetsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assetsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.sensible,
            this.human,
            this.composition});
            this.assetsGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.assetsGrid.Location = new System.Drawing.Point(14, 58);
            this.assetsGrid.Name = "assetsGrid";
            this.assetsGrid.ReadOnly = true;
            this.assetsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.assetsGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.assetsGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.assetsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assetsGrid.Size = new System.Drawing.Size(506, 401);
            this.assetsGrid.TabIndex = 0;
            this.assetsGrid.SelectionChanged += new System.EventHandler(this.assetsGrid_SelectionChanged);
            this.assetsGrid.DoubleClick += new System.EventHandler(this.assetsGrid_DoubleClick);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "نام برچسب";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // sensible
            // 
            this.sensible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sensible.HeaderText = "مقدارپذیر";
            this.sensible.Name = "sensible";
            this.sensible.ReadOnly = true;
            this.sensible.Width = 57;
            // 
            // human
            // 
            this.human.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.human.HeaderText = "دامنه حالت";
            this.human.Name = "human";
            this.human.ReadOnly = true;
            this.human.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.human.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.human.Width = 69;
            // 
            // composition
            // 
            this.composition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.composition.HeaderText = "مرکب";
            this.composition.Name = "composition";
            this.composition.ReadOnly = true;
            this.composition.Width = 41;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مشاهدهمشخصاتToolStripMenuItem,
            this.toolStripSeparator1,
            this.حذفToolStripMenuItem,
            this.ویرایشToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 76);
            // 
            // مشاهدهمشخصاتToolStripMenuItem
            // 
            this.مشاهدهمشخصاتToolStripMenuItem.Image = global::Divan.Properties.Resources.note;
            this.مشاهدهمشخصاتToolStripMenuItem.Name = "مشاهدهمشخصاتToolStripMenuItem";
            this.مشاهدهمشخصاتToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.مشاهدهمشخصاتToolStripMenuItem.Text = "مشاهده مشخصات";
            this.مشاهدهمشخصاتToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = global::Divan.Properties.Resources.delete;
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.delete_Click);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.Image = global::Divan.Properties.Resources.pencil;
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            this.ویرایشToolStripMenuItem.Click += new System.EventHandler(this.edit_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.delete);
            this.flowLayoutPanel1.Controls.Add(this.edit);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 469);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(502, 32);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::Divan.Properties.Resources.icon_package;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(368, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "مشاهده مشخصات";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.Image = global::Divan.Properties.Resources.delete;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Location = new System.Drawing.Point(301, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(61, 25);
            this.delete.TabIndex = 2;
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
            this.edit.Location = new System.Drawing.Point(221, 3);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(74, 25);
            this.edit.TabIndex = 3;
            this.edit.Text = "ویرایش";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click_1);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Image = global::Divan.Properties.Resources.icon_package_add;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(72, 3);
            this.button3.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "تعریف برچسب جدید";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // select
            // 
            this.select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.select.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.select.Enabled = false;
            this.select.Image = global::Divan.Properties.Resources.accept;
            this.select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.select.Location = new System.Drawing.Point(97, 472);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(79, 25);
            this.select.TabIndex = 2;
            this.select.Text = "انتخاب";
            this.select.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.select.UseVisualStyleBackColor = true;
            this.select.Visible = false;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Enabled = false;
            this.cancel.Image = global::Divan.Properties.Resources.cross;
            this.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel.Location = new System.Drawing.Point(12, 472);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(79, 25);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "انصراف";
            this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Image = global::Divan.Properties.Resources.icon_info;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "لطفا برچسب مورد نظر را انتخاب کنید.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فقطازلیستپاککنToolStripMenuItem,
            this.حذفازداخلداراییهایدیگرToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip2.Size = new System.Drawing.Size(316, 48);
            // 
            // فقطازلیستپاککنToolStripMenuItem
            // 
            this.فقطازلیستپاککنToolStripMenuItem.Name = "فقطازلیستپاککنToolStripMenuItem";
            this.فقطازلیستپاککنToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.فقطازلیستپاککنToolStripMenuItem.Text = "فقط حذف از لیست";
            this.فقطازلیستپاککنToolStripMenuItem.Click += new System.EventHandler(this.فقطازلیستپاککنToolStripMenuItem_Click);
            // 
            // حذفازداخلداراییهایدیگرToolStripMenuItem
            // 
            this.حذفازداخلداراییهایدیگرToolStripMenuItem.Name = "حذفازداخلداراییهایدیگرToolStripMenuItem";
            this.حذفازداخلداراییهایدیگرToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.حذفازداخلداراییهایدیگرToolStripMenuItem.Text = "حذف از لیست و داخل برچسب‌ها و دارایی‌های دیگر";
            this.حذفازداخلداراییهایدیگرToolStripMenuItem.Click += new System.EventHandler(this.فقطازلیستپاککنToolStripMenuItem_Click);
            // 
            // Labels
            // 
            this.AcceptButton = this.select;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(535, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.select);
            this.Controls.Add(this.assetsGrid);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Labels";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برچسب‌ها";
            this.Load += new System.EventHandler(this.assetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetsGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.DataGridView assetsGrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sensible;
        private System.Windows.Forms.DataGridViewTextBoxColumn human;
        private System.Windows.Forms.DataGridViewCheckBoxColumn composition;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهمشخصاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem فقطازلیستپاککنToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفازداخلداراییهایدیگرToolStripMenuItem;

    }
}