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
        public AuthorizationController(AuthorizatoinPresentationModel authoPresentationModel)
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

    }
}
