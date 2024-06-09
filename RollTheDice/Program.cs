/* Katie McDougall
 * 10/13/22
 * Lab 3 - DICE ROLLER
 * Asks user to enter the number of sides for a pair of dice. 
 * If you have learned about exception handling, make sure the user can only enter numbers
 * The application prompts the user to roll the dice.
 * The application “rolls” two n-sided dice, displaying the results of each along with a total
 * For 6-sided dice, the application recognizes the following dice combinations and displays a message for each. It should not output this for any other size of dice.
 * Snake Eyes: Two 1s
 * Ace Deuce: A 1 and 2
 * Box Cars: Two 6s
 * Win: A total of 7 or 11
 * Craps: A total of 2, 3, or 12 (will also generate another message!)
 * The application asks the user if he/she wants to roll the dice again.
 * 
 * Build Specifications:
 * Create a static method to generate the random numbers.
 * Proper method header: 2 points
 * Program generates random numbers validly within the user-specified range: 1 point
 * Method returns meaningful value of proper type: 1 point
 * Create a static method for six-sided dice that takes two dice values as parameters, and returns a string for one of the valid combinations (e.g. Snake Eyes, etc.) or an empty string if the dice don’t match one of the combinations.
 * Create a static method to implement output for different dice combinations
 * Proper method header: 2 points
 * Method recognizes all specified cases correctly: 1 point
 * Method displays properly to Console: 1 point
 * Application takes all user input correctly: 1 point
 * Application loops properly: 1 point
 * 
 * Extra Challenges:
 * Come up with a set of winning combinations for other dice sizes besides 6.
 * 
 */

using System;

namespace RollTheDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program RollTheDice = new Program();
            RollTheDice.Orchestrator();
            RollTheDice.SoLongAndThanksForAllTheFish();
        }

        public void Orchestrator()
        {
            string rollThoseBonez;
            bool letsRollEm = false;
            bool cantStopNow = true;
            int diceRoll;
            Console.WriteLine("Howdy! Welcome to Grand Circus Casino.");
            Console.WriteLine("Would you like to play a game of dice?");
            Console.WriteLine("\"y\" or \"yes\" to roll - anything else to quit");
            rollThoseBonez = Console.ReadLine().Trim().ToLower();
            if (rollThoseBonez == "y" || rollThoseBonez == "yes")
            {
                letsRollEm = true;
            }
            if (letsRollEm)
            {
                int rollNumber = 0;
                while (cantStopNow == true)
                {
                    int numberofSides;
                    string diceSides;
                    Console.WriteLine("Your dice have how many sides?");
                    diceSides = Console.ReadLine().Trim();
                    if (!int.TryParse(diceSides, out numberofSides) || diceSides == "" || diceSides == "0" || diceSides == null)
                    {
                        cantStopNow = GottaHaveANumber();
                    }
                    rollNumber++;
                    numberofSides = Math.Abs(numberofSides); // we won't allow empty, null or 0
                    diceRoll = RollDemBonez(numberofSides, rollNumber);
                    if (numberofSides == 6)
                    {
                        OutputForSixSides(diceRoll, rollNumber);
                    }
                    else
                    {
                        DiceRollOutput(diceRoll);
                    }
                    cantStopNow = AmIASucker();
                }
                SoLongAndThanksForAllTheFish();
            }
        }

        bool AmIASucker()
        {
            bool gottaKeepEmRolling = false;
            string whatDoYouSay = "";
            Console.WriteLine("Would you like to roll again?");
            Console.WriteLine("\"y\" or \"yes\" to roll - anything else to quit");
            whatDoYouSay = Console.ReadLine().Trim().ToLower();
            if (whatDoYouSay != "y" && whatDoYouSay != "yes")
            {
                SoLongAndThanksForAllTheFish();
            }
            else
            {
                if (whatDoYouSay == "y" || whatDoYouSay == "yes")
                {
                    gottaKeepEmRolling = true;
                }
                else
                {
                    gottaKeepEmRolling = false;
                }
            }
            return gottaKeepEmRolling;
        }

        bool GottaHaveANumber()
        {
            string whatDoYouSay = "";
            bool letsTryAgain = false;
            Console.WriteLine("Hey there. You didn't enter a valid number. Entries cannot be blank or 0");
            Console.WriteLine("Wanna try again?");
            whatDoYouSay = Console.ReadLine().Trim().ToLower();
            if (whatDoYouSay != "y" && whatDoYouSay != "yes")
            {
                SoLongAndThanksForAllTheFish();
            }
            else
            {
                if (whatDoYouSay == "y" || whatDoYouSay == "yes")
                {
                    letsTryAgain = true;
                }
                else
                {
                    letsTryAgain = false;
                }
            }
            return letsTryAgain;
        }

        int RollDemBonez(int numberOfSides, int rollNumber)
        {
            int dieOne;
            int dieTwo;
            int rollTotal = 0;
            Console.WriteLine("Let 'er rip!");
            Random random = new Random();
            dieOne = random.Next(1, numberOfSides);
            dieTwo = random.Next(1, numberOfSides);
            rollTotal = dieOne + dieTwo;
            return rollTotal;
        }

        void SoLongAndThanksForAllTheFish()
        {
            Console.WriteLine("Thanks for depositing your money with Grand Circus Casino. See you tomorrow!");
            Environment.Exit(0);
        }

        void OutputForSixSides(int rollTotal, int rollNumber)
        {
            Console.WriteLine($"Roll #{rollNumber}.");
            switch (rollTotal)
            {
                case 7:
                case 11:
                    Console.WriteLine($"You rolled a {rollTotal}! Congratulations. That's a win!");
                    break;
                case 12: // only one way to get a 12 - so we don't need value of each die
                    Console.WriteLine($"You rolled Box Cars - a {rollTotal}. Craps!");
                    break;
                case 3: // only one way to get a 3 - so we don't need the value of each die
                    Console.WriteLine($"You rolled Ace Deuce - a {rollTotal}. Craps!");
                    break;
                case 2: // only one way to get a 2 - so we don't need the value of each die
                    Console.WriteLine($"You rolled Snake Eyes - a {rollTotal}. Craps!");
                    break;
                default:
                    Console.WriteLine($"You rolled a {rollTotal}.");
                    break;
            }
        }

        void DiceRollOutput(int rollTotal)
        {
            Console.WriteLine($"You rolled a {rollTotal}. Congratulations. We have no idea what that means.");
        }
    } // class
}
