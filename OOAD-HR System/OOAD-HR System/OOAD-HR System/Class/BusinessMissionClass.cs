using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class BusinessMissionClass
    {

        private String _id;
        private DateTime _date;
        private DateTime _time;
        private String _reason;
        private Boolean _ratify;

        // ---------------------------------------------建構子---------------------------------------------
        public BusinessMissionClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置差勤單id---------------------------------------------
        public void setId(String bmId, String id)
        {
            this._id = id;
        }

        // ---------------------------------------------取得差勤單id---------------------------------------------
        public String getId()
        {
            return this._id;
        }

        // ---------------------------------------------設置差勤單日期---------------------------------------------
        public void setDate(DateTime date)
        {
            this._date = date;
        }

        // ---------------------------------------------取得差勤單日期---------------------------------------------
        public DateTime getDate(String bmId)
        {
            return this._date;
        }

        // ---------------------------------------------設置差勤單時間---------------------------------------------
        public void setTime(String bmId, DateTime time)
        {
            this._time = time;
        }

        // ---------------------------------------------取得差勤單時間---------------------------------------------
        public DateTime getTime(String bmId)
        {
            return this._time;
        }

        // ---------------------------------------------設置差勤單緣由---------------------------------------------
        public void setReason(String bmId, String reason)
        {
            this._reason = reason;
        }

        // ---------------------------------------------取得差勤單緣由---------------------------------------------
        public String getReason(String bmId)
        {
            return this._reason;
        }

        // ---------------------------------------------設置差勤單批准狀態---------------------------------------------
        public void setRatify(String bmId, Boolean ratify)
        {
            this._ratify = ratify;
        }

        // ---------------------------------------------取得差勤單批准狀態---------------------------------------------
        public Boolean getRatify(String bmId)
        {
            return this._ratify;
        }

        // ---------------------------------------------取得該員工填寫之差勤單---------------------------------------------
        // 暫時先不寫, 可能還需要討論

    }
}
