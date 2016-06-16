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
    public class DepartmentModelTests
    {
        DepartmentModel _department;
        PrivateObject _target;

        [TestInitialize()]
        public void Initialize()
        {
            _department = new DepartmentModel();
            _target = new PrivateObject(_department);
        }
        [TestMethod()]
        public void TestDepartmentID()
        {
            _department.SetDepartmentID("testdepID");
            Assert.AreEqual("testdepID", _department.GetDepartmentID());
        }

        [TestMethod()]
        public void TestDepartmentName()
        {
            _department.SetDepartmentName("testdepName");
            Assert.AreEqual("testdepName", _department.GetDepartmentName());
        }

        [TestMethod()]
        public void TestDepartmentStartTime()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 6, 16);
            _department.SetDepartmentStartTime(dateTime);
            Assert.AreEqual(dateTime, _department.GetDepartmentStartTime());
        }

        [TestMethod()]
        public void TestDepartmentEndTime()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 6, 20);
            _department.SetDepartmentEndTime(dateTime);
            Assert.AreEqual(dateTime, _department.GetDepartmentEndTime());
        }

        [TestMethod()]
        public void TestDepartmentManager()
        {
            _department.SetDepartmentManager("People");
            Assert.AreEqual("People", _department.GetDepartmentManager());
        }
    }
}
