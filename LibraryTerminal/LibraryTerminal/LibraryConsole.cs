using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminal
{
    public class LibraryConsole
    {
        BookInventory deweyDecimal = new BookInventory();

        public void UseLibraryConsole()
        {
            string consoleResponse = "";
            bool viewConsoleMenu = true;
            Navigation.PowerButton("on");
            deweyDecimal.DisplayBookList();
            while (viewConsoleMenu)
            {
                viewConsoleMenu = false;
                consoleResponse = ConsoleMenu(); // Gets response and validates range
                // we won't get here unless we have a valid response
                InitiatePatronRequest(consoleResponse.ToLower());
                viewConsoleMenu = Navigation.TryAgain("", "");
                if (!viewConsoleMenu)
                {
                    deweyDecimal.RecordBookInventory();
                    Navigation.ThankYouAndGoodbye();
                }
            }

            return;
        }

        public string ConsoleMenu()
        {
            string menuSelection;
            Console.WriteLine("  ------------------------------");
            {
                Console.WriteLine($"{" |  ",1}{"A",-1} {"See list of books",-25}{"|",2}");
                Console.WriteLine($"{" |  ",1}{"B",-1} {"Search books by title",-25}{"|",2}");
                Console.WriteLine($"{" |  ",1}{"C",-1} {"Search books by author",-25}{"|",2}");
                Console.WriteLine($"{" |  ",1}{"D",-1} {"Check out book",-25}{"|",2}");
                Console.WriteLine($"{" |  ",1}{"E",-1} {"Check in book",-25} {"|",1}");
                Console.WriteLine($"{" |  ",1}{"Q or X to Quit",-26} {"|",2}");
            }
            Console.WriteLine("  ------------------------------");
            Communication.TalkToUser("What would you like to do today?");
            Communication.TalkToUser("");
            menuSelection = GetMenuSelection();
            return menuSelection;
        }

        public string GetMenuSelection()
        {
            string libraryPatronResponse = "";
            bool enterResponseAgain = true;
            while (enterResponseAgain)
            {
                enterResponseAgain = false;
                libraryPatronResponse = Communication.ListenToUser();
                Communication.TalkToUser("Your selection: ", libraryPatronResponse);
                libraryPatronResponse = Validation.ValidatePatronResponse(libraryPatronResponse.ToLower());
                if (libraryPatronResponse == "?")
                {
                    enterResponseAgain = Navigation.TryAgain("invalid entry", "");
                    if (!enterResponseAgain)
                    {
                        deweyDecimal.RecordBookInventory();
                        Navigation.ThankYouAndGoodbye();
                    }
                }

                return libraryPatronResponse;
            }

            return libraryPatronResponse;
        }

        public void InitiatePatronRequest(string whatToDo)
        {
            switch (whatToDo)
            {
                case "a":
                    deweyDecimal.DisplayBookList();
                    break;
                case "b":
                    deweyDecimal.GetBookSearchValue("title");
                    break;
                case "c":
                    deweyDecimal.GetBookSearchValue("author");
                    break;
                case "d":
                    deweyDecimal.CheckOutBook();
                    break;
                case "e":
                    deweyDecimal.ReturnABook();
                    break;
                case "q":
                case "x":
                    deweyDecimal.RecordBookInventory();
                    Navigation.ThankYouAndGoodbye();
                    break;
            }
        }
    }
}