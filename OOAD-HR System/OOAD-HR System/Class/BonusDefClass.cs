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
        private String _bonusDefName = null;
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
        public void SetId(String bonusDefID)
        {
            this._bonusDefID = bonusDefID;
        }

        // ---------------------------------------------取得獎金id---------------------------------------------
        public String GetId()
        {
            return this._bonusDefID;
        }

        // ---------------------------------------------設置獎金名稱---------------------------------------------
        public void SetName(String bonusDefName)
        {
            this._bonusDefName = bonusDefName;
        }

        // ---------------------------------------------取得獎金名稱---------------------------------------------
        public String GetName()
        {
            return this._bonusDefName;
        }

        // ---------------------------------------------設置獎金描述---------------------------------------------
        public void SetDesc(String bonusDefDesc)
        {
            this._bonusDefDesc = bonusDefDesc;
        }

        // ---------------------------------------------取得獎金描述---------------------------------------------
        public String GetDesc()
        {
            return this._bonusDefDesc;
        }

        // ---------------------------------------------設置獎金建立日期---------------------------------------------
        public void SetCreateDate(DateTime bonusDefCreateDate)
        {
            this._bonusDefCreateDate = bonusDefCreateDate;
        }

        // ---------------------------------------------取得獎金建立日期---------------------------------------------
        public DateTime GetCreateDate()
        {
            return this._bonusDefCreateDate;
        }

        // ---------------------------------------------設置獎金有效期限---------------------------------------------
        public void SetEffiTime(DateTime bonusDefEffiDate)
        {
            this._bonusDefEffiDate = bonusDefEffiDate;
        }

        // ---------------------------------------------取得獎金有效期限---------------------------------------------
        public DateTime GetEffiTime()
        {
            return this._bonusDefEffiDate;
        }

        // ---------------------------------------------設置獎金金額---------------------------------------------
        public void SetAmount(float bonusDefAmount)
        {
            this._bonusDefAmount = bonusDefAmount;
        }

        // ---------------------------------------------取得獎金金額---------------------------------------------
        public float GetAmount()
        {
            return this._bonusDefAmount;
        }

    }
}
