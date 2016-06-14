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
    public class BonusDefService
    {

        private MySqlConnection myConnection = new MySqlConnection("server=csie-noip.ddns.net;user id=hrms; password=hrms; database=hrms; CharSet=utf8");
        private BonusDefModel _bonusDefModel = new BonusDefModel();

        public BonusDefService(BonusDefModel bonusDefModel)
        {
            this._bonusDefModel = bonusDefModel;
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
        public Boolean AddBonusDef()
        {
            if (this.connectToDB())
            {
                try
                {
                    String addString = String.Format("INSERT INTO bonusdef (bonusDefID,bonusName,bonusDescription,bonusCreateDate,bonusEffiDate,bonusAmount) VALUES('" +
                        this._bonusDefModel.GetBonusDefID() + "','" + this._bonusDefModel.GetBonusDefName() + "','" + this._bonusDefModel.GetBonusDefDesc() +
                        "','" + this._bonusDefModel.GetBonusDefCreateDate().ToString("yyyy/MM/dd") + "','" + this._bonusDefModel.GetBonusDefEffiDate().ToString("yyyy/MM/dd") + "','" + this._bonusDefModel.GetBonusDefAmount() + "');");
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
