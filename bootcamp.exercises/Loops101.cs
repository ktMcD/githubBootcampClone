/* Katie McDougall
* Lab101 lab
* Due 10/6/22 1830 Eastern
* Requirements:
* 1. Use a do-while loop to output "Hello, World!" in a loop.
*    Each time you output "Hello, World!" ask the user whether they would like to continue.
* 2. Prompt the user for a number. Use a for loop to output all the numbers from that number to 0.
*    After that loop finishes, use another loop to output all the numbers from 0 to that number
* 3. A door has a keypad entry. The combination to get in is 13579.
*    Write a while loop (not a do while loop) that asks the user to enter a key code.
*    The loop will repeat as long as the user enters the wrong code.
*    After the user enters the correct code, the program will print out a welcome message.
*    One way to do this: boolean variable for door locked/unlocked.
*    Then think about real life, when you approach a door with a keypad,
*    what state is it initially in before you type anything into the keypad? bools default to "false"
*    a. Continue the previous exercise, but now add a limited number of tries, say 5.
*       After 5 unsuccessful attempts, the loop ends, but instead of printing a welcome message,
*       it prints a message warning that there were too many incorrect attempts.
*       (But if the user entered the correct number, it will still print the welcome message as before.)
*    b. Start a new console project, and repeat the same exercise as the previous,
*       except this time implement it with a do while loop.
*    c. BIG GIRL PANTS challenge: Move the last while loop or the do-while loop into its own function.
*       The function should return a true if access is granted, or a false if the user didn’t
*       enter the correct code within 5 tries.
*/

using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Loops101
{
    internal class Program
    {
        bool letsDoThisAgain = true; // I'm not sure where to define this without causing an endless loop
        private const string keyCodeCombo = "13579";
        static void Main(string[] args)
        {
            Program Loops101 = new Program();
            Loops101.Orchestrator(); // my favorite pattern!
        }

        public void Orchestrator()
        {
            // 1. Hello World Do-While
            Holla();
            SegueToNextThing("CountDownAndUp");
            // 2. Display numbers from user input to 0 and then back again.
            CountDownAndUp();
            SegueToNextThing("LetMeOut");
            // 3. Unlock door with keycode "13579" (use strings for numbers when no calcs are neede)
            letsDoThisAgain = true; // need to reset this value for the next method.
            LetMeOut();
            SeeYaLaterCrocodile();
        }

        private void Holla()
        {
            string callingMethod = "Holla";
            do
            {
                Console.WriteLine("Hello World!");
                WannaGoAgain(callingMethod, ""); // sets class variable letsDoThisAgain
            }
            while (letsDoThisAgain);
        }

        private void SegueToNextThing(string nextMethod)
        {
            Console.WriteLine("\nAnd now for something completely different...\n");
            switch (nextMethod)
            {
                case "CountDownAndUp":
                    Console.WriteLine("Let's play a number game where everybody wins...");
                    letsDoThisAgain = true;
                    CountDownAndUp();
                    break;
                case "LetMeOut":
                    Console.WriteLine("Help! I'm locked in this house with all these cats...");
                    LetMeOut();
                    break;
            }
        }

        private void CountDownAndUp()
        {
            while (letsDoThisAgain)
            {
                string callingMethod = "CountDownAndUp";
                string myBuddysInput = GetMyBuddysInput(callingMethod);
                int myBuddysNumber;
                bool imANumber = int.TryParse(myBuddysInput, out myBuddysNumber);
                if (imANumber && myBuddysNumber >= 0 && myBuddysNumber <= 100)
                {
                    TeachMeToCount(myBuddysNumber);
                    WannaGoAgain("CountDownAndUp", "");
                }
                else if (!imANumber)
                {
                    WannaGoAgain("CountDownAndUp", "not a number");
                }
            }
        }

        private void TeachMeToCount(int whatsMyNumber)
        {
            Console.WriteLine($"First Let's count down from {whatsMyNumber}");
            for (int i = whatsMyNumber; i >= 0; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine($"\nNow Let's count up to {whatsMyNumber}");
            for (int i = 0; i <= whatsMyNumber; i++)
            {
                Console.Write($"{i} ");
            }
        }

        private void LetMeOut() // 13579
        {
            string callingMethod = "LetMeOut";
            int maxTries = 5;
            int currentAttemptCount = 0;
            while (letsDoThisAgain)
            {
                while (currentAttemptCount <= maxTries)
                {
                    string keyCodeEntry = GetMyBuddysInput(callingMethod);
                    currentAttemptCount++;
                    Console.WriteLine("Try# " + currentAttemptCount);
                    if (currentAttemptCount == maxTries && keyCodeEntry != keyCodeCombo)
                    {
                        WannaGoAgain(callingMethod, "too many tries");
                        break;
                    }
                    else
                    if (currentAttemptCount < maxTries && keyCodeEntry != keyCodeCombo)
                    {
                        WannaGoAgain(callingMethod, "wrong keycode");
                        break;
                    }
                    else
                        if (keyCodeEntry == keyCodeCombo)
                    {
                        HeyYoureFree();
                        WannaGoAgain(callingMethod, "");
                        Console.WriteLine("Try# " + currentAttemptCount);
                        break;
                    }
                }
                currentAttemptCount = 0;
            }
        }

        private void HeyYoureFree()
        {
            Console.WriteLine("Congratulations! You're free to leave that house full of cats.");
            Console.WriteLine("Although kitties are totally awesome and we don't know why you'd want to.\n");
        }

        // let's return a string here so we can reuse GetMyBuddysInput with only a little extra effort

        public string GetMyBuddysInput(string callingMethod)
        {
            string myBuddysInput;
            switch (callingMethod)
            {
                case "CountDownAndUp":
                    Console.WriteLine("Please enter a number between 0 and 100 inclusive");
                    Console.WriteLine("Enter anything else to go to the next thing");
                    break;
                case "LetMeOut":
                    Console.WriteLine("Please enter your five-digit keycode");
                    break;
            }
            myBuddysInput = Console.ReadLine().ToLower();
            return myBuddysInput.Trim();
        }

        private void WannaGoAgain(string callingMethod, string error)
        {
            string oneMoreTime;
            string whatToSay = "Enter yes or y to continue, or enter any other key to exit.";

            switch (callingMethod)
            {
                case "Holla":
                    Console.WriteLine("Would you like to see \"Hello World!\" again?");
                    break;

                case "CountDownAndUp":
                    if (error == "not a number")
                    {
                        Console.WriteLine("You didn't enter a number between 0 and 100 inclusive. Wanna try again?");
                    }
                    else
                    {
                        Console.WriteLine("\nWould you like to enter another number?");
                    }
                    break;

                case "LetMeOut":
                    switch (error)
                    {
                        case "wrong keycode":
                            Console.WriteLine("Woopsie! You have some fat fingers there! Wanna try again?");
                            break;
                        case "too many tries":
                            Console.WriteLine("You've reached the maximum of five tries. Sorry. You're stuck with all those cats.");
                            SeeYaLaterCrocodile();
                            break;
                        default:
                            Console.WriteLine("Would you like to do it all over again?");
                            break;
                    }
                    break;
            }
            Console.WriteLine(whatToSay);
            oneMoreTime = Console.ReadLine().Trim().ToLower();
            if (oneMoreTime == "y" || oneMoreTime == "yes")
            {
                letsDoThisAgain = true;
            }
            else
            {
                letsDoThisAgain = false;
            }
        }

        private void SeeYaLaterCrocodile()
        {
            Console.WriteLine("\nGoodBye, buddy. Thanks for stopping by!");
            Environment.Exit(0);
        }
    }
}