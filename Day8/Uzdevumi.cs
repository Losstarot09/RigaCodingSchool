using System;
using System.Text;

namespace Day8
{
    class Uzdevumi
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool check = false;
            while (!check)
            {
                Console.Write("Lūdzu. ievadiet veselo skaitļi 1 vai extra, lai izpildīt attiecīgo uzdevumu \n" +
                    " (exit, lai izietu no programmas): ");
                switch (Console.ReadLine().Trim())
                {
                    case "1":
                        {
                            Random random = new Random();
                            int size = random.Next(6) + 5;
                            int[] intArray = new int[size];
                            for (int i = 0; i < size; i++)
                            {
                                intArray[i] = random.Next(10) + 1;
                            }
                            Console.WriteLine("Sakumā int[] = " + String.Join(", ", intArray));
                            Console.WriteLine("Parveidots int[] = " + String.Join(", ", Task1.GetOnlySmallValues(intArray)));
                            break;
                        }
                    case "extra":
                        {
                            Console.Write("Lūdzu ievadiet paroli: ");
                            if (PasswordValidator.PasswordValidate(Console.ReadLine()))
                            {
                                Console.WriteLine("Parole ir derīga!");
                            }
                            else
                            {
                                Console.WriteLine("Parole ir nederīga");
                            }
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
