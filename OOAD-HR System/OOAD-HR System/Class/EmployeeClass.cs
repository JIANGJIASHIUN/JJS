using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class EmployeeClass
    {
   
        private String _emplID = null;                 // 編號
        private String _emplName = null;               // 姓名
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
        public void setId(String emplID, String newEmplID)
        {
            this._emplID = newEmplID;
        }

        // ---------------------------------------------取得id---------------------------------------------
        public String getId()
        {
            return this._emplID;
        }

        // ---------------------------------------------設置姓名---------------------------------------------
        public void setName(String emplName)
        {
            this._emplName = emplName;
        }

        // ---------------------------------------------取得姓名---------------------------------------------
        public String getName(String emplID)
        {
            return this._emplName;
        }

        // ---------------------------------------------設置身分證字號---------------------------------------------
        public void setSsn(String emplID, String ssn)
        {
            this._ssn = ssn;
        }

        // ---------------------------------------------取得身分證字號---------------------------------------------
        public String getSsn(String emplID)
        {
            return this._ssn;
        }

        // ---------------------------------------------設置性別---------------------------------------------
        public void setSex(String emplID, String sex)
        {
            this._sex = sex;
        }

        // ---------------------------------------------取得性別---------------------------------------------
        public String getSex(String emplID)
        {
            return this._sex;
        }

        // ---------------------------------------------設置血型---------------------------------------------
        public void setBlood(String emplID, String blood)
        {
            this._blood = blood;
        }

        // ---------------------------------------------取得血型---------------------------------------------
        public String getBlood(String emplID)
        {
            return this._blood;
        }

        // ---------------------------------------------取得聯絡電話---------------------------------------------
        public void setPhone(String emplID, String phone)
        {
            this._phone = phone;
        }

        // ---------------------------------------------這連絡電話---------------------------------------------
        public String getPhone(String emplID)
        {
            return this._phone;
        }

        // ---------------------------------------------設置住址---------------------------------------------
        public void setAddress(String emplID, String addr)
        {
            this._addr = addr;
        }

        // ---------------------------------------------取得住址---------------------------------------------
        public String getAddress(String emplID)
        {
            return this._addr;
        }

        // ---------------------------------------------取得緊急聯絡人---------------------------------------------
        public void setEmerPerson(String emplID, String emerPerson)
        {
            this._emerPerson = emerPerson;
        }

        // ---------------------------------------------設置緊急聯絡人---------------------------------------------
        public String getEmerPerson(String emplID)
        {
            return this._emerPerson;
        }

        // ---------------------------------------------設置緊急連絡電話---------------------------------------------
        public void setEmerPhone(String emplID, String emerPhone)
        {
            this._emerPhone = emerPhone;
        }

        // ---------------------------------------------取得緊急連絡電話---------------------------------------------
        public String getEmerPhone(String emplID)
        {
            return this._emerPhone;
        }

        // ---------------------------------------------設置兵役狀態---------------------------------------------
        public void setMilitary(String emplID, String military)
        {
            this._military = military;
        }

        // ---------------------------------------------取得兵役狀態---------------------------------------------
        public String getMilitary(String emplID)
        {
            return this._military;
        }

        // ---------------------------------------------設置工作狀態---------------------------------------------
        public void setJobState(String emplID, String jobState)
        {
            this._jobState = jobState;
        }

        // ---------------------------------------------取得工作狀態---------------------------------------------
        public String getJobState(String emplID)
        {
            return this._jobState;
        }

        // ---------------------------------------------設置婚姻狀態---------------------------------------------
        public void setMarriedState(String emplID, String marriedState)
        {
            this._marriedState = marriedState;
        }

        // ---------------------------------------------取得婚姻狀態---------------------------------------------
        public String getMarriedState(String emplID)
        {
            return this._marriedState;
        }

        // ---------------------------------------------設置配偶---------------------------------------------
        public void setSpouse(String emplID, String spouse)
        {
            this._spouse = spouse;
        }

        // ---------------------------------------------取得配偶---------------------------------------------
        public String getSpouse(String emplID)
        {
            return this._spouse;
        }

        // ---------------------------------------------設置出生日期---------------------------------------------
        public void setBirth(String emplID, DateTime birth)
        {
            this._birth = birth;
        }

        // ---------------------------------------------取得出生日期---------------------------------------------
        public DateTime getBirth(String emplID)
        {
            return this._birth;
        }

        // ---------------------------------------------設置底薪---------------------------------------------
        public void setBasicSalary(String emplID, float basicSalary)
        {
            this._basicSalary = basicSalary;
        }

        // ---------------------------------------------取得底薪---------------------------------------------
        public float getBasicSalary(String emplID)
        {
            return this._basicSalary;
        }

        // ---------------------------------------------設置所屬部門編號---------------------------------------------
        public void setDeptId(String emplID, String deptId)
        {
            this._deptId = deptId;
        }

        // ---------------------------------------------取得所屬部門編號---------------------------------------------
        public String getDeptId(String emplID)
        {
            return this._deptId;
        }

        // ---------------------------------------------設置職位編號---------------------------------------------
        public void setPositionId(String emplID, String positionId)
        {
            this._positionId = positionId;
        }

        // ---------------------------------------------取得職位編號---------------------------------------------
        public String getPositionId(String emplID)
        {
            return this._positionId;
        }

    }
}
