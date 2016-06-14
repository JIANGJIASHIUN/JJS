using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class BonusDefClass
    {

        private String _bonusDefID;
        private String _bonusDefName;
        private String _bonusDefDesc;
        private DateTime _bonusDefCreateDate;
        private DateTime _bonusDefEffiDate;
        private float _bonusDefAmount;

        // ---------------------------------------------建構子---------------------------------------------
        public BonusDefClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置獎金id---------------------------------------------
        public void setId(String bonusDefID)
        {
            this._bonusDefID = bonusDefID;
        }

        // ---------------------------------------------取得獎金id---------------------------------------------
        public String getId()
        {
            return this._bonusDefID;
        }

        // ---------------------------------------------設置獎金名稱---------------------------------------------
        public void setName(String bonusDefName)
        {
            this._bonusDefName = bonusDefName;
        }

        // ---------------------------------------------取得獎金名稱---------------------------------------------
        public String getName()
        {
            return this._bonusDefName;
        }

        // ---------------------------------------------設置獎金描述---------------------------------------------
        public void setDesc(String bonusDefDesc)
        {
            this._bonusDefDesc = bonusDefDesc;
        }

        // ---------------------------------------------取得獎金描述---------------------------------------------
        public String getDesc()
        {
            return this._bonusDefDesc;
        }

        // ---------------------------------------------設置獎金建立日期---------------------------------------------
        public void setCreateDate(DateTime bonusDefCreateDate)
        {
            this._bonusDefCreateDate = bonusDefCreateDate;
        }

        // ---------------------------------------------取得獎金建立日期---------------------------------------------
        public DateTime getCreateDate()
        {
            return this._bonusDefCreateDate;
        }

        // ---------------------------------------------設置獎金有效期限---------------------------------------------
        public void setEffiTime(DateTime bonusDefEffiDate)
        {
            this._bonusDefEffiDate = bonusDefEffiDate;
        }

        // ---------------------------------------------取得獎金有效期限---------------------------------------------
        public DateTime getEffiTime()
        {
            return this._bonusDefEffiDate;
        }

        // ---------------------------------------------設置獎金金額---------------------------------------------
        public void setAmount(float bonusDefAmount)
        {
            this._bonusDefAmount = bonusDefAmount;
        }

        // ---------------------------------------------取得獎金金額---------------------------------------------
        public float getAmount()
        {
            return this._bonusDefAmount;
        }

    }
}
