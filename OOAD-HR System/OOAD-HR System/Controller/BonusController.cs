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
    public class BonusController
    {

        private BonusModel _bonusModel = new BonusModel();
        private BonusService _bonusService;

        // 建構子
        public BonusController(BonusPresentationModel bonusPresentationModel)
        {
            this._bonusModel.SetBonusDefID(bonusPresentationModel.GetBonusDefID());
            this._bonusModel.SetEmplID(bonusPresentationModel.GetEmplID());
            this._bonusModel.SetBonusDate(bonusPresentationModel.GetBonusDate());
            this._bonusModel.SetBonusT(bonusPresentationModel.GetBonusT());
        }

        // 判斷員工獎金新增日期是否在獎金資料建立之後或在有效日期之後
        private String JudgeBonusDateIsValid()
        {
            String message = "";
            BonusDefModel bonusDefModel = new BonusDefModel();
            bonusDefModel.SetBonusDefID(this._bonusModel.GetBonusDefID());
            BonusDefService bonusDefService = new BonusDefService(bonusDefModel);

            bonusDefModel = bonusDefService.SearchBonusDefByBonusDefID();

            DateTime bonusDefCreateDate = bonusDefModel.GetBonusDefCreateDate();
            DateTime bonusDefEffiDate = bonusDefModel.GetBonusDefEffiDate();

            DateTime bonusDate = this._bonusModel.GetBonusDate();

            if (bonusDate.CompareTo(bonusDefCreateDate) == -1)
                message = "新增員工獎金日期在獎金資料建立之前!";

            if (bonusDate.CompareTo(bonusDefEffiDate) == 1)
                message = "新增員工獎金日期在獎金有效日期建立之後!";

            return message;
        }

        // 判斷員工ID是否存在
        private Boolean JudgeEmplIDIsExist()
        {
            String emplID = this._bonusModel.GetEmplID();
            EmployeeModel emplModel = new EmployeeModel();
            emplModel.SetEmplID(emplID);

            EmployeeService emplService = new EmployeeService(emplModel);
            emplModel = emplService.searchByEmplID();

            if (emplModel.GetName() == null || emplModel.GetName() == "")
                return false;

            return true;
        }

        // 呼叫service將資料新增至資料庫
        public void AddBonus()
        {
            this._bonusService = new BonusService(_bonusModel);

            int errorFlag = 0;

            if (this._bonusModel.GetEmplID() == "" || this._bonusModel.GetBonusT() == "")
            {
                MessageBox.Show("尚有欄位為空白, 請重新確認是否填寫完畢!");
                errorFlag = 1;
            }

            if (!this.JudgeEmplIDIsExist())
            {
                MessageBox.Show("員工ID不存在, 請重新確認!");
                return;
            }

            String message = this.JudgeBonusDateIsValid();
            if (message != "")
            {
                MessageBox.Show(message);
                errorFlag = 1;
            }

            if (errorFlag == 1)
                return;

            if (_bonusService.AddBonus())
                MessageBox.Show("新增成功!");
            else
                MessageBox.Show("新增失敗!");
        }

    }
}
