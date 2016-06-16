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
    public class SalaryController
    {

        private SalaryModel _salaryModel = new SalaryModel();
        private SalaryService _salaryService;

        // 建構子
        public SalaryController(SalaryPresentationModel salaryPresentationModel)
        {
            _salaryModel.setSalaryDate(salaryPresentationModel.getSalaryDate());
            _salaryModel.setSalaryT(salaryPresentationModel.getSalaryT());
            _salaryModel.setEmplID(salaryPresentationModel.getEmplID());
            _salaryModel.setPayway(salaryPresentationModel.getPayway());
            _salaryModel.setAccountData(salaryPresentationModel.getAccountData());
            
        }

        // 呼叫service將資料新增至資料庫
        public void AddPayway()
        {
            this._salaryService = new SalaryService(_salaryModel);
            SalaryPresentationModel salaryPresentModel = new SalaryPresentationModel();
            int errorFlag = 0;
            if(this._salaryModel.getEmplID() == "" ||(this._salaryModel.getPayway() == "Transfer" && this._salaryModel.getAccountData() ==""))
            {
                MessageBox.Show("尚有重要資料欄位為空白, 請重新確認");
                errorFlag = 1;
            }
            else
            {
                _salaryModel = _salaryService.searchByEmplID();

                salaryPresentModel.setEmplID(_salaryModel.getEmplID());

                if(_salaryModel.getEmplID() == null ||_salaryModel.getEmplID() == "")
                {
                    MessageBox.Show("資料庫內已有該員工轉帳資料");
                    errorFlag = 1;
                }
            }

            if (errorFlag == 1)
                return;

            if (_salaryService.addPayway())
                MessageBox.Show("新增成功!");
            else
                MessageBox.Show("新增失敗!");
        }

        // 以員工ID搜尋支付資料
        public SalaryPresentationModel SearchDataByEmplID()
        {
            SalaryPresentationModel salaryPresentationModel = new SalaryPresentationModel();
            if (this._salaryModel.getEmplID() == null || this._salaryModel.getEmplID() == "")
                MessageBox.Show("請輸入員工ID");
            else
            {
                //MessageBox.Show("yes");
                _salaryService = new SalaryService(this._salaryModel);
                _salaryModel = _salaryService.searchByEmplID();

                salaryPresentationModel.setEmplID(_salaryModel.getEmplID());
                salaryPresentationModel.setPayway(_salaryModel.getPayway());
                salaryPresentationModel.setAccountData(_salaryModel.getAccountData());

                if (_salaryModel.getEmplID() == null || _salaryModel.getEmplID() == "")
                {
                    MessageBox.Show("此員工ID不存在!");
                    //MessageBox.Show(_authoModel.GetAuthoID());
                    salaryPresentationModel.setEmplID(null);
                }
            }
            return salaryPresentationModel;
        }
    }
}
