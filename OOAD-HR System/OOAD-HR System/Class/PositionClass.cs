using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class PositionClass
    {

        private String _positionID = null;
        private String _positionName = null;
        private float _positionBasicSalary;
        private String _authoID = null;

        // ---------------------------------------------建構子---------------------------------------------
        public PositionClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置id---------------------------------------------
        public void setId(String positionID, String newPositionID)
        {
            this._positionID = newPositionID;
        }

        // ---------------------------------------------取得id---------------------------------------------
        public String getId()
        {
            return this._positionID;
        }

        // ---------------------------------------------設置職稱---------------------------------------------
        public void setName(String positionID, String positionName)
        {
            this._positionName = positionName;
        }

        // ---------------------------------------------取得職稱---------------------------------------------
        public String getName(String positionID)
        {
            return this._positionName;
        }

        // ---------------------------------------------設置職位底薪---------------------------------------------
        public void setBasicSalary(String positionID, float positionBasicSalary)
        {
            this._positionBasicSalary = positionBasicSalary;
        }

        // ---------------------------------------------取得職位底薪---------------------------------------------
        public float getBasicSalary(String positionID)
        {
            return this._positionBasicSalary;
        }

        // ---------------------------------------------設置權限id---------------------------------------------
        public void setAuthoId(String positionID, String authoID)
        {
            this._authoID = authoID;
        }

        // ---------------------------------------------取得權限id---------------------------------------------
        public String getAuthoId(String positionID)
        {
            return this._authoID;
        }

    }
}
