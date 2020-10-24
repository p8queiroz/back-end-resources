using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Back_end_tech.Snipets
{
    public static partial class QuickSnippets
    {

        public static void StringOperation001()
        {
            int a = 11 / 2;
            int b = 9 / 2;
            var c = 10 * 4 / 2; //division first
            Console.WriteLine("hello! {0} # {1} # {2} " , a, b, c);

        }


        public static StringBuilder GetDuplicateCharacter(string _title)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder duplicateChar = new StringBuilder();

            foreach (var item in _title)
            {
                if (result.ToString().IndexOf(item.ToString().ToLower()) == -1)
                {
                    result.Append(item);
                }
                else
                {
                    duplicateChar.Append(item);
                }
            }

            return duplicateChar;
        }

        public static void TrimOperation()
        {
            string[] text = { "Tesouro Direto", 
                "Fundos de Investimentos", 
                "COE", 
                "Mercado Secundario", 
                "Secundario Tit Publico",
                "Renda Fixa",
                "Plataformas Profissionais",
                "Serviços"};

            foreach (var item in text)
            {
                Console.WriteLine(item.Replace(" ", ""));
            }

        }

    }
}
