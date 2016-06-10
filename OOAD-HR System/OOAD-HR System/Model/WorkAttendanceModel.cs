using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD_HR_System.Class;

namespace OOAD_HR_System.Model
{
    public class WorkAttendanceModel
    {

        private WorkAttendanceClass _workAttendance = new WorkAttendanceClass();

        // 建構子
        public WorkAttendanceModel()
        {

        }

        // 設置員工ID
        public void SetWAEmplID(String emplID)
        {
            this._workAttendance.SetWAEmplID(emplID);
        }

        // 取得員工ID
        public String GetWAEmplID()
        {
            return this._workAttendance.GetWAEmplID();
        }

        // 設置考勤日期
        public void SetWADate(DateTime waDate)
        {
            _workAttendance.SetWADate(waDate);
        }

        // 取得考勤日期
        public DateTime GetWADate()
        {
            return this._workAttendance.GetWADate();
        }

        // 設置考勤狀態
        public void SetWAStatus(String waStatus)
        {
            this._workAttendance.SetWAStatus(waStatus);
        }

        // 取得考勤狀態
        public String GetWAStatus()
        {
            return this._workAttendance.GetWAStatus();
        }

        // 設置上班時間
        public void SetStartTime(DateTime startTime)
        {
            this._workAttendance.SetStartTime(startTime);
        }

        // 取得上班時間
        public DateTime GetStartTime()
        {
            return this._workAttendance.GetStartTime();
        }

        // 設置下班時間
        public void SetEndTime(DateTime endTime)
        {
            this._workAttendance.SetEndTime(endTime);
        }

        // 取得下班時間
        public DateTime GetEndTime()
        {
            return this._workAttendance.GetEndTime();
        }

        // 設置是否加班
        public void SetIsOvertime(Boolean isOvertime)
        {
            this._workAttendance.SetIsOvertime(isOvertime);
        }

        // 取得是否加班
        public Boolean GetIsOvertime()
        {
            return this._workAttendance.GetIsOvertime();
        }

        // 設置加班開始時間
        public void SetStartOvertime(DateTime startOvertime)
        {
            this.SetStartOvertime(startOvertime);
        }

        // 取得加班開始時間
        public DateTime GetStartOvertime()
        {
            return this._workAttendance.GetStartOvertime();
        }

        // 設置加班結束時間
        public void SetEndOvertime(DateTime endOvertime)
        {
            this._workAttendance.SetEndOvertime(endOvertime);
        }

        // 取得加班結束時間
        public DateTime GetEndOvertime()
        {
            return this._workAttendance.GetEnOvertime();
        }

    }
}
