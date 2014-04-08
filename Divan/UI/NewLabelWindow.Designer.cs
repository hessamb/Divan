namespace Divan
{
    partial class NewLabelWindow
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
            this.unvalueableRadio = new System.Windows.Forms.RadioButton();
            this.valueableOpt = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.domainGroup = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.continiousProps = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_minValue = new System.Windows.Forms.TextBox();
            this.textBox_maxValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.discSetPanel = new System.Windows.Forms.Panel();
            this.discNumericalPanel = new System.Windows.Forms.Panel();
            this.discMinValTxt = new System.Windows.Forms.NumericUpDown();
            this.discMaxValTxt = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ordinalValues = new System.Windows.Forms.RadioButton();
            this.domainGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveUp = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MoveDown = new System.Windows.Forms.DataGridViewButtonColumn();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.continuousRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.discreteRadio = new System.Windows.Forms.RadioButton();
            this.checkBox_splitter = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.distinctProps = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.discNumbersRadio = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.domainGroup.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.continiousProps.SuspendLayout();
            this.discSetPanel.SuspendLayout();
            this.discNumericalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discMinValTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discMaxValTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.distinctProps.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.domainGroup);
            this.flowLayoutPanel1.Controls.Add(this.checkBox_splitter);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(23, 22, 23, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12, 11, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(493, 597);
            this.flowLayoutPanel1.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.unvalueableRadio);
            this.panel1.Controls.Add(this.valueableOpt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 30);
            this.panel1.TabIndex = 0;
            // 
            // unvalueableRadio
            // 
            this.unvalueableRadio.AutoSize = true;
            this.unvalueableRadio.Location = new System.Drawing.Point(8, 4);
            this.unvalueableRadio.Name = "unvalueableRadio";
            this.unvalueableRadio.Size = new System.Drawing.Size(76, 18);
            this.unvalueableRadio.TabIndex = 4;
            this.unvalueableRadio.Text = "مقدارناپذیر";
            this.unvalueableRadio.UseVisualStyleBackColor = true;
            // 
            // valueableOpt
            // 
            this.valueableOpt.AutoSize = true;
            this.valueableOpt.Checked = true;
            this.valueableOpt.Location = new System.Drawing.Point(90, 4);
            this.valueableOpt.Name = "valueableOpt";
            this.valueableOpt.Size = new System.Drawing.Size(69, 18);
            this.valueableOpt.TabIndex = 3;
            this.valueableOpt.TabStop = true;
            this.valueableOpt.Text = "مقدارپذیر";
            this.valueableOpt.UseVisualStyleBackColor = true;
            this.valueableOpt.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "نوع برچسب:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(252, 3);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(138, 22);
            this.nameTxt.TabIndex = 0;
            this.nameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.nameTxt_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام برچسب:";
            // 
            // domainGroup
            // 
            this.domainGroup.AutoSize = true;
            this.domainGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.domainGroup.Controls.Add(this.flowLayoutPanel2);
            this.domainGroup.Controls.Add(this.continuousRadio);
            this.domainGroup.Controls.Add(this.label3);
            this.domainGroup.Controls.Add(this.discreteRadio);
            this.domainGroup.Location = new System.Drawing.Point(9, 50);
            this.domainGroup.Name = "domainGroup";
            this.domainGroup.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.domainGroup.Size = new System.Drawing.Size(469, 325);
            this.domainGroup.TabIndex = 1;
            this.domainGroup.TabStop = false;
            this.domainGroup.Text = "دامنه مقادیر";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.continiousProps);
            this.flowLayoutPanel2.Controls.Add(this.distinctProps);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 43);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(456, 267);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // continiousProps
            // 
            this.continiousProps.Controls.Add(this.label9);
            this.continiousProps.Controls.Add(this.textBox_minValue);
            this.continiousProps.Controls.Add(this.textBox_maxValue);
            this.continiousProps.Controls.Add(this.label10);
            this.continiousProps.Location = new System.Drawing.Point(3, 3);
            this.continiousProps.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.continiousProps.Name = "continiousProps";
            this.continiousProps.Size = new System.Drawing.Size(450, 23);
            this.continiousProps.TabIndex = 1;
            this.continiousProps.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "از:";
            // 
            // textBox_minValue
            // 
            this.textBox_minValue.Location = new System.Drawing.Point(314, 0);
            this.textBox_minValue.Name = "textBox_minValue";
            this.textBox_minValue.Size = new System.Drawing.Size(111, 22);
            this.textBox_minValue.TabIndex = 1;
            this.textBox_minValue.Text = "0.0";
            this.textBox_minValue.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_minValue_Validating);
            // 
            // textBox_maxValue
            // 
            this.textBox_maxValue.Location = new System.Drawing.Point(153, 0);
            this.textBox_maxValue.Name = "textBox_maxValue";
            this.textBox_maxValue.Size = new System.Drawing.Size(113, 22);
            this.textBox_maxValue.TabIndex = 2;
            this.textBox_maxValue.Text = "100.0";
            this.textBox_maxValue.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_minValue_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 14);
            this.label10.TabIndex = 2;
            this.label10.Text = "تا:";
            // 
            // discSetPanel
            // 
            this.discSetPanel.Controls.Add(this.radioButton3);
            this.discSetPanel.Controls.Add(this.domainGrid);
            this.discSetPanel.Controls.Add(this.label7);
            this.discSetPanel.Controls.Add(this.ordinalValues);
            this.discSetPanel.Location = new System.Drawing.Point(3, 60);
            this.discSetPanel.Name = "discSetPanel";
            this.discSetPanel.Size = new System.Drawing.Size(444, 172);
            this.discSetPanel.TabIndex = 5;
            // 
            // discNumericalPanel
            // 
            this.discNumericalPanel.Controls.Add(this.discMinValTxt);
            this.discNumericalPanel.Controls.Add(this.discMaxValTxt);
            this.discNumericalPanel.Controls.Add(this.label4);
            this.discNumericalPanel.Controls.Add(this.label5);
            this.discNumericalPanel.Location = new System.Drawing.Point(3, 32);
            this.discNumericalPanel.Name = "discNumericalPanel";
            this.discNumericalPanel.Size = new System.Drawing.Size(444, 22);
            this.discNumericalPanel.TabIndex = 4;
            this.discNumericalPanel.Visible = false;
            // 
            // discMinValTxt
            // 
            this.discMinValTxt.Location = new System.Drawing.Point(309, 0);
            this.discMinValTxt.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.discMinValTxt.Minimum = new decimal(new int[] {
            2000000000,
            0,
            0,
            -2147483648});
            this.discMinValTxt.Name = "discMinValTxt";
            this.discMinValTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.discMinValTxt.Size = new System.Drawing.Size(113, 22);
            this.discMinValTxt.TabIndex = 8;
            // 
            // discMaxValTxt
            // 
            this.discMaxValTxt.Location = new System.Drawing.Point(150, 0);
            this.discMaxValTxt.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.discMaxValTxt.Minimum = new decimal(new int[] {
            2000000000,
            0,
            0,
            -2147483648});
            this.discMaxValTxt.Name = "discMaxValTxt";
            this.discMaxValTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.discMaxValTxt.Size = new System.Drawing.Size(113, 22);
            this.discMaxValTxt.TabIndex = 7;
            this.discMaxValTxt.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "از:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "تا:";
            // 
            // ordinalValues
            // 
            this.ordinalValues.AutoSize = true;
            this.ordinalValues.Checked = true;
            this.ordinalValues.Location = new System.Drawing.Point(275, 2);
            this.ordinalValues.Name = "ordinalValues";
            this.ordinalValues.Size = new System.Drawing.Size(58, 18);
            this.ordinalValues.TabIndex = 2;
            this.ordinalValues.TabStop = true;
            this.ordinalValues.Text = "باترتیب";
            this.ordinalValues.UseVisualStyleBackColor = true;
            this.ordinalValues.CheckedChanged += new System.EventHandler(this.orderedValues_CheckedChanged);
            // 
            // domainGrid
            // 
            this.domainGrid.AllowUserToOrderColumns = true;
            this.domainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.domainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.MoveUp,
            this.MoveDown});
            this.domainGrid.Location = new System.Drawing.Point(3, 27);
            this.domainGrid.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.domainGrid.Name = "domainGrid";
            this.domainGrid.Size = new System.Drawing.Size(440, 144);
            this.domainGrid.TabIndex = 3;
            this.domainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.domainGrid_CellContentClick);
            this.domainGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.domainGrid_CellValidating);
            this.domainGrid.Validating += new System.ComponentModel.CancelEventHandler(this.domainGrid_Validating);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            // 
            // MoveUp
            // 
            this.MoveUp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MoveUp.HeaderText = "";
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Text = "^";
            this.MoveUp.UseColumnTextForButtonValue = true;
            this.MoveUp.Width = 22;
            // 
            // MoveDown
            // 
            this.MoveDown.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MoveDown.HeaderText = "";
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Text = "v";
            this.MoveDown.UseColumnTextForButtonValue = true;
            this.MoveDown.Width = 22;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(339, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(66, 18);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "بی‌ترتیب";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // continuousRadio
            // 
            this.continuousRadio.AutoSize = true;
            this.continuousRadio.Location = new System.Drawing.Point(252, 19);
            this.continuousRadio.Name = "continuousRadio";
            this.continuousRadio.Size = new System.Drawing.Size(60, 18);
            this.continuousRadio.TabIndex = 2;
            this.continuousRadio.Text = "پیوسته";
            this.continuousRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "فضای حالت:";
            // 
            // discreteRadio
            // 
            this.discreteRadio.AutoSize = true;
            this.discreteRadio.Checked = true;
            this.discreteRadio.Location = new System.Drawing.Point(318, 19);
            this.discreteRadio.Name = "discreteRadio";
            this.discreteRadio.Size = new System.Drawing.Size(68, 18);
            this.discreteRadio.TabIndex = 1;
            this.discreteRadio.TabStop = true;
            this.discreteRadio.Text = "گسسته";
            this.discreteRadio.UseVisualStyleBackColor = true;
            this.discreteRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkBox_splitter
            // 
            this.checkBox_splitter.AutoSize = true;
            this.checkBox_splitter.Location = new System.Drawing.Point(255, 381);
            this.checkBox_splitter.Name = "checkBox_splitter";
            this.checkBox_splitter.Size = new System.Drawing.Size(223, 18);
            this.checkBox_splitter.TabIndex = 2;
            this.checkBox_splitter.Text = "این برچسب از نوع تعریف‌گر دارایی است";
            this.checkBox_splitter.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(11, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 38);
            this.panel2.TabIndex = 8;
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
            // error
            // 
            this.error.ContainerControl = this;
            this.error.RightToLeft = true;
            // 
            // distinctProps
            // 
            this.distinctProps.AutoSize = true;
            this.distinctProps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.distinctProps.Controls.Add(this.panel3);
            this.distinctProps.Controls.Add(this.discNumericalPanel);
            this.distinctProps.Controls.Add(this.discSetPanel);
            this.distinctProps.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.distinctProps.Location = new System.Drawing.Point(3, 29);
            this.distinctProps.Name = "distinctProps";
            this.distinctProps.Size = new System.Drawing.Size(450, 235);
            this.distinctProps.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.discNumbersRadio);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 23);
            this.panel3.TabIndex = 6;
            // 
            // discNumbersRadio
            // 
            this.discNumbersRadio.AutoSize = true;
            this.discNumbersRadio.Location = new System.Drawing.Point(332, 2);
            this.discNumbersRadio.Name = "discNumbersRadio";
            this.discNumbersRadio.Size = new System.Drawing.Size(84, 18);
            this.discNumbersRadio.TabIndex = 1;
            this.discNumbersRadio.Text = "اعداد صحیح";
            this.discNumbersRadio.UseVisualStyleBackColor = true;
            this.discNumbersRadio.CheckedChanged += new System.EventHandler(this.discNumbersRadio_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "نوع:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(227, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 18);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "مجموعه مقادیر";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "ترتیب:";
            // 
            // NewLabelWindow
            // 
            this.AcceptButton = this.button3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(493, 597);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewLabelWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعریف برچسب جدید";
            this.Load += new System.EventHandler(this.NewAsset_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.domainGroup.ResumeLayout(false);
            this.domainGroup.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.continiousProps.ResumeLayout(false);
            this.continiousProps.PerformLayout();
            this.discSetPanel.ResumeLayout(false);
            this.discSetPanel.PerformLayout();
            this.discNumericalPanel.ResumeLayout(false);
            this.discNumericalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discMinValTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discMaxValTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.distinctProps.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_splitter;
        private System.Windows.Forms.GroupBox domainGroup;
        private System.Windows.Forms.DataGridView domainGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton continuousRadio;
        private System.Windows.Forms.RadioButton discreteRadio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel continiousProps;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_minValue;
        private System.Windows.Forms.TextBox textBox_maxValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton ordinalValues;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton unvalueableRadio;
        private System.Windows.Forms.RadioButton valueableOpt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewButtonColumn MoveUp;
        private System.Windows.Forms.DataGridViewButtonColumn MoveDown;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel discSetPanel;
        private System.Windows.Forms.Panel discNumericalPanel;
        private System.Windows.Forms.NumericUpDown discMinValTxt;
        private System.Windows.Forms.NumericUpDown discMaxValTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel distinctProps;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton discNumbersRadio;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}