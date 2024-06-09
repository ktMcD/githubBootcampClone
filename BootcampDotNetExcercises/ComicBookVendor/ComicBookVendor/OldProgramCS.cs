using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookVendor
{
    internal class OldProgramCS
    {
        void mainMethod()
        {
            ComicBook comicBook = new ComicBook("11234");
            comicBook.UpdateCurrentValue(500);

            ComicBookSeries series = new ComicBookSeries();
            series.AddAComicBook(comicBook);

            series.CalculateValueOfSeries();
            Console.WriteLine("STUFF");

            Random rand = new Random();

            Console.WriteLine("What is your name");
            string userName = ConsoleFormatter.GetInputTrimmed();

            ConsoleFormatter.DisplayRedText($"Hello {userName}.");

            Console.WriteLine("Do you want to continue (n/y)");

            string userInput = ConsoleFormatter.GetInputTrimmedLower();

            int intValue = Validator.IntegerValidator("test", 0, 10);

            // intValue of -999 is bad 



            if (userInput == "n")
            {
                Environment.Exit(0);
            }
        }
    }
}
