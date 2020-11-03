using System;
using System.Text;

namespace Day4Tasks
{
    class Program
    {

        public static void Task1()
        {
            string[] names = new string[8]{"Artūrs", "Alfreds", "Boriss", "Aleksandrs", "Germans",
                          "Ivans", "Romans", "Danils"};
            int count = 0;
            do
            {
                Console.WriteLine(names[count]);
                count++;
            } while (count < names.Length);
        }

        public static void Task2()
        {
            int[] numbers = new int[6] { 1, 3, 4, 8, 0, 23 };
            Console.Write("Visi masiva elementi: ");
            Console.Write(string.Join(", ", numbers));

            Console.Write("\n Visi masīva elementi, kuri ir lielaki par 5: ");
            foreach (int elem in numbers)
            {
                if (elem > 5)
                {
                    Console.Write(elem + ", ");
                }
            }
            Console.WriteLine();
        }

        public static void Task3()
        {
            string[] names = new string[12]{"Artūrs", "Jānis", "Alfreds", "Boriss", "Jazeps", "Aleksandrs", "Germans",
                          "Ivans", "Jevgenija", "Romans", "Danils", "Julia"};
            Console.WriteLine("Visi vārdi:");
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine("Visi vārdi, kas sakas ar J:");
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i][0] == 'J')
                {
                    Console.Write(names[i] + ", ");
                }
            }
            Console.WriteLine();
        }

        public static void Task4()
        {
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = i + 1;
            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        public static void TaskExtraDay4()
        {
            Console.Write("Lūdzu, ievadiet kaut kadu tekstu: ");
            string userText = Console.ReadLine();
            Console.WriteLine();
            string mirrorText = "";
            for (int i = userText.Length; i > 0; i--)
            {
                mirrorText += userText[i -1];
            }
            Console.WriteLine($"\"{userText}\" <=> \"{mirrorText}\"");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool check = false;
            while (!check)

            {
                Console.Write("Lūdzu. ievadiet veselo skaitļi no 1 līdz 4, vai extra, lai izpildīt attiecīgo uzdevumu \n" +
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
                   
                    case "extra":
                        {
                            TaskExtraDay4();
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
