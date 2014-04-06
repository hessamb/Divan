namespace Divan.UI
{
    partial class ReportInconsistencies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid_consistencies = new System.Windows.Forms.DataGridView();
            this.AssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inconsistent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_uid = new System.Windows.Forms.RadioButton();
            this.radioButton_name = new System.Windows.Forms.RadioButton();
            this.radioButton_allProperties = new System.Windows.Forms.RadioButton();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_consistencies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_consistencies
            // 
            this.dataGrid_consistencies.AllowUserToAddRows = false;
            this.dataGrid_consistencies.AllowUserToDeleteRows = false;
            this.dataGrid_consistencies.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGrid_consistencies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGrid_consistencies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_consistencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_consistencies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssetName,
            this.Importance,
            this.Operand,
            this.Inconsistent});
            this.dataGrid_consistencies.Location = new System.Drawing.Point(12, 65);
            this.dataGrid_consistencies.MultiSelect = false;
            this.dataGrid_consistencies.Name = "dataGrid_consistencies";
            this.dataGrid_consistencies.ReadOnly = true;
            this.dataGrid_consistencies.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGrid_consistencies.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGrid_consistencies.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGrid_consistencies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_consistencies.Size = new System.Drawing.Size(660, 385);
            this.dataGrid_consistencies.TabIndex = 1;
            // 
            // AssetName
            // 
            this.AssetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AssetName.DataPropertyName = "AssetName";
            this.AssetName.HeaderText = "نام دارایی";
            this.AssetName.Name = "AssetName";
            this.AssetName.ReadOnly = true;
            // 
            // Importance
            // 
            this.Importance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Importance.DataPropertyName = "Importance";
            this.Importance.HeaderText = "اهمیت قانون";
            this.Importance.Name = "Importance";
            this.Importance.ReadOnly = true;
            this.Importance.Width = 89;
            // 
            // Operand
            // 
            this.Operand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Operand.DataPropertyName = "condition";
            this.Operand.HeaderText = "عملگر";
            this.Operand.Name = "Operand";
            this.Operand.ReadOnly = true;
            this.Operand.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Operand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Operand.Width = 40;
            // 
            // Inconsistent
            // 
            this.Inconsistent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inconsistent.DataPropertyName = "Inconsistent";
            this.Inconsistent.HeaderText = "ناسازگار";
            this.Inconsistent.Name = "Inconsistent";
            this.Inconsistent.ReadOnly = true;
            this.Inconsistent.Width = 55;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Image = global::Divan.Properties.Resources.icon_info;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(346, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "برای محدود کردن قوانین سازگارسنجی از مورد زیر استفاده کنید.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "جستجو بر اساس:";
            // 
            // radioButton_uid
            // 
            this.radioButton_uid.AutoSize = true;
            this.radioButton_uid.Location = new System.Drawing.Point(15, 38);
            this.radioButton_uid.Name = "radioButton_uid";
            this.radioButton_uid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton_uid.Size = new System.Drawing.Size(56, 17);
            this.radioButton_uid.TabIndex = 21;
            this.radioButton_uid.Tag = "Operand";
            this.radioButton_uid.Text = "شناسه";
            this.radioButton_uid.UseVisualStyleBackColor = true;
            // 
            // radioButton_name
            // 
            this.radioButton_name.AutoSize = true;
            this.radioButton_name.Location = new System.Drawing.Point(92, 37);
            this.radioButton_name.Name = "radioButton_name";
            this.radioButton_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton_name.Size = new System.Drawing.Size(38, 17);
            this.radioButton_name.TabIndex = 20;
            this.radioButton_name.Tag = "AssetName";
            this.radioButton_name.Text = "نام";
            this.radioButton_name.UseVisualStyleBackColor = true;
            // 
            // radioButton_allProperties
            // 
            this.radioButton_allProperties.AutoSize = true;
            this.radioButton_allProperties.Checked = true;
            this.radioButton_allProperties.Location = new System.Drawing.Point(143, 37);
            this.radioButton_allProperties.Name = "radioButton_allProperties";
            this.radioButton_allProperties.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton_allProperties.Size = new System.Drawing.Size(102, 17);
            this.radioButton_allProperties.TabIndex = 19;
            this.radioButton_allProperties.TabStop = true;
            this.radioButton_allProperties.Tag = "";
            this.radioButton_allProperties.Text = "همه‌ی خصوصیات";
            this.radioButton_allProperties.UseVisualStyleBackColor = true;
            // 
            // searchTxt
            // 
            this.searchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchTxt.Location = new System.Drawing.Point(366, 37);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchTxt.Size = new System.Drawing.Size(306, 22);
            this.searchTxt.TabIndex = 18;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "فقط نمایش ناسازگارها";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ReportInconsistencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_uid);
            this.Controls.Add(this.radioButton_name);
            this.Controls.Add(this.radioButton_allProperties);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.dataGrid_consistencies);
            this.Name = "ReportInconsistencies";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گزارش ناسازگاری‌ها";
            this.Load += new System.EventHandler(this.ReportInconsistencies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_consistencies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_consistencies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_uid;
        private System.Windows.Forms.RadioButton radioButton_name;
        private System.Windows.Forms.RadioButton radioButton_allProperties;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operand;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Inconsistent;
        private System.Windows.Forms.CheckBox checkBox1;

    }
}