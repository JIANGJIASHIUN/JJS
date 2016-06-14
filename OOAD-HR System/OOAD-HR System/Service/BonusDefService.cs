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

        // 根據bonus def ID搜尋該獎金定義資料
        public BonusDefModel SearchBonusDefByBonusDefID()
        {
            if (this.connectToDB())
            {
                try
                {
                    DataTable dataSet = new DataTable();

                    String searchString = String.Format("SELECT * FROM bonusdef WHERE bonusDefID = '" + this._bonusDefModel.GetBonusDefID() + "'");
                    MySqlCommand searchCommand = new MySqlCommand(searchString, myConnection);
                    searchCommand.ExecuteNonQuery();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                    adapter.Fill(dataSet);

                    foreach (DataRow searchDr in dataSet.Rows)
                    {
                        this._bonusDefModel.SetBonusDefName(searchDr["bonusName"].ToString());
                        this._bonusDefModel.SetBonusDefDesc(searchDr["bonusDescription"].ToString());
                        this._bonusDefModel.SetBonusDefCreateDate(System.Convert.ToDateTime(searchDr["bonusCreateDate"]));
                        this._bonusDefModel.SetBonusDefEffiDate(System.Convert.ToDateTime(searchDr["bonusEffiDate"]));
                        this._bonusDefModel.SetBonusDefAmount(System.Convert.ToSingle(searchDr["bonusAmount"]));
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }
            }

            this.closeConnection();

            return this._bonusDefModel;
        }

        // 修改職位資料至資料庫表單
        public Boolean EditBonusDef()
        {
            if (this.connectToDB())
            {
                try
                {
                    String addString = String.Format("UPDATE bonusdef SET bonusName='" + this._bonusDefModel.GetBonusDefName() +
                        "',bonusDescription='" + this._bonusDefModel.GetBonusDefDesc() + "',bonusCreateDate='" + this._bonusDefModel.GetBonusDefCreateDate().ToString("yy/MM/dd") +
                        "',bonusEffiDate='" + this._bonusDefModel.GetBonusDefEffiDate().ToString("yy/MM/dd") + "',bonusAmount='" + this._bonusDefModel.GetBonusDefAmount() +"' WHERE bonusDefID='" + this._bonusDefModel.GetBonusDefID() + "';");
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
