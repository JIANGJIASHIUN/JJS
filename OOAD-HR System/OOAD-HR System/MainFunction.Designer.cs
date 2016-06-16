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
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionDataSet = new OOAD_HR_System.positionDataSet();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deptDataSet = new OOAD_HR_System.deptDataSet();
            this.bonusdefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bonusDefDataSet = new OOAD_HR_System.bonusDefDataSet();
            this.bonusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bonusDataSet = new OOAD_HR_System.bonusDataSet();
            this.authorizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authoDataSet = new OOAD_HR_System.authoDataSet();
            this._logoutButton = new System.Windows.Forms.Button();
            this.departmentTableAdapter = new OOAD_HR_System.deptDataSetTableAdapters.departmentTableAdapter();
            this.positionTableAdapter = new OOAD_HR_System.positionDataSetTableAdapters.positionTableAdapter();
            this.authorizationTableAdapter = new OOAD_HR_System.authoDataSetTableAdapters.authorizationTableAdapter();
            this.bonusdefTableAdapter = new OOAD_HR_System.bonusDefDataSetTableAdapters.bonusdefTableAdapter();
            this.bonusTableAdapter = new OOAD_HR_System.bonusDataSetTableAdapters.bonusTableAdapter();
            this._department = new System.Windows.Forms.TabPage();
            this._departmentPage = new System.Windows.Forms.TabControl();
            this._newDepartment = new System.Windows.Forms.TabPage();
            this._insertDeptButton = new System.Windows.Forms.Button();
            this._newDeptTimeDP = new System.Windows.Forms.DateTimePicker();
            this._newDeptManTB = new System.Windows.Forms.TextBox();
            this._newDeptNameTB = new System.Windows.Forms.TextBox();
            this._newDeptIDTB = new System.Windows.Forms.TextBox();
            this._newDeptManLB = new System.Windows.Forms.Label();
            this._newDeptStartTimeLB = new System.Windows.Forms.Label();
            this._newDeptNameLB = new System.Windows.Forms.Label();
            this._newDeptIDLB = new System.Windows.Forms.Label();
            this._editDepartment = new System.Windows.Forms.TabPage();
            this._editDeptEndTimeDefDP = new System.Windows.Forms.DateTimePicker();
            this._editDeptButton = new System.Windows.Forms.Button();
            this._searchDeptButton = new System.Windows.Forms.Button();
            this._editDeptCheckCB = new System.Windows.Forms.ComboBox();
            this._editDeptEndTimeDP = new System.Windows.Forms.DateTimePicker();
            this._editDeptStartTimeDP = new System.Windows.Forms.DateTimePicker();
            this._editDeptManTB = new System.Windows.Forms.TextBox();
            this._editDeptNameTB = new System.Windows.Forms.TextBox();
            this._editDeptIDTB = new System.Windows.Forms.TextBox();
            this._editDeptManLB = new System.Windows.Forms.Label();
            this._editDeptEndTimeLB = new System.Windows.Forms.Label();
            this._editDeptCheckLB = new System.Windows.Forms.Label();
            this._editDeptStartTimeLB = new System.Windows.Forms.Label();
            this._editDeptNameLB = new System.Windows.Forms.Label();
            this._editDeptIDLB = new System.Windows.Forms.Label();
            this._position = new System.Windows.Forms.TabPage();
            this._positionPage = new System.Windows.Forms.TabControl();
            this._addPosition = new System.Windows.Forms.TabPage();
            this._addPositionButton = new System.Windows.Forms.Button();
            this._addPositionIDTB = new System.Windows.Forms.TextBox();
            this._addPositionNameTB = new System.Windows.Forms.TextBox();
            this._addPositionBSTB = new System.Windows.Forms.TextBox();
            this._addPositionAuthoCB = new System.Windows.Forms.ComboBox();
            this._addPositionAuthoLB = new System.Windows.Forms.Label();
            this._addPositionBSLB = new System.Windows.Forms.Label();
            this._addPositionNameLB = new System.Windows.Forms.Label();
            this._addPositionIDLB = new System.Windows.Forms.Label();
            this._editPosition = new System.Windows.Forms.TabPage();
            this._editPositionButton = new System.Windows.Forms.Button();
            this._searchPositionButton = new System.Windows.Forms.Button();
            this._editPositionIDTB = new System.Windows.Forms.TextBox();
            this._editPositionNameTB = new System.Windows.Forms.TextBox();
            this._editPositionBSTB = new System.Windows.Forms.TextBox();
            this._editPositionAuthoCB = new System.Windows.Forms.ComboBox();
            this._editPositionAuthoLB = new System.Windows.Forms.Label();
            this._editPositionBSLB = new System.Windows.Forms.Label();
            this._editPositionNameLB = new System.Windows.Forms.Label();
            this._editPositionIDLB = new System.Windows.Forms.Label();
            this._authorization = new System.Windows.Forms.TabPage();
            this._authorizationPage = new System.Windows.Forms.TabControl();
            this._newAuthorization = new System.Windows.Forms.TabPage();
            this._insertAuthoButton = new System.Windows.Forms.Button();
            this._newAuthoLevelCB = new System.Windows.Forms.ComboBox();
            this._newAuthoNameTB = new System.Windows.Forms.TextBox();
            this._newAuthoIDTB = new System.Windows.Forms.TextBox();
            this._newAuthoLevelLB = new System.Windows.Forms.Label();
            this._newAuthoNameLB = new System.Windows.Forms.Label();
            this._newAuthoIDLB = new System.Windows.Forms.Label();
            this._editAuthorization = new System.Windows.Forms.TabPage();
            this._editAuthoButton = new System.Windows.Forms.Button();
            this._searchAuthoButton = new System.Windows.Forms.Button();
            this._editAuthoLevelCB = new System.Windows.Forms.ComboBox();
            this._editAuthoNameTB = new System.Windows.Forms.TextBox();
            this._editAuthoIDTB = new System.Windows.Forms.TextBox();
            this._editAuthoLevelLB = new System.Windows.Forms.Label();
            this._editAuthoNameLB = new System.Windows.Forms.Label();
            this._editAuthoIDLB = new System.Windows.Forms.Label();
            this._salary = new System.Windows.Forms.TabPage();
            this._salaryPage = new System.Windows.Forms.TabControl();
            this._addpayMethod = new System.Windows.Forms.TabPage();
            this._addPaywayButton = new System.Windows.Forms.Button();
            this._addPaywayMethodCB = new System.Windows.Forms.ComboBox();
            this._addPaywayAccountTB = new System.Windows.Forms.TextBox();
            this._addPaywayEmplIDTB = new System.Windows.Forms.TextBox();
            this._addpaywayAccountLB = new System.Windows.Forms.Label();
            this._addPaywayMethodLB = new System.Windows.Forms.Label();
            this._addPaywayEmplIDLB = new System.Windows.Forms.Label();
            this._editPayMethod = new System.Windows.Forms.TabPage();
            this._paywayEditButton = new System.Windows.Forms.Button();
            this._paywaySearchButton = new System.Windows.Forms.Button();
            this._editPaywayMethodCB = new System.Windows.Forms.ComboBox();
            this._editPaywayAccountTB = new System.Windows.Forms.TextBox();
            this._editPaywayEmplIDTB = new System.Windows.Forms.TextBox();
            this._editPaywayAccountLB = new System.Windows.Forms.Label();
            this._editPaywayMethodLB = new System.Windows.Forms.Label();
            this._editPaywayEmplIDLB = new System.Windows.Forms.Label();
            this._bonus = new System.Windows.Forms.TabPage();
            this._bonusPage = new System.Windows.Forms.TabControl();
            this._addBonusDef = new System.Windows.Forms.TabPage();
            this._addBonusDefButton = new System.Windows.Forms.Button();
            this._addBonusDefAmountTB = new System.Windows.Forms.TextBox();
            this._addBonusDefAmountLB = new System.Windows.Forms.Label();
            this._addBonusDefEffiDateDTP = new System.Windows.Forms.DateTimePicker();
            this._addBonusDefEffiDateLB = new System.Windows.Forms.Label();
            this._addBonusDefCreateDateDTP = new System.Windows.Forms.DateTimePicker();
            this._addBonusDefCreateDateLB = new System.Windows.Forms.Label();
            this._addBonusDefDescTB = new System.Windows.Forms.TextBox();
            this._addBonusDefDescLB = new System.Windows.Forms.Label();
            this._addBonusNameTB = new System.Windows.Forms.TextBox();
            this._addBonusDefNameLB = new System.Windows.Forms.Label();
            this._addBonusDefIDTB = new System.Windows.Forms.TextBox();
            this._addBonusDefIDLB = new System.Windows.Forms.Label();
            this._editBonusDef = new System.Windows.Forms.TabPage();
            this._editBonusDefButton = new System.Windows.Forms.Button();
            this._searchBonusDefButton = new System.Windows.Forms.Button();
            this._editBonusDefAmountTB = new System.Windows.Forms.TextBox();
            this._editBonusDefAmountLB = new System.Windows.Forms.Label();
            this._editBonusDefEffiDateDTP = new System.Windows.Forms.DateTimePicker();
            this._editBonusDefEffiDateLB = new System.Windows.Forms.Label();
            this._editBonusDefCreateDateDTP = new System.Windows.Forms.DateTimePicker();
            this._editBonusDefCreateDateLB = new System.Windows.Forms.Label();
            this._editBonusDefDescTB = new System.Windows.Forms.TextBox();
            this._editBonusDefDescLB = new System.Windows.Forms.Label();
            this._editBonusDefNameTB = new System.Windows.Forms.TextBox();
            this._editBonusDefNameLB = new System.Windows.Forms.Label();
            this._editBonusDefIDTB = new System.Windows.Forms.TextBox();
            this._editBonusDefIDLB = new System.Windows.Forms.Label();
            this._addBonusTLB = new System.Windows.Forms.TabPage();
            this._addbonusPeriodTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._addBonusButton = new System.Windows.Forms.Button();
            this._addBonusDateDTP = new System.Windows.Forms.DateTimePicker();
            this._addBonusDateLB = new System.Windows.Forms.Label();
            this._addBonusEmplIDTB = new System.Windows.Forms.TextBox();
            this._addBonusEmplID = new System.Windows.Forms.Label();
            this._addBonusCB = new System.Windows.Forms.ComboBox();
            this._addBonusNameLB = new System.Windows.Forms.Label();
            this._emplBonusSearch = new System.Windows.Forms.TabPage();
            this._bonusEmplIDSearchToolStrip = new System.Windows.Forms.ToolStrip();
            this._emplIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.emplIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this._fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._bonusDataGridView = new System.Windows.Forms.DataGridView();
            this.bonusDefIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._workAttendance = new System.Windows.Forms.TabPage();
            this._workAttendancePage = new System.Windows.Forms.TabControl();
            this._addWorkAttendance = new System.Windows.Forms.TabPage();
            this._addWAButton = new System.Windows.Forms.Button();
            this._addWAEndOTDTP = new System.Windows.Forms.DateTimePicker();
            this._addWAEndOverTimeLB = new System.Windows.Forms.Label();
            this._addWAStartOTDTP = new System.Windows.Forms.DateTimePicker();
            this._addWAStartOverTimeLB = new System.Windows.Forms.Label();
            this._addWAIsOvertimeCB = new System.Windows.Forms.ComboBox();
            this._addWAIsOvertime = new System.Windows.Forms.Label();
            this._addWAEndWTDTP = new System.Windows.Forms.DateTimePicker();
            this._addWAEndWTLB = new System.Windows.Forms.Label();
            this._addWAStartWTDTP = new System.Windows.Forms.DateTimePicker();
            this._addWAStartWTLB = new System.Windows.Forms.Label();
            this._addWAWorkStatusCB = new System.Windows.Forms.ComboBox();
            this._addWAStatusLB = new System.Windows.Forms.Label();
            this._addWADateDTP = new System.Windows.Forms.DateTimePicker();
            this._addWADate = new System.Windows.Forms.Label();
            this._addWAEmplIDTB = new System.Windows.Forms.TextBox();
            this._addWAEmplIDLB = new System.Windows.Forms.Label();
            this._editWorkAttendance = new System.Windows.Forms.TabPage();
            this._editWAButton = new System.Windows.Forms.Button();
            this._searchWAButton = new System.Windows.Forms.Button();
            this._editWAEndOTDTP = new System.Windows.Forms.DateTimePicker();
            this._editWAEndOTLB = new System.Windows.Forms.Label();
            this._editWAStartOTDTP = new System.Windows.Forms.DateTimePicker();
            this._editWAStartOTLB = new System.Windows.Forms.Label();
            this._editWAIsOvertimeCB = new System.Windows.Forms.ComboBox();
            this._editWAIsOvertimeLB = new System.Windows.Forms.Label();
            this._editWAEndWTDTP = new System.Windows.Forms.DateTimePicker();
            this._editWAEndWTLB = new System.Windows.Forms.Label();
            this._editWAStartWTDTP = new System.Windows.Forms.DateTimePicker();
            this._editWAStartWTLB = new System.Windows.Forms.Label();
            this._editWAStatusCB = new System.Windows.Forms.ComboBox();
            this._editWAWorkStatusLB = new System.Windows.Forms.Label();
            this._editWADateDTP = new System.Windows.Forms.DateTimePicker();
            this._editWADateLB = new System.Windows.Forms.Label();
            this._editWAEmplIDTB = new System.Windows.Forms.TextBox();
            this._editWAEmplIDLB = new System.Windows.Forms.Label();
            this._employee = new System.Windows.Forms.TabPage();
            this._employeePage = new System.Windows.Forms.TabControl();
            this._newEmployee = new System.Windows.Forms.TabPage();
            this._addEmplLoginPWTB = new System.Windows.Forms.TextBox();
            this._addEmplLoginPWLB = new System.Windows.Forms.Label();
            this._newEmplPositionCB = new System.Windows.Forms.ComboBox();
            this._newEmplSexCB = new System.Windows.Forms.ComboBox();
            this._insertEmplButton = new System.Windows.Forms.Button();
            this._newEmplBloodCB = new System.Windows.Forms.ComboBox();
            this._newEmplBloodLB = new System.Windows.Forms.Label();
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
            this._searchEmplButtom = new System.Windows.Forms.Button();
            this._editEmplPositionCB = new System.Windows.Forms.ComboBox();
            this._editEmplSexCB = new System.Windows.Forms.ComboBox();
            this._editEmplButton = new System.Windows.Forms.Button();
            this._editEmplBloodCB = new System.Windows.Forms.ComboBox();
            this._editEmplBloodLB = new System.Windows.Forms.Label();
            this._editEmplDeptCB = new System.Windows.Forms.ComboBox();
            this._editEmplBasicSalaryTB = new System.Windows.Forms.TextBox();
            this._editEmplJobStatCB = new System.Windows.Forms.ComboBox();
            this._editEmplSpouseTB = new System.Windows.Forms.TextBox();
            this._editEmplMarriedStatCB = new System.Windows.Forms.ComboBox();
            this._editEmplMilitaryStatCB = new System.Windows.Forms.ComboBox();
            this._editEmplEmerPhoneTB = new System.Windows.Forms.TextBox();
            this._editEmplEmerPersonTB = new System.Windows.Forms.TextBox();
            this._editEmplAddrTB = new System.Windows.Forms.TextBox();
            this._editEmplPhoneTB = new System.Windows.Forms.TextBox();
            this._editEmplSsnTB = new System.Windows.Forms.TextBox();
            this._editEmplBirthDTP = new System.Windows.Forms.DateTimePicker();
            this._editEmplNameTB = new System.Windows.Forms.TextBox();
            this._editEmplIDTB = new System.Windows.Forms.TextBox();
            this._editEmplPositionLB = new System.Windows.Forms.Label();
            this._editEmplDeptLB = new System.Windows.Forms.Label();
            this._editEmplBasicSalaryLB = new System.Windows.Forms.Label();
            this._editEmplBirthLB = new System.Windows.Forms.Label();
            this._editEmplSpouseLB = new System.Windows.Forms.Label();
            this._editMarriedStatLB = new System.Windows.Forms.Label();
            this._editEmplJobStatLB = new System.Windows.Forms.Label();
            this._editEmplMilitaryStatLB = new System.Windows.Forms.Label();
            this._editEmplEmerPhone = new System.Windows.Forms.Label();
            this._editEmplEmerPersonLB = new System.Windows.Forms.Label();
            this._editEmplAddrLB = new System.Windows.Forms.Label();
            this._editEmplPhoneLB = new System.Windows.Forms.Label();
            this._editEmplSexLB = new System.Windows.Forms.Label();
            this._editEmplSsnLB = new System.Windows.Forms.Label();
            this._editEmplNameLB = new System.Windows.Forms.Label();
            this.editEmplIDLB = new System.Windows.Forms.Label();
            this._mainFunctionPage = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusdefBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusDefDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authoDataSet)).BeginInit();
            this._department.SuspendLayout();
            this._departmentPage.SuspendLayout();
            this._newDepartment.SuspendLayout();
            this._editDepartment.SuspendLayout();
            this._position.SuspendLayout();
            this._positionPage.SuspendLayout();
            this._addPosition.SuspendLayout();
            this._editPosition.SuspendLayout();
            this._authorization.SuspendLayout();
            this._authorizationPage.SuspendLayout();
            this._newAuthorization.SuspendLayout();
            this._editAuthorization.SuspendLayout();
            this._salary.SuspendLayout();
            this._salaryPage.SuspendLayout();
            this._addpayMethod.SuspendLayout();
            this._editPayMethod.SuspendLayout();
            this._bonus.SuspendLayout();
            this._bonusPage.SuspendLayout();
            this._addBonusDef.SuspendLayout();
            this._editBonusDef.SuspendLayout();
            this._addBonusTLB.SuspendLayout();
            this._emplBonusSearch.SuspendLayout();
            this._bonusEmplIDSearchToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bonusDataGridView)).BeginInit();
            this._workAttendance.SuspendLayout();
            this._workAttendancePage.SuspendLayout();
            this._addWorkAttendance.SuspendLayout();
            this._editWorkAttendance.SuspendLayout();
            this._employee.SuspendLayout();
            this._employeePage.SuspendLayout();
            this._newEmployee.SuspendLayout();
            this._editEmployee.SuspendLayout();
            this._mainFunctionPage.SuspendLayout();
            this.SuspendLayout();
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
            // bonusdefBindingSource
            // 
            this.bonusdefBindingSource.DataMember = "bonusdef";
            this.bonusdefBindingSource.DataSource = this.bonusDefDataSet;
            // 
            // bonusDefDataSet
            // 
            this.bonusDefDataSet.DataSetName = "bonusDefDataSet";
            this.bonusDefDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bonusBindingSource
            // 
            this.bonusBindingSource.DataMember = "bonus";
            this.bonusBindingSource.DataSource = this.bonusDataSet;
            // 
            // bonusDataSet
            // 
            this.bonusDataSet.DataSetName = "bonusDataSet";
            this.bonusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorizationBindingSource
            // 
            this.authorizationBindingSource.DataMember = "authorization";
            this.authorizationBindingSource.DataSource = this.authoDataSet;
            // 
            // authoDataSet
            // 
            this.authoDataSet.DataSetName = "authoDataSet";
            this.authoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // authorizationTableAdapter
            // 
            this.authorizationTableAdapter.ClearBeforeFill = true;
            // 
            // bonusdefTableAdapter
            // 
            this.bonusdefTableAdapter.ClearBeforeFill = true;
            // 
            // bonusTableAdapter
            // 
            this.bonusTableAdapter.ClearBeforeFill = true;
            // 
            // _department
            // 
            this._department.Controls.Add(this._departmentPage);
            this._department.Location = new System.Drawing.Point(4, 26);
            this._department.Name = "_department";
            this._department.Padding = new System.Windows.Forms.Padding(3);
            this._department.Size = new System.Drawing.Size(1053, 577);
            this._department.TabIndex = 10;
            this._department.Text = "Department";
            this._department.UseVisualStyleBackColor = true;
            // 
            // _departmentPage
            // 
            this._departmentPage.Controls.Add(this._newDepartment);
            this._departmentPage.Controls.Add(this._editDepartment);
            this._departmentPage.Location = new System.Drawing.Point(4, 7);
            this._departmentPage.Name = "_departmentPage";
            this._departmentPage.SelectedIndex = 0;
            this._departmentPage.Size = new System.Drawing.Size(895, 456);
            this._departmentPage.TabIndex = 0;
            // 
            // _newDepartment
            // 
            this._newDepartment.Controls.Add(this._insertDeptButton);
            this._newDepartment.Controls.Add(this._newDeptTimeDP);
            this._newDepartment.Controls.Add(this._newDeptManTB);
            this._newDepartment.Controls.Add(this._newDeptNameTB);
            this._newDepartment.Controls.Add(this._newDeptIDTB);
            this._newDepartment.Controls.Add(this._newDeptManLB);
            this._newDepartment.Controls.Add(this._newDeptStartTimeLB);
            this._newDepartment.Controls.Add(this._newDeptNameLB);
            this._newDepartment.Controls.Add(this._newDeptIDLB);
            this._newDepartment.Location = new System.Drawing.Point(4, 26);
            this._newDepartment.Name = "_newDepartment";
            this._newDepartment.Padding = new System.Windows.Forms.Padding(3);
            this._newDepartment.Size = new System.Drawing.Size(887, 426);
            this._newDepartment.TabIndex = 0;
            this._newDepartment.Text = "Add";
            this._newDepartment.UseVisualStyleBackColor = true;
            // 
            // _insertDeptButton
            // 
            this._insertDeptButton.Location = new System.Drawing.Point(472, 322);
            this._insertDeptButton.Name = "_insertDeptButton";
            this._insertDeptButton.Size = new System.Drawing.Size(79, 31);
            this._insertDeptButton.TabIndex = 8;
            this._insertDeptButton.Text = "Add";
            this._insertDeptButton.UseVisualStyleBackColor = true;
            this._insertDeptButton.Click += new System.EventHandler(this.ClickAddDeptButton);
            // 
            // _newDeptTimeDP
            // 
            this._newDeptTimeDP.Location = new System.Drawing.Point(189, 197);
            this._newDeptTimeDP.Name = "_newDeptTimeDP";
            this._newDeptTimeDP.Size = new System.Drawing.Size(200, 27);
            this._newDeptTimeDP.TabIndex = 7;
            // 
            // _newDeptManTB
            // 
            this._newDeptManTB.Location = new System.Drawing.Point(190, 266);
            this._newDeptManTB.Name = "_newDeptManTB";
            this._newDeptManTB.Size = new System.Drawing.Size(199, 27);
            this._newDeptManTB.TabIndex = 6;
            // 
            // _newDeptNameTB
            // 
            this._newDeptNameTB.Location = new System.Drawing.Point(171, 106);
            this._newDeptNameTB.Name = "_newDeptNameTB";
            this._newDeptNameTB.Size = new System.Drawing.Size(220, 27);
            this._newDeptNameTB.TabIndex = 5;
            // 
            // _newDeptIDTB
            // 
            this._newDeptIDTB.Location = new System.Drawing.Point(151, 49);
            this._newDeptIDTB.Name = "_newDeptIDTB";
            this._newDeptIDTB.Size = new System.Drawing.Size(240, 27);
            this._newDeptIDTB.TabIndex = 4;
            // 
            // _newDeptManLB
            // 
            this._newDeptManLB.AutoSize = true;
            this._newDeptManLB.Location = new System.Drawing.Point(40, 269);
            this._newDeptManLB.Name = "_newDeptManLB";
            this._newDeptManLB.Size = new System.Drawing.Size(144, 16);
            this._newDeptManLB.TabIndex = 3;
            this._newDeptManLB.Text = "Department Manager:";
            // 
            // _newDeptStartTimeLB
            // 
            this._newDeptStartTimeLB.AutoSize = true;
            this._newDeptStartTimeLB.Location = new System.Drawing.Point(40, 169);
            this._newDeptStartTimeLB.Name = "_newDeptStartTimeLB";
            this._newDeptStartTimeLB.Size = new System.Drawing.Size(190, 16);
            this._newDeptStartTimeLB.TabIndex = 2;
            this._newDeptStartTimeLB.Text = "Start Date of the Department:";
            // 
            // _newDeptNameLB
            // 
            this._newDeptNameLB.AutoSize = true;
            this._newDeptNameLB.Location = new System.Drawing.Point(40, 109);
            this._newDeptNameLB.Name = "_newDeptNameLB";
            this._newDeptNameLB.Size = new System.Drawing.Size(126, 16);
            this._newDeptNameLB.TabIndex = 1;
            this._newDeptNameLB.Text = "Department Name:";
            // 
            // _newDeptIDLB
            // 
            this._newDeptIDLB.AutoSize = true;
            this._newDeptIDLB.Location = new System.Drawing.Point(40, 52);
            this._newDeptIDLB.Name = "_newDeptIDLB";
            this._newDeptIDLB.Size = new System.Drawing.Size(105, 16);
            this._newDeptIDLB.TabIndex = 0;
            this._newDeptIDLB.Text = "Department ID:";
            // 
            // _editDepartment
            // 
            this._editDepartment.Controls.Add(this._editDeptEndTimeDefDP);
            this._editDepartment.Controls.Add(this._editDeptButton);
            this._editDepartment.Controls.Add(this._searchDeptButton);
            this._editDepartment.Controls.Add(this._editDeptCheckCB);
            this._editDepartment.Controls.Add(this._editDeptEndTimeDP);
            this._editDepartment.Controls.Add(this._editDeptStartTimeDP);
            this._editDepartment.Controls.Add(this._editDeptManTB);
            this._editDepartment.Controls.Add(this._editDeptNameTB);
            this._editDepartment.Controls.Add(this._editDeptIDTB);
            this._editDepartment.Controls.Add(this._editDeptManLB);
            this._editDepartment.Controls.Add(this._editDeptEndTimeLB);
            this._editDepartment.Controls.Add(this._editDeptCheckLB);
            this._editDepartment.Controls.Add(this._editDeptStartTimeLB);
            this._editDepartment.Controls.Add(this._editDeptNameLB);
            this._editDepartment.Controls.Add(this._editDeptIDLB);
            this._editDepartment.Location = new System.Drawing.Point(4, 26);
            this._editDepartment.Margin = new System.Windows.Forms.Padding(2);
            this._editDepartment.Name = "_editDepartment";
            this._editDepartment.Padding = new System.Windows.Forms.Padding(2);
            this._editDepartment.Size = new System.Drawing.Size(887, 426);
            this._editDepartment.TabIndex = 1;
            this._editDepartment.Text = "Edit";
            this._editDepartment.UseVisualStyleBackColor = true;
            // 
            // _editDeptEndTimeDefDP
            // 
            this._editDeptEndTimeDefDP.Enabled = false;
            this._editDeptEndTimeDefDP.Location = new System.Drawing.Point(373, 284);
            this._editDeptEndTimeDefDP.Name = "_editDeptEndTimeDefDP";
            this._editDeptEndTimeDefDP.Size = new System.Drawing.Size(200, 27);
            this._editDeptEndTimeDefDP.TabIndex = 14;
            this._editDeptEndTimeDefDP.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this._editDeptEndTimeDefDP.Visible = false;
            // 
            // _editDeptButton
            // 
            this._editDeptButton.Location = new System.Drawing.Point(567, 363);
            this._editDeptButton.Name = "_editDeptButton";
            this._editDeptButton.Size = new System.Drawing.Size(82, 32);
            this._editDeptButton.TabIndex = 12;
            this._editDeptButton.Text = "Edit";
            this._editDeptButton.UseVisualStyleBackColor = true;
            this._editDeptButton.Click += new System.EventHandler(this.ClickEditDeptButton);
            // 
            // _searchDeptButton
            // 
            this._searchDeptButton.Location = new System.Drawing.Point(463, 364);
            this._searchDeptButton.Name = "_searchDeptButton";
            this._searchDeptButton.Size = new System.Drawing.Size(82, 31);
            this._searchDeptButton.TabIndex = 1;
            this._searchDeptButton.Text = "Search";
            this._searchDeptButton.UseVisualStyleBackColor = true;
            this._searchDeptButton.Click += new System.EventHandler(this.ClickSearchDeptButton);
            // 
            // _editDeptCheckCB
            // 
            this._editDeptCheckCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editDeptCheckCB.FormattingEnabled = true;
            this._editDeptCheckCB.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this._editDeptCheckCB.Location = new System.Drawing.Point(177, 212);
            this._editDeptCheckCB.Margin = new System.Windows.Forms.Padding(2);
            this._editDeptCheckCB.Name = "_editDeptCheckCB";
            this._editDeptCheckCB.Size = new System.Drawing.Size(82, 24);
            this._editDeptCheckCB.TabIndex = 11;
            this._editDeptCheckCB.SelectedIndexChanged += new System.EventHandler(this.ChangedEditDeptCheckCBSelectedIndex);
            // 
            // _editDeptEndTimeDP
            // 
            this._editDeptEndTimeDP.Enabled = false;
            this._editDeptEndTimeDP.Location = new System.Drawing.Point(195, 284);
            this._editDeptEndTimeDP.Margin = new System.Windows.Forms.Padding(2);
            this._editDeptEndTimeDP.Name = "_editDeptEndTimeDP";
            this._editDeptEndTimeDP.Size = new System.Drawing.Size(159, 27);
            this._editDeptEndTimeDP.TabIndex = 10;
            // 
            // _editDeptStartTimeDP
            // 
            this._editDeptStartTimeDP.Location = new System.Drawing.Point(195, 164);
            this._editDeptStartTimeDP.Margin = new System.Windows.Forms.Padding(2);
            this._editDeptStartTimeDP.Name = "_editDeptStartTimeDP";
            this._editDeptStartTimeDP.Size = new System.Drawing.Size(159, 27);
            this._editDeptStartTimeDP.TabIndex = 9;
            // 
            // _editDeptManTB
            // 
            this._editDeptManTB.Location = new System.Drawing.Point(223, 333);
            this._editDeptManTB.Margin = new System.Windows.Forms.Padding(2);
            this._editDeptManTB.Name = "_editDeptManTB";
            this._editDeptManTB.Size = new System.Drawing.Size(131, 27);
            this._editDeptManTB.TabIndex = 8;
            // 
            // _editDeptNameTB
            // 
            this._editDeptNameTB.Location = new System.Drawing.Point(205, 88);
            this._editDeptNameTB.Margin = new System.Windows.Forms.Padding(2);
            this._editDeptNameTB.Name = "_editDeptNameTB";
            this._editDeptNameTB.Size = new System.Drawing.Size(149, 27);
            this._editDeptNameTB.TabIndex = 7;
            // 
            // _editDeptIDTB
            // 
            this._editDeptIDTB.Location = new System.Drawing.Point(184, 34);
            this._editDeptIDTB.Margin = new System.Windows.Forms.Padding(2);
            this._editDeptIDTB.Name = "_editDeptIDTB";
            this._editDeptIDTB.Size = new System.Drawing.Size(170, 27);
            this._editDeptIDTB.TabIndex = 6;
            // 
            // _editDeptManLB
            // 
            this._editDeptManLB.AutoSize = true;
            this._editDeptManLB.Location = new System.Drawing.Point(75, 336);
            this._editDeptManLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editDeptManLB.Name = "_editDeptManLB";
            this._editDeptManLB.Size = new System.Drawing.Size(144, 16);
            this._editDeptManLB.TabIndex = 5;
            this._editDeptManLB.Text = "Department Manager:";
            // 
            // _editDeptEndTimeLB
            // 
            this._editDeptEndTimeLB.AutoSize = true;
            this._editDeptEndTimeLB.Location = new System.Drawing.Point(75, 266);
            this._editDeptEndTimeLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editDeptEndTimeLB.Name = "_editDeptEndTimeLB";
            this._editDeptEndTimeLB.Size = new System.Drawing.Size(219, 16);
            this._editDeptEndTimeLB.TabIndex = 4;
            this._editDeptEndTimeLB.Text = "Terminate date of the department:";
            // 
            // _editDeptCheckLB
            // 
            this._editDeptCheckLB.AutoSize = true;
            this._editDeptCheckLB.Location = new System.Drawing.Point(75, 215);
            this._editDeptCheckLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editDeptCheckLB.Name = "_editDeptCheckLB";
            this._editDeptCheckLB.Size = new System.Drawing.Size(102, 16);
            this._editDeptCheckLB.TabIndex = 3;
            this._editDeptCheckLB.Text = "Still operating?";
            // 
            // _editDeptStartTimeLB
            // 
            this._editDeptStartTimeLB.AutoSize = true;
            this._editDeptStartTimeLB.Location = new System.Drawing.Point(75, 146);
            this._editDeptStartTimeLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editDeptStartTimeLB.Name = "_editDeptStartTimeLB";
            this._editDeptStartTimeLB.Size = new System.Drawing.Size(184, 16);
            this._editDeptStartTimeLB.TabIndex = 2;
            this._editDeptStartTimeLB.Text = "Start date of the department:";
            // 
            // _editDeptNameLB
            // 
            this._editDeptNameLB.AutoSize = true;
            this._editDeptNameLB.Location = new System.Drawing.Point(75, 91);
            this._editDeptNameLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editDeptNameLB.Name = "_editDeptNameLB";
            this._editDeptNameLB.Size = new System.Drawing.Size(126, 16);
            this._editDeptNameLB.TabIndex = 1;
            this._editDeptNameLB.Text = "Department Name:";
            // 
            // _editDeptIDLB
            // 
            this._editDeptIDLB.AutoSize = true;
            this._editDeptIDLB.Location = new System.Drawing.Point(75, 45);
            this._editDeptIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editDeptIDLB.Name = "_editDeptIDLB";
            this._editDeptIDLB.Size = new System.Drawing.Size(105, 16);
            this._editDeptIDLB.TabIndex = 0;
            this._editDeptIDLB.Text = "Department ID:";
            // 
            // _position
            // 
            this._position.Controls.Add(this._positionPage);
            this._position.Location = new System.Drawing.Point(4, 26);
            this._position.Name = "_position";
            this._position.Padding = new System.Windows.Forms.Padding(3);
            this._position.Size = new System.Drawing.Size(1053, 577);
            this._position.TabIndex = 9;
            this._position.Text = "Position";
            this._position.UseVisualStyleBackColor = true;
            // 
            // _positionPage
            // 
            this._positionPage.Controls.Add(this._addPosition);
            this._positionPage.Controls.Add(this._editPosition);
            this._positionPage.Location = new System.Drawing.Point(3, 6);
            this._positionPage.Name = "_positionPage";
            this._positionPage.SelectedIndex = 0;
            this._positionPage.Size = new System.Drawing.Size(1552, 860);
            this._positionPage.TabIndex = 0;
            // 
            // _addPosition
            // 
            this._addPosition.Controls.Add(this._addPositionButton);
            this._addPosition.Controls.Add(this._addPositionIDTB);
            this._addPosition.Controls.Add(this._addPositionNameTB);
            this._addPosition.Controls.Add(this._addPositionBSTB);
            this._addPosition.Controls.Add(this._addPositionAuthoCB);
            this._addPosition.Controls.Add(this._addPositionAuthoLB);
            this._addPosition.Controls.Add(this._addPositionBSLB);
            this._addPosition.Controls.Add(this._addPositionNameLB);
            this._addPosition.Controls.Add(this._addPositionIDLB);
            this._addPosition.Location = new System.Drawing.Point(4, 26);
            this._addPosition.Name = "_addPosition";
            this._addPosition.Padding = new System.Windows.Forms.Padding(3);
            this._addPosition.Size = new System.Drawing.Size(1544, 830);
            this._addPosition.TabIndex = 0;
            this._addPosition.Text = "Add";
            this._addPosition.UseVisualStyleBackColor = true;
            // 
            // _addPositionButton
            // 
            this._addPositionButton.Location = new System.Drawing.Point(502, 462);
            this._addPositionButton.Name = "_addPositionButton";
            this._addPositionButton.Size = new System.Drawing.Size(113, 45);
            this._addPositionButton.TabIndex = 8;
            this._addPositionButton.Text = "Add";
            this._addPositionButton.UseVisualStyleBackColor = true;
            this._addPositionButton.Click += new System.EventHandler(this.ClickAddPositionButton);
            // 
            // _addPositionIDTB
            // 
            this._addPositionIDTB.Location = new System.Drawing.Point(179, 44);
            this._addPositionIDTB.Name = "_addPositionIDTB";
            this._addPositionIDTB.Size = new System.Drawing.Size(278, 27);
            this._addPositionIDTB.TabIndex = 7;
            // 
            // _addPositionNameTB
            // 
            this._addPositionNameTB.Location = new System.Drawing.Point(209, 132);
            this._addPositionNameTB.Name = "_addPositionNameTB";
            this._addPositionNameTB.Size = new System.Drawing.Size(248, 27);
            this._addPositionNameTB.TabIndex = 6;
            // 
            // _addPositionBSTB
            // 
            this._addPositionBSTB.Location = new System.Drawing.Point(270, 232);
            this._addPositionBSTB.Name = "_addPositionBSTB";
            this._addPositionBSTB.Size = new System.Drawing.Size(187, 27);
            this._addPositionBSTB.TabIndex = 5;
            this._addPositionBSTB.Text = "0";
            // 
            // _addPositionAuthoCB
            // 
            this._addPositionAuthoCB.DataSource = this.authorizationBindingSource;
            this._addPositionAuthoCB.DisplayMember = "authoName";
            this._addPositionAuthoCB.FormattingEnabled = true;
            this._addPositionAuthoCB.Location = new System.Drawing.Point(278, 318);
            this._addPositionAuthoCB.Name = "_addPositionAuthoCB";
            this._addPositionAuthoCB.Size = new System.Drawing.Size(179, 24);
            this._addPositionAuthoCB.TabIndex = 4;
            this._addPositionAuthoCB.ValueMember = "authoID";
            // 
            // _addPositionAuthoLB
            // 
            this._addPositionAuthoLB.AutoSize = true;
            this._addPositionAuthoLB.Location = new System.Drawing.Point(54, 326);
            this._addPositionAuthoLB.Name = "_addPositionAuthoLB";
            this._addPositionAuthoLB.Size = new System.Drawing.Size(152, 16);
            this._addPositionAuthoLB.TabIndex = 3;
            this._addPositionAuthoLB.Text = "Position Authorization:";
            // 
            // _addPositionBSLB
            // 
            this._addPositionBSLB.AutoSize = true;
            this._addPositionBSLB.Location = new System.Drawing.Point(54, 238);
            this._addPositionBSLB.Name = "_addPositionBSLB";
            this._addPositionBSLB.Size = new System.Drawing.Size(143, 16);
            this._addPositionBSLB.TabIndex = 2;
            this._addPositionBSLB.Text = "Position Basic Salary:";
            // 
            // _addPositionNameLB
            // 
            this._addPositionNameLB.AutoSize = true;
            this._addPositionNameLB.Location = new System.Drawing.Point(54, 144);
            this._addPositionNameLB.Name = "_addPositionNameLB";
            this._addPositionNameLB.Size = new System.Drawing.Size(103, 16);
            this._addPositionNameLB.TabIndex = 1;
            this._addPositionNameLB.Text = "Position Name:";
            // 
            // _addPositionIDLB
            // 
            this._addPositionIDLB.AutoSize = true;
            this._addPositionIDLB.Location = new System.Drawing.Point(54, 56);
            this._addPositionIDLB.Name = "_addPositionIDLB";
            this._addPositionIDLB.Size = new System.Drawing.Size(82, 16);
            this._addPositionIDLB.TabIndex = 0;
            this._addPositionIDLB.Text = "Position ID:";
            // 
            // _editPosition
            // 
            this._editPosition.Controls.Add(this._editPositionButton);
            this._editPosition.Controls.Add(this._searchPositionButton);
            this._editPosition.Controls.Add(this._editPositionIDTB);
            this._editPosition.Controls.Add(this._editPositionNameTB);
            this._editPosition.Controls.Add(this._editPositionBSTB);
            this._editPosition.Controls.Add(this._editPositionAuthoCB);
            this._editPosition.Controls.Add(this._editPositionAuthoLB);
            this._editPosition.Controls.Add(this._editPositionBSLB);
            this._editPosition.Controls.Add(this._editPositionNameLB);
            this._editPosition.Controls.Add(this._editPositionIDLB);
            this._editPosition.Location = new System.Drawing.Point(4, 26);
            this._editPosition.Name = "_editPosition";
            this._editPosition.Padding = new System.Windows.Forms.Padding(3);
            this._editPosition.Size = new System.Drawing.Size(1544, 830);
            this._editPosition.TabIndex = 1;
            this._editPosition.Text = "Edit";
            this._editPosition.UseVisualStyleBackColor = true;
            // 
            // _editPositionButton
            // 
            this._editPositionButton.Enabled = false;
            this._editPositionButton.Location = new System.Drawing.Point(676, 476);
            this._editPositionButton.Name = "_editPositionButton";
            this._editPositionButton.Size = new System.Drawing.Size(113, 45);
            this._editPositionButton.TabIndex = 18;
            this._editPositionButton.Text = "Edit";
            this._editPositionButton.UseVisualStyleBackColor = true;
            this._editPositionButton.Click += new System.EventHandler(this.ClickEditPositionButton);
            // 
            // _searchPositionButton
            // 
            this._searchPositionButton.Location = new System.Drawing.Point(502, 476);
            this._searchPositionButton.Name = "_searchPositionButton";
            this._searchPositionButton.Size = new System.Drawing.Size(113, 45);
            this._searchPositionButton.TabIndex = 17;
            this._searchPositionButton.Text = "Search";
            this._searchPositionButton.UseVisualStyleBackColor = true;
            this._searchPositionButton.Click += new System.EventHandler(this.ClickSearchPositionButtom);
            // 
            // _editPositionIDTB
            // 
            this._editPositionIDTB.Location = new System.Drawing.Point(179, 58);
            this._editPositionIDTB.Name = "_editPositionIDTB";
            this._editPositionIDTB.Size = new System.Drawing.Size(278, 27);
            this._editPositionIDTB.TabIndex = 16;
            // 
            // _editPositionNameTB
            // 
            this._editPositionNameTB.Location = new System.Drawing.Point(209, 146);
            this._editPositionNameTB.Name = "_editPositionNameTB";
            this._editPositionNameTB.ReadOnly = true;
            this._editPositionNameTB.Size = new System.Drawing.Size(248, 27);
            this._editPositionNameTB.TabIndex = 15;
            // 
            // _editPositionBSTB
            // 
            this._editPositionBSTB.Location = new System.Drawing.Point(270, 246);
            this._editPositionBSTB.Name = "_editPositionBSTB";
            this._editPositionBSTB.ReadOnly = true;
            this._editPositionBSTB.Size = new System.Drawing.Size(187, 27);
            this._editPositionBSTB.TabIndex = 14;
            // 
            // _editPositionAuthoCB
            // 
            this._editPositionAuthoCB.DataSource = this.authorizationBindingSource;
            this._editPositionAuthoCB.DisplayMember = "authoName";
            this._editPositionAuthoCB.Enabled = false;
            this._editPositionAuthoCB.FormattingEnabled = true;
            this._editPositionAuthoCB.Location = new System.Drawing.Point(278, 332);
            this._editPositionAuthoCB.Name = "_editPositionAuthoCB";
            this._editPositionAuthoCB.Size = new System.Drawing.Size(179, 24);
            this._editPositionAuthoCB.TabIndex = 13;
            this._editPositionAuthoCB.ValueMember = "authoID";
            // 
            // _editPositionAuthoLB
            // 
            this._editPositionAuthoLB.AutoSize = true;
            this._editPositionAuthoLB.Location = new System.Drawing.Point(54, 340);
            this._editPositionAuthoLB.Name = "_editPositionAuthoLB";
            this._editPositionAuthoLB.Size = new System.Drawing.Size(152, 16);
            this._editPositionAuthoLB.TabIndex = 12;
            this._editPositionAuthoLB.Text = "Position Authorization:";
            // 
            // _editPositionBSLB
            // 
            this._editPositionBSLB.AutoSize = true;
            this._editPositionBSLB.Location = new System.Drawing.Point(54, 252);
            this._editPositionBSLB.Name = "_editPositionBSLB";
            this._editPositionBSLB.Size = new System.Drawing.Size(143, 16);
            this._editPositionBSLB.TabIndex = 11;
            this._editPositionBSLB.Text = "Position Basic Salary:";
            // 
            // _editPositionNameLB
            // 
            this._editPositionNameLB.AutoSize = true;
            this._editPositionNameLB.Location = new System.Drawing.Point(54, 158);
            this._editPositionNameLB.Name = "_editPositionNameLB";
            this._editPositionNameLB.Size = new System.Drawing.Size(103, 16);
            this._editPositionNameLB.TabIndex = 10;
            this._editPositionNameLB.Text = "Position Name:";
            // 
            // _editPositionIDLB
            // 
            this._editPositionIDLB.AutoSize = true;
            this._editPositionIDLB.Location = new System.Drawing.Point(54, 70);
            this._editPositionIDLB.Name = "_editPositionIDLB";
            this._editPositionIDLB.Size = new System.Drawing.Size(82, 16);
            this._editPositionIDLB.TabIndex = 9;
            this._editPositionIDLB.Text = "Position ID:";
            // 
            // _authorization
            // 
            this._authorization.Controls.Add(this._authorizationPage);
            this._authorization.Location = new System.Drawing.Point(4, 26);
            this._authorization.Margin = new System.Windows.Forms.Padding(2);
            this._authorization.Name = "_authorization";
            this._authorization.Padding = new System.Windows.Forms.Padding(2);
            this._authorization.Size = new System.Drawing.Size(1053, 577);
            this._authorization.TabIndex = 8;
            this._authorization.Text = "Authorization";
            this._authorization.UseVisualStyleBackColor = true;
            // 
            // _authorizationPage
            // 
            this._authorizationPage.Controls.Add(this._newAuthorization);
            this._authorizationPage.Controls.Add(this._editAuthorization);
            this._authorizationPage.Location = new System.Drawing.Point(4, 5);
            this._authorizationPage.Margin = new System.Windows.Forms.Padding(2);
            this._authorizationPage.Name = "_authorizationPage";
            this._authorizationPage.SelectedIndex = 0;
            this._authorizationPage.Size = new System.Drawing.Size(1031, 573);
            this._authorizationPage.TabIndex = 0;
            // 
            // _newAuthorization
            // 
            this._newAuthorization.Controls.Add(this._insertAuthoButton);
            this._newAuthorization.Controls.Add(this._newAuthoLevelCB);
            this._newAuthorization.Controls.Add(this._newAuthoNameTB);
            this._newAuthorization.Controls.Add(this._newAuthoIDTB);
            this._newAuthorization.Controls.Add(this._newAuthoLevelLB);
            this._newAuthorization.Controls.Add(this._newAuthoNameLB);
            this._newAuthorization.Controls.Add(this._newAuthoIDLB);
            this._newAuthorization.Location = new System.Drawing.Point(4, 26);
            this._newAuthorization.Margin = new System.Windows.Forms.Padding(2);
            this._newAuthorization.Name = "_newAuthorization";
            this._newAuthorization.Padding = new System.Windows.Forms.Padding(2);
            this._newAuthorization.Size = new System.Drawing.Size(1023, 543);
            this._newAuthorization.TabIndex = 0;
            this._newAuthorization.Text = "Add";
            this._newAuthorization.UseVisualStyleBackColor = true;
            // 
            // _insertAuthoButton
            // 
            this._insertAuthoButton.Location = new System.Drawing.Point(365, 277);
            this._insertAuthoButton.Margin = new System.Windows.Forms.Padding(2);
            this._insertAuthoButton.Name = "_insertAuthoButton";
            this._insertAuthoButton.Size = new System.Drawing.Size(69, 30);
            this._insertAuthoButton.TabIndex = 6;
            this._insertAuthoButton.Text = "Add";
            this._insertAuthoButton.UseVisualStyleBackColor = true;
            this._insertAuthoButton.Click += new System.EventHandler(this.ClickAddAuthoButton);
            // 
            // _newAuthoLevelCB
            // 
            this._newAuthoLevelCB.FormattingEnabled = true;
            this._newAuthoLevelCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this._newAuthoLevelCB.Location = new System.Drawing.Point(167, 162);
            this._newAuthoLevelCB.Margin = new System.Windows.Forms.Padding(2);
            this._newAuthoLevelCB.Name = "_newAuthoLevelCB";
            this._newAuthoLevelCB.Size = new System.Drawing.Size(91, 24);
            this._newAuthoLevelCB.TabIndex = 5;
            // 
            // _newAuthoNameTB
            // 
            this._newAuthoNameTB.Location = new System.Drawing.Point(170, 87);
            this._newAuthoNameTB.Margin = new System.Windows.Forms.Padding(2);
            this._newAuthoNameTB.Name = "_newAuthoNameTB";
            this._newAuthoNameTB.Size = new System.Drawing.Size(181, 27);
            this._newAuthoNameTB.TabIndex = 4;
            // 
            // _newAuthoIDTB
            // 
            this._newAuthoIDTB.Location = new System.Drawing.Point(150, 19);
            this._newAuthoIDTB.Margin = new System.Windows.Forms.Padding(2);
            this._newAuthoIDTB.Name = "_newAuthoIDTB";
            this._newAuthoIDTB.Size = new System.Drawing.Size(201, 27);
            this._newAuthoIDTB.TabIndex = 3;
            // 
            // _newAuthoLevelLB
            // 
            this._newAuthoLevelLB.AutoSize = true;
            this._newAuthoLevelLB.Location = new System.Drawing.Point(33, 167);
            this._newAuthoLevelLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newAuthoLevelLB.Name = "_newAuthoLevelLB";
            this._newAuthoLevelLB.Size = new System.Drawing.Size(137, 16);
            this._newAuthoLevelLB.TabIndex = 2;
            this._newAuthoLevelLB.Text = "Authorization Level:";
            // 
            // _newAuthoNameLB
            // 
            this._newAuthoNameLB.AutoSize = true;
            this._newAuthoNameLB.Location = new System.Drawing.Point(33, 95);
            this._newAuthoNameLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newAuthoNameLB.Name = "_newAuthoNameLB";
            this._newAuthoNameLB.Size = new System.Drawing.Size(139, 16);
            this._newAuthoNameLB.TabIndex = 1;
            this._newAuthoNameLB.Text = "Authorization Name:";
            // 
            // _newAuthoIDLB
            // 
            this._newAuthoIDLB.AutoSize = true;
            this._newAuthoIDLB.Location = new System.Drawing.Point(33, 27);
            this._newAuthoIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._newAuthoIDLB.Name = "_newAuthoIDLB";
            this._newAuthoIDLB.Size = new System.Drawing.Size(118, 16);
            this._newAuthoIDLB.TabIndex = 0;
            this._newAuthoIDLB.Text = "Authorization ID:";
            // 
            // _editAuthorization
            // 
            this._editAuthorization.Controls.Add(this._editAuthoButton);
            this._editAuthorization.Controls.Add(this._searchAuthoButton);
            this._editAuthorization.Controls.Add(this._editAuthoLevelCB);
            this._editAuthorization.Controls.Add(this._editAuthoNameTB);
            this._editAuthorization.Controls.Add(this._editAuthoIDTB);
            this._editAuthorization.Controls.Add(this._editAuthoLevelLB);
            this._editAuthorization.Controls.Add(this._editAuthoNameLB);
            this._editAuthorization.Controls.Add(this._editAuthoIDLB);
            this._editAuthorization.Location = new System.Drawing.Point(4, 26);
            this._editAuthorization.Margin = new System.Windows.Forms.Padding(2);
            this._editAuthorization.Name = "_editAuthorization";
            this._editAuthorization.Padding = new System.Windows.Forms.Padding(2);
            this._editAuthorization.Size = new System.Drawing.Size(1023, 543);
            this._editAuthorization.TabIndex = 1;
            this._editAuthorization.Text = "Edit";
            this._editAuthorization.UseVisualStyleBackColor = true;
            // 
            // _editAuthoButton
            // 
            this._editAuthoButton.Location = new System.Drawing.Point(495, 303);
            this._editAuthoButton.Margin = new System.Windows.Forms.Padding(2);
            this._editAuthoButton.Name = "_editAuthoButton";
            this._editAuthoButton.Size = new System.Drawing.Size(79, 37);
            this._editAuthoButton.TabIndex = 13;
            this._editAuthoButton.Text = "Edit";
            this._editAuthoButton.UseVisualStyleBackColor = true;
            this._editAuthoButton.Click += new System.EventHandler(this.ClickEditAuthoButtom);
            // 
            // _searchAuthoButton
            // 
            this._searchAuthoButton.Location = new System.Drawing.Point(377, 303);
            this._searchAuthoButton.Margin = new System.Windows.Forms.Padding(2);
            this._searchAuthoButton.Name = "_searchAuthoButton";
            this._searchAuthoButton.Size = new System.Drawing.Size(74, 37);
            this._searchAuthoButton.TabIndex = 12;
            this._searchAuthoButton.Text = "Search";
            this._searchAuthoButton.UseVisualStyleBackColor = true;
            this._searchAuthoButton.Click += new System.EventHandler(this.ClickSearchAuthoButtom);
            // 
            // _editAuthoLevelCB
            // 
            this._editAuthoLevelCB.FormattingEnabled = true;
            this._editAuthoLevelCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this._editAuthoLevelCB.Location = new System.Drawing.Point(175, 174);
            this._editAuthoLevelCB.Margin = new System.Windows.Forms.Padding(2);
            this._editAuthoLevelCB.Name = "_editAuthoLevelCB";
            this._editAuthoLevelCB.Size = new System.Drawing.Size(91, 24);
            this._editAuthoLevelCB.TabIndex = 11;
            // 
            // _editAuthoNameTB
            // 
            this._editAuthoNameTB.Location = new System.Drawing.Point(178, 99);
            this._editAuthoNameTB.Margin = new System.Windows.Forms.Padding(2);
            this._editAuthoNameTB.Name = "_editAuthoNameTB";
            this._editAuthoNameTB.Size = new System.Drawing.Size(181, 27);
            this._editAuthoNameTB.TabIndex = 10;
            // 
            // _editAuthoIDTB
            // 
            this._editAuthoIDTB.Location = new System.Drawing.Point(158, 31);
            this._editAuthoIDTB.Margin = new System.Windows.Forms.Padding(2);
            this._editAuthoIDTB.Name = "_editAuthoIDTB";
            this._editAuthoIDTB.Size = new System.Drawing.Size(201, 27);
            this._editAuthoIDTB.TabIndex = 9;
            // 
            // _editAuthoLevelLB
            // 
            this._editAuthoLevelLB.AutoSize = true;
            this._editAuthoLevelLB.Location = new System.Drawing.Point(41, 179);
            this._editAuthoLevelLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editAuthoLevelLB.Name = "_editAuthoLevelLB";
            this._editAuthoLevelLB.Size = new System.Drawing.Size(137, 16);
            this._editAuthoLevelLB.TabIndex = 8;
            this._editAuthoLevelLB.Text = "Authorization Level:";
            // 
            // _editAuthoNameLB
            // 
            this._editAuthoNameLB.AutoSize = true;
            this._editAuthoNameLB.Location = new System.Drawing.Point(41, 107);
            this._editAuthoNameLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editAuthoNameLB.Name = "_editAuthoNameLB";
            this._editAuthoNameLB.Size = new System.Drawing.Size(139, 16);
            this._editAuthoNameLB.TabIndex = 7;
            this._editAuthoNameLB.Text = "Authorization Name:";
            // 
            // _editAuthoIDLB
            // 
            this._editAuthoIDLB.AutoSize = true;
            this._editAuthoIDLB.Location = new System.Drawing.Point(41, 39);
            this._editAuthoIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editAuthoIDLB.Name = "_editAuthoIDLB";
            this._editAuthoIDLB.Size = new System.Drawing.Size(118, 16);
            this._editAuthoIDLB.TabIndex = 6;
            this._editAuthoIDLB.Text = "Authorization ID:";
            // 
            // _salary
            // 
            this._salary.Controls.Add(this._salaryPage);
            this._salary.Location = new System.Drawing.Point(4, 26);
            this._salary.Margin = new System.Windows.Forms.Padding(2);
            this._salary.Name = "_salary";
            this._salary.Padding = new System.Windows.Forms.Padding(2);
            this._salary.Size = new System.Drawing.Size(1053, 577);
            this._salary.TabIndex = 4;
            this._salary.Text = "Salary";
            this._salary.UseVisualStyleBackColor = true;
            // 
            // _salaryPage
            // 
            this._salaryPage.Controls.Add(this._addpayMethod);
            this._salaryPage.Controls.Add(this._editPayMethod);
            this._salaryPage.Location = new System.Drawing.Point(5, 3);
            this._salaryPage.Name = "_salaryPage";
            this._salaryPage.SelectedIndex = 0;
            this._salaryPage.Size = new System.Drawing.Size(1048, 578);
            this._salaryPage.TabIndex = 0;
            // 
            // _addpayMethod
            // 
            this._addpayMethod.Controls.Add(this._addPaywayButton);
            this._addpayMethod.Controls.Add(this._addPaywayMethodCB);
            this._addpayMethod.Controls.Add(this._addPaywayAccountTB);
            this._addpayMethod.Controls.Add(this._addPaywayEmplIDTB);
            this._addpayMethod.Controls.Add(this._addpaywayAccountLB);
            this._addpayMethod.Controls.Add(this._addPaywayMethodLB);
            this._addpayMethod.Controls.Add(this._addPaywayEmplIDLB);
            this._addpayMethod.Location = new System.Drawing.Point(4, 26);
            this._addpayMethod.Name = "_addpayMethod";
            this._addpayMethod.Padding = new System.Windows.Forms.Padding(3);
            this._addpayMethod.Size = new System.Drawing.Size(1040, 548);
            this._addpayMethod.TabIndex = 1;
            this._addpayMethod.Text = "Add Payment Method";
            this._addpayMethod.UseVisualStyleBackColor = true;
            // 
            // _addPaywayButton
            // 
            this._addPaywayButton.Location = new System.Drawing.Point(398, 294);
            this._addPaywayButton.Name = "_addPaywayButton";
            this._addPaywayButton.Size = new System.Drawing.Size(108, 37);
            this._addPaywayButton.TabIndex = 6;
            this._addPaywayButton.Text = "Add";
            this._addPaywayButton.UseVisualStyleBackColor = true;
            this._addPaywayButton.Click += new System.EventHandler(this.ClickAddPaywayButton);
            // 
            // _addPaywayMethodCB
            // 
            this._addPaywayMethodCB.FormattingEnabled = true;
            this._addPaywayMethodCB.Items.AddRange(new object[] {
            "In Person",
            "Transfer"});
            this._addPaywayMethodCB.Location = new System.Drawing.Point(180, 110);
            this._addPaywayMethodCB.Name = "_addPaywayMethodCB";
            this._addPaywayMethodCB.Size = new System.Drawing.Size(170, 24);
            this._addPaywayMethodCB.TabIndex = 5;
            this._addPaywayMethodCB.SelectedIndexChanged += new System.EventHandler(this.ChangedAddPaywayMethodCBSelectedIndex);
            // 
            // _addPaywayAccountTB
            // 
            this._addPaywayAccountTB.Location = new System.Drawing.Point(107, 206);
            this._addPaywayAccountTB.Name = "_addPaywayAccountTB";
            this._addPaywayAccountTB.Size = new System.Drawing.Size(243, 27);
            this._addPaywayAccountTB.TabIndex = 4;
            // 
            // _addPaywayEmplIDTB
            // 
            this._addPaywayEmplIDTB.Location = new System.Drawing.Point(157, 50);
            this._addPaywayEmplIDTB.Name = "_addPaywayEmplIDTB";
            this._addPaywayEmplIDTB.Size = new System.Drawing.Size(193, 27);
            this._addPaywayEmplIDTB.TabIndex = 3;
            // 
            // _addpaywayAccountLB
            // 
            this._addpaywayAccountLB.AutoSize = true;
            this._addpaywayAccountLB.Location = new System.Drawing.Point(59, 181);
            this._addpaywayAccountLB.Name = "_addpaywayAccountLB";
            this._addpaywayAccountLB.Size = new System.Drawing.Size(123, 16);
            this._addpaywayAccountLB.TabIndex = 2;
            this._addpaywayAccountLB.Text = "Payment Account:";
            // 
            // _addPaywayMethodLB
            // 
            this._addPaywayMethodLB.AutoSize = true;
            this._addPaywayMethodLB.Location = new System.Drawing.Point(59, 116);
            this._addPaywayMethodLB.Name = "_addPaywayMethodLB";
            this._addPaywayMethodLB.Size = new System.Drawing.Size(118, 16);
            this._addPaywayMethodLB.TabIndex = 1;
            this._addPaywayMethodLB.Text = "Payment Method:";
            // 
            // _addPaywayEmplIDLB
            // 
            this._addPaywayEmplIDLB.AutoSize = true;
            this._addPaywayEmplIDLB.Location = new System.Drawing.Point(59, 56);
            this._addPaywayEmplIDLB.Name = "_addPaywayEmplIDLB";
            this._addPaywayEmplIDLB.Size = new System.Drawing.Size(95, 16);
            this._addPaywayEmplIDLB.TabIndex = 0;
            this._addPaywayEmplIDLB.Text = "Employee ID:";
            // 
            // _editPayMethod
            // 
            this._editPayMethod.Controls.Add(this._paywayEditButton);
            this._editPayMethod.Controls.Add(this._paywaySearchButton);
            this._editPayMethod.Controls.Add(this._editPaywayMethodCB);
            this._editPayMethod.Controls.Add(this._editPaywayAccountTB);
            this._editPayMethod.Controls.Add(this._editPaywayEmplIDTB);
            this._editPayMethod.Controls.Add(this._editPaywayAccountLB);
            this._editPayMethod.Controls.Add(this._editPaywayMethodLB);
            this._editPayMethod.Controls.Add(this._editPaywayEmplIDLB);
            this._editPayMethod.Location = new System.Drawing.Point(4, 26);
            this._editPayMethod.Name = "_editPayMethod";
            this._editPayMethod.Padding = new System.Windows.Forms.Padding(3);
            this._editPayMethod.Size = new System.Drawing.Size(1040, 548);
            this._editPayMethod.TabIndex = 2;
            this._editPayMethod.Text = "Edit Payment Method";
            this._editPayMethod.UseVisualStyleBackColor = true;
            // 
            // _paywayEditButton
            // 
            this._paywayEditButton.Location = new System.Drawing.Point(514, 314);
            this._paywayEditButton.Name = "_paywayEditButton";
            this._paywayEditButton.Size = new System.Drawing.Size(104, 32);
            this._paywayEditButton.TabIndex = 31;
            this._paywayEditButton.Text = "Edit";
            this._paywayEditButton.UseVisualStyleBackColor = true;
            this._paywayEditButton.Click += new System.EventHandler(this.ClickPaywayEditButton);
            // 
            // _paywaySearchButton
            // 
            this._paywaySearchButton.Location = new System.Drawing.Point(380, 314);
            this._paywaySearchButton.Name = "_paywaySearchButton";
            this._paywaySearchButton.Size = new System.Drawing.Size(104, 32);
            this._paywaySearchButton.TabIndex = 30;
            this._paywaySearchButton.Text = "Search";
            this._paywaySearchButton.UseVisualStyleBackColor = true;
            this._paywaySearchButton.Click += new System.EventHandler(this.ClickPaywaySearchButton);
            // 
            // _editPaywayMethodCB
            // 
            this._editPaywayMethodCB.FormattingEnabled = true;
            this._editPaywayMethodCB.Items.AddRange(new object[] {
            "In Person",
            "Transfer"});
            this._editPaywayMethodCB.Location = new System.Drawing.Point(182, 126);
            this._editPaywayMethodCB.Name = "_editPaywayMethodCB";
            this._editPaywayMethodCB.Size = new System.Drawing.Size(166, 24);
            this._editPaywayMethodCB.TabIndex = 29;
            this._editPaywayMethodCB.SelectedIndexChanged += new System.EventHandler(this.ChangededitPaywayMethodCBSelectedIndex);
            // 
            // _editPaywayAccountTB
            // 
            this._editPaywayAccountTB.Location = new System.Drawing.Point(100, 234);
            this._editPaywayAccountTB.Name = "_editPaywayAccountTB";
            this._editPaywayAccountTB.Size = new System.Drawing.Size(248, 27);
            this._editPaywayAccountTB.TabIndex = 28;
            // 
            // _editPaywayEmplIDTB
            // 
            this._editPaywayEmplIDTB.Location = new System.Drawing.Point(159, 48);
            this._editPaywayEmplIDTB.Name = "_editPaywayEmplIDTB";
            this._editPaywayEmplIDTB.Size = new System.Drawing.Size(189, 27);
            this._editPaywayEmplIDTB.TabIndex = 27;
            // 
            // _editPaywayAccountLB
            // 
            this._editPaywayAccountLB.AutoSize = true;
            this._editPaywayAccountLB.Location = new System.Drawing.Point(61, 204);
            this._editPaywayAccountLB.Name = "_editPaywayAccountLB";
            this._editPaywayAccountLB.Size = new System.Drawing.Size(123, 16);
            this._editPaywayAccountLB.TabIndex = 26;
            this._editPaywayAccountLB.Text = "Payment Account:";
            // 
            // _editPaywayMethodLB
            // 
            this._editPaywayMethodLB.AutoSize = true;
            this._editPaywayMethodLB.Location = new System.Drawing.Point(61, 132);
            this._editPaywayMethodLB.Name = "_editPaywayMethodLB";
            this._editPaywayMethodLB.Size = new System.Drawing.Size(118, 16);
            this._editPaywayMethodLB.TabIndex = 25;
            this._editPaywayMethodLB.Text = "Payment Method:";
            // 
            // _editPaywayEmplIDLB
            // 
            this._editPaywayEmplIDLB.AutoSize = true;
            this._editPaywayEmplIDLB.Location = new System.Drawing.Point(61, 54);
            this._editPaywayEmplIDLB.Name = "_editPaywayEmplIDLB";
            this._editPaywayEmplIDLB.Size = new System.Drawing.Size(95, 16);
            this._editPaywayEmplIDLB.TabIndex = 24;
            this._editPaywayEmplIDLB.Text = "Employee ID:";
            // 
            // _bonus
            // 
            this._bonus.Controls.Add(this._bonusPage);
            this._bonus.Location = new System.Drawing.Point(4, 26);
            this._bonus.Margin = new System.Windows.Forms.Padding(2);
            this._bonus.Name = "_bonus";
            this._bonus.Padding = new System.Windows.Forms.Padding(2);
            this._bonus.Size = new System.Drawing.Size(1053, 577);
            this._bonus.TabIndex = 3;
            this._bonus.Text = "Bonus";
            this._bonus.UseVisualStyleBackColor = true;
            // 
            // _bonusPage
            // 
            this._bonusPage.Controls.Add(this._addBonusDef);
            this._bonusPage.Controls.Add(this._editBonusDef);
            this._bonusPage.Controls.Add(this._addBonusTLB);
            this._bonusPage.Controls.Add(this._emplBonusSearch);
            this._bonusPage.Location = new System.Drawing.Point(3, 5);
            this._bonusPage.Margin = new System.Windows.Forms.Padding(2);
            this._bonusPage.Name = "_bonusPage";
            this._bonusPage.SelectedIndex = 0;
            this._bonusPage.Size = new System.Drawing.Size(1033, 573);
            this._bonusPage.TabIndex = 0;
            // 
            // _addBonusDef
            // 
            this._addBonusDef.Controls.Add(this._addBonusDefButton);
            this._addBonusDef.Controls.Add(this._addBonusDefAmountTB);
            this._addBonusDef.Controls.Add(this._addBonusDefAmountLB);
            this._addBonusDef.Controls.Add(this._addBonusDefEffiDateDTP);
            this._addBonusDef.Controls.Add(this._addBonusDefEffiDateLB);
            this._addBonusDef.Controls.Add(this._addBonusDefCreateDateDTP);
            this._addBonusDef.Controls.Add(this._addBonusDefCreateDateLB);
            this._addBonusDef.Controls.Add(this._addBonusDefDescTB);
            this._addBonusDef.Controls.Add(this._addBonusDefDescLB);
            this._addBonusDef.Controls.Add(this._addBonusNameTB);
            this._addBonusDef.Controls.Add(this._addBonusDefNameLB);
            this._addBonusDef.Controls.Add(this._addBonusDefIDTB);
            this._addBonusDef.Controls.Add(this._addBonusDefIDLB);
            this._addBonusDef.Location = new System.Drawing.Point(4, 26);
            this._addBonusDef.Margin = new System.Windows.Forms.Padding(2);
            this._addBonusDef.Name = "_addBonusDef";
            this._addBonusDef.Padding = new System.Windows.Forms.Padding(2);
            this._addBonusDef.Size = new System.Drawing.Size(1025, 543);
            this._addBonusDef.TabIndex = 0;
            this._addBonusDef.Text = "Add Definition";
            this._addBonusDef.UseVisualStyleBackColor = true;
            // 
            // _addBonusDefButton
            // 
            this._addBonusDefButton.Location = new System.Drawing.Point(584, 377);
            this._addBonusDefButton.Margin = new System.Windows.Forms.Padding(2);
            this._addBonusDefButton.Name = "_addBonusDefButton";
            this._addBonusDefButton.Size = new System.Drawing.Size(74, 24);
            this._addBonusDefButton.TabIndex = 12;
            this._addBonusDefButton.Text = "Add";
            this._addBonusDefButton.UseVisualStyleBackColor = true;
            this._addBonusDefButton.Click += new System.EventHandler(this.ClickAddBonusDefButton);
            // 
            // _addBonusDefAmountTB
            // 
            this._addBonusDefAmountTB.Location = new System.Drawing.Point(518, 152);
            this._addBonusDefAmountTB.Margin = new System.Windows.Forms.Padding(2);
            this._addBonusDefAmountTB.Name = "_addBonusDefAmountTB";
            this._addBonusDefAmountTB.Size = new System.Drawing.Size(141, 27);
            this._addBonusDefAmountTB.TabIndex = 11;
            this._addBonusDefAmountTB.Text = "0";
            // 
            // _addBonusDefAmountLB
            // 
            this._addBonusDefAmountLB.AutoSize = true;
            this._addBonusDefAmountLB.Location = new System.Drawing.Point(412, 156);
            this._addBonusDefAmountLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addBonusDefAmountLB.Name = "_addBonusDefAmountLB";
            this._addBonusDefAmountLB.Size = new System.Drawing.Size(107, 16);
            this._addBonusDefAmountLB.TabIndex = 10;
            this._addBonusDefAmountLB.Text = "Bonus Amount:";
            // 
            // _addBonusDefEffiDateDTP
            // 
            this._addBonusDefEffiDateDTP.Location = new System.Drawing.Point(525, 79);
            this._addBonusDefEffiDateDTP.Margin = new System.Windows.Forms.Padding(2);
            this._addBonusDefEffiDateDTP.Name = "_addBonusDefEffiDateDTP";
            this._addBonusDefEffiDateDTP.Size = new System.Drawing.Size(135, 27);
            this._addBonusDefEffiDateDTP.TabIndex = 9;
            // 
            // _addBonusDefEffiDateLB
            // 
            this._addBonusDefEffiDateLB.AutoSize = true;
            this._addBonusDefEffiDateLB.Location = new System.Drawing.Point(409, 87);
            this._addBonusDefEffiDateLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addBonusDefEffiDateLB.Name = "_addBonusDefEffiDateLB";
            this._addBonusDefEffiDateLB.Size = new System.Drawing.Size(115, 16);
            this._addBonusDefEffiDateLB.TabIndex = 8;
            this._addBonusDefEffiDateLB.Text = "Efficacious Date:";
            // 
            // _addBonusDefCreateDateDTP
            // 
            this._addBonusDefCreateDateDTP.Location = new System.Drawing.Point(495, 17);
            this._addBonusDefCreateDateDTP.Margin = new System.Windows.Forms.Padding(2);
            this._addBonusDefCreateDateDTP.Name = "_addBonusDefCreateDateDTP";
            this._addBonusDefCreateDateDTP.Size = new System.Drawing.Size(135, 27);
            this._addBonusDefCreateDateDTP.TabIndex = 7;
            // 
            // _addBonusDefCreateDateLB
            // 
            this._addBonusDefCreateDateLB.AutoSize = true;
            this._addBonusDefCreateDateLB.Location = new System.Drawing.Point(409, 25);
            this._addBonusDefCreateDateLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addBonusDefCreateDateLB.Name = "_addBonusDefCreateDateLB";
            this._addBonusDefCreateDateLB.Size = new System.Drawing.Size(85, 16);
            this._addBonusDefCreateDateLB.TabIndex = 6;
            this._addBonusDefCreateDateLB.Text = "Create Date:";
            // 
            // _addBonusDefDescTB
            // 
            this._addBonusDefDescTB.Location = new System.Drawing.Point(155, 151);
            this._addBonusDefDescTB.Margin = new System.Windows.Forms.Padding(2);
            this._addBonusDefDescTB.Multiline = true;
            this._addBonusDefDescTB.Name = "_addBonusDefDescTB";
            this._addBonusDefDescTB.Size = new System.Drawing.Size(189, 251);
            this._addBonusDefDescTB.TabIndex = 5;
            // 
            // _addBonusDefDescLB
            // 
            this._addBonusDefDescLB.AutoSize = true;
            this._addBonusDefDescLB.Location = new System.Drawing.Point(29, 153);
            this._addBonusDefDescLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addBonusDefDescLB.Name = "_addBonusDefDescLB";
            this._addBonusDefDescLB.Size = new System.Drawing.Size(128, 16);
            this._addBonusDefDescLB.TabIndex = 4;
            this._addBonusDefDescLB.Text = "Bonus Description:";
            // 
            // _addBonusNameTB
            // 
            this._addBonusNameTB.Location = new System.Drawing.Point(120, 83);
            this._addBonusNameTB.Margin = new System.Windows.Forms.Padding(2);
            this._addBonusNameTB.Name = "_addBonusNameTB";
            this._addBonusNameTB.Size = new System.Drawing.Size(224, 27);
            this._addBonusNameTB.TabIndex = 3;
            // 
            // _addBonusDefNameLB
            // 
            this._addBonusDefNameLB.AutoSize = true;
            this._addBonusDefNameLB.Location = new System.Drawing.Point(27, 87);
            this._addBonusDefNameLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addBonusDefNameLB.Name = "_addBonusDefNameLB";
            this._addBonusDefNameLB.Size = new System.Drawing.Size(93, 16);
            this._addBonusDefNameLB.TabIndex = 2;
            this._addBonusDefNameLB.Text = "Bonus Name:";
            // 
            // _addBonusDefIDTB
            // 
            this._addBonusDefIDTB.Location = new System.Drawing.Point(164, 17);
            this._addBonusDefIDTB.Margin = new System.Windows.Forms.Padding(2);
            this._addBonusDefIDTB.Name = "_addBonusDefIDTB";
            this._addBonusDefIDTB.Size = new System.Drawing.Size(180, 27);
            this._addBonusDefIDTB.TabIndex = 1;
            // 
            // _addBonusDefIDLB
            // 
            this._addBonusDefIDLB.AutoSize = true;
            this._addBonusDefIDLB.Location = new System.Drawing.Point(27, 25);
            this._addBonusDefIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addBonusDefIDLB.Name = "_addBonusDefIDLB";
            this._addBonusDefIDLB.Size = new System.Drawing.Size(139, 16);
            this._addBonusDefIDLB.TabIndex = 0;
            this._addBonusDefIDLB.Text = "Bonus Definition ID:";
            // 
            // _editBonusDef
            // 
            this._editBonusDef.Controls.Add(this._editBonusDefButton);
            this._editBonusDef.Controls.Add(this._searchBonusDefButton);
            this._editBonusDef.Controls.Add(this._editBonusDefAmountTB);
            this._editBonusDef.Controls.Add(this._editBonusDefAmountLB);
            this._editBonusDef.Controls.Add(this._editBonusDefEffiDateDTP);
            this._editBonusDef.Controls.Add(this._editBonusDefEffiDateLB);
            this._editBonusDef.Controls.Add(this._editBonusDefCreateDateDTP);
            this._editBonusDef.Controls.Add(this._editBonusDefCreateDateLB);
            this._editBonusDef.Controls.Add(this._editBonusDefDescTB);
            this._editBonusDef.Controls.Add(this._editBonusDefDescLB);
            this._editBonusDef.Controls.Add(this._editBonusDefNameTB);
            this._editBonusDef.Controls.Add(this._editBonusDefNameLB);
            this._editBonusDef.Controls.Add(this._editBonusDefIDTB);
            this._editBonusDef.Controls.Add(this._editBonusDefIDLB);
            this._editBonusDef.Location = new System.Drawing.Point(4, 26);
            this._editBonusDef.Margin = new System.Windows.Forms.Padding(2);
            this._editBonusDef.Name = "_editBonusDef";
            this._editBonusDef.Padding = new System.Windows.Forms.Padding(2);
            this._editBonusDef.Size = new System.Drawing.Size(1025, 543);
            this._editBonusDef.TabIndex = 1;
            this._editBonusDef.Text = "Edit Definition";
            this._editBonusDef.UseVisualStyleBackColor = true;
            // 
            // _editBonusDefButton
            // 
            this._editBonusDefButton.Enabled = false;
            this._editBonusDefButton.Location = new System.Drawing.Point(687, 392);
            this._editBonusDefButton.Margin = new System.Windows.Forms.Padding(2);
            this._editBonusDefButton.Name = "_editBonusDefButton";
            this._editBonusDefButton.Size = new System.Drawing.Size(74, 24);
            this._editBonusDefButton.TabIndex = 26;
            this._editBonusDefButton.Text = "Edit";
            this._editBonusDefButton.UseVisualStyleBackColor = true;
            this._editBonusDefButton.Click += new System.EventHandler(this.ClickEditBonusDefButton);
            // 
            // _searchBonusDefButton
            // 
            this._searchBonusDefButton.Location = new System.Drawing.Point(589, 392);
            this._searchBonusDefButton.Margin = new System.Windows.Forms.Padding(2);
            this._searchBonusDefButton.Name = "_searchBonusDefButton";
            this._searchBonusDefButton.Size = new System.Drawing.Size(74, 24);
            this._searchBonusDefButton.TabIndex = 25;
            this._searchBonusDefButton.Text = "Search";
            this._searchBonusDefButton.UseVisualStyleBackColor = true;
            this._searchBonusDefButton.Click += new System.EventHandler(this.ClickSearchBonusDefButton);
            // 
            // _editBonusDefAmountTB
            // 
            this._editBonusDefAmountTB.Enabled = false;
            this._editBonusDefAmountTB.Location = new System.Drawing.Point(523, 167);
            this._editBonusDefAmountTB.Margin = new System.Windows.Forms.Padding(2);
            this._editBonusDefAmountTB.Name = "_editBonusDefAmountTB";
            this._editBonusDefAmountTB.Size = new System.Drawing.Size(141, 27);
            this._editBonusDefAmountTB.TabIndex = 24;
            this._editBonusDefAmountTB.Text = "0";
            // 
            // _editBonusDefAmountLB
            // 
            this._editBonusDefAmountLB.AutoSize = true;
            this._editBonusDefAmountLB.Location = new System.Drawing.Point(417, 171);
            this._editBonusDefAmountLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editBonusDefAmountLB.Name = "_editBonusDefAmountLB";
            this._editBonusDefAmountLB.Size = new System.Drawing.Size(107, 16);
            this._editBonusDefAmountLB.TabIndex = 23;
            this._editBonusDefAmountLB.Text = "Bonus Amount:";
            // 
            // _editBonusDefEffiDateDTP
            // 
            this._editBonusDefEffiDateDTP.Enabled = false;
            this._editBonusDefEffiDateDTP.Location = new System.Drawing.Point(530, 95);
            this._editBonusDefEffiDateDTP.Margin = new System.Windows.Forms.Padding(2);
            this._editBonusDefEffiDateDTP.Name = "_editBonusDefEffiDateDTP";
            this._editBonusDefEffiDateDTP.Size = new System.Drawing.Size(135, 27);
            this._editBonusDefEffiDateDTP.TabIndex = 22;
            // 
            // _editBonusDefEffiDateLB
            // 
            this._editBonusDefEffiDateLB.AutoSize = true;
            this._editBonusDefEffiDateLB.Location = new System.Drawing.Point(415, 103);
            this._editBonusDefEffiDateLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editBonusDefEffiDateLB.Name = "_editBonusDefEffiDateLB";
            this._editBonusDefEffiDateLB.Size = new System.Drawing.Size(115, 16);
            this._editBonusDefEffiDateLB.TabIndex = 21;
            this._editBonusDefEffiDateLB.Text = "Efficacious Date:";
            // 
            // _editBonusDefCreateDateDTP
            // 
            this._editBonusDefCreateDateDTP.Enabled = false;
            this._editBonusDefCreateDateDTP.Location = new System.Drawing.Point(501, 32);
            this._editBonusDefCreateDateDTP.Margin = new System.Windows.Forms.Padding(2);
            this._editBonusDefCreateDateDTP.Name = "_editBonusDefCreateDateDTP";
            this._editBonusDefCreateDateDTP.Size = new System.Drawing.Size(135, 27);
            this._editBonusDefCreateDateDTP.TabIndex = 20;
            // 
            // _editBonusDefCreateDateLB
            // 
            this._editBonusDefCreateDateLB.AutoSize = true;
            this._editBonusDefCreateDateLB.Location = new System.Drawing.Point(415, 40);
            this._editBonusDefCreateDateLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editBonusDefCreateDateLB.Name = "_editBonusDefCreateDateLB";
            this._editBonusDefCreateDateLB.Size = new System.Drawing.Size(85, 16);
            this._editBonusDefCreateDateLB.TabIndex = 19;
            this._editBonusDefCreateDateLB.Text = "Create Date:";
            // 
            // _editBonusDefDescTB
            // 
            this._editBonusDefDescTB.Enabled = false;
            this._editBonusDefDescTB.Location = new System.Drawing.Point(161, 166);
            this._editBonusDefDescTB.Margin = new System.Windows.Forms.Padding(2);
            this._editBonusDefDescTB.Multiline = true;
            this._editBonusDefDescTB.Name = "_editBonusDefDescTB";
            this._editBonusDefDescTB.Size = new System.Drawing.Size(189, 251);
            this._editBonusDefDescTB.TabIndex = 18;
            // 
            // _editBonusDefDescLB
            // 
            this._editBonusDefDescLB.AutoSize = true;
            this._editBonusDefDescLB.Location = new System.Drawing.Point(35, 168);
            this._editBonusDefDescLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editBonusDefDescLB.Name = "_editBonusDefDescLB";
            this._editBonusDefDescLB.Size = new System.Drawing.Size(128, 16);
            this._editBonusDefDescLB.TabIndex = 17;
            this._editBonusDefDescLB.Text = "Bonus Description:";
            // 
            // _editBonusDefNameTB
            // 
            this._editBonusDefNameTB.Enabled = false;
            this._editBonusDefNameTB.Location = new System.Drawing.Point(125, 99);
            this._editBonusDefNameTB.Margin = new System.Windows.Forms.Padding(2);
            this._editBonusDefNameTB.Name = "_editBonusDefNameTB";
            this._editBonusDefNameTB.Size = new System.Drawing.Size(224, 27);
            this._editBonusDefNameTB.TabIndex = 16;
            // 
            // _editBonusDefNameLB
            // 
            this._editBonusDefNameLB.AutoSize = true;
            this._editBonusDefNameLB.Location = new System.Drawing.Point(32, 103);
            this._editBonusDefNameLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editBonusDefNameLB.Name = "_editBonusDefNameLB";
            this._editBonusDefNameLB.Size = new System.Drawing.Size(93, 16);
            this._editBonusDefNameLB.TabIndex = 15;
            this._editBonusDefNameLB.Text = "Bonus Name:";
            // 
            // _editBonusDefIDTB
            // 
            this._editBonusDefIDTB.Location = new System.Drawing.Point(169, 32);
            this._editBonusDefIDTB.Margin = new System.Windows.Forms.Padding(2);
            this._editBonusDefIDTB.Name = "_editBonusDefIDTB";
            this._editBonusDefIDTB.Size = new System.Drawing.Size(180, 27);
            this._editBonusDefIDTB.TabIndex = 14;
            // 
            // _editBonusDefIDLB
            // 
            this._editBonusDefIDLB.AutoSize = true;
            this._editBonusDefIDLB.Location = new System.Drawing.Point(32, 40);
            this._editBonusDefIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editBonusDefIDLB.Name = "_editBonusDefIDLB";
            this._editBonusDefIDLB.Size = new System.Drawing.Size(139, 16);
            this._editBonusDefIDLB.TabIndex = 13;
            this._editBonusDefIDLB.Text = "Bonus Definition ID:";
            // 
            // _addBonusTLB
            // 
            this._addBonusTLB.Controls.Add(this._addbonusPeriodTB);
            this._addBonusTLB.Controls.Add(this.label1);
            this._addBonusTLB.Controls.Add(this._addBonusButton);
            this._addBonusTLB.Controls.Add(this._addBonusDateDTP);
            this._addBonusTLB.Controls.Add(this._addBonusDateLB);
            this._addBonusTLB.Controls.Add(this._addBonusEmplIDTB);
            this._addBonusTLB.Controls.Add(this._addBonusEmplID);
            this._addBonusTLB.Controls.Add(this._addBonusCB);
            this._addBonusTLB.Controls.Add(this._addBonusNameLB);
            this._addBonusTLB.Location = new System.Drawing.Point(4, 26);
            this._addBonusTLB.Margin = new System.Windows.Forms.Padding(2);
            this._addBonusTLB.Name = "_addBonusTLB";
            this._addBonusTLB.Padding = new System.Windows.Forms.Padding(2);
            this._addBonusTLB.Size = new System.Drawing.Size(1025, 543);
            this._addBonusTLB.TabIndex = 2;
            this._addBonusTLB.Text = "Add";
            this._addBonusTLB.UseVisualStyleBackColor = true;
            // 
            // _addbonusPeriodTB
            // 
            this._addbonusPeriodTB.AcceptsReturn = true;
            this._addbonusPeriodTB.Location = new System.Drawing.Point(103, 265);
            this._addbonusPeriodTB.Margin = new System.Windows.Forms.Padding(2);
            this._addbonusPeriodTB.Name = "_addbonusPeriodTB";
            this._addbonusPeriodTB.Size = new System.Drawing.Size(200, 27);
            this._addbonusPeriodTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Period:";
            // 
            // _addBonusButton
            // 
            this._addBonusButton.Location = new System.Drawing.Point(319, 346);
            this._addBonusButton.Margin = new System.Windows.Forms.Padding(2);
            this._addBonusButton.Name = "_addBonusButton";
            this._addBonusButton.Size = new System.Drawing.Size(63, 25);
            this._addBonusButton.TabIndex = 6;
            this._addBonusButton.Text = "Add";
            this._addBonusButton.UseVisualStyleBackColor = true;
            this._addBonusButton.Click += new System.EventHandler(this.ClickAddBonusbutton);
            // 
            // _addBonusDateDTP
            // 
            this._addBonusDateDTP.Location = new System.Drawing.Point(119, 182);
            this._addBonusDateDTP.Margin = new System.Windows.Forms.Padding(2);
            this._addBonusDateDTP.Name = "_addBonusDateDTP";
            this._addBonusDateDTP.Size = new System.Drawing.Size(185, 27);
            this._addBonusDateDTP.TabIndex = 5;
            // 
            // _addBonusDateLB
            // 
            this._addBonusDateLB.AutoSize = true;
            this._addBonusDateLB.Location = new System.Drawing.Point(47, 190);
            this._addBonusDateLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addBonusDateLB.Name = "_addBonusDateLB";
            this._addBonusDateLB.Size = new System.Drawing.Size(72, 16);
            this._addBonusDateLB.TabIndex = 4;
            this._addBonusDateLB.Text = "Add Date:";
            // 
            // _addBonusEmplIDTB
            // 
            this._addBonusEmplIDTB.Location = new System.Drawing.Point(145, 103);
            this._addBonusEmplIDTB.Margin = new System.Windows.Forms.Padding(2);
            this._addBonusEmplIDTB.Name = "_addBonusEmplIDTB";
            this._addBonusEmplIDTB.Size = new System.Drawing.Size(159, 27);
            this._addBonusEmplIDTB.TabIndex = 3;
            // 
            // _addBonusEmplID
            // 
            this._addBonusEmplID.AutoSize = true;
            this._addBonusEmplID.Location = new System.Drawing.Point(47, 111);
            this._addBonusEmplID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addBonusEmplID.Name = "_addBonusEmplID";
            this._addBonusEmplID.Size = new System.Drawing.Size(95, 16);
            this._addBonusEmplID.TabIndex = 2;
            this._addBonusEmplID.Text = "Employee ID:";
            // 
            // _addBonusCB
            // 
            this._addBonusCB.DataSource = this.bonusdefBindingSource;
            this._addBonusCB.DisplayMember = "bonusName";
            this._addBonusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._addBonusCB.FormattingEnabled = true;
            this._addBonusCB.Location = new System.Drawing.Point(140, 26);
            this._addBonusCB.Margin = new System.Windows.Forms.Padding(2);
            this._addBonusCB.Name = "_addBonusCB";
            this._addBonusCB.Size = new System.Drawing.Size(163, 24);
            this._addBonusCB.TabIndex = 1;
            this._addBonusCB.ValueMember = "bonusDefID";
            // 
            // _addBonusNameLB
            // 
            this._addBonusNameLB.AutoSize = true;
            this._addBonusNameLB.Location = new System.Drawing.Point(47, 33);
            this._addBonusNameLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addBonusNameLB.Name = "_addBonusNameLB";
            this._addBonusNameLB.Size = new System.Drawing.Size(93, 16);
            this._addBonusNameLB.TabIndex = 0;
            this._addBonusNameLB.Text = "Bonus Name:";
            // 
            // _emplBonusSearch
            // 
            this._emplBonusSearch.Controls.Add(this._bonusEmplIDSearchToolStrip);
            this._emplBonusSearch.Controls.Add(this._bonusDataGridView);
            this._emplBonusSearch.Location = new System.Drawing.Point(4, 26);
            this._emplBonusSearch.Name = "_emplBonusSearch";
            this._emplBonusSearch.Padding = new System.Windows.Forms.Padding(3);
            this._emplBonusSearch.Size = new System.Drawing.Size(1025, 543);
            this._emplBonusSearch.TabIndex = 3;
            this._emplBonusSearch.Text = "Show Employee Bonus";
            this._emplBonusSearch.UseVisualStyleBackColor = true;
            // 
            // _bonusEmplIDSearchToolStrip
            // 
            this._bonusEmplIDSearchToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._bonusEmplIDSearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._emplIDToolStripLabel,
            this.emplIDToolStripTextBox,
            this._fillToolStripButton});
            this._bonusEmplIDSearchToolStrip.Location = new System.Drawing.Point(19, 25);
            this._bonusEmplIDSearchToolStrip.Name = "_bonusEmplIDSearchToolStrip";
            this._bonusEmplIDSearchToolStrip.Size = new System.Drawing.Size(247, 25);
            this._bonusEmplIDSearchToolStrip.TabIndex = 2;
            // 
            // _emplIDToolStripLabel
            // 
            this._emplIDToolStripLabel.Name = "_emplIDToolStripLabel";
            this._emplIDToolStripLabel.Size = new System.Drawing.Size(83, 22);
            this._emplIDToolStripLabel.Text = "Employee ID:";
            // 
            // emplIDToolStripTextBox
            // 
            this.emplIDToolStripTextBox.Name = "emplIDToolStripTextBox";
            this.emplIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // _fillToolStripButton
            // 
            this._fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._fillToolStripButton.Name = "_fillToolStripButton";
            this._fillToolStripButton.Size = new System.Drawing.Size(50, 22);
            this._fillToolStripButton.Text = "Search";
            this._fillToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // _bonusDataGridView
            // 
            this._bonusDataGridView.AllowUserToAddRows = false;
            this._bonusDataGridView.AllowUserToDeleteRows = false;
            this._bonusDataGridView.AutoGenerateColumns = false;
            this._bonusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._bonusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bonusDefIDDataGridViewTextBoxColumn,
            this.emplIDDataGridViewTextBoxColumn,
            this.bonusDateDataGridViewTextBoxColumn,
            this.bonusTDataGridViewTextBoxColumn});
            this._bonusDataGridView.DataSource = this.bonusBindingSource;
            this._bonusDataGridView.Location = new System.Drawing.Point(19, 76);
            this._bonusDataGridView.Name = "_bonusDataGridView";
            this._bonusDataGridView.ReadOnly = true;
            this._bonusDataGridView.RowTemplate.Height = 24;
            this._bonusDataGridView.Size = new System.Drawing.Size(643, 437);
            this._bonusDataGridView.TabIndex = 0;
            // 
            // bonusDefIDDataGridViewTextBoxColumn
            // 
            this.bonusDefIDDataGridViewTextBoxColumn.DataPropertyName = "bonusDefID";
            this.bonusDefIDDataGridViewTextBoxColumn.FillWeight = 150F;
            this.bonusDefIDDataGridViewTextBoxColumn.HeaderText = "獎金定義ID";
            this.bonusDefIDDataGridViewTextBoxColumn.Name = "bonusDefIDDataGridViewTextBoxColumn";
            this.bonusDefIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bonusDefIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // emplIDDataGridViewTextBoxColumn
            // 
            this.emplIDDataGridViewTextBoxColumn.DataPropertyName = "emplID";
            this.emplIDDataGridViewTextBoxColumn.FillWeight = 150F;
            this.emplIDDataGridViewTextBoxColumn.HeaderText = "員工ID";
            this.emplIDDataGridViewTextBoxColumn.Name = "emplIDDataGridViewTextBoxColumn";
            this.emplIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.emplIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // bonusDateDataGridViewTextBoxColumn
            // 
            this.bonusDateDataGridViewTextBoxColumn.DataPropertyName = "bonusDate";
            this.bonusDateDataGridViewTextBoxColumn.FillWeight = 150F;
            this.bonusDateDataGridViewTextBoxColumn.HeaderText = "獎金登錄日期";
            this.bonusDateDataGridViewTextBoxColumn.Name = "bonusDateDataGridViewTextBoxColumn";
            this.bonusDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.bonusDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // bonusTDataGridViewTextBoxColumn
            // 
            this.bonusTDataGridViewTextBoxColumn.DataPropertyName = "bonusT";
            this.bonusTDataGridViewTextBoxColumn.FillWeight = 150F;
            this.bonusTDataGridViewTextBoxColumn.HeaderText = "獎金登錄期別";
            this.bonusTDataGridViewTextBoxColumn.Name = "bonusTDataGridViewTextBoxColumn";
            this.bonusTDataGridViewTextBoxColumn.ReadOnly = true;
            this.bonusTDataGridViewTextBoxColumn.Width = 150;
            // 
            // _workAttendance
            // 
            this._workAttendance.Controls.Add(this._workAttendancePage);
            this._workAttendance.Location = new System.Drawing.Point(4, 26);
            this._workAttendance.Margin = new System.Windows.Forms.Padding(2);
            this._workAttendance.Name = "_workAttendance";
            this._workAttendance.Padding = new System.Windows.Forms.Padding(2);
            this._workAttendance.Size = new System.Drawing.Size(1053, 577);
            this._workAttendance.TabIndex = 1;
            this._workAttendance.Text = "Work Attendance";
            this._workAttendance.UseVisualStyleBackColor = true;
            // 
            // _workAttendancePage
            // 
            this._workAttendancePage.Controls.Add(this._addWorkAttendance);
            this._workAttendancePage.Controls.Add(this._editWorkAttendance);
            this._workAttendancePage.Location = new System.Drawing.Point(5, 5);
            this._workAttendancePage.Margin = new System.Windows.Forms.Padding(2);
            this._workAttendancePage.Name = "_workAttendancePage";
            this._workAttendancePage.SelectedIndex = 0;
            this._workAttendancePage.Size = new System.Drawing.Size(1032, 575);
            this._workAttendancePage.TabIndex = 0;
            // 
            // _addWorkAttendance
            // 
            this._addWorkAttendance.Controls.Add(this._addWAButton);
            this._addWorkAttendance.Controls.Add(this._addWAEndOTDTP);
            this._addWorkAttendance.Controls.Add(this._addWAEndOverTimeLB);
            this._addWorkAttendance.Controls.Add(this._addWAStartOTDTP);
            this._addWorkAttendance.Controls.Add(this._addWAStartOverTimeLB);
            this._addWorkAttendance.Controls.Add(this._addWAIsOvertimeCB);
            this._addWorkAttendance.Controls.Add(this._addWAIsOvertime);
            this._addWorkAttendance.Controls.Add(this._addWAEndWTDTP);
            this._addWorkAttendance.Controls.Add(this._addWAEndWTLB);
            this._addWorkAttendance.Controls.Add(this._addWAStartWTDTP);
            this._addWorkAttendance.Controls.Add(this._addWAStartWTLB);
            this._addWorkAttendance.Controls.Add(this._addWAWorkStatusCB);
            this._addWorkAttendance.Controls.Add(this._addWAStatusLB);
            this._addWorkAttendance.Controls.Add(this._addWADateDTP);
            this._addWorkAttendance.Controls.Add(this._addWADate);
            this._addWorkAttendance.Controls.Add(this._addWAEmplIDTB);
            this._addWorkAttendance.Controls.Add(this._addWAEmplIDLB);
            this._addWorkAttendance.Location = new System.Drawing.Point(4, 26);
            this._addWorkAttendance.Margin = new System.Windows.Forms.Padding(2);
            this._addWorkAttendance.Name = "_addWorkAttendance";
            this._addWorkAttendance.Padding = new System.Windows.Forms.Padding(2);
            this._addWorkAttendance.Size = new System.Drawing.Size(1024, 545);
            this._addWorkAttendance.TabIndex = 0;
            this._addWorkAttendance.Text = "Add";
            this._addWorkAttendance.UseVisualStyleBackColor = true;
            // 
            // _addWAButton
            // 
            this._addWAButton.Location = new System.Drawing.Point(645, 399);
            this._addWAButton.Margin = new System.Windows.Forms.Padding(2);
            this._addWAButton.Name = "_addWAButton";
            this._addWAButton.Size = new System.Drawing.Size(65, 27);
            this._addWAButton.TabIndex = 16;
            this._addWAButton.Text = "Add";
            this._addWAButton.UseVisualStyleBackColor = true;
            this._addWAButton.Click += new System.EventHandler(this.ClickAddWAButton);
            // 
            // _addWAEndOTDTP
            // 
            this._addWAEndOTDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._addWAEndOTDTP.Location = new System.Drawing.Point(547, 159);
            this._addWAEndOTDTP.Margin = new System.Windows.Forms.Padding(2);
            this._addWAEndOTDTP.Name = "_addWAEndOTDTP";
            this._addWAEndOTDTP.Size = new System.Drawing.Size(165, 27);
            this._addWAEndOTDTP.TabIndex = 15;
            // 
            // _addWAEndOverTimeLB
            // 
            this._addWAEndOverTimeLB.AutoSize = true;
            this._addWAEndOverTimeLB.Location = new System.Drawing.Point(434, 167);
            this._addWAEndOverTimeLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addWAEndOverTimeLB.Name = "_addWAEndOverTimeLB";
            this._addWAEndOverTimeLB.Size = new System.Drawing.Size(99, 16);
            this._addWAEndOverTimeLB.TabIndex = 14;
            this._addWAEndOverTimeLB.Text = "End Overtime:";
            // 
            // _addWAStartOTDTP
            // 
            this._addWAStartOTDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._addWAStartOTDTP.Location = new System.Drawing.Point(551, 95);
            this._addWAStartOTDTP.Margin = new System.Windows.Forms.Padding(2);
            this._addWAStartOTDTP.Name = "_addWAStartOTDTP";
            this._addWAStartOTDTP.Size = new System.Drawing.Size(160, 27);
            this._addWAStartOTDTP.TabIndex = 13;
            // 
            // _addWAStartOverTimeLB
            // 
            this._addWAStartOverTimeLB.AutoSize = true;
            this._addWAStartOverTimeLB.Location = new System.Drawing.Point(434, 103);
            this._addWAStartOverTimeLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addWAStartOverTimeLB.Name = "_addWAStartOverTimeLB";
            this._addWAStartOverTimeLB.Size = new System.Drawing.Size(102, 16);
            this._addWAStartOverTimeLB.TabIndex = 12;
            this._addWAStartOverTimeLB.Text = "Start Overtime:";
            // 
            // _addWAIsOvertimeCB
            // 
            this._addWAIsOvertimeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._addWAIsOvertimeCB.FormattingEnabled = true;
            this._addWAIsOvertimeCB.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this._addWAIsOvertimeCB.Location = new System.Drawing.Point(521, 32);
            this._addWAIsOvertimeCB.Margin = new System.Windows.Forms.Padding(2);
            this._addWAIsOvertimeCB.Name = "_addWAIsOvertimeCB";
            this._addWAIsOvertimeCB.Size = new System.Drawing.Size(106, 24);
            this._addWAIsOvertimeCB.TabIndex = 11;
            this._addWAIsOvertimeCB.SelectedIndexChanged += new System.EventHandler(this.ChangeWAIsOvertimeSelectedIndex);
            // 
            // _addWAIsOvertime
            // 
            this._addWAIsOvertime.AutoSize = true;
            this._addWAIsOvertime.Location = new System.Drawing.Point(435, 35);
            this._addWAIsOvertime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addWAIsOvertime.Name = "_addWAIsOvertime";
            this._addWAIsOvertime.Size = new System.Drawing.Size(85, 16);
            this._addWAIsOvertime.TabIndex = 10;
            this._addWAIsOvertime.Text = "Is Overtime:";
            // 
            // _addWAEndWTDTP
            // 
            this._addWAEndWTDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._addWAEndWTDTP.Location = new System.Drawing.Point(147, 289);
            this._addWAEndWTDTP.Margin = new System.Windows.Forms.Padding(2);
            this._addWAEndWTDTP.Name = "_addWAEndWTDTP";
            this._addWAEndWTDTP.Size = new System.Drawing.Size(165, 27);
            this._addWAEndWTDTP.TabIndex = 9;
            // 
            // _addWAEndWTLB
            // 
            this._addWAEndWTLB.AutoSize = true;
            this._addWAEndWTLB.Location = new System.Drawing.Point(35, 297);
            this._addWAEndWTLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addWAEndWTLB.Name = "_addWAEndWTLB";
            this._addWAEndWTLB.Size = new System.Drawing.Size(112, 16);
            this._addWAEndWTLB.TabIndex = 8;
            this._addWAEndWTLB.Text = "End Work Time:";
            // 
            // _addWAStartWTDTP
            // 
            this._addWAStartWTDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._addWAStartWTDTP.Location = new System.Drawing.Point(152, 225);
            this._addWAStartWTDTP.Margin = new System.Windows.Forms.Padding(2);
            this._addWAStartWTDTP.Name = "_addWAStartWTDTP";
            this._addWAStartWTDTP.Size = new System.Drawing.Size(160, 27);
            this._addWAStartWTDTP.TabIndex = 7;
            // 
            // _addWAStartWTLB
            // 
            this._addWAStartWTLB.AutoSize = true;
            this._addWAStartWTLB.Location = new System.Drawing.Point(35, 233);
            this._addWAStartWTLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addWAStartWTLB.Name = "_addWAStartWTLB";
            this._addWAStartWTLB.Size = new System.Drawing.Size(115, 16);
            this._addWAStartWTLB.TabIndex = 6;
            this._addWAStartWTLB.Text = "Start Work Time:";
            // 
            // _addWAWorkStatusCB
            // 
            this._addWAWorkStatusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._addWAWorkStatusCB.FormattingEnabled = true;
            this._addWAWorkStatusCB.Items.AddRange(new object[] {
            "正常上下班",
            "遲到",
            "早退",
            "無故未到",
            "病假",
            "婚假",
            "產假",
            "休假"});
            this._addWAWorkStatusCB.Location = new System.Drawing.Point(125, 163);
            this._addWAWorkStatusCB.Margin = new System.Windows.Forms.Padding(2);
            this._addWAWorkStatusCB.Name = "_addWAWorkStatusCB";
            this._addWAWorkStatusCB.Size = new System.Drawing.Size(187, 24);
            this._addWAWorkStatusCB.TabIndex = 5;
            this._addWAWorkStatusCB.SelectedIndexChanged += new System.EventHandler(this.ChangeWAStatusSelectedIndex);
            // 
            // _addWAStatusLB
            // 
            this._addWAStatusLB.AutoSize = true;
            this._addWAStatusLB.Location = new System.Drawing.Point(35, 168);
            this._addWAStatusLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addWAStatusLB.Name = "_addWAStatusLB";
            this._addWAStatusLB.Size = new System.Drawing.Size(88, 16);
            this._addWAStatusLB.TabIndex = 4;
            this._addWAStatusLB.Text = "Work Status:";
            // 
            // _addWADateDTP
            // 
            this._addWADateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._addWADateDTP.Location = new System.Drawing.Point(80, 97);
            this._addWADateDTP.Margin = new System.Windows.Forms.Padding(2);
            this._addWADateDTP.Name = "_addWADateDTP";
            this._addWADateDTP.Size = new System.Drawing.Size(232, 27);
            this._addWADateDTP.TabIndex = 3;
            this._addWADateDTP.Value = new System.DateTime(2016, 6, 10, 0, 0, 0, 0);
            // 
            // _addWADate
            // 
            this._addWADate.AutoSize = true;
            this._addWADate.Location = new System.Drawing.Point(35, 103);
            this._addWADate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addWADate.Name = "_addWADate";
            this._addWADate.Size = new System.Drawing.Size(41, 16);
            this._addWADate.TabIndex = 2;
            this._addWADate.Text = "Date:";
            // 
            // _addWAEmplIDTB
            // 
            this._addWAEmplIDTB.Location = new System.Drawing.Point(131, 33);
            this._addWAEmplIDTB.Margin = new System.Windows.Forms.Padding(2);
            this._addWAEmplIDTB.Name = "_addWAEmplIDTB";
            this._addWAEmplIDTB.Size = new System.Drawing.Size(181, 27);
            this._addWAEmplIDTB.TabIndex = 1;
            // 
            // _addWAEmplIDLB
            // 
            this._addWAEmplIDLB.AutoSize = true;
            this._addWAEmplIDLB.Location = new System.Drawing.Point(35, 37);
            this._addWAEmplIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addWAEmplIDLB.Name = "_addWAEmplIDLB";
            this._addWAEmplIDLB.Size = new System.Drawing.Size(95, 16);
            this._addWAEmplIDLB.TabIndex = 0;
            this._addWAEmplIDLB.Text = "Employee ID:";
            // 
            // _editWorkAttendance
            // 
            this._editWorkAttendance.Controls.Add(this._editWAButton);
            this._editWorkAttendance.Controls.Add(this._searchWAButton);
            this._editWorkAttendance.Controls.Add(this._editWAEndOTDTP);
            this._editWorkAttendance.Controls.Add(this._editWAEndOTLB);
            this._editWorkAttendance.Controls.Add(this._editWAStartOTDTP);
            this._editWorkAttendance.Controls.Add(this._editWAStartOTLB);
            this._editWorkAttendance.Controls.Add(this._editWAIsOvertimeCB);
            this._editWorkAttendance.Controls.Add(this._editWAIsOvertimeLB);
            this._editWorkAttendance.Controls.Add(this._editWAEndWTDTP);
            this._editWorkAttendance.Controls.Add(this._editWAEndWTLB);
            this._editWorkAttendance.Controls.Add(this._editWAStartWTDTP);
            this._editWorkAttendance.Controls.Add(this._editWAStartWTLB);
            this._editWorkAttendance.Controls.Add(this._editWAStatusCB);
            this._editWorkAttendance.Controls.Add(this._editWAWorkStatusLB);
            this._editWorkAttendance.Controls.Add(this._editWADateDTP);
            this._editWorkAttendance.Controls.Add(this._editWADateLB);
            this._editWorkAttendance.Controls.Add(this._editWAEmplIDTB);
            this._editWorkAttendance.Controls.Add(this._editWAEmplIDLB);
            this._editWorkAttendance.Location = new System.Drawing.Point(4, 26);
            this._editWorkAttendance.Margin = new System.Windows.Forms.Padding(2);
            this._editWorkAttendance.Name = "_editWorkAttendance";
            this._editWorkAttendance.Padding = new System.Windows.Forms.Padding(2);
            this._editWorkAttendance.Size = new System.Drawing.Size(1024, 545);
            this._editWorkAttendance.TabIndex = 1;
            this._editWorkAttendance.Text = "Edit";
            this._editWorkAttendance.UseVisualStyleBackColor = true;
            // 
            // _editWAButton
            // 
            this._editWAButton.Enabled = false;
            this._editWAButton.Location = new System.Drawing.Point(699, 393);
            this._editWAButton.Name = "_editWAButton";
            this._editWAButton.Size = new System.Drawing.Size(97, 41);
            this._editWAButton.TabIndex = 34;
            this._editWAButton.Text = "Edit";
            this._editWAButton.UseVisualStyleBackColor = true;
            this._editWAButton.Click += new System.EventHandler(this.ClickEditWAButton);
            // 
            // _searchWAButton
            // 
            this._searchWAButton.Location = new System.Drawing.Point(567, 393);
            this._searchWAButton.Name = "_searchWAButton";
            this._searchWAButton.Size = new System.Drawing.Size(97, 41);
            this._searchWAButton.TabIndex = 33;
            this._searchWAButton.Text = "Search";
            this._searchWAButton.UseVisualStyleBackColor = true;
            this._searchWAButton.Click += new System.EventHandler(this.ClickSearchWAButton);
            // 
            // _editWAEndOTDTP
            // 
            this._editWAEndOTDTP.Enabled = false;
            this._editWAEndOTDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._editWAEndOTDTP.Location = new System.Drawing.Point(552, 135);
            this._editWAEndOTDTP.Name = "_editWAEndOTDTP";
            this._editWAEndOTDTP.Size = new System.Drawing.Size(245, 27);
            this._editWAEndOTDTP.TabIndex = 32;
            // 
            // _editWAEndOTLB
            // 
            this._editWAEndOTLB.AutoSize = true;
            this._editWAEndOTLB.Location = new System.Drawing.Point(454, 143);
            this._editWAEndOTLB.Name = "_editWAEndOTLB";
            this._editWAEndOTLB.Size = new System.Drawing.Size(99, 16);
            this._editWAEndOTLB.TabIndex = 31;
            this._editWAEndOTLB.Text = "End Overtime:";
            // 
            // _editWAStartOTDTP
            // 
            this._editWAStartOTDTP.Enabled = false;
            this._editWAStartOTDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._editWAStartOTDTP.Location = new System.Drawing.Point(559, 77);
            this._editWAStartOTDTP.Name = "_editWAStartOTDTP";
            this._editWAStartOTDTP.Size = new System.Drawing.Size(238, 27);
            this._editWAStartOTDTP.TabIndex = 30;
            // 
            // _editWAStartOTLB
            // 
            this._editWAStartOTLB.AutoSize = true;
            this._editWAStartOTLB.Location = new System.Drawing.Point(454, 85);
            this._editWAStartOTLB.Name = "_editWAStartOTLB";
            this._editWAStartOTLB.Size = new System.Drawing.Size(102, 16);
            this._editWAStartOTLB.TabIndex = 29;
            this._editWAStartOTLB.Text = "Start Overtime:";
            // 
            // _editWAIsOvertimeCB
            // 
            this._editWAIsOvertimeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editWAIsOvertimeCB.Enabled = false;
            this._editWAIsOvertimeCB.FormattingEnabled = true;
            this._editWAIsOvertimeCB.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this._editWAIsOvertimeCB.Location = new System.Drawing.Point(542, 25);
            this._editWAIsOvertimeCB.Name = "_editWAIsOvertimeCB";
            this._editWAIsOvertimeCB.Size = new System.Drawing.Size(157, 24);
            this._editWAIsOvertimeCB.TabIndex = 28;
            this._editWAIsOvertimeCB.SelectedIndexChanged += new System.EventHandler(this.ChangeEditWAIsOvertimeSelectedIndex);
            // 
            // _editWAIsOvertimeLB
            // 
            this._editWAIsOvertimeLB.AutoSize = true;
            this._editWAIsOvertimeLB.Location = new System.Drawing.Point(454, 30);
            this._editWAIsOvertimeLB.Name = "_editWAIsOvertimeLB";
            this._editWAIsOvertimeLB.Size = new System.Drawing.Size(85, 16);
            this._editWAIsOvertimeLB.TabIndex = 27;
            this._editWAIsOvertimeLB.Text = "Is Overtime:";
            // 
            // _editWAEndWTDTP
            // 
            this._editWAEndWTDTP.Enabled = false;
            this._editWAEndWTDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._editWAEndWTDTP.Location = new System.Drawing.Point(144, 260);
            this._editWAEndWTDTP.Name = "_editWAEndWTDTP";
            this._editWAEndWTDTP.Size = new System.Drawing.Size(245, 27);
            this._editWAEndWTDTP.TabIndex = 26;
            // 
            // _editWAEndWTLB
            // 
            this._editWAEndWTLB.AutoSize = true;
            this._editWAEndWTLB.Location = new System.Drawing.Point(33, 268);
            this._editWAEndWTLB.Name = "_editWAEndWTLB";
            this._editWAEndWTLB.Size = new System.Drawing.Size(112, 16);
            this._editWAEndWTLB.TabIndex = 25;
            this._editWAEndWTLB.Text = "End Work Time:";
            // 
            // _editWAStartWTDTP
            // 
            this._editWAStartWTDTP.Enabled = false;
            this._editWAStartWTDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._editWAStartWTDTP.Location = new System.Drawing.Point(151, 197);
            this._editWAStartWTDTP.Name = "_editWAStartWTDTP";
            this._editWAStartWTDTP.Size = new System.Drawing.Size(238, 27);
            this._editWAStartWTDTP.TabIndex = 24;
            // 
            // _editWAStartWTLB
            // 
            this._editWAStartWTLB.AutoSize = true;
            this._editWAStartWTLB.Location = new System.Drawing.Point(33, 205);
            this._editWAStartWTLB.Name = "_editWAStartWTLB";
            this._editWAStartWTLB.Size = new System.Drawing.Size(115, 16);
            this._editWAStartWTLB.TabIndex = 23;
            this._editWAStartWTLB.Text = "Start Work Time:";
            // 
            // _editWAStatusCB
            // 
            this._editWAStatusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editWAStatusCB.Enabled = false;
            this._editWAStatusCB.FormattingEnabled = true;
            this._editWAStatusCB.Items.AddRange(new object[] {
            "正常上下班",
            "遲到",
            "早退",
            "無故未到",
            "病假",
            "婚假",
            "產假",
            "休假"});
            this._editWAStatusCB.Location = new System.Drawing.Point(123, 146);
            this._editWAStatusCB.Name = "_editWAStatusCB";
            this._editWAStatusCB.Size = new System.Drawing.Size(219, 24);
            this._editWAStatusCB.TabIndex = 22;
            this._editWAStatusCB.SelectedIndexChanged += new System.EventHandler(this.ChangeEditWAStatusSelectedIndex);
            // 
            // _editWAWorkStatusLB
            // 
            this._editWAWorkStatusLB.AutoSize = true;
            this._editWAWorkStatusLB.Location = new System.Drawing.Point(33, 148);
            this._editWAWorkStatusLB.Name = "_editWAWorkStatusLB";
            this._editWAWorkStatusLB.Size = new System.Drawing.Size(88, 16);
            this._editWAWorkStatusLB.TabIndex = 21;
            this._editWAWorkStatusLB.Text = "Work Status:";
            // 
            // _editWADateDTP
            // 
            this._editWADateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._editWADateDTP.Location = new System.Drawing.Point(77, 85);
            this._editWADateDTP.Name = "_editWADateDTP";
            this._editWADateDTP.Size = new System.Drawing.Size(266, 27);
            this._editWADateDTP.TabIndex = 20;
            this._editWADateDTP.Value = new System.DateTime(2016, 6, 10, 0, 0, 0, 0);
            // 
            // _editWADateLB
            // 
            this._editWADateLB.AutoSize = true;
            this._editWADateLB.Location = new System.Drawing.Point(33, 91);
            this._editWADateLB.Name = "_editWADateLB";
            this._editWADateLB.Size = new System.Drawing.Size(41, 16);
            this._editWADateLB.TabIndex = 19;
            this._editWADateLB.Text = "Date:";
            // 
            // _editWAEmplIDTB
            // 
            this._editWAEmplIDTB.Location = new System.Drawing.Point(129, 28);
            this._editWAEmplIDTB.Name = "_editWAEmplIDTB";
            this._editWAEmplIDTB.Size = new System.Drawing.Size(213, 27);
            this._editWAEmplIDTB.TabIndex = 18;
            // 
            // _editWAEmplIDLB
            // 
            this._editWAEmplIDLB.AutoSize = true;
            this._editWAEmplIDLB.Location = new System.Drawing.Point(33, 36);
            this._editWAEmplIDLB.Name = "_editWAEmplIDLB";
            this._editWAEmplIDLB.Size = new System.Drawing.Size(95, 16);
            this._editWAEmplIDLB.TabIndex = 17;
            this._editWAEmplIDLB.Text = "Employee ID:";
            // 
            // _employee
            // 
            this._employee.Controls.Add(this._employeePage);
            this._employee.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._employee.Location = new System.Drawing.Point(4, 26);
            this._employee.Margin = new System.Windows.Forms.Padding(2);
            this._employee.Name = "_employee";
            this._employee.Padding = new System.Windows.Forms.Padding(2);
            this._employee.Size = new System.Drawing.Size(1053, 577);
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
            this._newEmployee.Controls.Add(this._addEmplLoginPWTB);
            this._newEmployee.Controls.Add(this._addEmplLoginPWLB);
            this._newEmployee.Controls.Add(this._newEmplPositionCB);
            this._newEmployee.Controls.Add(this._newEmplSexCB);
            this._newEmployee.Controls.Add(this._insertEmplButton);
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
            // _addEmplLoginPWTB
            // 
            this._addEmplLoginPWTB.Location = new System.Drawing.Point(562, 385);
            this._addEmplLoginPWTB.Margin = new System.Windows.Forms.Padding(2);
            this._addEmplLoginPWTB.Name = "_addEmplLoginPWTB";
            this._addEmplLoginPWTB.Size = new System.Drawing.Size(215, 27);
            this._addEmplLoginPWTB.TabIndex = 41;
            // 
            // _addEmplLoginPWLB
            // 
            this._addEmplLoginPWLB.AutoSize = true;
            this._addEmplLoginPWLB.Location = new System.Drawing.Point(449, 389);
            this._addEmplLoginPWLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addEmplLoginPWLB.Name = "_addEmplLoginPWLB";
            this._addEmplLoginPWLB.Size = new System.Drawing.Size(112, 16);
            this._addEmplLoginPWLB.TabIndex = 40;
            this._addEmplLoginPWLB.Text = "Login Password:";
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
            this._newEmplPositionCB.SelectedIndexChanged += new System.EventHandler(this.ChangedNewEmplPositionCBSelectedIndex);
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
            // _insertEmplButton
            // 
            this._insertEmplButton.Location = new System.Drawing.Point(813, 479);
            this._insertEmplButton.Margin = new System.Windows.Forms.Padding(2);
            this._insertEmplButton.Name = "_insertEmplButton";
            this._insertEmplButton.Size = new System.Drawing.Size(75, 35);
            this._insertEmplButton.TabIndex = 37;
            this._insertEmplButton.Text = "Add";
            this._insertEmplButton.UseVisualStyleBackColor = true;
            this._insertEmplButton.Click += new System.EventHandler(this.ClickAddEmplButton);
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
            this._editEmployee.Controls.Add(this._searchEmplButtom);
            this._editEmployee.Controls.Add(this._editEmplPositionCB);
            this._editEmployee.Controls.Add(this._editEmplSexCB);
            this._editEmployee.Controls.Add(this._editEmplButton);
            this._editEmployee.Controls.Add(this._editEmplBloodCB);
            this._editEmployee.Controls.Add(this._editEmplBloodLB);
            this._editEmployee.Controls.Add(this._editEmplDeptCB);
            this._editEmployee.Controls.Add(this._editEmplBasicSalaryTB);
            this._editEmployee.Controls.Add(this._editEmplJobStatCB);
            this._editEmployee.Controls.Add(this._editEmplSpouseTB);
            this._editEmployee.Controls.Add(this._editEmplMarriedStatCB);
            this._editEmployee.Controls.Add(this._editEmplMilitaryStatCB);
            this._editEmployee.Controls.Add(this._editEmplEmerPhoneTB);
            this._editEmployee.Controls.Add(this._editEmplEmerPersonTB);
            this._editEmployee.Controls.Add(this._editEmplAddrTB);
            this._editEmployee.Controls.Add(this._editEmplPhoneTB);
            this._editEmployee.Controls.Add(this._editEmplSsnTB);
            this._editEmployee.Controls.Add(this._editEmplBirthDTP);
            this._editEmployee.Controls.Add(this._editEmplNameTB);
            this._editEmployee.Controls.Add(this._editEmplIDTB);
            this._editEmployee.Controls.Add(this._editEmplPositionLB);
            this._editEmployee.Controls.Add(this._editEmplDeptLB);
            this._editEmployee.Controls.Add(this._editEmplBasicSalaryLB);
            this._editEmployee.Controls.Add(this._editEmplBirthLB);
            this._editEmployee.Controls.Add(this._editEmplSpouseLB);
            this._editEmployee.Controls.Add(this._editMarriedStatLB);
            this._editEmployee.Controls.Add(this._editEmplJobStatLB);
            this._editEmployee.Controls.Add(this._editEmplMilitaryStatLB);
            this._editEmployee.Controls.Add(this._editEmplEmerPhone);
            this._editEmployee.Controls.Add(this._editEmplEmerPersonLB);
            this._editEmployee.Controls.Add(this._editEmplAddrLB);
            this._editEmployee.Controls.Add(this._editEmplPhoneLB);
            this._editEmployee.Controls.Add(this._editEmplSexLB);
            this._editEmployee.Controls.Add(this._editEmplSsnLB);
            this._editEmployee.Controls.Add(this._editEmplNameLB);
            this._editEmployee.Controls.Add(this.editEmplIDLB);
            this._editEmployee.Location = new System.Drawing.Point(4, 26);
            this._editEmployee.Margin = new System.Windows.Forms.Padding(2);
            this._editEmployee.Name = "_editEmployee";
            this._editEmployee.Padding = new System.Windows.Forms.Padding(2);
            this._editEmployee.Size = new System.Drawing.Size(1022, 543);
            this._editEmployee.TabIndex = 1;
            this._editEmployee.Text = "Edit";
            this._editEmployee.UseVisualStyleBackColor = true;
            // 
            // _searchEmplButtom
            // 
            this._searchEmplButtom.Location = new System.Drawing.Point(719, 484);
            this._searchEmplButtom.Margin = new System.Windows.Forms.Padding(2);
            this._searchEmplButtom.Name = "_searchEmplButtom";
            this._searchEmplButtom.Size = new System.Drawing.Size(75, 35);
            this._searchEmplButtom.TabIndex = 75;
            this._searchEmplButtom.Text = "Search";
            this._searchEmplButtom.UseVisualStyleBackColor = true;
            this._searchEmplButtom.Click += new System.EventHandler(this.ClickSearchEmplButtom);
            // 
            // _editEmplPositionCB
            // 
            this._editEmplPositionCB.DataSource = this.positionBindingSource;
            this._editEmplPositionCB.DisplayMember = "positionName";
            this._editEmplPositionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editEmplPositionCB.Enabled = false;
            this._editEmplPositionCB.FormattingEnabled = true;
            this._editEmplPositionCB.Location = new System.Drawing.Point(100, 421);
            this._editEmplPositionCB.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplPositionCB.Name = "_editEmplPositionCB";
            this._editEmplPositionCB.Size = new System.Drawing.Size(207, 24);
            this._editEmplPositionCB.TabIndex = 74;
            this._editEmplPositionCB.ValueMember = "positionID";
            this._editEmplPositionCB.SelectedIndexChanged += new System.EventHandler(this.ChangedEditEmplPositionCBSelectedIndex);
            // 
            // _editEmplSexCB
            // 
            this._editEmplSexCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editEmplSexCB.Enabled = false;
            this._editEmplSexCB.FormattingEnabled = true;
            this._editEmplSexCB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this._editEmplSexCB.Location = new System.Drawing.Point(487, 72);
            this._editEmplSexCB.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplSexCB.Name = "_editEmplSexCB";
            this._editEmplSexCB.Size = new System.Drawing.Size(82, 24);
            this._editEmplSexCB.TabIndex = 73;
            // 
            // _editEmplButton
            // 
            this._editEmplButton.Enabled = false;
            this._editEmplButton.Location = new System.Drawing.Point(816, 484);
            this._editEmplButton.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplButton.Name = "_editEmplButton";
            this._editEmplButton.Size = new System.Drawing.Size(75, 35);
            this._editEmplButton.TabIndex = 72;
            this._editEmplButton.Text = "Edit";
            this._editEmplButton.UseVisualStyleBackColor = true;
            this._editEmplButton.Click += new System.EventHandler(this.ClickEditEmplButtom);
            // 
            // _editEmplBloodCB
            // 
            this._editEmplBloodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editEmplBloodCB.Enabled = false;
            this._editEmplBloodCB.FormattingEnabled = true;
            this._editEmplBloodCB.Items.AddRange(new object[] {
            "A",
            "B",
            "O",
            "AB"});
            this._editEmplBloodCB.Location = new System.Drawing.Point(637, 72);
            this._editEmplBloodCB.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplBloodCB.Name = "_editEmplBloodCB";
            this._editEmplBloodCB.Size = new System.Drawing.Size(77, 24);
            this._editEmplBloodCB.TabIndex = 71;
            // 
            // _editEmplBloodLB
            // 
            this._editEmplBloodLB.AutoSize = true;
            this._editEmplBloodLB.Location = new System.Drawing.Point(585, 77);
            this._editEmplBloodLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editEmplBloodLB.Name = "_editEmplBloodLB";
            this._editEmplBloodLB.Size = new System.Drawing.Size(50, 16);
            this._editEmplBloodLB.TabIndex = 70;
            this._editEmplBloodLB.Text = "Blood:";
            // 
            // _editEmplDeptCB
            // 
            this._editEmplDeptCB.DataSource = this.departmentBindingSource;
            this._editEmplDeptCB.DisplayMember = "departmentName";
            this._editEmplDeptCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editEmplDeptCB.Enabled = false;
            this._editEmplDeptCB.FormattingEnabled = true;
            this._editEmplDeptCB.Location = new System.Drawing.Point(124, 377);
            this._editEmplDeptCB.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplDeptCB.Name = "_editEmplDeptCB";
            this._editEmplDeptCB.Size = new System.Drawing.Size(207, 24);
            this._editEmplDeptCB.TabIndex = 69;
            this._editEmplDeptCB.ValueMember = "departmentID";
            // 
            // _editEmplBasicSalaryTB
            // 
            this._editEmplBasicSalaryTB.Location = new System.Drawing.Point(125, 468);
            this._editEmplBasicSalaryTB.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplBasicSalaryTB.Name = "_editEmplBasicSalaryTB";
            this._editEmplBasicSalaryTB.ReadOnly = true;
            this._editEmplBasicSalaryTB.Size = new System.Drawing.Size(201, 27);
            this._editEmplBasicSalaryTB.TabIndex = 68;
            this._editEmplBasicSalaryTB.Text = "0";
            // 
            // _editEmplJobStatCB
            // 
            this._editEmplJobStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editEmplJobStatCB.Enabled = false;
            this._editEmplJobStatCB.FormattingEnabled = true;
            this._editEmplJobStatCB.Items.AddRange(new object[] {
            "在職",
            "離職"});
            this._editEmplJobStatCB.Location = new System.Drawing.Point(112, 329);
            this._editEmplJobStatCB.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplJobStatCB.Name = "_editEmplJobStatCB";
            this._editEmplJobStatCB.Size = new System.Drawing.Size(215, 24);
            this._editEmplJobStatCB.TabIndex = 67;
            // 
            // _editEmplSpouseTB
            // 
            this._editEmplSpouseTB.Location = new System.Drawing.Point(508, 323);
            this._editEmplSpouseTB.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplSpouseTB.Name = "_editEmplSpouseTB";
            this._editEmplSpouseTB.ReadOnly = true;
            this._editEmplSpouseTB.Size = new System.Drawing.Size(150, 27);
            this._editEmplSpouseTB.TabIndex = 66;
            // 
            // _editEmplMarriedStatCB
            // 
            this._editEmplMarriedStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editEmplMarriedStatCB.Enabled = false;
            this._editEmplMarriedStatCB.FormattingEnabled = true;
            this._editEmplMarriedStatCB.Items.AddRange(new object[] {
            "未婚",
            "已婚"});
            this._editEmplMarriedStatCB.Location = new System.Drawing.Point(555, 279);
            this._editEmplMarriedStatCB.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplMarriedStatCB.Name = "_editEmplMarriedStatCB";
            this._editEmplMarriedStatCB.Size = new System.Drawing.Size(103, 24);
            this._editEmplMarriedStatCB.TabIndex = 65;
            this._editEmplMarriedStatCB.SelectedIndexChanged += new System.EventHandler(this.ChangedEditEmplMarriedStatCBSelectedIndex);
            // 
            // _editEmplMilitaryStatCB
            // 
            this._editEmplMilitaryStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editEmplMilitaryStatCB.Enabled = false;
            this._editEmplMilitaryStatCB.FormattingEnabled = true;
            this._editEmplMilitaryStatCB.Items.AddRange(new object[] {
            "役畢",
            "屆退",
            "待役",
            "未役",
            "免役"});
            this._editEmplMilitaryStatCB.Location = new System.Drawing.Point(555, 219);
            this._editEmplMilitaryStatCB.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplMilitaryStatCB.Name = "_editEmplMilitaryStatCB";
            this._editEmplMilitaryStatCB.Size = new System.Drawing.Size(103, 24);
            this._editEmplMilitaryStatCB.TabIndex = 64;
            // 
            // _editEmplEmerPhoneTB
            // 
            this._editEmplEmerPhoneTB.Location = new System.Drawing.Point(160, 275);
            this._editEmplEmerPhoneTB.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplEmerPhoneTB.Name = "_editEmplEmerPhoneTB";
            this._editEmplEmerPhoneTB.ReadOnly = true;
            this._editEmplEmerPhoneTB.Size = new System.Drawing.Size(167, 27);
            this._editEmplEmerPhoneTB.TabIndex = 63;
            // 
            // _editEmplEmerPersonTB
            // 
            this._editEmplEmerPersonTB.Location = new System.Drawing.Point(163, 223);
            this._editEmplEmerPersonTB.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplEmerPersonTB.Name = "_editEmplEmerPersonTB";
            this._editEmplEmerPersonTB.ReadOnly = true;
            this._editEmplEmerPersonTB.Size = new System.Drawing.Size(164, 27);
            this._editEmplEmerPersonTB.TabIndex = 62;
            // 
            // _editEmplAddrTB
            // 
            this._editEmplAddrTB.Location = new System.Drawing.Point(100, 172);
            this._editEmplAddrTB.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplAddrTB.Name = "_editEmplAddrTB";
            this._editEmplAddrTB.ReadOnly = true;
            this._editEmplAddrTB.Size = new System.Drawing.Size(680, 27);
            this._editEmplAddrTB.TabIndex = 61;
            // 
            // _editEmplPhoneTB
            // 
            this._editEmplPhoneTB.Location = new System.Drawing.Point(555, 127);
            this._editEmplPhoneTB.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplPhoneTB.Name = "_editEmplPhoneTB";
            this._editEmplPhoneTB.ReadOnly = true;
            this._editEmplPhoneTB.Size = new System.Drawing.Size(225, 27);
            this._editEmplPhoneTB.TabIndex = 60;
            // 
            // _editEmplSsnTB
            // 
            this._editEmplSsnTB.Location = new System.Drawing.Point(72, 123);
            this._editEmplSsnTB.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplSsnTB.Name = "_editEmplSsnTB";
            this._editEmplSsnTB.ReadOnly = true;
            this._editEmplSsnTB.Size = new System.Drawing.Size(256, 27);
            this._editEmplSsnTB.TabIndex = 59;
            // 
            // _editEmplBirthDTP
            // 
            this._editEmplBirthDTP.Enabled = false;
            this._editEmplBirthDTP.Location = new System.Drawing.Point(524, 24);
            this._editEmplBirthDTP.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplBirthDTP.Name = "_editEmplBirthDTP";
            this._editEmplBirthDTP.Size = new System.Drawing.Size(135, 27);
            this._editEmplBirthDTP.TabIndex = 58;
            // 
            // _editEmplNameTB
            // 
            this._editEmplNameTB.Location = new System.Drawing.Point(85, 75);
            this._editEmplNameTB.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplNameTB.Name = "_editEmplNameTB";
            this._editEmplNameTB.ReadOnly = true;
            this._editEmplNameTB.Size = new System.Drawing.Size(241, 27);
            this._editEmplNameTB.TabIndex = 57;
            // 
            // _editEmplIDTB
            // 
            this._editEmplIDTB.Location = new System.Drawing.Point(129, 24);
            this._editEmplIDTB.Margin = new System.Windows.Forms.Padding(2);
            this._editEmplIDTB.Name = "_editEmplIDTB";
            this._editEmplIDTB.Size = new System.Drawing.Size(197, 27);
            this._editEmplIDTB.TabIndex = 56;
            // 
            // _editEmplPositionLB
            // 
            this._editEmplPositionLB.AutoSize = true;
            this._editEmplPositionLB.Location = new System.Drawing.Point(35, 424);
            this._editEmplPositionLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editEmplPositionLB.Name = "_editEmplPositionLB";
            this._editEmplPositionLB.Size = new System.Drawing.Size(62, 16);
            this._editEmplPositionLB.TabIndex = 55;
            this._editEmplPositionLB.Text = "Position:";
            // 
            // _editEmplDeptLB
            // 
            this._editEmplDeptLB.AutoSize = true;
            this._editEmplDeptLB.Location = new System.Drawing.Point(35, 380);
            this._editEmplDeptLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editEmplDeptLB.Name = "_editEmplDeptLB";
            this._editEmplDeptLB.Size = new System.Drawing.Size(85, 16);
            this._editEmplDeptLB.TabIndex = 54;
            this._editEmplDeptLB.Text = "Department:";
            // 
            // _editEmplBasicSalaryLB
            // 
            this._editEmplBasicSalaryLB.AutoSize = true;
            this._editEmplBasicSalaryLB.Location = new System.Drawing.Point(35, 472);
            this._editEmplBasicSalaryLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editEmplBasicSalaryLB.Name = "_editEmplBasicSalaryLB";
            this._editEmplBasicSalaryLB.Size = new System.Drawing.Size(89, 16);
            this._editEmplBasicSalaryLB.TabIndex = 53;
            this._editEmplBasicSalaryLB.Text = "Basic Salary:";
            // 
            // _editEmplBirthLB
            // 
            this._editEmplBirthLB.AutoSize = true;
            this._editEmplBirthLB.Location = new System.Drawing.Point(449, 32);
            this._editEmplBirthLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editEmplBirthLB.Name = "_editEmplBirthLB";
            this._editEmplBirthLB.Size = new System.Drawing.Size(73, 16);
            this._editEmplBirthLB.TabIndex = 52;
            this._editEmplBirthLB.Text = "Birth Day:";
            // 
            // _editEmplSpouseLB
            // 
            this._editEmplSpouseLB.AutoSize = true;
            this._editEmplSpouseLB.Location = new System.Drawing.Point(449, 331);
            this._editEmplSpouseLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editEmplSpouseLB.Name = "_editEmplSpouseLB";
            this._editEmplSpouseLB.Size = new System.Drawing.Size(57, 16);
            this._editEmplSpouseLB.TabIndex = 51;
            this._editEmplSpouseLB.Text = "Spouse:";
            // 
            // _editMarriedStatLB
            // 
            this._editMarriedStatLB.AutoSize = true;
            this._editMarriedStatLB.Location = new System.Drawing.Point(449, 283);
            this._editMarriedStatLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editMarriedStatLB.Name = "_editMarriedStatLB";
            this._editMarriedStatLB.Size = new System.Drawing.Size(102, 16);
            this._editMarriedStatLB.TabIndex = 50;
            this._editMarriedStatLB.Text = "Married Status:";
            // 
            // _editEmplJobStatLB
            // 
            this._editEmplJobStatLB.AutoSize = true;
            this._editEmplJobStatLB.Location = new System.Drawing.Point(35, 331);
            this._editEmplJobStatLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editEmplJobStatLB.Name = "_editEmplJobStatLB";
            this._editEmplJobStatLB.Size = new System.Drawing.Size(75, 16);
            this._editEmplJobStatLB.TabIndex = 49;
            this._editEmplJobStatLB.Text = "Job Status:";
            // 
            // _editEmplMilitaryStatLB
            // 
            this._editEmplMilitaryStatLB.AutoSize = true;
            this._editEmplMilitaryStatLB.Location = new System.Drawing.Point(449, 224);
            this._editEmplMilitaryStatLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editEmplMilitaryStatLB.Name = "_editEmplMilitaryStatLB";
            this._editEmplMilitaryStatLB.Size = new System.Drawing.Size(102, 16);
            this._editEmplMilitaryStatLB.TabIndex = 48;
            this._editEmplMilitaryStatLB.Text = "Military Status:";
            // 
            // _editEmplEmerPhone
            // 
            this._editEmplEmerPhone.AutoSize = true;
            this._editEmplEmerPhone.Location = new System.Drawing.Point(35, 283);
            this._editEmplEmerPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editEmplEmerPhone.Name = "_editEmplEmerPhone";
            this._editEmplEmerPhone.Size = new System.Drawing.Size(126, 16);
            this._editEmplEmerPhone.TabIndex = 47;
            this._editEmplEmerPhone.Text = "Emergency Phone:";
            // 
            // _editEmplEmerPersonLB
            // 
            this._editEmplEmerPersonLB.AutoSize = true;
            this._editEmplEmerPersonLB.Location = new System.Drawing.Point(35, 231);
            this._editEmplEmerPersonLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editEmplEmerPersonLB.Name = "_editEmplEmerPersonLB";
            this._editEmplEmerPersonLB.Size = new System.Drawing.Size(129, 16);
            this._editEmplEmerPersonLB.TabIndex = 46;
            this._editEmplEmerPersonLB.Text = "Emergency Person:";
            // 
            // _editEmplAddrLB
            // 
            this._editEmplAddrLB.AutoSize = true;
            this._editEmplAddrLB.Location = new System.Drawing.Point(35, 180);
            this._editEmplAddrLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editEmplAddrLB.Name = "_editEmplAddrLB";
            this._editEmplAddrLB.Size = new System.Drawing.Size(63, 16);
            this._editEmplAddrLB.TabIndex = 45;
            this._editEmplAddrLB.Text = "Address:";
            // 
            // _editEmplPhoneLB
            // 
            this._editEmplPhoneLB.AutoSize = true;
            this._editEmplPhoneLB.Location = new System.Drawing.Point(449, 131);
            this._editEmplPhoneLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editEmplPhoneLB.Name = "_editEmplPhoneLB";
            this._editEmplPhoneLB.Size = new System.Drawing.Size(106, 16);
            this._editEmplPhoneLB.TabIndex = 44;
            this._editEmplPhoneLB.Text = "Phone Number:";
            // 
            // _editEmplSexLB
            // 
            this._editEmplSexLB.AutoSize = true;
            this._editEmplSexLB.Location = new System.Drawing.Point(449, 77);
            this._editEmplSexLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editEmplSexLB.Name = "_editEmplSexLB";
            this._editEmplSexLB.Size = new System.Drawing.Size(35, 16);
            this._editEmplSexLB.TabIndex = 43;
            this._editEmplSexLB.Text = "Sex:";
            // 
            // _editEmplSsnLB
            // 
            this._editEmplSsnLB.AutoSize = true;
            this._editEmplSsnLB.Location = new System.Drawing.Point(35, 135);
            this._editEmplSsnLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editEmplSsnLB.Name = "_editEmplSsnLB";
            this._editEmplSsnLB.Size = new System.Drawing.Size(34, 16);
            this._editEmplSsnLB.TabIndex = 42;
            this._editEmplSsnLB.Text = "Ssn:";
            // 
            // _editEmplNameLB
            // 
            this._editEmplNameLB.AutoSize = true;
            this._editEmplNameLB.Location = new System.Drawing.Point(35, 83);
            this._editEmplNameLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._editEmplNameLB.Name = "_editEmplNameLB";
            this._editEmplNameLB.Size = new System.Drawing.Size(49, 16);
            this._editEmplNameLB.TabIndex = 41;
            this._editEmplNameLB.Text = "Name:";
            // 
            // editEmplIDLB
            // 
            this.editEmplIDLB.AutoSize = true;
            this.editEmplIDLB.Location = new System.Drawing.Point(35, 32);
            this.editEmplIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editEmplIDLB.Name = "editEmplIDLB";
            this.editEmplIDLB.Size = new System.Drawing.Size(95, 16);
            this.editEmplIDLB.TabIndex = 40;
            this.editEmplIDLB.Text = "Employee ID:";
            // 
            // _mainFunctionPage
            // 
            this._mainFunctionPage.Controls.Add(this._employee);
            this._mainFunctionPage.Controls.Add(this._workAttendance);
            this._mainFunctionPage.Controls.Add(this._bonus);
            this._mainFunctionPage.Controls.Add(this._salary);
            this._mainFunctionPage.Controls.Add(this._authorization);
            this._mainFunctionPage.Controls.Add(this._position);
            this._mainFunctionPage.Controls.Add(this._department);
            this._mainFunctionPage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._mainFunctionPage.Location = new System.Drawing.Point(8, 8);
            this._mainFunctionPage.Margin = new System.Windows.Forms.Padding(2);
            this._mainFunctionPage.Name = "_mainFunctionPage";
            this._mainFunctionPage.SelectedIndex = 0;
            this._mainFunctionPage.Size = new System.Drawing.Size(1061, 607);
            this._mainFunctionPage.TabIndex = 0;
            // 
            // _mainFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 635);
            this.Controls.Add(this._logoutButton);
            this.Controls.Add(this._mainFunctionPage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "_mainFunction";
            this.Text = "MainFunction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseMainFunction);
            this.Load += new System.EventHandler(this.LoadMainFunction);
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusdefBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusDefDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authoDataSet)).EndInit();
            this._department.ResumeLayout(false);
            this._departmentPage.ResumeLayout(false);
            this._newDepartment.ResumeLayout(false);
            this._newDepartment.PerformLayout();
            this._editDepartment.ResumeLayout(false);
            this._editDepartment.PerformLayout();
            this._position.ResumeLayout(false);
            this._positionPage.ResumeLayout(false);
            this._addPosition.ResumeLayout(false);
            this._addPosition.PerformLayout();
            this._editPosition.ResumeLayout(false);
            this._editPosition.PerformLayout();
            this._authorization.ResumeLayout(false);
            this._authorizationPage.ResumeLayout(false);
            this._newAuthorization.ResumeLayout(false);
            this._newAuthorization.PerformLayout();
            this._editAuthorization.ResumeLayout(false);
            this._editAuthorization.PerformLayout();
            this._salary.ResumeLayout(false);
            this._salaryPage.ResumeLayout(false);
            this._addpayMethod.ResumeLayout(false);
            this._addpayMethod.PerformLayout();
            this._editPayMethod.ResumeLayout(false);
            this._editPayMethod.PerformLayout();
            this._bonus.ResumeLayout(false);
            this._bonusPage.ResumeLayout(false);
            this._addBonusDef.ResumeLayout(false);
            this._addBonusDef.PerformLayout();
            this._editBonusDef.ResumeLayout(false);
            this._editBonusDef.PerformLayout();
            this._addBonusTLB.ResumeLayout(false);
            this._addBonusTLB.PerformLayout();
            this._emplBonusSearch.ResumeLayout(false);
            this._emplBonusSearch.PerformLayout();
            this._bonusEmplIDSearchToolStrip.ResumeLayout(false);
            this._bonusEmplIDSearchToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bonusDataGridView)).EndInit();
            this._workAttendance.ResumeLayout(false);
            this._workAttendancePage.ResumeLayout(false);
            this._addWorkAttendance.ResumeLayout(false);
            this._addWorkAttendance.PerformLayout();
            this._editWorkAttendance.ResumeLayout(false);
            this._editWorkAttendance.PerformLayout();
            this._employee.ResumeLayout(false);
            this._employeePage.ResumeLayout(false);
            this._newEmployee.ResumeLayout(false);
            this._newEmployee.PerformLayout();
            this._editEmployee.ResumeLayout(false);
            this._editEmployee.PerformLayout();
            this._mainFunctionPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _logoutButton;
        private deptDataSet deptDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private deptDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private positionDataSet positionDataSet;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private positionDataSetTableAdapters.positionTableAdapter positionTableAdapter;
        private authoDataSet authoDataSet;
        private System.Windows.Forms.BindingSource authorizationBindingSource;
        private authoDataSetTableAdapters.authorizationTableAdapter authorizationTableAdapter;
        private bonusDefDataSet bonusDefDataSet;
        private System.Windows.Forms.BindingSource bonusdefBindingSource;
        private bonusDefDataSetTableAdapters.bonusdefTableAdapter bonusdefTableAdapter;
        private bonusDataSet bonusDataSet;
        private System.Windows.Forms.BindingSource bonusBindingSource;
        private bonusDataSetTableAdapters.bonusTableAdapter bonusTableAdapter;
        private System.Windows.Forms.TabPage _department;
        private System.Windows.Forms.TabControl _departmentPage;
        private System.Windows.Forms.TabPage _newDepartment;
        private System.Windows.Forms.Button _insertDeptButton;
        private System.Windows.Forms.DateTimePicker _newDeptTimeDP;
        private System.Windows.Forms.TextBox _newDeptManTB;
        private System.Windows.Forms.TextBox _newDeptNameTB;
        private System.Windows.Forms.TextBox _newDeptIDTB;
        private System.Windows.Forms.Label _newDeptManLB;
        private System.Windows.Forms.Label _newDeptStartTimeLB;
        private System.Windows.Forms.Label _newDeptNameLB;
        private System.Windows.Forms.Label _newDeptIDLB;
        private System.Windows.Forms.TabPage _editDepartment;
        private System.Windows.Forms.DateTimePicker _editDeptEndTimeDefDP;
        private System.Windows.Forms.Button _editDeptButton;
        private System.Windows.Forms.Button _searchDeptButton;
        private System.Windows.Forms.ComboBox _editDeptCheckCB;
        private System.Windows.Forms.DateTimePicker _editDeptEndTimeDP;
        private System.Windows.Forms.DateTimePicker _editDeptStartTimeDP;
        private System.Windows.Forms.TextBox _editDeptManTB;
        private System.Windows.Forms.TextBox _editDeptNameTB;
        private System.Windows.Forms.TextBox _editDeptIDTB;
        private System.Windows.Forms.Label _editDeptManLB;
        private System.Windows.Forms.Label _editDeptEndTimeLB;
        private System.Windows.Forms.Label _editDeptCheckLB;
        private System.Windows.Forms.Label _editDeptStartTimeLB;
        private System.Windows.Forms.Label _editDeptNameLB;
        private System.Windows.Forms.Label _editDeptIDLB;
        private System.Windows.Forms.TabPage _position;
        private System.Windows.Forms.TabControl _positionPage;
        private System.Windows.Forms.TabPage _addPosition;
        private System.Windows.Forms.Button _addPositionButton;
        private System.Windows.Forms.TextBox _addPositionIDTB;
        private System.Windows.Forms.TextBox _addPositionNameTB;
        private System.Windows.Forms.TextBox _addPositionBSTB;
        private System.Windows.Forms.ComboBox _addPositionAuthoCB;
        private System.Windows.Forms.Label _addPositionAuthoLB;
        private System.Windows.Forms.Label _addPositionBSLB;
        private System.Windows.Forms.Label _addPositionNameLB;
        private System.Windows.Forms.Label _addPositionIDLB;
        private System.Windows.Forms.TabPage _editPosition;
        private System.Windows.Forms.Button _editPositionButton;
        private System.Windows.Forms.Button _searchPositionButton;
        private System.Windows.Forms.TextBox _editPositionIDTB;
        private System.Windows.Forms.TextBox _editPositionNameTB;
        private System.Windows.Forms.TextBox _editPositionBSTB;
        private System.Windows.Forms.ComboBox _editPositionAuthoCB;
        private System.Windows.Forms.Label _editPositionAuthoLB;
        private System.Windows.Forms.Label _editPositionBSLB;
        private System.Windows.Forms.Label _editPositionNameLB;
        private System.Windows.Forms.Label _editPositionIDLB;
        private System.Windows.Forms.TabPage _authorization;
        private System.Windows.Forms.TabControl _authorizationPage;
        private System.Windows.Forms.TabPage _newAuthorization;
        private System.Windows.Forms.Button _insertAuthoButton;
        private System.Windows.Forms.ComboBox _newAuthoLevelCB;
        private System.Windows.Forms.TextBox _newAuthoNameTB;
        private System.Windows.Forms.TextBox _newAuthoIDTB;
        private System.Windows.Forms.Label _newAuthoLevelLB;
        private System.Windows.Forms.Label _newAuthoNameLB;
        private System.Windows.Forms.Label _newAuthoIDLB;
        private System.Windows.Forms.TabPage _editAuthorization;
        private System.Windows.Forms.Button _editAuthoButton;
        private System.Windows.Forms.Button _searchAuthoButton;
        private System.Windows.Forms.ComboBox _editAuthoLevelCB;
        private System.Windows.Forms.TextBox _editAuthoNameTB;
        private System.Windows.Forms.TextBox _editAuthoIDTB;
        private System.Windows.Forms.Label _editAuthoLevelLB;
        private System.Windows.Forms.Label _editAuthoNameLB;
        private System.Windows.Forms.Label _editAuthoIDLB;
        private System.Windows.Forms.TabPage _salary;
        private System.Windows.Forms.TabPage _bonus;
        private System.Windows.Forms.TabControl _bonusPage;
        private System.Windows.Forms.TabPage _addBonusDef;
        private System.Windows.Forms.Button _addBonusDefButton;
        private System.Windows.Forms.TextBox _addBonusDefAmountTB;
        private System.Windows.Forms.Label _addBonusDefAmountLB;
        private System.Windows.Forms.DateTimePicker _addBonusDefEffiDateDTP;
        private System.Windows.Forms.Label _addBonusDefEffiDateLB;
        private System.Windows.Forms.DateTimePicker _addBonusDefCreateDateDTP;
        private System.Windows.Forms.Label _addBonusDefCreateDateLB;
        private System.Windows.Forms.TextBox _addBonusDefDescTB;
        private System.Windows.Forms.Label _addBonusDefDescLB;
        private System.Windows.Forms.TextBox _addBonusNameTB;
        private System.Windows.Forms.Label _addBonusDefNameLB;
        private System.Windows.Forms.TextBox _addBonusDefIDTB;
        private System.Windows.Forms.Label _addBonusDefIDLB;
        private System.Windows.Forms.TabPage _editBonusDef;
        private System.Windows.Forms.Button _editBonusDefButton;
        private System.Windows.Forms.Button _searchBonusDefButton;
        private System.Windows.Forms.TextBox _editBonusDefAmountTB;
        private System.Windows.Forms.Label _editBonusDefAmountLB;
        private System.Windows.Forms.DateTimePicker _editBonusDefEffiDateDTP;
        private System.Windows.Forms.Label _editBonusDefEffiDateLB;
        private System.Windows.Forms.DateTimePicker _editBonusDefCreateDateDTP;
        private System.Windows.Forms.Label _editBonusDefCreateDateLB;
        private System.Windows.Forms.TextBox _editBonusDefDescTB;
        private System.Windows.Forms.Label _editBonusDefDescLB;
        private System.Windows.Forms.TextBox _editBonusDefNameTB;
        private System.Windows.Forms.Label _editBonusDefNameLB;
        private System.Windows.Forms.TextBox _editBonusDefIDTB;
        private System.Windows.Forms.Label _editBonusDefIDLB;
        private System.Windows.Forms.TabPage _addBonusTLB;
        private System.Windows.Forms.TextBox _addbonusPeriodTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _addBonusButton;
        private System.Windows.Forms.DateTimePicker _addBonusDateDTP;
        private System.Windows.Forms.Label _addBonusDateLB;
        private System.Windows.Forms.TextBox _addBonusEmplIDTB;
        private System.Windows.Forms.Label _addBonusEmplID;
        private System.Windows.Forms.ComboBox _addBonusCB;
        private System.Windows.Forms.Label _addBonusNameLB;
        private System.Windows.Forms.TabPage _emplBonusSearch;
        private System.Windows.Forms.ToolStrip _bonusEmplIDSearchToolStrip;
        private System.Windows.Forms.ToolStripLabel _emplIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox emplIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton _fillToolStripButton;
        private System.Windows.Forms.DataGridView _bonusDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusDefIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusTDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage _workAttendance;
        private System.Windows.Forms.TabControl _workAttendancePage;
        private System.Windows.Forms.TabPage _addWorkAttendance;
        private System.Windows.Forms.Button _addWAButton;
        private System.Windows.Forms.DateTimePicker _addWAEndOTDTP;
        private System.Windows.Forms.Label _addWAEndOverTimeLB;
        private System.Windows.Forms.DateTimePicker _addWAStartOTDTP;
        private System.Windows.Forms.Label _addWAStartOverTimeLB;
        private System.Windows.Forms.ComboBox _addWAIsOvertimeCB;
        private System.Windows.Forms.Label _addWAIsOvertime;
        private System.Windows.Forms.DateTimePicker _addWAEndWTDTP;
        private System.Windows.Forms.Label _addWAEndWTLB;
        private System.Windows.Forms.DateTimePicker _addWAStartWTDTP;
        private System.Windows.Forms.Label _addWAStartWTLB;
        private System.Windows.Forms.ComboBox _addWAWorkStatusCB;
        private System.Windows.Forms.Label _addWAStatusLB;
        private System.Windows.Forms.DateTimePicker _addWADateDTP;
        private System.Windows.Forms.Label _addWADate;
        private System.Windows.Forms.TextBox _addWAEmplIDTB;
        private System.Windows.Forms.Label _addWAEmplIDLB;
        private System.Windows.Forms.TabPage _editWorkAttendance;
        private System.Windows.Forms.Button _editWAButton;
        private System.Windows.Forms.Button _searchWAButton;
        private System.Windows.Forms.DateTimePicker _editWAEndOTDTP;
        private System.Windows.Forms.Label _editWAEndOTLB;
        private System.Windows.Forms.DateTimePicker _editWAStartOTDTP;
        private System.Windows.Forms.Label _editWAStartOTLB;
        private System.Windows.Forms.ComboBox _editWAIsOvertimeCB;
        private System.Windows.Forms.Label _editWAIsOvertimeLB;
        private System.Windows.Forms.DateTimePicker _editWAEndWTDTP;
        private System.Windows.Forms.Label _editWAEndWTLB;
        private System.Windows.Forms.DateTimePicker _editWAStartWTDTP;
        private System.Windows.Forms.Label _editWAStartWTLB;
        private System.Windows.Forms.ComboBox _editWAStatusCB;
        private System.Windows.Forms.Label _editWAWorkStatusLB;
        private System.Windows.Forms.DateTimePicker _editWADateDTP;
        private System.Windows.Forms.Label _editWADateLB;
        private System.Windows.Forms.TextBox _editWAEmplIDTB;
        private System.Windows.Forms.Label _editWAEmplIDLB;
        private System.Windows.Forms.TabPage _employee;
        private System.Windows.Forms.TabControl _employeePage;
        private System.Windows.Forms.TabPage _newEmployee;
        private System.Windows.Forms.TextBox _addEmplLoginPWTB;
        private System.Windows.Forms.Label _addEmplLoginPWLB;
        private System.Windows.Forms.ComboBox _newEmplPositionCB;
        private System.Windows.Forms.ComboBox _newEmplSexCB;
        private System.Windows.Forms.Button _insertEmplButton;
        private System.Windows.Forms.ComboBox _newEmplBloodCB;
        private System.Windows.Forms.Label _newEmplBloodLB;
        private System.Windows.Forms.ComboBox _newEmplDeptCB;
        private System.Windows.Forms.TextBox _newEmplBasicSalaryTB;
        private System.Windows.Forms.ComboBox _newEmplJobStatCB;
        private System.Windows.Forms.TextBox _newEmplSpouseTB;
        private System.Windows.Forms.ComboBox _newEmplMarriedStatCB;
        private System.Windows.Forms.ComboBox _newEmplMilitaryStatCB;
        private System.Windows.Forms.TextBox _newEmplEmerPhoneTB;
        private System.Windows.Forms.TextBox _newEmplEmerPersonTB;
        private System.Windows.Forms.TextBox _newEmplAddrTB;
        private System.Windows.Forms.TextBox _newEmplPhoneTB;
        private System.Windows.Forms.TextBox _newEmpllSsnTB;
        private System.Windows.Forms.DateTimePicker _newEmplBirthDP;
        private System.Windows.Forms.TextBox _newEmplNameTB;
        private System.Windows.Forms.TextBox _newEmplIDTB;
        private System.Windows.Forms.Label _newEmplPositionIDLB;
        private System.Windows.Forms.Label _newEmplDeptIDLB;
        private System.Windows.Forms.Label _newEmplBasicSalaryLB;
        private System.Windows.Forms.Label _newEmplBirthLB;
        private System.Windows.Forms.Label _newEmplSpouseLB;
        private System.Windows.Forms.Label _newEmplMarriedStatLB;
        private System.Windows.Forms.Label _newEmplJobStatLB;
        private System.Windows.Forms.Label _newEmplMilitaryLB;
        private System.Windows.Forms.Label _newEmplEmerPhoneLB;
        private System.Windows.Forms.Label _newEmplEmerPersonLB;
        private System.Windows.Forms.Label _newEmplAddrLB;
        private System.Windows.Forms.Label _newEmplPhoneLB;
        private System.Windows.Forms.Label _newEmplSexLB;
        private System.Windows.Forms.Label _newEmplSsnLB;
        private System.Windows.Forms.Label _newEmplNameLB;
        private System.Windows.Forms.Label _newEmplIDLB;
        private System.Windows.Forms.TabPage _editEmployee;
        private System.Windows.Forms.Button _searchEmplButtom;
        private System.Windows.Forms.ComboBox _editEmplPositionCB;
        private System.Windows.Forms.ComboBox _editEmplSexCB;
        private System.Windows.Forms.Button _editEmplButton;
        private System.Windows.Forms.ComboBox _editEmplBloodCB;
        private System.Windows.Forms.Label _editEmplBloodLB;
        private System.Windows.Forms.ComboBox _editEmplDeptCB;
        private System.Windows.Forms.TextBox _editEmplBasicSalaryTB;
        private System.Windows.Forms.ComboBox _editEmplJobStatCB;
        private System.Windows.Forms.TextBox _editEmplSpouseTB;
        private System.Windows.Forms.ComboBox _editEmplMarriedStatCB;
        private System.Windows.Forms.ComboBox _editEmplMilitaryStatCB;
        private System.Windows.Forms.TextBox _editEmplEmerPhoneTB;
        private System.Windows.Forms.TextBox _editEmplEmerPersonTB;
        private System.Windows.Forms.TextBox _editEmplAddrTB;
        private System.Windows.Forms.TextBox _editEmplPhoneTB;
        private System.Windows.Forms.TextBox _editEmplSsnTB;
        private System.Windows.Forms.DateTimePicker _editEmplBirthDTP;
        private System.Windows.Forms.TextBox _editEmplNameTB;
        private System.Windows.Forms.TextBox _editEmplIDTB;
        private System.Windows.Forms.Label _editEmplPositionLB;
        private System.Windows.Forms.Label _editEmplDeptLB;
        private System.Windows.Forms.Label _editEmplBasicSalaryLB;
        private System.Windows.Forms.Label _editEmplBirthLB;
        private System.Windows.Forms.Label _editEmplSpouseLB;
        private System.Windows.Forms.Label _editMarriedStatLB;
        private System.Windows.Forms.Label _editEmplJobStatLB;
        private System.Windows.Forms.Label _editEmplMilitaryStatLB;
        private System.Windows.Forms.Label _editEmplEmerPhone;
        private System.Windows.Forms.Label _editEmplEmerPersonLB;
        private System.Windows.Forms.Label _editEmplAddrLB;
        private System.Windows.Forms.Label _editEmplPhoneLB;
        private System.Windows.Forms.Label _editEmplSexLB;
        private System.Windows.Forms.Label _editEmplSsnLB;
        private System.Windows.Forms.Label _editEmplNameLB;
        private System.Windows.Forms.Label editEmplIDLB;
        private System.Windows.Forms.TabPage _addpayMethod;
        private System.Windows.Forms.TabPage _editPayMethod;
        private System.Windows.Forms.Button _addPaywayButton;
        private System.Windows.Forms.ComboBox _addPaywayMethodCB;
        private System.Windows.Forms.TextBox _addPaywayAccountTB;
        private System.Windows.Forms.TextBox _addPaywayEmplIDTB;
        private System.Windows.Forms.Label _addpaywayAccountLB;
        private System.Windows.Forms.Label _addPaywayMethodLB;
        private System.Windows.Forms.Label _addPaywayEmplIDLB;
        private System.Windows.Forms.Button _paywayEditButton;
        private System.Windows.Forms.Button _paywaySearchButton;
        private System.Windows.Forms.ComboBox _editPaywayMethodCB;
        private System.Windows.Forms.TextBox _editPaywayAccountTB;
        private System.Windows.Forms.TextBox _editPaywayEmplIDTB;
        private System.Windows.Forms.Label _editPaywayAccountLB;
        private System.Windows.Forms.Label _editPaywayMethodLB;
        private System.Windows.Forms.Label _editPaywayEmplIDLB;
        private System.Windows.Forms.TabControl _mainFunctionPage;
        private System.Windows.Forms.TabControl _salaryPage;
    }
}