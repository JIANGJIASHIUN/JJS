using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class CareerPlanningClass
    {

        private float _pension;
        private DateTime _insuranceBegin;
        private String _insuranceAging;
        private String _employeeInsuranceID;
        
        // ---------------------------------------------建構子---------------------------------------------
        public CareerPlanningClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置退休金---------------------------------------------
        public void setPension(String emplID, float pension)
        {
            this._pension = pension;
        }

        // ---------------------------------------------取得退休金---------------------------------------------
        public float getPension(String emplId)
        {
            return this._pension;
        }

        // ---------------------------------------------設置員工保險開始日期---------------------------------------------
        public void setInsuranceBegin(String emplID, DateTime insuranceBegin)
        {
            this._insuranceBegin = insuranceBegin;
        }

        // ---------------------------------------------取得員工保險開始日期---------------------------------------------
        public DateTime getInsuranceBegin(String emplID)
        {
            return this._insuranceBegin;
        }

        // ---------------------------------------------設置員工保險年限---------------------------------------------
        public void setInsuranceAging(String emplID, String insuranceAging)
        {
            this._insuranceAging = insuranceAging;
        }

        // ---------------------------------------------取得員工保險年限---------------------------------------------
        public String getInsuranceAging(String emplID)
        {
            return this._insuranceAging;
        }

        // ---------------------------------------------設置員工保險id---------------------------------------------
        public void setEmployeeInsuranceId(String emplID, String employeeInsuranceID)
        {
            this._employeeInsuranceID = employeeInsuranceID;
        }

        // ---------------------------------------------取得員工保險id---------------------------------------------
        public String getEmployeeInsuranceId(String emplID)
        {
            return this._employeeInsuranceID;
        }

        // ---------------------------------------------取得員工保險總額(計算應付金額)---------------------------------------------
        public float getInsuranceAmount(String emplID)
        {
            float insuranceAmount = 0;
            return insuranceAmount;
        }

    }
}
