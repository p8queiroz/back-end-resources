using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_tech.Snipets
{
    public static class QuickSnippets
    {

        public static void MathRound()
        {
            //If the fractional component of d is halfway
            //between two integers, one of which is even and the other odd, the even number
            //is returned.
            Console.WriteLine(Math.Round(6.5));
            Console.WriteLine(Math.Round(7.5));
        }


    }
}
