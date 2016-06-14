using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOAD_HR_System.PresentationModel;
using OOAD_HR_System.Controller;

namespace OOAD_HR_System
{
    public partial class _mainFunction : Form
    {

        private Form _login = new Form();
        private EmployeePresentationModel _employeePresentationModel = new EmployeePresentationModel();
        private EmployeeController _employeeController;

        private AuthorizationPresentationModel _authoPresentationModel = new AuthorizationPresentationModel();
        private AuthorizationController _authoController;

        private PositionPresentationModel _positionPresentationModel = new PositionPresentationModel();
        private PositionController _positionController;

        private WorkAttendancePresentationModel _waPresentationModel = new WorkAttendancePresentationModel();
        private WorkAttendanController _waController;

        private DepartmentPresentationModel _deptPresentationModel = new DepartmentPresentationModel();
        private DepartmentController _deptController;

        private BonusDefPresentationModel _bonusDefPresentationModel = new BonusDefPresentationModel();
        private BonusDefController _bonusDefController;

        private BonusPresentationModel _bonusPresentationModel = new BonusPresentationModel();
        private BonusController _bonusController;

        public _mainFunction(Form login)
        {
            _login = login;

            InitializeComponent();
        }

        // form load
        private void LoadMainFunction(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'bonusDefDataSet.bonusdef' 資料表。您可以視需要進行移動或移除。
            this.bonusdefTableAdapter.Fill(this.bonusDefDataSet.bonusdef);
            // TODO:  這行程式碼會將資料載入 'authoDataSet.authorization' 資料表。您可以視需要進行移動或移除。
            this.authorizationTableAdapter.Fill(this.authoDataSet.authorization);
            // TODO:  這行程式碼會將資料載入 'positionDataSet.position' 資料表。您可以視需要進行移動或移除。
            this.positionTableAdapter.Fill(this.positionDataSet.position);
            // TODO:  這行程式碼會將資料載入 'deptDataSet.department' 資料表。您可以視需要進行移動或移除。
            this.departmentTableAdapter.Fill(this.deptDataSet.department);

            // 設置所有UI的預設值
            this.ResetNewEmplUI();
            this.ResetEditEmplUI();
            this.ResetNewAuthoUI();
            this.ResetEditAuthoUI();
            this.ResetNewWAUI();
            this.ResetEditWAUI();
            this.ResetAddBonusDefUI();
            this.ResetEditBonusDefUI();
        }

        // reset all edit bonus def UI
        private void ResetEditBonusDefUI()
        {
            _editBonusDefIDTB.Enabled = true;
            _editBonusDefIDTB.Text = "";
            _editBonusDefNameTB.Enabled = false;
            _editBonusDefNameTB.Text = "";
            _editBonusDefDescTB.Text = "";
            _editBonusDefDescTB.Enabled = false;
            _editBonusDefCreateDateDTP.Value = DateTime.Now;
            _editBonusDefCreateDateDTP.Enabled = false;
            _editBonusDefEffiDateDTP.Value = DateTime.Now;
            _editBonusDefEffiDateDTP.Enabled = false;
            _editBonusDefAmountTB.Text = "0";
            _editBonusDefAmountTB.Enabled = false;
            _searchBonusDefButton.Enabled = true;
            _editBonusDefButton.Enabled = false;
        }

        // reste all add bonus def UI
        private void ResetAddBonusDefUI()
        {
            _addBonusDefIDTB.Text = "";
            _addBonusNameTB.Text = "";
            _addBonusDefDescTB.Text = "";
            _addBonusDefCreateDateDTP.Value = DateTime.Now;
            _addBonusDefEffiDateDTP.Value = DateTime.Now;
            _addBonusDefAmountTB.Text = "0";
            _addBonusDefButton.Enabled = true;
        }

        // reset all add work attendance UI
        private void ResetNewWAUI()
        {
            _addWADateDTP.Value = DateTime.Now;
            _addWAStartWTDTP.Value = DateTime.Now;
            _addWAEndWTDTP.Value = DateTime.Now;
            _addWAWorkStatusCB.SelectedIndex = 0;
            _addWAIsOvertimeCB.SelectedIndex = 0;
            _addWAStartWTDTP.Enabled = true;
            _addWAEndWTDTP.Enabled = true;
            _addWAEmplIDTB.Text = "";
            _addWAStartOTDTP.Value = DateTime.Now;
            _addWAStartOTDTP.Enabled = false;
            _addWAEndOTDTP.Value = DateTime.Now;
            _addWAEndOTDTP.Enabled = false;
        }

        // reset all edit work attendance UI
        private void ResetEditWAUI()
        {
            _editWADateDTP.Value = DateTime.Now;
            _editWADateDTP.Enabled = true;
            _editWAStartWTDTP.Value = DateTime.Now;
            _editWAStartWTDTP.Enabled = false;
            _editWAEndWTDTP.Value = DateTime.Now;
            _editWAEndWTDTP.Enabled = false;
            _editWAStatusCB.SelectedIndex = 0;
            _editWAStatusCB.Enabled = false;
            _editWAIsOvertimeCB.SelectedIndex = 0;
            _editWAIsOvertimeCB.Enabled = false;
            _editWAEmplIDTB.Text = "";
            _editWAStartOTDTP.Value = DateTime.Now;
            _editWAStartOTDTP.Enabled = false;
            _editWAEndOTDTP.Value = DateTime.Now;
            _editWAEndOTDTP.Enabled = false;
            _editWAButton.Enabled = false;
            _searchWAButton.Enabled = true;
        }

        // reset all add authorization UI 預設值
        private void ResetNewAuthoUI()
        {
            _newAuthoLevelCB.SelectedIndex = 0;
        }

