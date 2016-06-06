using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOAD_HR_System.Service;
using OOAD_HR_System.Model;
using OOAD_HR_System.PresentationModel;

namespace OOAD_HR_System.Controller
{
    public class PositionController
    {

        private PositionModel _positionModel = new PositionModel();
        private PositionService _positionService;

        // 建構子
        public PositionController(PositionPresentationModel positionPresentationModel) 
        {
            this._positionModel.SetId(positionPresentationModel.GetPositionID());
            this._positionModel.SetName(positionPresentationModel.GetPositionName());
            this._positionModel.SetBasicSalary(positionPresentationModel.GetPositionBasicSalary());
            this._positionModel.SetAuthoId(positionPresentationModel.GetPositionAuthoID());
        }

        // 呼叫service將資料新增至資料庫
        public void AddPosition()
        {
            this._positionService = new PositionService(_positionModel);

            int errorFlag = 0;

            if (this._positionModel.GetId() == "" || this._positionModel.GetName() == "" || this._positionModel.GetAuthoId() == "")
            {
                MessageBox.Show("尚有欄位為空白, 請重新確認是否填寫完畢!");
                errorFlag = 1;
            }

            if (errorFlag == 1)
                return;

            if (_positionService.AddPosition())
                MessageBox.Show("新增成功!");
            else
                MessageBox.Show("新增失敗!");
        }

    }
}
