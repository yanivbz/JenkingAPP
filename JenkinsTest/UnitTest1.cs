using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkingAPP;

namespace JenkinsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Message()
        {
            Assert.AreEqual("Test Jenkins", Program.CreateMessage());
        }
    }
}
