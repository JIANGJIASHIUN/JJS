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
    public class BonusClassTests
    {

        BonusClass _bonus;
        PrivateObject _target;

        [TestInitialize()]
        public void Initialize()
        {
            _bonus = new BonusClass();
            _target = new PrivateObject(_bonus);
        }

        [TestMethod()]
        public void TestBonusDefID()
        {
            _bonus.SetBonusDefID("testBonusID");
            Assert.AreEqual("testBonusID", _bonus.GetBonusDefID());
        }

        [TestMethod()]
        public void TestEmplID()
        {
            _bonus.SetEmplID("testEmplID");
            Assert.AreEqual("testEmplID", _bonus.GetEmplID());
        }

        [TestMethod()]
        public void TestBonusDate()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 6, 20);
            _bonus.SetBonusDate(dateTime);
            Assert.AreEqual(dateTime, _bonus.GetBonusDate());
        }

        [TestMethod()]
        public void TestBonusT()
        {
            _bonus.SetBonusT("testID");
            Assert.AreEqual("testID", _bonus.GetBonusT());
        }
    }
}
