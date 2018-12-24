namespace Stepic.Algorithms
{
	public class BinarySearch
	{
		public int GetIndexKey(int[] array, int key)
		{
			var rightIndex = array.Length - 1;
			var leftIndex = 0;
			while (leftIndex <= rightIndex)
			{
				var mediumIndex = (rightIndex - leftIndex) / 2 + leftIndex;
				var keyMediumIndex = array[mediumIndex];
				if (key == keyMediumIndex) return mediumIndex + 1;
				if (key < keyMediumIndex) rightIndex = mediumIndex - 1;
				else leftIndex = mediumIndex + 1;
			}
			return -1;
		}
	}
}
