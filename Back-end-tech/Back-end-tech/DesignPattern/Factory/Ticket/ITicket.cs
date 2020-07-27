using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_tech.DesignPattern.Factory
{
    interface ITicket
    {

        public Ticket Ticket();
        public void Create();

        public Status Status(Ticket ticket);

        public decimal Value(Ticket ticket);

        public List<Ticket> NotCanceled(List<Ticket> tickets);
    }
}
