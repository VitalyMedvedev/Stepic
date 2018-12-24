using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stepic.Algorithms;
using Stepic.Entities;

namespace StepicTest.Algorithms
{
	[TestClass]
	public class GreedyAlgorithmsTest
	{
		public GreedyAlgorithmsTest()
		{
			_greedyAlgorithms = new GreedyAlgorithms();
		}

		[TestMethod]
		public void CoverSegmentsOfPoints()
		{
			var segments = new List<Segment>
			{
				new Segment {StartPosition = 4, EndPosition = 7},
				new Segment {StartPosition = 1, EndPosition = 3},
				new Segment {StartPosition = 2, EndPosition = 5},
				new Segment {StartPosition = 5, EndPosition = 6}
			};
			var points = _greedyAlgorithms.CoverSegmentsOfPoints(segments);
			Assert.AreEqual(points.Count, 2);
			Assert.AreEqual(points[0], 3);
			Assert.AreEqual(points[1], 6);
		}

		[TestMethod]
		public void ContinuousBackpack()
		{
			var products = new List<Product>
			{
				new Product {Price = 18, Volume = 3},
				new Product {Price = 20, Volume = 4},
				new Product {Price = 14, Volume = 2}
			};
			var price = _greedyAlgorithms.ContinuousBackpack(7, products);
			Assert.AreEqual(price, 42.000);
		}

		[TestMethod]
		public void ContinuousBackpackWhereVolumeBackpackMin()
		{
			var products = new List<Product>
			{
				new Product {Price = 1717, Volume = 8427},
				new Product {Price = 2852, Volume = 6912},
				new Product {Price = 4375, Volume = 8940},
				new Product {Price = 3316, Volume = 1601},
				new Product {Price = 3336, Volume = 9926}
			};
			var price = _greedyAlgorithms.ContinuousBackpack(9022, products);
			Assert.AreEqual(price, 6947.641);
		}

		[TestMethod]
		public void GetListTermsNumberWhereNumberIs3()
		{
			var termsNumber = _greedyAlgorithms.GetListTermsNumber(6);
			Assert.AreEqual(termsNumber.Count, 3);
			Assert.AreEqual(termsNumber[0], 1);
			Assert.AreEqual(termsNumber[1], 2);
			Assert.AreEqual(termsNumber[2], 3);
		}

		[TestMethod]
		public void GetListTermsNumberWhereNumberIs4()
		{
			var termsNumber = _greedyAlgorithms.GetListTermsNumber(4);
			Assert.AreEqual(termsNumber.Count, 2);
			Assert.AreEqual(termsNumber[0], 1);
			Assert.AreEqual(termsNumber[1], 3);
		}

		[TestMethod]
		public void GetListTermsNumberWhereNumberIs10()
		{
			var termsNumber = _greedyAlgorithms.GetListTermsNumber(6);
			Assert.AreEqual(termsNumber.Count, 3);
			Assert.AreEqual(termsNumber[0], 1);
			Assert.AreEqual(termsNumber[1], 2);
			Assert.AreEqual(termsNumber[2], 3);
		}

		private readonly GreedyAlgorithms _greedyAlgorithms;
	}
}
