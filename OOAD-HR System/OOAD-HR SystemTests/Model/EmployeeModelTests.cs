using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD_HR_System.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace OOAD_HR_System.Model.Tests
{
    [TestClass()]
    public class EmployeeModelTests
    {
        EmployeeModel _employee;
        PrivateObject _target;

        [TestInitialize()]
        public void Initialize()
        {
            _employee = new EmployeeModel();
            _target = new PrivateObject(_employee);
        }

        [TestMethod()]
        public void GetEmplIDTest()
        {
            _employee.SetEmplID("TestID01");
            Assert.AreEqual("TestID01", _employee.GetEmplID());
        }

        [TestMethod()]
        public void GetNameTest()
        {
            _employee.SetName("TestName");
            Assert.AreEqual("TestName", _employee.GetName());
        }

        [TestMethod()]
        public void GetSsnTest()
        {
            _employee.SetSsn("A123456789");
            Assert.AreEqual("A123456789", _employee.GetSsn());
        }

        [TestMethod()]
        public void GetSexTest()
        {
            _employee.SetSex("Female");
            Assert.AreEqual("Female", _employee.GetSex());
        }

        [TestMethod()]
        public void GetBloodTest()
        {
            _employee.SetBlood("O");
            Assert.AreEqual("O",_employee.GetBlood());
        }

        [TestMethod()]
        public void GetPhoneTest()
        {
            _employee.SetPhone("0987654321");
            Assert.AreEqual("0987654321",_employee.GetPhone());
        }

        [TestMethod()]
        public void GetAddressTest()
        {
            _employee.SetAddress("Taiwan");
            Assert.AreEqual("Taiwan",_employee.GetAddress());
        }

        [TestMethod()]
        public void GetEmerPersonTest()
        {
            _employee.SetEmerPerson("EmTest");
            Assert.AreEqual("EmTest",_employee.GetEmerPerson());
        }

        [TestMethod()]
        public void GetEmerPhoneTest()
        {
            _employee.SetEmerPhone("0987987987");
            Assert.AreEqual("0987987987",_employee.GetEmerPhone());
        }

        [TestMethod()]
        public void GetMilitaryStatusTest()
        {
            _employee.SetMilitaryStatus("免役");
            Assert.AreEqual("免役",_employee.GetMilitaryStatus());
        }

        [TestMethod()]
        public void GetJobStatusTest()
        {
            _employee.SetJobStatus("在職");
            Assert.AreEqual("在職",_employee.GetJobStatus());
        }

        [TestMethod()]
        public void GetMarriedStatusTest()
        {
            _employee.SetMarriedStatus("已婚");
            Assert.AreEqual("已婚",_employee.GetMarriedStatus());
        }

        [TestMethod()]
        public void GetSpouseTest()
        {
            _employee.SetSpouse("右手");
            Assert.AreEqual("右手",_employee.GetSpouse());
        }

        [TestMethod()]
        public void GetBirthTest()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 2, 29);
            _employee.SetBirth(dateTime);
            Assert.AreEqual(dateTime,_employee.GetBirth());
        }

        [TestMethod()]
        public void GetBasicSalaryTest()
        {
            _employee.SetBasicSalary(39.08F);
            Assert.AreEqual(39.08F,_employee.GetBasicSalary());
        }

        [TestMethod()]
        public void GetDeptIDTest()
        {
            _employee.SetDeptID("testD01");
            Assert.AreEqual("testD01",_employee.GetDeptID());
        }

        [TestMethod()]
        public void GetPositionIDTest()
        {
            _employee.SetPositoinID("testP01");
            Assert.AreEqual("testP01",_employee.GetPositionID());
        }
    }
}
