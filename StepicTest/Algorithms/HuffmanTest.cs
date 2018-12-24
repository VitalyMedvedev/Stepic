using NUnit.Framework;
using Stepic.Algorithms;
using System.Collections.Generic;

namespace StepicTest.Algorithms
{
	[TestFixture]
	public class HuffmanTest
	{
		[Test]
		public void GetCodeHuffman()
		{
			var code = _huffman.GetCodeHuffman("abacabad");
			Assert.AreEqual(code, "01001100100111");
		}

		[Test]
		public void GetDecodedCode()
		{
			var tableCodes = new Dictionary<string, string> {{"0", "a"}, {"10", "b"}, {"110", "c"}, {"111", "d"}};
			var code = _huffman.GetDecodedCode(tableCodes, "01001100100111");
			Assert.AreEqual(code, "abacabad");
		}

		[SetUp]
		public void Init()
		{
			_huffman = new Huffman();
		}

		private Huffman _huffman;
	}
}
