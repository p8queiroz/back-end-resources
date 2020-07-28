using Back_end_tech.DesignPattern.Factory.Ticket;
using  Back_end_tech.DesignPattern.Singleton;
using System;

namespace Back_end_tech
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to my source playground!");






            //******************************************************Singleton Pattern
            /*var ticket = DesignPattern.Singleton.Ticket.Instance;

            ticket.ID = 1;
            ticket.Value = 200;

            var newTicket = DesignPattern.Singleton.Ticket.Instance;

            newTicket.ID = 2;
            newTicket.Value = 300;

            ticket.GetInfo();
            newTicket.GetInfo();

            Console.ReadKey();*/




            //******************************************************Factory Pattern
            //This is a bad practice
            //if I want to swap?
            //var ticket = new Ticket();

            //Factory Pattern
            //benefits: future changes to constructed objects are now centrally locate
            //var ticket = TicketFactory.Create();




        }
    }
}
