﻿using Stepic.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stepic
{

	internal class Program
	{

		private static void Main()
		{
			var args = Console.ReadLine();
			var res = SequenceNumbers(Convert.ToInt32(args));
			var count = res.Split(' ').Length - 1;
			Console.WriteLine(count);
			Console.WriteLine(res);
		}


        public static string SequenceNumbers(int number)
        {
            var array = new Step[number + 1];
            array[1] = new Step { StepNumber = 0, PreviousStep = 0 };
            for (var i = 1; i < number + 1; i++)
            {
                Calculate(array, i, i * 2);
                Calculate(array, i, i * 3);
                Calculate(array, i, i + 1);
            }
            var index = number;
            var stack = new Stack<int>();

            while (index > 0)
            {
                stack.Push(index);
                index = array[index].PreviousStep;

            }
            var res = "";
            while (stack.Count > 0)
            {
                if (res != "")
                {
                    res += " ";
                }
                res += stack.Pop();

            }
            return res;
        }

        private static void Calculate(Step[] array, int i, int calcValue)
        {
            if (calcValue > array.Length - 1)
            {
                return;
            }
            if (!(array[calcValue].StepNumber != 0 && array[calcValue].StepNumber <= array[i].StepNumber + 1))
            {
                array[calcValue] = new Step { StepNumber = array[i].StepNumber + 1, PreviousStep = i };
            }
        }

        public struct Step
        {
            public int StepNumber { get; set; }
            public int PreviousStep { get; set; }
        }
	}
}
