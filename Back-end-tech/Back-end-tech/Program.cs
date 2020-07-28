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
            //This is a bad practice
            //if I want to swap?
            //var ticket = new Ticket();

            //Factory Pattern
            //benefits: future changes to constructed objects are now centrally locate
            //var ticket = TicketFactory.Create();

            //Singleton Pattern
            var ticket = DesignPattern.Singleton.Ticket.Create(10, 2323);
            Console.WriteLine(ticket.Value);


        }
    }
}
