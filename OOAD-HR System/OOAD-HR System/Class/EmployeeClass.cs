using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class EmployeeClass
    {
   
        private String _emplID = null;             // 編號
        private String _emplName = null;           // 姓名
        private String _ssn = null;                // 身分證字號
        private String _sex = null;                // 性別
        private String _blood = null;              // 血型
        private String _phone = null;              // 連絡電話
        private String _addr = null;               // 住址
        private String _emerPerson = null;         // 緊急聯絡人
        private String _emerPhone = null;          // 緊急聯絡人電話
        private String _military = null;           // 兵役狀態
        private String _jobState = null;           // 工作狀態(在職, 離職... etc)
        private String _marriedState = null;       // 婚姻狀態
        private String _spouse = null;             // 配偶
        private DateTime _birth;                   // 出生日期
        private float _basicSalary;                // 底薪
        private String _deptId = null;             // 所屬部門編號
        private String _positionId = null;         // 職位編號

        // ---------------------------------------------建構子---------------------------------------------
        public EmployeeClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置id---------------------------------------------
        public void SetId( String newEmplID)
        {
            this._emplID = newEmplID;
        }

        // ---------------------------------------------取得id---------------------------------------------
        public String GetId()
        {
            return this._emplID;
        }

        // ---------------------------------------------設置姓名---------------------------------------------
        public void SetName(String emplName)
        {
            this._emplName = emplName;
        }

        // ---------------------------------------------取得姓名---------------------------------------------
        public String GetName()
        {
            return this._emplName;
        }

        // ---------------------------------------------設置身分證字號---------------------------------------------
        public void SetSsn(String ssn)
        {
            this._ssn = ssn;
        }

        // ---------------------------------------------取得身分證字號---------------------------------------------
        public String GetSsn()
        {
            return this._ssn;
        }

        // ---------------------------------------------設置性別---------------------------------------------
        public void SetSex(String sex)
        {
            this._sex = sex;
        }

        // ---------------------------------------------取得性別---------------------------------------------
        public String GetSex()
        {
            return this._sex;
        }

        // ---------------------------------------------設置血型---------------------------------------------
        public void SetBlood(String blood)
        {
            this._blood = blood;
        }

        // ---------------------------------------------取得血型---------------------------------------------
        public String GetBlood()
        {
            return this._blood;
        }

        // ---------------------------------------------取得聯絡電話---------------------------------------------
        public void SetPhone(String phone)
        {
            this._phone = phone;
        }

        // ---------------------------------------------這連絡電話---------------------------------------------
        public String GetPhone()
        {
            return this._phone;
        }

        // ---------------------------------------------設置住址---------------------------------------------
        public void SetAddress(String addr)
        {
            this._addr = addr;
        }

        // ---------------------------------------------取得住址---------------------------------------------
        public String GetAddress()
        {
            return this._addr;
        }

        // ---------------------------------------------取得緊急聯絡人---------------------------------------------
        public void SetEmerPerson(String emerPerson)
        {
            this._emerPerson = emerPerson;
        }

        // ---------------------------------------------設置緊急聯絡人---------------------------------------------
        public String GetEmerPerson()
        {
            return this._emerPerson;
        }

        // ---------------------------------------------設置緊急連絡電話---------------------------------------------
        public void SetEmerPhone(String emerPhone)
        {
            this._emerPhone = emerPhone;
        }

        // ---------------------------------------------取得緊急連絡電話---------------------------------------------
        public String GetEmerPhone()
        {
            return this._emerPhone;
        }

        // ---------------------------------------------設置兵役狀態---------------------------------------------
        public void SetMilitary(String military)
        {
            this._military = military;
        }

        // ---------------------------------------------取得兵役狀態---------------------------------------------
        public String GetMilitary()
        {
            return this._military;
        }

        // ---------------------------------------------設置工作狀態---------------------------------------------
        public void SetJobState(String jobState)
        {
            this._jobState = jobState;
        }

        // ---------------------------------------------取得工作狀態---------------------------------------------
        public String GetJobState()
        {
            return this._jobState;
        }

        // ---------------------------------------------設置婚姻狀態---------------------------------------------
        public void SetMarriedState(String marriedState)
        {
            this._marriedState = marriedState;
        }

        // ---------------------------------------------取得婚姻狀態---------------------------------------------
        public String GetMarriedState()
        {
            return this._marriedState;
        }

        // ---------------------------------------------設置配偶---------------------------------------------
        public void SetSpouse(String spouse)
        {
            this._spouse = spouse;
        }

        // ---------------------------------------------取得配偶---------------------------------------------
        public String GetSpouse()
        {
            return this._spouse;
        }

        // ---------------------------------------------設置出生日期---------------------------------------------
        public void SetBirth(DateTime birth)
        {
            this._birth = birth;
        }

        // ---------------------------------------------取得出生日期---------------------------------------------
        public DateTime GetBirth()
        {
            return this._birth;
        }

        // ---------------------------------------------設置底薪---------------------------------------------
        public void SetBasicSalary(float basicSalary)
        {
            this._basicSalary = basicSalary;
        }

        // ---------------------------------------------取得底薪---------------------------------------------
        public float GetBasicSalary()
        {
            return this._basicSalary;
        }

        // ---------------------------------------------設置所屬部門編號---------------------------------------------
        public void SetDeptId(String deptId)
        {
            this._deptId = deptId;
        }

        // ---------------------------------------------取得所屬部門編號---------------------------------------------
        public String GetDeptId()
        {
            return this._deptId;
        }

        // ---------------------------------------------設置職位編號---------------------------------------------
        public void SetPositionId(String positionId)
        {
            this._positionId = positionId;
        }

        // ---------------------------------------------取得職位編號---------------------------------------------
        public String GetPositionId()
        {
            return this._positionId;
        }

    }
}
