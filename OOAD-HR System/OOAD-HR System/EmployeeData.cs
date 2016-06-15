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
    public partial class EmployeeData : Form
    {

        private Form _login = new Form();
        private EmployeePresentationModel _employeePresentationModel = new EmployeePresentationModel();
        private EmployeeController _employeeController;

        public EmployeeData(Form login, String emplID, String password)
        {
            _login = login;
            _employeePresentationModel.SetEmplID(emplID);
            _employeePresentationModel.SetEmplLoginPassword(password);
            
            this.SetAllEmplDataToUI();
            
            InitializeComponent();
        }

        // 查詢該員工資料並將資料填進UI中
        private void SetAllEmplDataToUI()
        {
            _employeeController = new EmployeeController(_employeePresentationModel);
            _employeePresentationModel = _employeeController.SearchDataByEmplID();

            try
            {
                _newEmplIDTB.Text = _employeePresentationModel.GetEmplID();
                _newEmplBirthDP.Value = _employeePresentationModel.GetBirth();
                _newEmplMarriedStatCB.SelectedItem = _employeePresentationModel.GetMarriedStatus();
                // 1 為未婚
                // 0 為已婚
                if (_newEmplMarriedStatCB.SelectedIndex == 1)
                {
                    _newEmplSpouseTB.Text = _employeePresentationModel.GetSpouse();
                }
                else if (_newEmplMarriedStatCB.SelectedIndex == 0)
                {
                    _newEmplSpouseTB.ReadOnly = true;
                    _newEmplSpouseTB.Text = null;
                }
                _newEmplJobStatCB.SelectedItem = _employeePresentationModel.GetJobStatus();
                _newEmplMilitaryStatCB.SelectedItem = _employeePresentationModel.GetMilitaryStatus();
                _newEmplBloodCB.SelectedItem = _employeePresentationModel.GetBlood();
                _newEmplSexCB.SelectedItem = _employeePresentationModel.GetSex();
                _newEmplNameTB.Text = _employeePresentationModel.GetName();
                _newEmpllSsnTB.Text = _employeePresentationModel.GetSsn(); ;
                _newEmplAddrTB.Text = _employeePresentationModel.GetAddress();
                _newEmplEmerPersonTB.Text = _employeePresentationModel.GetEmerPerson();
                _newEmplEmerPhoneTB.Text = _employeePresentationModel.GetEmerPhone();
                _newEmplBasicSalaryTB.Text = _employeePresentationModel.GetBasicSalary().ToString();
                _newEmplPhoneTB.Text = _employeePresentationModel.GetPhone();
                _newEmplDeptCB.SelectedValue = _employeePresentationModel.GetDeptID();
                _newEmplPositionCB.SelectedValue = _employeePresentationModel.GetPositionID();
                _addEmplLoginPWTB.Text = _employeePresentationModel.GetEmplLoginPassword();
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("系統發生錯誤, 請稍後再嘗試!");
            }     
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

        private void EmployeeData_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'emplPositionDataDataSet.position' 資料表。您可以視需要進行移動或移除。
            this.positionTableAdapter.Fill(this.emplPositionDataDataSet.position);
            // TODO:  這行程式碼會將資料載入 'emplDeptDataDataSet.department' 資料表。您可以視需要進行移動或移除。
            this.departmentTableAdapter.Fill(this.emplDeptDataDataSet.department);

        }
    }
}
