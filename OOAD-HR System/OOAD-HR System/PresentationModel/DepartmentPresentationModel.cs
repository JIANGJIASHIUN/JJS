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
            this._department.setId(departmentID);
        }

        // 取得ID
        public String getDepartmentID()
        {
            return this._department.getId();
        }

        // 設置名稱
        public void setDepartmentName(String departmentName)
        {
            this._department.setName(departmentName);
        }

        // 取得名稱
        public String getDepartmentName()
        {
            return this._department.getName();
        }

        // 設置開始日期
        public void setDepartmentStartTime(DateTime departmentStartTime)
        {
            this._department.setStartTime(departmentStartTime);
        }

        // 取得開始日期
        public DateTime getDepartmentStartTime()
        {
            return this._department.getStartTime();
        }

        // 設置結束日期
        public void setDepartmentEndTime(DateTime departmentEndTime)
        {
            this._department.setEndTime(departmentEndTime);
        }

        // 取得結束日期
        public DateTime getDepartmentEndTime()
        {
            return this._department.getEndTime();
        }

        // 設置管理人
        public void setDepartmentManager(String departmentManager)
        {
            this._department.setManager(departmentManager);
        }

        // 取得管理人
        public String getDepartmentManager()
        {
            return this._department.getManager();
        }
        
    }
}
