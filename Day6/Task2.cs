using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Task2
    {
        public static void PrintMyName(string name, string surName)
        {
            if (name.Length < 1)
            {
                name = "Name";
            }
            if (surName.Length < 1)
            {
                surName = "Surname";
            }
            Console.WriteLine($"{name[0].ToString().ToUpper()}. {surName[0].ToString().ToUpper()}{surName.Substring(1).ToLower()}");
        }
    }
}
