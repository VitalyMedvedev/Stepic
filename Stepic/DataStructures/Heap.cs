using System.Collections.Generic;
using Stepic.Entities.Heap;

namespace Stepic.DataStructures
{
	public class Heap
	{
		public List<Node> BuildHeap(List<int> values)
		{
			var result = new List<Node>();
			var size = values.Count;
			for (var i = (size - 2) / 2; i >= 0; i--)
			{
				ShiftDown(i, values, result);
			}
			return result;
		}

		private void ShiftDown(int index, IList<int> values, IList<Node> nodes)
		{
			var maxIndex = index;
			var leftChild = GetLeftChild(index);
			if (leftChild <= values.Count - 1 && values[leftChild] < values[maxIndex])
				maxIndex = leftChild;
			var rightChild = GetRightChild(index);
			if (rightChild <= values.Count - 1 && values[rightChild] < values[maxIndex])
				maxIndex = rightChild;
			if (index != maxIndex)
			{
				var old = values[index];
				values[index] = values[maxIndex];
				values[maxIndex] = old;
				nodes.Add(new Node { ParrentIndex = index, Index = maxIndex });
				ShiftDown(maxIndex, values, nodes);
			}
		}

		private int GetLeftChild(int index)
		{
			return index * 2 + 1;
		}

		private int GetRightChild(int index)
		{
			return index * 2 + 2;
		}
	}
}
