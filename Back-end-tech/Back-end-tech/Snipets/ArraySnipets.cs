using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Back_end_tech.Snipets
{
    public static class ArraySnipets
    {
        public static List<int> Numbers { get; set; }

        public static int GetEvenSum()
        {
            var numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(4);
            numbers.Add(2);
            Numbers = numbers;

            var sum = Numbers.Where(i => i % 2 == 0).Sum();
            return sum;
        }

    }
}
