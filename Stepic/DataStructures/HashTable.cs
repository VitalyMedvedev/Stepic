using System.Collections.Generic;
using System.Linq;

namespace Stepic.DataStructures
{
	public class HashTable
	{
		public List<string> GetNames(List<string> commands)
		{
			var result = new List<string>();
			var telephoneDirectory = new Dictionary<string, string>();
			foreach (var command in commands)
			{
				var partsCommand = command.Split(' ');
				if (partsCommand[0] == "add")
				{
					if (telephoneDirectory.ContainsKey(partsCommand[1]))
					{
						telephoneDirectory.Remove(partsCommand[1]);
					}
					telephoneDirectory.Add(partsCommand[1], partsCommand[2]);
					continue;
				}
				if (partsCommand[0] == "del")
				{
					telephoneDirectory.Remove(partsCommand[1]);
					continue;
				}
				if (partsCommand[0] == "find")
				{
					if(!telephoneDirectory.ContainsKey(partsCommand[1]))
						result.Add("not found");
					else
					{
						result.Add(telephoneDirectory[partsCommand[1]]);
					}
				}
			}
			return result;
		}
	}
}
