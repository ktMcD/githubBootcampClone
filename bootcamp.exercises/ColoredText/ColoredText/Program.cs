// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

void Driver()
{
    string userName = GetUserName();
    string userColor = GetUserColor();
    SetUserColor(userColor);
    DisplayUserColor(userName, userColor);
    ResetConsoleColor();
}

string GetUserName()
{
    string userName;
    Console.WriteLine("Hi! What's your name?");
    userName = Console.ReadLine();
    if (userName == null || userName == "")
    {
        userName = "friend";
    }
    return userName;
}
string GetUserColor()
{
    Console.WriteLine("Hi! What color do you like?");
    Console.WriteLine("Yellow, Red or Blue?");
    string colorPref = Console.ReadLine().ToLower();
    if (colorPref == null || colorPref == "")
    {
        colorPref = "yellow";
    }
    return colorPref;
}

void SetUserColor(string colorPref)
{
    switch (colorPref)
    {
        case "yellow":
            Console.ForegroundColor = ConsoleColor.Yellow;
            break;
        case "red":
            Console.ForegroundColor = ConsoleColor.Red;
            break;
        case "blue":
            Console.ForegroundColor = ConsoleColor.Blue;
            break;
    }
}

void DisplayUserColor(string userName, string userColor)
{
    Console.WriteLine($"You selected the color {userColor}.");
}

void ResetConsoleColor()
{
    Console.ForegroundColor = ConsoleColor.Gray;
}