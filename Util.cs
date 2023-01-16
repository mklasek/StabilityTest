using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StabilityTest
{
    internal static class Util
    {
        public static long Median(List<long> list)
        {
            list.Sort();
            return list[list.Count / 2];
        }

        public static (int count, List<long> filtered) FilterZeros(long[] array)
        {

            List<long> filtered = new List<long>();
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    filtered.Add(array[i]);
                }
                else
                    count++;
            }

            return (count, filtered);
        }

        public static (int count, double avg, double avggap) ProcessSpikes(List<long> list, int WaitTime)
        {
            long median = Median(list);
            int spikes = 0;
            List<long> spikelist = new List<long>();
            List<double> spikegaps = new List<double>();
            int gap = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if ((median < 50 && list[i] > 70) || (median >= 50 && list[i] > (median * 1.5f)))
                {
                    spikes++;
                    spikelist.Add(list[i]);
                    spikegaps.Add(gap * WaitTime);
                    gap = 0;

                }
                else 
                {
                    gap++;
                }
            }

            double avgspike, avggap;
            if (spikelist.Any()) avgspike = spikelist.Average();
            else  avgspike = 0;

            if (spikegaps.Any()) avggap = spikegaps.Average();
            else avggap = 0;

            return (spikes, avgspike, avggap);
        }
    }
}
