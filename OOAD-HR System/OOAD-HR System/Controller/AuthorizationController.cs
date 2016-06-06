using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOAD_HR_System.Model;
using OOAD_HR_System.PresentationModel;
using OOAD_HR_System.Service;

namespace OOAD_HR_System.Controller
{
    public class AuthorizationController
    {

        private AuthorizationModel _authoModel = new AuthorizationModel();
        private AuthorizationService _authoService;

        // 建構子
        public AuthorizationController(AuthorizationPresentationModel authoPresentationModel)
        {
            _authoModel.SetAuthoID(authoPresentationModel.GetAuthoID());
            _authoModel.SetAuthoName(authoPresentationModel.GetAuthoName());
            _authoModel.SetAuthoValue(authoPresentationModel.GetAuthoValue());
        }

        // 呼叫service將資料新增至資料庫
        public void AddAuthorization()
        {
            this._authoService = new AuthorizationService(_authoModel);

            int errorFlag = 0;

            if (this._authoModel.GetAuthoID() == "" || this._authoModel.GetAuthoName() == "" || this._authoModel.GetAuthoValue() == "")
            {
                MessageBox.Show("尚有欄位為空白, 請重新確認是否填寫完畢!");
                errorFlag = 1;
            }

            if (errorFlag == 1)
                return;

            if (_authoService.AddAuthorization())
                MessageBox.Show("新增成功!");
            else
                MessageBox.Show("新增失敗!");
        }

        // 呼叫service, 將資料新增至資料庫(edit)
        public Boolean editAuthorization()
        {
            this._authoService = new AuthorizationService(this._authoModel);
            int error_flag = 0;
            if (this._authoModel.GetAuthoName() == "")
            {
                MessageBox.Show("請輸入權限名稱");
                return false;
            }
            else if(this._authoModel.GetAuthoValue() == "")
            {
                MessageBox.Show("請輸入權限數值");
                return false;
            }

            if (_authoService.EditAuthorization())
                MessageBox.Show("修改成功！");
            else
            {
                MessageBox.Show("修改失敗！");
                return false;
            }
                
            
            return true;
        }

        //呼叫service 利用authoID查詢autho資料
        public AuthorizationPresentationModel SearchDataByAuthoID()
        {
            AuthorizationPresentationModel authoPresentModel = new AuthorizationPresentationModel();

            if (this._authoModel.GetAuthoID() == null || this._authoModel.GetAuthoID() == "")
                MessageBox.Show("請輸入權限ID");
            else
            {
                //MessageBox.Show("yes");
                _authoService = new AuthorizationService(this._authoModel);
                _authoModel = _authoService.searchByAuthoID();

                authoPresentModel.SetAuthoID(_authoModel.GetAuthoID());
                authoPresentModel.SetAuthoName(_authoModel.GetAuthoName());
                authoPresentModel.SetAuthoValue(_authoModel.GetAuthoValue());

                if(_authoModel.GetAuthoName() == null || _authoModel.GetAuthoName() == "")
                {
                    MessageBox.Show("此權限ID不存在!");
                    //MessageBox.Show(_authoModel.GetAuthoID());
                    authoPresentModel.SetAuthoID(null);
                }
            }
            return authoPresentModel;
        }

    }
}
