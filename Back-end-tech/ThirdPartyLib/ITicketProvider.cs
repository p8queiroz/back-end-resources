using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdPartyLib
{
    public interface ITicketProvider
    {
        public IEnumerable<string> GetTicketsList();
    }
}
