using NUnit.Framework;
using TablizaUmnojeniya;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void GetResultTest()
        {
            var res = Program.GetResult(1, 3);
            Assert.AreEqual(3, res);
        }

        [Test]
        public void CheckValidateNegative()
        {
            var val = Program.Validate_(4, 2);
            Assert.IsFalse(val);
        }

        [Test]
        public void CheckValidatePositive()
        {
            var val = Program.Validate_(4, 4);
            Assert.IsTrue(val);

        }

        [Test]
        public void CheckIsEnd_Positive()
        {
            var end = Program.IsEnd_("n");
            Assert.IsTrue(end);
        }

        [Test]
        public void CheckIsEnd_Negative()
        {
            var end = Program.IsEnd_("b");
            Assert.IsFalse(end);
        }

    }

}