using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class ReimburseDefClass
    {

        private String _id = null;
        private String _name = null;
        private String _createrId = null;        // 定義人的員工編號
        private float _maxAmount;
        private DateTime _creatDate;

        // ---------------------------------------------建構子---------------------------------------------
        public ReimburseDefClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置id---------------------------------------------
        public void setId(String reimDefId, String id)
        {
            this._id = id;
        }

        // ---------------------------------------------取得id---------------------------------------------
        public String getId()
        {
            return this._id;
        }

        // ---------------------------------------------設置報帳定義名稱---------------------------------------------
        public void setName(String reimDefId, String name)
        {
            this._name = name;
        }

        // ---------------------------------------------取得報帳定義名稱---------------------------------------------
        public String getName(String reimDefId)
        {
            return this._name;
        }

        // ---------------------------------------------設置定義人的員工編號---------------------------------------------
        public void setCreaterId(String reimDefId, String createrId)
        {
            this._createrId = createrId;
        }

        // ---------------------------------------------取得定義人的員工編號---------------------------------------------
        public String getCreaterId(String reimDefId)
        {
            return this._createrId;
        }

        // ---------------------------------------------設置報帳上限金額---------------------------------------------
        public void setMaxAmount(String reimDefId, float maxAmount)
        {
            this._maxAmount = maxAmount;
        }

        // ---------------------------------------------取得報帳金額上限---------------------------------------------
        public float getMaxAmountt(String reimDefId)
        {
            return this._maxAmount;
        }

        // ---------------------------------------------設置報帳定義定義日期---------------------------------------------
        public void setCreateDate(String reimDefId, DateTime createDate)
        {
            this._creatDate = createDate;
        }

        // ---------------------------------------------取得報帳定義定義日期---------------------------------------------
        public DateTime getCreateDate(String reimDefId)
        {
            return this._creatDate;
        }

    }
}
