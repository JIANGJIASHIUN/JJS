using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class TraningCourseClass
    {

        private String _courseID;
        private String _courseName;
        private String _trainerID;
        private String _trainerName;
        private DateTime _periodStart;
        private DateTime _periodEnd;

        // ---------------------------------------------建構子---------------------------------------------
        public TraningCourseClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置課程id---------------------------------------------
        public void setId(String courseID, String newCourseID)
        {
            this._courseID = newCourseID;
        }

        // ---------------------------------------------取得課程id---------------------------------------------
        public String getId()
        {
            return this._courseID;
        }

        // ---------------------------------------------設置課程名稱---------------------------------------------
        public void setName(String courseID, String courseName)
        {
            this._courseName = courseName;
        }

        // ---------------------------------------------取得課程名稱---------------------------------------------
        public String getName(String courseID)
        {
            return this._courseName;
        }

        // ---------------------------------------------設置訓練者id---------------------------------------------
        public void setTrainerId(String courseID, String trainerID)
        {
            this._trainerID = trainerID;
        }

        // ---------------------------------------------取得訓練者id---------------------------------------------
        public String getTrainerId(String courseID)
        {
            return this._trainerID;
        }

        // ---------------------------------------------設置訓練者姓名---------------------------------------------
        public void setTrainerName(String courseID, String trainerName)
        {
            this._trainerName = trainerName;
        }

        // ---------------------------------------------取得訓練者姓名---------------------------------------------
        public String getTrainerName(String courseID)
        {
            return this._trainerName;
        }

        // ---------------------------------------------設置課程開始時間---------------------------------------------
        public void setPeriodStart(String courseID, DateTime periodStart)
        {
            this._periodStart = periodStart;
        }

        // ---------------------------------------------取得課程開始時間---------------------------------------------
        public DateTime getPeriodStart(String courseID)
        {
            return this._periodStart;
        }

        // ---------------------------------------------設置課程結束時間---------------------------------------------
        public void setPeriodEnd(String courseID, DateTime periodEnd)
        {
            this._periodEnd = periodEnd;
        }

        // ---------------------------------------------取得課程結束時間---------------------------------------------
        public DateTime getPeriodEnd(String courseID)
        {
            return this._periodEnd;
        }

    }
}
