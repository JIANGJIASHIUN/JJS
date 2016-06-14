using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD_HR_System.Class;

namespace OOAD_HR_System.Model
{
    public class BonusModel
    {

        private BonusClass _bonus = new BonusClass();

        // 建構子
        public BonusModel()
        {

        }

        // 設置bonus def id
        public void SetBonusDefID(String bonusDefID)
        {
            this._bonus.SetBonusDefID(bonusDefID);
        }

        // 取得bonus def id
        public String GetBonusDefID()
        {
            return this._bonus.GetBonusDefID();
        }

        // 設置empl id
        public void SetEmplID(String emplID)
        {
            this._bonus.SetEmplID(emplID);
        }

        // 取得empl id
        public String GetEmplID()
        {
            return this._bonus.GetEmplID();
        }

        // 設置bonus date
        public void SetBonusDate(DateTime bonusDate) {
            this._bonus.SetBonusDate(bonusDate);
        }

        // 取得bonus date
        public DateTime GetBonusDate()
        {
            return this._bonus.GetBonusDate();
        }

        // 設置獎金期別
        public void SetBonusT(String bonusT)
        {
            this._bonus.SetBonusT(bonusT);
        }

        // 取得獎金期別
        public String GetBonusT()
        {
            return this._bonus.GetBonusT();
        }

    }
}
