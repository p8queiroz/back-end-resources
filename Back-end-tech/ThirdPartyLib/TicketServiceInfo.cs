using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThirdPartyLib
{
    public class TicketServiceInfo : ITicketProvider
    {
        public IEnumerable<string> GetTicketsList()
        {
            Console.WriteLine("third party library...");
            Thread.Sleep(4000);
            return new List<string> { "this is the first", "this is the second" };
        }
    }
}
