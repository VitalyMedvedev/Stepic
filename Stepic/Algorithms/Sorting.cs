using System.Collections.Generic;

namespace Stepic.Algorithms
{
	public class Sorting
	{
		public IList<int> SortCouting(IList<int> array, int maxNumber)
		{
			var result = new int[array.Count];
			var b = new int[maxNumber + 1];
			for (var j = 0; j < array.Count; j++)
			{
				b[array[j]] = b[array[j]] + 1;
			}
			for (var i = 1; i <= maxNumber; i++)
			{
				b[i] = b[i] + b[i - 1];
			}
			for (var j = array.Count - 1; j >= 0; j--)
			{
				result[b[array[j]] - 1] = array[j];
				b[array[j]] = b[array[j]] - 1;
			}
			return result;
		}
	}
}