        // reset all edit authorization UI 預設值
        private void ResetEditAuthoUI()
        {
            _editAuthoNameTB.Text = "";
            _editAuthoNameTB.ReadOnly = true;
            _editAuthoLevelCB.Text = "";
            _editAuthoLevelCB.Enabled = false;
            _editAuthoButton.Enabled = false;
        }

        // 查詢後autho UI放入資料
        private void ResetSearchEditAuthoUI()
        {
            _editAuthoNameTB.Text = _authoPresentationModel.GetAuthoName();
            //_editAuthoLevelCB.Text = "";
            _editAuthoLevelCB.Text = _authoPresentationModel.GetAuthoValue();
            _editAuthoButton.Enabled = true;
        }

        // reset all add employee UI 預設值
        private void ResetNewEmplUI() 
        {
            _newEmplJobStatCB.SelectedIndex = 0;
            _newEmplMarriedStatCB.SelectedIndex = 0;
            _newEmplMilitaryStatCB.SelectedIndex = 0;
            _newEmplBloodCB.SelectedIndex = 0;
            _newEmplSexCB.SelectedIndex = 0;
            this.SetAllNewEmplVariableToPM();

            _employeeController = new EmployeeController(_employeePresentationModel);
            _newEmplBasicSalaryTB.Text = _employeeController.SearchBasicSalaryByPositionID();
        }

        // reset all edit employee UI
        private void ResetEditEmplUI()
        {
            _editEmplJobStatCB.SelectedIndex = 0;
            _editEmplMarriedStatCB.SelectedIndex = 0;
            _editEmplMilitaryStatCB.SelectedIndex = 0;
            _editEmplBloodCB.SelectedIndex = 0;
            _editEmplSexCB.SelectedIndex = 0;
            _editEmplDeptCB.SelectedIndex = 0;
            _editEmplPositionCB.SelectedIndex = 0;
            _editEmplBirthDTP.Value = DateTime.Now;
            this.SetAllEditEmplVariableToPM();

            _employeeController = new EmployeeController(_employeePresentationModel);
            _editEmplBasicSalaryTB.Text = _employeeController.SearchBasicSalaryByPositionID();
        }

        // reset all edit position UI
        private void ResetEditPositionUI()
        {
            _editPositionIDTB.Text = "";
            _editPositionNameTB.Text = "";
            _editPositionBSTB.Text = "";
            _editPositionAuthoCB.SelectedIndex = 0;
        }

        // 設置查詢後 all edit employee UI
        private void ResetSearchEditEmplUI()
        {
            _editEmplBirthDTP.Value = _employeePresentationModel.GetBirth();
            _editEmplMarriedStatCB.SelectedItem = _employeePresentationModel.GetMarriedStatus();
            // 1 為未婚
            // 0 為已婚
            if (_editEmplMarriedStatCB.SelectedIndex == 1)
            {
                _editEmplSpouseTB.Text = _employeePresentationModel.GetSpouse();
            }
            else if (_editEmplMarriedStatCB.SelectedIndex == 0)
            {
                _editEmplSpouseTB.ReadOnly = true;
                _editEmplSpouseTB.Text = null;
            }
            _editEmplJobStatCB.SelectedItem = _employeePresentationModel.GetJobStatus(); 
            _editEmplMilitaryStatCB.SelectedItem = _employeePresentationModel.GetMilitaryStatus();
            _editEmplBloodCB.SelectedItem = _employeePresentationModel.GetBlood();
            _editEmplSexCB.SelectedItem = _employeePresentationModel.GetSex();
            _editEmplNameTB.Text = _employeePresentationModel.GetName();
            _editEmplSsnTB.Text = _employeePresentationModel.GetSsn(); ;
            _editEmplAddrTB.Text = _employeePresentationModel.GetAddress();
            _editEmplEmerPersonTB.Text = _employeePresentationModel.GetEmerPerson();
            _editEmplEmerPhoneTB.Text = _employeePresentationModel.GetEmerPhone();
            _editEmplBasicSalaryTB.Text = _employeePresentationModel.GetBasicSalary().ToString();
            _editEmplPhoneTB.Text = _employeePresentationModel.GetPhone();
            _editEmplDeptCB.SelectedValue = _employeePresentationModel.GetDeptID();
            _editEmplPositionCB.SelectedValue = _employeePresentationModel.GetPositionID();
        }

        private void ResetNewDeptUI()
        {
            _newDeptIDTB.Text = "";
            _newDeptNameTB.Text = "";
            _newDeptTimeDP.Value = DateTime.Now;
            _newDeptManTB.Text = "";
        }

        // 按下登出鍵
        private void ClickLogoutButton(object sender, EventArgs e)
        {
            _login.Visible = true;
            this.Close();
        }

        // 按下右上角關閉
        private void CloseMainFunction(object sender, FormClosedEventArgs e)
        {
            _login.Visible = true;
        }

        // 根據婚姻狀況修改配偶欄是否可以填寫(new)
        private void ChangedNewEmplMarriedStatCBSelectedIndex(object sender, EventArgs e)
        {
            // 1 為未婚
            // 0 為已婚
            if (_newEmplMarriedStatCB.SelectedIndex == 1)
            {
                _newEmplSpouseTB.ReadOnly = false;
            }
            else if (_newEmplMarriedStatCB.SelectedIndex == 0)
            {
                _newEmplSpouseTB.ReadOnly = true;
                _newEmplSpouseTB.Text = null;
            }
        }

