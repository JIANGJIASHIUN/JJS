using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class AuthorizationClass
    {

        private String _authoID = null;
        private String _authoName = null;
        private String _authoValue = null;

        // ---------------------------------------------建構子---------------------------------------------
        public AuthorizationClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置id---------------------------------------------
        public void SetId(String newAuthodID)
        {
            this._authoID = newAuthodID;
        }

        // ---------------------------------------------取得id---------------------------------------------
        public String GetId()
        {
            return this._authoID;
        }

        // ---------------------------------------------設置名稱---------------------------------------------
        public void SetName(String authoName)
        {
            this._authoName = authoName;
        }

        // ---------------------------------------------取得名稱---------------------------------------------
        public String GetName()
        {
            return this._authoName;
        }

        //  ---------------------------------------------設置數值---------------------------------------------
        public void SetValue(String authoValue)
        {
            this._authoValue = authoValue;
        }

        // ---------------------------------------------取得數值---------------------------------------------
        public String GetValue()
        {
            return this._authoValue;
        }

    }
}
