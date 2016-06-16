using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Model
{
    public class ProduceSalaryModel
    {

        private DateTime _startDate;
        private DateTime _endDate;
        private String _salaryT;
        private String _emplID;
        private String _payWay;
        private String _accountData = null;
        private float _totalSalary = 0;

        // 建構子
        public ProduceSalaryModel()
        {

        }

        // 設置起始日期
        public void SetStartDate(DateTime startDate)
        {
            this._startDate = startDate;
        }

        // 取得起始日期
        public DateTime GetStartDate()
        {
            return this._startDate;
        }

        // 設置結束日期
        public void SetEndDate(DateTime endDate)
        {
            this._endDate = endDate;
        }

        // 取得結束日期
        public DateTime GetEndDate()
        {
            return this._endDate;
        }

        // 設置新水期別
        public void SetSalaryT(String salaryT)
        {
            this._salaryT = salaryT;
        }

        // 取得薪水期別
        public String GetSalaryT()
        {
            return this._salaryT;
        }

        // 設置員工id
        public void SetEmplID(String emplID)
        {
            this._emplID = emplID;
        }

        // 取得員工id
        public String GetEmplID()
        {
            return this._emplID;
        }

        // 設置支付方式
        public void SetPayWay(String payWay)
        {
            this._payWay = payWay;
        }

        // 取得支付方式
        public String GetPayWay()
        {
            return this._payWay;
        }

        // 設置帳戶資料
        public void SetAccountData(String accountData)
        {
            this._accountData = accountData;
        }

        // 取得帳戶資料
        public String GetAccountData()
        {
            return this._accountData;
        }

        // 設置薪水總額
        public void SetTotalSalary(float totalSalary)
        {
            this._totalSalary = totalSalary;
        }

        // 取得薪水總額
        public float GetTotalSalary()
        {
            return this._totalSalary;
        }

    }
}
