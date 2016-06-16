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
    public class BonusDefModelTests
    {
        BonusDefModel _bonusDef;
        PrivateObject _target;

        [TestInitialize()]
        public void Initialize()
        {
            _bonusDef = new BonusDefModel();
            _target = new PrivateObject(_bonusDef);
        }

        [TestMethod()]
        public void TestID()
        {
            _bonusDef.SetBonusDefID("testdepID");
            Assert.AreEqual("testdepID", _bonusDef.GetBonusDefID());
        }

        [TestMethod()]
        public void TestName()
        {
            _bonusDef.SetBonusDefName("testDefName");
            Assert.AreEqual("testDefName", _bonusDef.GetBonusDefName());
        }

        [TestMethod()]
        public void TestDesc()
        {
            _bonusDef.SetBonusDefDesc("testtest");
            Assert.AreEqual("testtest", _bonusDef.GetBonusDefDesc());
        }

        [TestMethod()]
        public void TestCreateDate()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 6, 17);
            _bonusDef.SetBonusDefCreateDate(dateTime);
            Assert.AreEqual(dateTime, _bonusDef.GetBonusDefCreateDate());
        }

        [TestMethod()]
        public void TestEffiTime()
        {
            DateTime dateTime;
            dateTime = new DateTime(2016, 6, 21);
            _bonusDef.SetBonusDefEffiDate(dateTime);
            Assert.AreEqual(dateTime, _bonusDef.GetBonusDefEffiDate());
        }

        [TestMethod()]
        public void TestAmount()
        {
            _bonusDef.SetBonusDefAmount(81000.00F);
            Assert.AreEqual(81000.00F, _bonusDef.GetBonusDefAmount());
        }
    }
}
