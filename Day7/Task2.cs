using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Task2
    {
        public static void PrintNameSurname(string name, string surname)
        {
            Console.WriteLine(name);
            Console.WriteLine(surname);
        }

        public static void PrintNameSurname(string name)
        {
            Console.WriteLine(name);
        }

        public static void PrintNameAge(string name, int age = 99) 
        {
            Console.WriteLine($"{name}, {age} gadi");    
        }

        public static void NameSurname()
        {
            Console.Write("Lūdzu, ievadiet vārdu un uzvārdu ar atstārpi, vai tikai vārdu: ");
            string nameSurname = Console.ReadLine();
            nameSurname = nameSurname.Trim();
            if (nameSurname.Contains(" "))
            {
                string name = nameSurname.Substring(0, nameSurname.IndexOf(" ") - 1);
                string surname = nameSurname.Substring(nameSurname.IndexOf(" ") + 1, nameSurname.Length - nameSurname.IndexOf(" ") - 1);
                Task2.PrintNameSurname(name, surname);
                Console.Write("Lūdzu, ievadiet savu vecumu vai nospiediet ENTER: ");
                string age = Console.ReadLine();
                int ageTrue;
                if (int.TryParse(age, out ageTrue))
                {
                    Task2.PrintNameAge(name, ageTrue);
                }
                else
                {
                    Task2.PrintNameAge(name);
                }
            }
            else
            {
                Task2.PrintNameSurname(nameSurname);
                Console.Write("Lūdzu, ievadiet savu vecumu vai nospiediet ENTER: ");
                string age = Console.ReadLine();
                int ageTrue;
                if (int.TryParse(age, out ageTrue)) 
                {
                    Task2.PrintNameAge(nameSurname, ageTrue);
                }
                else
                {
                    Task2.PrintNameAge(nameSurname);
                }
            }

        }
    }
}
