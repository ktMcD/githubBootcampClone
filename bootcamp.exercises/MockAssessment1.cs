/* katie mcdougall
 * Mock Assessment 1
 * Due 10/10/22
 * Methods and conditionals
 * 
 * 1.	Create a method named IsTheSame() that returns a bool and takes in two numbers (int) as parameters.
 *       a.	If num1 is equal to num2, return true.
 *       b.	If num1 is not equal to num2, return false.
 *       2.	Create a method named Subtract() that takes in 2 parameters, all doubles: num1, num2.
 *          This method should return the difference of num2 from num1.
 *       3.	Create a method named FindBuildingType() takes in a number (int) as a parameter.
 *          (The following ranges are inclusive.)
 *       a.	If the number is between 4 and 10, return "This is an office building!"
 *       b.	If the number is over 50, return "This is a SUPER skyscraper!" 
 *       c.	If a number is between 11 and 49, return "This is a skyscraper!"
 *       d.	If the number is less than 3, return "This is a house!"
 *       
 *  10/6/22
 */

using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

string userEntry;
int firstNumber;
int secondNumber;
int howManyStories;
double firstForSubtraction;
double secondForSubtraction;
double difference;
bool equalOrNot;
string buildingType;

Console.WriteLine("Let's play the Same Game");
Console.WriteLine("Here's how it works:");
Console.WriteLine("You enter two integers (numbers without a decimal)");
Console.WriteLine("We'll tell you if those numbers are the same");
Console.WriteLine("Here we go! What's your first number?");
userEntry = Console.ReadLine();
if (!int.TryParse(userEntry, out firstNumber))
{
    Goodbye();
}    
Console.WriteLine("Cool. Now what's your second number?");
userEntry = Console.ReadLine();
if (!int.TryParse(userEntry, out secondNumber))
{
    Goodbye();
}

equalOrNot = IsTheSame(firstNumber, secondNumber);
if (equalOrNot)
{
    Console.WriteLine("We worked really really hard and determined that those numbers are the same");
}
else
{
    Console.WriteLine("Nope nope nope. Those numbers aren't the same");
}

Console.WriteLine("Now let's play a subtracting game.");
Console.WriteLine("You pick two numbers and we'll subtract the second number from the first number");
Console.WriteLine("These numbers can be decimals.");
Console.WriteLine("Here we go! What's your first number?");
userEntry = Console.ReadLine();
if (!double.TryParse(userEntry, out firstForSubtraction))
{
    Goodbye();
}
Console.WriteLine("Cool. Now what's your second number?");
userEntry = Console.ReadLine();
if (!double.TryParse(userEntry, out secondForSubtraction))
{
    Goodbye();
}
difference = Subtract(firstForSubtraction, secondForSubtraction);
Console.WriteLine($"The difference between {firstForSubtraction} and {secondForSubtraction} is {difference}.");

Console.WriteLine("Oh hey how many stories does your favorite building have?");
userEntry = Console.ReadLine();
if (!int.TryParse(userEntry, out howManyStories))
{
    Goodbye();
}
buildingType = FindBuildingType(howManyStories);
Console.WriteLine(buildingType);

Console.WriteLine("All done! Thanks for playing.");
Environment.Exit(0);


bool IsTheSame(int num1, int num2)
{
        if (num1 == num2)
        { 
            return true;
        }
    return false;
}

double Subtract(double num1, double num2)
{
    double difference = num1 - num2;
    return difference;
}

string FindBuildingType(int howManyStories)
{
    string buildingType;
    string officeBuilding = "This is an office building!";
    string superSky = "This is a SUPER skyscraper!";
    string skyscraper = "This is a skyscraper!";
    string house = "This is a house!";
    if (howManyStories <= 3)
    {
        buildingType = house;
    }
    else if (howManyStories >= 4 && howManyStories <= 10)
    {
        buildingType = officeBuilding;
    }
    else if (howManyStories >= 10 && howManyStories <= 49)
    {
        buildingType = skyscraper;
    }
    else
        buildingType = superSky;
    return buildingType;

}

void Goodbye()
{
    Console.WriteLine("Sorry! We can't continue if you don't enter a number. :( ");
    Console.WriteLine("\nThis program is now ending. GoodBye.");
    Environment.Exit(0);
}
