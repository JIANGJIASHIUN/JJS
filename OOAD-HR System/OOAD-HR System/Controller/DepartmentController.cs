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
            _deptModel.setDepartmentID(deptPresentationModel.getDepartmentID());
            _deptModel.setDepartmentName(deptPresentationModel.getDepartmentName());
            _deptModel.setDepartmentStartTime(deptPresentationModel.getDepartmentStartTime());
            _deptModel.setDepartmentEndTime(deptPresentationModel.getDepartmentEndTime());
            _deptModel.setDepartmentManager(deptPresentationModel.getDepartmentManager());
        }

        // 呼叫service將資料新增至資料庫
        public void AddDepartment()
        {
            this._deptService = new DepartmentService(_deptModel);
            int error_flag = 0;

            if(this._deptModel.getDepartmentID() == "" || this._deptModel.getDepartmentName() == "" || this._deptModel.getDepartmentManager() == "")
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
    }
}
