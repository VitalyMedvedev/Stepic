namespace Stepic.Algorithms
{
	public class GreatestCommonDivisor
	{
		public int Get(int firstNumber, int secondNumber)
		{
			while (firstNumber != 0 && secondNumber != 0)
			{
				if (firstNumber >= secondNumber)
				{
					firstNumber = firstNumber % secondNumber;
				}
				else
				{
					secondNumber = secondNumber % firstNumber;
				}
			}
			return firstNumber == 0 ? secondNumber : firstNumber;
		}
	}
}