        // 根據婚姻狀況修改配偶欄是否可以填寫(edit)
        private void ChangedEditEmplMarriedStatCBSelectedIndex(object sender, EventArgs e)
        {
            // 1 為未婚
            // 0 為已婚
            if (_editEmplMarriedStatCB.SelectedIndex == 1)
            {
                _editEmplSpouseTB.ReadOnly = false;
            }
            else if (_editEmplMarriedStatCB.SelectedIndex == 0)
            {
                _editEmplSpouseTB.ReadOnly = true;
                _editEmplSpouseTB.Text = null;
            }
        }

        // 根據選取職位 顯示職位底薪(new)
        private void ChangedNewEmplPositionCBSelectedIndex(object sender, EventArgs e)
        {
            this.SetAllNewEmplVariableToPM();

            _employeeController = new EmployeeController(_employeePresentationModel);
            _newEmplBasicSalaryTB.Text = _employeeController.SearchBasicSalaryByPositionID();
        }

        // 根據選取職位 顯示職位底薪(edit)
        private void ChangedEditEmplPositionCBSelectedIndex(object sender, EventArgs e)
        {
            this.SetAllEditEmplVariableToPM();

            _employeeController = new EmployeeController(_employeePresentationModel);
            _editEmplBasicSalaryTB.Text = _employeeController.SearchBasicSalaryByPositionID();
        }

        // 將UI上的empl變數存入presentationModel中(new)
        private void SetAllNewEmplVariableToPM()
        {
            String emplID = _newEmplIDTB.Text;  
            String emplName = _newEmplNameTB.Text;
            String ssn = _newEmpllSsnTB.Text;
            String sex = _newEmplSexCB.SelectedItem.ToString();
            String blood = _newEmplBloodCB.SelectedItem.ToString();
            String phone = _newEmplPhoneTB.Text;
            String addr = _newEmplAddrTB.Text;
            String emerPerson = _newEmplEmerPersonTB.Text;
            String emerPhone = _newEmplEmerPhoneTB.Text;
            String military = _newEmplMilitaryStatCB.SelectedItem.ToString();
            String jobState = _newEmplJobStatCB.SelectedItem.ToString();
            String marriedState = _newEmplMarriedStatCB.SelectedItem.ToString();
            String spouse = _newEmplSpouseTB.Text;
            DateTime birth = _newEmplBirthDP.Value;
            if (_newEmplBasicSalaryTB.Text == "")
                _newEmplBasicSalaryTB.Text = "0";
            float basicSalary = System.Convert.ToSingle(_newEmplBasicSalaryTB.Text);
            String deptID = "";
            String positionID = "";
            if (_newEmplDeptCB.SelectedValue != null)
                deptID = _newEmplDeptCB.SelectedValue.ToString();
            if (_newEmplPositionCB.SelectedValue != null)
                positionID = _newEmplPositionCB.SelectedValue.ToString();

            _employeePresentationModel.SetEmplID(emplID);
            _employeePresentationModel.SetName(emplName);
            _employeePresentationModel.SetSsn(ssn);
            _employeePresentationModel.SetSex(sex);
            _employeePresentationModel.SetBlood(blood);
            _employeePresentationModel.SetPhone(phone);
            _employeePresentationModel.SetAddress(addr);
            _employeePresentationModel.SetEmerPerson(emerPerson);
            _employeePresentationModel.SetEmerPhone(emerPhone);
            _employeePresentationModel.SetMilitaryStatus(military);
            _employeePresentationModel.SetJobStatus(jobState);
            _employeePresentationModel.SetMarriedStatus(marriedState);
            _employeePresentationModel.SetSpouse(spouse);
            _employeePresentationModel.SetBirth(birth);
            _employeePresentationModel.SetBasicSalary(basicSalary);
            _employeePresentationModel.SetDeptID(deptID);
            _employeePresentationModel.SetPositoinID(positionID);
        }

        // 將UI上的empl變數存入presentationModel中(edit)
        private void SetAllEditEmplVariableToPM()
        {
            String emplID = _editEmplIDTB.Text;
            String emplName = _editEmplNameTB.Text;
            String ssn = _editEmplSsnTB.Text;
            String sex = _editEmplSexCB.SelectedItem.ToString();
            String blood = _editEmplBloodCB.SelectedItem.ToString();
            String phone = _editEmplPhoneTB.Text;
            String addr = _editEmplAddrTB.Text;
            String emerPerson = _editEmplEmerPersonTB.Text;
            String emerPhone = _editEmplEmerPhoneTB.Text;
            String military = _editEmplMilitaryStatCB.SelectedItem.ToString();
            String jobState = _editEmplJobStatCB.SelectedItem.ToString();
            String marriedState = _editEmplMarriedStatCB.SelectedItem.ToString();
            String spouse = _editEmplSpouseTB.Text;
            DateTime birth = _editEmplBirthDTP.Value;
            if (_editEmplBasicSalaryTB.Text == "")
                _editEmplBasicSalaryTB.Text = "0";
            float basicSalary = System.Convert.ToSingle(_editEmplBasicSalaryTB.Text);
            String deptID = "";
            String positionID = "";
            if (_editEmplDeptCB.SelectedValue != null)
                deptID = _editEmplDeptCB.SelectedValue.ToString();
            if (_editEmplPositionCB.SelectedValue != null)
                positionID = _editEmplPositionCB.SelectedValue.ToString();

            _employeePresentationModel.SetEmplID(emplID);
            _employeePresentationModel.SetName(emplName);
            _employeePresentationModel.SetSsn(ssn);
            _employeePresentationModel.SetSex(sex);
            _employeePresentationModel.SetBlood(blood);
            _employeePresentationModel.SetPhone(phone);
            _employeePresentationModel.SetAddress(addr);
            _employeePresentationModel.SetEmerPerson(emerPerson);
            _employeePresentationModel.SetEmerPhone(emerPhone);
            _employeePresentationModel.SetMilitaryStatus(military);
            _employeePresentationModel.SetJobStatus(jobState);
            _employeePresentationModel.SetMarriedStatus(marriedState);
            _employeePresentationModel.SetSpouse(spouse);
            _employeePresentationModel.SetBirth(birth);
            _employeePresentationModel.SetBasicSalary(basicSalary);
            _employeePresentationModel.SetDeptID(deptID);
            _employeePresentationModel.SetPositoinID(positionID);
        }
        
