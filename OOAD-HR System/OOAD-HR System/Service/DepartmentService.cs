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
        private DepartmentModel _departmentModel = new DepartmentModel();

        // 建構子
        public DepartmentService(DepartmentModel departmentModel)
        {
            this._departmentModel = departmentModel;
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

        // 新增部門資料至資料庫表單
        public Boolean AddDepartment()
        {
            if(this.connectToDB())
            {
                try
                {
                    String addString = String.Format("INSERT INTO department(departmentID,departmentName,departmentStartTime,departmentEndTime,departmentManager) VALUES('" +
                        this._departmentModel.getDepartmentID() + "','" + this._departmentModel.getDepartmentName() + "','" + this._departmentModel.getDepartmentStartTime() + 
                        "','" + this._departmentModel.getDepartmentEndTime() + "','" + this._departmentModel.getDepartmentManager() + "');");
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
    }
}
