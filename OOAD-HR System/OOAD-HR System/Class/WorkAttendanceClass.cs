using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class WorkAttendanceClass
    {

        private String _emplID;
        private DateTime _waDate;
        private String _waState = null;
        private DateTime _waStartTime;
        private DateTime _waEndTime;
        private Boolean _isOverTime = false;
        private DateTime _startOvertime;
        private DateTime _endOvertime;

        // ---------------------------------------------建構子---------------------------------------------
        public WorkAttendanceClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // 設置員工ID
        public void SetWAEmplID(String emplID)
        {
            this._emplID = emplID;
        }

        // 取得員工ID
        public String GetWAEmplID()
        {
            return this._emplID;
        }

        // 設置考勤日期
        public void SetWADate(DateTime waDate)
        {
            this._waDate = waDate;
        }

        // 取得考勤日期
        public DateTime GetWADate()
        {
            return this._waDate;
        }

        // 設置考勤狀態
        public void SetWAStatus(String waStatus)
        {
            this._waState = waStatus;
        }

        // 取得考勤狀態
        public String GetWAStatus()
        {
            return this._waState;
        }

        // 設置上班時間
        public void SetStartTime(DateTime startTime)
        {
            this._waStartTime = startTime;
        }

        // 取得上班時間
        public DateTime GetStartTime()
        {
            return this._waStartTime;
        }

        // 設置下班時間
        public void SetEndTime(DateTime endTime)
        {
            this._waEndTime = endTime;
        }

        // 取得下班時間
        public DateTime GetEndTime()
        {
            return this._waEndTime;
        }

        // 設置是否加班
        public void SetIsOvertime(Boolean isOvertime)
        {
            this._isOverTime = isOvertime;
        }

        // 取得是否加班
        public Boolean GetIsOvertime()
        {
            return this._isOverTime;
        }

        // 設置加班開始時間
        public void SetStartOvertime(DateTime startOvertime)
        {
            this._startOvertime = startOvertime;
        }

        // 取得加班開始時間
        public DateTime GetStartOvertime()
        {
            return this._startOvertime;
        }

        // 設置加班結束時間
        public void SetEndOvertime(DateTime endOvertime)
        {
            this._endOvertime = endOvertime;
        }

        // 取得加班結束時間
        public DateTime GetEndOvertime()
        {
            return this._endOvertime;
        }

    }
}
