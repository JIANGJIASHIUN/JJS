using System;
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
    public class WorkAttendanceService
    {

        private MySqlConnection myConnection = new MySqlConnection("server=csie-noip.ddns.net;user id=hrms; password=hrms; database=hrms; CharSet=utf8");
        private WorkAttendanceModel _workAttendanceModel = new WorkAttendanceModel();

        // 建構子
        public WorkAttendanceService(WorkAttendanceModel workAttendanceModel)
        {
            this._workAttendanceModel = workAttendanceModel;
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

        // 新增職位資料至資料庫表單
        public Boolean AddWorkAttendance()
        {
            if (this.connectToDB())
            {
                try
                {
                    String addString = String.Format("INSERT INTO workattendance (emplID,date,status,startworktime,endworktime,isovertime) VALUES('" +
                        this._workAttendanceModel.GetWAEmplID() + "','" + this._workAttendanceModel.GetWADate() + "','" + this._workAttendanceModel.GetWAStatus() + "','" +
                        this._workAttendanceModel.GetStartTime() + "','" + this._workAttendanceModel.GetEndTime() + "','" + this._workAttendanceModel.GetIsOvertime() + "');");
                    
                    String waStatus = this._workAttendanceModel.GetWAStatus();
                    if (waStatus == "無故未到" || waStatus == "病假" || waStatus == "婚假" || waStatus == "產假" || waStatus == "休假")
                    {
                        addString = String.Format("INSERT INTO workattendance (emplID,date,status) VALUES('" +
                        this._workAttendanceModel.GetWAEmplID() + "','" + this._workAttendanceModel.GetWADate() + "','" + this._workAttendanceModel.GetWAStatus() + "');");
                    }

                    if (this._workAttendanceModel.GetIsOvertime())
                    {
                        addString = String.Format("INSERT INTO workattendance (emplID,date,status,startworktime,endworktime,isovertime,startovertime,endovertime) VALUES('" +
                        this._workAttendanceModel.GetWAEmplID() + "','" + this._workAttendanceModel.GetWADate() + "','" + this._workAttendanceModel.GetWAStatus() + "','" +
                        this._workAttendanceModel.GetStartTime() + "','" + this._workAttendanceModel.GetEndTime() + "','" + this._workAttendanceModel.GetIsOvertime() + "','" +
                        this._workAttendanceModel.GetStartOvertime() + "','" + this._workAttendanceModel.GetEndOvertime() + "');");
                    }
                        

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
