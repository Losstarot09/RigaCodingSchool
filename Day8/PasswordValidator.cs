using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Day8
{
    class PasswordValidator
    {
        public static bool PasswordValidate(string password)
        {
            if (password.Length >= 8)
            {
                bool isDigits = password.Any(elem => char.IsDigit(elem))
                bool isLetter = password.Any(elem => char.IsLetter(elem));
                return isDigits && isLetter;
            }
            return false;
        }
    }
}
