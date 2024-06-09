/*
* STUDENT DATABASE
* katie mcdougall
* 10/16/22
* 
* Create 3 arrays and fill them with student information—one with buildName,
*     one with hometown, one with favorite food
* Prompt the user to ask about a particular student by number.
*     Convert the input to an integer. Use the integer as the index for the arrays.
*     Print the student’s buildName.
* Ask the user which category to display:
*     Hometown or Favorite food. Then display the relevant information.
* Ask the user if they would like to learn about another student.
* Recognize invalid inputs
*
* Validate user number: Use an if statement to check if the number is <1 or > arrays.length,
*     If so, display a friendly message and let the user try again.
* Validate category: Ask the user what information category to display:
*     "Hometown" or "Favorite Food". Use an if statement to
*     check that they entered either category buildName correctly.
*     If they entered an incorrect category, display a friendly message and re-ask the question.
* Use the first array’s Length property in your code instead of hardcoding it.
* Make sure the arrays are the same size.
* Let the user enter a number from 1 up to and including the length of the array.
* To get the index, subtract 1 from the number they entered.
* For the valid category:
* You might create a separate program to test out some code that uses a while
* loop and asks for either “Hometown” or “Favorite Food.”
* And only finishes the loop if either of these two is entered.
* Once you have it working, copy the code over to your “real” code.
* Make it easy for the user – tell them what information is available
* Try to use good grammar. Make your messages polite.

* Extra Challenges:
* 1 Point: Provide an option where the user can see a list of all students.
* 2 Points: Allow the user to search by student name (Good challenge but difficult!)
* 1 Point: Category names: Allow uppercase and lowercase;
*     allow portion of word such as "Food" instead of "Favorite Food"
*
*/

using System;

namespace Student_Database
{
    internal class Program
    {
        // array for names
        string[] names = new string[10]; // length = 10; index 0 - 9
        // array for hometown
        string[] homeTowns = new string[10];
        // array for favorite food
        string[] faveFoods = new string[10];

        static void Main(string[] args)
        {
            Program StudentDB = new Program();
            StudentDB.Driver();
        }

        public void Driver()
        {
            PopulateNamesArray();
            PopulateHometownsArray();
            PopulateFaveFoodsArray();
            bool repeatTheQuery = true; // if a data type has a default value, why do we need to initialize?
            int studentNumber;
            string category;
            string studentName;
            while (repeatTheQuery)
            {
                // list students, foods and hometown
                ListAllStudents();
                // Ask the user to ask about a specific student by number
                studentNumber = PromptForStudentNum();
                studentName = GetStudentName(studentNumber);
                // PromptForCategory calls SortOutCategory to figure out if data entry is valid
                // We'll either get a valid category back from the method or exit
                category = PromptForCategory(studentNumber, studentName);
                DisplayResults(studentNumber, category);
                repeatTheQuery = LetsDoThatAgain("");
            }
        }