        // 按下新增員工按鈕
        private void ClickAddEmplButton(object sender, EventArgs e)
        {
            this.SetAllNewEmplVariableToPM();

            _employeeController = new EmployeeController(_employeePresentationModel);
            _employeeController.AddEmployee();
        }

        // 按下修改員工資料按鈕
        private void ClickEditEmplButtom(object sender, EventArgs e)
        {
            this.SetAllEditEmplVariableToPM();

            _employeeController = new EmployeeController(_employeePresentationModel);
            if (_employeeController.EditEmployee())
            {
                this.SetAllEmplEditToNotEnable();
                this.ResetEditEmplUI();
            }
        }

        // 設置所有編輯的UI 可以更改
        private void SetAllEmplEditToNotEnable()
        {
            _editEmplIDTB.ReadOnly = false;
            _editEmplIDTB.Text = "";
            _editEmplNameTB.ReadOnly = true;
            _editEmplNameTB.Text = "";
            _editEmplSsnTB.ReadOnly = true;
            _editEmplSsnTB.Text = "";
            _editEmplAddrTB.ReadOnly = true;
            _editEmplAddrTB.Text = "";
            _editEmplEmerPersonTB.ReadOnly = true;
            _editEmplEmerPersonTB.Text = "";
            _editEmplEmerPhoneTB.ReadOnly = true;
            _editEmplEmerPhoneTB.Text = "";
            _editEmplBasicSalaryTB.ReadOnly = true;
            _editEmplBasicSalaryTB.Text = "";
            _editEmplPhoneTB.ReadOnly = true;
            _editEmplPhoneTB.Text = "";
            _editEmplSpouseTB.ReadOnly = true;
            _editEmplSpouseTB.Text = "";
            _editEmplJobStatCB.Enabled = false;
            _editEmplJobStatCB.Text = "";
            _editEmplDeptCB.Enabled = false;
            _editEmplDeptCB.Text = "";
            _editEmplPositionCB.Enabled = false;
            _editEmplPositionCB.Text = "";
            _editEmplSexCB.Enabled = false;
            _editEmplSexCB.Text = "";
            _editEmplBloodCB.Enabled = false;
            _editEmplBloodCB.Text = "";
            _editEmplMilitaryStatCB.Enabled = false;
            _editEmplMarriedStatCB.Enabled = false;
            _editEmplButton.Enabled = false;
            _editEmplBirthDTP.Enabled = false;
        }

        // 設置所有編輯的Employee UI 可以更改
        private void SetAllEmplEditToEnable()
        {
            _editEmplIDTB.ReadOnly = true;
            _editEmplNameTB.ReadOnly = false;
            _editEmplSsnTB.ReadOnly = false;
            _editEmplAddrTB.ReadOnly = false;
            _editEmplEmerPersonTB.ReadOnly = false;
            _editEmplEmerPhoneTB.ReadOnly = false;
            _editEmplBasicSalaryTB.ReadOnly = false;
            _editEmplPhoneTB.ReadOnly = false;
            _editEmplSpouseTB.ReadOnly = false;
            _editEmplJobStatCB.Enabled = true;
            _editEmplDeptCB.Enabled = true;
            _editEmplPositionCB.Enabled = true;
            _editEmplSexCB.Enabled = true;
            _editEmplBloodCB.Enabled = true;
            _editEmplMilitaryStatCB.Enabled = true;
            _editEmplMarriedStatCB.Enabled = true;
            _editEmplButton.Enabled = true;
            _editEmplBirthDTP.Enabled = true;
        }

        // 權限編輯後將UI初始化
        private void SetAllAuthoEditToNotEable()
        {
            _editAuthoIDTB.ReadOnly = false;
            _editAuthoIDTB.Text = "";
            _editAuthoNameTB.ReadOnly = true;
            _editAuthoLevelCB.SelectedIndex = 0;
            _editAuthoLevelCB.Enabled = false;
        }

        // 設置可編輯的Authorization欄位
        private void SetAllAuthoEditToEnable()
        {
            _editAuthoIDTB.ReadOnly = true;
            _editAuthoNameTB.ReadOnly = false;
            _editAuthoLevelCB.Enabled = true;
        }

        // 按下查詢員工按鈕
        private void ClickSearchEmplButtom(object sender, EventArgs e)
        {
            String emplID = _editEmplIDTB.Text;
            _employeePresentationModel.SetEmplID(emplID);

            _employeeController = new EmployeeController(_employeePresentationModel);
            _employeePresentationModel = _employeeController.SearchDataByEmplID();

            if (_employeePresentationModel.GetEmplID() == null || _employeePresentationModel.GetEmplID() == "")
                return;

            this.SetAllEmplEditToEnable();
            this.ResetSearchEditEmplUI();
        }

        // 將新增權限的所有變數存至presentation model
        private void SetAllNewAuthoVariableToPM()
        {
            String authoID = _newAuthoIDTB.Text;
            String authoName = _newAuthoNameTB.Text;
            String authoLevel = _newAuthoLevelCB.SelectedItem.ToString();

            this._authoPresentationModel.SetAuthoID(authoID);
            this._authoPresentationModel.SetAuthoName(authoName);
            this._authoPresentationModel.SetAuthoValue(authoLevel);
        }

