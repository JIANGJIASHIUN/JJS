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
        public void  setAccount(String account) {
            this._account = account;
        }

        // 取得帳號
        public String getAccount()
        {
            return this._account;
        }

        // 設置密碼
        public void setPassword(String password)
        {
            this._password = password;
        }

        // 取得密碼
        public String getPassword()
        {
            return this._password;
        }

    }
}
