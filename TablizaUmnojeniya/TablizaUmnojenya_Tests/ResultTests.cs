using NUnit.Framework;
using TablizaUmnojeniya;

namespace Tests
{
    [TestFixture]
    public class ResultText
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetResultTest()
        {
            var result = Program.GetResult(1, 2);
            Assert.AreEqual(2, result);
        }
    }
}