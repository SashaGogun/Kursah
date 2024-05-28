using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PROBA.Class
{
    static class StaticMethod
    {
        static public bool IsStringConsistsOfNineDigits(string input)
        {
            if (input.Length != 9)
            {
                return false;
            }

            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        static public bool IsStringOfDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        static public bool ContainsNumbers(string input)
        {

            return Regex.IsMatch(input, @"\d");
        }
        static public bool IsStringConsistsOfDigits(string input, int num)
        {
            if (input.Length != num)
            {
                return false;
            }

            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        static public string AddSpaces(string input)
        {
            StringBuilder result = new StringBuilder(input);
            for (int i = 3; i < result.Length; i += 4)
            {
                result.Insert(i, ' ');
            }
            return result.ToString();
        }
    }
}
