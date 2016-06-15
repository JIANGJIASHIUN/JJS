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
    public class AccountService
    {

        private MySqlConnection myConnection = new MySqlConnection("server=csie-noip.ddns.net;user id=hrms; password=hrms; database=hrms; CharSet=utf8");
        private LoginModel _loginModel = new LoginModel();
        private String _account;
        private String _password;

        public AccountService(String account, String password)
        {
            this._account = account;
            this._password = password;
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

        // 新增帳號至資料庫表單
        public Boolean AddAccount()
        {
            if (this.connectToDB())
            {
                try
                {
                    String addString = String.Format("INSERT INTO account (account,password) VALUES('" +
                        this._account + "','" + this._password + "');");
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

        // 以輸入員工ID搜尋帳號密碼
        public LoginModel searchByAccount()
        {
            if (this.connectToDB())
            {
                try {
                    DataTable dataSet = new DataTable();

                    String searchString = String.Format("SELECT * FROM account WHERE account = '" + _account + "'");
                    MySqlCommand searchCommand = new MySqlCommand(searchString, myConnection);
                    searchCommand.ExecuteNonQuery();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                    adapter.Fill(dataSet);

                    foreach (DataRow searchDr in dataSet.Rows)
                    {
                        _loginModel.SetAccount(searchDr["account"].ToString());
                        _loginModel.SetPassword(searchDr["password"].ToString());
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }
            }

            this.closeConnection();

            return this._loginModel;
        }

    }
}
