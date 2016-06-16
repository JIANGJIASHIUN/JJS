using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using OOAD_HR_System.Model;
using OOAD_HR_System.PresentationModel;
using OOAD_HR_System.Service;

namespace OOAD_HR_System.Controller
{
    public class ProduceSalaryController
    {

        private DateTime _startDate;
        private DateTime _endDate;
        private String _salaryT;

        // 建構子
        public ProduceSalaryController(ProduceSalaryPresentationModel produceSalaryPM)
        {
            this._startDate = produceSalaryPM.GetStartDate();
            this._endDate = produceSalaryPM.GetEndDate();
            this._salaryT = produceSalaryPM.GetSalaryT();
        }

        // 取得所有員工資料
        private List<EmployeeModel> GetAllEmplDate() 
        {
            List<EmployeeModel> emplList = new List<EmployeeModel>();
            EmployeeModel emplModel = new EmployeeModel();
            EmployeeService emplService = new EmployeeService(emplModel);
            emplList = emplService.GetAllEmplData();
            return emplList;
        }

        // 用員工ID查詢該員工所有獎金, 並判斷日期與期別是否在輸入範圍內, 回傳所有在範圍內的獎金總合
        private float ComputeEmplBonus(String emplID)
        {
            float totalBonus = 0;

            BonusModel bonusModel = new BonusModel();
            bonusModel.SetEmplID(emplID);
            BonusService bonusService = new BonusService(bonusModel);
            List<BonusModel> emplTotalBonus = bonusService.searchBonusByEmplID();

            List<BonusModel> emplBonusInDate = new List<BonusModel>();

            int emplTotalBonusCount = emplTotalBonus.Count;

            // 取出所有符合日期與期別的獎金資料
            for (int i = 0; i < emplTotalBonusCount; i++)
            {
                DateTime bonusDate = emplTotalBonus[i].GetBonusDate();
                String bonusT = emplTotalBonus[i].GetBonusT();

                if (bonusDate.CompareTo(this._startDate) == 1 && bonusDate.CompareTo(this._endDate) == -1 && bonusT == this._salaryT)
                    emplBonusInDate.Add(emplTotalBonus[i]);
            }

            // 計算符合日期與期別之獎金總額
            BonusDefModel bonusDefModel;
            BonusDefService bonusDefService;
            int totalBonusInDateCount = emplBonusInDate.Count;

            for (int i = 0; i < totalBonusInDateCount; i++)
            {
                bonusDefModel = new BonusDefModel();
                bonusDefModel.SetBonusDefID(emplBonusInDate[i].GetBonusDefID());
                bonusDefService = new BonusDefService(bonusDefModel);
                bonusDefModel = bonusDefService.SearchBonusDefByBonusDefID();
                totalBonus += bonusDefModel.GetBonusDefAmount();
            }

            return totalBonus;
        }

        // 取得該員工薪水支付方式
        private List<String> GetEmplSalaryPayWay(String emplID)
        {
            List<String> salaryPayWayData = new List<String>();

            SalaryModel salaryModel = new SalaryModel();
            salaryModel.setEmplID(emplID);
            SalaryService salaryService = new SalaryService(salaryModel);
            salaryModel = salaryService.searchByEmplID();

            salaryPayWayData.Add(salaryModel.getPayway());
            salaryPayWayData.Add(salaryModel.getAccountData());

            return salaryPayWayData;
        }

        // 產出薪資單(所有員工)
        public void ProduceSalary()
        {
            List<EmployeeModel> emplList = new List<EmployeeModel>();
            emplList = this.GetAllEmplDate();

            int totalEmpl = emplList.Count;
            float emplBasicSalary = 0;
            float emplBonus = 0;
            float totalSalary = 0;
            String emplID;
            List<String> salaryPayWayData = new List<String>();
            String salaryPayWay = null;
            String accountData = null;

            ProduceSalaryModel produceSalaryModel;
            ProduceSalaryService produceSalaryService;

            for (int i = 0; i < totalEmpl; i++)
            {
                emplID = emplList[i].GetEmplID();
                emplBasicSalary = emplList[i].GetBasicSalary();
                emplBonus = this.ComputeEmplBonus(emplID);
                salaryPayWayData = this.GetEmplSalaryPayWay(emplID);
                salaryPayWay = salaryPayWayData[0];
                accountData = salaryPayWayData[1];

                totalSalary = emplBasicSalary + emplBonus;

                produceSalaryModel = new ProduceSalaryModel();
                produceSalaryModel.SetStartDate(this._startDate);
                produceSalaryModel.SetEndDate(this._endDate);
                produceSalaryModel.SetSalaryT(this._salaryT);
                produceSalaryModel.SetEmplID(emplID);
                produceSalaryModel.SetPayWay(salaryPayWay);
                produceSalaryModel.SetAccountData(accountData);
                produceSalaryModel.SetTotalSalary(totalSalary);

                produceSalaryService = new ProduceSalaryService(produceSalaryModel);

                if (!produceSalaryService.AddProduceSalary())
                {
                    MessageBox.Show("發生錯誤, 系統停止運算! 先前共計算" + (i + 1) + "筆資料");
                    return;
                }
            }

            MessageBox.Show("計算完畢, 共" + totalEmpl + "筆資料!");
        }

    }
}
