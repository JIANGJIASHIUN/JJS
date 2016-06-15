namespace OOAD_HR_System
{
    partial class EmployeeData
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
            this._logoutButton = new System.Windows.Forms.Button();
            this._addEmplLoginPWTB = new System.Windows.Forms.TextBox();
            this._addEmplLoginPWLB = new System.Windows.Forms.Label();
            this._newEmplBloodLB = new System.Windows.Forms.Label();
            this._newEmplBasicSalaryTB = new System.Windows.Forms.TextBox();
            this._newEmplSpouseTB = new System.Windows.Forms.TextBox();
            this._newEmplPhoneTB = new System.Windows.Forms.TextBox();
            this._newEmplBirthDP = new System.Windows.Forms.DateTimePicker();
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
            this._newEmplJobStatCB = new System.Windows.Forms.ComboBox();
            this._newEmplDeptCB = new System.Windows.Forms.ComboBox();
            this._newEmplPositionCB = new System.Windows.Forms.ComboBox();
            this._newEmplSexCB = new System.Windows.Forms.ComboBox();
            this._newEmplBloodCB = new System.Windows.Forms.ComboBox();
            this._newEmplMilitaryStatCB = new System.Windows.Forms.ComboBox();
            this._newEmplMarriedStatCB = new System.Windows.Forms.ComboBox();
            this.emplDeptDataDataSet = new OOAD_HR_System.emplDeptDataDataSet();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new OOAD_HR_System.emplDeptDataDataSetTableAdapters.departmentTableAdapter();
            this.emplPositionDataDataSet = new OOAD_HR_System.emplPositionDataDataSet();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionTableAdapter = new OOAD_HR_System.emplPositionDataDataSetTableAdapters.positionTableAdapter();
            this._newEmplIDTB = new System.Windows.Forms.TextBox();
            this._newEmplNameTB = new System.Windows.Forms.TextBox();
            this._newEmpllSsnTB = new System.Windows.Forms.TextBox();
            this._newEmplAddrTB = new System.Windows.Forms.TextBox();
            this._newEmplEmerPersonTB = new System.Windows.Forms.TextBox();
            this._newEmplEmerPhoneTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.emplDeptDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplPositionDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _logoutButton
            // 
            this._logoutButton.Location = new System.Drawing.Point(1113, 26);
            this._logoutButton.Name = "_logoutButton";
            this._logoutButton.Size = new System.Drawing.Size(93, 41);
            this._logoutButton.TabIndex = 0;
            this._logoutButton.Text = "Logout";
            this._logoutButton.UseVisualStyleBackColor = true;
            this._logoutButton.Click += new System.EventHandler(this.ClickLogoutButton);
            // 
            // _addEmplLoginPWTB
            // 
            this._addEmplLoginPWTB.Location = new System.Drawing.Point(851, 627);
            this._addEmplLoginPWTB.Name = "_addEmplLoginPWTB";
            this._addEmplLoginPWTB.ReadOnly = true;
            this._addEmplLoginPWTB.Size = new System.Drawing.Size(321, 29);
            this._addEmplLoginPWTB.TabIndex = 77;
            // 
            // _addEmplLoginPWLB
            // 
            this._addEmplLoginPWLB.AutoSize = true;
            this._addEmplLoginPWLB.Location = new System.Drawing.Point(682, 633);
            this._addEmplLoginPWLB.Name = "_addEmplLoginPWLB";
            this._addEmplLoginPWLB.Size = new System.Drawing.Size(122, 18);
            this._addEmplLoginPWLB.TabIndex = 76;
            this._addEmplLoginPWLB.Text = "Login Password:";
            // 
            // _newEmplBloodLB
            // 
            this._newEmplBloodLB.AutoSize = true;
            this._newEmplBloodLB.Location = new System.Drawing.Point(882, 157);
            this._newEmplBloodLB.Name = "_newEmplBloodLB";
            this._newEmplBloodLB.Size = new System.Drawing.Size(53, 18);
            this._newEmplBloodLB.TabIndex = 72;
            this._newEmplBloodLB.Text = "Blood:";
            // 
            // _newEmplBasicSalaryTB
            // 
            this._newEmplBasicSalaryTB.Location = new System.Drawing.Point(192, 743);
            this._newEmplBasicSalaryTB.Name = "_newEmplBasicSalaryTB";
            this._newEmplBasicSalaryTB.ReadOnly = true;
            this._newEmplBasicSalaryTB.Size = new System.Drawing.Size(300, 29);
            this._newEmplBasicSalaryTB.TabIndex = 70;
            this._newEmplBasicSalaryTB.Text = "0";
            // 
            // _newEmplSpouseTB
            // 
            this._newEmplSpouseTB.Location = new System.Drawing.Point(766, 526);
            this._newEmplSpouseTB.Name = "_newEmplSpouseTB";
            this._newEmplSpouseTB.ReadOnly = true;
            this._newEmplSpouseTB.Size = new System.Drawing.Size(223, 29);
            this._newEmplSpouseTB.TabIndex = 68;
            // 
            // _newEmplPhoneTB
            // 
            this._newEmplPhoneTB.Location = new System.Drawing.Point(836, 231);
            this._newEmplPhoneTB.Name = "_newEmplPhoneTB";
            this._newEmplPhoneTB.ReadOnly = true;
            this._newEmplPhoneTB.Size = new System.Drawing.Size(336, 29);
            this._newEmplPhoneTB.TabIndex = 62;
            // 
            // _newEmplBirthDP
            // 
            this._newEmplBirthDP.Enabled = false;
            this._newEmplBirthDP.Location = new System.Drawing.Point(790, 77);
            this._newEmplBirthDP.Name = "_newEmplBirthDP";
            this._newEmplBirthDP.Size = new System.Drawing.Size(200, 29);
            this._newEmplBirthDP.TabIndex = 60;
            // 
            // _newEmplPositionIDLB
            // 
            this._newEmplPositionIDLB.AutoSize = true;
            this._newEmplPositionIDLB.Location = new System.Drawing.Point(56, 677);
            this._newEmplPositionIDLB.Name = "_newEmplPositionIDLB";
            this._newEmplPositionIDLB.Size = new System.Drawing.Size(68, 18);
            this._newEmplPositionIDLB.TabIndex = 57;
            this._newEmplPositionIDLB.Text = "Position:";
            // 
            // _newEmplDeptIDLB
            // 
            this._newEmplDeptIDLB.AutoSize = true;
            this._newEmplDeptIDLB.Location = new System.Drawing.Point(56, 611);
            this._newEmplDeptIDLB.Name = "_newEmplDeptIDLB";
            this._newEmplDeptIDLB.Size = new System.Drawing.Size(94, 18);
            this._newEmplDeptIDLB.TabIndex = 56;
            this._newEmplDeptIDLB.Text = "Department:";
            // 
            // _newEmplBasicSalaryLB
            // 
            this._newEmplBasicSalaryLB.AutoSize = true;
            this._newEmplBasicSalaryLB.Location = new System.Drawing.Point(56, 749);
            this._newEmplBasicSalaryLB.Name = "_newEmplBasicSalaryLB";
            this._newEmplBasicSalaryLB.Size = new System.Drawing.Size(101, 18);
            this._newEmplBasicSalaryLB.TabIndex = 55;
            this._newEmplBasicSalaryLB.Text = "Basic Salary:";
            // 
            // _newEmplBirthLB
            // 
            this._newEmplBirthLB.AutoSize = true;
            this._newEmplBirthLB.Location = new System.Drawing.Point(678, 89);
            this._newEmplBirthLB.Name = "_newEmplBirthLB";
            this._newEmplBirthLB.Size = new System.Drawing.Size(81, 18);
            this._newEmplBirthLB.TabIndex = 54;
            this._newEmplBirthLB.Text = "Birth Day:";
            // 
            // _newEmplSpouseLB
            // 
            this._newEmplSpouseLB.AutoSize = true;
            this._newEmplSpouseLB.Location = new System.Drawing.Point(678, 538);
            this._newEmplSpouseLB.Name = "_newEmplSpouseLB";
            this._newEmplSpouseLB.Size = new System.Drawing.Size(61, 18);
            this._newEmplSpouseLB.TabIndex = 53;
            this._newEmplSpouseLB.Text = "Spouse:";
            // 
            // _newEmplMarriedStatLB
            // 
            this._newEmplMarriedStatLB.AutoSize = true;
            this._newEmplMarriedStatLB.Location = new System.Drawing.Point(678, 466);
            this._newEmplMarriedStatLB.Name = "_newEmplMarriedStatLB";
            this._newEmplMarriedStatLB.Size = new System.Drawing.Size(116, 18);
            this._newEmplMarriedStatLB.TabIndex = 52;
            this._newEmplMarriedStatLB.Text = "Married Status:";
            // 
            // _newEmplJobStatLB
            // 
            this._newEmplJobStatLB.AutoSize = true;
            this._newEmplJobStatLB.Location = new System.Drawing.Point(56, 538);
            this._newEmplJobStatLB.Name = "_newEmplJobStatLB";
            this._newEmplJobStatLB.Size = new System.Drawing.Size(83, 18);
            this._newEmplJobStatLB.TabIndex = 51;
            this._newEmplJobStatLB.Text = "Job Status:";
            // 
            // _newEmplMilitaryLB
            // 
            this._newEmplMilitaryLB.AutoSize = true;
            this._newEmplMilitaryLB.Location = new System.Drawing.Point(678, 377);
            this._newEmplMilitaryLB.Name = "_newEmplMilitaryLB";
            this._newEmplMilitaryLB.Size = new System.Drawing.Size(117, 18);
            this._newEmplMilitaryLB.TabIndex = 50;
            this._newEmplMilitaryLB.Text = "Military Status:";
            // 
            // _newEmplEmerPhoneLB
            // 
            this._newEmplEmerPhoneLB.AutoSize = true;
            this._newEmplEmerPhoneLB.Location = new System.Drawing.Point(56, 466);
            this._newEmplEmerPhoneLB.Name = "_newEmplEmerPhoneLB";
            this._newEmplEmerPhoneLB.Size = new System.Drawing.Size(136, 18);
            this._newEmplEmerPhoneLB.TabIndex = 49;
            this._newEmplEmerPhoneLB.Text = "Emergency Phone:";
            // 
            // _newEmplEmerPersonLB
            // 
            this._newEmplEmerPersonLB.AutoSize = true;
            this._newEmplEmerPersonLB.Location = new System.Drawing.Point(56, 387);
            this._newEmplEmerPersonLB.Name = "_newEmplEmerPersonLB";
            this._newEmplEmerPersonLB.Size = new System.Drawing.Size(141, 18);
            this._newEmplEmerPersonLB.TabIndex = 48;
            this._newEmplEmerPersonLB.Text = "Emergency Person:";
            // 
            // _newEmplAddrLB
            // 
            this._newEmplAddrLB.AutoSize = true;
            this._newEmplAddrLB.Location = new System.Drawing.Point(56, 311);
            this._newEmplAddrLB.Name = "_newEmplAddrLB";
            this._newEmplAddrLB.Size = new System.Drawing.Size(69, 18);
            this._newEmplAddrLB.TabIndex = 47;
            this._newEmplAddrLB.Text = "Address:";
            // 
            // _newEmplPhoneLB
            // 
            this._newEmplPhoneLB.AutoSize = true;
            this._newEmplPhoneLB.Location = new System.Drawing.Point(678, 238);
            this._newEmplPhoneLB.Name = "_newEmplPhoneLB";
            this._newEmplPhoneLB.Size = new System.Drawing.Size(114, 18);
            this._newEmplPhoneLB.TabIndex = 46;
            this._newEmplPhoneLB.Text = "Phone Number:";
            // 
            // _newEmplSexLB
            // 
            this._newEmplSexLB.AutoSize = true;
            this._newEmplSexLB.Location = new System.Drawing.Point(678, 157);
            this._newEmplSexLB.Name = "_newEmplSexLB";
            this._newEmplSexLB.Size = new System.Drawing.Size(38, 18);
            this._newEmplSexLB.TabIndex = 45;
            this._newEmplSexLB.Text = "Sex:";
            // 
            // _newEmplSsnLB
            // 
            this._newEmplSsnLB.AutoSize = true;
            this._newEmplSsnLB.Location = new System.Drawing.Point(56, 243);
            this._newEmplSsnLB.Name = "_newEmplSsnLB";
            this._newEmplSsnLB.Size = new System.Drawing.Size(37, 18);
            this._newEmplSsnLB.TabIndex = 44;
            this._newEmplSsnLB.Text = "Ssn:";
            // 
            // _newEmplNameLB
            // 
            this._newEmplNameLB.AutoSize = true;
            this._newEmplNameLB.Location = new System.Drawing.Point(56, 166);
            this._newEmplNameLB.Name = "_newEmplNameLB";
            this._newEmplNameLB.Size = new System.Drawing.Size(54, 18);
            this._newEmplNameLB.TabIndex = 43;
            this._newEmplNameLB.Text = "Name:";
            // 
            // _newEmplIDLB
            // 
            this._newEmplIDLB.AutoSize = true;
            this._newEmplIDLB.Location = new System.Drawing.Point(56, 89);
            this._newEmplIDLB.Name = "_newEmplIDLB";
            this._newEmplIDLB.Size = new System.Drawing.Size(104, 18);
            this._newEmplIDLB.TabIndex = 42;
            this._newEmplIDLB.Text = "Employee ID:";
            // 
            // _newEmplJobStatCB
            // 
            this._newEmplJobStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplJobStatCB.Enabled = false;
            this._newEmplJobStatCB.FormattingEnabled = true;
            this._newEmplJobStatCB.Items.AddRange(new object[] {
            "在職",
            "離職"});
            this._newEmplJobStatCB.Location = new System.Drawing.Point(174, 526);
            this._newEmplJobStatCB.Name = "_newEmplJobStatCB";
            this._newEmplJobStatCB.Size = new System.Drawing.Size(320, 26);
            this._newEmplJobStatCB.TabIndex = 78;
            // 
            // _newEmplDeptCB
            // 
            this._newEmplDeptCB.DataSource = this.departmentBindingSource;
            this._newEmplDeptCB.DisplayMember = "departmentName";
            this._newEmplDeptCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplDeptCB.Enabled = false;
            this._newEmplDeptCB.FormattingEnabled = true;
            this._newEmplDeptCB.Location = new System.Drawing.Point(184, 603);
            this._newEmplDeptCB.Name = "_newEmplDeptCB";
            this._newEmplDeptCB.Size = new System.Drawing.Size(308, 26);
            this._newEmplDeptCB.TabIndex = 79;
            this._newEmplDeptCB.ValueMember = "departmentID";
            // 
            // _newEmplPositionCB
            // 
            this._newEmplPositionCB.DataSource = this.positionBindingSource;
            this._newEmplPositionCB.DisplayMember = "positionName";
            this._newEmplPositionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplPositionCB.Enabled = false;
            this._newEmplPositionCB.FormattingEnabled = true;
            this._newEmplPositionCB.Location = new System.Drawing.Point(184, 669);
            this._newEmplPositionCB.Name = "_newEmplPositionCB";
            this._newEmplPositionCB.Size = new System.Drawing.Size(308, 26);
            this._newEmplPositionCB.TabIndex = 80;
            this._newEmplPositionCB.ValueMember = "positionID";
            // 
            // _newEmplSexCB
            // 
            this._newEmplSexCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplSexCB.Enabled = false;
            this._newEmplSexCB.FormattingEnabled = true;
            this._newEmplSexCB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this._newEmplSexCB.Location = new System.Drawing.Point(722, 149);
            this._newEmplSexCB.Name = "_newEmplSexCB";
            this._newEmplSexCB.Size = new System.Drawing.Size(121, 26);
            this._newEmplSexCB.TabIndex = 81;
            // 
            // _newEmplBloodCB
            // 
            this._newEmplBloodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplBloodCB.Enabled = false;
            this._newEmplBloodCB.FormattingEnabled = true;
            this._newEmplBloodCB.Items.AddRange(new object[] {
            "A",
            "B",
            "O",
            "AB"});
            this._newEmplBloodCB.Location = new System.Drawing.Point(941, 149);
            this._newEmplBloodCB.Name = "_newEmplBloodCB";
            this._newEmplBloodCB.Size = new System.Drawing.Size(114, 26);
            this._newEmplBloodCB.TabIndex = 82;
            // 
            // _newEmplMilitaryStatCB
            // 
            this._newEmplMilitaryStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplMilitaryStatCB.Enabled = false;
            this._newEmplMilitaryStatCB.FormattingEnabled = true;
            this._newEmplMilitaryStatCB.Items.AddRange(new object[] {
            "役畢",
            "屆退",
            "待役",
            "未役",
            "免役"});
            this._newEmplMilitaryStatCB.Location = new System.Drawing.Point(801, 369);
            this._newEmplMilitaryStatCB.Name = "_newEmplMilitaryStatCB";
            this._newEmplMilitaryStatCB.Size = new System.Drawing.Size(152, 26);
            this._newEmplMilitaryStatCB.TabIndex = 83;
            // 
            // _newEmplMarriedStatCB
            // 
            this._newEmplMarriedStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplMarriedStatCB.Enabled = false;
            this._newEmplMarriedStatCB.FormattingEnabled = true;
            this._newEmplMarriedStatCB.Items.AddRange(new object[] {
            "未婚",
            "已婚"});
            this._newEmplMarriedStatCB.Location = new System.Drawing.Point(801, 457);
            this._newEmplMarriedStatCB.Name = "_newEmplMarriedStatCB";
            this._newEmplMarriedStatCB.Size = new System.Drawing.Size(152, 26);
            this._newEmplMarriedStatCB.TabIndex = 84;
            // 
            // emplDeptDataDataSet
            // 
            this.emplDeptDataDataSet.DataSetName = "emplDeptDataDataSet";
            this.emplDeptDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.emplDeptDataDataSet;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // emplPositionDataDataSet
            // 
            this.emplPositionDataDataSet.DataSetName = "emplPositionDataDataSet";
            this.emplPositionDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "position";
            this.positionBindingSource.DataSource = this.emplPositionDataDataSet;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // _newEmplIDTB
            // 
            this._newEmplIDTB.Location = new System.Drawing.Point(166, 77);
            this._newEmplIDTB.Name = "_newEmplIDTB";
            this._newEmplIDTB.ReadOnly = true;
            this._newEmplIDTB.Size = new System.Drawing.Size(326, 29);
            this._newEmplIDTB.TabIndex = 85;
            // 
            // _newEmplNameTB
            // 
            this._newEmplNameTB.Location = new System.Drawing.Point(117, 154);
            this._newEmplNameTB.Name = "_newEmplNameTB";
            this._newEmplNameTB.ReadOnly = true;
            this._newEmplNameTB.Size = new System.Drawing.Size(375, 29);
            this._newEmplNameTB.TabIndex = 86;
            // 
            // _newEmpllSsnTB
            // 
            this._newEmpllSsnTB.Location = new System.Drawing.Point(117, 235);
            this._newEmpllSsnTB.Name = "_newEmpllSsnTB";
            this._newEmpllSsnTB.ReadOnly = true;
            this._newEmpllSsnTB.Size = new System.Drawing.Size(375, 29);
            this._newEmpllSsnTB.TabIndex = 87;
            // 
            // _newEmplAddrTB
            // 
            this._newEmplAddrTB.Location = new System.Drawing.Point(131, 300);
            this._newEmplAddrTB.Name = "_newEmplAddrTB";
            this._newEmplAddrTB.ReadOnly = true;
            this._newEmplAddrTB.Size = new System.Drawing.Size(1041, 29);
            this._newEmplAddrTB.TabIndex = 88;
            // 
            // _newEmplEmerPersonTB
            // 
            this._newEmplEmerPersonTB.Location = new System.Drawing.Point(244, 377);
            this._newEmplEmerPersonTB.Name = "_newEmplEmerPersonTB";
            this._newEmplEmerPersonTB.ReadOnly = true;
            this._newEmplEmerPersonTB.Size = new System.Drawing.Size(248, 29);
            this._newEmplEmerPersonTB.TabIndex = 89;
            // 
            // _newEmplEmerPhoneTB
            // 
            this._newEmplEmerPhoneTB.Location = new System.Drawing.Point(244, 454);
            this._newEmplEmerPhoneTB.Name = "_newEmplEmerPhoneTB";
            this._newEmplEmerPhoneTB.ReadOnly = true;
            this._newEmplEmerPhoneTB.Size = new System.Drawing.Size(248, 29);
            this._newEmplEmerPhoneTB.TabIndex = 90;
            // 
            // EmployeeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 849);
            this.Controls.Add(this._newEmplEmerPhoneTB);
            this.Controls.Add(this._newEmplEmerPersonTB);
            this.Controls.Add(this._newEmplAddrTB);
            this.Controls.Add(this._newEmpllSsnTB);
            this.Controls.Add(this._newEmplNameTB);
            this.Controls.Add(this._newEmplIDTB);
            this.Controls.Add(this._newEmplMarriedStatCB);
            this.Controls.Add(this._newEmplMilitaryStatCB);
            this.Controls.Add(this._newEmplBloodCB);
            this.Controls.Add(this._newEmplSexCB);
            this.Controls.Add(this._newEmplPositionCB);
            this.Controls.Add(this._newEmplDeptCB);
            this.Controls.Add(this._newEmplJobStatCB);
            this.Controls.Add(this._addEmplLoginPWTB);
            this.Controls.Add(this._addEmplLoginPWLB);
            this.Controls.Add(this._newEmplBloodLB);
            this.Controls.Add(this._newEmplBasicSalaryTB);
            this.Controls.Add(this._newEmplSpouseTB);
            this.Controls.Add(this._newEmplPhoneTB);
            this.Controls.Add(this._newEmplBirthDP);
            this.Controls.Add(this._newEmplPositionIDLB);
            this.Controls.Add(this._newEmplDeptIDLB);
            this.Controls.Add(this._newEmplBasicSalaryLB);
            this.Controls.Add(this._newEmplBirthLB);
            this.Controls.Add(this._newEmplSpouseLB);
            this.Controls.Add(this._newEmplMarriedStatLB);
            this.Controls.Add(this._newEmplJobStatLB);
            this.Controls.Add(this._newEmplMilitaryLB);
            this.Controls.Add(this._newEmplEmerPhoneLB);
            this.Controls.Add(this._newEmplEmerPersonLB);
            this.Controls.Add(this._newEmplAddrLB);
            this.Controls.Add(this._newEmplPhoneLB);
            this.Controls.Add(this._newEmplSexLB);
            this.Controls.Add(this._newEmplSsnLB);
            this.Controls.Add(this._newEmplNameLB);
            this.Controls.Add(this._newEmplIDLB);
            this.Controls.Add(this._logoutButton);
            this.Name = "EmployeeData";
            this.Text = "EmployeeData";
            this.Load += new System.EventHandler(this.EmployeeData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emplDeptDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplPositionDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _logoutButton;
        private System.Windows.Forms.TextBox _addEmplLoginPWTB;
        private System.Windows.Forms.Label _addEmplLoginPWLB;
        private System.Windows.Forms.Label _newEmplBloodLB;
        private System.Windows.Forms.TextBox _newEmplBasicSalaryTB;
        private System.Windows.Forms.TextBox _newEmplSpouseTB;
        private System.Windows.Forms.TextBox _newEmplPhoneTB;
        private System.Windows.Forms.DateTimePicker _newEmplBirthDP;
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
        private System.Windows.Forms.ComboBox _newEmplJobStatCB;
        private System.Windows.Forms.ComboBox _newEmplDeptCB;
        private System.Windows.Forms.ComboBox _newEmplPositionCB;
        private System.Windows.Forms.ComboBox _newEmplSexCB;
        private System.Windows.Forms.ComboBox _newEmplBloodCB;
        private System.Windows.Forms.ComboBox _newEmplMilitaryStatCB;
        private System.Windows.Forms.ComboBox _newEmplMarriedStatCB;
        private emplDeptDataDataSet emplDeptDataDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private emplDeptDataDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private emplPositionDataDataSet emplPositionDataDataSet;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private emplPositionDataDataSetTableAdapters.positionTableAdapter positionTableAdapter;
        private System.Windows.Forms.TextBox _newEmplIDTB;
        private System.Windows.Forms.TextBox _newEmplNameTB;
        private System.Windows.Forms.TextBox _newEmpllSsnTB;
        private System.Windows.Forms.TextBox _newEmplAddrTB;
        private System.Windows.Forms.TextBox _newEmplEmerPersonTB;
        private System.Windows.Forms.TextBox _newEmplEmerPhoneTB;
    }
}