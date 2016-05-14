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

        public _mainFunction(Form login)
        {
            _login = login;

            InitializeComponent();
        }

        // form load
        private void LoadMainFunction(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'positionDataSet.position' 資料表。您可以視需要進行移動或移除。
            this.positionTableAdapter.Fill(this.positionDataSet.position);
            // TODO:  這行程式碼會將資料載入 'deptDataSet.department' 資料表。您可以視需要進行移動或移除。
            this.departmentTableAdapter.Fill(this.deptDataSet.department);

            // 設置所有UI的預設值
            this.ResetUI();
        }

        // reset all UI 預設值
        private void ResetUI() 
        {
            _newEmplJobStatCB.SelectedIndex = 0;
            _newEmplMarriedStatCB.SelectedIndex = 0;
            _newEmplMilitaryStatCB.SelectedIndex = 0;
            _newEmplBloodCB.SelectedIndex = 0;
            _newEmplSexCB.SelectedIndex = 0;
            this.SetAllVariableToPM();

            _employeeController = new EmployeeController(_employeePresentationModel);
            _newEmplBasicSalaryTB.Text = _employeeController.SearchBasicSalaryByPositionID();
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

        // 根據婚姻狀況修改配偶欄是否可以填寫
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

        // 根據選取職位 顯示職位底薪
        private void ChangedNewEmplPositionCBSelectedIndex(object sender, EventArgs e)
        {
            this.SetAllVariableToPM();

            _employeeController = new EmployeeController(_employeePresentationModel);
            _newEmplBasicSalaryTB.Text = _employeeController.SearchBasicSalaryByPositionID();
        }

        // 將UI上的變數存入presentationModel中
        private void SetAllVariableToPM()
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
            float basicSalary = System.Convert.ToSingle(_newEmplBasicSalaryTB.Text);
            String deptID = _newEmplDeptCB.SelectedValue.ToString();
            String positionID = _newEmplPositionCB.SelectedValue.ToString();

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
        private void ClickAddButton(object sender, EventArgs e)
        {
            this.SetAllVariableToPM();

            _employeeController = new EmployeeController(_employeePresentationModel);
            _employeeController.InsertEmployee();
        }

    }
}
