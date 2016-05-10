using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class TraningClass
    {

        private String _courseID;
        private String _completeState;

         // ---------------------------------------------建構子---------------------------------------------
        public TraningClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置員工培訓課程---------------------------------------------
        public void setTraning(String courseID, String emplID, String state)
        {
            this._courseID = courseID;
            this._completeState = state;
        }

        //---------------------------------------------根據couese id取得員工培訓狀態---------------------------------------------
        public String getTraningByCourseID(String courseID)
        {
            // 應回傳員工id與state
            return this._completeState;
        }

        // ---------------------------------------------根據員工編號取得該員工培訓課程---------------------------------------------
        public String getTraingByEmplId(String emplID)
        {
            // 應回傳課程資訊
            return this._courseID;
        }

    }
}
