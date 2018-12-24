using System.Collections.Generic;
using NUnit.Framework;
using Stepic.DataStructures;

namespace StepicTest.DataStructures
{
	[TestFixture]
	public class StackTest
	{
		[Test]
		public void IsBalanced1()
		{
			var result = _stack.IsBalanced("{[]}()");
			Assert.AreEqual(result, "Success");
		}

		[Test]
		public void IsBalanced2()
		{
			var result = _stack.IsBalanced("{");
			Assert.AreEqual(result, "1");
		}

		[Test]
		public void IsBalanced3()
		{
			var result = _stack.IsBalanced("foo(bar[i)");
			Assert.AreEqual(result, "10");
		}

		[Test]
		public void IsBalanced4()
		{
			var result = _stack.IsBalanced("foo(bar)");
			Assert.AreEqual(result, "Success");
		}

		[Test]
		public void IsBalanced5()
		{
			var result = _stack.IsBalanced("()[]}");
			Assert.AreEqual(result, "5");
		}

		[Test]
		public void IsBalanced6()
		{
			var result = _stack.IsBalanced("{}([]");
			Assert.AreEqual(result, "3");
		}

		[Test]
		public void GetArrayHighs1()
		{
			var result = _stack.GetArrayHighs(new List<string> {"push 2", "push 1", "max", "pop", "max" });
			Assert.AreEqual(result[0], 2);
			Assert.AreEqual(result[1], 2);
		}

		[Test]
		public void GetArrayHighs2()
		{
			var result = _stack.GetArrayHighs(new List<string> { "push 7", "push 1", "push 7", "max", "pop", "max" });
			Assert.AreEqual(result[0], 7);
			Assert.AreEqual(result[1], 7);
		}

		[Test]
		public void GetArrayHigh2()
		{
			var result = _stack.GetArrayHighs(new List<string> { "push 1", "push 2", "max", "pop", "max" });
			Assert.AreEqual(result[0], 2);
			Assert.AreEqual(result[1], 1);
		}

		[Test]
		public void GetArrayHigh3()
		{
			var result = _stack.GetArrayHighs(new List<string> { "push 2", "push 3", "push 9", "push 7", "push 2", "max", "max", "max", "pop", "max" });
			Assert.AreEqual(result[0], 9);
			Assert.AreEqual(result[1], 9);
			Assert.AreEqual(result[2], 9);
			Assert.AreEqual(result[3], 9);
		}

		[Test]
		public void GetHeight()
		{
			var result = _stack.GetHeightTree(new List<int> { 9, 7, 5, 5, 2, 9, 9, 9, 2 , -1});
			Assert.AreEqual(result, 4);
		}

		[Test]
		public void GetHeight1()
		{
			var result = _stack.GetHeightTree(new List<int> { 4, -1, 4, 1, 1 });
			Assert.AreEqual(result, 3);
		}

		[Test]
		public void GetMax()
		{
			var result = _stack.GetMax(new List<int> { 2, 7, 3, 1, 5, 2, 6, 2 }, 4);
			Assert.AreEqual(result[0], 7);
			Assert.AreEqual(result[1], 7);
			Assert.AreEqual(result[2], 5);
			Assert.AreEqual(result[3], 6);
			Assert.AreEqual(result[4], 6);
		}

		[Test]
		public void GetMax1()
		{
			var result = _stack.GetMax(new List<int> { 2, 7, 3, 1, 5, 2, 6, 2 }, 2);
			Assert.AreEqual(result[0], 7);
			Assert.AreEqual(result[1], 7);
			Assert.AreEqual(result[2], 3);
			Assert.AreEqual(result[3], 5);
			Assert.AreEqual(result[4], 5);
		}

		[Test]
		public void GetMax2()
		{
			var result = _stack.GetMax(new List<int> { 73, 65, 24, 14, 44, 20, 65, 97, 27, 6, 42, 1, 6, 41, 16 }, 7);
			Assert.AreEqual(result[0], 73);
			Assert.AreEqual(result[1], 97);
			Assert.AreEqual(result[2], 97);
			Assert.AreEqual(result[3], 97);
			Assert.AreEqual(result[4], 97);
			Assert.AreEqual(result[5], 97);
			Assert.AreEqual(result[6], 97);
			Assert.AreEqual(result[7], 97);
			Assert.AreEqual(result[8], 42);
		}

		[SetUp]
		public void Init()
		{
			_stack = new Stack();
		}

		private Stack _stack;
	}
}
