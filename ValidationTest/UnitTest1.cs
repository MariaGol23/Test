using NUnit.Framework;
using Testing;

namespace ValidationTest
{
    public class Tests
    {
        Validation validation = new Validation();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSymbolsCount()
        {
           


            Assert.AreEqual(true,validation.SymbolsCount("1234567"));
        }
        [Test]
        public void TestPhoneMask()
        {
            Assert.AreEqual(true, false, "сообщение");
        }
        [Test]
        public void TestEmail()
        {
            Assert.AreEqual(true, validation.Email("42mari@gmail.com."), "Bad email format");
        }
        [Test]
        public void TestPolo()
        {
            Assert.AreEqual(true, validation.Positive("1201898"), "сообщение");
        }
        [Test]
        public void TestGroup()
        {
            Assert.AreEqual(true, false, "сообщение");
        }
        [Test]
        public void TestStrogo()
        {
            Assert.AreEqual(true, false, "сообщение");
        }
        [Test]
        public void TestYear()
        {
            Assert.AreEqual(true, validation.Year("2485"), "сообщение");
        }
    }
}