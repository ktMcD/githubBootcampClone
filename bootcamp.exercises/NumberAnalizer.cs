/* Katie McDougall
 * Lab 2
 * Number Analyzer
 * 9/28/2022
 * This program prompts the user for an integer between 10 and 100 (integers need to be positive)
 * Business rules:
 * if integer is odd:
 *     and < 60 display "Odd and less than 60"
 *     or > 60  display "Odd and greater than 60"
 * if the integer is even:
 *     and >= 2 and <= 24 display "Even and less than 25"
 *     or  >= 26 and <= 60 display "Even and between 26 and 60 inclusive"
 *     or > 60 display "Even and greater than 60"
 * Answer lab summary 
 */

using System.Runtime.CompilerServices;

namespace NumberAnalyzer
{
    internal class Program 
    {
        public const string oddLt60 = "Odd and less than 60";
        public const string oddGt60 = "Odd and greater than 60";
        public const string evenLt25 = "Even and less than 25";
        public const string even26to60 = "Even and between 26 and 60 inclusive"; // 25 or 6 to 4 ;)
        public const string gt60 = "Even and greater than 60";
        private string userFirstName;
        static void Main(string[] args)
        {
            Program NumberAnalyzer = new Program();
            NumberAnalyzer.userFirstName = NumberAnalyzer.GetUserName();
            NumberAnalyzer.RunThisPuppy();
        }

        private void RunThisPuppy()
        {
            int theNumber = GetTheNumber();
            string setDisplay;
            if (theNumber == 0 || theNumber > 100)
            {
                BadDataNoRamChipsForYou();
            }
            else
            {
                setDisplay = AnalyzeNumber(theNumber);
                DisplayResults(setDisplay);
                CheckForRepeat();
            }
        }

        private string GetUserName()
        {
            Console.WriteLine("Hi there! What's your first name?");
            string userName = Console.ReadLine();
            if (userName == null || userName == "")
            {
                userName = "friend";
            }
            return userName;
        }

        private int GetTheNumber()
        {
            string theNumberInput;
            int theNumber;

            Console.WriteLine($"{userFirstName}, please enter an integer between 1 and 100");
            theNumberInput = Console.ReadLine(); // warnings cs8600 & 8602 - remember to ask about these
            if (int.TryParse(theNumberInput, out theNumber))
            {
                theNumber = Math.Abs(theNumber);
                return theNumber;
            }
            else
            {
                return 0; // this is how we'll know that we couldn't parse the input
            }
        }

        private string AnalyzeNumber(int someNumber)
        {
            bool isEven = TestForEven(someNumber);
            string analysisComplete;

            if (isEven)
            {
                if (someNumber >= 2 && someNumber <= 24)
                {
                    analysisComplete = evenLt25;
                }
                else if (someNumber >= 26 && someNumber <= 60)
                {
                    analysisComplete = even26to60;
                }
                else
                {
                    analysisComplete = gt60;
                }
            }
            else
            {
                if (someNumber < 60)
                {
                    analysisComplete = oddLt60;
                }
                else
                {
                    analysisComplete = oddGt60;
                }
            }

            return analysisComplete;
        }

        private bool TestForEven(int someNumber)
        {
            bool trueIfEven;
            if (someNumber % 2 != 0) // some classmates might need a hint about this if they're new to dev
            {
                trueIfEven = false;
            }
            else
            {
                trueIfEven = true;
            }
            
            return trueIfEven;
        }

        private void DisplayResults(string whatToSay)
        {
            Console.WriteLine($"Output: {whatToSay}");
            return;
        }

        private void CheckForRepeat()
        {
            Console.WriteLine($"Would you like to enter another number, {userFirstName}?");
            Console.WriteLine("Enter yes or y to continue, or enter any other key to exit.");
            string oneMoreRound = Console.ReadLine().ToLower();
            if (oneMoreRound != "y" && oneMoreRound != "yes")
            {
                KThanksBai();
            }
            else RunThisPuppy();
        }

        private void BadDataNoRamChipsForYou()
        {
            string startAgain;

            Console.WriteLine($"Hey {userFirstName}, you haven't entered a valid number.");
            Console.WriteLine("You haven't entered a real number.");
            startAgain = Console.ReadLine().ToLower();
            if (startAgain != "y" && startAgain != "yes")
            {
                KThanksBai();
            }
            else RunThisPuppy();
        }

        private void KThanksBai()
        {
            Console.WriteLine($"GoodBye, {userFirstName}. Thanks for stopping by!");
            Environment.Exit(0);
        }

    } // end class Program 
} // end namespace NumberAnalyzer

