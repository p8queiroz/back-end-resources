using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_tech.DesignPattern.Singleton
{
    public  class Ticket
    {
        
        //by assinging null to the instance, it guaranteers lazy load
        private static Ticket instance = null;

        private Ticket() { }

        public int ID { get; set; }
        public decimal Value { get; set; }

        //todo
        public static Ticket Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Ticket();
                }

                return instance;
            }
        }  

        public void GetInfo()
        {
            Console.WriteLine($"{instance.ID} - {instance.Value}");
        }

    }
}
