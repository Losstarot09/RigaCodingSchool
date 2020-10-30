using System;
using System.Text;

namespace Day6
{
    class Body
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool check = false;
            while (!check)

            {
                Console.Write("Lūdzu. ievadiet veselo skaitļi no 1 līdz 3, vai extra, lai izpildīt attiecīgo uzdevumu \n" +
                    " (exit, lai izietu no programmas): ");
                switch (Console.ReadLine().Trim())
                {
                    case "1":
                        {
                            Task1.PrintGreeting();
                            Task1.PrintGreeting();
                            Task1.PrintGreeting();
                            break;
                        }
                    case "2":
                        {
                            Console.Write("Lūdzu, ievadiet vārdu: ");
                            string name = Console.ReadLine();
                            Console.Write("Lūdzu, ievadiet uzvārdu: ");
                            string surName = Console.ReadLine();
                            Console.WriteLine();
                            Task2.PrintMyName(name, surName);
                            break;
                        }
                   case "3":
                        {
                            Task3.PrintNameSurname(Task3.GetNameSurname());
                            break;
                        }
                    case "extra":
                        {

                            break;
                        }
                    case "exit":
                        {
                            check = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Lūdzu evadiet pareizo ciparu vai vardu!!!");
                            break;
                        }
                }
            }
        }
    }
}
