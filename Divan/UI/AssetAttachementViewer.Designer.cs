namespace Divan
{
    partial class AssetAttachementViewer
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
            this.listBox_attachement = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel_info = new System.Windows.Forms.TableLayoutPanel();
            this.label_name = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.label_lastModification = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.button_exec = new System.Windows.Forms.Button();
            this.tableLayoutPanel_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_attachement
            // 
            this.listBox_attachement.FormattingEnabled = true;
            this.listBox_attachement.ItemHeight = 14;
            this.listBox_attachement.Location = new System.Drawing.Point(14, 13);
            this.listBox_attachement.Name = "listBox_attachement";
            this.listBox_attachement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_attachement.Size = new System.Drawing.Size(198, 88);
            this.listBox_attachement.TabIndex = 0;
            this.listBox_attachement.SelectedIndexChanged += new System.EventHandler(this.listBox_attachement_SelectedIndexChanged);
            // 
            // tableLayoutPanel_info
            // 
            this.tableLayoutPanel_info.ColumnCount = 1;
            this.tableLayoutPanel_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_info.Controls.Add(this.label_name, 0, 0);
            this.tableLayoutPanel_info.Controls.Add(this.label_size, 0, 1);
            this.tableLayoutPanel_info.Controls.Add(this.label_lastModification, 0, 2);
            this.tableLayoutPanel_info.Location = new System.Drawing.Point(219, 13);
            this.tableLayoutPanel_info.Name = "tableLayoutPanel_info";
            this.tableLayoutPanel_info.RowCount = 3;
            this.tableLayoutPanel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.27536F));
            this.tableLayoutPanel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.72464F));
            this.tableLayoutPanel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel_info.Size = new System.Drawing.Size(344, 88);
            this.tableLayoutPanel_info.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(291, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(50, 14);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "نام فایل:";
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(306, 20);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(35, 14);
            this.label_size.TabIndex = 1;
            this.label_size.Text = "حجم:";
            // 
            // label_lastModification
            // 
            this.label_lastModification.AutoSize = true;
            this.label_lastModification.Location = new System.Drawing.Point(220, 41);
            this.label_lastModification.Name = "label_lastModification";
            this.label_lastModification.Size = new System.Drawing.Size(121, 14);
            this.label_lastModification.TabIndex = 3;
            this.label_lastModification.Text = "آخرین تاریخ بروزرسانی:";
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Image = global::Divan.Properties.Resources.cross;
            this.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel.Location = new System.Drawing.Point(14, 111);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(92, 27);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "بستن";
            this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.Location = new System.Drawing.Point(274, 37);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(187, 23);
            this.label_error.TabIndex = 5;
            this.label_error.Text = "فایل حذف شده است.";
            this.label_error.Visible = false;
            // 
            // button_exec
            // 
            this.button_exec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_exec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_exec.Enabled = false;
            this.button_exec.Image = global::Divan.Properties.Resources.action_forward;
            this.button_exec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_exec.Location = new System.Drawing.Point(473, 111);
            this.button_exec.Name = "button_exec";
            this.button_exec.Size = new System.Drawing.Size(92, 27);
            this.button_exec.TabIndex = 6;
            this.button_exec.Text = "اجرای فایل";
            this.button_exec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_exec.UseVisualStyleBackColor = true;
            this.button_exec.Click += new System.EventHandler(this.button_exec_Click);
            // 
            // AssetAttachementViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 150);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.button_exec);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.tableLayoutPanel_info);
            this.Controls.Add(this.listBox_attachement);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AssetAttachementViewer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فایل‌های ضمیمه";
            this.Load += new System.EventHandler(this.AssetAttachementViewer_Load);
            this.tableLayoutPanel_info.ResumeLayout(false);
            this.tableLayoutPanel_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_attachement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_info;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Label label_lastModification;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Button button_exec;
    }
}