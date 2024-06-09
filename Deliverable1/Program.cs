/* Grand Circus C# Full Stack Bootcamp
 * unit 1, deliverable 1
 * Katie McDougall
 * 9/1/2022
 * Assumptions: 1 person = 1 sandwich
 *              1 sandwich = 2 x slice, 2 x pb, 4 x jelly
 *
*/

using System;
using System.Security.Cryptography.X509Certificates;

namespace Deliverable1
{
    internal class Program // catchy name
    {
        // I would have liked to set up enumerations for the values for each sandwich but I don't know how 
           // and the documentation was confusing!
        // I just used constants instead
        // I can, however, pick apart logic to create tiny methods. Hoping to have conversations about SOLID during classes
        // There's a better way to declare and use these constants, I'm sure.
        public const int slicesPerSammie = 2;
        public const int slicesPerLoaf = 28;
        public const int tspPerSammie = 4;
        public const int tspPerJellyJar = 48;
        public const int tbspPerSammie = 2;
        public const int tbspPerPBJar = 32;
        static void Main(string[] args) 
        {
            string letsMakeASammie;
            var MakeASandwich = new Program();

            Console.WriteLine("Ohai! Wanna make a sammie?");
            letsMakeASammie = Console.ReadLine();
            if (letsMakeASammie == "y" || letsMakeASammie == "yes")
            {
                MakeASandwich.Driver();
                MakeASandwich.CheckForRepeat();
            }
            else
            {
                Console.WriteLine("kthanksbai!");
                Environment.Exit(0);
            }
            
        } // end main method

        private void Driver()
        {
            int numberOfSlices;
            int numberOfTbsp;
            int numberOfTsp;
            int numberOfLoaves;
            int numberOfPBJars;
            int numberOfJellyJars;
            int numberOfPeeps;
            numberOfPeeps = NumPeople();
            numberOfSlices = GetTotalSlices(numberOfPeeps);
            numberOfTbsp = GetTotalTbsp(numberOfPeeps);
            numberOfTsp = GetTotalTsp(numberOfPeeps);
            numberOfLoaves = GetNumberOfLoaves(numberOfSlices);
            numberOfPBJars = GetNumberOfPBJars(numberOfTbsp);
            numberOfJellyJars = GetNumberOfJellyJars(numberOfTsp);
            DisplayResults(numberOfSlices,
                           numberOfTbsp,
                           numberOfTsp,
                           numberOfLoaves,
                           numberOfPBJars,
                           numberOfJellyJars);
            CheckForRepeat();
        } // end driver method

        // We should be checking for integer input
        // as well as non-negative and non-zero numbers here
        private int NumPeople()
        {
            string numPeopleEating;
            int howManySammies;
            Console.WriteLine("How many people are we making PB and J sandwiches for?");
            numPeopleEating = Console.ReadLine();
            // cast the answer to an integer
            howManySammies = int.Parse(numPeopleEating);
            return howManySammies;
        } // end NumPeople

        private int GetTotalSlices(int numSammiches)
        {
            Console.WriteLine("line 85");
            int totalSlices = numSammiches * slicesPerSammie;
            return totalSlices;
        } // end GetTotalSlices

        private int GetTotalTbsp(int numSammiches)
        {
            int totalTbsp = numSammiches * tbspPerSammie;
            return totalTbsp;
        } // end GetTotalTbsp

        private int GetTotalTsp(int numSammiches)
        {
            int totalTsp = numSammiches * tspPerSammie;
            return totalTsp;
        } // end GetTotalTsp

        private int GetNumberOfLoaves(int numOfSlices)
        {
            int numLoaves;
            decimal loaves = numOfSlices / slicesPerLoaf;
            numLoaves = (int)loaves;
            if (numLoaves < loaves || numLoaves == 0) // rounding is not to be trusted
            {
                Console.WriteLine(numLoaves < loaves);
                numLoaves = numLoaves + 1;
            }
            return numLoaves;
        }

        private int GetNumberOfPBJars(int numOfTbsp)
        {
            int numPbJars;
            decimal pbJars = numOfTbsp / tbspPerPBJar;
            numPbJars = (int)pbJars;
            if (numPbJars < pbJars || numPbJars == 0)
            {
                numPbJars = numPbJars + 1;
            }
            return numPbJars;
        } // end GetNumberOfPBJars

        private int GetNumberOfJellyJars(int numOfTsp)
        {
            int numJellyJars;
            decimal jellyJars = numOfTsp / tspPerJellyJar;
            numJellyJars = (int)jellyJars;
            if (numJellyJars < jellyJars || numJellyJars == 0)
            {
                numJellyJars = numJellyJars + 1;
            }
            return numJellyJars;
        } // end GetNumberOfJellyJars

        private void DisplayResults(int slices,
                                    int tbsp,
                                    int tsp,
                                    int loaves,
                                    int pbJars,
                                    int jellyJars)
        {
            Console.WriteLine("You need:\n");
            Console.WriteLine(slices + " slices of bread");
            Console.WriteLine(tbsp + " tablespoons of peanut butter");
            Console.WriteLine(tsp + " of jelly\n");
            Console.WriteLine("which is ...\n");
            Console.WriteLine(loaves + " loaves of bread");
            Console.WriteLine(pbJars + " jars of peanut butter");
            Console.WriteLine(jellyJars + " jars of jelly\n");
            return;

        }

        private void CheckForRepeat()
        {
            Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
            string letsGoAgain = Console.ReadLine();
            if (letsGoAgain != "y" && letsGoAgain != "yes")
            {
                Console.WriteLine("GoodBye!");
                Environment.Exit(0);
            }
            else Driver();
        }
    } // end class Program 
} // end namespace Deliverables1