        // 將編輯權限的所有變數存至presentation model
        private void SetAllEditAuthoVariableToPM()
        {
            String authoID = _editAuthoIDTB.Text;
            String authoName = _editAuthoNameTB.Text;
            String authoValue = _editAuthoLevelCB.SelectedItem.ToString();

            this._authoPresentationModel.SetAuthoID(authoID);
            this._authoPresentationModel.SetAuthoName(authoName);
            this._authoPresentationModel.SetAuthoValue(authoValue);
        }

        // 按下加入權限
        private void ClickAddAuthoButton(object sender, EventArgs e)
        {
            this.SetAllNewAuthoVariableToPM();

            _authoController = new AuthorizationController(_authoPresentationModel);
            _authoController.AddAuthorization();
        }

        // 按下查詢權限按鈕
        private void ClickSearchAuthoButtom(object sender, EventArgs e)
        {
            String authoID = _editAuthoIDTB.Text;
            _authoPresentationModel.SetAuthoID(authoID);

            _authoController = new AuthorizationController(_authoPresentationModel);
            _authoPresentationModel = _authoController.SearchDataByAuthoID();

            if (_authoPresentationModel.GetAuthoID() == null || _authoPresentationModel.GetAuthoID() == "")
                return;

            this.SetAllAuthoEditToEnable();
            this.ResetSearchEditAuthoUI();
        }

        // 按下編輯權限按鈕
        private void ClickEditAuthoButtom(object sender, EventArgs e)
        {
            this.SetAllEditAuthoVariableToPM();
            _authoController = new AuthorizationController(_authoPresentationModel);
            if(_authoController.editAuthorization())
            {
                this.SetAllAuthoEditToNotEable();
                this.ResetEditAuthoUI();
            }
        }
//=======
        // 設置position UI變數至presentation model
        private Boolean SetAllNewPositionVariableToPM()
        {
            String positionID = _addPositionIDTB.Text;
            String positionName = _addPositionNameTB.Text;
            float positionBS;
            try
            {
                positionBS = System.Convert.ToSingle(_addPositionBSTB.Text);
            }
            catch
            {
                MessageBox.Show("輸入的職位底薪不為數字, 請重新輸入!");
                return false;
            }
            String positionAuthoID = null;
            if (_addPositionAuthoCB.SelectedValue != null)
                positionAuthoID = _addPositionAuthoCB.SelectedValue.ToString();

            this._positionPresentationModel.SetPositionID(positionID);
            this._positionPresentationModel.SetPositionName(positionName);
            this._positionPresentationModel.SetPositionBasicSalary(positionBS);
            this._positionPresentationModel.SetPositionAuthoID(positionAuthoID);
            return true;
        }

        // 按下加入職位
        private void ClickAddPositionButton(object sender, EventArgs e)
        {
            if (this.SetAllNewPositionVariableToPM())
            {
                _positionController = new PositionController(_positionPresentationModel);
                _positionController.AddPosition();
            }         
        }

//>>>>>>> origin/master

        // 設置所有edit position UI to enable
        private void SetAllPositionEditToEnable()
        {
            _editPositionNameTB.ReadOnly = false;
            _editPositionBSTB.ReadOnly = false;
            _editPositionAuthoCB.Enabled = true;
            _editPositionButton.Enabled = true;
        }

        // 設置所有edit position UI to enable
        private void SetAllPositionEditToNotEnable()
        {
            _editPositionNameTB.ReadOnly = true;
            _editPositionBSTB.ReadOnly = true;
            _editPositionAuthoCB.Enabled = false;
            _editPositionButton.Enabled = false;
        }

        // 設置資料進edit position UI中
        private void ResetSearchEditPositionUI()
        {
            _editPositionNameTB.Text = this._positionPresentationModel.GetPositionName();
            _editPositionBSTB.Text = this._positionPresentationModel.GetPositionBasicSalary().ToString();
            _editPositionAuthoCB.SelectedValue = this._positionPresentationModel.GetPositionAuthoID();
        }

        // 按下查詢職位按鈕
        private void ClickSearchPositionButtom(object sender, EventArgs e)
        {
            String positionID = _editPositionIDTB.Text;
            _positionPresentationModel.SetPositionID(positionID);

            _positionController = new PositionController(_positionPresentationModel);
            _positionPresentationModel = _positionController.SearchDataByPositionID();

            if (_positionPresentationModel.GetPositionID() == null || _positionPresentationModel.GetPositionID() == "")
                return;

            this.SetAllPositionEditToEnable();
            this.ResetSearchEditPositionUI();
        }

        // 設置position UI變數至presentation model
        private Boolean SetAllEditPositionVariableToPM()
        {
            String positionID = _editPositionIDTB.Text;
            String positionName = _editPositionNameTB.Text;
            float positionBS;
            try
            {
                positionBS = System.Convert.ToSingle(_editPositionBSTB.Text);
            }
            catch
            {
                MessageBox.Show("輸入的職位底薪不為數字, 請重新輸入!");
                return false;
            }
            String positionAuthoID = null;
            if (_addPositionAuthoCB.SelectedValue != null)
                positionAuthoID = _editPositionAuthoCB.SelectedValue.ToString();

            this._positionPresentationModel.SetPositionID(positionID);
            this._positionPresentationModel.SetPositionName(positionName);
            this._positionPresentationModel.SetPositionBasicSalary(positionBS);
            this._positionPresentationModel.SetPositionAuthoID(positionAuthoID);
            return true;
        }

