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
    public class BonusService
    {

        private MySqlConnection myConnection = new MySqlConnection("server=csie-noip.ddns.net;user id=hrms; password=hrms; database=hrms; CharSet=utf8");
        private BonusModel _bonusModel = new BonusModel();

        public BonusService(BonusModel bonusModel)
        {
            this._bonusModel = bonusModel;
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

        // 新增員工獎金資料至資料庫表單
        public Boolean AddBonus()
        {
            if (this.connectToDB())
            {
                try
                {
                    String addString = String.Format("INSERT INTO bonus (bonusDefID,emplID,bonusDate,bonusT) VALUES('" +
                        this._bonusModel.GetBonusDefID() + "','" + this._bonusModel.GetEmplID() + "','" + this._bonusModel.GetBonusDate().ToString("yy/MM/dd") +
                        "','" + this._bonusModel.GetBonusT() + "');");
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
