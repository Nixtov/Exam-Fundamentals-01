using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class RageQuit
    {
        public static void Main(string[] args)
        {
        string pattern = @"([^0-9]+)(\d+)";
        string input = @"aSd2&5s@1";

        foreach (Match m in Regex.Matches(input, pattern))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }
    }