        // 按下修改職位按鈕
        private void ClickEditPositionButton(object sender, EventArgs e)
        {
            this.SetAllEditPositionVariableToPM();
            _positionController = new PositionController(_positionPresentationModel);
            if (_positionController.EditPosition())
            {
                this.SetAllPositionEditToNotEnable();
                this.ResetEditPositionUI();
            }
        }

        // 選取狀態更改上下班時間enable
        private void ChangeWAStatusSelectedIndex(object sender, EventArgs e)
        {
            int waStatusIndex = _addWAWorkStatusCB.SelectedIndex;

            // 3 無故未到
            // 4 病假
            // 5 婚假
            // 6 產假
            // 7 休假

            if (waStatusIndex == 3 || waStatusIndex == 4 || waStatusIndex == 5 || waStatusIndex == 6 || waStatusIndex == 7)
            {
                _addWAIsOvertimeCB.SelectedIndex = 0;
                _addWAIsOvertimeCB.Enabled = false;
                _addWAStartWTDTP.Enabled = false;
                _addWAEndWTDTP.Enabled = false;
            }
            else
            {
                _addWAIsOvertimeCB.Enabled = true;
                _addWAStartWTDTP.Enabled = true;
                _addWAEndWTDTP.Enabled = true;
            }
        }

        // 選取是否加班更改加班時間enable
        private void ChangeWAIsOvertimeSelectedIndex(object sender, EventArgs e)
        {
            int waIsOvertimeIndex = _addWAIsOvertimeCB.SelectedIndex;

            // 0 NO
            // 1 YES

            if (waIsOvertimeIndex == 0)
            {
                _addWAStartOTDTP.Enabled = false;
                _addWAEndOTDTP.Enabled = false;
            }
            else
            {
                _addWAStartOTDTP.Enabled = true;
                _addWAEndOTDTP.Enabled = true;
            }
        }

        // 設置add work attendance UI變數至work attendance presentation model
        private void SetAllNewWAVariableToPM()
        {
            String emplID = _addWAEmplIDTB.Text;
            DateTime waDate = _addWADateDTP.Value;
            String waStatus = _addWAWorkStatusCB.SelectedItem.ToString();
            Boolean isOvertime;

            this._waPresentationModel.SetWAEmplID(emplID);
            this._waPresentationModel.SetWADate(waDate);
            this._waPresentationModel.SetWAStatus(waStatus);

            int waStatusIndex = _addWAWorkStatusCB.SelectedIndex;
            // 3 無故未到
            // 4 病假
            // 5 婚假
            // 6 產假
            // 7 休假
            if (!(waStatusIndex == 3 || waStatusIndex == 4 || waStatusIndex == 5 || waStatusIndex == 6 || waStatusIndex == 7))
            {
                DateTime startWorkTime = _addWAStartWTDTP.Value;
                DateTime endWorkTime = _addWAEndWTDTP.Value;
                this._waPresentationModel.SetStartTime(startWorkTime);
                this._waPresentationModel.SetEndTime(endWorkTime);
            }

            int waIsOvertimeIndex = _addWAIsOvertimeCB.SelectedIndex;
            // 0 NO
            // 1 YES
            if (waIsOvertimeIndex == 0)
            {
                isOvertime = false;
                this._waPresentationModel.SetIsOvertime(isOvertime);
            }
            else
            {
                isOvertime = true;
                DateTime startOvertime = _addWAStartOTDTP.Value;
                DateTime endOvertime = _addWAEndOTDTP.Value;
                this._waPresentationModel.SetIsOvertime(isOvertime);
                this._waPresentationModel.SetStartOvertime(startOvertime);
                this._waPresentationModel.SetEndOvertime(endOvertime);
            }
            
        }

        // 按下新增考勤資料按鈕
        private void ClickAddWAButton(object sender, EventArgs e)
        {
            this.SetAllNewWAVariableToPM();
            this._waController = new WorkAttendanController(_waPresentationModel);
            _waController.AddWorkAttendance();
        }

        // 選取狀態更改edit上下班時間enable
        private void ChangeEditWAStatusSelectedIndex(object sender, EventArgs e)
        {
            int waStatusIndex = _editWAStatusCB.SelectedIndex;

            // 3 無故未到
            // 4 病假
            // 5 婚假
            // 6 產假
            // 7 休假

            if (waStatusIndex == 3 || waStatusIndex == 4 || waStatusIndex == 5 || waStatusIndex == 6 || waStatusIndex == 7)
            {
                _editWAIsOvertimeCB.SelectedIndex = 0;
                _editWAIsOvertimeCB.Enabled = false;
                _editWAStartWTDTP.Enabled = false;
                _editWAEndWTDTP.Enabled = false;
            }
            else
            {
                _editWAIsOvertimeCB.Enabled = true;
                _editWAStartWTDTP.Enabled = true;
                _editWAEndWTDTP.Enabled = true;
            }
        }

        // 選取是否加班更改edit加班時間enable
        private void ChangeEditWAIsOvertimeSelectedIndex(object sender, EventArgs e)
        {
            int waIsOvertimeIndex = _editWAIsOvertimeCB.SelectedIndex;

            // 0 NO
            // 1 YES

            if (waIsOvertimeIndex == 0)
            {
                _editWAStartOTDTP.Enabled = false;
                _editWAEndOTDTP.Enabled = false;
            }
            else
            {
                _editWAStartOTDTP.Enabled = true;
                _editWAEndOTDTP.Enabled = true;
            }
        }

