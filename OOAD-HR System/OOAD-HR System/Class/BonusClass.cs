using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class BonusClass
    {

        private DateTime _bonusY;
        private DateTime _bonusMN;
        private int _bonusT;             // 期別
        private String _bonusDefID;

        // ---------------------------------------------建構子---------------------------------------------
        public BonusClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置員工獎金---------------------------------------------
        public void setBonus(String emplID, String bonusDefID)
        {
            this._bonusDefID = bonusDefID;
        }

        // ---------------------------------------------移除員工獎金---------------------------------------------
        public void removeBonus(String emplID, String bonusDefID)
        {

        }

        // ---------------------------------------------計算員工獎金---------------------------------------------
        public float computeBonus(String emplID)
        {
            float totalBonus = 0;
            return totalBonus;
        }

    }
}
