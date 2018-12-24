using System.Collections.Generic;
using System.Linq;

namespace Stepic.Algorithms
{
	public class Huffman
	{
		public string GetDecodedCode(Dictionary<string, string> tableCodes, string code)
		{
			var result = "";
			for (var i = 0; i < code.Length; i++)
			{
				for (var j = 1; j <= code.Length - i; j++)
				{
					var symbol = code.Substring(i, j);
					if (!tableCodes.ContainsKey(symbol)) continue;
					result = result + tableCodes[symbol];
					i = i + j - 1;
					break;
				}
			}
			return result;
		}

		public string GetCodeHuffman(string arraySymbols)
		{
			var codes = new List<Entities.CodeHuffman>();
			var sortedSymbols = arraySymbols.GroupBy(x => x).ToList().OrderByDescending(x => x.Count()).ToList();
			for (var i = 0; i < sortedSymbols.Count; i++)
			{
				if (i == 0)
				{
					codes.Add(new Entities.CodeHuffman {Symbol = sortedSymbols[i].Key, Code = "0"});
					continue;
				}
				if (i == sortedSymbols.Count- 1)
				{
					codes.Add(new Entities.CodeHuffman {Symbol = sortedSymbols[i].Key, Code = codes[i - 1].Code.Replace('0', '1')});
					continue;
				}
				codes.Add(new Entities.CodeHuffman { Symbol = sortedSymbols[i].Key, Code = "1" + codes[i - 1].Code });
			}
			return arraySymbols.Select(value => codes.FirstOrDefault(x => x.Symbol == value)).Where(firstOrDefault => firstOrDefault != null).Aggregate("", (current, firstOrDefault) => current + firstOrDefault.Code);
		}
	}
}
