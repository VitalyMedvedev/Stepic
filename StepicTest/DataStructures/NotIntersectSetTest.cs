using System.Collections.Generic;
using NUnit.Framework;
using Stepic.DataStructures;
using Stepic.Entities;

namespace StepicTest.DataStructures
{
	[TestFixture]
	public class NotIntersectSetTest
	{
		[Test]
		public void GetRank1()
		{
			var result = _notIntersectSet.GetRank(new List<int> {10, 0, 5, 0, 3, 3}, new List<Union>
			{
				new Union {NumberFirstTable = 6, NumberSecondTable = 6},
				new Union {NumberFirstTable = 6, NumberSecondTable = 5},
				new Union {NumberFirstTable = 5, NumberSecondTable = 4},
				new Union {NumberFirstTable = 4, NumberSecondTable = 3}
			});
			Assert.AreEqual(result[0], 10);
			Assert.AreEqual(result[1], 10);
			Assert.AreEqual(result[2], 10);
			Assert.AreEqual(result[3], 11);
		}

		[Test]
		public void GetRank2()
		{
			var result =_notIntersectSet.GetRank(new List<int> {1, 1, 1, 1, 1 }, new List<Union>
			{
				new Union {NumberFirstTable = 3, NumberSecondTable = 5},
				new Union {NumberFirstTable = 2, NumberSecondTable = 4},
				new Union {NumberFirstTable = 1, NumberSecondTable = 4},
				new Union {NumberFirstTable = 5, NumberSecondTable = 4},
				new Union {NumberFirstTable = 5, NumberSecondTable = 3}
			});

			Assert.AreEqual(result[0], 2);
			Assert.AreEqual(result[1], 2);
			Assert.AreEqual(result[2], 3);
			Assert.AreEqual(result[3], 5);
			Assert.AreEqual(result[4], 5);
		}

		[SetUp]
		public void Init()
		{
			_notIntersectSet = new NotIntersectSet();
		}

		private NotIntersectSet _notIntersectSet;
	}
}
