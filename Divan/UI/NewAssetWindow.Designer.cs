namespace Divan
{
    partial class NewAssetWindow
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("زیردارایی ۱.۱.۱");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("زیردارایی ۱.۱", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("زیردارایی ۱.۲");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("زیردارایی ۱.۳.۱");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("زیردارایی ۱.۳", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("زیردارایی ۱", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("زیردارایی ۲.۱");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("زیردارایی ۲", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("زیردارایی ۳");
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.humanAssetCh = new System.Windows.Forms.CheckBox();
            this.humanAssetProps = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sensibleAssetCh = new System.Windows.Forms.CheckBox();
            this.sensibleAssetProps = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSearchtxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.compositAsset = new System.Windows.Forms.CheckBox();
            this.subAssets = new System.Windows.Forms.GroupBox();
            this.subAssetsTree = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.attachmentList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.removeSubAssetBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteFileBut = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.humanAssetProps.SuspendLayout();
            this.sensibleAssetProps.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.subAssets.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.humanAssetCh);
            this.flowLayoutPanel1.Controls.Add(this.humanAssetProps);
            this.flowLayoutPanel1.Controls.Add(this.sensibleAssetCh);
            this.flowLayoutPanel1.Controls.Add(this.sensibleAssetProps);
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.compositAsset);
            this.flowLayoutPanel1.Controls.Add(this.subAssets);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(23, 22, 23, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12, 11, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(968, 535);
            this.flowLayoutPanel1.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.nameTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(486, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 32);
            this.panel1.TabIndex = 0;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(8, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(138, 22);
            this.textBox8.TabIndex = 2;
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
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(252, 3);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(138, 22);
            this.nameTxt.TabIndex = 0;
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
            // humanAssetCh
            // 
            this.humanAssetCh.AutoSize = true;
            this.humanAssetCh.Checked = true;
            this.humanAssetCh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.humanAssetCh.Location = new System.Drawing.Point(805, 52);
            this.humanAssetCh.Name = "humanAssetCh";
            this.humanAssetCh.Size = new System.Drawing.Size(148, 18);
            this.humanAssetCh.TabIndex = 2;
            this.humanAssetCh.Text = "این دارایی انسانی است";
            this.humanAssetCh.UseVisualStyleBackColor = true;
            this.humanAssetCh.CheckedChanged += new System.EventHandler(this.humanAssetCh_CheckedChanged);
            // 
            // humanAssetProps
            // 
            this.humanAssetProps.Controls.Add(this.textBox6);
            this.humanAssetProps.Controls.Add(this.label6);
            this.humanAssetProps.Controls.Add(this.textBox7);
            this.humanAssetProps.Controls.Add(this.label7);
            this.humanAssetProps.Controls.Add(this.textBox5);
            this.humanAssetProps.Controls.Add(this.label5);
            this.humanAssetProps.Controls.Add(this.textBox4);
            this.humanAssetProps.Controls.Add(this.label4);
            this.humanAssetProps.Controls.Add(this.textBox2);
            this.humanAssetProps.Controls.Add(this.label2);
            this.humanAssetProps.Location = new System.Drawing.Point(486, 76);
            this.humanAssetProps.Name = "humanAssetProps";
            this.humanAssetProps.Size = new System.Drawing.Size(467, 102);
            this.humanAssetProps.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(8, 32);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(138, 22);
            this.textBox6.TabIndex = 7;
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
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(8, 60);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(382, 37);
            this.textBox7.TabIndex = 8;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(252, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(138, 22);
            this.textBox5.TabIndex = 6;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(8, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(138, 22);
            this.textBox4.TabIndex = 5;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 22);
            this.textBox2.TabIndex = 4;
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
            // sensibleAssetCh
            // 
            this.sensibleAssetCh.AutoSize = true;
            this.sensibleAssetCh.Checked = true;
            this.sensibleAssetCh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sensibleAssetCh.Location = new System.Drawing.Point(806, 184);
            this.sensibleAssetCh.Name = "sensibleAssetCh";
            this.sensibleAssetCh.Size = new System.Drawing.Size(147, 18);
            this.sensibleAssetCh.TabIndex = 4;
            this.sensibleAssetCh.Text = "این دارایی ملموس است";
            this.sensibleAssetCh.UseVisualStyleBackColor = true;
            this.sensibleAssetCh.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // sensibleAssetProps
            // 
            this.sensibleAssetProps.Controls.Add(this.textBox9);
            this.sensibleAssetProps.Controls.Add(this.label12);
            this.sensibleAssetProps.Location = new System.Drawing.Point(486, 208);
            this.sensibleAssetProps.Name = "sensibleAssetProps";
            this.sensibleAssetProps.Size = new System.Drawing.Size(467, 70);
            this.sensibleAssetProps.TabIndex = 5;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(8, 26);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(451, 37);
            this.textBox9.TabIndex = 10;
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(802, 284);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(151, 18);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "این دارایی مکان‌مند است";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.humanAssetCh_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(774, 308);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(179, 18);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "این دارایی متغییر در زمان است";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.humanAssetCh_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(486, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 197);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات اولیه:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.type,
            this.value});
            this.dataGridView1.Location = new System.Drawing.Point(8, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 166);
            this.dataGridView1.TabIndex = 13;
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
            // labelSearchtxt
            // 
            this.labelSearchtxt.Location = new System.Drawing.Point(8, 46);
            this.labelSearchtxt.Name = "labelSearchtxt";
            this.labelSearchtxt.Size = new System.Drawing.Size(222, 22);
            this.labelSearchtxt.TabIndex = 15;
            this.labelSearchtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // compositAsset
            // 
            this.compositAsset.AutoSize = true;
            this.compositAsset.Checked = true;
            this.compositAsset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compositAsset.Location = new System.Drawing.Point(342, 192);
            this.compositAsset.Name = "compositAsset";
            this.compositAsset.Size = new System.Drawing.Size(138, 18);
            this.compositAsset.TabIndex = 4;
            this.compositAsset.Text = "این دارایی مرکب است";
            this.compositAsset.UseVisualStyleBackColor = true;
            this.compositAsset.CheckedChanged += new System.EventHandler(this.compositAsset_CheckedChanged);
            // 
            // subAssets
            // 
            this.subAssets.Controls.Add(this.removeSubAssetBut);
            this.subAssets.Controls.Add(this.button1);
            this.subAssets.Controls.Add(this.subAssetsTree);
            this.subAssets.Location = new System.Drawing.Point(13, 216);
            this.subAssets.Name = "subAssets";
            this.subAssets.Size = new System.Drawing.Size(467, 173);
            this.subAssets.TabIndex = 10;
            this.subAssets.TabStop = false;
            this.subAssets.Text = "زیردارایی‌ها:";
            // 
            // subAssetsTree
            // 
            this.subAssetsTree.Location = new System.Drawing.Point(7, 22);
            this.subAssetsTree.Name = "subAssetsTree";
            treeNode1.Name = "Node6";
            treeNode1.Text = "زیردارایی ۱.۱.۱";
            treeNode2.Name = "Node3";
            treeNode2.Text = "زیردارایی ۱.۱";
            treeNode3.Name = "Node4";
            treeNode3.Text = "زیردارایی ۱.۲";
            treeNode4.Name = "Node7";
            treeNode4.Text = "زیردارایی ۱.۳.۱";
            treeNode5.Name = "Node5";
            treeNode5.Text = "زیردارایی ۱.۳";
            treeNode6.Name = "Node0";
            treeNode6.Text = "زیردارایی ۱";
            treeNode7.Name = "Node8";
            treeNode7.Text = "زیردارایی ۲.۱";
            treeNode8.Name = "Node1";
            treeNode8.Text = "زیردارایی ۲";
            treeNode9.Name = "Node2";
            treeNode9.Text = "زیردارایی ۳";
            this.subAssetsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode8,
            treeNode9});
            this.subAssetsTree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subAssetsTree.RightToLeftLayout = true;
            this.subAssetsTree.Size = new System.Drawing.Size(376, 143);
            this.subAssetsTree.TabIndex = 18;
            this.subAssetsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.subAssetsTree.Enter += new System.EventHandler(this.subAssetsTree_Leave);
            this.subAssetsTree.Leave += new System.EventHandler(this.subAssetsTree_Leave);
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
            // attachmentList
            // 
            this.attachmentList.FormattingEnabled = true;
            this.attachmentList.ItemHeight = 14;
            this.attachmentList.Location = new System.Drawing.Point(8, 21);
            this.attachmentList.Name = "attachmentList";
            this.attachmentList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.attachmentList.Size = new System.Drawing.Size(375, 60);
            this.attachmentList.TabIndex = 18;
            this.attachmentList.SelectedIndexChanged += new System.EventHandler(this.attachmentList_SelectedIndexChanged);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.removeSubAssetBut.Click += new System.EventHandler(this.removeSubAssetBut_Click);
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
            this.deleteFileBut.Click += new System.EventHandler(this.button2_Click);
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
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // NewAsset
            // 
            this.AcceptButton = this.button3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(968, 535);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewAsset";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعریف دارایی جدید";
            this.Load += new System.EventHandler(this.NewAsset_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.humanAssetProps.ResumeLayout(false);
            this.humanAssetProps.PerformLayout();
            this.sensibleAssetProps.ResumeLayout(false);
            this.sensibleAssetProps.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.subAssets.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox humanAssetCh;
        private System.Windows.Forms.Panel humanAssetProps;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox sensibleAssetCh;
        private System.Windows.Forms.Panel sensibleAssetProps;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox subAssets;
        private System.Windows.Forms.Button removeSubAssetBut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView subAssetsTree;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewComboBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox labelSearchtxt;
        private System.Windows.Forms.CheckBox compositAsset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox attachmentList;
        private System.Windows.Forms.Button deleteFileBut;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}