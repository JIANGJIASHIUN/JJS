using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    class InsuranceClass
    {

        String _id = null;
        String _category = null;

        // ---------------------------------------------建構子---------------------------------------------
        InsuranceClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置保險id---------------------------------------------
        void setId(String insuranceId, String id)
        {
            this._id = id;
        }

        // ---------------------------------------------取得保險id---------------------------------------------
        String getId()
        {
            return this._id;
        }

        // ---------------------------------------------設置保險種類---------------------------------------------
        void setCategory(String insusranceId, String category)
        {
            this._category = category;
        }

        // ---------------------------------------------取得保險種類---------------------------------------------
        String getCategory(String insuranceId)
        {
            return this._category;
        }

    }
}
