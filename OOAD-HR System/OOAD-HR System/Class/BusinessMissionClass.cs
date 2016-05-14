using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class BusinessMissionClass
    {

        private String _bmID;
        private DateTime _bmDate;
        private DateTime _bmTime;
        private String _bmReason;
        private Boolean _bmRatify;

        // ---------------------------------------------建構子---------------------------------------------
        public BusinessMissionClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置差勤單id---------------------------------------------
        public void setId(String bmID, String newBmID)
        {
            this._bmID = newBmID;
        }

        // ---------------------------------------------取得差勤單id---------------------------------------------
        public String getId()
        {
            return this._bmID;
        }

        // ---------------------------------------------設置差勤單日期---------------------------------------------
        public void setDate(DateTime bmDate)
        {
            this._bmDate = bmDate;
        }

        // ---------------------------------------------取得差勤單日期---------------------------------------------
        public DateTime getDate(String bmId)
        {
            return this._bmDate;
        }

        // ---------------------------------------------設置差勤單時間---------------------------------------------
        public void setTime(String bmId, DateTime bmTime)
        {
            this._bmTime = bmTime;
        }

        // ---------------------------------------------取得差勤單時間---------------------------------------------
        public DateTime getTime(String bmID)
        {
            return this._bmTime;
        }

        // ---------------------------------------------設置差勤單緣由---------------------------------------------
        public void setReason(String bmId, String bmReason)
        {
            this._bmReason = bmReason;
        }

        // ---------------------------------------------取得差勤單緣由---------------------------------------------
        public String getReason(String bmID)
        {
            return this._bmReason;
        }

        // ---------------------------------------------設置差勤單批准狀態---------------------------------------------
        public void setRatify(String bmId, Boolean bmRatify)
        {
            this._bmRatify = bmRatify;
        }

        // ---------------------------------------------取得差勤單批准狀態---------------------------------------------
        public Boolean getRatify(String bmID)
        {
            return this._bmRatify;
        }

        // ---------------------------------------------取得該員工填寫之差勤單---------------------------------------------
        // 暫時先不寫, 可能還需要討論

    }
}
