using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            string regexOne = @"\+([359]+)([-| ])2(\2)(\d{3})(\2)(\d{4})\b";

            string digits = Console.ReadLine();

            MatchCollection phones = Regex.Matches(digits, regexOne);

            List<string> output = new List<string>();

            foreach (Match item in phones)
            {
                output.Add(item.Value);
            }

            Console.Write(string.Join(", ", output));
        }
    }
}