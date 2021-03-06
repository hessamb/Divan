﻿namespace Divan
{
    partial class EditAssetWindow
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
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox_isPhysical = new System.Windows.Forms.CheckBox();
            this.sensibleAssetProps = new System.Windows.Forms.Panel();
            this.textBox_PhysicalDescription = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSearchtxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.dataGrid_PrimaryInfo = new System.Windows.Forms.DataGridView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_isHuman = new System.Windows.Forms.CheckBox();
            this.humanAssetProps = new System.Windows.Forms.Panel();
            this.textBox_PersonnelCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_HumanDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_NationalID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView_subAssets = new System.Windows.Forms.TreeView();
            this.attachmentList = new System.Windows.Forms.ListBox();
            this.deleteFileBut = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_UID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.removeSubAssetBut = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox_isPortable = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_Composite = new System.Windows.Forms.CheckBox();
            this.GroupBox_subAssets = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sensibleAssetProps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_PrimaryInfo)).BeginInit();
            this.humanAssetProps.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GroupBox_subAssets.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button3.Image = global::Divan.Properties.Resources.accept;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(101, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 25);
            this.button3.TabIndex = 19;
            this.button3.Text = "تایید";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox_isPhysical
            // 
            this.checkBox_isPhysical.AutoSize = true;
            this.checkBox_isPhysical.Checked = true;
            this.checkBox_isPhysical.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_isPhysical.Location = new System.Drawing.Point(806, 184);
            this.checkBox_isPhysical.Name = "checkBox_isPhysical";
            this.checkBox_isPhysical.Size = new System.Drawing.Size(147, 18);
            this.checkBox_isPhysical.TabIndex = 4;
            this.checkBox_isPhysical.Text = "این دارایی ملموس است";
            this.checkBox_isPhysical.UseVisualStyleBackColor = true;
            this.checkBox_isPhysical.CheckedChanged += new System.EventHandler(this.checkBox_isPhysical_CheckedChanged);
            // 
            // sensibleAssetProps
            // 
            this.sensibleAssetProps.Controls.Add(this.textBox_PhysicalDescription);
            this.sensibleAssetProps.Controls.Add(this.label12);
            this.sensibleAssetProps.Location = new System.Drawing.Point(486, 208);
            this.sensibleAssetProps.Name = "sensibleAssetProps";
            this.sensibleAssetProps.Size = new System.Drawing.Size(467, 70);
            this.sensibleAssetProps.TabIndex = 5;
            // 
            // textBox_PhysicalDescription
            // 
            this.textBox_PhysicalDescription.Location = new System.Drawing.Point(8, 26);
            this.textBox_PhysicalDescription.Multiline = true;
            this.textBox_PhysicalDescription.Name = "textBox_PhysicalDescription";
            this.textBox_PhysicalDescription.Size = new System.Drawing.Size(451, 37);
            this.textBox_PhysicalDescription.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(267, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 14);
            this.label12.TabIndex = 2;
            this.label12.Text = "توضیحات مشخصات ظاهری دارایی:";
            // 
            // name
            // 
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.Width = 120;
            // 
            // type
            // 
            this.type.HeaderText = "نوع";
            this.type.Items.AddRange(new object[] {
            "عدد",
            "رشته",
            "بلی/خیر"});
            this.type.Name = "type";
            this.type.Width = 70;
            // 
            // value
            // 
            this.value.HeaderText = "مقدار";
            this.value.Name = "value";
            // 
            // labelSearchtxt
            // 
            this.labelSearchtxt.Location = new System.Drawing.Point(8, 46);
            this.labelSearchtxt.Name = "labelSearchtxt";
            this.labelSearchtxt.Size = new System.Drawing.Size(222, 22);
            this.labelSearchtxt.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(128, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 14);
            this.label14.TabIndex = 4;
            this.label14.Text = "برچسب‌های دیگر:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(274, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 14);
            this.label13.TabIndex = 4;
            this.label13.Text = "برچسب‌های تعریف‌گر نوع دارایی:";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "برچسب ۱",
            "برچسب ۲",
            "برچسب ۳",
            "برچسب ۴",
            "برچسب ۵",
            "برچسب ۶",
            "برچسب ۷"});
            this.checkedListBox2.Location = new System.Drawing.Point(8, 75);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(222, 89);
            this.checkedListBox2.TabIndex = 16;
            // 
            // dataGrid_PrimaryInfo
            // 
            this.dataGrid_PrimaryInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_PrimaryInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.type,
            this.value});
            this.dataGrid_PrimaryInfo.Location = new System.Drawing.Point(8, 24);
            this.dataGrid_PrimaryInfo.Name = "dataGrid_PrimaryInfo";
            this.dataGrid_PrimaryInfo.Size = new System.Drawing.Size(451, 166);
            this.dataGrid_PrimaryInfo.TabIndex = 13;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "خودرو",
            "ساختمان",
            "سند",
            "طلب مالی"});
            this.checkedListBox1.Location = new System.Drawing.Point(238, 41);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(221, 123);
            this.checkedListBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Image = global::Divan.Properties.Resources.add;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(389, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "افزودن";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_isHuman
            // 
            this.checkBox_isHuman.AutoSize = true;
            this.checkBox_isHuman.Checked = true;
            this.checkBox_isHuman.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_isHuman.Location = new System.Drawing.Point(805, 52);
            this.checkBox_isHuman.Name = "checkBox_isHuman";
            this.checkBox_isHuman.Size = new System.Drawing.Size(148, 18);
            this.checkBox_isHuman.TabIndex = 2;
            this.checkBox_isHuman.Text = "این دارایی انسانی است";
            this.checkBox_isHuman.UseVisualStyleBackColor = true;
            this.checkBox_isHuman.CheckedChanged += new System.EventHandler(this.checkBox_isHuman_CheckedChanged);
            // 
            // humanAssetProps
            // 
            this.humanAssetProps.Controls.Add(this.textBox_PersonnelCode);
            this.humanAssetProps.Controls.Add(this.label6);
            this.humanAssetProps.Controls.Add(this.textBox_HumanDescription);
            this.humanAssetProps.Controls.Add(this.label7);
            this.humanAssetProps.Controls.Add(this.textBox_NationalID);
            this.humanAssetProps.Controls.Add(this.label5);
            this.humanAssetProps.Controls.Add(this.textBox_LastName);
            this.humanAssetProps.Controls.Add(this.label4);
            this.humanAssetProps.Controls.Add(this.textBox_FirstName);
            this.humanAssetProps.Controls.Add(this.label2);
            this.humanAssetProps.Location = new System.Drawing.Point(486, 76);
            this.humanAssetProps.Name = "humanAssetProps";
            this.humanAssetProps.Size = new System.Drawing.Size(467, 102);
            this.humanAssetProps.TabIndex = 3;
            // 
            // textBox_PersonnelCode
            // 
            this.textBox_PersonnelCode.Location = new System.Drawing.Point(8, 32);
            this.textBox_PersonnelCode.Name = "textBox_PersonnelCode";
            this.textBox_PersonnelCode.Size = new System.Drawing.Size(138, 22);
            this.textBox_PersonnelCode.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "کد پرسنلی:";
            // 
            // textBox_HumanDescription
            // 
            this.textBox_HumanDescription.Location = new System.Drawing.Point(8, 60);
            this.textBox_HumanDescription.Multiline = true;
            this.textBox_HumanDescription.Name = "textBox_HumanDescription";
            this.textBox_HumanDescription.Size = new System.Drawing.Size(382, 37);
            this.textBox_HumanDescription.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "توضیحات:";
            // 
            // textBox_NationalID
            // 
            this.textBox_NationalID.Location = new System.Drawing.Point(252, 32);
            this.textBox_NationalID.Name = "textBox_NationalID";
            this.textBox_NationalID.Size = new System.Drawing.Size(138, 22);
            this.textBox_NationalID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "کد ملی:";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(8, 4);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(138, 22);
            this.textBox_LastName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "نام خانوادگی:";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(252, 4);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(138, 22);
            this.textBox_FirstName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام:";
            // 
            // treeView_subAssets
            // 
            this.treeView_subAssets.Location = new System.Drawing.Point(7, 22);
            this.treeView_subAssets.Name = "treeView_subAssets";
            this.treeView_subAssets.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeView_subAssets.RightToLeftLayout = true;
            this.treeView_subAssets.Size = new System.Drawing.Size(376, 143);
            this.treeView_subAssets.TabIndex = 18;
            // 
            // attachmentList
            // 
            this.attachmentList.FormattingEnabled = true;
            this.attachmentList.ItemHeight = 14;
            this.attachmentList.Location = new System.Drawing.Point(8, 21);
            this.attachmentList.Name = "attachmentList";
            this.attachmentList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.attachmentList.Size = new System.Drawing.Size(375, 60);
            this.attachmentList.TabIndex = 18;
            // 
            // deleteFileBut
            // 
            this.deleteFileBut.Enabled = false;
            this.deleteFileBut.Image = global::Divan.Properties.Resources.delete;
            this.deleteFileBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteFileBut.Location = new System.Drawing.Point(389, 53);
            this.deleteFileBut.Name = "deleteFileBut";
            this.deleteFileBut.Size = new System.Drawing.Size(71, 25);
            this.deleteFileBut.TabIndex = 17;
            this.deleteFileBut.Text = "حذف";
            this.deleteFileBut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteFileBut.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::Divan.Properties.Resources.add;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(389, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 25);
            this.button5.TabIndex = 16;
            this.button5.Text = "افزودن";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_UID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(486, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 32);
            this.panel1.TabIndex = 0;
            // 
            // textBox_UID
            // 
            this.textBox_UID.Location = new System.Drawing.Point(8, 3);
            this.textBox_UID.Name = "textBox_UID";
            this.textBox_UID.Size = new System.Drawing.Size(138, 22);
            this.textBox_UID.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = "شناسه دارایی:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(252, 3);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(138, 22);
            this.textBox_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام دارایی:";
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button4.Image = global::Divan.Properties.Resources.cross;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(7, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 25);
            this.button4.TabIndex = 20;
            this.button4.Text = "انصراف";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // removeSubAssetBut
            // 
            this.removeSubAssetBut.Enabled = false;
            this.removeSubAssetBut.Image = global::Divan.Properties.Resources.delete;
            this.removeSubAssetBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeSubAssetBut.Location = new System.Drawing.Point(389, 53);
            this.removeSubAssetBut.Name = "removeSubAssetBut";
            this.removeSubAssetBut.Size = new System.Drawing.Size(71, 25);
            this.removeSubAssetBut.TabIndex = 17;
            this.removeSubAssetBut.Text = "حذف";
            this.removeSubAssetBut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeSubAssetBut.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox_isPortable
            // 
            this.checkBox_isPortable.AutoSize = true;
            this.checkBox_isPortable.Location = new System.Drawing.Point(802, 284);
            this.checkBox_isPortable.Name = "checkBox_isPortable";
            this.checkBox_isPortable.Size = new System.Drawing.Size(151, 18);
            this.checkBox_isPortable.TabIndex = 6;
            this.checkBox_isPortable.Text = "این دارایی مکان‌مند است";
            this.checkBox_isPortable.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGrid_PrimaryInfo);
            this.groupBox1.Location = new System.Drawing.Point(486, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 197);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات اولیه:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox_isHuman);
            this.flowLayoutPanel1.Controls.Add(this.humanAssetProps);
            this.flowLayoutPanel1.Controls.Add(this.checkBox_isPhysical);
            this.flowLayoutPanel1.Controls.Add(this.sensibleAssetProps);
            this.flowLayoutPanel1.Controls.Add(this.checkBox_isPortable);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.checkBox_Composite);
            this.flowLayoutPanel1.Controls.Add(this.GroupBox_subAssets);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(23, 22, 23, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12, 11, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(968, 535);
            this.flowLayoutPanel1.TabIndex = 101;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSearchtxt);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.checkedListBox2);
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Location = new System.Drawing.Point(13, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 172);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "برچسب‌ها:";
            // 
            // checkBox_Composite
            // 
            this.checkBox_Composite.AutoSize = true;
            this.checkBox_Composite.Checked = true;
            this.checkBox_Composite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Composite.Location = new System.Drawing.Point(342, 192);
            this.checkBox_Composite.Name = "checkBox_Composite";
            this.checkBox_Composite.Size = new System.Drawing.Size(138, 18);
            this.checkBox_Composite.TabIndex = 4;
            this.checkBox_Composite.Text = "این دارایی مرکب است";
            this.checkBox_Composite.UseVisualStyleBackColor = true;
            // 
            // GroupBox_subAssets
            // 
            this.GroupBox_subAssets.Controls.Add(this.removeSubAssetBut);
            this.GroupBox_subAssets.Controls.Add(this.button1);
            this.GroupBox_subAssets.Controls.Add(this.treeView_subAssets);
            this.GroupBox_subAssets.Location = new System.Drawing.Point(13, 216);
            this.GroupBox_subAssets.Name = "GroupBox_subAssets";
            this.GroupBox_subAssets.Size = new System.Drawing.Size(467, 173);
            this.GroupBox_subAssets.TabIndex = 10;
            this.GroupBox_subAssets.TabStop = false;
            this.GroupBox_subAssets.Text = "زیردارایی‌ها:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.attachmentList);
            this.groupBox3.Controls.Add(this.deleteFileBut);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Location = new System.Drawing.Point(13, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 90);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "فایل‌های ضمیمه:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(13, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 38);
            this.panel2.TabIndex = 11;
            // 
            // EditAssetWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.ClientSize = new System.Drawing.Size(968, 535);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditAssetWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش دارایی";
            this.Load += new System.EventHandler(this.NewAsset_Load);
            this.sensibleAssetProps.ResumeLayout(false);
            this.sensibleAssetProps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_PrimaryInfo)).EndInit();
            this.humanAssetProps.ResumeLayout(false);
            this.humanAssetProps.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GroupBox_subAssets.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox_isPhysical;
        private System.Windows.Forms.Panel sensibleAssetProps;
        private System.Windows.Forms.TextBox textBox_PhysicalDescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewComboBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.TextBox labelSearchtxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.DataGridView dataGrid_PrimaryInfo;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_isHuman;
        private System.Windows.Forms.Panel humanAssetProps;
        private System.Windows.Forms.TextBox textBox_PersonnelCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_HumanDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_NationalID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView_subAssets;
        private System.Windows.Forms.ListBox attachmentList;
        private System.Windows.Forms.Button deleteFileBut;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_UID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button removeSubAssetBut;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBox_isPortable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_Composite;
        private System.Windows.Forms.GroupBox GroupBox_subAssets;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;

    }
}