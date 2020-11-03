using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Task3
    {
        public static void PrintArrayValues(int[] array)
        {
            int i = 1;
            foreach (int elem in array)
            {
                if (i++ == array.Length)
                {
                    Console.Write(elem);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write($"{elem}, ");
                }
            }
        }

        public static void PrintArrayValues(string[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }

        public static void PrintArrayIntOrString()
        {
            int[] arrayInt = new int[] { 1, 2, 3, 4, 5, 6, 10, 8, 9, 10 };
            Task3.PrintArrayValues(arrayInt);
            string[] arrayString = new string[] { "Mani", "sauc", "Artūrs" };
            Task3.PrintArrayValues(arrayString);
        }
    }
}
