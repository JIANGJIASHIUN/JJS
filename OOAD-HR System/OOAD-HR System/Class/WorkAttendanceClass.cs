using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class WorkAttendanceClass
    {

        private DateTime _waDate;
        private DateTime _waTime;
        private String _waState;

        // ---------------------------------------------建構子---------------------------------------------
        public WorkAttendanceClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置考勤狀態---------------------------------------------
        public void setWorkState(String emplID, DateTime waDate, DateTime waTime, String waState)
        {
            this._waDate = waDate;
            this._waTime = waTime;
            this._waState = waState;
        }

        // ---------------------------------------------檢查考勤日期---------------------------------------------
        public String checkWorkState(String emplID, DateTime waDate, DateTime waTime)
        {
            return this._waState;
        } 


    }
}
