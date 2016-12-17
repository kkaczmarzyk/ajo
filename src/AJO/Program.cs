using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AJO
{
    public class Program
    {
        private static string CursesPattern = @"kurw|gów|chuj|dup|cip|pierd|jeb|pi(n|z)d|dziwk|kutas|sra|szczyn|szcza";

        public static int CheckComment(string comment, string pattern)
        {
            int matches = 0;
            Match result = Regex.Match(comment, pattern);

            while (result.Success)
            {
                Console.WriteLine(result.Value);
                result = result.NextMatch();
                matches++;
            }
            return matches;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(CheckComment("chuj, dupa, kurwa, cipa", CursesPattern));
            Console.ReadLine();
        }
    }
}
