using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_tech.DesignPattern.Singleton
{
    public  class Ticket
    {
        public int ID { get; set; }
        public decimal Value { get; set; }


        private Ticket() { }
        
        private Ticket(int id, decimal value)
        {
            ID = id;
            Value = value;
        }

        public static Ticket Create(int id, decimal value)
        {
            var entity = new Ticket(id, value);
            return entity;
        }

    }
}
