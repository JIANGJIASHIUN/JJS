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
    public class AuthorizationService
    {
        private MySqlConnection myConnection = new MySqlConnection("server=csie-noip.ddns.net;user id=hrms; password=hrms; database=hrms; CharSet=utf8");
        private AuthorizationModel _authoModel = new AuthorizationModel();

        // 建構子
        public AuthorizationService(AuthorizationModel authoModel)
        {
            this._authoModel = authoModel;
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

        // 新增權限資料至資料庫表單
        public Boolean AddAuthorization()
        {
            if (this.connectToDB())
            {
                try
                {
                    String addString = String.Format("INSERT INTO authorization(authoID,authoName,authoValue) VALUES('" +
                        this._authoModel.GetAuthoID() + "','" + this._authoModel.GetAuthoName() + "','" + this._authoModel.GetAuthoValue() + "');");
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

        // 修改權限資料至資料庫表單
        public Boolean EditAuthorization()
        {
            if(this.connectToDB())
            {
                try
                {
                    String addString = String.Format("UPDATE authorization SET authoName='" + this._authoModel.GetAuthoName() + 
                        "',authoValue='" + this._authoModel.GetAuthoValue() + "' WHERE authoID='" + this._authoModel.GetAuthoID() + 
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

        // 以輸入權限ID搜尋權限資料
        public AuthorizationModel searchByAuthoID()
        {
            if (this.connectToDB())
            {
                try
                {
                    DataTable dataSet = new DataTable();

                    String searchString = String.Format("SELECT * FROM authorization WHERE authoID = '" + this._authoModel.GetAuthoID() + "'");
                    MySqlCommand searchCommand = new MySqlCommand(searchString, myConnection);
                    searchCommand.ExecuteNonQuery();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                    adapter.Fill(dataSet);

                    foreach (DataRow searchDr in dataSet.Rows)
                    {
                        _authoModel.SetAuthoName( searchDr["authoName"].ToString());
                        _authoModel.SetAuthoValue( searchDr["authoValue"].ToString());
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }

                
            }
            this.closeConnection();

            return this._authoModel;
        }

    }
}
