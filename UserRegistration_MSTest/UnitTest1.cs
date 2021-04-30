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
        public void TestFirstName()
        { 
            bool result = pattern.ValidateFirstName("Shubham");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestLastName()
        {
            bool result1 = pattern.ValidateLastName("Bodake");
            Assert.IsTrue(result1);
        }

        [TestMethod]
        public void TestEmail()
        {
            bool result2 = pattern.ValidateEmail("Shubham@gmail.com");
            Assert.IsTrue(result2);
        }

        [TestMethod]
        public void TestMobileNumber()
        {
            bool result3 = pattern.ValidateMobileNumber("91 7757929383");
            Assert.IsTrue(result3);
        }

        [TestMethod]
        public void TestPasswordRule1()
        {
            bool result4 = pattern.ValidateLastName("Shubhambodake");
            Assert.IsTrue(result4);
        }
    }
}
