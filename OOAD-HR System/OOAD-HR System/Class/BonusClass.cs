using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class BonusClass
    {
        private String _emplID;
        private DateTime _bonusDate;
        private String _bonusT;             // 期別
        private String _bonusDefID;

        // ---------------------------------------------建構子---------------------------------------------
        public BonusClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // 設置bonus def id
        public void SetBonusDefID(String bonusDefID)
        {
            this._bonusDefID = bonusDefID;
        }

        // 取得bonus def id
        public String GetBonusDefID()
        {
            return this._bonusDefID;
        }

        // 設置empl id
        public void SetEmplID(String emplID)
        {
            this._emplID = emplID;
        }

        // 取得empl id
        public String GetEmplID()
        {
            return this._emplID;
        }

        // 設置add bonus date
        public void SetBonusDate(DateTime bonusDate)
        {
            this._bonusDate = bonusDate;
        }

        // 取得add bonus date
        public DateTime GetBonusDate()
        {
            return this._bonusDate;
        }

        // 設置獎金期別
        public void SetBonusT(String bonusT)
        {
            this._bonusT = bonusT;
        }

        // 取得獎金期別
        public String GetBonusT()
        {
            return this._bonusT;
        }
    }
}
