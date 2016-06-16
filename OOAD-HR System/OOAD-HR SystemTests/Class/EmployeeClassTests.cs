using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD_HR_System.Class;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace OOAD_HR_System.Class.Tests
{
    [TestClass()]
    public class EmployeeClassTests
    {
        EmployeeClass _employee;
        PrivateObject _target;

        [TestInitialize()]
        public void Initialize()
        {
            _employee = new EmployeeClass();
            _target = new PrivateObject(_employee);
        }

        [TestMethod()]
        public void TestEmployeeId()
        {
            _employee.SetId("test01");
            Assert.AreEqual("test01", _employee.GetId());
        }

        [TestMethod()]
        public void TestEmployeeName()
        {
            _employee.SetName("String");
            Assert.AreEqual("String", _employee.GetName());
        }

        [TestMethod()]
        public void TestEmployeeSsn()
        {
            _employee.SetSsn("A123456789");
            Assert.AreEqual("A123456789", _employee.GetSsn());
        }

        [TestMethod()]
        public void TestEmployeeSex()
        {
            _employee.SetSex("Man");
            Assert.AreEqual("Man", _employee.GetSex());
        }

        [TestMethod()]
        public void TestEmployeeBlood()
        {
            _employee.SetBlood("O");
            Assert.AreEqual("O", _employee.GetBlood());
        }

        [TestMethod()]
        public void TestEmployeePhone()
        {
            _employee.SetPhone("0987654321");
            Assert.AreEqual("0987654321", _employee.GetPhone());
        }

        [TestMethod()]
        public void TestEmployeeAddress()
        {
            _employee.SetAddress("Taiwan,Taipei");
            Assert.AreEqual("Taiwan,Taipei", _employee.GetAddress());
        }

        [TestMethod()]
        public void TestEmployeeEmerPerson()
        {
            _employee.SetEmerPerson("TestName");
            Assert.AreEqual("TestName", _employee.GetEmerPerson());
        }

        [TestMethod()]
        public void TestEmployeeEmerPhone()
        {
            _employee.SetEmerPhone("0987987987");
            Assert.AreEqual("0987987987", _employee.GetEmerPhone());
        }

        [TestMethod()]
        public void TestEmployeeMilitary()
        {
            _employee.SetMilitary("NO");
            Assert.AreEqual("NO", _employee.GetMilitary());
        }

        [TestMethod()]
        public void TestEmployeeJobState()
        {
            _employee.SetJobState("On");
            Assert.AreEqual("On", _employee.GetJobState());
        }

        [TestMethod()]
        public void TestEmployeeMarriedState()
        {
            _employee.SetMarriedState("Lu");
            Assert.AreEqual("Lu", _employee.GetMarriedState());
        }

        [TestMethod()]
        public void TestEmployeeSpouse()
        {
            _employee.SetSpouse("Righthand");
            Assert.AreEqual("Righthand", _employee.GetSpouse());
        }

        [TestMethod()]
        public void TestEmployeeBirth()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 1, 30);
            _employee.SetBirth(dateTime);
            Assert.AreEqual(dateTime, _employee.GetBirth());
        }

        [TestMethod()]
        public void TestEmployeeBasicSalary()
        {
            _employee.SetBasicSalary(9999.99F);
            Assert.AreEqual(9999.99F, _employee.GetBasicSalary());
        }

        [TestMethod()]
        public void TestEmployeeDeptId()
        {
            String st = "test001";
            _employee.SetDeptId(st);
            Assert.AreEqual("test001", _employee.GetDeptId());
        }

        [TestMethod()]
        public void TestEmployeePositionId()
        {
            _employee.SetPositionId("A1");
            Assert.AreEqual("A1", _employee.GetPositionId());
        }
    }
}
