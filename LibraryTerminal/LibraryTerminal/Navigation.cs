using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminal
{
    public static class Navigation
    {
        public static bool TryAgain(string theError, string additionalInfo)
        {
            bool tryAgain;
            string libraryPatronResponse;
            switch (theError)
            {
                case "invalid entry":
                    Communication.TalkToUser("Menu selections should only be entered as  alpha-numeric characters");
                    break;
                case "book is checked out":
                    Communication.TalkToUser($"The Title you entered, \"{additionalInfo}\", is already checked out! Please try another book!{Environment.NewLine}");
                    break;
                case "book not found":
                    Communication.TalkToUser($"The Title you entered, \"{additionalInfo}\", was not found! Please try again!{Environment.NewLine}");
                    break;
                case "not checked out":
                    Communication.TalkToUser($"The Title you entered, \"{additionalInfo}\", is not checked out! Please try another book!{Environment.NewLine}");
                    break;
                default:
                    break;
            }

            Communication.TalkToUser("Would you like to select another menu item?");
            Communication.TalkToUser("Enter \"y\" or \"yes\" to try again; anything else to quit");
            libraryPatronResponse = Communication.ListenToUser();
            if (libraryPatronResponse.ToLower() != "y" && libraryPatronResponse.ToLower() != "yes")
            {
                return false;
            }

            return true;
        }

        public static void PowerButton(string onOrOff)
        {
            if (onOrOff == "on")
            {
                Communication.TalkToUser($"Library Console says, \"Initializing...\"{Environment.NewLine}");
                return;
            }
            Communication.TalkToUser("Library Console says, \"Shutting down...\"");
        }

        public static void ThankYouAndGoodbye()
        {
            Communication.TalkToUser("Thank you for visiting Library Console today.");
            Communication.TalkToUser("Please come back another time.");
            Console.WriteLine();
            PowerButton("off");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}