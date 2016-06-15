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
    public class DepartmentService
    {
        private MySqlConnection myConnection = new MySqlConnection("server=csie-noip.ddns.net;user id=hrms; password=hrms; database=hrms; CharSet=utf8");
        private DepartmentModel _deptModel = new DepartmentModel();

        // 建構子
        public DepartmentService(DepartmentModel departmentModel)
        {
            this._deptModel = departmentModel;
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
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                return false;
            }
        }

        // 關閉資料庫連線
        private void closeConnection()
        {
            myConnection.Close();
        }

        // 新增部門資料至資料庫表單
        public Boolean AddDepartment()
        {
            if(this.connectToDB())
            {
                try
                {
                    String addString = String.Format("INSERT INTO department(departmentID,departmentName,departmentStartTime,departmentEndTime,departmentManager) VALUES('" +
                        this._deptModel.getDepartmentID() + "','" + this._deptModel.getDepartmentName() + "','" + this._deptModel.getDepartmentStartTime() + 
                        "','" + this._deptModel.getDepartmentEndTime() + "','" + this._deptModel.getDepartmentManager() + "');");
                    MySqlCommand addCommand = new MySqlCommand(addString, myConnection);
                    addCommand.Connection = myConnection;
                    addCommand.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                    return false;
                }
            }
            this.closeConnection();
            return true;
        }

        // 輸入部門ID搜尋部門資料
        public DepartmentModel searchByDeptID()
        {
            if (this.connectToDB())
            {
                try
                {
                    DataTable dataset = new DataTable();

                    String searchString = String.Format("SELECT * FROM department WHERE departmentID = '" + this._deptModel.getDepartmentID() + "'");
                    MySqlCommand searchCommand = new MySqlCommand(searchString, myConnection);
                    searchCommand.ExecuteNonQuery();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                    adapter.Fill(dataset);

                    foreach (DataRow searchDr in dataset.Rows)
                    {
                        _deptModel.setDepartmentName(searchDr["departmentName"].ToString());
                        _deptModel.setDepartmentStartTime(System.Convert.ToDateTime(searchDr["departmentStartTime"]));
                        _deptModel.setDepartmentEndTime(System.Convert.ToDateTime(searchDr["departmentEndTime"]));
                        _deptModel.setDepartmentManager(searchDr["departmentManager"].ToString());
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }
            }
            this.closeConnection();
            return this._deptModel;
        }

        // 修改部門資料至資料庫表單
        public Boolean EditDepartment()
        {
            if (this.connectToDB())
            {
                try
                {
                    String addString = String.Format("UPDATE department SET departmentName='" + this._deptModel.getDepartmentName() +
                        "',departmentStartTime='" + this._deptModel.getDepartmentStartTime() + "',departmentEndTime='" + this._deptModel.getDepartmentEndTime() +
                        "',departmentManager='" + _deptModel.getDepartmentManager() + "' WHERE departmentID='" + this._deptModel.getDepartmentID() +
                        "';");
                    MySqlCommand updateCommand = new MySqlCommand(addString, myConnection);
                    updateCommand.Connection = myConnection;
                    updateCommand.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                    return false;
                }
            }
            this.closeConnection();
            return true;
        }
    }
}
