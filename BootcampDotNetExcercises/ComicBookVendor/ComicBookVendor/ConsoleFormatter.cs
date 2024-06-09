using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookVendor
{
    public static class ConsoleFormatter
    {
        public static string GetInputTrimmedLower()
        {
            return Console.ReadLine().Trim().ToLower();
        }

        public static string GetInputTrimmed()
        { 
            return Console.ReadLine().Trim(); 
        }

       public static void DisplayRedText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor= ConsoleColor.Gray;
        }
    }
}