        // 將搜尋後的結果及對應的enable設置進UI
        private void ResetAllEditWAUI()
        {
            _editWADateDTP.Enabled = false;
            String status = this._waPresentationModel.GetWAStatus();
            _editWAStatusCB.Enabled = true;
            _editWAStatusCB.SelectedItem = status;
            if (!(status == "無故未到" || status == "病假" || status == "婚假" || status == "產假" || status == "休假"))
            {
                _editWAStartWTDTP.Enabled = true;
                _editWAStartWTDTP.Value = this._waPresentationModel.GetStartTime();
                _editWAEndWTDTP.Enabled = true;
                _editWAEndWTDTP.Value = this._waPresentationModel.GetEndTime();
            }

            Boolean isOvertime = this._waPresentationModel.GetIsOvertime();
            _editWAIsOvertimeCB.Enabled = true;
            if (isOvertime)
            {
                _editWAIsOvertimeCB.SelectedIndex = 1;
                _editWAStartOTDTP.Enabled = true;
                _editWAStartOTDTP.Value = this._waPresentationModel.GetStartOvertime();
                _editWAEndOTDTP.Enabled = true;
                _editWAEndOTDTP.Value = this._waPresentationModel.GetEndOvertime();
            }
            else
            {
                _editWAIsOvertimeCB.SelectedIndex = 0;
            }
            _searchWAButton.Enabled = false;
            _editWAButton.Enabled = true;
        }

        // 按下搜尋work attendance
        private void ClickSearchWAButton(object sender, EventArgs e)
        {
            String emplID = _editWAEmplIDTB.Text;
            DateTime date = _editWADateDTP.Value;
            _waPresentationModel.SetWAEmplID(emplID);
            _waPresentationModel.SetWADate(date);

            _waController = new WorkAttendanController(_waPresentationModel);
            _waPresentationModel = _waController.SearchDataByEmplIDAndDate();

            if (_waPresentationModel.GetWAEmplID() == null || _waPresentationModel.GetWAEmplID() == "")
                return;

            this.ResetAllEditWAUI();
        }

        // 設置edit work attendance UI變數至work attendance presentation model
        private void SetAllEditWAVariableToPM()
        {
            String emplID = _editWAEmplIDTB.Text;
            DateTime waDate = _editWADateDTP.Value;
            String waStatus = _editWAStatusCB.SelectedItem.ToString();
            Boolean isOvertime;

            this._waPresentationModel.SetWAEmplID(emplID);
            this._waPresentationModel.SetWADate(waDate);
            this._waPresentationModel.SetWAStatus(waStatus);

            int waStatusIndex = _editWAStatusCB.SelectedIndex;
            // 3 無故未到
            // 4 病假
            // 5 婚假
            // 6 產假
            // 7 休假
            if (!(waStatusIndex == 3 || waStatusIndex == 4 || waStatusIndex == 5 || waStatusIndex == 6 || waStatusIndex == 7))
            {
                DateTime startWorkTime = _editWAStartWTDTP.Value;
                DateTime endWorkTime = _editWAEndWTDTP.Value;
                this._waPresentationModel.SetStartTime(startWorkTime);
                this._waPresentationModel.SetEndTime(endWorkTime);
            }

            int waIsOvertimeIndex = _editWAIsOvertimeCB.SelectedIndex;
            // 0 NO
            // 1 YES
            if (waIsOvertimeIndex == 0)
            {
                isOvertime = false;
                this._waPresentationModel.SetIsOvertime(isOvertime);
            }
            else
            {
                isOvertime = true;
                DateTime startOvertime = _editWAStartOTDTP.Value;
                DateTime endOvertime = _editWAEndOTDTP.Value;
                this._waPresentationModel.SetIsOvertime(isOvertime);
                this._waPresentationModel.SetStartOvertime(startOvertime);
                this._waPresentationModel.SetEndOvertime(endOvertime);
            }

        }

        // 按下編輯work attendance
        private void ClickEditWAButton(object sender, EventArgs e)
        {
            this.SetAllEditWAVariableToPM();
            _waController = new WorkAttendanController(_waPresentationModel);
            if (_waController.EditWorkAttendance())
            {
                this.ResetEditWAUI();
            }
        }

        // 將新增部門的所有變數存至presentation model
        private void SetAllNewDeptVariableToPM()
        {
            String deptID = _newDeptIDTB.Text;
            String deptName = _newDeptNameTB.Text;
            DateTime deptStartTime = _newDeptTimeDP.Value;
            String deptManager = _newDeptManTB.Text;

            this._deptPresentationModel.setDepartmentID(deptID);
            this._deptPresentationModel.setDepartmentName(deptName);
            this._deptPresentationModel.setDepartmentStartTime(deptStartTime);
            //this._deptPresetationModel.setDepartmentEndTime(null);
            this._deptPresentationModel.setDepartmentManager(deptManager);
        }

        // 按下新增部門資料按鈕
        private void ClickAddDeptButton(object sender, EventArgs e)
        {
            this.SetAllNewDeptVariableToPM();

            _deptController = new DepartmentController(_deptPresentationModel);
            _deptController.AddDepartment();
            this.ResetNewDeptUI();
            this.departmentTableAdapter.Fill(this.deptDataSet.department);

        }

