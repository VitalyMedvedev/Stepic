using System.Collections.Generic;
using NUnit.Framework;
using Stepic.DataStructures;

namespace StepicTest.DataStructures
{
	[TestFixture]
	public class HashTableTest
	{
		[Test]
		public void GetNames()
		{
			var result = _hashTable.GetNames(new List<string>
			{
				"add 911 police",
				"add 76213 Mom",
				"add 17239 Bob",
				"find 76213",
				"find 910",
				"find 911",
				"del 910",
				"del 911",
				"find 911",
				"find 76213",
				"add 76213 daddy",
				"find 76213"
			});

			Assert.AreEqual(result[0], "Mom");
			Assert.AreEqual(result[1], "not found");
			Assert.AreEqual(result[2], "police");
			Assert.AreEqual(result[3], "not found");
			Assert.AreEqual(result[4], "Mom");
			Assert.AreEqual(result[5], "daddy");
		}

		[SetUp]
		public void Init()
		{
			_hashTable = new HashTable();
		}

		private HashTable _hashTable;
	}
}
