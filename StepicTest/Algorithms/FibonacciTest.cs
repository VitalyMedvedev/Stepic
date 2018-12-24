using NUnit.Framework;
using Stepic.Algorithms;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace StepicTest.Algorithms
{
	[TestFixture]
	public class FibonacciTest
	{
		[Test]
		public void GetFibonacciNumberIs3()
		{
			var number = _fibonacci.GetFibonacciNumber(3);
			Assert.AreEqual(number, 2);
		}

		[Test]
		public void GetFibonacciNumberIs12()
		{
			var number = _fibonacci.GetFibonacciNumber(12);
			Assert.AreEqual(number, 144);
		}

		[SetUp]
		public void Init()
		{
			_fibonacci = new Fibonacci();
		}

		private Fibonacci _fibonacci;
	}
}
