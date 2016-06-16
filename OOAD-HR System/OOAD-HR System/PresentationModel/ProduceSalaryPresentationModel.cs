using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.PresentationModel
{
    public class ProduceSalaryPresentationModel
    {

        private DateTime _startDate;
        private DateTime _endDate;
        private String _salaryT;

        // 建構子
        public ProduceSalaryPresentationModel()
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

    }
}
