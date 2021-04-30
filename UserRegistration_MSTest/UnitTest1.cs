using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistration_Using_Exception;

namespace UserRegistration_MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestValidateFirstName()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.ValidateFirstName("Shubham");
            Assert.IsTrue(result);
        }
    }
}
