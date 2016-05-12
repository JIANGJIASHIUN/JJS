using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOAD_HR_System.PresentationModel;
using OOAD_HR_System.Model;
using OOAD_HR_System.Service;

namespace OOAD_HR_System.Controller
{
    public class EmployeeController
    {

        private EmployeeModel _employeeModel = new EmployeeModel();
        private EmployeeService _employeeService;

        // 建構子
        public EmployeeController(EmployeePresentationModel employeePresentationModel)
        {
            _employeeModel.SetEmplID(employeePresentationModel.GetEmplID());
            _employeeModel.SetName(employeePresentationModel.GetName());
            _employeeModel.SetSsn(employeePresentationModel.GetSsn());
            _employeeModel.SetSex(employeePresentationModel.GetSex());
            _employeeModel.SetPhone(employeePresentationModel.GetPhone());
            _employeeModel.SetAddress(employeePresentationModel.GetAddress());
            _employeeModel.SetBlood(employeePresentationModel.GetBlood());
            _employeeModel.SetBirth(employeePresentationModel.GetBirth());
            _employeeModel.SetEmerPerson(employeePresentationModel.GetEmerPerson());
            _employeeModel.SetEmerPhone(employeePresentationModel.GetEmerPhone());
            _employeeModel.SetMilitaryStatus(employeePresentationModel.GetMilitaryStatus());
            _employeeModel.SetJobStatus(employeePresentationModel.GetJobStatus());
            _employeeModel.SetMarriedStatus(employeePresentationModel.GetMarriedStatus());
            _employeeModel.SetSpouse(employeePresentationModel.GetSpouse());
            _employeeModel.SetDeptID(employeePresentationModel.GetDeptID());
            _employeeModel.SetPositoinID(employeePresentationModel.GetPositionID());
            _employeeModel.SetBasicSalary(employeePresentationModel.GetBasicSalary());
        }

        // 呼叫service, 將資料新增至資料庫
        public void InsertEmployee()
        {
            _employeeService = new EmployeeService(_employeeModel);
            if (_employeeService.AddEmployee())
                MessageBox.Show("新增成功!");
            else
                MessageBox.Show("新增失敗!");
        }

    }
}
