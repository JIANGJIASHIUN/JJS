using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD_HR_System.Class;

namespace OOAD_HR_System.PresentationModel
{
    public class DepartmentPresentationModel
    {

        private DepartmentClass _department = new DepartmentClass();

        //建構子
        public DepartmentPresentationModel()
        {

        }

        // 設置ID
        public void setDepartmentID(String departmentID)
        {
            this._department.SetId(departmentID);
        }

        // 取得ID
        public String getDepartmentID()
        {
            return this._department.GetId();
        }

        // 設置名稱
        public void setDepartmentName(String departmentName)
        {
            this._department.SetName(departmentName);
        }

        // 取得名稱
        public String getDepartmentName()
        {
            return this._department.GetName();
        }

        // 設置開始日期
        public void setDepartmentStartTime(DateTime departmentStartTime)
        {
            this._department.SetStartTime(departmentStartTime);
        }

        // 取得開始日期
        public DateTime getDepartmentStartTime()
        {
            return this._department.GetStartTime();
        }

        // 設置結束日期
        public void setDepartmentEndTime(DateTime departmentEndTime)
        {
            this._department.SetEndTime(departmentEndTime);
        }

        // 取得結束日期
        public DateTime getDepartmentEndTime()
        {
            return this._department.GetEndTime();
        }

        // 設置管理人
        public void setDepartmentManager(String departmentManager)
        {
            this._department.SetManager(departmentManager);
        }

        // 取得管理人
        public String getDepartmentManager()
        {
            return this._department.GetManager();
        }
        
    }
}
