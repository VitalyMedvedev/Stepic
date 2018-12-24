using NUnit.Framework;
using Stepic.Algorithms;

namespace StepicTest.Algorithms
{
	[TestFixture]
	public class BinarySearchTest
	{
		[Test]
		public void GetIndexKeyWhereKeyIs8()
		{
			var index = _binarySearch.GetIndexKey(_array, 8);
			Assert.AreEqual(index, 3);
		}

		[Test]
		public void GetIndexKeyWhereKeyIs23()
		{
			var index = _binarySearch.GetIndexKey(_array, 23);
			Assert.AreEqual(index, -1);
		}

		[Test]
		public void GetIndexKeyWhereKeyIs11()
		{
			var index = _binarySearch.GetIndexKey(_array, 11);
			Assert.AreEqual(index, -1);
		}

		[Test]
		public void GetIndexKeyWhereKeyIs1()
		{
			var index = _binarySearch.GetIndexKey(_array, 1);
			Assert.AreEqual(index, 1);
		}

		[Test]
		public void GetIndexKeyWhereKeyIs13()
		{
			var index = _binarySearch.GetIndexKey(_array, 13);
			Assert.AreEqual(index, 5);
		}

		[SetUp]
		public void Init()
		{
			_binarySearch = new BinarySearch();
			_array = new[] {1, 5, 8, 12, 13};
		}

		private BinarySearch _binarySearch;
		private int[] _array;
	}
}
