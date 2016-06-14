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
    public class BonusDefController
    {

        private BonusDefModel _bonusDefModel = new BonusDefModel();
        private BonusDefService _bonusDefService;

        // 建構子
        public BonusDefController(BonusDefPresentationModel bonusDefPresentationModel)
        {
            this._bonusDefModel.SetBonusDefID(bonusDefPresentationModel.GetBonusDefID());
            this._bonusDefModel.SetBonusDefName(bonusDefPresentationModel.GetBonusDefName());
            this._bonusDefModel.SetBonusDefDesc(bonusDefPresentationModel.GetBonusDefDesc());
            this._bonusDefModel.SetBonusDefCreateDate(bonusDefPresentationModel.GetBonusDefCreateDate());
            this._bonusDefModel.SetBonusDefEffiDate(bonusDefPresentationModel.GetBonusDefEffiDate());
            this._bonusDefModel.SetBonusDefAmount(bonusDefPresentationModel.GetBonusDefAmount());
        }

        // 呼叫service將資料新增至資料庫
        public void AddBonusDef()
        {
            this._bonusDefService = new BonusDefService(_bonusDefModel);

            int errorFlag = 0;

            if (this._bonusDefModel.GetBonusDefID() == "" || this._bonusDefModel.GetBonusDefName() == "" || this._bonusDefModel.GetBonusDefDesc() == "")
            {
                MessageBox.Show("尚有欄位為空白, 請重新確認是否填寫完畢!");
                errorFlag = 1;
            }

            if (this._bonusDefModel.GetBonusDefEffiDate().CompareTo(this._bonusDefModel.GetBonusDefCreateDate()) == -1) 
            {
                MessageBox.Show("獎金有效日期請選擇於建立日期之後!");
                errorFlag = 1;
            }

            if (errorFlag == 1)
                return;

            if (_bonusDefService.AddBonusDef())
                MessageBox.Show("新增成功!");
            else
                MessageBox.Show("新增失敗!");
        }

    }
}
