using NUnit.Framework;

namespace aruodas.ltOOPInheritance0731vak.Tests
{
    internal class TestAttributes
    {
        [Test]
        public void firstTest()
        {
            Console.WriteLine("first test");
        }
        [Test]
        public void secondTest()
        {
            Console.WriteLine("second test");
        }

        [OneTimeSetUp]
        public void setUp()
        {
            Console.WriteLine("set up");
        }
        [OneTimeTearDown]
        public void DownUp()
        {
            Console.WriteLine("Tear Down");
        }
    }
}
