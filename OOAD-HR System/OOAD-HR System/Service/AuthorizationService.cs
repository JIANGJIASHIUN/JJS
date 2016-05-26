using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    return false;
                }
            }

            this.closeConnection();

            return true;
        }

    }
}
