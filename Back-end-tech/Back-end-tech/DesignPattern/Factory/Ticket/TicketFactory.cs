using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_tech.DesignPattern.Factory
{
    public class TicketFactory
    {
        public static Ticket Create ()
        {
            return Ticket.Create(1, "des", Status.Open, 10);
        }
    }
}
