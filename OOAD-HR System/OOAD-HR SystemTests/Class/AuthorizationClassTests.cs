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
    public class AuthorizationClassTests
    {
        AuthorizationClass _autho;
        PrivateObject _target;

        [TestInitialize()]
        public void Initialize()
        {
            _autho = new AuthorizationClass();
            _target = new PrivateObject(_autho);
        }

        [TestMethod()]
        public void TestId()
        {
            _autho.SetId("testID");
            Assert.AreEqual("testID", _autho.GetId());
        }

        [TestMethod()]
        public void TestName()
        {
            _autho.SetName("testName");
            Assert.AreEqual("testName", _autho.GetName());
        }

        [TestMethod()]
        public void TestValue()
        {
            _autho.SetValue("testValue");
            Assert.AreEqual("testValue", _autho.GetValue());
        }
    }
}
