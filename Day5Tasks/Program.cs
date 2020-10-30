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
            count = 0;
            for (int i = 0; i < allNumbers.Length; i++) {
                if (allNumbers[i] > 15)
                {
                    chosenNumbers[count] = allNumbers[i];
                    count++;
                }
            }
            Console.WriteLine($"allnumbers = {String.Join(", ", allNumbers)}");
            Console.WriteLine();
            Console.WriteLine($"chosenNumbers = {String.Join(", ", chosenNumbers)}");

        }

        public static void Task4()
        {
            string[] names = new string[5] {"jānis", "pēteris", "andris", "sergejs", "antons"};
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Contains("a") || names[i].Contains("ā"))
                {
                    Console.WriteLine(names[i]);
                }
            }
        }

        public static void Task5()
        {
            int[] numbers = new int[12] { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8, 43, 56 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0 && numbers[i] <= 30)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 30 && numbers[i] <= 60)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 60 && numbers[i] <= 90)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
        }

        public static void Task6()
        {
            int count = 0;
            int[,] array2D = new int[5, 5];
            for (int i =0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    array2D[i, j] = ++count;
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine();
            }
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
