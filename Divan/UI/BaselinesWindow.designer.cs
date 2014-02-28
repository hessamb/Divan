namespace Divan
{
    partial class BaselinesWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.assetsGrid = new System.Windows.Forms.DataGridView();
            this.eventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assetsGrid)).BeginInit();
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
            this.searchTxt.Size = new System.Drawing.Size(321, 22);
            this.searchTxt.TabIndex = 1;
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
            this.eventName,
            this.name});
            this.assetsGrid.Location = new System.Drawing.Point(14, 58);
            this.assetsGrid.Name = "assetsGrid";
            this.assetsGrid.ReadOnly = true;
            this.assetsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.assetsGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.assetsGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.assetsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assetsGrid.Size = new System.Drawing.Size(321, 192);
            this.assetsGrid.TabIndex = 2;
            this.assetsGrid.DoubleClick += new System.EventHandler(this.assetsGrid_DoubleClick);
            // 
            // eventName
            // 
            this.eventName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eventName.HeaderText = "نام نقطه‌ی مبنا";
            this.eventName.Name = "eventName";
            this.eventName.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "تاریخ ایجاد";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // select
            // 
            this.select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.select.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.select.Image = global::Divan.Properties.Resources.accept;
            this.select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.select.Location = new System.Drawing.Point(97, 263);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(79, 25);
            this.select.TabIndex = 4;
            this.select.Text = "انتخاب";
            this.select.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Image = global::Divan.Properties.Resources.cross;
            this.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel.Location = new System.Drawing.Point(12, 263);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(79, 25);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "انصراف";
            this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Image = global::Divan.Properties.Resources.icon_info;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "لطفا نقطه‌ی مبنا مورد نظر را انتخاب کنید.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Baselines
            // 
            this.AcceptButton = this.select;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(351, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.select);
            this.Controls.Add(this.assetsGrid);
            this.Controls.Add(this.searchTxt);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Baselines";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نقاط مبنا";
            this.Load += new System.EventHandler(this.assetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.DataGridView assetsGrid;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;

    }
}