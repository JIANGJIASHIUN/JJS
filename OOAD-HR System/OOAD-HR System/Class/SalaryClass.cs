using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class SalaryClass
    {

        private String _emplID;
        private String _salaryDate;
        private String _salaryT;           // 期別
        private String _accountData;
        private String _salaryPayWay;

        // ---------------------------------------------建構子---------------------------------------------
        public SalaryClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置員工ID---------------------------------------------
        public void setemplID(String emplID)
        {
            this._emplID = emplID;
        }

        // ---------------------------------------------取得薪水月份---------------------------------------------
        public String getEmplID()
        {
            return this._emplID;
        }

        // ---------------------------------------------設置薪水年月---------------------------------------------
        public void setDate(String salaryDate)
        {
            this._salaryDate = salaryDate;
        }

        // ---------------------------------------------取得薪水月份---------------------------------------------
        public String getDate()
        {
            return this._salaryDate;
        }

        // ---------------------------------------------設置薪水期別---------------------------------------------
        public void setSalaryT(String salaryT)
        {
            this._salaryT = salaryT;
        }

        // ---------------------------------------------取得薪水期別---------------------------------------------
        public String getSalaryT()
        {
            return this._salaryT;
        }

        // ---------------------------------------------設置員工帳戶資料---------------------------------------------
        public void setAccountData(String accountData)
        {
            this._accountData = accountData;
        }

        // ---------------------------------------------取得員工帳戶資料---------------------------------------------
        public String getAccountData()
        {
            return this._accountData;
        }

        // ---------------------------------------------設置支付方式---------------------------------------------
        public void setPayWay(String salaryPayWay)
        {
            this._salaryPayWay = salaryPayWay;
        }

        // ---------------------------------------------取得支付方式---------------------------------------------
        public String getPayWay()
        {
            return this._salaryPayWay;
        }

        // ---------------------------------------------計算所有員工薪水---------------------------------------------
        public void computeSalary()
        {

        }

        // ---------------------------------------------匯出所有員工薪水資料---------------------------------------------
        public void exportSalary()
        {

        }

    }
}
