using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_tech.DesignPattern.Factory
{
    public static class TicketFactory
    {
        public static Ticket Create() 
        {
            return new Ticket();
        }
    }
}
