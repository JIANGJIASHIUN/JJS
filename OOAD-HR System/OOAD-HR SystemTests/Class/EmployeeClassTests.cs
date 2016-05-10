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
            _employee.setId("test01");
            Assert.AreEqual("test01", _employee.getId());
        }

        [TestMethod()]
        public void EmployeeNameTest()
        {
            _employee.setName("String");
            Assert.AreEqual("String", _employee.getName());
        }

        [TestMethod()]
        public void EmployeeSsnTest()
        {
            _employee.setSsn("A123456789");
            Assert.AreEqual("A123456789", _employee.getSsn());
        }

        [TestMethod()]
        public void EmployeeSexTest()
        {
            _employee.setSex("Man");
            Assert.AreEqual("Man", _employee.getSex());
        }

        [TestMethod()]
        public void EmployeeBloodTest()
        {
            _employee.setBlood("O");
            Assert.AreEqual("O", _employee.getBlood());
        }

        [TestMethod()]
        public void EmployeePhoneTest()
        {
            _employee.setPhone("0987654321");
            Assert.AreEqual("0987654321", _employee.getPhone());
        }

        [TestMethod()]
        public void EmployeeAddressTest()
        {
            _employee.setAddress("Taiwan,Taipei");
            Assert.AreEqual("Taiwan,Taipei", _employee.getAddress());
        }

        [TestMethod()]
        public void EmployeeEmerPersonTest()
        {
            _employee.setEmerPerson("TestName");
            Assert.AreEqual("TestName", _employee.getEmerPerson());
        }

        [TestMethod()]
        public void EmployeeEmerPhoneTest()
        {
            _employee.setEmerPhone("0987987987");
            Assert.AreEqual("0987987987", _employee.getEmerPhone());
        }

        [TestMethod()]
        public void EmployeeMilitaryTest()
        {
            _employee.setMilitary("NO");
            Assert.AreEqual("NO", _employee.getMilitary());
        }

        [TestMethod()]
        public void EmployeeJobStateTest()
        {
            _employee.setJobState("On");
            Assert.AreEqual("On", _employee.getJobState());
        }

        [TestMethod()]
        public void EmployeeMarriedStateTest()
        {
            _employee.setMarriedState("Lu");
            Assert.AreEqual("Lu", _employee.getMarriedState());
        }

        [TestMethod()]
        public void EmployeeSpouseTest()
        {
            _employee.setSpouse("Righthand");
            Assert.AreEqual("Righthand", _employee.getSpouse());
        }

        [TestMethod()]
        public void EmployeeBirthTest()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 1, 30);
            _employee.setBirth(dateTime);
            Assert.AreEqual(dateTime, _employee.getBirth());
        }

        [TestMethod()]
        public void EmployeeBasicSalaryTest()
        {
            _employee.setBasicSalary(9999.99F);
            Assert.AreEqual(9999.99F, _employee.getBasicSalary());
        }

        [TestMethod()]
        public void EmployeeDeptIdTest()
        {
            String st = "test001";
            _employee.setDeptId(st);
            Assert.AreEqual("test001", _employee.getDeptId());
        }

        [TestMethod()]
        public void EmployeePositionIdTest()
        {
            _employee.setPositionId("A1");
            Assert.AreEqual("A1", _employee.getPositionId());
        }

    }
}
