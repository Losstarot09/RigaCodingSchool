using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Day6Extra
    {
        public static void NotCicle()
        {
            Console.Write("Lūdzu, ievadiet veselo skaiļi, kas ir lielaka par 0: ");
            int number = int.Parse(Console.ReadLine());
            Day6Extra.ChainMult(number);
        }

        public static int ChainMult(int number, int mult = 1)
        {
            mult = number * mult;
            if (number == 1)
            {
                Console.WriteLine("1 = " + mult);
                return mult;
            }
            else
            {
                Console.Write(number + " * ");
                return ChainMult(number - 1, mult);
            }
        }
    }
}
