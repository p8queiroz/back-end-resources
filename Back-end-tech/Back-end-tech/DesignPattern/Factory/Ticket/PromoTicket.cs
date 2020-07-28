using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Back_end_tech.DesignPattern.Factory.Ticket
{
    public class PromoTicket : ITicket
    {
        public PromoTicket()
        {
        }

        public PromoTicket(int iD, string description)
        {
            ID = iD;
            Description = description;
        }

        public int ID { get; set; }

        public string Description { get; set; }

       
        public Status GetStatus(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public decimal GetValue(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> NotCanceled(List<Ticket> tickets)
        {
            throw new NotImplementedException();
        }

        public static PromoTicket Create(int id, string description)
        {
            var entity = new PromoTicket(id, description);
            return entity;
        }


    }
}
