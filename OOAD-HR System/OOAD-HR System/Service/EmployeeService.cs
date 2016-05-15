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
        private void closeConnection()
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

            this.closeConnection();

            return true;
        }

        // 修改員工資料至資料庫表單
        public Boolean EditEmployee()
        {
            if (this.connectToDB())
            {
                try
                {
                    String addString = String.Format("UPDATE employee SET emplName='" + this._employeeModel.GetName() +
                        "',ssn='" + this._employeeModel.GetSsn() + "',sex='" + this._employeeModel.GetSex() + "',phone='" + this._employeeModel.GetPhone() + 
                        "',blood='" + this._employeeModel.GetBlood() + "',address='" + this._employeeModel.GetAddress() + "',birth='" + this._employeeModel.GetBirth() +
                        "',emerPerson='" + this._employeeModel.GetEmerPerson() + "',emerPhoneNum='" + this._employeeModel.GetEmerPhone() +
                        "',military='" + this._employeeModel.GetMilitaryStatus() + "',jobStat='" + this._employeeModel.GetJobStatus() + 
                        "',marriedStat='" + this._employeeModel.GetMarriedStatus() + "',spouse='" + this._employeeModel.GetSpouse() + 
                        "',deptID='" + this._employeeModel.GetDeptID() + "',positionID='" + this._employeeModel.GetPositionID() +
                        "',basicSalary='" + this._employeeModel.GetBasicSalary() + "' WHERE emplID='" + this._employeeModel.GetEmplID() + "';");

                    MySqlCommand updateCommand = new MySqlCommand(addString, myConnection);
                    updateCommand.Connection = myConnection;
                    updateCommand.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    return false;
                }
            }

            this.closeConnection();

            return true;
        }

        // 以輸入員工ID搜尋員工資料
        public EmployeeModel searchByEmplID()
        {
            if (this.connectToDB())
            {
                try
                {
                    DataTable dataSet = new DataTable();

                    String searchString = String.Format("SELECT * FROM employee WHERE emplID = '" + this._employeeModel.GetEmplID() + "'");
                    MySqlCommand searchCommand = new MySqlCommand(searchString, myConnection);
                    searchCommand.ExecuteNonQuery();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                    adapter.Fill(dataSet);

                    foreach (DataRow searchDr in dataSet.Rows)
                    {
                        _employeeModel.SetAddress(searchDr["address"].ToString());
                        _employeeModel.SetBasicSalary(System.Convert.ToSingle(searchDr["basicSalary"]));
                        _employeeModel.SetBirth(System.Convert.ToDateTime(searchDr["birth"]));
                        _employeeModel.SetBlood(searchDr["blood"].ToString());
                        _employeeModel.SetDeptID(searchDr["deptID"].ToString());
                        _employeeModel.SetEmerPerson(searchDr["emerPerson"].ToString());
                        _employeeModel.SetEmerPhone(searchDr["emerPhoneNum"].ToString());
                        _employeeModel.SetEmplID(searchDr["emplID"].ToString());
                        _employeeModel.SetName(searchDr["emplName"].ToString());
                        _employeeModel.SetJobStatus(searchDr["jobStat"].ToString());
                        _employeeModel.SetMarriedStatus(searchDr["marriedStat"].ToString());
                        _employeeModel.SetMilitaryStatus(searchDr["military"].ToString());
                        _employeeModel.SetPhone(searchDr["phone"].ToString());
                        _employeeModel.SetPositoinID(searchDr["positionID"].ToString());
                        _employeeModel.SetSex(searchDr["sex"].ToString());
                        _employeeModel.SetSpouse(searchDr["spouse"].ToString());
                        _employeeModel.SetSsn(searchDr["ssn"].ToString());
                    }
                }
                catch (MySqlException ex)
                {

                }
            }

            this.closeConnection();

            return this._employeeModel;
        }

    }
}
