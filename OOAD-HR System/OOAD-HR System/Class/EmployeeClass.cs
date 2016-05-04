using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class EmployeeClass
    {
        //這兩個public要加
        String _id = null;                 // 編號
        String _name = null;               // 姓名
        String _ssn = null;                // 身分證字號
        String _sex = null;                // 性別
        String _blood = null;              // 血型
        String _phone = null;              // 連絡電話
        String _addr = null;               // 住址
        String _emerPerson = null;         // 緊急聯絡人
        String _emerPhone = null;          // 緊急聯絡人電話
        String _military = null;           // 兵役狀態
        String _jobState = null;           // 工作狀態(在職, 離職... etc)
        String _marriedState = null;       // 婚姻狀態
        String _spouse = null;             // 配偶
        DateTime _birth;                   // 出生日期
        float _basicSalary;                // 底薪
        String _deptId = null;             // 所屬部門編號
        String _positionId = null;         // 職位編號

        // ---------------------------------------------建構子---------------------------------------------
        public EmployeeClass () {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置id---------------------------------------------
        void setId(String id)
        {
            this._id = id;
        }

        // ---------------------------------------------取得id---------------------------------------------
        String getId()
        {
            return this._id;
        }

        // ---------------------------------------------設置姓名---------------------------------------------
        void setName(String name)
        {
            this._name = name;
        }

        // ---------------------------------------------取得姓名---------------------------------------------
        String getName()
        {
            return this._name;
        }

        // ---------------------------------------------設置身分證字號---------------------------------------------
        void setSsn(String ssn)
        {
            this._ssn = ssn;
        }

        // ---------------------------------------------取得身分證字號---------------------------------------------
        String getSsn()
        {
            return this._ssn;
        }

        // ---------------------------------------------設置性別---------------------------------------------
        void setSex(String sex)
        {
            this._sex = sex;
        }

        // ---------------------------------------------取得性別---------------------------------------------
        String getSex()
        {
            return this._sex;
        }

        // ---------------------------------------------設置血型---------------------------------------------
        void setBlood(String blood)
        {
            this._blood = blood;
        }

        // ---------------------------------------------取得血型---------------------------------------------
        String getBlood()
        {
            return this._blood;
        }

        // ---------------------------------------------取得聯絡電話---------------------------------------------
        void setPhone(String phone)
        {
            this._phone = phone;
        }

        // ---------------------------------------------這連絡電話---------------------------------------------
        String getPhone()
        {
            return this._phone;
        }

        // ---------------------------------------------設置住址---------------------------------------------
        void setAddress(String addr)
        {
            this._addr = addr;
        }

        // ---------------------------------------------取得住址---------------------------------------------
        String getAddress()
        {
            return this._addr;
        }

        // ---------------------------------------------取得緊急聯絡人---------------------------------------------
        void setEmerPerson(String emerPerson)
        {
            this._emerPerson = emerPerson;
        }

        // ---------------------------------------------設置緊急聯絡人---------------------------------------------
        String getEmerPerson()
        {
            return this._emerPerson;
        }

        // ---------------------------------------------設置緊急連絡電話---------------------------------------------
        void setEmerPhone(String emerPhone)
        {
            this._emerPhone = emerPhone;
        }

        // ---------------------------------------------取得緊急連絡電話---------------------------------------------
        String getEmerPhone()
        {
            return this._emerPhone;
        }

        // ---------------------------------------------設置兵役狀態---------------------------------------------
        void setMilitary(String military)
        {
            this._military = military;
        }

        // ---------------------------------------------取得兵役狀態---------------------------------------------
        String getMilitary()
        {
            return this._military;
        }

        // ---------------------------------------------設置工作狀態---------------------------------------------
        void setJobState(String jobState)
        {
            this._jobState = jobState;
        }

        // ---------------------------------------------取得工作狀態---------------------------------------------
        String getJobState()
        {
            return this._jobState;
        }

        // ---------------------------------------------設置婚姻狀態---------------------------------------------
        void setMarriedState(String marriedState)
        {
            this._marriedState = marriedState;
        }

        // ---------------------------------------------取得婚姻狀態---------------------------------------------
        String getMarriedState()
        {
            return this._marriedState;
        }

        // ---------------------------------------------設置配偶---------------------------------------------
        void setSpouse(String spouse)
        {
            this._spouse = spouse;
        }

        // ---------------------------------------------取得配偶---------------------------------------------
        String getSpouse()
        {
            return this._spouse;
        }

        // ---------------------------------------------設置出生日期---------------------------------------------
        void setBirth(DateTime birth)
        {
            this._birth = birth;
        }

        // ---------------------------------------------取得出生日期---------------------------------------------
        DateTime getBirth()
        {
            return this._birth;
        }

        // ---------------------------------------------設置底薪---------------------------------------------
        void setBasicSalary(float basicSalary)
        {
            this._basicSalary = basicSalary;
        }

        // ---------------------------------------------取得底薪---------------------------------------------
        float getBasicSalary()
        {
            return this._basicSalary;
        }

        // ---------------------------------------------設置所屬部門編號---------------------------------------------
        void setDeptId(String deptId)
        {
            this._deptId = deptId;
        }

        // ---------------------------------------------取得所屬部門編號---------------------------------------------
        String getDeptId()
        {
            return this._deptId;
        }

        // ---------------------------------------------設置職位編號---------------------------------------------
        void setPositionId(String positionId)
        {
            this._positionId = positionId;
        }

        // ---------------------------------------------取得職位編號---------------------------------------------
        String getPositionId()
        {
            return this._positionId;
        }

    }
}
