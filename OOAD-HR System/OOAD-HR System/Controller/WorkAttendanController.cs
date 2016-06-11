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
    public class WorkAttendanController
    {

        private WorkAttendanceModel _workAttendanceModel = new WorkAttendanceModel();
        private WorkAttendanceService _waService;
        
        // 建構子
        public WorkAttendanController(WorkAttendancePresentationModel waPresentationModel)
        {
            this._workAttendanceModel.SetWAEmplID(waPresentationModel.GetWAEmplID());
            this._workAttendanceModel.SetWADate(waPresentationModel.GetWADate());
            this._workAttendanceModel.SetWAStatus(waPresentationModel.GetWAStatus());
            String waStatus = this._workAttendanceModel.GetWAStatus();
            if (!(waStatus == "無故未到" || waStatus == "病假" || waStatus == "婚假" || waStatus == "產假" || waStatus == "休假"))
            {
                this._workAttendanceModel.SetStartTime(waPresentationModel.GetStartTime());
                this._workAttendanceModel.SetEndTime(waPresentationModel.GetEndTime());
            }
            
            this._workAttendanceModel.SetIsOvertime(waPresentationModel.GetIsOvertime());
            if (this._workAttendanceModel.GetIsOvertime())
            {
                this._workAttendanceModel.SetStartOvertime(waPresentationModel.GetStartOvertime());
                this._workAttendanceModel.SetEndOvertime(waPresentationModel.GetEndOvertime());
            }
        }

        // 判斷員工ID是否存在
        private Boolean JudgeEmplIDIsExist()
        {
            String emplID = this._workAttendanceModel.GetWAEmplID();
            EmployeeModel emplModel = new EmployeeModel();
            emplModel.SetEmplID(emplID);

            EmployeeService emplService = new EmployeeService(emplModel);
            emplModel = emplService.searchByEmplID();

            if (emplModel.GetName() == null || emplModel.GetName() == "")
                return false;

            return true;
        }

        // 呼叫service 將考勤資料新增置資料庫
        public void AddWorkAttendance()
        {
            if (!this.JudgeEmplIDIsExist())
            {
                MessageBox.Show("此員工ID不存在, 請重新輸入!");
                return;
            }

            this._waService = new WorkAttendanceService(_workAttendanceModel);

            if (_waService.AddWorkAttendance())
                MessageBox.Show("新增成功!");
            else
                MessageBox.Show("新增失敗!");
        }

    }
}
