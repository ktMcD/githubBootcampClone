// Application starts here
ConverseWithUser();
ExitApplication();

void PauseApplication()
{
    Console.WriteLine("Hit any key to continue");
    Console.ReadKey();
}

void ExitApplication()
{
    Console.WriteLine("Thank for you playing.");
    Console.WriteLine("Hit any key to exit the application");
    Console.ReadKey();
    Environment.Exit(0);
}

void ConverseWithUser() // Orchestrator method
{
    string greetingName = GetUserName();

    if (greetingName == "Scott")
    {
        string message = "I've been warned about you";
        PrintColoredText(message, "yellow");
    }
    Console.ForegroundColor = ConsoleColor.Gray;

    int userAge = GetUserAge(greetingName);

    Console.WriteLine($"your name is really {greetingName}");

    CheckUserEmotions(greetingName);

    int numberOfKids;
    bool hasKids = DoesUserHaveKids(greetingName, out numberOfKids);

    if (hasKids)
    {
        Console.WriteLine($"{numberOfKids} is a good amount.");
    }
}

string GetUserName()
{
    while (true)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        if (name.Trim() != "")
        {
            return name;
        }
        Console.WriteLine("Let's try that again.");
    }
}

bool DoesUserHaveKids(string userName, out int kidCount)
{
    Console.WriteLine($"Hey {userName}, do you have kids (y/n)");
    string answer = Console.ReadLine();
    if (answer.ToLower().Trim() == "y")
    {
        Console.WriteLine("How many kids do you have?");
        int numberOfKids = Convert.ToInt32(Console.ReadLine());
        kidCount = numberOfKids;
        return true;
    }
    else
    {
        kidCount = 0;
        return false;
    }
}

int GetUserAge(string ageName)
{
    ageName = "Fred";
    Console.WriteLine($"Hello {ageName}, how old are you?");

    // int userAge = int.Parse(Console.ReadLine());
    int userAge;
    bool isValid = int.TryParse(Console.ReadLine(), out userAge);

    if (!isValid)
    {
        Console.WriteLine("you tried to trick me.");
        ExitApplication();
    }

    return userAge;

}

void PrintColoredText(string text, string color)
{
    string colorLower = color.ToLower();
    switch (colorLower)
    {
        case "blue":
            Console.ForegroundColor = ConsoleColor.Blue;
            break;
        case "yellow":
            Console.ForegroundColor = ConsoleColor.Yellow;
            break;
        case "red":
            Console.ForegroundColor = ConsoleColor.Red;
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Gray;
            break;
    }

    Console.WriteLine(text);
    Console.ForegroundColor = ConsoleColor.Gray;
}

void CheckUserEmotions(string userName)
{
    Console.WriteLine($"Hey {userName}, how are you feeling today?");
    string emotion = Console.ReadLine();
    string message = "";

    switch (emotion.ToLower())
    {
        case "sad":
        case "depressed":
        case "blah":
        case "poopy":
            message = $"I'm sorry you are feeling {emotion}, {userName}.";
            PrintColoredText(message, "blue");
            break;

        case "happy":
        case "great":
        case "awesome":
        case "incredible":
            message = $"I'm so happy that you are feeling {emotion}, {userName}.";
            PrintColoredText(message, "yellow");
            break;

        case "mad":
        case "pissed":
        case "angry":
        case "furious":
            message = $"Whoa {userName}, don't let things make you so {emotion}.";
            PrintColoredText(message, "red");
            break;

        default:
            message = "I have never felt that emotion.";
            PrintColoredText(message, "");
            break;
    }
}


// This is just extra code

void CountBetween(int startingNumber, int endingNumber)
{
    for (int i = startingNumber; i <= endingNumber; i++)
    {
        Console.WriteLine(i);
    }
}
string userFirstName = "John";
string userLastName = "Jones";

ChangeName(userFirstName, ref userLastName);
Console.WriteLine($"Technically your name is {userFirstName} {userLastName}");


void ChangeName(string firstName, ref string lastName)
{
    lastName = "Smith";

    Console.WriteLine($"Your name is now {firstName} {lastName}");

}