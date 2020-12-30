using NUnit.Framework;
using Stepic.Algorithms;

namespace StepicTest.Algorithms
{
    [TestFixture]
    public class SimpleCalcTest
    {
        [Test]
        public void SequenceNumbers()
        {
            var res = _calc.SequenceNumbers(5);
            var count = res.Split(' ').Length - 1;
            Assert.IsTrue(count == 2);
            Assert.IsTrue("1 2 4 5" == res);
        }

        [SetUp]
        public void Init()
        {
            _calc = new SimpleCalc();
        }

        private SimpleCalc _calc;
    }
}
