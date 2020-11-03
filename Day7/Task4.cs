using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Task4
    {
        public static void GetNonEmptyArray(string[] array)
        {
            int fillCount = 0;
            foreach (string elem in array)
            {
               fillCount = String.IsNullOrWhiteSpace(elem) ? fillCount : ++fillCount; 
            }
            string[] nonEmptyArray = new string[fillCount];
            fillCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (!String.IsNullOrWhiteSpace(array[i]))
                {
                    nonEmptyArray[fillCount++] = array[i];
                }
            }
            Task3.PrintArrayValues(nonEmptyArray);
        }
    }
}
