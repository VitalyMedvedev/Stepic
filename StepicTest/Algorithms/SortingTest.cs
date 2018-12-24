using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Stepic.Algorithms;

namespace StepicTest.Algorithms
{
	[TestFixture]
	public class SortingTest
	{
		[Test]
		public void SortCounting()
		{
			var sortedArray = _sorting.SortCouting(_array, 10);
			Assert.AreEqual(sortedArray[0], 2);
			Assert.AreEqual(sortedArray[1], 2);
			Assert.AreEqual(sortedArray[2], 3);
			Assert.AreEqual(sortedArray[3], 9);
			Assert.AreEqual(sortedArray[4], 9);
		}

		[SetUp]
		public void Init()
		{
			_array = new List<int> {2, 3, 9, 2, 9};
			_sorting = new Sorting();
		}

		private Sorting _sorting;
		private List<int> _array;
	}
}
