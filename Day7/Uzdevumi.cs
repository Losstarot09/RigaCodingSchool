using System;
using System.Text;

namespace Day7
{
    class Uzdevumi
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool check = false;
            while (!check)

            {
                Console.Write("Lūdzu. ievadiet veselo skaitļi no 2 līdz 6, vai extra, lai izpildīt attiecīgo uzdevumu \n" +
                    " (exit, lai izietu no programmas): ");
                switch (Console.ReadLine().Trim())
                {
                    case "2":
                        {
                            Task2.NameSurname();
                            break;
                        }
                    case "3":
                        {
                            Task3.PrintArrayIntOrString();
                            break;
                        }
                    case "4":
                        {
                            string[] arrayString = new string[] { "Jānis", "", "Pēteris", "Antons", "", "Andris" };
                            Task4.GetNonEmptyArray(arrayString);
                            break;
                        }
                    case "5":

                        {
                            Console.WriteLine("x = un y = ");
                            Console.WriteLine(Task5.CalculateSum());
                            int x = 5;
                            int y = x;
                            Console.WriteLine($"x = {x} un y = {y}");
                            Console.WriteLine("x + y = " + Task5.CalculateSum(x, y));
                            x = 3;
                            y = 15;
                            Console.WriteLine($"x = {x} un y = {y}");
                            Console.WriteLine("x + y = " + Task5.CalculateSum(x, y));
                            x = -10;
                            y = 6;
                            Console.WriteLine($"x = {x} un y = {y}");
                            Console.WriteLine("x + y = " + Task5.CalculateSum(x, y));
                            break;
                        }
                    case "6":
                        {
                            Console.Write("Lūdzu, ievadiet Jūsu personas kodu: ");
                            string personId = Console.ReadLine();
                            if (Task6.ValidatePersonId(personId))
                            {
                                Console.WriteLine("Personas koda ir pareizs");
                                Console.Write("Jūsu dzimšanas diena ir ");
                                Task6.PrintBirthday(personId);
                            }
                            else
                            {
                                Console.WriteLine("Personas kods nav pareizs");
                            }
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
