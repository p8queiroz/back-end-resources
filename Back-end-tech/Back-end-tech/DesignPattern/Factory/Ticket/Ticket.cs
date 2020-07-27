using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_tech.DesignPattern.Factory
{
    //by default, the associations for a enum are int
    public enum Status
    {
        Open = 0,
        Progress = 1,
        Closed  = 2
    }

    public partial class Ticket    {
        protected Ticket() { }

        private Ticket(int id, string description, Status status, decimal value)
        {
            ID = id;
            Description = description;
            Status = status;
            Value = value;
        }

        public int ID { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public decimal Value { get; set; }
       
    }
}
