using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using OOAD_HR_System.Model;

namespace OOAD_HR_System.Service
{
    public class EmployeeService
    {

        private MySqlConnection myConnection = new MySqlConnection("server=118.166.192.62;user id=hrms; password=hrms; database=hrms; CharSet=utf8");
        private EmployeeModel _employeeModel = new EmployeeModel();

        public EmployeeService(EmployeeModel employeeModel)
        {
            this._employeeModel = employeeModel;
        }

        // 建立與資料庫連線
        private Boolean connectToDB()
        {
            try
            {
                myConnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        // 關閉資料庫連線
        private void closeConnextion()
        {
            myConnection.Close();
        }

        // 新增員工資料至資料庫表單
        public Boolean AddEmployee()
        {
            if (this.connectToDB())
            {
                try
                {
                    /* String addString = String.Format("INSERT INTO 'employee'('emplID','emplName','ssn','sex','phone','blood','address','birth'," +
                        "'emerPerson','emerPhoneNum','military','jobStat','marriedStat','spouse','deptID','positionID','basicSalary')" +
                        "VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})",
                        _employeeModel.GetEmplID(), _employeeModel.GetName(), _employeeModel.GetSsn(), _employeeModel.GetSex(), _employeeModel.GetPhone(),
                        _employeeModel.GetBlood(), _employeeModel.GetAddress(), _employeeModel.GetBirth(), _employeeModel.GetEmerPerson(), _employeeModel.GetEmerPhone(),
                        _employeeModel.GetMilitaryStatus(), _employeeModel.GetJobStatus(), _employeeModel.GetMarriedStatus(), _employeeModel.GetSpouse(),
                        _employeeModel.GetDeptID(), _employeeModel.GetPositionID(), _employeeModel.GetBasicSalary().ToString());*/
                    String addString = String.Format("INSERT INTO employee(emplID,emplName,ssn,sex,phone,blood,address,birth,emerPerson,emerPhoneNum,military,jobStat,marriedStat,spouse,deptID,positionID,basicSalary) VALUES('" +
                        this._employeeModel.GetEmplID() + "','" + this._employeeModel.GetName() + "','" + this._employeeModel.GetSsn() + "','" + this._employeeModel.GetSex() + "','" +
                        this._employeeModel.GetPhone() + "','" + this._employeeModel.GetBlood() + "','" + this._employeeModel.GetAddress() + "','" + this._employeeModel.GetBirth() + "','" +
                        this._employeeModel.GetEmerPerson() + "','" + this._employeeModel.GetEmerPhone() + "','" + this._employeeModel.GetMilitaryStatus() + "','" +
                        this._employeeModel.GetJobStatus() + "','" + this._employeeModel.GetMarriedStatus() + "','" + this._employeeModel.GetSpouse() + "','" +
                        this._employeeModel.GetDeptID() + "','" + this._employeeModel.GetPositionID() + "','" + this._employeeModel.GetBasicSalary() + "');");
                    MySqlCommand addCommand = new MySqlCommand(addString, myConnection);
                    addCommand.Connection = myConnection;
                    addCommand.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    return false;
                }
            }

            this.closeConnextion();

            return true;
        }

    }
}
