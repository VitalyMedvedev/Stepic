using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stepic.Algorithms;

namespace StepicTest.Algorithms
{
	[TestClass]
	public class GreatestCommonDivisorTest
	{
		public GreatestCommonDivisorTest()
		{
			_greatestCommonDivisor = new GreatestCommonDivisor();
		}

		[TestMethod]
		public void GetInput1()
		{
			var greatestCommonDivisor = _greatestCommonDivisor.Get(18, 35);
			Assert.AreEqual(greatestCommonDivisor, 1);
		}

		[TestMethod]
		public void GetInput2()
		{
			var greatestCommonDivisor = _greatestCommonDivisor.Get(14159572, 63967072);
			Assert.AreEqual(greatestCommonDivisor, 4);
		}

		private readonly GreatestCommonDivisor _greatestCommonDivisor;
	}
}
