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
    public class ProduceSalaryService
    {

        private MySqlConnection myConnection = new MySqlConnection("server=csie-noip.ddns.net;user id=hrms; password=hrms; database=hrms; CharSet=utf8");
        private ProduceSalaryModel _produceSlaryModel = new ProduceSalaryModel();

        // 建構子
        public ProduceSalaryService(ProduceSalaryModel produceSlaryModel)
        {
            this._produceSlaryModel = produceSlaryModel;
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
        public Boolean AddProduceSalary()
        {
            if(this.connectToDB())
            {
                try
                {
                    String addString = String.Format("INSERT INTO salarypage (startDate,endDate,salaryPageT,emplID,salaryPayWay,accountData,salaryTotal) VALUES('" +
                        this._produceSlaryModel.GetStartDate().ToString("yy/MM/dd") + "','" + this._produceSlaryModel.GetEndDate().ToString("yy/MM/dd") + "','" +
                        this._produceSlaryModel.GetSalaryT() + "','" + this._produceSlaryModel.GetEmplID() + "','" + this._produceSlaryModel.GetPayWay() + "','" +
                        this._produceSlaryModel.GetAccountData() + "','" + this._produceSlaryModel.GetTotalSalary().ToString()　+ "');");
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

    }
}
