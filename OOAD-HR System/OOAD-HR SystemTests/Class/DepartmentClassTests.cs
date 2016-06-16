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
    public class DepartmentClassTests
    {
        DepartmentClass _department;
        PrivateObject _target;

        [TestInitialize()]
        public void Initialize()
        {
            _department = new DepartmentClass();
            _target = new PrivateObject(_department);
        }
        [TestMethod()]
        public void TestDepartmentID()
        {
            _department.SetId("testdepID");
            Assert.AreEqual("testdepID", _department.GetId());
        }

        [TestMethod()]
        public void TestDepartmentName()
        {
            _department.SetName("testdepName");
            Assert.AreEqual("testdepName", _department.GetName());
        }

        [TestMethod()]
        public void TestDepartmentStartTime()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 6, 16);
            _department.SetStartTime(dateTime);
            Assert.AreEqual(dateTime, _department.GetStartTime());
        }

        [TestMethod()]
        public void TestDepartmentEndTime()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 6, 20);
            _department.SetEndTime(dateTime);
            Assert.AreEqual(dateTime, _department.GetEndTime());
        }

        [TestMethod()]
        public void TestDepartmentManager()
        {
            _department.SetManager("People");
            Assert.AreEqual("People", _department.GetManager());
        }
    }
}
