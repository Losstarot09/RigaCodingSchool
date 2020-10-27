using System;

namespace Day1Tasks
{
    class Program
    {
        public static void Task1()
        {
            Console.WriteLine("Artūrs Lobanovs");
        }

        public static void Task2()
        {
            int i = 1;
            double d = 0.1d;
            bool b = new bool();
            string s = new string("");
            b = true;
            s = "string";
            Console.WriteLine("i = " + i);
            Console.WriteLine("d = " + d);
            Console.WriteLine("b = " + b);
            Console.WriteLine("s = " + s);
        }

        public static void Task3()
        {
            int x = new int();
            int y = new int();
            x = 10;
            y = 15;
            int z = new int();
            z = x + y;
            Console.WriteLine(z);
        }

        public static void Task4()
        {
            Console.Write("Lūdzu, ievadiet savu vārdu: ");
            string name = Console.ReadLine();
            Console.Write("Lūdzu, ievadiet savu uzvārdu: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Jūs sauc {0} {1}", name, surname);
        }

        public static void Task5()
        {
            Console.Write("Lūdzu, ievadiet savu vārdu: ");
            string name = Console.ReadLine();
            Console.Write("Lūdzu, ievadiet savu uzvārdu: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Jūs sauc {0}. {1}{2}", name.Substring(0, 1).ToUpper(), surname.Substring(0, 1).ToUpper(),
                surname.Substring(1, surname.Length - 1).ToLower());
        }

        public static void TaskExtraDay1()
        {
            Console.Write("Lūdzu, ievadiet simbolus un/vai ciparus mainīgam a: ");
            string a = Console.ReadLine();
            Console.Write("Lūdzu, ievadiet simbolus un/vai ciparus mainīgam b: ");
            string b = Console.ReadLine();
            int al = a.Length;
            a = a + b;
            b = a.Substring(0, al);
            a = a.Substring(al, a.Length - b.Length);
            Console.WriteLine("Tagad maģija - Jūsu mainīgie apmainījas ar vertībam!");
            Console.WriteLine("a = {0}; b = {1}", a, b);
        }

        static void Main(string[] args)
        {
            bool check = false;
            while (!check)
            {
                Console.Write("Lūdzu. ievadiet veselo skaitļi no 1 līdz 5, vai extra, lai izpildīt attiecīgo uzdevumu: ");
                switch (Console.ReadLine().Trim())
                {
                    case "1":
                        {
                            Task1();
                            check = true;
                            break;
                        }
                    case "2":
                        {
                            Task2();
                            check = true;
                            break;
                        }
                    case "3":
                        {
                            Task3();
                            check = true;
                            break;
                        }
                    case "4":
                        {
                            Task4();
                            check = true;
                            break;
                        }
                    case "5":
                        {
                            Task5();
                            check = true;
                            break;
                        }
                    case "extra":
                        {
                            TaskExtraDay1();
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
