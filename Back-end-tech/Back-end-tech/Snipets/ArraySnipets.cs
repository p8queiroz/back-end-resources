using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Back_end_tech.Snipets
{
    class ArraySnipets
    {
        public ArraySnipets()
        {
            var numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(4);
            numbers.Add(2);
            Numbers = numbers;
        }

        public List<int> Numbers { get; set; }

        public int GetEvenSum()
        {
            var sum = Numbers.Where(i => i % 2 == 0).Sum();
            return sum;
        }


    }
}
