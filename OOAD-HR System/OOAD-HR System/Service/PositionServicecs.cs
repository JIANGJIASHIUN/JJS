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
    public class PositionServicecs
    {
        private MySqlConnection myConnection = new MySqlConnection("server=118.166.192.62;user id=hrms; password=hrms; database=hrms; CharSet=utf8");
        private PositionModel _positionModel = new PositionModel();

        public PositionServicecs(PositionModel positionModel)
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
                return false;
            }
        }

        // 關閉資料庫連線
        private void closeConnection()
        {
            myConnection.Close();
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

                }
            }

            this.closeConnection();

            return this._positionModel;
        }

    }
}
