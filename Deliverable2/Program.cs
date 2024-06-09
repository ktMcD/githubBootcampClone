using System;

namespace Deliverable2
{
    internal class Program
    {
        public const double costOfCoffee = 2;
        public const int partyLimit = 6;
        public const double costOfBuffet = 9.99;
        static void Main(string[] args)
        {
            var HowdyHowdyHowdy = new Program();
            HowdyHowdyHowdy.Driver();
        }

        public void Driver()
        {
            int partySize;
            // get the number of people in the party
            partySize = GetPartySize();
            
            // handle 0
            if (partySize == 0)
            {
                Console.WriteLine("I see you've changed your mind.\n" +
                                  "See you next time!");
                Environment.Exit(0);
            }

            //handle party size greater than 6
            if (partySize > partyLimit)
            {
                Console.WriteLine("Too many! You go now!");
                Environment.Exit(0);
            }

            // get everybody's drink order
            GetTotals(partySize);

        } // end Driver method

        private int GetPartySize()
        {
            int partyPeeps;
            string numInParty;
            Console.WriteLine("Welcome to our buffet! All you can eat for $9.99! \n" +
                              "We charge $2 extra for coffee.\n" +
                              "How many people are in your group? Parties of 6 or fewer, please.");
            numInParty = Console.ReadLine();
            if (int.TryParse(numInParty, out partyPeeps))
            {
                return partyPeeps;
            }

            return 0;
        } // end GetPartySize

        private void GetTotals(int numPeeps)
        {
            int numWaters = 0;
            int numCoffees = 0;
            string drinkResponse;
            for (int i = 1; i <= numPeeps; i++)
            {
                Console.WriteLine("Hiya, Person " + i + "! Whaddaya want?\n" +
                                  "Coffee or water?");
                drinkResponse = Console.ReadLine();
                switch (drinkResponse)
                {
                    case "coffee":
                        numCoffees++;
                        break;
                    case "water":
                        numWaters++;
                        break;
                    default:
                        Console.WriteLine("We don't have that! No drink for you!"); // hilarious! :)
                        break;
                }
            }
            Console.WriteLine("OK! So that's " + numCoffees + " coffees and \n" +
                              numWaters + " waters. I'll be right back.\n" +
                              "Feel free to grab your food.");
            TallyBill(numWaters,
                      numCoffees,
                      numPeeps);
        } // end GetTotals
        private void TallyBill(int water,
                               int coffee,
                               int peeps)
        {
            double totalFood = peeps * costOfBuffet;
            double totalcoffee = coffee * costOfCoffee;
            double total = totalFood + totalcoffee;
            Console.WriteLine("Here's your bill! Total price: $" + total);
        }
    }
}
