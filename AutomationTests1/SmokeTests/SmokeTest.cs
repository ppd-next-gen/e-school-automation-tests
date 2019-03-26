using System;
using NUnit.Framework;


namespace AutomationTests1
{
    [TestFixture]
    public class SmokeTest
    {
        [Test]
        public void TestTrue()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void TestFalse()
        {
            Assert.IsTrue(false);
        }
    }
}
