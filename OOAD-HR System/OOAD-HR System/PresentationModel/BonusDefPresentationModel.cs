using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD_HR_System.Class;

namespace OOAD_HR_System.PresentationModel
{
    public class BonusDefPresentationModel
    {

        private BonusDefClass _bonusDef = new BonusDefClass();

        // 建構子
        public BonusDefPresentationModel()
        {

        }

        // 設置bonus def ID
        public void SetBonusDefID(String bonusDefID)
        {
            this._bonusDef.setId(bonusDefID);
        }

        // 取得bonus def ID
        public String GetBonusDefID()
        {
            return this._bonusDef.getId();
        }

        // 設置bonus def name
        public void SetBonusDefName(String bonusDefName)
        {
            this._bonusDef.setName(bonusDefName);
        }

        // 取得bonus def name
        public String GetBonusDefName()
        {
            return this._bonusDef.getName();
        }

        // 設置bonus def描述
        public void SetBonusDefDesc(String bonusDefDesc)
        {
            this._bonusDef.setDesc(bonusDefDesc);
        }

        // 取得bonus def描述
        public String GetBonusDefDesc()
        {
            return this._bonusDef.getDesc();
        }

        // 設置bonus create date
        public void SetBonusDefCreateDate(DateTime bonusDefCreateDate)
        {
            this._bonusDef.setCreateDate(bonusDefCreateDate);
        } 

        // 取得bonus create date
        public DateTime GetBonusDefCreateDate()
        {
            return this._bonusDef.getCreateDate();
        }

        // 設置bonus effi date
        public void SetBonusDefEffiDate(DateTime bonusDefEffiDate)
        {
            this._bonusDef.setEffiTime(bonusDefEffiDate);
        }

        // 取得bonus effi date
        public DateTime GetBonusDefEffiDate()
        {
            return this._bonusDef.getEffiTime();
        }

        // 設置bonus def amount
        public void SetBonusDefAmount(float bonusDefAmount)
        {
            this._bonusDef.setAmount(bonusDefAmount);
        }

        // 取得bonus def amount
        public float GetBonusDefAmount()
        {
            return this._bonusDef.getAmount();
        }

    }
}
