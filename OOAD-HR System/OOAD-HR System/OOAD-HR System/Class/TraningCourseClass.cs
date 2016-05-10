using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class TraningCourseClass
    {

        private String _id;
        private String _name;
        private String _trainerId;
        private String _trainerName;
        private DateTime _periodStart;
        private DateTime _periodEnd;

        // ---------------------------------------------建構子---------------------------------------------
        public TraningCourseClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置課程id---------------------------------------------
        public void setId(String courseId, String id)
        {
            this._id = id;
        }

        // ---------------------------------------------取得課程id---------------------------------------------
        public String getId()
        {
            return this._id;
        }

        // ---------------------------------------------設置課程名稱---------------------------------------------
        public void setName(String courseId, String name)
        {
            this._name = name;
        }

        // ---------------------------------------------取得課程名稱---------------------------------------------
        public String getName(String courseId)
        {
            return this._name;
        }

        // ---------------------------------------------設置訓練者id---------------------------------------------
        public void setTrainerId(String courseId, String trainerId)
        {
            this._trainerId = trainerId;
        }

        // ---------------------------------------------取得訓練者id---------------------------------------------
        public String getTrainerId(String courseId)
        {
            return this._trainerId;
        }

        // ---------------------------------------------設置訓練者姓名---------------------------------------------
        public void setTrainerName(String courseId, String trainerName)
        {
            this._trainerName = trainerName;
        }

        // ---------------------------------------------取得訓練者姓名---------------------------------------------
        public String getTrainerName(String courseId)
        {
            return this._trainerName;
        }

        // ---------------------------------------------設置課程開始時間---------------------------------------------
        public void setPeriodStart(String courseId, DateTime periodStart)
        {
            this._periodStart = periodStart;
        }

        // ---------------------------------------------取得課程開始時間---------------------------------------------
        public DateTime getPeriodStart(String courseId)
        {
            return this._periodStart;
        }

        // ---------------------------------------------設置課程結束時間---------------------------------------------
        public void setPeriodEnd(String courseId, DateTime periodEnd)
        {
            this._periodEnd = periodEnd;
        }

        // ---------------------------------------------取得課程結束時間---------------------------------------------
        public DateTime getPeriodEnd(String courseId)
        {
            return this._periodEnd;
        }

    }
}
