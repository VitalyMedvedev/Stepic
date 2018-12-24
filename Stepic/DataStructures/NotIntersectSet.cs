using System.Collections.Generic;
using System.Linq;
using Stepic.Entities;

namespace Stepic.DataStructures
{
	public class NotIntersectSet
	{
		public List<long> GetRank(List<int> numberRowsTables, List<Union> unions)
		{
			var result = new List<long>();
			_parrent = new List<int>();
			_rank = new List<long>();
			_parrent.Add(0);
			_rank.Add(0);
			for (var i = 0; i < numberRowsTables.Count; i++)
			{
				_parrent.Add(i + 1);
				_rank.Add(numberRowsTables[i]);
			}
			foreach (var union in unions)
			{
				result.Add(Union(union.NumberFirstTable, union.NumberSecondTable));
			}
			return result;
		}

		private long Union(int j, int i)
		{
			var iId = Find(i);
			var jId = Find(j);
			if(iId == jId) return _rank.Max();
			if (_rank[iId] > _rank[jId])
			{
				_parrent[jId] = iId;
			}
			else
			{
				if (_rank[iId] == _rank[jId])
				{
					_parrent[jId] = iId;
				}
				else
				{
					_parrent[iId] = jId;
				}
			}
			_rank[iId] += _rank[jId];
			return _rank.Max();
		}

		private int Find(int position)
		{
			while (position != _parrent[position])
			{
				position = _parrent[position];
			}
			return position;
		}

		private List<int> _parrent;
		private List<long> _rank;
	}
}
