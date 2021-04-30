using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistration_Using_Exception;

namespace UserRegistration_MSTest
{
    [TestClass]
    public class UnitTest1
    {
        Pattern pattern = new Pattern();
        [TestMethod]
        public void TestValidateFirstName()
        { 
            bool result = pattern.ValidateFirstName("Shubham");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestValidateLastName()
        {
            bool result1 = pattern.ValidateLastName("Bodake");
            Assert.IsTrue(result1);
        }

        [TestMethod]
        public void TestValidateEmail()
        {
            bool result2 = pattern.ValidateEmail("Shubham@gmail.com");
            Assert.IsTrue(result2);
        }
    }
}
