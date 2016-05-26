using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD_HR_System.Class;

namespace OOAD_HR_System.Model
{
    public class AuthorizationModel
    {

        private AuthorizationClass _authorization = new AuthorizationClass();

        // 建構子
        public AuthorizationModel()
        {

        }

        // 設置ID
        public void SetAuthoID(String authoID) 
        {
            this._authorization.setId(authoID);
        }

        // 取得ID
        public String GetAuthoID()
        {
            return this._authorization.getId();
        }

        // 設置名稱
        public void SetAuthoName(String authoName)
        {
            this._authorization.setName(authoName);
        }

        // 取得名稱
        public String GetAuthoName()
        {
            return this._authorization.getName();
        }

        // 設置等級數值
        public void SetAuthoValue(String authoValue)
        {
            this._authorization.setValue(authoValue);
        }

        // 取得等級數值
        public String GetAuthoValue()
        {
            return this._authorization.getValue();
        }

    }
}
