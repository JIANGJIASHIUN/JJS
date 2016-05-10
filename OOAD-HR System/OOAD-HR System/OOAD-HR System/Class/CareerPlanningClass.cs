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
        private DateTime _insuranceDate;
        private String _insuranceAging;
        private String _employeeInsuranceId;
        
        // ---------------------------------------------建構子---------------------------------------------
        public CareerPlanningClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置退休金---------------------------------------------
        public void setPension(String emplId, float pension)
        {
            this._pension = pension;
        }

        // ---------------------------------------------取得退休金---------------------------------------------
        public float getPension(String emplId)
        {
            return this._pension;
        }

        // ---------------------------------------------設置員工保險日期---------------------------------------------
        public void setInsuranceDate(String emplId, DateTime insuranceDate)
        {
            this._insuranceDate = insuranceDate;
        }

        // ---------------------------------------------取得員工保險日期---------------------------------------------
        public DateTime getInsuranceDate(String emplId)
        {
            return this._insuranceDate;
        }

        // ---------------------------------------------設置員工保險年限---------------------------------------------
        public void setInsuranceAging(String emplId, String insuranceAging)
        {
            this._insuranceAging = insuranceAging;
        }

        // ---------------------------------------------取得員工保險年限---------------------------------------------
        public String getInsuranceAging(String emplId)
        {
            return this._insuranceAging;
        }

        // ---------------------------------------------設置員工保險id---------------------------------------------
        public void setEmployeeInsuranceId(String emplId, String employeeInsuranceId)
        {
            this._employeeInsuranceId = employeeInsuranceId;
        }

        // ---------------------------------------------取得員工保險id---------------------------------------------
        public String getEmployeeInsuranceId(String emplId)
        {
            return this._employeeInsuranceId;
        }

        // ---------------------------------------------取得員工保險總額(計算應付金額)---------------------------------------------
        public float getInsuranceAmount(String emplId)
        {
            float insuranceAmount = 0;
            return insuranceAmount;
        }

    }
}
