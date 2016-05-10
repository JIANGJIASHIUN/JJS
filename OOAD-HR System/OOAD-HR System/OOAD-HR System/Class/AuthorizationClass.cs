using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class AuthorizationClass
    {

        private String _id = null;
        private String _name = null;
        private String _value = null;

        // ---------------------------------------------建構子---------------------------------------------
        public AuthorizationClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置id---------------------------------------------
        public void setId(String authoId, String id)
        {
            this._id = id;
        }

        // ---------------------------------------------取得id---------------------------------------------
        public String getId()
        {
            return this._id;
        }

        // ---------------------------------------------設置名稱---------------------------------------------
        public void setName(String authoId, String name)
        {
            this._name = name;
        }

        // ---------------------------------------------取得名稱---------------------------------------------
        public String getName(String authoId)
        {
            return this._name;
        }

        //  ---------------------------------------------設置數值---------------------------------------------
        public void setValue(String authoId, String value)
        {
            this._value = value;
        }

        // ---------------------------------------------取得數值---------------------------------------------
        public String getValue(String authoId)
        {
            return this._value;
        }

    }
}
