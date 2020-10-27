using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello? Is any one here?");
            sbyte i = 0;
            while (i == 0)
            {
                string here = Console.ReadLine();
                if (here.ToLower() == "i am here")
                {
                    Console.WriteLine("No," + here + "!!!");
                    Console.WriteLine("Goodbye!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please, if there is someone, write: \"I am here\"");
                }
            }
        }
    }
}
