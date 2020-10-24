using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_tech.Snipets
{
    public static partial class QuickSnippets
    {
        public static void Operation()
        {
            bool a = true;
            bool b = false;
            a ^= b; //Xor operator (result is true if the elements are different
            Console.WriteLine("Value of a = {0}", a);
        }


    }
}
