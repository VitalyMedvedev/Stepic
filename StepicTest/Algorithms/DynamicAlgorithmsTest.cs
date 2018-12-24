using System.Collections.Generic;
using NUnit.Framework;
using Stepic.Algorithms;

namespace StepicTest.Algorithms
{
	[TestFixture]
	public class DynamicAlgorithmsTest
	{
		[Test]
		public void GetLargestSubsequenceWhere4ItemsArray()
		{
			var result = _dynamicAlgorithms.GetLargestSubsequence(_array);
			Assert.AreEqual(result, 3);
		}

		[Test]
		public void GetLargestSubsequenceWhere15ItemsArray()
		{
			_array = new List<int> {7, 2, 1, 3, 8, 4, 9, 1, 2, 6, 5, 9, 3, 8, 1};
			var result = _dynamicAlgorithms.GetLargestSubsequence(_array);
			Assert.AreEqual(result, 4);
		}

		[Test]
		public void GetLargestSubsequenceWhere5ItemsArray()
		{
			_array = new List<int> { 1, 1, 1, 1, 1 };
			var result = _dynamicAlgorithms.GetLargestSubsequence(_array);
			Assert.AreEqual(result, 5);
		}

		[Test]
		public void GetLargestSubsequenceWhere18ItemsArray()
		{
			_array = new List<int> { 1, 4, 4, 6, 7, 9, 12, 14, 14, 15, 17, 20, 22, 24, 24, 27, 30, 30 };
			var result = _dynamicAlgorithms.GetLargestSubsequence(_array);
			Assert.AreEqual(result, 6);
		}

		[Test]
		public void Backpack()
		{
			var result = _dynamicAlgorithms.Backpack(10, new List<int> {1, 4, 8});
			Assert.AreEqual(9, result);
		}

		[Test]
		public void GetEditDistanceWhereResult0()
		{
			var result = _dynamicAlgorithms.GetEditDistance("ab", "ab");
			Assert.AreEqual(result, 0);
		}

		[Test]
		public void GetEditDistanceWhereResult3()
		{
			var result = _dynamicAlgorithms.GetEditDistance("short", "ports");
			Assert.AreEqual(result, 3);
		}

		[SetUp]
		public void Init()
		{
			_array = new List<int> {3, 6, 7, 12};
			_dynamicAlgorithms = new DynamicAlgorithms();
		}

		private DynamicAlgorithms _dynamicAlgorithms;
		private List<int> _array;
	}
}
