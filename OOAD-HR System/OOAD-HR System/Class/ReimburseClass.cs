using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class ReimburseClass
    {

        private String _reimburseID = null;
        private String _applicantID = null;         // 申請人員工編號
        private String _reimDefID = null;
        private DateTime _applicationDate;
        private float _applicationAmount;

        // ---------------------------------------------建構子---------------------------------------------
        public ReimburseClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置報帳id---------------------------------------------
        public void setId(String reimburseID, String newReimburseID)
        {
            this._reimburseID = newReimburseID;
        }

        // ---------------------------------------------取得報帳id---------------------------------------------
        public String getId()
        {
            return this._reimburseID;
        }

        // ---------------------------------------------設置申請人員工編號---------------------------------------------
        public void setApplicantId(String reimburseID, String applicantID)
        {
            this._applicantID = applicantID;
        }

        // ---------------------------------------------取得申請人員工編號---------------------------------------------
        public String getApplicantId(String reimburseID)
        {
            return this._applicantID;
        }

        // ---------------------------------------------設置報帳定義id---------------------------------------------
        public void setReimDefId(String reimburseID, String reimDefID)
        {
            this._reimDefID = reimDefID;
        }

        // ---------------------------------------------取得報帳定義id---------------------------------------------
        public String getReimDefId(String reimburseID)
        {
            return this._reimDefID;
        }

        // ---------------------------------------------設置報帳申請日期---------------------------------------------
        public void setApplicationDate(String reimburseID, DateTime applicationDate)
        {
            this._applicationDate = applicationDate;
        }

        // ---------------------------------------------取得報帳申請日期---------------------------------------------
        public DateTime getApplicationDate(String reimburseID)
        {
            return this._applicationDate;
        }

        // ---------------------------------------------設置報帳申請金額---------------------------------------------
        public void setApplicationAmount(String reimburseID, float applicationAmount)
        {
            this._applicationAmount = applicationAmount;
        }

        // ---------------------------------------------取得報帳申請金額---------------------------------------------
        public float getApplicationAmount(String reimburseID)
        {
            return this._applicationAmount;
        }

    }
}
