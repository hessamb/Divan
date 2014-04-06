namespace Divan
{
    partial class LabelDetailsWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_name = new System.Windows.Forms.Label();
            this.label_domainModel = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.domainGroup = new System.Windows.Forms.GroupBox();
            this.label_continuousDomain = new System.Windows.Forms.Label();
            this.domainGrid = new System.Windows.Forms.DataGridView();
            this.rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitterLabelGroup = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.مشاهدهمشخصاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.فقطازلیستپاککنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفازداخلداراییهایدیگرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.domainGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainGrid)).BeginInit();
            this.splitterLabelGroup.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.domainGroup);
            this.flowLayoutPanel1.Controls.Add(this.splitterLabelGroup);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(23, 22, 23, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12, 11, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(494, 330);
            this.flowLayoutPanel1.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label_domainModel);
            this.panel1.Controls.Add(this.label_type);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 31);
            this.panel1.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_name, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(267, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 28);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(93, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(104, 14);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "نام برچسب: خیابان";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_domainModel
            // 
            this.label_domainModel.AutoSize = true;
            this.label_domainModel.Location = new System.Drawing.Point(7, 9);
            this.label_domainModel.Name = "label_domainModel";
            this.label_domainModel.Size = new System.Drawing.Size(114, 14);
            this.label_domainModel.TabIndex = 0;
            this.label_domainModel.Text = "دامنه حالت: گسسته";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(127, 9);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(118, 14);
            this.label_type.TabIndex = 0;
            this.label_type.Text = "نوع برچسب: مقدارپذیر";
            // 
            // domainGroup
            // 
            this.domainGroup.AutoSize = true;
            this.domainGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.domainGroup.Controls.Add(this.label_continuousDomain);
            this.domainGroup.Controls.Add(this.domainGrid);
            this.domainGroup.Controls.Add(this.flowLayoutPanel2);
            this.domainGroup.Location = new System.Drawing.Point(12, 51);
            this.domainGroup.Name = "domainGroup";
            this.domainGroup.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.domainGroup.Size = new System.Drawing.Size(467, 182);
            this.domainGroup.TabIndex = 2;
            this.domainGroup.TabStop = false;
            this.domainGroup.Text = "دامنه مقادیر";
            // 
            // label_continuousDomain
            // 
            this.label_continuousDomain.AutoSize = true;
            this.label_continuousDomain.Location = new System.Drawing.Point(192, 29);
            this.label_continuousDomain.Name = "label_continuousDomain";
            this.label_continuousDomain.Size = new System.Drawing.Size(269, 14);
            this.label_continuousDomain.TabIndex = 15;
            this.label_continuousDomain.Text = "این برچسب هر عدد حقیقی از 0 تا 1000 را می‌پذیرد";
            this.label_continuousDomain.Visible = false;
            // 
            // domainGrid
            // 
            this.domainGrid.AllowUserToAddRows = false;
            this.domainGrid.AllowUserToDeleteRows = false;
            this.domainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.domainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rank,
            this.name});
            this.domainGrid.Location = new System.Drawing.Point(7, 23);
            this.domainGrid.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.domainGrid.Name = "domainGrid";
            this.domainGrid.ReadOnly = true;
            this.domainGrid.RowHeadersVisible = false;
            this.domainGrid.Size = new System.Drawing.Size(454, 144);
            this.domainGrid.TabIndex = 3;
            // 
            // rank
            // 
            this.rank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rank.DataPropertyName = "rank";
            this.rank.HeaderText = "ترتیب";
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            this.rank.Width = 58;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "value";
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 43);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // splitterLabelGroup
            // 
            this.splitterLabelGroup.Controls.Add(this.label1);
            this.splitterLabelGroup.Location = new System.Drawing.Point(12, 239);
            this.splitterLabelGroup.Name = "splitterLabelGroup";
            this.splitterLabelGroup.Size = new System.Drawing.Size(467, 34);
            this.splitterLabelGroup.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "این برچسب از نوع تعریف‌گر دارایی است.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.edit);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(12, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 38);
            this.panel2.TabIndex = 11;
            // 
            // edit
            // 
            this.edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edit.Image = global::Divan.Properties.Resources.pencil;
            this.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit.Location = new System.Drawing.Point(389, 9);
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
            this.button4.Size = new System.Drawing.Size(71, 25);
            this.button4.TabIndex = 20;
            this.button4.Text = "بستن";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
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
            // 
            // حذفازداخلداراییهایدیگرToolStripMenuItem
            // 
            this.حذفازداخلداراییهایدیگرToolStripMenuItem.Name = "حذفازداخلداراییهایدیگرToolStripMenuItem";
            this.حذفازداخلداراییهایدیگرToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.حذفازداخلداراییهایدیگرToolStripMenuItem.Text = "حذف از لیست و داخل برچسب‌ها و دارایی‌های دیگر";
            // 
            // LabelDetailsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(494, 330);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LabelDetailsWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مشخصات برچسب";
            this.Load += new System.EventHandler(this.NewAsset_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.domainGroup.ResumeLayout(false);
            this.domainGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainGrid)).EndInit();
            this.splitterLabelGroup.ResumeLayout(false);
            this.splitterLabelGroup.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهمشخصاتToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_domainModel;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem فقطازلیستپاککنToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفازداخلداراییهایدیگرToolStripMenuItem;
        private System.Windows.Forms.Panel splitterLabelGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox domainGroup;
        private System.Windows.Forms.Label label_continuousDomain;
        private System.Windows.Forms.DataGridView domainGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}