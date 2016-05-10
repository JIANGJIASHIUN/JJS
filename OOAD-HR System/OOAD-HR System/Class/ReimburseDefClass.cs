using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class ReimburseDefClass
    {

        private String _reimDefID = null;
        private String _reimDefName = null;
        private String _reimCreaterID = null;        // 定義人的員工編號
        private float _reimDefMaxAmount;
        private DateTime _reimDefCreatDate;

        // ---------------------------------------------建構子---------------------------------------------
        public ReimburseDefClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置id---------------------------------------------
        public void setId(String reimDefID, String newReimDefID)
        {
            this._reimDefID = newReimDefID;
        }

        // ---------------------------------------------取得id---------------------------------------------
        public String getId()
        {
            return this._reimDefID;
        }

        // ---------------------------------------------設置報帳定義名稱---------------------------------------------
        public void setName(String reimDefID, String reimDefName)
        {
            this._reimDefName = reimDefName;
        }

        // ---------------------------------------------取得報帳定義名稱---------------------------------------------
        public String getName(String reimDefID)
        {
            return this._reimDefName;
        }

        // ---------------------------------------------設置定義人的員工編號---------------------------------------------
        public void setCreaterId(String reimDefID, String reimCreaterID)
        {
            this._reimCreaterID = reimCreaterID;
        }

        // ---------------------------------------------取得定義人的員工編號---------------------------------------------
        public String getCreaterId(String reimDefID)
        {
            return this._reimCreaterID;
        }

        // ---------------------------------------------設置報帳上限金額---------------------------------------------
        public void setMaxAmount(String reimDefID, float reimDefMaxAmount)
        {
            this._reimDefMaxAmount = reimDefMaxAmount;
        }

        // ---------------------------------------------取得報帳金額上限---------------------------------------------
        public float getMaxAmountt(String reimDefId)
        {
            return this._reimDefMaxAmount;
        }

        // ---------------------------------------------設置報帳定義定義日期---------------------------------------------
        public void setCreateDate(String reimDefId, DateTime createDate)
        {
            this._reimDefCreatDate = createDate;
        }

        // ---------------------------------------------取得報帳定義定義日期---------------------------------------------
        public DateTime getCreateDate(String reimDefId)
        {
            return this._reimDefCreatDate;
        }

    }
}
