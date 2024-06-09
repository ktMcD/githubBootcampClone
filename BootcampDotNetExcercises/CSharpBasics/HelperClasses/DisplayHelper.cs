using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.HelperClasses
{
    public static class DisplayHelper
    {

        // Overloading Methods
        public static void DisplayConsoleMessage(string message)
        {
            Console.WriteLine(message);
        }

       public static void DisplayConsoleMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void DisplayConsoleMessage(string message, string name)
        {
            Console.WriteLine($"{name} - {message}");
        }

        public static void DisplayConsoleMessage(Message message)
        {
            Console.WriteLine($"TITLE {message.Title} : {message.MessageString}");
        }

        public static void DisplayConsoleMessage(string message, string name, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{name} - {message}");
            Console.ForegroundColor = ConsoleColor.Gray;            
        }
    }
}
