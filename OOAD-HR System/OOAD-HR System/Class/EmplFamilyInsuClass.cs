using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    class EmplFamilyInsuClass
    {

        String _emplId;                 // 員工編號(用於確認該家屬為哪個員工之家屬)
        String _eFName;
        String _eFInsuranceId;
        DateTime _eFInsuranceBegin;
        String _eFInsuranceAging;

        // ---------------------------------------------建構子---------------------------------------------
        EmplFamilyInsuClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置員工編號---------------------------------------------
        void setEmplId(String emplId)
        {
            this._emplId = emplId;
        }

        // ---------------------------------------------取得員工編號---------------------------------------------
        String getEmplId()
        {
            return this._emplId;
        }

        // ---------------------------------------------設置家屬性名---------------------------------------------
        void setEFName(String emplId, String eFName)
        {
            this._eFName = eFName;
        }

        // ---------------------------------------------取得家屬姓名---------------------------------------------
        String getEFName(String emplId)
        {
            return this._eFName;
        }

        // ---------------------------------------------設置家屬保險id---------------------------------------------
        void setEFInsuranceId(String emplId, String eFInsuranceId)
        {
            this._eFInsuranceId = eFInsuranceId;
        }

        // ---------------------------------------------取得家屬保險id---------------------------------------------
        String getEFInsurance(String emplId)
        {
            return this._eFInsuranceId;
        }

        // ---------------------------------------------設置家屬保險開始日期---------------------------------------------
        void setEFInsuranceBegin(String emplId, DateTime eFInsuranceBegin)
        {
            this._eFInsuranceBegin = eFInsuranceBegin;
        }

        // ---------------------------------------------取得家屬保險開始日期---------------------------------------------
        DateTime getEFInsuranceBegin(String emplId)
        {
            return this._eFInsuranceBegin;
        }

        // ---------------------------------------------設置家屬保險年限---------------------------------------------
        void setEFInsuranceAging(String emplId, String eFInsuranceAging)
        {
            this._eFInsuranceAging = eFInsuranceAging;
        }

        // ---------------------------------------------取得家屬保險年限---------------------------------------------
        String getEFInsuranceAging(String emplId)
        {
            return this._eFInsuranceAging;
        }

    }
}
