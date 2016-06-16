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
    public class PositionClassTests
    {

        PositionClass _position;
        PrivateObject _target;

        [TestInitialize()]
        public void Initialize()
        {
            _position = new PositionClass();
            _target = new PrivateObject(_position);
        }

        [TestMethod()]
        public void TestId()
        {
            _position.SetId("testPosiID");
            Assert.AreEqual("testPosiID", _position.GetId());
        }

        [TestMethod()]
        public void TestName()
        {
            _position.SetName("testPosiName");
            Assert.AreEqual("testPosiName", _position.GetName());
        }

        [TestMethod()]
        public void TestBasicSalary()
        {
            _position.SetBasicSalary(81000.00F);
            Assert.AreEqual(81000.00F, _position.GetBasicSalary());
        }

        [TestMethod()]
        public void TestAuthoId()
        {
            _position.SetAuthoId("testAuthoID");
            Assert.AreEqual("testAuthoID", _position.GetAuthoId());
        }
    }
}
