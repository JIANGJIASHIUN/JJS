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
    public class AuthorizationModelTests
    {
        AuthorizationModel _autho;
        PrivateObject _target;

        [TestInitialize()]
        public void Initialize()
        {
            _autho = new AuthorizationModel();
            _target = new PrivateObject(_autho);
        }

        [TestMethod()]
        public void TestAuthoID()
        {
            _autho.SetAuthoID("testID");
            Assert.AreEqual("testID", _autho.GetAuthoID());
        }

        [TestMethod()]
        public void TestAuthoName()
        {
            _autho.SetAuthoName("testName");
            Assert.AreEqual("testName", _autho.GetAuthoName());
        }

        [TestMethod()]
        public void TestAuthoValue()
        {
            _autho.SetAuthoValue("testValue");
            Assert.AreEqual("testValue", _autho.GetAuthoValue());
        }
    }
}
