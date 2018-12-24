using System.Collections.Generic;

namespace Stepic.Algorithms
{
	public class QuickSort
	{
		private static int Partition(IList<int> array, int start, int end)
		{
			int temp;//swap helper
			var marker = start;//divides left and right subarrays
			for (var i = start; i <= end; i++)
			{
				if (array[i] >= array[end]) continue;
				temp = array[marker]; // swap
				array[marker] = array[i];
				array[i] = temp;
				marker += 1;
			}
			//put pivot(array[end]) between left and right subarrays
			temp = array[marker];
			array[marker] = array[end];
			array[end] = temp;
			return marker;
		}

		public void Quicksort(IList<int> array, int start, int end)
		{
			if (start >= end)
			{
				return;
			}
			var pivot = Partition(array, start, end);
			Quicksort(array, start, pivot - 1);
			Quicksort(array, pivot + 1, end);
		}
	}
}
