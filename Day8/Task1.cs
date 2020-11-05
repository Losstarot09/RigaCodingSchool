using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day8
{
    class Task1
    {
        public static int[] GetOnlySmallValues(int[] array)
        {
            return array.Where(num => num < 5).ToArray();
        }
    }
}
