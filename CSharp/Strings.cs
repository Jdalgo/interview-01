using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharp
{
    public static class Strings
    {
        /// <summary>
        /// Implement a string reversal method
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Reverse1(string input)
        {
            string reverseString = "";
            int length;

            length = input.Length - 1;

            while (length >= 0)
            {
                reverseString += input[length];
                length--;
            }
            return reverseString;
        }

        /// <summary>
        /// Implement a different string reversal method
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Reverse2(string input)
        {
            return new string(input.Reverse().ToArray());
        }


        /// <summary>
        /// Implement a string truncation function that safely truncates the input without throwning an exception. Return null if input is null.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string SafeTruncate(string input, int length)
        {
            string output = null;
            if (input != null)
            {
                output = input.Substring(0, input.Length < length ? input.Length : length);
            }

            return output;
        }

        /// <summary>
        /// return a list of even numbers from the input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int> EvenNumerics(List<string> input)
        {
            var result = new List<int>();

            foreach (var inputStrings in input)
            {
                var numbers = Regex.Split(inputStrings, @"\D+");
                foreach (string number in numbers)
                {
                    if (Int32.TryParse(number, out int value))
                    {
                        result.Add(value);
                    }
                    result = (from m in result
                              where m % 2 == 0
                              select m).ToList();
                }

            }
            return result;
        }
    }
}
