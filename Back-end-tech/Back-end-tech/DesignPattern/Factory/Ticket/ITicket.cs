using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_tech.DesignPattern.Factory
{
    public interface ITicket
    {
        //You can't* define static members on an interface in C#. An interface is a contract for instances.
        //https://stackoverflow.com/questions/9415257/how-can-i-implement-static-methods-on-an-interface
         public static Ticket Create(int id, string description, Status status, decimal value) => throw new NotImplementedException();

        public Status GetStatus(Ticket ticket);

        public decimal GetValue(Ticket ticket);

        public List<Ticket> NotCanceled(List<Ticket> tickets);
    }
}
