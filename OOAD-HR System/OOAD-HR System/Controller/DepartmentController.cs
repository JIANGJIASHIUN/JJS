using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOAD_HR_System.Model;
using OOAD_HR_System.PresentationModel;
using OOAD_HR_System.Service;

namespace OOAD_HR_System.Controller
{
    public class DepartmentController
    {
        private DepartmentModel _deptModel = new DepartmentModel();
        private DepartmentService _deptService;

        //建構子
        public DepartmentController(DepartmentPresentationModel deptPresentationModel)
        {
            _deptModel.SetDepartmentID(deptPresentationModel.getDepartmentID());
            _deptModel.SetDepartmentName(deptPresentationModel.getDepartmentName());
            _deptModel.SetDepartmentStartTime(deptPresentationModel.getDepartmentStartTime());
            _deptModel.SetDepartmentEndTime(deptPresentationModel.getDepartmentEndTime());
            _deptModel.SetDepartmentManager(deptPresentationModel.getDepartmentManager());
        }

        // 呼叫service將資料新增至資料庫
        public void AddDepartment()
        {
            this._deptService = new DepartmentService(_deptModel);
            int error_flag = 0;

            if(this._deptModel.GetDepartmentID() == "" || this._deptModel.GetDepartmentName() == "" || this._deptModel.GetDepartmentManager() == "")
            {
                MessageBox.Show("尚有欄位為空白, 請重新確認是否填寫完畢!");
                error_flag = 1;
            }

            if (error_flag == 1)
                return;

            if (_deptService.AddDepartment())
                MessageBox.Show("新增成功!");
            else
                MessageBox.Show("新增失敗!");
        }

        // 呼叫service利用departmentID查詢dept資料
        public DepartmentPresentationModel SearchDepartmentByID()
        {
            DepartmentPresentationModel deptPresentModel = new DepartmentPresentationModel();

            if (this._deptModel.GetDepartmentID() == null || _deptModel.GetDepartmentID() == "")
                MessageBox.Show("請輸入部門ID");
            else
            {
                _deptService = new DepartmentService(this._deptModel);
                _deptModel = _deptService.searchByDeptID();

                deptPresentModel.setDepartmentID(_deptModel.GetDepartmentID());
                deptPresentModel.setDepartmentName(_deptModel.GetDepartmentName());
                deptPresentModel.setDepartmentStartTime(_deptModel.GetDepartmentStartTime());
                deptPresentModel.setDepartmentEndTime(_deptModel.GetDepartmentEndTime());
                deptPresentModel.setDepartmentManager(_deptModel.GetDepartmentManager());

                if(_deptModel.GetDepartmentName() == null || _deptModel.GetDepartmentName() == "")
                {
                    MessageBox.Show("此部門ID不存在!");
                    deptPresentModel.setDepartmentID(null);
                }
            }
            return deptPresentModel;
        }

        // 呼叫service, 將資料新增至資料庫(edit)
        public Boolean editDepartment()
        {
            this._deptService = new DepartmentService(this._deptModel);
            if(this._deptModel.GetDepartmentName() == "")
            {
                MessageBox.Show("請輸入部門名稱");
                return false;
            }
            else if(this._deptModel.GetDepartmentManager() == "")
            {
                MessageBox.Show("請輸入部門主管名稱");
                return false;
            }

            if(_deptService.EditDepartment())
                MessageBox.Show("修改成功");
            else
            {
                MessageBox.Show("修改失敗");
                return false;
            }
            return true;
        }
    }
}
