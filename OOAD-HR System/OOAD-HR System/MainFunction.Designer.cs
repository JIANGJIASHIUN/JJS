namespace OOAD_HR_System
{
    partial class _mainFunction
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
            this._mainFunctionPage = new System.Windows.Forms.TabControl();
            this._employee = new System.Windows.Forms.TabPage();
            this._employeePage = new System.Windows.Forms.TabControl();
            this._newEmployee = new System.Windows.Forms.TabPage();
            this._newEmplSexCB = new System.Windows.Forms.ComboBox();
            this._insertButton = new System.Windows.Forms.Button();
            this._newEmplBloodCB = new System.Windows.Forms.ComboBox();
            this._newEmplBloodLB = new System.Windows.Forms.Label();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deptDataSet = new OOAD_HR_System.deptDataSet();
            this._newEmplDeptCB = new System.Windows.Forms.ComboBox();
            this._newEmplBasicSalaryTB = new System.Windows.Forms.TextBox();
            this._newEmplJobStatCB = new System.Windows.Forms.ComboBox();
            this._newEmplSpouseTB = new System.Windows.Forms.TextBox();
            this._newEmplMarriedStatCB = new System.Windows.Forms.ComboBox();
            this._newEmplMilitaryStatCB = new System.Windows.Forms.ComboBox();
            this._newEmplEmerPhoneTB = new System.Windows.Forms.TextBox();
            this._newEmplEmerPersonTB = new System.Windows.Forms.TextBox();
            this._newEmplAddrTB = new System.Windows.Forms.TextBox();
            this._newEmplPhoneTB = new System.Windows.Forms.TextBox();
            this._newEmpllSsnTB = new System.Windows.Forms.TextBox();
            this._newEmplBirthDP = new System.Windows.Forms.DateTimePicker();
            this._newEmplNameTB = new System.Windows.Forms.TextBox();
            this._newEmplIDTB = new System.Windows.Forms.TextBox();
            this._newEmplPositionIDLB = new System.Windows.Forms.Label();
            this._newEmplDeptIDLB = new System.Windows.Forms.Label();
            this._newEmplBasicSalaryLB = new System.Windows.Forms.Label();
            this._newEmplBirthLB = new System.Windows.Forms.Label();
            this._newEmplSpouseLB = new System.Windows.Forms.Label();
            this._newEmplMarriedStatLB = new System.Windows.Forms.Label();
            this._newEmplJobStatLB = new System.Windows.Forms.Label();
            this._newEmplMilitaryLB = new System.Windows.Forms.Label();
            this._newEmplEmerPhoneLB = new System.Windows.Forms.Label();
            this._newEmplEmerPersonLB = new System.Windows.Forms.Label();
            this._newEmplAddrLB = new System.Windows.Forms.Label();
            this._newEmplPhoneLB = new System.Windows.Forms.Label();
            this._newEmplSexLB = new System.Windows.Forms.Label();
            this._newEmplSsnLB = new System.Windows.Forms.Label();
            this._newEmplNameLB = new System.Windows.Forms.Label();
            this._newEmplIDLB = new System.Windows.Forms.Label();
            this._editEmployee = new System.Windows.Forms.TabPage();
            this._workAttendance = new System.Windows.Forms.TabPage();
            this._reimburse = new System.Windows.Forms.TabPage();
            this._bonus = new System.Windows.Forms.TabPage();
            this._salary = new System.Windows.Forms.TabPage();
            this._traning = new System.Windows.Forms.TabPage();
            this._careerPlanning = new System.Windows.Forms.TabPage();
            this._report = new System.Windows.Forms.TabPage();
            this._authorization = new System.Windows.Forms.TabPage();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionDataSet = new OOAD_HR_System.positionDataSet();
            this._logoutButton = new System.Windows.Forms.Button();
            this.departmentTableAdapter = new OOAD_HR_System.deptDataSetTableAdapters.departmentTableAdapter();
            this.positionTableAdapter = new OOAD_HR_System.positionDataSetTableAdapters.positionTableAdapter();
            this._newEmplPositionCB = new System.Windows.Forms.ComboBox();
            this._mainFunctionPage.SuspendLayout();
            this._employee.SuspendLayout();
            this._employeePage.SuspendLayout();
            this._newEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainFunctionPage
            // 
            this._mainFunctionPage.Controls.Add(this._employee);
            this._mainFunctionPage.Controls.Add(this._workAttendance);
            this._mainFunctionPage.Controls.Add(this._reimburse);
            this._mainFunctionPage.Controls.Add(this._bonus);
            this._mainFunctionPage.Controls.Add(this._salary);
            this._mainFunctionPage.Controls.Add(this._traning);
            this._mainFunctionPage.Controls.Add(this._careerPlanning);
            this._mainFunctionPage.Controls.Add(this._report);
            this._mainFunctionPage.Controls.Add(this._authorization);
            this._mainFunctionPage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._mainFunctionPage.Location = new System.Drawing.Point(8, 8);
            this._mainFunctionPage.Margin = new System.Windows.Forms.Padding(2);
            this._mainFunctionPage.Name = "_mainFunctionPage";
            this._mainFunctionPage.SelectedIndex = 0;
            this._mainFunctionPage.Size = new System.Drawing.Size(1044, 607);
            this._mainFunctionPage.TabIndex = 0;
            // 
            // _employee
            // 
            this._employee.Controls.Add(this._employeePage);
            this._employee.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._employee.Location = new System.Drawing.Point(4, 26);
            this._employee.Margin = new System.Windows.Forms.Padding(2);
            this._employee.Name = "_employee";
            this._employee.Padding = new System.Windows.Forms.Padding(2);
            this._employee.Size = new System.Drawing.Size(1036, 577);
            this._employee.TabIndex = 0;
            this._employee.Text = "Employee";
            this._employee.UseVisualStyleBackColor = true;
            // 
            // _employeePage
            // 
            this._employeePage.Controls.Add(this._newEmployee);
            this._employeePage.Controls.Add(this._editEmployee);
            this._employeePage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._employeePage.Location = new System.Drawing.Point(5, 5);
            this._employeePage.Margin = new System.Windows.Forms.Padding(2);
            this._employeePage.Name = "_employeePage";
            this._employeePage.SelectedIndex = 0;
            this._employeePage.Size = new System.Drawing.Size(1030, 573);
            this._employeePage.TabIndex = 0;
            // 
            // _newEmployee
            // 
            this._newEmployee.Controls.Add(this._newEmplPositionCB);
            this._newEmployee.Controls.Add(this._newEmplSexCB);
            this._newEmployee.Controls.Add(this._insertButton);
            this._newEmployee.Controls.Add(this._newEmplBloodCB);
            this._newEmployee.Controls.Add(this._newEmplBloodLB);
            this._newEmployee.Controls.Add(this._newEmplDeptCB);
            this._newEmployee.Controls.Add(this._newEmplBasicSalaryTB);
            this._newEmployee.Controls.Add(this._newEmplJobStatCB);
            this._newEmployee.Controls.Add(this._newEmplSpouseTB);
            this._newEmployee.Controls.Add(this._newEmplMarriedStatCB);
            this._newEmployee.Controls.Add(this._newEmplMilitaryStatCB);
            this._newEmployee.Controls.Add(this._newEmplEmerPhoneTB);
            this._newEmployee.Controls.Add(this._newEmplEmerPersonTB);
            this._newEmployee.Controls.Add(this._newEmplAddrTB);
            this._newEmployee.Controls.Add(this._newEmplPhoneTB);
            this._newEmployee.Controls.Add(this._newEmpllSsnTB);
            this._newEmployee.Controls.Add(this._newEmplBirthDP);
            this._newEmployee.Controls.Add(this._newEmplNameTB);
            this._newEmployee.Controls.Add(this._newEmplIDTB);
            this._newEmployee.Controls.Add(this._newEmplPositionIDLB);
            this._newEmployee.Controls.Add(this._newEmplDeptIDLB);
            this._newEmployee.Controls.Add(this._newEmplBasicSalaryLB);
            this._newEmployee.Controls.Add(this._newEmplBirthLB);
            this._newEmployee.Controls.Add(this._newEmplSpouseLB);
            this._newEmployee.Controls.Add(this._newEmplMarriedStatLB);
            this._newEmployee.Controls.Add(this._newEmplJobStatLB);
            this._newEmployee.Controls.Add(this._newEmplMilitaryLB);
            this._newEmployee.Controls.Add(this._newEmplEmerPhoneLB);
            this._newEmployee.Controls.Add(this._newEmplEmerPersonLB);
            this._newEmployee.Controls.Add(this._newEmplAddrLB);
            this._newEmployee.Controls.Add(this._newEmplPhoneLB);
            this._newEmployee.Controls.Add(this._newEmplSexLB);
            this._newEmployee.Controls.Add(this._newEmplSsnLB);
            this._newEmployee.Controls.Add(this._newEmplNameLB);
            this._newEmployee.Controls.Add(this._newEmplIDLB);
            this._newEmployee.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._newEmployee.Location = new System.Drawing.Point(4, 26);
            this._newEmployee.Margin = new System.Windows.Forms.Padding(2);
            this._newEmployee.Name = "_newEmployee";
            this._newEmployee.Padding = new System.Windows.Forms.Padding(2);
            this._newEmployee.Size = new System.Drawing.Size(1022, 543);
            this._newEmployee.TabIndex = 0;
            this._newEmployee.Text = "Add";
            this._newEmployee.UseVisualStyleBackColor = true;
            // 
            // _newEmplSexCB
            // 
            this._newEmplSexCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplSexCB.FormattingEnabled = true;
            this._newEmplSexCB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this._newEmplSexCB.Location = new System.Drawing.Point(484, 67);
            this._newEmplSexCB.Margin = new System.Windows.Forms.Padding(2);
            this._newEmplSexCB.Name = "_newEmplSexCB";
            this._newEmplSexCB.Size = new System.Drawing.Size(82, 24);
            this._newEmplSexCB.TabIndex = 38;
            // 
            // _insertButton
            // 
            this._insertButton.Location = new System.Drawing.Point(813, 479);
            this._insertButton.Margin = new System.Windows.Forms.Padding(2);
            this._insertButton.Name = "_insertButton";
            this._insertButton.Size = new System.Drawing.Size(75, 35);
            this._insertButton.TabIndex = 37;
            this._insertButton.Text = "Add";
            this._insertButton.UseVisualStyleBackColor = true;
            this._insertButton.Click += new System.EventHandler(this.ClickAddButton);
            // 
            // _newEmplBloodCB
            // 
            this._newEmplBloodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplBloodCB.FormattingEnabled = true;
            this._newEmplBloodCB.Items.AddRange(new object[] {
            "A",
            "B",
            "O",
            "AB"});
            this._newEmplBloodCB.Location = new System.Drawing.Point(634, 67);
            this._newEmplBloodCB.Margin = new System.Windows.Forms.Padding(2);
            this._newEmplBloodCB.Name = "_newEmplBloodCB";
            this._newEmplBloodCB.Size = new System.Drawing.Size(77, 24);
            this._newEmplBloodCB.TabIndex = 36;
            // 
            // _newEmplBloodLB
            // 
            this._newEmplBloodLB.AutoSize = true;
            this._newEmplBloodLB.Location = new System.Drawing.Point(583, 72);
            this._newEmplBloodLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplBloodLB.Name = "_newEmplBloodLB";
            this._newEmplBloodLB.Size = new System.Drawing.Size(50, 16);
            this._newEmplBloodLB.TabIndex = 35;
            this._newEmplBloodLB.Text = "Blood:";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.deptDataSet;
            // 
            // deptDataSet
            // 
            this.deptDataSet.DataSetName = "deptDataSet";
            this.deptDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _newEmplDeptCB
            // 
            this._newEmplDeptCB.DataSource = this.departmentBindingSource;
            this._newEmplDeptCB.DisplayMember = "departmentName";
            this._newEmplDeptCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplDeptCB.FormattingEnabled = true;
            this._newEmplDeptCB.Location = new System.Drawing.Point(121, 372);
            this._newEmplDeptCB.Margin = new System.Windows.Forms.Padding(2);
            this._newEmplDeptCB.Name = "_newEmplDeptCB";
            this._newEmplDeptCB.Size = new System.Drawing.Size(207, 24);
            this._newEmplDeptCB.TabIndex = 33;
            this._newEmplDeptCB.ValueMember = "departmentID";
            // 
            // _newEmplBasicSalaryTB
            // 
            this._newEmplBasicSalaryTB.Location = new System.Drawing.Point(123, 463);
            this._newEmplBasicSalaryTB.Margin = new System.Windows.Forms.Padding(2);
            this._newEmplBasicSalaryTB.Name = "_newEmplBasicSalaryTB";
            this._newEmplBasicSalaryTB.Size = new System.Drawing.Size(201, 27);
            this._newEmplBasicSalaryTB.TabIndex = 32;
            this._newEmplBasicSalaryTB.Text = "0";
            // 
            // _newEmplJobStatCB
            // 
            this._newEmplJobStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplJobStatCB.FormattingEnabled = true;
            this._newEmplJobStatCB.Items.AddRange(new object[] {
            "在職",
            "離職"});
            this._newEmplJobStatCB.Location = new System.Drawing.Point(109, 324);
            this._newEmplJobStatCB.Margin = new System.Windows.Forms.Padding(2);
            this._newEmplJobStatCB.Name = "_newEmplJobStatCB";
            this._newEmplJobStatCB.Size = new System.Drawing.Size(215, 24);
            this._newEmplJobStatCB.TabIndex = 31;
            // 
            // _newEmplSpouseTB
            // 
            this._newEmplSpouseTB.Location = new System.Drawing.Point(505, 318);
            this._newEmplSpouseTB.Margin = new System.Windows.Forms.Padding(2);
            this._newEmplSpouseTB.Name = "_newEmplSpouseTB";
            this._newEmplSpouseTB.ReadOnly = true;
            this._newEmplSpouseTB.Size = new System.Drawing.Size(150, 27);
            this._newEmplSpouseTB.TabIndex = 30;
            // 
            // _newEmplMarriedStatCB
            // 
            this._newEmplMarriedStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplMarriedStatCB.FormattingEnabled = true;
            this._newEmplMarriedStatCB.Items.AddRange(new object[] {
            "未婚",
            "已婚"});
            this._newEmplMarriedStatCB.Location = new System.Drawing.Point(552, 273);
            this._newEmplMarriedStatCB.Margin = new System.Windows.Forms.Padding(2);
            this._newEmplMarriedStatCB.Name = "_newEmplMarriedStatCB";
            this._newEmplMarriedStatCB.Size = new System.Drawing.Size(103, 24);
            this._newEmplMarriedStatCB.TabIndex = 29;
            this._newEmplMarriedStatCB.SelectedIndexChanged += new System.EventHandler(this.ChangedNewEmplMarriedStatCBSelectedIndex);
            // 
            // _newEmplMilitaryStatCB
            // 
            this._newEmplMilitaryStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplMilitaryStatCB.FormattingEnabled = true;
            this._newEmplMilitaryStatCB.Items.AddRange(new object[] {
            "役畢",
            "屆退",
            "待役",
            "未役",
            "免役"});
            this._newEmplMilitaryStatCB.Location = new System.Drawing.Point(552, 213);
            this._newEmplMilitaryStatCB.Margin = new System.Windows.Forms.Padding(2);
            this._newEmplMilitaryStatCB.Name = "_newEmplMilitaryStatCB";
            this._newEmplMilitaryStatCB.Size = new System.Drawing.Size(103, 24);
            this._newEmplMilitaryStatCB.TabIndex = 28;
            // 
            // _newEmplEmerPhoneTB
            // 
            this._newEmplEmerPhoneTB.Location = new System.Drawing.Point(157, 270);
            this._newEmplEmerPhoneTB.Margin = new System.Windows.Forms.Padding(2);
            this._newEmplEmerPhoneTB.Name = "_newEmplEmerPhoneTB";
            this._newEmplEmerPhoneTB.Size = new System.Drawing.Size(167, 27);
            this._newEmplEmerPhoneTB.TabIndex = 27;
            // 
            // _newEmplEmerPersonTB
            // 
            this._newEmplEmerPersonTB.Location = new System.Drawing.Point(160, 217);
            this._newEmplEmerPersonTB.Margin = new System.Windows.Forms.Padding(2);
            this._newEmplEmerPersonTB.Name = "_newEmplEmerPersonTB";
            this._newEmplEmerPersonTB.Size = new System.Drawing.Size(164, 27);
            this._newEmplEmerPersonTB.TabIndex = 26;
            // 
            // _newEmplAddrTB
            // 
            this._newEmplAddrTB.Location = new System.Drawing.Point(97, 167);
            this._newEmplAddrTB.Margin = new System.Windows.Forms.Padding(2);
            this._newEmplAddrTB.Name = "_newEmplAddrTB";
            this._newEmplAddrTB.Size = new System.Drawing.Size(680, 27);
            this._newEmplAddrTB.TabIndex = 25;
            // 
            // _newEmplPhoneTB
            // 
            this._newEmplPhoneTB.Location = new System.Drawing.Point(552, 121);
            this._newEmplPhoneTB.Margin = new System.Windows.Forms.Padding(2);
            this._newEmplPhoneTB.Name = "_newEmplPhoneTB";
            this._newEmplPhoneTB.Size = new System.Drawing.Size(225, 27);
            this._newEmplPhoneTB.TabIndex = 24;
            // 
            // _newEmpllSsnTB
            // 
            this._newEmpllSsnTB.Location = new System.Drawing.Point(69, 118);
            this._newEmpllSsnTB.Margin = new System.Windows.Forms.Padding(2);
            this._newEmpllSsnTB.Name = "_newEmpllSsnTB";
            this._newEmpllSsnTB.Size = new System.Drawing.Size(256, 27);
            this._newEmpllSsnTB.TabIndex = 20;
            // 
            // _newEmplBirthDP
            // 
            this._newEmplBirthDP.Location = new System.Drawing.Point(521, 19);
            this._newEmplBirthDP.Margin = new System.Windows.Forms.Padding(2);
            this._newEmplBirthDP.Name = "_newEmplBirthDP";
            this._newEmplBirthDP.Size = new System.Drawing.Size(135, 27);
            this._newEmplBirthDP.TabIndex = 19;
            // 
            // _newEmplNameTB
            // 
            this._newEmplNameTB.Location = new System.Drawing.Point(83, 70);
            this._newEmplNameTB.Margin = new System.Windows.Forms.Padding(2);
            this._newEmplNameTB.Name = "_newEmplNameTB";
            this._newEmplNameTB.Size = new System.Drawing.Size(241, 27);
            this._newEmplNameTB.TabIndex = 17;
            // 
            // _newEmplIDTB
            // 
            this._newEmplIDTB.Location = new System.Drawing.Point(127, 19);
            this._newEmplIDTB.Margin = new System.Windows.Forms.Padding(2);
            this._newEmplIDTB.Name = "_newEmplIDTB";
            this._newEmplIDTB.Size = new System.Drawing.Size(197, 27);
            this._newEmplIDTB.TabIndex = 16;
            // 
            // _newEmplPositionIDLB
            // 
            this._newEmplPositionIDLB.AutoSize = true;
            this._newEmplPositionIDLB.Location = new System.Drawing.Point(32, 419);
            this._newEmplPositionIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplPositionIDLB.Name = "_newEmplPositionIDLB";
            this._newEmplPositionIDLB.Size = new System.Drawing.Size(62, 16);
            this._newEmplPositionIDLB.TabIndex = 15;
            this._newEmplPositionIDLB.Text = "Position:";
            // 
            // _newEmplDeptIDLB
            // 
            this._newEmplDeptIDLB.AutoSize = true;
            this._newEmplDeptIDLB.Location = new System.Drawing.Point(32, 375);
            this._newEmplDeptIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplDeptIDLB.Name = "_newEmplDeptIDLB";
            this._newEmplDeptIDLB.Size = new System.Drawing.Size(85, 16);
            this._newEmplDeptIDLB.TabIndex = 14;
            this._newEmplDeptIDLB.Text = "Department:";
            // 
            // _newEmplBasicSalaryLB
            // 
            this._newEmplBasicSalaryLB.AutoSize = true;
            this._newEmplBasicSalaryLB.Location = new System.Drawing.Point(32, 467);
            this._newEmplBasicSalaryLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplBasicSalaryLB.Name = "_newEmplBasicSalaryLB";
            this._newEmplBasicSalaryLB.Size = new System.Drawing.Size(89, 16);
            this._newEmplBasicSalaryLB.TabIndex = 13;
            this._newEmplBasicSalaryLB.Text = "Basic Salary:";
            // 
            // _newEmplBirthLB
            // 
            this._newEmplBirthLB.AutoSize = true;
            this._newEmplBirthLB.Location = new System.Drawing.Point(447, 27);
            this._newEmplBirthLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplBirthLB.Name = "_newEmplBirthLB";
            this._newEmplBirthLB.Size = new System.Drawing.Size(73, 16);
            this._newEmplBirthLB.TabIndex = 12;
            this._newEmplBirthLB.Text = "Birth Day:";
            // 
            // _newEmplSpouseLB
            // 
            this._newEmplSpouseLB.AutoSize = true;
            this._newEmplSpouseLB.Location = new System.Drawing.Point(447, 326);
            this._newEmplSpouseLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplSpouseLB.Name = "_newEmplSpouseLB";
            this._newEmplSpouseLB.Size = new System.Drawing.Size(57, 16);
            this._newEmplSpouseLB.TabIndex = 11;
            this._newEmplSpouseLB.Text = "Spouse:";
            // 
            // _newEmplMarriedStatLB
            // 
            this._newEmplMarriedStatLB.AutoSize = true;
            this._newEmplMarriedStatLB.Location = new System.Drawing.Point(447, 278);
            this._newEmplMarriedStatLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplMarriedStatLB.Name = "_newEmplMarriedStatLB";
            this._newEmplMarriedStatLB.Size = new System.Drawing.Size(102, 16);
            this._newEmplMarriedStatLB.TabIndex = 10;
            this._newEmplMarriedStatLB.Text = "Married Status:";
            // 
            // _newEmplJobStatLB
            // 
            this._newEmplJobStatLB.AutoSize = true;
            this._newEmplJobStatLB.Location = new System.Drawing.Point(32, 326);
            this._newEmplJobStatLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplJobStatLB.Name = "_newEmplJobStatLB";
            this._newEmplJobStatLB.Size = new System.Drawing.Size(75, 16);
            this._newEmplJobStatLB.TabIndex = 9;
            this._newEmplJobStatLB.Text = "Job Status:";
            // 
            // _newEmplMilitaryLB
            // 
            this._newEmplMilitaryLB.AutoSize = true;
            this._newEmplMilitaryLB.Location = new System.Drawing.Point(447, 219);
            this._newEmplMilitaryLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplMilitaryLB.Name = "_newEmplMilitaryLB";
            this._newEmplMilitaryLB.Size = new System.Drawing.Size(102, 16);
            this._newEmplMilitaryLB.TabIndex = 8;
            this._newEmplMilitaryLB.Text = "Military Status:";
            // 
            // _newEmplEmerPhoneLB
            // 
            this._newEmplEmerPhoneLB.AutoSize = true;
            this._newEmplEmerPhoneLB.Location = new System.Drawing.Point(32, 278);
            this._newEmplEmerPhoneLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplEmerPhoneLB.Name = "_newEmplEmerPhoneLB";
            this._newEmplEmerPhoneLB.Size = new System.Drawing.Size(126, 16);
            this._newEmplEmerPhoneLB.TabIndex = 7;
            this._newEmplEmerPhoneLB.Text = "Emergency Phone:";
            // 
            // _newEmplEmerPersonLB
            // 
            this._newEmplEmerPersonLB.AutoSize = true;
            this._newEmplEmerPersonLB.Location = new System.Drawing.Point(32, 225);
            this._newEmplEmerPersonLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplEmerPersonLB.Name = "_newEmplEmerPersonLB";
            this._newEmplEmerPersonLB.Size = new System.Drawing.Size(129, 16);
            this._newEmplEmerPersonLB.TabIndex = 6;
            this._newEmplEmerPersonLB.Text = "Emergency Person:";
            // 
            // _newEmplAddrLB
            // 
            this._newEmplAddrLB.AutoSize = true;
            this._newEmplAddrLB.Location = new System.Drawing.Point(32, 175);
            this._newEmplAddrLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplAddrLB.Name = "_newEmplAddrLB";
            this._newEmplAddrLB.Size = new System.Drawing.Size(63, 16);
            this._newEmplAddrLB.TabIndex = 5;
            this._newEmplAddrLB.Text = "Address:";
            // 
            // _newEmplPhoneLB
            // 
            this._newEmplPhoneLB.AutoSize = true;
            this._newEmplPhoneLB.Location = new System.Drawing.Point(447, 126);
            this._newEmplPhoneLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplPhoneLB.Name = "_newEmplPhoneLB";
            this._newEmplPhoneLB.Size = new System.Drawing.Size(106, 16);
            this._newEmplPhoneLB.TabIndex = 4;
            this._newEmplPhoneLB.Text = "Phone Number:";
            // 
            // _newEmplSexLB
            // 
            this._newEmplSexLB.AutoSize = true;
            this._newEmplSexLB.Location = new System.Drawing.Point(447, 72);
            this._newEmplSexLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplSexLB.Name = "_newEmplSexLB";
            this._newEmplSexLB.Size = new System.Drawing.Size(35, 16);
            this._newEmplSexLB.TabIndex = 3;
            this._newEmplSexLB.Text = "Sex:";
            // 
            // _newEmplSsnLB
            // 
            this._newEmplSsnLB.AutoSize = true;
            this._newEmplSsnLB.Location = new System.Drawing.Point(32, 129);
            this._newEmplSsnLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplSsnLB.Name = "_newEmplSsnLB";
            this._newEmplSsnLB.Size = new System.Drawing.Size(34, 16);
            this._newEmplSsnLB.TabIndex = 2;
            this._newEmplSsnLB.Text = "Ssn:";
            // 
            // _newEmplNameLB
            // 
            this._newEmplNameLB.AutoSize = true;
            this._newEmplNameLB.Location = new System.Drawing.Point(32, 78);
            this._newEmplNameLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplNameLB.Name = "_newEmplNameLB";
            this._newEmplNameLB.Size = new System.Drawing.Size(49, 16);
            this._newEmplNameLB.TabIndex = 1;
            this._newEmplNameLB.Text = "Name:";
            // 
            // _newEmplIDLB
            // 
            this._newEmplIDLB.AutoSize = true;
            this._newEmplIDLB.Location = new System.Drawing.Point(32, 27);
            this._newEmplIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newEmplIDLB.Name = "_newEmplIDLB";
            this._newEmplIDLB.Size = new System.Drawing.Size(95, 16);
            this._newEmplIDLB.TabIndex = 0;
            this._newEmplIDLB.Text = "Employee ID:";
            // 
            // _editEmployee
            // 
            this._editEmployee.Location = new System.Drawing.Point(4, 26);
            this._editEmployee.Margin = new System.Windows.Forms.Padding(2);
            this._editEmployee.Name = "_editEmployee";
            this._editEmployee.Padding = new System.Windows.Forms.Padding(2);
            this._editEmployee.Size = new System.Drawing.Size(1022, 543);
            this._editEmployee.TabIndex = 1;
            this._editEmployee.Text = "Edit";
            this._editEmployee.UseVisualStyleBackColor = true;
            // 
            // _workAttendance
            // 
            this._workAttendance.Location = new System.Drawing.Point(4, 26);
            this._workAttendance.Margin = new System.Windows.Forms.Padding(2);
            this._workAttendance.Name = "_workAttendance";
            this._workAttendance.Padding = new System.Windows.Forms.Padding(2);
            this._workAttendance.Size = new System.Drawing.Size(1036, 577);
            this._workAttendance.TabIndex = 1;
            this._workAttendance.Text = "Work Attendance";
            this._workAttendance.UseVisualStyleBackColor = true;
            // 
            // _reimburse
            // 
            this._reimburse.Location = new System.Drawing.Point(4, 26);
            this._reimburse.Margin = new System.Windows.Forms.Padding(2);
            this._reimburse.Name = "_reimburse";
            this._reimburse.Padding = new System.Windows.Forms.Padding(2);
            this._reimburse.Size = new System.Drawing.Size(1036, 577);
            this._reimburse.TabIndex = 2;
            this._reimburse.Text = "Reimburse";
            this._reimburse.UseVisualStyleBackColor = true;
            // 
            // _bonus
            // 
            this._bonus.Location = new System.Drawing.Point(4, 26);
            this._bonus.Margin = new System.Windows.Forms.Padding(2);
            this._bonus.Name = "_bonus";
            this._bonus.Padding = new System.Windows.Forms.Padding(2);
            this._bonus.Size = new System.Drawing.Size(1036, 577);
            this._bonus.TabIndex = 3;
            this._bonus.Text = "Bonus";
            this._bonus.UseVisualStyleBackColor = true;
            // 
            // _salary
            // 
            this._salary.Location = new System.Drawing.Point(4, 26);
            this._salary.Margin = new System.Windows.Forms.Padding(2);
            this._salary.Name = "_salary";
            this._salary.Padding = new System.Windows.Forms.Padding(2);
            this._salary.Size = new System.Drawing.Size(1036, 577);
            this._salary.TabIndex = 4;
            this._salary.Text = "Salary";
            this._salary.UseVisualStyleBackColor = true;
            // 
            // _traning
            // 
            this._traning.Location = new System.Drawing.Point(4, 26);
            this._traning.Margin = new System.Windows.Forms.Padding(2);
            this._traning.Name = "_traning";
            this._traning.Padding = new System.Windows.Forms.Padding(2);
            this._traning.Size = new System.Drawing.Size(1036, 577);
            this._traning.TabIndex = 5;
            this._traning.Text = "Traning";
            this._traning.UseVisualStyleBackColor = true;
            // 
            // _careerPlanning
            // 
            this._careerPlanning.Location = new System.Drawing.Point(4, 26);
            this._careerPlanning.Margin = new System.Windows.Forms.Padding(2);
            this._careerPlanning.Name = "_careerPlanning";
            this._careerPlanning.Padding = new System.Windows.Forms.Padding(2);
            this._careerPlanning.Size = new System.Drawing.Size(1036, 577);
            this._careerPlanning.TabIndex = 6;
            this._careerPlanning.Text = "Career Plainning";
            this._careerPlanning.UseVisualStyleBackColor = true;
            // 
            // _report
            // 
            this._report.Location = new System.Drawing.Point(4, 26);
            this._report.Margin = new System.Windows.Forms.Padding(2);
            this._report.Name = "_report";
            this._report.Padding = new System.Windows.Forms.Padding(2);
            this._report.Size = new System.Drawing.Size(1036, 577);
            this._report.TabIndex = 7;
            this._report.Text = "Report";
            this._report.UseVisualStyleBackColor = true;
            // 
            // _authorization
            // 
            this._authorization.Location = new System.Drawing.Point(4, 26);
            this._authorization.Margin = new System.Windows.Forms.Padding(2);
            this._authorization.Name = "_authorization";
            this._authorization.Padding = new System.Windows.Forms.Padding(2);
            this._authorization.Size = new System.Drawing.Size(1036, 577);
            this._authorization.TabIndex = 8;
            this._authorization.Text = "Authorization";
            this._authorization.UseVisualStyleBackColor = true;
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "position";
            this.positionBindingSource.DataSource = this.positionDataSet;
            // 
            // positionDataSet
            // 
            this.positionDataSet.DataSetName = "positionDataSet";
            this.positionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _logoutButton
            // 
            this._logoutButton.Location = new System.Drawing.Point(879, 9);
            this._logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this._logoutButton.Name = "_logoutButton";
            this._logoutButton.Size = new System.Drawing.Size(50, 19);
            this._logoutButton.TabIndex = 1;
            this._logoutButton.Text = "Logout";
            this._logoutButton.UseVisualStyleBackColor = true;
            this._logoutButton.Click += new System.EventHandler(this.ClickLogoutButton);
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // _newEmplPositionCB
            // 
            this._newEmplPositionCB.DataSource = this.positionBindingSource;
            this._newEmplPositionCB.DisplayMember = "positionName";
            this._newEmplPositionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplPositionCB.FormattingEnabled = true;
            this._newEmplPositionCB.Location = new System.Drawing.Point(97, 416);
            this._newEmplPositionCB.Margin = new System.Windows.Forms.Padding(2);
            this._newEmplPositionCB.Name = "_newEmplPositionCB";
            this._newEmplPositionCB.Size = new System.Drawing.Size(207, 24);
            this._newEmplPositionCB.TabIndex = 39;
            this._newEmplPositionCB.ValueMember = "positionID";
            // 
            // _mainFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 623);
            this.Controls.Add(this._logoutButton);
            this.Controls.Add(this._mainFunctionPage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "_mainFunction";
            this.Text = "MainFunction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseMainFunction);
            this.Load += new System.EventHandler(this.LoadMainFunction);
            this._mainFunctionPage.ResumeLayout(false);
            this._employee.ResumeLayout(false);
            this._employeePage.ResumeLayout(false);
            this._newEmployee.ResumeLayout(false);
            this._newEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _mainFunctionPage;
        private System.Windows.Forms.TabPage _employee;
        private System.Windows.Forms.TabPage _workAttendance;
        private System.Windows.Forms.TabPage _reimburse;
        private System.Windows.Forms.TabPage _bonus;
        private System.Windows.Forms.TabPage _salary;
        private System.Windows.Forms.TabPage _traning;
        private System.Windows.Forms.TabPage _careerPlanning;
        private System.Windows.Forms.TabPage _report;
        private System.Windows.Forms.TabPage _authorization;
        private System.Windows.Forms.Button _logoutButton;
        private System.Windows.Forms.TabControl _employeePage;
        private System.Windows.Forms.TabPage _newEmployee;
        private System.Windows.Forms.TabPage _editEmployee;
        private System.Windows.Forms.Label _newEmplIDLB;
        private System.Windows.Forms.Label _newEmplNameLB;
        private System.Windows.Forms.Label _newEmplSsnLB;
        private System.Windows.Forms.Label _newEmplSexLB;
        private System.Windows.Forms.Label _newEmplPhoneLB;
        private System.Windows.Forms.Label _newEmplAddrLB;
        private System.Windows.Forms.Label _newEmplEmerPersonLB;
        private System.Windows.Forms.Label _newEmplEmerPhoneLB;
        private System.Windows.Forms.Label _newEmplMilitaryLB;
        private System.Windows.Forms.Label _newEmplJobStatLB;
        private System.Windows.Forms.Label _newEmplMarriedStatLB;
        private System.Windows.Forms.Label _newEmplSpouseLB;
        private System.Windows.Forms.Label _newEmplBirthLB;
        private System.Windows.Forms.Label _newEmplBasicSalaryLB;
        private System.Windows.Forms.Label _newEmplDeptIDLB;
        private System.Windows.Forms.Label _newEmplPositionIDLB;
        private System.Windows.Forms.TextBox _newEmplIDTB;
        private System.Windows.Forms.TextBox _newEmplNameTB;
        private System.Windows.Forms.DateTimePicker _newEmplBirthDP;
        private System.Windows.Forms.TextBox _newEmpllSsnTB;
        private System.Windows.Forms.TextBox _newEmplPhoneTB;
        private System.Windows.Forms.TextBox _newEmplAddrTB;
        private System.Windows.Forms.TextBox _newEmplEmerPhoneTB;
        private System.Windows.Forms.TextBox _newEmplEmerPersonTB;
        private System.Windows.Forms.ComboBox _newEmplMilitaryStatCB;
        private System.Windows.Forms.ComboBox _newEmplMarriedStatCB;
        private System.Windows.Forms.TextBox _newEmplSpouseTB;
        private System.Windows.Forms.ComboBox _newEmplJobStatCB;
        private System.Windows.Forms.TextBox _newEmplBasicSalaryTB;
        private System.Windows.Forms.ComboBox _newEmplDeptCB;
        private System.Windows.Forms.Label _newEmplBloodLB;
        private System.Windows.Forms.ComboBox _newEmplBloodCB;
        private System.Windows.Forms.Button _insertButton;
        private System.Windows.Forms.ComboBox _newEmplSexCB;
        private deptDataSet deptDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private deptDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private positionDataSet positionDataSet;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private positionDataSetTableAdapters.positionTableAdapter positionTableAdapter;
        private System.Windows.Forms.ComboBox _newEmplPositionCB;
    }
}