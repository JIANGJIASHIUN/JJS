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
        private DateTime _bonusDefCreateDate;
        private String _bonusDefEffiTime;
        private float _bonusDefAmount;

        // ---------------------------------------------建構子---------------------------------------------
        public BonusDefClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置獎金id---------------------------------------------
        public void setId(String bonusDefID, String newBonusDefID)
        {
            this._bonusDefID = newBonusDefID;
        }

        // ---------------------------------------------取得獎金id---------------------------------------------
        public String getId()
        {
            return this._bonusDefID;
        }

        // ---------------------------------------------設置獎金名稱---------------------------------------------
        public void setName(String bonusDefId, String bonusDefName)
        {
            this._bonusDefName = bonusDefName;
        }

        // ---------------------------------------------取得獎金名稱---------------------------------------------
        public String getName(String bonusDefId)
        {
            return this._bonusDefName;
        }

        // ---------------------------------------------設置獎金建立日期---------------------------------------------
        public void setCreateDate(String bonusDefId, DateTime bonusDefCreateDate)
        {
            this._bonusDefCreateDate = bonusDefCreateDate;
        }

        // ---------------------------------------------取得獎金建立日期---------------------------------------------
        public DateTime getCreateDate(String bonusDefID)
        {
            return this._bonusDefCreateDate;
        }

        // ---------------------------------------------設置獎金有效期限---------------------------------------------
        public void setEffiTime(String bonusDefID, String bonusDefEffiTime)
        {
            this._bonusDefEffiTime = bonusDefEffiTime;
        }

        // ---------------------------------------------取得獎金有效期限---------------------------------------------
        public String getEffiTime(String bonusDefID)
        {
            return this._bonusDefEffiTime;
        }

        // ---------------------------------------------設置獎金金額---------------------------------------------
        public void setAmount(String bonusDefID, float bonusDefAmount)
        {
            this._bonusDefAmount = bonusDefAmount;
        }

        // ---------------------------------------------取得獎金金額---------------------------------------------
        public float getAmount(String bonusDefID)
        {
            return this._bonusDefAmount;
        }

    }
}
