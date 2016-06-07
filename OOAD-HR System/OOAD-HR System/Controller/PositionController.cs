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

        //呼叫service 利用positionID查詢position資料
        public PositionPresentationModel SearchDataByPositionID()
        {
            PositionPresentationModel positionPresentationModel = new PositionPresentationModel();

            if (this._positionModel.GetId() == null || this._positionModel.GetId() == "")
                MessageBox.Show("請輸入職位ID");
            else
            {
                //MessageBox.Show("yes");
                _positionService = new PositionService(this._positionModel);
                _positionModel = _positionService.searchByPositionID();

                positionPresentationModel.SetPositionID(_positionModel.GetId());
                positionPresentationModel.SetPositionName(_positionModel.GetName());
                positionPresentationModel.SetPositionBasicSalary(_positionModel.GetBasicSalary());
                positionPresentationModel.SetPositionAuthoID(_positionModel.GetAuthoId());

                if (positionPresentationModel.GetPositionName() == null || positionPresentationModel.GetPositionName() == "")
                {
                    MessageBox.Show("此職位ID不存在!");
                    //MessageBox.Show(_authoModel.GetAuthoID());
                    positionPresentationModel.SetPositionID(null);
                }
            }
            return positionPresentationModel;
        }

        // 呼叫service, 將資料新增至資料庫(edit)
        public Boolean EditPosition()
        {
            this._positionService = new PositionService(this._positionModel);
            int error_flag = 0;
            if (this._positionModel.GetName() == "")
            {
                MessageBox.Show("請輸入職位名稱");
                return false;
            }

            if (_positionService.EditPosition())
                MessageBox.Show("修改成功！");
            else
            {
                MessageBox.Show("修改失敗！");
                return false;
            }


            return true;
        }

    }
}
