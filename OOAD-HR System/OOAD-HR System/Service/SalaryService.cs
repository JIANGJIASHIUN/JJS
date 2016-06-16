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
    public class SalaryService
    {
        private MySqlConnection myConnection = new MySqlConnection("server=csie-noip.ddns.net;user id=hrms; password=hrms; database=hrms; CharSet=utf8");
        private SalaryModel _salaryModel = new SalaryModel();

        // 建構子
        public SalaryService(SalaryModel salaryModel)
        {
            this._salaryModel = salaryModel;
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

        // 新增薪水支付資料至資料庫
        public Boolean addPayway()
        {
            if(this.connectToDB())
            {
                try
                {
                    String addString = String.Format("INSERT INTO salary(emplID,salaryPayWay,accountData) VALUES('" +
                        this._salaryModel.getEmplID() + "','" + this._salaryModel.getPayway() + "','" +
                        this._salaryModel.getAccountData() + "');");
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

        // 以輸入員工ID搜尋支付資料
        public SalaryModel searchByEmplID()
        {
            if (this.connectToDB())
            {
                try
                {
                    DataTable dataSet = new DataTable();

                    String searchString = String.Format("SELECT * FROM salary WHERE emplID = '" + this._salaryModel.getEmplID() + "'");
                    MySqlCommand searchCommand = new MySqlCommand(searchString, myConnection);
                    searchCommand.ExecuteNonQuery();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                    adapter.Fill(dataSet);

                    foreach (DataRow searchDr in dataSet.Rows)
                    {
                        _salaryModel.setPayway(searchDr["salaryPayWay"].ToString());
                        _salaryModel.setAccountData(searchDr["accountData"].ToString());
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }


            }
            this.closeConnection();

            return this._salaryModel;
        }

        // 更新薪資支付資料至資料庫
        public Boolean EditPayway()
        {
            if (this.connectToDB())
            {
                try
                {
                    String addString = String.Format("UPDATE salary SET salaryPayWay='" + this._salaryModel.getPayway() +
                        "',accountData='" + this._salaryModel.getAccountData() + "' WHERE emplID='" +
                        this._salaryModel.getEmplID() + "';");
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
