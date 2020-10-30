using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Task3
    {
        public static string GetNameSurname()
        {
            Console.Write("Lūdzu, ievadiet vārdu un uzvārdu: ");
            string nameSurname = Console.ReadLine();
            return nameSurname;
        }

        public static void PrintNameSurname(string nameSurname)
        {
            Console.WriteLine($"Jūsu vārds un uzvārds: {nameSurname}");
        }
    }
}
