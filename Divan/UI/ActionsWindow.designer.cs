namespace Divan
{
    partial class ActionsWindow
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
            this.actionsGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.مشاهدهمشخصاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.runBut = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Composite = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.actionsGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.searchTxt.TabIndex = 1;
            // 
            // actionsGrid
            // 
            this.actionsGrid.AllowUserToAddRows = false;
            this.actionsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.actionsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.actionsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.assetName,
            this.labelName,
            this.Composite});
            this.actionsGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.actionsGrid.Location = new System.Drawing.Point(14, 58);
            this.actionsGrid.Name = "actionsGrid";
            this.actionsGrid.ReadOnly = true;
            this.actionsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.actionsGrid.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.actionsGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.actionsGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.actionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.actionsGrid.Size = new System.Drawing.Size(506, 386);
            this.actionsGrid.TabIndex = 2;
            this.actionsGrid.SelectionChanged += new System.EventHandler(this.assetsGrid_SelectionChanged);
            this.actionsGrid.DoubleClick += new System.EventHandler(this.assetsGrid_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مشاهدهمشخصاتToolStripMenuItem,
            this.toolStripSeparator1,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 54);
            // 
            // مشاهدهمشخصاتToolStripMenuItem
            // 
            this.مشاهدهمشخصاتToolStripMenuItem.Image = global::Divan.Properties.Resources.action_go;
            this.مشاهدهمشخصاتToolStripMenuItem.Name = "مشاهدهمشخصاتToolStripMenuItem";
            this.مشاهدهمشخصاتToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.مشاهدهمشخصاتToolStripMenuItem.Text = "اعمال عملیات";
            this.مشاهدهمشخصاتToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = global::Divan.Properties.Resources.delete;
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.delete_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.runBut);
            this.flowLayoutPanel1.Controls.Add(this.delete);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 454);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(502, 32);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // runBut
            // 
            this.runBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.runBut.Image = global::Divan.Properties.Resources.action_go;
            this.runBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.runBut.Location = new System.Drawing.Point(396, 3);
            this.runBut.Name = "runBut";
            this.runBut.Size = new System.Drawing.Size(103, 25);
            this.runBut.TabIndex = 1;
            this.runBut.Text = "اعمال عملیات";
            this.runBut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.runBut.UseVisualStyleBackColor = true;
            this.runBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.Image = global::Divan.Properties.Resources.delete;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Location = new System.Drawing.Point(329, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(61, 25);
            this.delete.TabIndex = 2;
            this.delete.Text = "حذف";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Image = global::Divan.Properties.Resources.page_script;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(173, 3);
            this.button3.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "تعریف عملیات جدید";
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
            this.select.Location = new System.Drawing.Point(97, 457);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(79, 25);
            this.select.TabIndex = 4;
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
            this.cancel.Location = new System.Drawing.Point(12, 457);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(79, 25);
            this.cancel.TabIndex = 5;
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
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "لطفا عملیات مورد نظر را انتخاب کنید.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "نام عملیات";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // assetName
            // 
            this.assetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.assetName.DataPropertyName = "AssetName";
            this.assetName.HeaderText = "نام دارایی";
            this.assetName.Name = "assetName";
            this.assetName.ReadOnly = true;
            this.assetName.Width = 81;
            // 
            // labelName
            // 
            this.labelName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.labelName.DataPropertyName = "LabelName";
            this.labelName.HeaderText = "نام برچسب";
            this.labelName.Name = "labelName";
            this.labelName.ReadOnly = true;
            this.labelName.Width = 90;
            // 
            // Composite
            // 
            this.Composite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Composite.HeaderText = "مرکب";
            this.Composite.Name = "Composite";
            this.Composite.ReadOnly = true;
            this.Composite.Width = 41;
            // 
            // ActionsWindow
            // 
            this.AcceptButton = this.select;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(535, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.select);
            this.Controls.Add(this.actionsGrid);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "ActionsWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عملیات‌ها";
            this.Load += new System.EventHandler(this.assetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actionsGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button runBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهمشخصاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Composite;
        private System.Windows.Forms.DataGridView actionsGrid;

    }
}