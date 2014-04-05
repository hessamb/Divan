namespace Divan
{
    partial class NewActionWindow
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.domainGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_asset = new System.Windows.Forms.Label();
            this.label_label = new System.Windows.Forms.Label();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_selectLabel = new System.Windows.Forms.Button();
            this.button_selectAsset = new System.Windows.Forms.Button();
            this.autoRunable = new System.Windows.Forms.CheckBox();
            this.runTime = new System.Windows.Forms.GroupBox();
            this.textBox_period = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.compositAsset = new System.Windows.Forms.CheckBox();
            this.subAssets = new System.Windows.Forms.GroupBox();
            this.subActionList = new System.Windows.Forms.ListBox();
            this.removeSubAssetBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.مشاهدهمشخصاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.domainGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.runTime.SuspendLayout();
            this.subAssets.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.domainGroup);
            this.flowLayoutPanel1.Controls.Add(this.autoRunable);
            this.flowLayoutPanel1.Controls.Add(this.runTime);
            this.flowLayoutPanel1.Controls.Add(this.compositAsset);
            this.flowLayoutPanel1.Controls.Add(this.subAssets);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(23, 22, 23, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12, 11, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(497, 536);
            this.flowLayoutPanel1.TabIndex = 100;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nameTxt);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(15, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(467, 27);
            this.panel3.TabIndex = 1;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(254, 0);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(138, 22);
            this.nameTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام عملیات:";
            // 
            // domainGroup
            // 
            this.domainGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.domainGroup.Controls.Add(this.tableLayoutPanel1);
            this.domainGroup.Controls.Add(this.textBox_value);
            this.domainGroup.Controls.Add(this.label4);
            this.domainGroup.Controls.Add(this.button_selectLabel);
            this.domainGroup.Controls.Add(this.button_selectAsset);
            this.domainGroup.Location = new System.Drawing.Point(15, 47);
            this.domainGroup.Name = "domainGroup";
            this.domainGroup.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.domainGroup.Size = new System.Drawing.Size(467, 114);
            this.domainGroup.TabIndex = 2;
            this.domainGroup.TabStop = false;
            this.domainGroup.Text = "مشخصات:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_asset, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_label, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(129, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 56);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label_asset
            // 
            this.label_asset.AutoSize = true;
            this.label_asset.Location = new System.Drawing.Point(232, 0);
            this.label_asset.Name = "label_asset";
            this.label_asset.Size = new System.Drawing.Size(103, 14);
            this.label_asset.TabIndex = 1;
            this.label_asset.Text = "دارایی: انتخاب کنید";
            // 
            // label_label
            // 
            this.label_label.AutoSize = true;
            this.label_label.Location = new System.Drawing.Point(177, 27);
            this.label_label.Name = "label_label";
            this.label_label.Size = new System.Drawing.Size(158, 14);
            this.label_label.TabIndex = 1;
            this.label_label.Text = "برچسب: دارایی را انتخاب کنید";
            // 
            // textBox_value
            // 
            this.textBox_value.Enabled = false;
            this.textBox_value.Location = new System.Drawing.Point(8, 84);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(366, 22);
            this.textBox_value.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "مقدار برچسب:";
            // 
            // button_selectLabel
            // 
            this.button_selectLabel.Enabled = false;
            this.button_selectLabel.Image = global::Divan.Properties.Resources.note;
            this.button_selectLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_selectLabel.Location = new System.Drawing.Point(8, 53);
            this.button_selectLabel.Name = "button_selectLabel";
            this.button_selectLabel.Size = new System.Drawing.Size(115, 25);
            this.button_selectLabel.TabIndex = 2;
            this.button_selectLabel.Text = "انتخاب برچسب";
            this.button_selectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_selectLabel.UseVisualStyleBackColor = true;
            this.button_selectLabel.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_selectAsset
            // 
            this.button_selectAsset.Image = global::Divan.Properties.Resources.icon_package;
            this.button_selectAsset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_selectAsset.Location = new System.Drawing.Point(8, 22);
            this.button_selectAsset.Name = "button_selectAsset";
            this.button_selectAsset.Size = new System.Drawing.Size(115, 25);
            this.button_selectAsset.TabIndex = 1;
            this.button_selectAsset.Text = "انتخاب دارایی";
            this.button_selectAsset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_selectAsset.UseVisualStyleBackColor = true;
            this.button_selectAsset.Click += new System.EventHandler(this.button2_Click);
            // 
            // autoRunable
            // 
            this.autoRunable.AutoSize = true;
            this.autoRunable.Checked = true;
            this.autoRunable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRunable.Location = new System.Drawing.Point(247, 167);
            this.autoRunable.Name = "autoRunable";
            this.autoRunable.Size = new System.Drawing.Size(235, 18);
            this.autoRunable.TabIndex = 3;
            this.autoRunable.Text = "این عملیات باید به صورت خودکار اجرا شود";
            this.autoRunable.UseVisualStyleBackColor = true;
            this.autoRunable.CheckedChanged += new System.EventHandler(this.autoRunable_CheckedChanged);
            // 
            // runTime
            // 
            this.runTime.Controls.Add(this.textBox_period);
            this.runTime.Controls.Add(this.label6);
            this.runTime.Controls.Add(this.label5);
            this.runTime.Location = new System.Drawing.Point(15, 191);
            this.runTime.Name = "runTime";
            this.runTime.Size = new System.Drawing.Size(467, 51);
            this.runTime.TabIndex = 4;
            this.runTime.TabStop = false;
            this.runTime.Text = "زمان اجرا:";
            // 
            // textBox_period
            // 
            this.textBox_period.Location = new System.Drawing.Point(304, 21);
            this.textBox_period.Name = "textBox_period";
            this.textBox_period.Size = new System.Drawing.Size(70, 22);
            this.textBox_period.TabIndex = 1;
            this.textBox_period.Text = "30";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "روز یک بار اجرا شود.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "این عملیات هر";
            // 
            // compositAsset
            // 
            this.compositAsset.AutoSize = true;
            this.compositAsset.Checked = true;
            this.compositAsset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compositAsset.Location = new System.Drawing.Point(339, 248);
            this.compositAsset.Name = "compositAsset";
            this.compositAsset.Size = new System.Drawing.Size(143, 18);
            this.compositAsset.TabIndex = 5;
            this.compositAsset.Text = "این عملیات مرکب است";
            this.compositAsset.UseVisualStyleBackColor = true;
            this.compositAsset.CheckedChanged += new System.EventHandler(this.compositAsset_CheckedChanged);
            // 
            // subAssets
            // 
            this.subAssets.Controls.Add(this.subActionList);
            this.subAssets.Controls.Add(this.removeSubAssetBut);
            this.subAssets.Controls.Add(this.button1);
            this.subAssets.Location = new System.Drawing.Point(15, 272);
            this.subAssets.Name = "subAssets";
            this.subAssets.Size = new System.Drawing.Size(467, 201);
            this.subAssets.TabIndex = 6;
            this.subAssets.TabStop = false;
            this.subAssets.Text = "زیرعملیات‌ها:";
            // 
            // subActionList
            // 
            this.subActionList.FormattingEnabled = true;
            this.subActionList.ItemHeight = 14;
            this.subActionList.Location = new System.Drawing.Point(8, 21);
            this.subActionList.Name = "subActionList";
            this.subActionList.Size = new System.Drawing.Size(382, 172);
            this.subActionList.TabIndex = 3;
            this.subActionList.SelectedIndexChanged += new System.EventHandler(this.subActionList_SelectedIndexChanged);
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
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(15, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 38);
            this.panel2.TabIndex = 7;
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
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مشاهدهمشخصاتToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 26);
            // 
            // مشاهدهمشخصاتToolStripMenuItem
            // 
            this.مشاهدهمشخصاتToolStripMenuItem.Image = global::Divan.Properties.Resources.note;
            this.مشاهدهمشخصاتToolStripMenuItem.Name = "مشاهدهمشخصاتToolStripMenuItem";
            this.مشاهدهمشخصاتToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.مشاهدهمشخصاتToolStripMenuItem.Text = "مشاهده مشخصات زیربرچسب";
            // 
            // NewActionWindow
            // 
            this.AcceptButton = this.button3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(497, 536);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewActionWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعریف عملیات جدید";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.domainGroup.ResumeLayout(false);
            this.domainGroup.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.runTime.ResumeLayout(false);
            this.runTime.PerformLayout();
            this.subAssets.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox domainGroup;
        private System.Windows.Forms.GroupBox subAssets;
        private System.Windows.Forms.Button removeSubAssetBut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهمشخصاتToolStripMenuItem;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_asset;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_selectLabel;
        private System.Windows.Forms.Button button_selectAsset;
        private System.Windows.Forms.Label label_label;
        private System.Windows.Forms.CheckBox compositAsset;
        private System.Windows.Forms.ListBox subActionList;
        private System.Windows.Forms.CheckBox autoRunable;
        private System.Windows.Forms.GroupBox runTime;
        private System.Windows.Forms.TextBox textBox_period;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}