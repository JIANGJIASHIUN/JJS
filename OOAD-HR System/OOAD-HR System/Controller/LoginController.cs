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
        private AccountService _accountService;

        // 建構子
        public LoginController()
        {

        }

        // 判斷帳號密碼是否符合資料庫中的資料
        public int judgeAccountAndPassword(String account, String password)
        {

            if (account == "" && password == "")
            {
                MessageBox.Show("請輸入員工ID與密碼!");
                return -1;
            }
            else if (account == "")
            {
                MessageBox.Show("請輸入員工ID!");
                return -1;
            }
            else if (password == "")
            {
                MessageBox.Show("請輸入密碼!");
                return -1;
            }

            _accountService = new AccountService(account, password);
            _loginModel = _accountService.searchByAccount();
            if (account == _loginModel.GetAccount() && password == _loginModel.GetPassword())
            {
                EmployeeModel emplModel = new EmployeeModel();
                emplModel.SetEmplID(account);
                EmployeeService emplService = new EmployeeService(emplModel);
                emplModel = emplService.searchByEmplID();

                if (!(emplModel.GetPositionID() == null || emplModel.GetPositionID() == ""))
                {
                    PositionModel positionModel = new PositionModel();
                    positionModel.SetId(emplModel.GetPositionID());
                    PositionService positionService = new PositionService(positionModel);

                    positionModel = positionService.searchByPositionID();

                    if (!(positionModel.GetAuthoId() == null || positionModel.GetAuthoId() == "")) 
                    {
                        AuthorizationModel authoModel = new AuthorizationModel();
                        authoModel.SetAuthoID(positionModel.GetAuthoId());
                        AuthorizationService authoService = new AuthorizationService(authoModel);

                        authoModel = authoService.searchByAuthoID();

                        // > 0 管理介面
                        // = 0 員工介面
                        if (!(authoModel.GetAuthoName() == null || authoModel.GetAuthoName() == ""))
                        {
                            return System.Convert.ToInt32(authoModel.GetAuthoValue());
                        }
                        else
                            return -1;
                    }
                    else
                        return -1;
                }
                else
                    return -1;
            }   
            else
            {
                MessageBox.Show("帳號密碼錯誤!");
                return -1;
            }
        }

    }
}
