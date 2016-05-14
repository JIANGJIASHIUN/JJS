using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD_HR_System.Model;
using OOAD_HR_System.Service;
using System.Windows.Forms;

namespace OOAD_HR_System.Controller
{
    public class LoginController
    {

        private LoginModel _loginModel = new LoginModel();
        private AccountService _accountService = new AccountService();

        // 建構子
        public LoginController()
        {

        }

        // 判斷帳號密碼是否符合資料庫中的資料
        public Boolean judgeAccountAndPassword(String account, String password)
        {

            if (account == "" && password == "")
            {
                MessageBox.Show("請輸入員工ID與密碼!");
                return false;
            }
            else if (account == "")
            {
                MessageBox.Show("請輸入員工ID!");
                return false;
            }
            else if (password == "")
            {
                MessageBox.Show("請輸入密碼!");
                return false;
            }

            _loginModel = _accountService.searchByAccount(account);
            if (account == _loginModel.GetAccount() && password == _loginModel.GetPassword())
                return true;
            else
            {
                MessageBox.Show("帳號密碼錯誤!");
                return false;
            }
               
        }

    }
}
