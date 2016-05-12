using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD_HR_System.Class;

namespace OOAD_HR_System.PresentationModel
{
    public class EmployeePresentationModel
    {

        private EmployeeClass _employee = new EmployeeClass();

        // 建構子
        public EmployeePresentationModel()
        {

        }

        // 設置員工id
        public void SetEmplID(String emplID)
        {
            this._employee.SetId(emplID);
        }

        // 取得員工ID
        public String GetEmplID()
        {
            return this._employee.GetId();
        }

        // 設置員工姓名
        public void SetName(String name)
        {
            this._employee.SetName(name);
        }

        // 取得員工姓名
        public String GetName()
        {
            return this._employee.GetName();
        }

        // 設置員工身分證字號
        public void SetSsn(String ssn)
        {
            this._employee.SetSsn(ssn);
        }

        // 取得員工身分證字號
        public String GetSsn()
        {
            return this._employee.GetSsn();
        }

        // 設置員工性別
        public void SetSex(String sex)
        {
            this._employee.SetSex(sex);
        }

        // 取得員工性別
        public String GetSex()
        {
            return this._employee.GetSex();
        }

        // 設置員工血型
        public void SetBlood(String blood)
        {
            this._employee.SetBlood(blood);
        }

        // 取得員工血型
        public String GetBlood()
        {
            return this._employee.GetBlood();
        }

        // 設置員工連絡電話
        public void SetPhone(String phone)
        {
            this._employee.SetPhone(phone);
        }

        // 取得員工聯絡電話
        public String GetPhone()
        {
            return this._employee.GetPhone();
        }

        // 設置員工聯絡地址
        public void SetAddress(String address)
        {
            this._employee.SetAddress(address);
        }

        // 取得員工聯絡地址
        public String GetAddress()
        {
            return this._employee.GetAddress();
        }

        // 設置員工緊急聯絡人姓名
        public void SetEmerPerson(String emerPerson)
        {
            this._employee.SetEmerPerson(emerPerson);
        }

        // 取得員工緊急聯絡人姓名
        public String GetEmerPerson()
        {
            return this._employee.GetEmerPerson();
        }

        // 設置員工緊急聯絡電話
        public void SetEmerPhone(String emerPhone)
        {
            this._employee.SetEmerPhone(emerPhone);
        }

        // 取得員工緊急聯絡電話
        public String GetEmerPhone()
        {
            return this._employee.GetEmerPhone();
        }

        // 設置員工兵役狀態
        public void SetMilitaryStatus(String military)
        {
            this._employee.SetMilitary(military);
        }

        // 取得員工兵役狀態
        public String GetMilitaryStatus()
        {
            return this._employee.GetMilitary();
        }

        // 設置員工工作狀態
        public void SetJobStatus(String jobStatus)
        {
            this._employee.SetJobState(jobStatus);
        }

        // 取得員工工作狀態
        public String GetJobStatus()
        {
            return this._employee.GetJobState();
        }

        // 設置員工婚姻狀態
        public void SetMarriedStatus(String marriedStatus)
        {
            this._employee.SetMarriedState(marriedStatus);
        }

        // 取得員工婚姻狀態
        public String GetMarriedStatus()
        {
            return this._employee.GetMarriedState();
        }

        // 設置員工配偶
        public void SetSpouse(String spouse)
        {
            this._employee.SetSpouse(spouse);
        }

        // 取得員工配偶
        public String GetSpouse()
        {
            return this._employee.GetSpouse();
        }

        // 設置員工出生年月日
        public void SetBirth(DateTime birth)
        {
            this._employee.SetBirth(birth);
        }

        // 取得員工出生年月日
        public DateTime GetBirth()
        {
            return this._employee.GetBirth();
        }

        // 設置員工底薪
        public void SetBasicSalary(float basicSalary)
        {
            this._employee.SetBasicSalary(basicSalary);
        }

        // 取得員工底薪
        public float GetBasicSalary()
        {
            return this._employee.GetBasicSalary();
        }

        // 設置員工所屬部門ID
        public void SetDeptID(String deptID)
        {
            this._employee.SetDeptId(deptID);
        }

        // 取得員工所屬部門ID
        public String GetDeptID()
        {
            return this._employee.GetDeptId();
        }

        // 設置員工職位ID
        public void SetPositoinID(String positionID)
        {
            this._employee.SetPositionId(positionID);
        }

        // 取得員工職位ID
        public String GetPositionID()
        {
            return this._employee.GetPositionId();
        }
    }
}
