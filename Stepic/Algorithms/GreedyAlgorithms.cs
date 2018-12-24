using System;
using System.Collections.Generic;
using System.Linq;

namespace Stepic.Algorithms
{
	public class GreedyAlgorithms
	{
		public IList<int> CoverSegmentsOfPoints(IList<Entities.Segment> segments)
		{
			var points = new List<int>();
			var sortedSegments = segments.OrderBy(s => s.EndPosition).ToList();
			var actualIndexSegment = 0;
			for (var i = 0; i < sortedSegments.Count; i++)
			{
				if (i == 0)
				{
					points.Add(sortedSegments[0].EndPosition);
				}
				else
				{
					if (sortedSegments[i].StartPosition <= sortedSegments[actualIndexSegment].EndPosition) continue;
					points.Add(sortedSegments[i].EndPosition);
					actualIndexSegment = i;
				}
			}
			return points;
		}

		public double ContinuousBackpack(int volumeBackpack, IList<Entities.Product> products)
		{
			double residualVolumeBackpack = volumeBackpack;
			double resultPrice = 0;
			var sortedProducts = products.OrderByDescending(p => (double)p.Price / p.Volume).ToList();
			foreach (var product in sortedProducts)
			{
				if (residualVolumeBackpack - product.Volume >= 0)
				{
					resultPrice += product.Price;
					residualVolumeBackpack -= product.Volume;
				}
				else
				{
					var ratioVolumes = residualVolumeBackpack / product.Volume;
					resultPrice += product.Price * ratioVolumes;
					residualVolumeBackpack -= product.Volume * ratioVolumes;
				}
			}
			return Math.Round(resultPrice, 3); 
		}

		public IList<int> GetListTermsNumber(int number)
		{
			var result = new List<int>();
			var sum = 0;
			for(var i = 1; i <= number; i++)
			{
				if((sum + i > (double) number / 2 && number - (sum + i) <= i) || number == 2)
					break;
				sum += i;
				result.Add(i);
			}
			if(sum < number)
				result.Add(number - sum);
			return result;
		}
	}
}
