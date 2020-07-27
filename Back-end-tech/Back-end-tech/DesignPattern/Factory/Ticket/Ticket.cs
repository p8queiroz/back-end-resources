using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_tech.DesignPattern.Factory
{
    //by default, the associations for a enum are int
    enum Status
    {
        Open = 0,
        Progress = 1,
        Closed  = 2
    }

    public partial class Ticket
    {
        int ID { get; set; }
        string Description { get; set; }
        Status status { get; set; }
        decimal Value { get; set; }
        
    }
}
