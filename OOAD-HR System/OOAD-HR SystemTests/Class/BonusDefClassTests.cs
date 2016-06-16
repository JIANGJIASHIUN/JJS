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
    public class BonusDefClassTests
    {
        BonusDefClass _bonusDef;
        PrivateObject _target;

        [TestInitialize()]
        public void Initialize()
        {
            _bonusDef = new BonusDefClass();
            _target = new PrivateObject(_bonusDef);
        }
        [TestMethod()]
        public void TestID()
        {
            _bonusDef.SetId("testdepID");
            Assert.AreEqual("testdepID", _bonusDef.GetId());
        }

        [TestMethod()]
        public void TestName()
        {
            _bonusDef.SetName("testDefName");
            Assert.AreEqual("testDefName", _bonusDef.GetName());
        }

        [TestMethod()]
        public void TestDesc()
        {
            _bonusDef.SetDesc("testtest");
            Assert.AreEqual("testtest", _bonusDef.GetDesc());
        }

        [TestMethod()]
        public void TestCreateDate()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 6, 17);
            _bonusDef.SetCreateDate(dateTime);
            Assert.AreEqual(dateTime, _bonusDef.GetCreateDate());
        }

        [TestMethod()]
        public void TestEffiTime()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 6, 21);
            _bonusDef.SetEffiTime(dateTime);
            Assert.AreEqual(dateTime, _bonusDef.GetEffiTime());
        }

        [TestMethod()]
        public void TestAmount()
        {
            _bonusDef.SetAmount(81000.00F);
            Assert.AreEqual(81000.00F, _bonusDef.GetAmount());
        }
    }
}
