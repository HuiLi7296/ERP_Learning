namespace ERP_Learning.HR
{
    partial class FormEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolModify = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbxCondition = new System.Windows.Forms.ToolStripComboBox();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolSearch = new System.Windows.Forms.ToolStripButton();
            this.toolrefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.EmployeeInfo = new System.Windows.Forms.GroupBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxDeptCode = new System.Windows.Forms.ComboBox();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.cbxEduLvl = new System.Windows.Forms.ComboBox();
            this.cbxActive = new System.Windows.Forms.ComboBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDNum = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEmployeeInfo = new System.Windows.Forms.DataGridView();
            this.员工编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.员工姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否在职 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.身份证号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.邮箱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入职时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.更新时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.出生日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学历 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.formEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formEmployeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.EmployeeInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formEmployeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolCancel,
            this.toolAdd,
            this.toolModify,
            this.toolDelete,
            this.toolStripLabel1,
            this.cbxCondition,
            this.txtSearch,
            this.toolSearch,
            this.toolrefresh,
            this.toolStripSeparator1,
            this.toolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(852, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSave
            // 
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(52, 22);
            this.toolSave.Text = "保存";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolCancel
            // 
            this.toolCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolCancel.Image")));
            this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.Size = new System.Drawing.Size(52, 22);
            this.toolCancel.Text = "取消";
            this.toolCancel.Click += new System.EventHandler(this.toolCancel_Click);
            // 
            // toolAdd
            // 
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(52, 22);
            this.toolAdd.Text = "添加";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolModify
            // 
            this.toolModify.Image = ((System.Drawing.Image)(resources.GetObject("toolModify.Image")));
            this.toolModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolModify.Name = "toolModify";
            this.toolModify.Size = new System.Drawing.Size(52, 22);
            this.toolModify.Text = "修改";
            this.toolModify.Click += new System.EventHandler(this.toolModify_Click);
            // 
            // toolDelete
            // 
            this.toolDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolDelete.Image")));
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(52, 22);
            this.toolDelete.Text = "删除";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "查询条件：";
            // 
            // cbxCondition
            // 
            this.cbxCondition.Name = "cbxCondition";
            this.cbxCondition.Size = new System.Drawing.Size(121, 25);
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 25);
            // 
            // toolSearch
            // 
            this.toolSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolSearch.Image")));
            this.toolSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSearch.Name = "toolSearch";
            this.toolSearch.Size = new System.Drawing.Size(52, 22);
            this.toolSearch.Text = "查找";
            this.toolSearch.Click += new System.EventHandler(this.toolSearch_Click);
            // 
            // toolrefresh
            // 
            this.toolrefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolrefresh.Image")));
            this.toolrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolrefresh.Name = "toolrefresh";
            this.toolrefresh.Size = new System.Drawing.Size(52, 22);
            this.toolrefresh.Text = "刷新";
            this.toolrefresh.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolExit
            // 
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(52, 22);
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // EmployeeInfo
            // 
            this.EmployeeInfo.Controls.Add(this.dtpBirthday);
            this.EmployeeInfo.Controls.Add(this.label11);
            this.EmployeeInfo.Controls.Add(this.cbxDeptCode);
            this.EmployeeInfo.Controls.Add(this.dtpEntryDate);
            this.EmployeeInfo.Controls.Add(this.cbxEduLvl);
            this.EmployeeInfo.Controls.Add(this.cbxActive);
            this.EmployeeInfo.Controls.Add(this.cbxGender);
            this.EmployeeInfo.Controls.Add(this.txtPhone);
            this.EmployeeInfo.Controls.Add(this.label7);
            this.EmployeeInfo.Controls.Add(this.label8);
            this.EmployeeInfo.Controls.Add(this.txtAddress);
            this.EmployeeInfo.Controls.Add(this.label13);
            this.EmployeeInfo.Controls.Add(this.txtEmail);
            this.EmployeeInfo.Controls.Add(this.label12);
            this.EmployeeInfo.Controls.Add(this.txtJob);
            this.EmployeeInfo.Controls.Add(this.label9);
            this.EmployeeInfo.Controls.Add(this.label6);
            this.EmployeeInfo.Controls.Add(this.label14);
            this.EmployeeInfo.Controls.Add(this.label5);
            this.EmployeeInfo.Controls.Add(this.txtAge);
            this.EmployeeInfo.Controls.Add(this.label4);
            this.EmployeeInfo.Controls.Add(this.label3);
            this.EmployeeInfo.Controls.Add(this.txtIDNum);
            this.EmployeeInfo.Controls.Add(this.txtEmployeeName);
            this.EmployeeInfo.Controls.Add(this.label10);
            this.EmployeeInfo.Controls.Add(this.label2);
            this.EmployeeInfo.Controls.Add(this.txtEmployeeID);
            this.EmployeeInfo.Controls.Add(this.label1);
            this.EmployeeInfo.Location = new System.Drawing.Point(12, 63);
            this.EmployeeInfo.Name = "EmployeeInfo";
            this.EmployeeInfo.Size = new System.Drawing.Size(828, 232);
            this.EmployeeInfo.TabIndex = 1;
            this.EmployeeInfo.TabStop = false;
            this.EmployeeInfo.Text = "员工信息";
            this.EmployeeInfo.Enter += new System.EventHandler(this.EmployeeInfo_Enter);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(489, 121);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(100, 20);
            this.dtpBirthday.TabIndex = 11;
            this.dtpBirthday.Value = new System.DateTime(2018, 1, 28, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(416, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "出生日期";
            // 
            // cbxDeptCode
            // 
            this.cbxDeptCode.FormattingEnabled = true;
            this.cbxDeptCode.Location = new System.Drawing.Point(489, 29);
            this.cbxDeptCode.Name = "cbxDeptCode";
            this.cbxDeptCode.Size = new System.Drawing.Size(100, 21);
            this.cbxDeptCode.TabIndex = 3;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Location = new System.Drawing.Point(282, 119);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(99, 20);
            this.dtpEntryDate.TabIndex = 10;
            // 
            // cbxEduLvl
            // 
            this.cbxEduLvl.FormattingEnabled = true;
            this.cbxEduLvl.Location = new System.Drawing.Point(489, 69);
            this.cbxEduLvl.Name = "cbxEduLvl";
            this.cbxEduLvl.Size = new System.Drawing.Size(100, 21);
            this.cbxEduLvl.TabIndex = 7;
            // 
            // cbxActive
            // 
            this.cbxActive.FormattingEnabled = true;
            this.cbxActive.Location = new System.Drawing.Point(697, 125);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(50, 21);
            this.cbxActive.TabIndex = 12;
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(283, 70);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(50, 21);
            this.cbxGender.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(695, 71);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(129, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "联系电话";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "入职日期";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(284, 166);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(329, 20);
            this.txtAddress.TabIndex = 14;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(223, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "地    址";
            this.label13.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(69, 166);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "邮    箱";
            this.label12.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(68, 119);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(100, 20);
            this.txtJob.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "职    位";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "学    历";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(623, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "是否在职";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "性    别";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(68, 73);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "年    龄";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "部    门";
            // 
            // txtIDNum
            // 
            this.txtIDNum.Location = new System.Drawing.Point(695, 32);
            this.txtIDNum.Name = "txtIDNum";
            this.txtIDNum.Size = new System.Drawing.Size(129, 20);
            this.txtIDNum.TabIndex = 4;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(284, 30);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(97, 20);
            this.txtEmployeeName.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(622, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "身份证号";
            this.label10.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "员工名称";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(69, 30);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工编号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEmployeeInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "员工记录";
            // 
            // dgvEmployeeInfo
            // 
            this.dgvEmployeeInfo.CausesValidation = false;
            this.dgvEmployeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.员工编号,
            this.员工姓名,
            this.是否在职,
            this.身份证号,
            this.性别,
            this.邮箱,
            this.联系电话,
            this.地址,
            this.入职时间,
            this.更新时间,
            this.DepartmentName,
            this.出生日期,
            this.职位,
            this.学历});
            this.dgvEmployeeInfo.Location = new System.Drawing.Point(10, 28);
            this.dgvEmployeeInfo.Name = "dgvEmployeeInfo";
            this.dgvEmployeeInfo.Size = new System.Drawing.Size(711, 150);
            this.dgvEmployeeInfo.TabIndex = 0;
            this.dgvEmployeeInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeInfo_CellClick);
            // 
            // 员工编号
            // 
            this.员工编号.DataPropertyName = "EmployeeID";
            this.员工编号.HeaderText = "员工编号";
            this.员工编号.Name = "员工编号";
            this.员工编号.ReadOnly = true;
            // 
            // 员工姓名
            // 
            this.员工姓名.DataPropertyName = "EmployeeName";
            this.员工姓名.HeaderText = "员工姓名";
            this.员工姓名.Name = "员工姓名";
            this.员工姓名.ReadOnly = true;
            // 
            // 是否在职
            // 
            this.是否在职.DataPropertyName = "IsActive";
            this.是否在职.HeaderText = "是否在职";
            this.是否在职.Name = "是否在职";
            this.是否在职.ReadOnly = true;
            // 
            // 身份证号
            // 
            this.身份证号.DataPropertyName = "IDNumber";
            this.身份证号.HeaderText = "身份证号";
            this.身份证号.Name = "身份证号";
            this.身份证号.ReadOnly = true;
            // 
            // 性别
            // 
            this.性别.DataPropertyName = "gender";
            this.性别.HeaderText = "性别";
            this.性别.Items.AddRange(new object[] {
            "gender"});
            this.性别.Name = "性别";
            this.性别.ReadOnly = true;
            // 
            // 邮箱
            // 
            this.邮箱.DataPropertyName = "Email";
            this.邮箱.HeaderText = "邮箱";
            this.邮箱.Name = "邮箱";
            this.邮箱.ReadOnly = true;
            // 
            // 联系电话
            // 
            this.联系电话.DataPropertyName = "Phone";
            this.联系电话.HeaderText = "联系电话";
            this.联系电话.Name = "联系电话";
            this.联系电话.ReadOnly = true;
            // 
            // 地址
            // 
            this.地址.DataPropertyName = "Address";
            this.地址.HeaderText = "地址";
            this.地址.Name = "地址";
            this.地址.ReadOnly = true;
            // 
            // 入职时间
            // 
            this.入职时间.DataPropertyName = "EntryDate";
            this.入职时间.HeaderText = "入职时间";
            this.入职时间.Name = "入职时间";
            this.入职时间.ReadOnly = true;
            // 
            // 更新时间
            // 
            this.更新时间.DataPropertyName = "ChangeDate";
            this.更新时间.HeaderText = "更新时间";
            this.更新时间.Name = "更新时间";
            this.更新时间.ReadOnly = true;
            // 
            // DepartmentName
            // 
            this.DepartmentName.DataPropertyName = "DepartmentName";
            this.DepartmentName.HeaderText = "部门";
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.ReadOnly = true;
            // 
            // 出生日期
            // 
            this.出生日期.DataPropertyName = "BirthDay";
            this.出生日期.HeaderText = "出生日期";
            this.出生日期.Name = "出生日期";
            this.出生日期.ReadOnly = true;
            // 
            // 职位
            // 
            this.职位.DataPropertyName = "Position";
            this.职位.HeaderText = "职位";
            this.职位.Name = "职位";
            this.职位.ReadOnly = true;
            // 
            // 学历
            // 
            this.学历.DataPropertyName = "EducationLevel";
            this.学历.HeaderText = "学历";
            this.学历.Name = "学历";
            this.学历.ReadOnly = true;
            // 
            // formEmployeeBindingSource
            // 
            this.formEmployeeBindingSource.DataSource = typeof(ERP_Learning.HR.FormEmployee);
            // 
            // formEmployeeBindingSource1
            // 
            this.formEmployeeBindingSource1.DataSource = typeof(ERP_Learning.HR.FormEmployee);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EmployeeInfo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormEmployee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.EmployeeInfo.ResumeLayout(false);
            this.EmployeeInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formEmployeeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolCancel;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolModify;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbxCondition;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton toolSearch;
        private System.Windows.Forms.GroupBox EmployeeInfo;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.ComboBox cbxEduLvl;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEmployeeInfo;
        private System.Windows.Forms.ComboBox cbxDeptCode;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIDNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxActive;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripButton toolrefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.BindingSource formEmployeeBindingSource;
        private System.Windows.Forms.BindingSource formEmployeeBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工姓名;
        private System.Windows.Forms.DataGridViewComboBoxColumn 是否在职;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证号;
        private System.Windows.Forms.DataGridViewComboBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 邮箱;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入职时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 更新时间;
        private System.Windows.Forms.DataGridViewComboBoxColumn DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出生日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职位;
        private System.Windows.Forms.DataGridViewComboBoxColumn 学历;
    }
}