        private void PopulateNamesArray()
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = "SmartyPants" + (i + 1);
            }
        }

        private void PopulateHometownsArray()
        {
            for (int i = 0; i < homeTowns.Length; i++)
            {
                homeTowns[i] = "funky town " + (i + 1);
            }
        }

        private void PopulateFaveFoodsArray()
        {
            for (int i = 0; i < faveFoods.Length; i++)
            {
                faveFoods[i] = "bizarre food " + (i + 1);
            }
        }

        private void ListAllStudents()
        {
            Console.WriteLine("ID\tName\t\tHome Town\t\t Favorite Food");
            for (int i = 0; i < names.Length; i++)
            {
                int j = i + 1;
                Console.WriteLine($"{j}\t{names[i]}\t\t{homeTowns[i]}\t\t {faveFoods[i]} ");
            }
            return;
        }

        private int PromptForStudentNum()
        {
            string rawStudentNumber = "";
            int studentNumber = 0;
            bool isValidNumber = false;
            bool again = true;
            while (again) // look at me nesting while loops and everything
            {
                again = false;
                while (!isValidNumber)
                {
                    // takes in a number as a string
                    Console.WriteLine("Please enter the student number for that student");
                    Console.WriteLine("Please use the student\'s ID number");
                    Console.WriteLine($"We accept integers between 1 and {names.Length}");
                    rawStudentNumber = Console.ReadLine().Trim();
                    // test to see if the number is valid
                    isValidNumber = ValidateNumber(rawStudentNumber, out studentNumber);
                    // if invalid, call error program and ask if user wants to try again
                    if (!isValidNumber)
                    {
                        again = LetsDoThatAgain("not a number");
                    }
                }
            }
            return studentNumber;
        } // PromptForStudentNumber

        private bool ValidateNumber(string rawStudentNumber, out int studentNumber)
        {
            bool isValidNumber = true;
            if (!int.TryParse(rawStudentNumber, out studentNumber) ||
               (int.TryParse(rawStudentNumber, out studentNumber) && 
               studentNumber < 1 || studentNumber > names.Length))
            {
                return false;
            }
            int.TryParse(rawStudentNumber, out studentNumber);
            return isValidNumber;
        }

        private string GetStudentName(int studentNum)
        {
            // set index# to studentNum - 1
            int nameIndexNum = studentNum - 1;
            // find student name from index
            return names[nameIndexNum];
        }

        private string PromptForCategory(int studentNum, string studentName)
        {
            string lookAtCategory = "";
            bool isValidCategory = false;
            bool playItAgainSamantha = true;
            while (playItAgainSamantha)
            {
                playItAgainSamantha = false;
                while (!isValidCategory)
                {
                    Console.WriteLine($"For student {studentName}, which category interests you?");
                    Console.WriteLine("You can choose between \"Favorite Foods\", \"Home Town\" or \"both\"");
                    lookAtCategory = Console.ReadLine().Trim();
                    isValidCategory = SortOutCategories(lookAtCategory.ToLower(), out lookAtCategory);
                    if (!isValidCategory)
                    {
                        playItAgainSamantha = LetsDoThatAgain("not a valid category");
                    }
                }
            }
            return lookAtCategory;
        }

        private bool SortOutCategories(string categoryIn, out string categoryOut)
        {
            bool goAhead = false;
            categoryOut = "";
            switch (categoryIn)
            {
                case "hometown":
                case "home":
                case "home town":
                case "city":
                case "town":
                    categoryOut = "homeTowns";
                    goAhead = true;
                    break;
                case "favorite food":
                case "faves":
                case "food":
                case "favoritefood":
                case "eat":
                case "favefoods":
                case "foods":
                    categoryOut = "faveFoods";
                    goAhead = true;
                    break;
                case "both":
                    categoryOut = "both";
                    goAhead = true;
                    break;
                default:
                    break;
            }
            return goAhead;
        }

        private void DisplayResults(int studentNumber, string category)
        {
            // up until this point we've been passing user input back & forth
            // user input is not the acutal index for the student
            int studentIndex = studentNumber - 1;
            string displayCategory;
            string displayValue;
            switch(category)
            {
                case "homeTowns":
                    displayCategory = "home town";
                    displayValue = homeTowns[studentIndex];
                    break;
                case "faveFoods":
                    displayCategory = "favorite food";
                    displayValue = faveFoods[studentIndex];
                    break;
                default:
                    Console.WriteLine($"You chose to learn more about {names[studentIndex]}'s favorite food and home town.");
                    Console.WriteLine($"{names[studentIndex]}'s favorite food is {faveFoods[studentIndex]}");
                    Console.WriteLine($"{names[studentIndex]}'s home town is {homeTowns[studentIndex]}");
                    return;
            }
            Console.WriteLine($"You chose to learn more about {names[studentIndex]}'s {displayCategory}.");
            Console.WriteLine($"Their {displayCategory} is {displayValue}");
            return;
        }

        private bool LetsDoThatAgain(string errorType)
        {
            string rawInputTryAgain = "";
            switch (errorType)
            {
                case "not a number":
                    Console.WriteLine("Looks like you entered an invalid number.");
                    break;
                case "not a valid category":
                    Console.WriteLine("You entered a category that we don't recognize.");
                    break;
                default:
                    break;
            }
            Console.WriteLine("Would you like to do this again?");
            Console.WriteLine("\"Yes\" or \"y\" to continue. Anything else to exit this program.");
            rawInputTryAgain = Console.ReadLine().Trim().ToLower();
            if (rawInputTryAgain != "y" && rawInputTryAgain != "yes")
            {
                SoLongWellMissYou();
            }

            return true;


        } // LetsDoThatAgain

        private void SoLongWellMissYou()
        {
            Console.WriteLine("Hope you enjoyed your stay in our little corner of the digital wonderland.");
            Console.WriteLine("See you next time!");
            Console.ReadKey(); // wouldn't it be nice to just leave after this without any ancillary bs?
            Environment.Exit(0);
        }

    } // end class  (I know this isn't necessary but it helps me easily identify where blocks end)
} //end namespace
