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

        // 判斷該天是否已經有考勤紀錄
        private Boolean JudgeWAExist()
        {
            WorkAttendanceModel waModel = new WorkAttendanceModel();

            waModel.SetWAEmplID(this._workAttendanceModel.GetWAEmplID());
            waModel.SetWADate(this._workAttendanceModel.GetWADate());

            this._waService = new WorkAttendanceService(waModel);

            waModel = this._waService.SearchWAByEmplIDAndDate();

            String waStatus = waModel.GetWAStatus();
            if (waStatus != null)
                return true;

            return false;
        }

        // 呼叫service 將考勤資料新增置資料庫
        public void AddWorkAttendance()
        {
            if (!this.JudgeEmplIDIsExist())
            {
                MessageBox.Show("此員工ID不存在, 請重新輸入!");
                return;
            }

            if (this.JudgeWAExist())
            {
                MessageBox.Show("此員工該天的考勤紀錄已存在!");
                return;
            }

            this._waService = new WorkAttendanceService(_workAttendanceModel);

            if (this._waService.AddWorkAttendance())
                MessageBox.Show("新增成功!");
            else
                MessageBox.Show("新增失敗!");
        }

        //呼叫service 利用員工ID與日期查詢work attendance資料
        public WorkAttendancePresentationModel SearchDataByEmplIDAndDate()
        {
            WorkAttendancePresentationModel waPresentationModel = new WorkAttendancePresentationModel();

            if (this._workAttendanceModel.GetWAEmplID() == null || this._workAttendanceModel.GetWAEmplID() == "")
                MessageBox.Show("請輸入員工ID");
            else
            {
                this._waService = new WorkAttendanceService(_workAttendanceModel);
                this._workAttendanceModel = this._waService.SearchWAByEmplIDAndDate();

                waPresentationModel.SetWAEmplID(this._workAttendanceModel.GetWAEmplID());
                waPresentationModel.SetWADate(this._workAttendanceModel.GetWADate());
                waPresentationModel.SetWAStatus(this._workAttendanceModel.GetWAStatus());
                waPresentationModel.SetStartTime(this._workAttendanceModel.GetStartTime());
                waPresentationModel.SetEndTime(this._workAttendanceModel.GetStartTime());
                waPresentationModel.SetIsOvertime(this._workAttendanceModel.GetIsOvertime());
                waPresentationModel.SetStartOvertime(this._workAttendanceModel.GetStartOvertime());
                waPresentationModel.SetEndOvertime(this._workAttendanceModel.GetEndOvertime());

                if (waPresentationModel.GetWAStatus() == null || waPresentationModel.GetWAStatus() == "")
                {
                    MessageBox.Show("該筆考勤紀錄不存在!");
                    waPresentationModel.SetWAEmplID(null);
                }
            }
            return waPresentationModel;
        }

        // 呼叫service, 將資料新增至資料庫(edit)
        public Boolean EditWorkAttendance()
        {
            this._waService = new WorkAttendanceService(_workAttendanceModel);

            if (this._waService.EditWorkAttendance())
                MessageBox.Show("修改成功！");
            else
            {
                MessageBox.Show("修改失敗！");
                return false;
            }


            return true;
        }

    }
}
