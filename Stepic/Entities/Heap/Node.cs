namespace Stepic.Entities.Heap
{
	public class Node
	{
		public int ParrentIndex { get; set; }
		public int Index { get; set; }

		public override bool Equals(object obj)
		{
			var node = obj as Node;
			return node != null && Equals(node);
		}

		protected bool Equals(Node other)
		{
			return ParrentIndex == other.ParrentIndex && Index == other.Index;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (ParrentIndex * 397) ^ Index;
			}
		}
	}
}
