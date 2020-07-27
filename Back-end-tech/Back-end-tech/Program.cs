using Back_end_tech.DesignPattern.Factory;
using System;

namespace Back_end_tech
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a bad practice
            //if I want to swap?
            //var ticket = new Ticket();


            //benefits: future changes to constructed objects are now centrally locate
            var ticket = TicketFactory.Create();

            Console.WriteLine(ticket.ID);
            
        }
    }
}
