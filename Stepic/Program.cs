using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stepic
{

	public class Res
	{
		public Res(double val, string desc)
		{
			Val = val;
			Descr = desc;
		}

		public double Val { get; set; }
		public string Descr { get; set; }
	}
	internal class Program
	{

		private static void Main()
		{
			var args = Console.ReadLine().Split(' ');
			var maxWeightBackpack = Convert.ToInt32(args[0]);
			var weightItems = new List<int>();
			var weightArgs = Console.ReadLine().Split(' ');
			for (var i = 0; i < weightArgs.Length; i++)
			{
				weightItems.Add(Convert.ToInt32(weightArgs[i]));
			}
			var result = Backpack(maxWeightBackpack, weightItems);
			Console.WriteLine(result);
		}

		private static int Backpack(int maxWeightBackpack, IList<int> weightItems)
		{
			var d = new int[maxWeightBackpack + 1, weightItems.Count + 1];
			for (var i = 1; i <= weightItems.Count; i++)
			{
				for (var w = 1; w <= maxWeightBackpack; w++)
				{
					d[w, i] = d[w, i - 1];
					if (weightItems[i - 1] <= w)
					{
						d[w, i] = Math.Max(d[w, i - 1], d[w - weightItems[i - 1], i - 1] + weightItems[i - 1]);
					}
				}
			}
			return d[maxWeightBackpack, weightItems.Count];
		}
	}
}