        // 設置所有add bonus def 變數進presentationModel
        private Boolean SetAllNewBonusDefVariableToPM()
        {
            String bonusDefID = _addBonusDefIDTB.Text;
            String bonusDefName = _addBonusNameTB.Text;
            String bonusDefDesc = _addBonusDefDescTB.Text;
            DateTime bonusDefCreateDate = _addBonusDefCreateDateDTP.Value.Date;
            DateTime bonusDefEffiDate = _addBonusDefEffiDateDTP.Value.Date;
            float bonusDefAmount;
            try
            {
                bonusDefAmount = System.Convert.ToSingle(_addBonusDefAmountTB.Text);
            }
            catch
            {
                MessageBox.Show("輸入的獎金金額不為數字, 請重新輸入!");
                return false;
            }

            this._bonusDefPresentationModel.SetBonusDefID(bonusDefID);
            this._bonusDefPresentationModel.SetBonusDefName(bonusDefName);
            this._bonusDefPresentationModel.SetBonusDefDesc(bonusDefDesc);
            this._bonusDefPresentationModel.SetBonusDefCreateDate(bonusDefCreateDate);
            this._bonusDefPresentationModel.SetBonusDefEffiDate(bonusDefEffiDate);
            this._bonusDefPresentationModel.SetBonusDefAmount(bonusDefAmount);
            return true;
        }

        // 按下新增bonus def button
        private void ClickAddBonusDefButton(object sender, EventArgs e)
        {
            if (SetAllNewBonusDefVariableToPM())
            {
                _bonusDefController = new BonusDefController(_bonusDefPresentationModel);
                _bonusDefController.AddBonusDef();
            }
        }

        // reset all edit bonus def UI to enable
        private void ResetAllEditUIToEnable()
        {
            _editBonusDefIDTB.Enabled = false;
            _editBonusDefNameTB.Enabled = true;
            _editBonusDefDescTB.Enabled = true;
            _editBonusDefCreateDateDTP.Enabled = true;
            _editBonusDefEffiDateDTP.Enabled = true;
            _editBonusDefAmountTB.Enabled = true;
            _searchBonusDefButton.Enabled = false;
            _editBonusDefButton.Enabled = true;
        }

        // set all edit bonus def variable from presentationModel
        private void SetAllEditBonusDefVariableFormPM()
        {
            _editBonusDefNameTB.Text = this._bonusDefPresentationModel.GetBonusDefName();
            _editBonusDefDescTB.Text = this._bonusDefPresentationModel.GetBonusDefDesc();
            _editBonusDefCreateDateDTP.Value = this._bonusDefPresentationModel.GetBonusDefCreateDate();
            _editBonusDefEffiDateDTP.Value = this._bonusDefPresentationModel.GetBonusDefEffiDate();
            _editBonusDefAmountTB.Text = this._bonusDefPresentationModel.GetBonusDefAmount().ToString();
        }

        // 按下搜尋bonus def button
        private void ClickSearchBonusDefButton(object sender, EventArgs e)
        {
            String bonusDefID = _editBonusDefIDTB.Text;

            this._bonusDefPresentationModel.SetBonusDefID(bonusDefID);

            this._bonusDefController = new BonusDefController(this._bonusDefPresentationModel);

            this._bonusDefPresentationModel = this._bonusDefController.SearchDataByBonusDefID();

            if (this._bonusDefPresentationModel.GetBonusDefID() != null)
            {
                this.ResetAllEditUIToEnable();
                this.SetAllEditBonusDefVariableFormPM();
            }
        }

        // 設置所有edit bonus def 變數進presentationModel
        private Boolean SetAllEditBonusDefVariableToPM()
        {
            String bonusDefID = _editBonusDefIDTB.Text;
            String bonusDefName = _editBonusDefNameTB.Text;
            String bonusDefDesc = _editBonusDefDescTB.Text;
            DateTime bonusDefCreateDate = _editBonusDefCreateDateDTP.Value.Date;
            DateTime bonusDefEffiDate = _editBonusDefEffiDateDTP.Value.Date;
            float bonusDefAmount;
            try
            {
                bonusDefAmount = System.Convert.ToSingle(_editBonusDefAmountTB.Text);
            }
            catch
            {
                MessageBox.Show("輸入的獎金金額不為數字, 請重新輸入!");
                return false;
            }

            this._bonusDefPresentationModel.SetBonusDefID(bonusDefID);
            this._bonusDefPresentationModel.SetBonusDefName(bonusDefName);
            this._bonusDefPresentationModel.SetBonusDefDesc(bonusDefDesc);
            this._bonusDefPresentationModel.SetBonusDefCreateDate(bonusDefCreateDate);
            this._bonusDefPresentationModel.SetBonusDefEffiDate(bonusDefEffiDate);
            this._bonusDefPresentationModel.SetBonusDefAmount(bonusDefAmount);
            return true;
        }

        // 按下edit bonus def button
        private void ClickEditBonusDefButton(object sender, EventArgs e)
        {
            this.SetAllEditBonusDefVariableToPM();
            this._bonusDefController = new BonusDefController(this._bonusDefPresentationModel);
            if (_bonusDefController.EditBonusDef())
            {
                this.ResetEditBonusDefUI();
            }
        }

        // set all add bonus data to presentationModel
        private void SetAllBonusVariableToPM()
        {
            String bonusDefID = _addBonusCB.SelectedValue.ToString();
            String EmplID = _addBonusEmplIDTB.Text;
            DateTime bonusDate = _addBonusDateDTP.Value.Date;
            String bonusT = _addbonusPeriodTB.Text;

            this._bonusPresentationModel.SetBonusDefID(bonusDefID);
            this._bonusPresentationModel.SetEmplID(EmplID);
            this._bonusPresentationModel.SetBonusDate(bonusDate);
            this._bonusPresentationModel.SetBonusT(bonusT);
        }

        // 按下新增員工獎金button
        private void ClickAddBonusbutton(object sender, EventArgs e)
        {
            this.SetAllBonusVariableToPM();

            _bonusController = new BonusController(this._bonusPresentationModel);
            _bonusController.AddBonus();
        }

    }
}
