namespace Stepic.Algorithms
{
	public class Fibonacci
	{
		public int GetFibonacciNumber(int number)
		{
			var array = new int[number + 1];
			array[0] = 0;
			array[1] = 1;
			for (var i = 2; i <= number; i++)
			{
				array[i] = array[i - 1] + array[i - 2];
			}
			return array[number];
		}
	}
}
