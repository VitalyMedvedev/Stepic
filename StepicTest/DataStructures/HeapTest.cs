using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Stepic.DataStructures;
using Stepic.Entities.Heap;

namespace StepicTest.DataStructures
{
	[TestFixture]
	public class HeapTest
	{
		[Test]
		public void GetHeap()
		{
			var result =_heap.BuildHeap(new List<int> {5, 4, 3, 2, 1});
			Assert.AreEqual(result[0], new Node {ParrentIndex = 1, Index = 4} );
			Assert.AreEqual(result[1], new Node { ParrentIndex = 0, Index = 1 });
			Assert.AreEqual(result[2], new Node { ParrentIndex = 1, Index = 3 });
		}

		[SetUp]
		public void Init()
		{
			_heap = new Heap();
		}

		private Heap _heap;
	}
}
