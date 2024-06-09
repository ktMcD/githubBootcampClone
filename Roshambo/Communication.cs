using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public static class Communication
    {
        // Console.WriteLine with fields
        public static void TalkToUser(string theText, string theFieldValue)
        {
            Console.WriteLine($"{theText} {theFieldValue}");
        }

        // Console.WriteLine with no field values
        public static void TalkToUser(string theText)
        {
            Console.WriteLine($"{theText}");
        }

        // Console.ReadLine 
        public static string ListenToUser()
        {
            return Console.ReadLine().Trim();
        }

    }
}
