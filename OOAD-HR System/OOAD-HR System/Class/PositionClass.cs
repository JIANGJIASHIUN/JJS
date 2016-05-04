using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    class PositionClass
    {

        String _id = null;
        String _name = null;
        float _basicSalary;
        String _authoId = null;

        // ---------------------------------------------建構子---------------------------------------------
        PositionClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置id---------------------------------------------
        void setId(String positionId, String id)
        {
            this._id = id;
        }

        // ---------------------------------------------取得id---------------------------------------------
        String getId()
        {
            return this._id;
        }

        // ---------------------------------------------設置職稱---------------------------------------------
        void setName(String positionId, String name)
        {
            this._name = name;
        }

        // ---------------------------------------------取得職稱---------------------------------------------
        String getName(String positionId)
        {
            return this._name;
        }

        // ---------------------------------------------設置職位底薪---------------------------------------------
        void setBasicSalary(String positionId, float basicSalary)
        {
            this._basicSalary = basicSalary;
        }

        // ---------------------------------------------取得職位底薪---------------------------------------------
        float getBasicSalary(String positionId)
        {
            return this._basicSalary;
        }

        // ---------------------------------------------設置權限id---------------------------------------------
        void setAuthoId(String positionId, String authoId)
        {
            this._authoId = authoId;
        }

        // ---------------------------------------------取得權限id---------------------------------------------
        String getAuthoId(String positionId)
        {
            return this._authoId;
        }

    }
}
