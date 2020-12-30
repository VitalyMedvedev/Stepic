using Stepic.Entities;
using System.Collections.Generic;

namespace Stepic.Algorithms
{
    public class SimpleCalc
    {
        public string SequenceNumbers(int number)
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
            
            while(index > 0)
            {
                stack.Push(index);
                index = array[index].PreviousStep;
                 
            }
            var res = "";
            while(stack.Count > 0)
            {
                if(res != "")
                {
                    res += " ";
                }
                res += stack.Pop();

            }
            return res;
        }

        private void Calculate(Step[] array, int i, int calcValue)
        {
            if(calcValue > array.Length - 1)
            {
                return;
            }
            if (!(array[calcValue].StepNumber != 0 && array[calcValue].StepNumber <= array[i].StepNumber + 1))
            {
                array[calcValue] = new Step { StepNumber = array[i].StepNumber + 1, PreviousStep = i };
            }
        }
    }
}
