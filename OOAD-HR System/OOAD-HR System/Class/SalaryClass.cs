using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class SalaryClass
    {

        private DateTime _salaryY;
        private DateTime _salaryMN;
        private int _salaryT;           // 期別
        private String _accountData;
        private String _salaryPayWay;

        // ---------------------------------------------建構子---------------------------------------------
        public SalaryClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置薪水年分---------------------------------------------
        public void setYear(String emplID, DateTime salaryY)
        {
            this._salaryY = salaryY;
        }

        // ---------------------------------------------取得薪水年份---------------------------------------------
        public DateTime getYear(String emplID)
        {
            return this._salaryY;
        }

        // ---------------------------------------------設置薪水月份---------------------------------------------
        public void setMonth(String emplID, DateTime salaryMN)
        {
            this._salaryMN = salaryMN;
        }

        // ---------------------------------------------取得薪水月份---------------------------------------------
        public DateTime getMonth(String emplID)
        {
            return this._salaryMN;
        }

        // ---------------------------------------------設置薪水期別---------------------------------------------
        public void setSalaryT(String emplID, int salaryT)
        {
            this._salaryT = salaryT;
        }

        // ---------------------------------------------取得薪水期別---------------------------------------------
        public int getSalaryT(String emplID)
        {
            return this._salaryT;
        }

        // ---------------------------------------------設置員工帳戶資料---------------------------------------------
        public void setAccountData(String emplID, String accountData)
        {
            this._accountData = accountData;
        }

        // ---------------------------------------------取得員工帳戶資料---------------------------------------------
        public String getAccountData(String emplID)
        {
            return this._accountData;
        }

        // ---------------------------------------------設置支付方式---------------------------------------------
        public void setPayWay(String emplID, String salaryPayWay)
        {
            this._salaryPayWay = salaryPayWay;
        }

        // ---------------------------------------------取得支付方式---------------------------------------------
        public String getPayWay(String emplID)
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
