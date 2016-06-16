using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD_HR_System.Class;

namespace OOAD_HR_System.PresentationModel
{
    public class AuthorizationPresentationModel
    {

        private AuthorizationClass _authorization = new AuthorizationClass();

        // 建構子
        public AuthorizationPresentationModel()
        {

        }

        // 設置ID
        public void SetAuthoID(String authoID) 
        {
            this._authorization.SetId(authoID);
        }

        // 取得ID
        public String GetAuthoID()
        {
            return this._authorization.GetId();
        }

        // 設置名稱
        public void SetAuthoName(String authoName)
        {
            this._authorization.SetName(authoName);
        }

        // 取得名稱
        public String GetAuthoName()
        {
            return this._authorization.GetName();
        }

        // 設置等級數值
        public void SetAuthoValue(String authoValue)
        {
            this._authorization.SetValue(authoValue);
        }

        // 取得等級數值
        public String GetAuthoValue()
        {
            return this._authorization.GetValue();
        }

    }
}
