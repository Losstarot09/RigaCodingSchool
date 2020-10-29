using System;
using System.Threading.Tasks.Dataflow;

namespace Day5Tasks
{
    class Program
    {

        public static void Task1()
        {
            int[] numbers = new int[10] { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8 };
            foreach (int elem in numbers)
            {
                Console.WriteLine(elem);
                if (elem == 22)
                {
                    break;
                }
            }
        }

        public static void Task2()
        {
            string[] names = new string[10] { "Artūrs", "Ivans", "Aleksandrs", "Romans", "Danils", 
                "Germans", "Mihails", "Marcis", "Juris", "Jānis" };
            string[] surnames = new string[10] { "Lobanovs", "Šutovs", "Bobrovskis", "Lapiņš", "Ozols",
                "Skripka", "Barda", "Barons", "Muzikants", "Šatro"};
            string[] namesSurnames = new string[10];
            for (int i = 0; i < 10; i++)
            {
                namesSurnames[i] = $"{names[i]} {surnames[i]}";
            }
            Console.WriteLine(String.Join(", ", names));
            Console.WriteLine(String.Join(", ", surnames));
            Console.WriteLine(String.Join(", ", namesSurnames));
        }

        public static void Task3()
        {
            int[] allNumbers = new int[9] { 4, 68, 7, 12, 56, 33, 1, 90, 4 };
            int count = 0;
            for (int i = 0; i < allNumbers.Length; i++)
            {
                if (allNumbers[i] > 15)
                {
                    count++;
                }
            }
            int[] chosenNumbers = new int[count];
        }

        public static void Task4()
        {

        }

        public static void Task5()
        {

        }

        public static void Task6()
        {

        }

        static void Main(string[] args)
        {
            bool check = false;
            while (!check)

            {
                Console.Write("Lūdzu. ievadiet veselo skaitļi no 1 līdz 6, vai extra, lai izpildīt attiecīgo uzdevumu \n" +
                    " (exit, lai izietu no programmas): ");
                switch (Console.ReadLine().Trim())
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
