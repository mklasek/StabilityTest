using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net;

namespace StabilityTest
{
    internal class Pinger
    {
        private String destination;
        public String Destination { get { return destination; } }


        public Pinger() 
        {
            destination = "bing.com";
        }

        public bool TestPingSetAddr(String address)
        {
            Ping p = new Ping();
            PingReply reply;
            
            try
            {
                reply = p.Send(address, 500);
                if (reply.Status == IPStatus.Success) 
                {
                    destination = address;
                    return true;
                }
                else
                    return false;
            }
            catch 
            {
                return false;
            }

        }

        public long[] PingTest(int NumOfPings, int WaitTime, IProgress<int> progress)
        {
            long[] results = new long[NumOfPings];
            float progcalc = 0f;

            Ping p = new Ping();
            PingReply reply;

            for (int i = 0; i < NumOfPings; i++)
            {
                Thread.Sleep(WaitTime);

                progcalc = ((float)i / (float)NumOfPings) * 100f;
                progress.Report((int)progcalc);

                try
                {
                    reply = p.Send(destination, 1000);
                    if (reply.Status == IPStatus.Success)
                    {
                        results[i] = reply.RoundtripTime;
                    }
                    else
                        continue;
                }
                catch
                {
                    continue;
                }
            }
            progress.Report(100);
            return results;

        }


    }
}


