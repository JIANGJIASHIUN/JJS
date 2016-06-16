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
    public class WorkAttendanceModelTests
    {
        WorkAttendanceModel _workAttendance;
        PrivateObject _target;

        [TestInitialize()]
        public void Initialize()
        {
            _workAttendance = new WorkAttendanceModel();
            _target = new PrivateObject(_workAttendance);
        }

        [TestMethod()]
        public void TestWAEmplID()
        {
            _workAttendance.SetWAEmplID("testWAEID");
            Assert.AreEqual("testWAEID", _workAttendance.GetWAEmplID());
        }

        [TestMethod()]
        public void TestWADate()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 6, 15);
            _workAttendance.SetWADate(dateTime);
            Assert.AreEqual(dateTime, _workAttendance.GetWADate());
        }

        [TestMethod()]
        public void TestWAStatus()
        {
            _workAttendance.SetWAStatus("testFatCat");
            Assert.AreEqual("testFatCat", _workAttendance.GetWAStatus());
        }

        [TestMethod()]
        public void TestStartTime()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 6, 12);
            _workAttendance.SetStartTime(dateTime);
            Assert.AreEqual(dateTime, _workAttendance.GetStartTime());
        }

        [TestMethod()]
        public void TestEndTime()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 6, 28);
            _workAttendance.SetEndTime(dateTime);
            Assert.AreEqual(dateTime, _workAttendance.GetEndTime());
        }

        [TestMethod()]
        public void TestIsOvertime()
        {
            _workAttendance.SetIsOvertime(false);
            Assert.IsTrue(!_workAttendance.GetIsOvertime());
        }

        [TestMethod()]
        public void TestStartOvertime()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 6, 29);
            _workAttendance.SetStartOvertime(dateTime);
            Assert.AreEqual(dateTime, _workAttendance.GetStartOvertime());
        }

        [TestMethod()]
        public void TestEndOverTime()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 6, 30);
            _workAttendance.SetEndOvertime(dateTime);
            Assert.AreEqual(dateTime, _workAttendance.GetEndOvertime());
        }
    }
}
