using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Model
{
    public class LoginModel
    {

        private String  _account = null;
        private String  _password = null;

        // 建構子
        public LoginModel()
        {

        }

        // 設置帳號
        public void  SetAccount(String account) {
            this._account = account;
        }

        // 取得帳號
        public String GetAccount()
        {
            return this._account;
        }

        // 設置密碼
        public void SetPassword(String password)
        {
            this._password = password;
        }

        // 取得密碼
        public String GetPassword()
        {
            return this._password;
        }

    }
}
