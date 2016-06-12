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
        public Boolean AddWorkAttendance()
        {
            if (this.connectToDB())
            {
                try
                {
                    String addString = String.Format("INSERT INTO workattendance (emplID,waDate,status,startworktime,endworktime,isovertime) VALUES('" +
                        this._workAttendanceModel.GetWAEmplID() + "','" + this._workAttendanceModel.GetWADate().ToString("yyyy-MM-dd") + "','" + this._workAttendanceModel.GetWAStatus() + "','" +
                        this._workAttendanceModel.GetStartTime().ToString("H:mm:ss") + "','" + this._workAttendanceModel.GetEndTime().ToString("H:mm:ss") + "','" + System.Convert.ToInt32(this._workAttendanceModel.GetIsOvertime()) + "');");
                    
                    String waStatus = this._workAttendanceModel.GetWAStatus();
                    if (waStatus == "無故未到" || waStatus == "病假" || waStatus == "婚假" || waStatus == "產假" || waStatus == "休假")
                    {
                        addString = String.Format("INSERT INTO workattendance (emplID,waDate,status) VALUES('" +
                        this._workAttendanceModel.GetWAEmplID() + "','" + this._workAttendanceModel.GetWADate().ToString("yyyy-MM-dd") + "','" + this._workAttendanceModel.GetWAStatus() + "');");
                    }

                    if (this._workAttendanceModel.GetIsOvertime())
                    {
                        addString = String.Format("INSERT INTO workattendance (emplID,waDate,status,startworktime,endworktime,isovertime,startovertime,endovertime) VALUES('" +
                        this._workAttendanceModel.GetWAEmplID() + "','" + this._workAttendanceModel.GetWADate().ToString("yyyy-MM-dd") + "','" + this._workAttendanceModel.GetWAStatus() + "','" +
                        this._workAttendanceModel.GetStartTime().ToString("H:mm:ss") + "','" + this._workAttendanceModel.GetEndTime().ToString("H:mm:ss") + "','" + System.Convert.ToInt32(this._workAttendanceModel.GetIsOvertime()) + "','" +
                        this._workAttendanceModel.GetStartOvertime().ToString("H:mm:ss") + "','" + this._workAttendanceModel.GetEndOvertime().ToString("H:mm:ss") + "');");
                    }
                        

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

        // 根據員工ID與日期搜尋該該天該員工之考勤資料
        public WorkAttendanceModel SearchWAByEmplIDAndDate()
        {
            if (this.connectToDB())
            {
                try
                {
                    DataTable dataSet = new DataTable();

                    String searchString = String.Format("SELECT * FROM workattendance WHERE emplID = '" + this._workAttendanceModel.GetWAEmplID() + "' AND waDate = '" + this._workAttendanceModel.GetWADate().ToString("yyyy-MM-dd") + "'");
                    MySqlCommand searchCommand = new MySqlCommand(searchString, myConnection);
                    searchCommand.ExecuteNonQuery();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                    adapter.Fill(dataSet);

                    foreach (DataRow searchDr in dataSet.Rows)
                    {
                        this._workAttendanceModel.SetWAStatus(searchDr["status"].ToString());
                        String waStatus = this._workAttendanceModel.GetWAStatus();
                        if (!(waStatus == "無故未到" || waStatus == "病假" || waStatus == "婚假" || waStatus == "產假" || waStatus == "休假"))
                        {
                            this._workAttendanceModel.SetStartTime(System.Convert.ToDateTime(searchDr["startworktime"]));
                            this._workAttendanceModel.SetEndTime(System.Convert.ToDateTime(searchDr["endworktime"]));
                            this._workAttendanceModel.SetIsOvertime(System.Convert.ToBoolean(searchDr["isovertime"]));

                            if (this._workAttendanceModel.GetIsOvertime())
                            {
                                this._workAttendanceModel.SetStartOvertime(System.Convert.ToDateTime(searchDr["startovertime"]));
                                this._workAttendanceModel.SetEndOvertime(System.Convert.ToDateTime(searchDr["endovertime"]));
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }
            }

            this.closeConnection();

            return this._workAttendanceModel;
        }

        // 修改考勤資料至資料庫表單
        public Boolean EditWorkAttendance()
        {
            if (this.connectToDB())
            {
                try
                {
                    String addString = String.Format("UPDATE workattendance SET status='" + this._workAttendanceModel.GetWAStatus() +
                        "',startworktime='" + this._workAttendanceModel.GetStartTime().ToString("H:mm:ss") + "',endworktime='" + this._workAttendanceModel.GetEndTime().ToString("H:mm:ss") +
                        "',isovertime='" + this._workAttendanceModel.GetIsOvertime() + "',startovertime='" + null +
                        "',endovertime='" + null + "' WHERE emplID='" + this._workAttendanceModel.GetWAEmplID() +
                        "' AND waDate='" + this._workAttendanceModel.GetWADate().ToString("yyyy-MM-dd") + "';");
                    String waStatus = this._workAttendanceModel.GetWAStatus();
                    if (waStatus == "無故未到" || waStatus == "病假" || waStatus == "婚假" || waStatus == "產假" || waStatus == "休假")
                    {
                        addString = String.Format("UPDATE workattendance SET status='" + this._workAttendanceModel.GetWAStatus() +
                        "',startworktime='" + null + "',endworktime='" + null +
                        "',isovertime='" + this._workAttendanceModel.GetIsOvertime() + "',startovertime='" + null +
                        "',endovertime='" + null + "' WHERE emplID='" + this._workAttendanceModel.GetWAEmplID() +
                        "' AND waDate='" + this._workAttendanceModel.GetWADate().ToString("yyyy-MM-dd") + "';");
                    }

                    if (this._workAttendanceModel.GetIsOvertime())
                    {
                        addString = String.Format("UPDATE workattendance SET status='" + this._workAttendanceModel.GetWAStatus() +
                        "',startworktime='" + this._workAttendanceModel.GetStartTime().ToString("H:mm:ss") + "',endworktime='" + this._workAttendanceModel.GetEndTime().ToString("H:mm:ss") +
                        "',isovertime='" + this._workAttendanceModel.GetIsOvertime() + "',startovertime='" + this._workAttendanceModel.GetStartOvertime().ToString("H:mm:ss") +
                        "',endovertime='" + this._workAttendanceModel.GetEndOvertime().ToString("H:mm:ss") + "' WHERE emplID='" + this._workAttendanceModel.GetWAEmplID() +
                        "' AND waDate='" + this._workAttendanceModel.GetWADate().ToString("yyyy-MM-dd") + "';");
                    }
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
