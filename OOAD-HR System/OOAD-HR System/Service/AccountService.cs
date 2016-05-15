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

        private MySqlConnection myConnection = new MySqlConnection("server=118.166.192.62;user id=hrms; password=hrms; database=hrms; CharSet=utf8");
        private LoginModel _loginModel = new LoginModel();

        public AccountService()
        {

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
                return false;
            }
        }

        // 關閉資料庫連線
        private void closeConnection()
        {
            myConnection.Close();
        }

        // 以輸入員工ID搜尋帳號密碼
        public LoginModel searchByAccount(String account)
        {
            if (this.connectToDB())
            {
                try {
                    DataTable dataSet = new DataTable();

                    String searchString = String.Format("SELECT * FROM account WHERE account = '" + account + "'");
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
                    
                }
            }

            this.closeConnection();

            return this._loginModel;
        }

    }
}
