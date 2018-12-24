using System;
using System.Collections.Generic;
using System.Linq;

namespace Stepic.DataStructures
{
	public class Stack
	{
		public string IsBalanced(string str)
		{
			var stack = new Stack<char>();
			var indexLastChar = 0;
			for (var i = 0; i < str.Length; i++)
			{
				if (stack.Count == 0) indexLastChar = i;
				if (!(str[i] == '(' || str[i] == '[' || str[i] == '{' || str[i] == ')' || str[i] == ']' || str[i] == '}'))
					continue;
				if (str[i] == '(' || str[i] == '[' || str[i] == '{')
				{
					stack.Push(str[i]);
				}
				else
				{
					if (stack.Count == 0) return (++i).ToString();
					var top = stack.Pop();
					if ((top == '(' && str[i] != ')') || (top == '[' && str[i] != ']') || (top == '{' && str[i] != '}'))
						return (++i).ToString();
					if (stack.Count == 0) indexLastChar = i;
				}
			}
			return stack.Count != 0 ? (++indexLastChar).ToString() : "Success";
		}

		public IList<int> GetArrayHighs(IEnumerable<string> tasks)
		{
			var result = new List<int>();
			var stack = new Stack<int>();
			var stackHighs = new Stack<int>();
			foreach (var task in tasks)
			{
				if (task.Contains("push "))
				{
					stack.Push(Convert.ToInt32(task.Replace("push ", "")));
					if (stackHighs.Count == 0 || stackHighs.Peek() < stack.Peek())
						stackHighs.Push(stack.Peek());
					else
						stackHighs.Push(stackHighs.Peek());
					continue;
				}
				if (task == "pop")
				{
					stack.Pop();
					stackHighs.Pop();
					continue;
				}
				if (task == "max")
				{
					if(stackHighs.Count != 0)
						result.Add(stackHighs.Peek());
					continue;
				}
			}
			return result;
		}

		public List<int> GetMax(List<int> values, int count)
		{
			if (count == 1) return values;
			var valueCount = values.Count;
			var stak1 = new Stack<int>();
			var stak2 = new Stack<int>();
			for (var i = 0; i < count - 1; i++)
			{
				stak1.Push(values[i]);
			}
			var stak1Count = stak1.Count;
			for (var i = 0; i < stak1Count; i++)
			{
				if(stak2.Count == 0 || stak1.Peek() > stak2.Peek())
					stak2.Push(stak1.Pop());
				else
				{
					stak1.Pop();
					stak2.Push(stak2.Peek());
				}
			}

			var stak2Count = stak2.Count;
			var result = new List<int>();
			var max = 0;
			for (var i = stak2Count; i < valueCount; i++)
			{
				if (stak2.Count == 0)
				{
					var st1Count = stak1.Count();
					for (var q = 0; q < st1Count; q++)
					{
						if(stak2.Count == 0)
							stak2.Push(stak1.Pop());
						else
						{
							if (stak2.Peek() > stak1.Peek())
							{
								stak2.Push(stak2.Peek());
								stak1.Pop();
							}
							else
							{
								stak2.Push(stak1.Pop());

							}

						}
					}
				}

				if (stak1.Count == 0)
				{
					max = values[i];
					stak1.Push(values[i]);
				}
				else
				{

					stak1.Push(values[i]);
					var newMax = Math.Max(stak1.Peek(), values[i]);
					if (max < newMax)
						max = newMax;
				}
				result.Add(Math.Max(max, stak2.Pop()));
			}
			return result;
		}

		public int GetHeightTree(IList<int> values)
		{
			_tree = new Dictionary<int, List<int>>();
			for (var i = 0; i < values.Count; i++)
			{
				if(!_tree.ContainsKey(values[i]))
					_tree.Add(values[i], new List<int> {i});
				else
					_tree[values[i]].Add(i);
			}
			return GetHeight(_tree[-1]);
		}

		private int GetHeight(IEnumerable<int> childrens)
		{
			var height = 1;
			foreach (var children in childrens)
			{
				if(_tree.ContainsKey(children))
					height = Math.Max(height, 1 + GetHeight(_tree[children]));
			}
			return height;
		}

		private Dictionary<int, List<int>> _tree;

	}
}
