using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD_HR_System.Class;

namespace OOAD_HR_System.Model
{
    public class DepartmentModel
    {

        private DepartmentClass _department = new DepartmentClass();

        // 建構子
        public DepartmentModel()
        {

        }

        // 設置ID
        public void SetDepartmentID(String departmentID)
        {
            this._department.SetId(departmentID);
        }

        // 取得ID
        public String GetDepartmentID()
        {
            return this._department.GetId();
        }

        // 設置名稱
        public void SetDepartmentName(String departmentName)
        {
            this._department.SetName(departmentName);
        }

        // 取得名稱
        public String GetDepartmentName()
        {
            return this._department.GetName();
        }

        // 設置開始日期
        public void SetDepartmentStartTime(DateTime departmentStartTime)
        {
            this._department.SetStartTime(departmentStartTime);
        }

        // 取得開始日期
        public DateTime GetDepartmentStartTime()
        {
            return this._department.GetStartTime();
        }

        // 設置結束日期
        public void SetDepartmentEndTime(DateTime departmentEndTime)
        {
            this._department.SetEndTime(departmentEndTime);
        }

        // 取得結束日期
        public DateTime GetDepartmentEndTime()
        {
            return this._department.GetEndTime();
        }

        // 設置管理人
        public void SetDepartmentManager(String departmentManager)
        {
            this._department.SetManager(departmentManager);
        }

        // 取得管理人
        public String GetDepartmentManager()
        {
            return this._department.GetManager();
        }
    }
}
