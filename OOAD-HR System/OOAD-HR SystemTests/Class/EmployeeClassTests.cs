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
        public void EmployeeIdTest()
        {
            _employee.SetId("test01");
            Assert.AreEqual("test01", _employee.GetId());
        }

        [TestMethod()]
        public void EmployeeNameTest()
        {
            _employee.SetName("String");
            Assert.AreEqual("String", _employee.GetName());
        }

        [TestMethod()]
        public void EmployeeSsnTest()
        {
            _employee.SetSsn("A123456789");
            Assert.AreEqual("A123456789", _employee.GetSsn());
        }

        [TestMethod()]
        public void EmployeeSexTest()
        {
            _employee.SetSex("Man");
            Assert.AreEqual("Man", _employee.GetSex());
        }

        [TestMethod()]
        public void EmployeeBloodTest()
        {
            _employee.SetBlood("O");
            Assert.AreEqual("O", _employee.GetBlood());
        }

        [TestMethod()]
        public void EmployeePhoneTest()
        {
            _employee.SetPhone("0987654321");
            Assert.AreEqual("0987654321", _employee.GetPhone());
        }

        [TestMethod()]
        public void EmployeeAddressTest()
        {
            _employee.SetAddress("Taiwan,Taipei");
            Assert.AreEqual("Taiwan,Taipei", _employee.GetAddress());
        }

        [TestMethod()]
        public void EmployeeEmerPersonTest()
        {
            _employee.SetEmerPerson("TestName");
            Assert.AreEqual("TestName", _employee.GetEmerPerson());
        }

        [TestMethod()]
        public void EmployeeEmerPhoneTest()
        {
            _employee.SetEmerPhone("0987987987");
            Assert.AreEqual("0987987987", _employee.GetEmerPhone());
        }

        [TestMethod()]
        public void EmployeeMilitaryTest()
        {
            _employee.SetMilitary("NO");
            Assert.AreEqual("NO", _employee.GetMilitary());
        }

        [TestMethod()]
        public void EmployeeJobStateTest()
        {
            _employee.SetJobState("On");
            Assert.AreEqual("On", _employee.GetJobState());
        }

        [TestMethod()]
        public void EmployeeMarriedStateTest()
        {
            _employee.SetMarriedState("Lu");
            Assert.AreEqual("Lu", _employee.GetMarriedState());
        }

        [TestMethod()]
        public void EmployeeSpouseTest()
        {
            _employee.SetSpouse("Righthand");
            Assert.AreEqual("Righthand", _employee.GetSpouse());
        }

        [TestMethod()]
        public void EmployeeBirthTest()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 1, 30);
            _employee.SetBirth(dateTime);
            Assert.AreEqual(dateTime, _employee.GetBirth());
        }

        [TestMethod()]
        public void EmployeeBasicSalaryTest()
        {
            _employee.SetBasicSalary(9999.99F);
            Assert.AreEqual(9999.99F, _employee.GetBasicSalary());
        }

        [TestMethod()]
        public void EmployeeDeptIdTest()
        {
            String st = "test001";
            _employee.SetDeptId(st);
            Assert.AreEqual("test001", _employee.GetDeptId());
        }

        [TestMethod()]
        public void EmployeePositionIdTest()
        {
            _employee.SetPositionId("A1");
            Assert.AreEqual("A1", _employee.GetPositionId());
        }

    }
}
