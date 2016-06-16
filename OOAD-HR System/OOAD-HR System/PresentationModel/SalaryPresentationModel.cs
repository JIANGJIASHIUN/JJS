using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD_HR_System.Class;

namespace OOAD_HR_System.PresentationModel
{
    public class SalaryPresentationModel
    {

        private SalaryClass _salary = new SalaryClass();

        //建構子
        public SalaryPresentationModel()
        {

        }

        // 設置員工ID
        public void setEmplID(String emplID)
        {
            this._salary.setemplID(emplID);
        }

        // 取得員工ID
        public String getEmplID()
        {
            return this._salary.getEmplID();
        }

        // 設置支付方式
        public void setPayway(String payway)
        {
            this._salary.setPayWay(payway);
        }

        // 取得支付方式
        public String getPayway()
        {
            return this._salary.getPayWay();
        }

        // 設置帳戶
        public void setAccountData(String accountData)
        {
            this._salary.setAccountData(accountData);
        }

        // 取得帳戶
        public String getAccountData()
        {
            return this._salary.getAccountData();
        }

        // 設置薪資年月
        public void setSalaryDate(String salaryDate)
        {
            this._salary.setDate(salaryDate);
        }

        // 取得薪資年月
        public String getSalaryDate()
        {
            return this._salary.getDate();
        }

        // 設置薪資分期
        public void setSalaryT(String salaryT)
        {
            this._salary.setSalaryT(salaryT);
        }

        // 取得薪資分期
        public String getSalaryT()
        {
            return this._salary.getSalaryT();
        }
    }
}
