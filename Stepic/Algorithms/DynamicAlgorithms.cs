using System;
using System.Collections.Generic;
using System.Linq;

namespace Stepic.Algorithms
{
	public class DynamicAlgorithms
	{
		public int GetLargestSubsequence(IList<int> array)
		{
			var arrayLargestSubsequence = new int[array.Count];
			for (var i = 0; i < array.Count; i++)
			{
				arrayLargestSubsequence[i] = 1;
				for (var j = 0; j < i; j++)
				{
					if (array[i] % array[j] == 0 && arrayLargestSubsequence[j] + 1 > arrayLargestSubsequence[i])
					{
						arrayLargestSubsequence[i] = arrayLargestSubsequence[j] + 1;
					}
				}
			}
			return arrayLargestSubsequence.Max(x => x);
		}

		public int GetEditDistance(string first, string second)
		{
			var array = new int[first.Length + 1, second.Length + 1];
			for (var i = 0; i <= first.Length; i++)
			{
				for (var j = 0; j <= second.Length; j++)
				{
					if (i == 0 && j == 0) array[i, j] = 0;
					else if(i == 0) array[i, j] = j;
					else if (j == 0) array[i, j] = i;
					else
					{
						var result1 = array[i, j - 1] + 1;
						var result2 = array[i - 1, j] + 1;
						var result3 = array[i - 1, j - 1] + (first.ToCharArray()[i - 1] == second.ToCharArray()[j - 1] ? 0 : 1);
						var result = Math.Min(Math.Min(result1, result2), result3);
						array[i, j] = result;
					}
				}
			}
			return array[first.Length, second.Length];
		}

		public int Backpack(int maxWeightBackpack, IList<int> weightItems)
		{
			var d = new int[maxWeightBackpack + 1, weightItems.Count + 1];
			for (var i = 1; i <= weightItems.Count; i++)
			{
				for (var w = 1; w <= maxWeightBackpack; w++)
				{
					d[w,i] = d[w, i - 1];
					if (weightItems[i-1] <= w)
					{
						d[w, i] = Math.Max(d[w, i-1], d[w - weightItems[i-1], i - 1] + weightItems[i-1]);
					}
				}
			}
			return d[maxWeightBackpack, weightItems.Count];
		}
	}
}
