using System;
using System.Configuration;

namespace Back_end_tech.DesignPattern.Factory.Ticket
{
    public class TicketFactory
    {
        public static ITicket Create ()
        {

            var config = Convert.ToBoolean(ConfigurationManager.AppSettings["setting1"]);
             
            if(config)
            {
                return Ticket.Create(1, "des", Status.Open, 10);
            }
            else
            {
                return PromoTicket.Create(1, "des");
            }

        }
    }
}
