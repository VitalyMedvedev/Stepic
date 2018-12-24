using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Stepic.Algorithms;

namespace StepicTest.Algorithms
{
	class QuickSortTest
	{
		[TestFixture]
		public class SortingTest
		{
			[Test]
			public void SortCounting()
			{
				_sorting.Quicksort(_array, 0, 5);
			}

			[SetUp]
			public void Init()
			{
				_array = new List<int> {2, 3, 9, 2, 9, 3};
				_sorting = new QuickSort();
			}

			private QuickSort _sorting;
			private IList<int> _array;
		}
	}
}
