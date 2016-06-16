using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD_HR_System.Class;

namespace OOAD_HR_System.Model
{
    public class BonusDefModel
    {

        private BonusDefClass _bonusDef = new BonusDefClass();

        // 建構子
        public BonusDefModel()
        {

        }

        // 設置bonus def ID
        public void SetBonusDefID(String bonusDefID)
        {
            this._bonusDef.SetId(bonusDefID);
        }

        // 取得bonus def ID
        public String GetBonusDefID()
        {
            return this._bonusDef.GetId();
        }

        // 設置bonus def name
        public void SetBonusDefName(String bonusDefName)
        {
            this._bonusDef.SetName(bonusDefName);
        }

        // 取得bonus def name
        public String GetBonusDefName()
        {
            return this._bonusDef.GetName();
        }

        // 設置bonus def描述
        public void SetBonusDefDesc(String bonusDefDesc)
        {
            this._bonusDef.SetDesc(bonusDefDesc);
        }

        // 取得bonus def描述
        public String GetBonusDefDesc()
        {
            return this._bonusDef.GetDesc();
        }

        // 設置bonus create date
        public void SetBonusDefCreateDate(DateTime bonusDefCreateDate)
        {
            this._bonusDef.SetCreateDate(bonusDefCreateDate);
        } 

        // 取得bonus create date
        public DateTime GetBonusDefCreateDate()
        {
            return this._bonusDef.GetCreateDate();
        }

        // 設置bonus effi date
        public void SetBonusDefEffiDate(DateTime bonusDefEffiDate)
        {
            this._bonusDef.SetEffiTime(bonusDefEffiDate);
        }

        // 取得bonus effi date
        public DateTime GetBonusDefEffiDate()
        {
            return this._bonusDef.GetEffiTime();
        }

        // 設置bonus def amount
        public void SetBonusDefAmount(float bonusDefAmount)
        {
            this._bonusDef.SetAmount(bonusDefAmount);
        }

        // 取得bonus def amount
        public float GetBonusDefAmount()
        {
            return this._bonusDef.GetAmount();
        }

    }
}
