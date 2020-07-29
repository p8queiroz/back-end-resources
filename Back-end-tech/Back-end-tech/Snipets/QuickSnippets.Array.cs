using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Back_end_tech.Snipets
{
    public static partial class QuickSnippets
    {

        public static void ArrayOperations001()
        {
            // Create an array of four elements, and add values later
            string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars1 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] cars2 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" };


            //default value of an array?
            int[] i = new int[0];
            Console.WriteLine(i[0]);
        }

        public static int ArrayOperations002()
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
