using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using OOAD_HR_System.Model;

namespace OOAD_HR_System.Service
{
    public class PositionService
    {
        private MySqlConnection myConnection = new MySqlConnection("server=csie-noip.ddns.net;user id=hrms; password=hrms; database=hrms; CharSet=utf8");
        private PositionModel _positionModel = new PositionModel();

        public PositionService(PositionModel positionModel)
        {
            this._positionModel = positionModel;
        }

        // 建立與資料庫連線
        private Boolean connectToDB() {
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

        // 新增職位資料至資料庫表單
        public Boolean AddPosition()
        {
            if (this.connectToDB())
            {
                try
                {
                    String addString = String.Format("INSERT INTO position (positionID,positionName,positionBasicSalary,authoID) VALUES('" +
                        this._positionModel.GetId() + "','" + this._positionModel.GetName() + "','" + this._positionModel.GetBasicSalary() + "','" + this._positionModel.GetAuthoId() + "');");
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

        // 根據職位ID搜尋該職位的底薪
        public PositionModel SearchBsicSalaryByPositionID()
        {
            if (this.connectToDB())
            {
                try
                {
                    DataTable dataSet = new DataTable();

                    String searchString = String.Format("SELECT * FROM position WHERE positionID = '" + this._positionModel.GetId() + "'");
                    MySqlCommand searchCommand = new MySqlCommand(searchString, myConnection);
                    searchCommand.ExecuteNonQuery();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                    adapter.Fill(dataSet);

                    foreach (DataRow searchDr in dataSet.Rows)
                    {
                        this._positionModel.SetBasicSalary(System.Convert.ToSingle(searchDr["positionBasicSalary"]));
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }
            }

            this.closeConnection();

            return this._positionModel;
        }

        // 以輸入職位ID搜尋職位資料
        public PositionModel searchByPositionID()
        {
            if (this.connectToDB())
            {
                try
                {
                    DataTable dataSet = new DataTable();

                    String searchString = String.Format("SELECT * FROM position WHERE positionID = '" + this._positionModel.GetId() + "'");
                    MySqlCommand searchCommand = new MySqlCommand(searchString, myConnection);
                    searchCommand.ExecuteNonQuery();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                    adapter.Fill(dataSet);

                    foreach (DataRow searchDr in dataSet.Rows)
                    {
                        this._positionModel.SetName(System.Convert.ToString(searchDr["positionName"]));
                        this._positionModel.SetBasicSalary(System.Convert.ToSingle(searchDr["positionBasicSalary"]));
                        this._positionModel.SetAuthoId(System.Convert.ToString(searchDr["authoID"]));
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }


            }
            this.closeConnection();

            return this._positionModel;
        }

        // 修改職位資料至資料庫表單
        public Boolean EditPosition()
        {
            if (this.connectToDB())
            {
                try
                {
                    String addString = String.Format("UPDATE position SET positionName='" + this._positionModel.GetName() +
                        "',positionBasicSalary='" + this._positionModel.GetBasicSalary() + "',authoID='" + this._positionModel.GetAuthoId() + "' WHERE positionID='" + this._positionModel.GetId() +
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
