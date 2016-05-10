using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class DepartmentClass
    {

        private String _id = null;
        private String _name = null;
        private DateTime _startTime;
        private DateTime _endTime;
        private String _manager = null;

        // ---------------------------------------------建構子---------------------------------------------
        public DepartmentClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置id---------------------------------------------
        public void setId(String id)
        {
            this._id = id;
        }

        // ---------------------------------------------取得id---------------------------------------------
        public String getId()
        {
            return this._id;
        }

        // ---------------------------------------------設置名稱---------------------------------------------
        public void setName(String deptId, String name)
        {
            this._name = name;
        }

        // ---------------------------------------------取得名稱---------------------------------------------
        public String getName(String deptId)
        {
            return this._name;
        }

        // ---------------------------------------------設置創立時間---------------------------------------------
        public void setStartTime(String deptId, DateTime startTime)
        {
            this._startTime = startTime;
        }

        // ---------------------------------------------取得創立時間---------------------------------------------
        public DateTime getStartTime(String deptId)
        {
            return this._startTime;
        }

        // ---------------------------------------------設置關閉時間---------------------------------------------
        public void setEndTime(String deptId, DateTime endTime)
        {
            this._endTime = endTime;
        }

        // ---------------------------------------------取得關閉時間---------------------------------------------
        public DateTime getEndTime(String deptId)
        {
            return this._endTime;
        }

        // ---------------------------------------------設置管理人---------------------------------------------
        public void setManager(String deptId, String manager)
        {
            this._manager = manager;
        }

        // ---------------------------------------------取得管理人---------------------------------------------
        public String getManager(String deptId)
        {
            return this._manager; 
        }

    }
}
