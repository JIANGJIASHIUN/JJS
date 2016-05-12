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
            this._newEmplJobStatCB = new System.Windows.Forms.ComboBox();
            this._newEmplSpouseTB = new System.Windows.Forms.TextBox();
            this._newEmplMarriedStatCB = new System.Windows.Forms.ComboBox();
            this._newEmplMilitaryStatCB = new System.Windows.Forms.ComboBox();
            this._newEmplEmerPhoneTB = new System.Windows.Forms.TextBox();
            this._newEmplEmerPersonTB = new System.Windows.Forms.TextBox();
            this._newEmplAddrTB = new System.Windows.Forms.TextBox();
            this._phoneTB = new System.Windows.Forms.TextBox();
            this._dashLB = new System.Windows.Forms.Label();
            this._areaCodeTB = new System.Windows.Forms.TextBox();
            this._sexGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this._male = new System.Windows.Forms.RadioButton();
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
            this._logoutButton = new System.Windows.Forms.Button();
            this._newEmplBasicSalaryTB = new System.Windows.Forms.TextBox();
            this._newEmplDeptCB = new System.Windows.Forms.ComboBox();
            this._newEmplPositionCB = new System.Windows.Forms.ComboBox();
            this.hrmsDataSet2 = new OOAD_HR_System.hrmsDataSet2();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new OOAD_HR_System.hrmsDataSet2TableAdapters.departmentTableAdapter();
            this.hrmsDataSet3 = new OOAD_HR_System.hrmsDataSet3();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionTableAdapter = new OOAD_HR_System.hrmsDataSet3TableAdapters.positionTableAdapter();
            this._mainFunctionPage.SuspendLayout();
            this._employee.SuspendLayout();
            this._employeePage.SuspendLayout();
            this._newEmployee.SuspendLayout();
            this._sexGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hrmsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrmsDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
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
            this._mainFunctionPage.Location = new System.Drawing.Point(12, 12);
            this._mainFunctionPage.Name = "_mainFunctionPage";
            this._mainFunctionPage.SelectedIndex = 0;
            this._mainFunctionPage.Size = new System.Drawing.Size(1566, 910);
            this._mainFunctionPage.TabIndex = 0;
            // 
            // _employee
            // 
            this._employee.Controls.Add(this._employeePage);
            this._employee.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._employee.Location = new System.Drawing.Point(4, 34);
            this._employee.Name = "_employee";
            this._employee.Padding = new System.Windows.Forms.Padding(3);
            this._employee.Size = new System.Drawing.Size(1558, 872);
            this._employee.TabIndex = 0;
            this._employee.Text = "Employee";
            this._employee.UseVisualStyleBackColor = true;
            // 
            // _employeePage
            // 
            this._employeePage.Controls.Add(this._newEmployee);
            this._employeePage.Controls.Add(this._editEmployee);
            this._employeePage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._employeePage.Location = new System.Drawing.Point(7, 7);
            this._employeePage.Name = "_employeePage";
            this._employeePage.SelectedIndex = 0;
            this._employeePage.Size = new System.Drawing.Size(1545, 859);
            this._employeePage.TabIndex = 0;
            // 
            // _newEmployee
            // 
            this._newEmployee.Controls.Add(this._newEmplPositionCB);
            this._newEmployee.Controls.Add(this._newEmplDeptCB);
            this._newEmployee.Controls.Add(this._newEmplBasicSalaryTB);
            this._newEmployee.Controls.Add(this._newEmplJobStatCB);
            this._newEmployee.Controls.Add(this._newEmplSpouseTB);
            this._newEmployee.Controls.Add(this._newEmplMarriedStatCB);
            this._newEmployee.Controls.Add(this._newEmplMilitaryStatCB);
            this._newEmployee.Controls.Add(this._newEmplEmerPhoneTB);
            this._newEmployee.Controls.Add(this._newEmplEmerPersonTB);
            this._newEmployee.Controls.Add(this._newEmplAddrTB);
            this._newEmployee.Controls.Add(this._phoneTB);
            this._newEmployee.Controls.Add(this._dashLB);
            this._newEmployee.Controls.Add(this._areaCodeTB);
            this._newEmployee.Controls.Add(this._sexGroupBox);
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
            this._newEmployee.Location = new System.Drawing.Point(4, 34);
            this._newEmployee.Name = "_newEmployee";
            this._newEmployee.Padding = new System.Windows.Forms.Padding(3);
            this._newEmployee.Size = new System.Drawing.Size(1537, 821);
            this._newEmployee.TabIndex = 0;
            this._newEmployee.Text = "New";
            this._newEmployee.UseVisualStyleBackColor = true;
            // 
            // _newEmplJobStatCB
            // 
            this._newEmplJobStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplJobStatCB.FormattingEnabled = true;
            this._newEmplJobStatCB.Items.AddRange(new object[] {
            "在職",
            "離職"});
            this._newEmplJobStatCB.Location = new System.Drawing.Point(163, 486);
            this._newEmplJobStatCB.Name = "_newEmplJobStatCB";
            this._newEmplJobStatCB.Size = new System.Drawing.Size(321, 32);
            this._newEmplJobStatCB.TabIndex = 31;
            // 
            // _newEmplSpouseTB
            // 
            this._newEmplSpouseTB.Location = new System.Drawing.Point(758, 477);
            this._newEmplSpouseTB.Name = "_newEmplSpouseTB";
            this._newEmplSpouseTB.ReadOnly = true;
            this._newEmplSpouseTB.Size = new System.Drawing.Size(223, 36);
            this._newEmplSpouseTB.TabIndex = 30;
            // 
            // _newEmplMarriedStatCB
            // 
            this._newEmplMarriedStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplMarriedStatCB.FormattingEnabled = true;
            this._newEmplMarriedStatCB.Items.AddRange(new object[] {
            "未婚",
            "已婚"});
            this._newEmplMarriedStatCB.Location = new System.Drawing.Point(828, 409);
            this._newEmplMarriedStatCB.Name = "_newEmplMarriedStatCB";
            this._newEmplMarriedStatCB.Size = new System.Drawing.Size(153, 32);
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
            this._newEmplMilitaryStatCB.Location = new System.Drawing.Point(828, 320);
            this._newEmplMilitaryStatCB.Name = "_newEmplMilitaryStatCB";
            this._newEmplMilitaryStatCB.Size = new System.Drawing.Size(153, 32);
            this._newEmplMilitaryStatCB.TabIndex = 28;
            // 
            // _newEmplEmerPhoneTB
            // 
            this._newEmplEmerPhoneTB.Location = new System.Drawing.Point(235, 405);
            this._newEmplEmerPhoneTB.Name = "_newEmplEmerPhoneTB";
            this._newEmplEmerPhoneTB.Size = new System.Drawing.Size(249, 36);
            this._newEmplEmerPhoneTB.TabIndex = 27;
            // 
            // _newEmplEmerPersonTB
            // 
            this._newEmplEmerPersonTB.Location = new System.Drawing.Point(240, 325);
            this._newEmplEmerPersonTB.Name = "_newEmplEmerPersonTB";
            this._newEmplEmerPersonTB.Size = new System.Drawing.Size(244, 36);
            this._newEmplEmerPersonTB.TabIndex = 26;
            // 
            // _newEmplAddrTB
            // 
            this._newEmplAddrTB.Location = new System.Drawing.Point(145, 251);
            this._newEmplAddrTB.Name = "_newEmplAddrTB";
            this._newEmplAddrTB.Size = new System.Drawing.Size(1018, 36);
            this._newEmplAddrTB.TabIndex = 25;
            // 
            // _phoneTB
            // 
            this._phoneTB.Location = new System.Drawing.Point(939, 181);
            this._phoneTB.Name = "_phoneTB";
            this._phoneTB.Size = new System.Drawing.Size(224, 36);
            this._phoneTB.TabIndex = 24;
            // 
            // _dashLB
            // 
            this._dashLB.AutoSize = true;
            this._dashLB.Location = new System.Drawing.Point(914, 187);
            this._dashLB.Name = "_dashLB";
            this._dashLB.Size = new System.Drawing.Size(18, 24);
            this._dashLB.TabIndex = 23;
            this._dashLB.Text = "-";
            // 
            // _areaCodeTB
            // 
            this._areaCodeTB.Location = new System.Drawing.Point(828, 181);
            this._areaCodeTB.Name = "_areaCodeTB";
            this._areaCodeTB.Size = new System.Drawing.Size(78, 36);
            this._areaCodeTB.TabIndex = 22;
            // 
            // _sexGroupBox
            // 
            this._sexGroupBox.Controls.Add(this.radioButton1);
            this._sexGroupBox.Controls.Add(this._male);
            this._sexGroupBox.Location = new System.Drawing.Point(726, 86);
            this._sexGroupBox.Name = "_sexGroupBox";
            this._sexGroupBox.Size = new System.Drawing.Size(206, 64);
            this._sexGroupBox.TabIndex = 21;
            this._sexGroupBox.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(95, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(102, 28);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Female";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // _male
            // 
            this._male.AutoSize = true;
            this._male.Location = new System.Drawing.Point(8, 22);
            this._male.Name = "_male";
            this._male.Size = new System.Drawing.Size(81, 28);
            this._male.TabIndex = 0;
            this._male.TabStop = true;
            this._male.Text = "Male";
            this._male.UseVisualStyleBackColor = true;
            // 
            // _newEmpllSsnTB
            // 
            this._newEmpllSsnTB.Location = new System.Drawing.Point(103, 177);
            this._newEmpllSsnTB.Name = "_newEmpllSsnTB";
            this._newEmpllSsnTB.Size = new System.Drawing.Size(382, 36);
            this._newEmpllSsnTB.TabIndex = 20;
            // 
            // _newEmplBirthDP
            // 
            this._newEmplBirthDP.Location = new System.Drawing.Point(781, 29);
            this._newEmplBirthDP.Name = "_newEmplBirthDP";
            this._newEmplBirthDP.Size = new System.Drawing.Size(200, 36);
            this._newEmplBirthDP.TabIndex = 19;
            // 
            // _newEmplNameTB
            // 
            this._newEmplNameTB.Location = new System.Drawing.Point(125, 105);
            this._newEmplNameTB.Name = "_newEmplNameTB";
            this._newEmplNameTB.Size = new System.Drawing.Size(360, 36);
            this._newEmplNameTB.TabIndex = 17;
            // 
            // _newEmplIDTB
            // 
            this._newEmplIDTB.Location = new System.Drawing.Point(191, 29);
            this._newEmplIDTB.Name = "_newEmplIDTB";
            this._newEmplIDTB.Size = new System.Drawing.Size(294, 36);
            this._newEmplIDTB.TabIndex = 16;
            // 
            // _newEmplPositionIDLB
            // 
            this._newEmplPositionIDLB.AutoSize = true;
            this._newEmplPositionIDLB.Location = new System.Drawing.Point(48, 629);
            this._newEmplPositionIDLB.Name = "_newEmplPositionIDLB";
            this._newEmplPositionIDLB.Size = new System.Drawing.Size(89, 24);
            this._newEmplPositionIDLB.TabIndex = 15;
            this._newEmplPositionIDLB.Text = "Position:";
            // 
            // _newEmplDeptIDLB
            // 
            this._newEmplDeptIDLB.AutoSize = true;
            this._newEmplDeptIDLB.Location = new System.Drawing.Point(48, 563);
            this._newEmplDeptIDLB.Name = "_newEmplDeptIDLB";
            this._newEmplDeptIDLB.Size = new System.Drawing.Size(122, 24);
            this._newEmplDeptIDLB.TabIndex = 14;
            this._newEmplDeptIDLB.Text = "Department:";
            // 
            // _newEmplBasicSalaryLB
            // 
            this._newEmplBasicSalaryLB.AutoSize = true;
            this._newEmplBasicSalaryLB.Location = new System.Drawing.Point(48, 700);
            this._newEmplBasicSalaryLB.Name = "_newEmplBasicSalaryLB";
            this._newEmplBasicSalaryLB.Size = new System.Drawing.Size(130, 24);
            this._newEmplBasicSalaryLB.TabIndex = 13;
            this._newEmplBasicSalaryLB.Text = "Basic Salary:";
            // 
            // _newEmplBirthLB
            // 
            this._newEmplBirthLB.AutoSize = true;
            this._newEmplBirthLB.Location = new System.Drawing.Point(670, 41);
            this._newEmplBirthLB.Name = "_newEmplBirthLB";
            this._newEmplBirthLB.Size = new System.Drawing.Size(105, 24);
            this._newEmplBirthLB.TabIndex = 12;
            this._newEmplBirthLB.Text = "Birth Day:";
            // 
            // _newEmplSpouseLB
            // 
            this._newEmplSpouseLB.AutoSize = true;
            this._newEmplSpouseLB.Location = new System.Drawing.Point(670, 489);
            this._newEmplSpouseLB.Name = "_newEmplSpouseLB";
            this._newEmplSpouseLB.Size = new System.Drawing.Size(81, 24);
            this._newEmplSpouseLB.TabIndex = 11;
            this._newEmplSpouseLB.Text = "Spouse:";
            // 
            // _newEmplMarriedStatLB
            // 
            this._newEmplMarriedStatLB.AutoSize = true;
            this._newEmplMarriedStatLB.Location = new System.Drawing.Point(670, 417);
            this._newEmplMarriedStatLB.Name = "_newEmplMarriedStatLB";
            this._newEmplMarriedStatLB.Size = new System.Drawing.Size(150, 24);
            this._newEmplMarriedStatLB.TabIndex = 10;
            this._newEmplMarriedStatLB.Text = "Married Status:";
            // 
            // _newEmplJobStatLB
            // 
            this._newEmplJobStatLB.AutoSize = true;
            this._newEmplJobStatLB.Location = new System.Drawing.Point(48, 489);
            this._newEmplJobStatLB.Name = "_newEmplJobStatLB";
            this._newEmplJobStatLB.Size = new System.Drawing.Size(108, 24);
            this._newEmplJobStatLB.TabIndex = 9;
            this._newEmplJobStatLB.Text = "Job Status:";
            // 
            // _newEmplMilitaryLB
            // 
            this._newEmplMilitaryLB.AutoSize = true;
            this._newEmplMilitaryLB.Location = new System.Drawing.Point(670, 328);
            this._newEmplMilitaryLB.Name = "_newEmplMilitaryLB";
            this._newEmplMilitaryLB.Size = new System.Drawing.Size(150, 24);
            this._newEmplMilitaryLB.TabIndex = 8;
            this._newEmplMilitaryLB.Text = "Military Status:";
            // 
            // _newEmplEmerPhoneLB
            // 
            this._newEmplEmerPhoneLB.AutoSize = true;
            this._newEmplEmerPhoneLB.Location = new System.Drawing.Point(48, 417);
            this._newEmplEmerPhoneLB.Name = "_newEmplEmerPhoneLB";
            this._newEmplEmerPhoneLB.Size = new System.Drawing.Size(181, 24);
            this._newEmplEmerPhoneLB.TabIndex = 7;
            this._newEmplEmerPhoneLB.Text = "Emergency Phone:";
            // 
            // _newEmplEmerPersonLB
            // 
            this._newEmplEmerPersonLB.AutoSize = true;
            this._newEmplEmerPersonLB.Location = new System.Drawing.Point(48, 337);
            this._newEmplEmerPersonLB.Name = "_newEmplEmerPersonLB";
            this._newEmplEmerPersonLB.Size = new System.Drawing.Size(187, 24);
            this._newEmplEmerPersonLB.TabIndex = 6;
            this._newEmplEmerPersonLB.Text = "Emergency Person:";
            // 
            // _newEmplAddrLB
            // 
            this._newEmplAddrLB.AutoSize = true;
            this._newEmplAddrLB.Location = new System.Drawing.Point(48, 263);
            this._newEmplAddrLB.Name = "_newEmplAddrLB";
            this._newEmplAddrLB.Size = new System.Drawing.Size(90, 24);
            this._newEmplAddrLB.TabIndex = 5;
            this._newEmplAddrLB.Text = "Address:";
            // 
            // _newEmplPhoneLB
            // 
            this._newEmplPhoneLB.AutoSize = true;
            this._newEmplPhoneLB.Location = new System.Drawing.Point(670, 189);
            this._newEmplPhoneLB.Name = "_newEmplPhoneLB";
            this._newEmplPhoneLB.Size = new System.Drawing.Size(152, 24);
            this._newEmplPhoneLB.TabIndex = 4;
            this._newEmplPhoneLB.Text = "Phone Number:";
            // 
            // _newEmplSexLB
            // 
            this._newEmplSexLB.AutoSize = true;
            this._newEmplSexLB.Location = new System.Drawing.Point(670, 108);
            this._newEmplSexLB.Name = "_newEmplSexLB";
            this._newEmplSexLB.Size = new System.Drawing.Size(50, 24);
            this._newEmplSexLB.TabIndex = 3;
            this._newEmplSexLB.Text = "Sex:";
            // 
            // _newEmplSsnLB
            // 
            this._newEmplSsnLB.AutoSize = true;
            this._newEmplSsnLB.Location = new System.Drawing.Point(48, 193);
            this._newEmplSsnLB.Name = "_newEmplSsnLB";
            this._newEmplSsnLB.Size = new System.Drawing.Size(49, 24);
            this._newEmplSsnLB.TabIndex = 2;
            this._newEmplSsnLB.Text = "Ssn:";
            // 
            // _newEmplNameLB
            // 
            this._newEmplNameLB.AutoSize = true;
            this._newEmplNameLB.Location = new System.Drawing.Point(48, 117);
            this._newEmplNameLB.Name = "_newEmplNameLB";
            this._newEmplNameLB.Size = new System.Drawing.Size(70, 24);
            this._newEmplNameLB.TabIndex = 1;
            this._newEmplNameLB.Text = "Name:";
            // 
            // _newEmplIDLB
            // 
            this._newEmplIDLB.AutoSize = true;
            this._newEmplIDLB.Location = new System.Drawing.Point(48, 41);
            this._newEmplIDLB.Name = "_newEmplIDLB";
            this._newEmplIDLB.Size = new System.Drawing.Size(137, 24);
            this._newEmplIDLB.TabIndex = 0;
            this._newEmplIDLB.Text = "Employee ID:";
            // 
            // _editEmployee
            // 
            this._editEmployee.Location = new System.Drawing.Point(4, 34);
            this._editEmployee.Name = "_editEmployee";
            this._editEmployee.Padding = new System.Windows.Forms.Padding(3);
            this._editEmployee.Size = new System.Drawing.Size(1537, 821);
            this._editEmployee.TabIndex = 1;
            this._editEmployee.Text = "Edit";
            this._editEmployee.UseVisualStyleBackColor = true;
            // 
            // _workAttendance
            // 
            this._workAttendance.Location = new System.Drawing.Point(4, 34);
            this._workAttendance.Name = "_workAttendance";
            this._workAttendance.Padding = new System.Windows.Forms.Padding(3);
            this._workAttendance.Size = new System.Drawing.Size(1558, 872);
            this._workAttendance.TabIndex = 1;
            this._workAttendance.Text = "Work Attendance";
            this._workAttendance.UseVisualStyleBackColor = true;
            // 
            // _reimburse
            // 
            this._reimburse.Location = new System.Drawing.Point(4, 34);
            this._reimburse.Name = "_reimburse";
            this._reimburse.Padding = new System.Windows.Forms.Padding(3);
            this._reimburse.Size = new System.Drawing.Size(1558, 872);
            this._reimburse.TabIndex = 2;
            this._reimburse.Text = "Reimburse";
            this._reimburse.UseVisualStyleBackColor = true;
            // 
            // _bonus
            // 
            this._bonus.Location = new System.Drawing.Point(4, 34);
            this._bonus.Name = "_bonus";
            this._bonus.Padding = new System.Windows.Forms.Padding(3);
            this._bonus.Size = new System.Drawing.Size(1558, 872);
            this._bonus.TabIndex = 3;
            this._bonus.Text = "Bonus";
            this._bonus.UseVisualStyleBackColor = true;
            // 
            // _salary
            // 
            this._salary.Location = new System.Drawing.Point(4, 34);
            this._salary.Name = "_salary";
            this._salary.Padding = new System.Windows.Forms.Padding(3);
            this._salary.Size = new System.Drawing.Size(1558, 872);
            this._salary.TabIndex = 4;
            this._salary.Text = "Salary";
            this._salary.UseVisualStyleBackColor = true;
            // 
            // _traning
            // 
            this._traning.Location = new System.Drawing.Point(4, 34);
            this._traning.Name = "_traning";
            this._traning.Padding = new System.Windows.Forms.Padding(3);
            this._traning.Size = new System.Drawing.Size(1558, 872);
            this._traning.TabIndex = 5;
            this._traning.Text = "Traning";
            this._traning.UseVisualStyleBackColor = true;
            // 
            // _careerPlanning
            // 
            this._careerPlanning.Location = new System.Drawing.Point(4, 34);
            this._careerPlanning.Name = "_careerPlanning";
            this._careerPlanning.Padding = new System.Windows.Forms.Padding(3);
            this._careerPlanning.Size = new System.Drawing.Size(1558, 872);
            this._careerPlanning.TabIndex = 6;
            this._careerPlanning.Text = "Career Plainning";
            this._careerPlanning.UseVisualStyleBackColor = true;
            // 
            // _report
            // 
            this._report.Location = new System.Drawing.Point(4, 34);
            this._report.Name = "_report";
            this._report.Padding = new System.Windows.Forms.Padding(3);
            this._report.Size = new System.Drawing.Size(1558, 872);
            this._report.TabIndex = 7;
            this._report.Text = "Report";
            this._report.UseVisualStyleBackColor = true;
            // 
            // _authorization
            // 
            this._authorization.Location = new System.Drawing.Point(4, 34);
            this._authorization.Name = "_authorization";
            this._authorization.Padding = new System.Windows.Forms.Padding(3);
            this._authorization.Size = new System.Drawing.Size(1558, 872);
            this._authorization.TabIndex = 8;
            this._authorization.Text = "Authorization";
            this._authorization.UseVisualStyleBackColor = true;
            // 
            // _logoutButton
            // 
            this._logoutButton.Location = new System.Drawing.Point(1036, 16);
            this._logoutButton.Name = "_logoutButton";
            this._logoutButton.Size = new System.Drawing.Size(75, 23);
            this._logoutButton.TabIndex = 1;
            this._logoutButton.Text = "Logout";
            this._logoutButton.UseVisualStyleBackColor = true;
            this._logoutButton.Click += new System.EventHandler(this.ClickLogoutButton);
            // 
            // _newEmplBasicSalaryTB
            // 
            this._newEmplBasicSalaryTB.Location = new System.Drawing.Point(185, 694);
            this._newEmplBasicSalaryTB.Name = "_newEmplBasicSalaryTB";
            this._newEmplBasicSalaryTB.Size = new System.Drawing.Size(299, 36);
            this._newEmplBasicSalaryTB.TabIndex = 32;
            // 
            // _newEmplDeptCB
            // 
            this._newEmplDeptCB.DataSource = this.departmentBindingSource;
            this._newEmplDeptCB.DisplayMember = "departmentName";
            this._newEmplDeptCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplDeptCB.FormattingEnabled = true;
            this._newEmplDeptCB.Location = new System.Drawing.Point(177, 560);
            this._newEmplDeptCB.Name = "_newEmplDeptCB";
            this._newEmplDeptCB.Size = new System.Drawing.Size(308, 32);
            this._newEmplDeptCB.TabIndex = 33;
            this._newEmplDeptCB.ValueMember = "departmentID";
            // 
            // _newEmplPositionCB
            // 
            this._newEmplPositionCB.DataSource = this.positionBindingSource;
            this._newEmplPositionCB.DisplayMember = "positionName";
            this._newEmplPositionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplPositionCB.FormattingEnabled = true;
            this._newEmplPositionCB.Location = new System.Drawing.Point(144, 626);
            this._newEmplPositionCB.Name = "_newEmplPositionCB";
            this._newEmplPositionCB.Size = new System.Drawing.Size(341, 32);
            this._newEmplPositionCB.TabIndex = 34;
            this._newEmplPositionCB.ValueMember = "positionID";
            this._newEmplPositionCB.SelectedIndexChanged += new System.EventHandler(this.ChangedNewEmplPositionCBSelectedIndex);
            // 
            // hrmsDataSet2
            // 
            this.hrmsDataSet2.DataSetName = "hrmsDataSet2";
            this.hrmsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.hrmsDataSet2;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // hrmsDataSet3
            // 
            this.hrmsDataSet3.DataSetName = "hrmsDataSet3";
            this.hrmsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "position";
            this.positionBindingSource.DataSource = this.hrmsDataSet3;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // _mainFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 934);
            this.Controls.Add(this._logoutButton);
            this.Controls.Add(this._mainFunctionPage);
            this.Name = "_mainFunction";
            this.Text = "MainFunction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseMainFunction);
            this.Load += new System.EventHandler(this.LoadMainFunction);
            this._mainFunctionPage.ResumeLayout(false);
            this._employee.ResumeLayout(false);
            this._employeePage.ResumeLayout(false);
            this._newEmployee.ResumeLayout(false);
            this._newEmployee.PerformLayout();
            this._sexGroupBox.ResumeLayout(false);
            this._sexGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hrmsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrmsDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
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
        private System.Windows.Forms.GroupBox _sexGroupBox;
        private System.Windows.Forms.RadioButton _male;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label _dashLB;
        private System.Windows.Forms.TextBox _areaCodeTB;
        private System.Windows.Forms.TextBox _phoneTB;
        private System.Windows.Forms.TextBox _newEmplAddrTB;
        private System.Windows.Forms.TextBox _newEmplEmerPhoneTB;
        private System.Windows.Forms.TextBox _newEmplEmerPersonTB;
        private System.Windows.Forms.ComboBox _newEmplMilitaryStatCB;
        private System.Windows.Forms.ComboBox _newEmplMarriedStatCB;
        private System.Windows.Forms.TextBox _newEmplSpouseTB;
        private System.Windows.Forms.ComboBox _newEmplJobStatCB;
        private System.Windows.Forms.TextBox _newEmplBasicSalaryTB;
        private System.Windows.Forms.ComboBox _newEmplDeptCB;
        private System.Windows.Forms.ComboBox _newEmplPositionCB;
        private hrmsDataSet2 hrmsDataSet2;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private hrmsDataSet2TableAdapters.departmentTableAdapter departmentTableAdapter;
        private hrmsDataSet3 hrmsDataSet3;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private hrmsDataSet3TableAdapters.positionTableAdapter positionTableAdapter;
    }
}