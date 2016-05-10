using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class InsuranceClass
    {

        private String _insuranceID = null;
        private String _insuranceCategory = null;

        // ---------------------------------------------建構子---------------------------------------------
        public InsuranceClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置保險id---------------------------------------------
        public void setId(String insuranceID, String newInsuranceID)
        {
            this._insuranceID = newInsuranceID;
        }

        // ---------------------------------------------取得保險id---------------------------------------------
        public String getId()
        {
            return this._insuranceID;
        }

        // ---------------------------------------------設置保險種類---------------------------------------------
        public void setCategory(String insusranceID, String insuranceCategory)
        {
            this._insuranceCategory = insuranceCategory;
        }

        // ---------------------------------------------取得保險種類---------------------------------------------
        public String getCategory(String insuranceID)
        {
            return this._insuranceCategory;
        }

    }
}
