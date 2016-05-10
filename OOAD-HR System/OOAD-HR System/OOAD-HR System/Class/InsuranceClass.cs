using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class InsuranceClass
    {

        private String _id = null;
        private String _category = null;

        // ---------------------------------------------建構子---------------------------------------------
        public InsuranceClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置保險id---------------------------------------------
        public void setId(String insuranceId, String id)
        {
            this._id = id;
        }

        // ---------------------------------------------取得保險id---------------------------------------------
        public String getId()
        {
            return this._id;
        }

        // ---------------------------------------------設置保險種類---------------------------------------------
        public void setCategory(String insusranceId, String category)
        {
            this._category = category;
        }

        // ---------------------------------------------取得保險種類---------------------------------------------
        public String getCategory(String insuranceId)
        {
            return this._category;
        }

    }
}
