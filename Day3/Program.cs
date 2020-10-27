using System;

namespace Day3Tasks
{
    class Program
    {
        enum WeekDays
        {
            Pirmdiena,
            Otrdiena,
            Trešdiena,
            Ceturdiena,
            Piektdiena,
            Sestdiena,
            Svetdiena
        }
        public static void Task1()
        {
            int[] massiv1 = { 1, 6, 7, 78, 9, 9 };
            for (int i = 0; i < massiv1.Length; i++)
            {
                Console.Write(massiv1[i]);
                if (i+1 != massiv1.Length)
                {
                    Console.Write(", ");
                }
            }
        }

        public static void Task2()
        {
            Console.WriteLine("Vai Jūs gribāt pusdienu?");
            Boolean pusdienas = Boolean.Parse(Console.ReadLine());
            if (pusdienas)
            {
                Console.WriteLine("Jūsu pusdienas ir gatavas");
            }
            else
            {
                Console.WriteLine("Jums pusdienas nebūs");
            }
        }

        public static void Task3()
        {
            Boolean check = true;
            int i = 1;
            while (check)
            {
                Console.WriteLine(i);
                if (i == 20)
                {
                    Console.WriteLine("Cikls atkartojas {0} reizes", i);
                    break;
                }
                i++;
            }
        }

        public static void Task4()
        {
            Console.Write("Lūdzu, ievadiet cik reizes jāraksta \"Hello World!\": ");
            int cicle = int.Parse(Console.ReadLine());
            for (int i = 0; i < cicle; i++)
            {
                Console.WriteLine("Hello World!");
            }
        }

        public static void Task5()
        {
            int[] massiv1 = { 100, 200, 233, 66, 77, 98 };
            Console.Write("Masivs: ");
            for (int i = 0; i < massiv1.Length; i++)
            {
                Console.Write(massiv1[i]);
                if (i + 1 != massiv1.Length)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Pirmais elements masīvam ir : {0}", massiv1[0]);
            Console.WriteLine("Pedejais elements masīvam ir : {0}", massiv1[massiv1.Length - 1]);
        }

        public static void Task6()
        {
            int[] massiv1 = { 7, 4, 7, 3, 6, 9, 2 };
            Console.Write("Masivs: ");
            for (int i = 0; i < massiv1.Length; i++)
            {
                Console.Write(massiv1[i]);
                if (i + 1 != massiv1.Length)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            massiv1[3] = 10;
            Console.Write("Masiv: ");
            for (int i = 0; i < massiv1.Length; i++)
            {
                Console.Write(massiv1[i]);
                if (i + 1 != massiv1.Length)
                {
                    Console.Write(", ");
                }
            }
        }

        public static void Task7()
        {
            string[] names = { "Jānis", "Pēteris", "Andris" };
            Console.Write("Masiv: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i]);
                if (i + 1 != names.Length)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Masīva otrais elements: {0}", names[1]);
            names[2] = "Jekabs";
            Console.Write("Jaunais masivs: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i]);
                if (i + 1 != names.Length)
                {
                    Console.Write(", ");
                }
            }
        }

        public static void Task8()
        {
            WeekDays day = WeekDays.Piektdiena;
            Console.WriteLine(day);
        }

        public static void TaskExtraDay3()
        {
            int x;
            string number1;
            while (true)
            {
                Console.Write("Lūdzu, ievadiet skaitļi no 1 līdz 20: ");
                number1 = Console.ReadLine();
                if (!int.TryParse(number1, out x))
                {
                    Console.WriteLine("Jūs ievadījat nepareizu skaitļi");
                    continue;
                }
                if ( x < 1 || x > 20)
                {
                    Console.WriteLine("Skaitļis neatbilst uzdotam robežam [1 - 20]");
                    continue;
                }
                break;
            }
            int i = 1;
            while (i <= x)
            {
                for (int j = 1; j <= x; j++)
                {
                    Console.Write(j * i);
                    if (j < x)
                    {
                        Console.Write(" ");
                    }
                }
                if (i < x)
                {
                    Console.WriteLine();
                }
                i++;
            }
        }

        static void Main(string[] args)
        {
            bool check = false;
            while (!check)
            {
                Console.Write("Lūdzu. ievadiet veselo skaitļi no 1 līdz 8, vai extra, lai izpildīt attiecīgo uzdevumu (exit, lai izietu no programmas): ");
                string option = Console.ReadLine().Trim();
                switch (option)
                {
                    case "1":
                        {
                            Task1();
                            break;
                        }
                    case "2":
                        {
                            Task2();
                            break;
                        }
                    case "3":
                        {
                            Task3();
                            break;
                        }
                    case "4":
                        {
                            Task4();
                            break;
                        }
                    case "5":
                        {
                            Task5();
                            break;
                        }
                    case "6":
                        {
                            Task6();
                            break;
                        }
                    case "7":
                        {
                            Task7();
                            break;
                        }
                    case "8":
                        {
                            Task8();
                            break;
                        }
                    case "extra":
                        {
                            TaskExtraDay3();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Lūdzu evadiet pareizo ciparu vai vardu!!!");
                            break;
                        }
                }
                if ( option == "exit")
                {
                    check = true;
                }

            }
        }
    }
}
