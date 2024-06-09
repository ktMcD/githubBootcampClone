using StudentDatabase;

bool doContinue = true;
string[] students = PopulateNames();
string[] hometowns = PopulateHometowns();
string[] favoriteFoods = PopulateFavoriteFoods();
string[] studentMenuOptions = PopulateStudentMenuOptions();

while (doContinue == true)
{
    // Get Student Selection
    Console.Clear();
    Console.WriteLine("How would you like to find a student?");
    DisplayStringArrayWithNumber(studentMenuOptions);
    Console.WriteLine();
    int studentOption = GetValidIndexSelectionFromUser("menu option", studentMenuOptions);
    int currentStudentIndex = -1;
    string studentName = "";
    Console.Clear();
    switch ((StudentMenuOption) studentOption)
    {
        case StudentMenuOption.FullList:
            Console.WriteLine("Which person would you like to know more about? ");
            DisplayStringArrayWithNumber(students);
            Console.WriteLine();
            currentStudentIndex = GetValidIndexSelectionFromUser("student", students);
            studentName = students[currentStudentIndex];
            break;
        case StudentMenuOption.Search:
            Console.WriteLine("Enter the search string you would like to use (case will not be considered)");
            string searchString = Console.ReadLine().ToLower().Trim();
            string[] filteredList = students.Where(x => x.ToLower().Contains(searchString)).ToArray();
            Console.WriteLine("Which student would you like to know more about? ");
            DisplayStringArrayWithNumber(filteredList);
            Console.WriteLine();
            int filteredStudentIndex = GetValidIndexSelectionFromUser("student", filteredList);
            studentName = filteredList[filteredStudentIndex];
            currentStudentIndex = Array.IndexOf(students, studentName);
            break;
        default:
            break;
    }
        
    // Get Category Choice
    InformationMenuOption infoChoice = GetValidInfoChoiceFromUser(studentName);

    // Deterimine what array to user
    switch (infoChoice)
    {
        case InformationMenuOption.FavoriteFood:
            Console.WriteLine($"The favorite food of {studentName} is {favoriteFoods[currentStudentIndex]}");
            break;
        case InformationMenuOption.Hometown:
            Console.WriteLine($"The hometown of {studentName} is {hometowns[currentStudentIndex]}");
            break;
    }

    try
    {

    }
    catch (ArithmeticException)
    {

        throw;
    }

    // Does the user want to continue?
    doContinue = DetermineWhetherToContinue();
}
EndApplication();


#region Methods

// When you learn classes, all of these methods would exist in separate classes
InformationMenuOption GetValidInfoChoiceFromUser(string name)
{
    Console.Clear();
    string[] validFoodValues = new string[] {"favoritefood","favorite food","food","favorite"};
    string[] validHomeValues = new string[] { "hometown","home town","home", "town" };
    string returnValue = "";
    while (true)
    { 
        Console.WriteLine($"What information would you like to see about {name}?");
        Console.WriteLine("Hometown or Favorite Food");
        returnValue = Console.ReadLine().Trim().ToLower();
        if (validFoodValues.Contains(returnValue)) return InformationMenuOption.FavoriteFood;
        if (validHomeValues.Contains(returnValue)) return InformationMenuOption.Hometown;
        Console.WriteLine();
        Console.WriteLine("It seems you entered invalid data. Let's try again.");
        Console.WriteLine();
    }
}

void DisplayStringArrayWithNumber(string[] values)
{
    for (int i = 0; i < values.Length; i++)
    {
        Console.WriteLine($"{i+1}: {values[i]}");
    }
}

string[] PopulateNames()
{
    return new string[]
    {
        "Joseph",
        "Mary",
        "John",
        "Daniel",
        "Noah",
        "Samson"
    };
}

string[] PopulateHometowns()
{
    return new string[]
    {
        "Baniff",
        "Newark",
        "Jackson",
        "Jeffers",
        "Minneapolis",
        "Seattle"
    };
}

string[] PopulateFavoriteFoods()
{
    return new string[]
    {
        "Potatoes",
        "Fruit",
        "Fish",
        "Wild Game",
        "Chicken",
        "Bread"
    };
}

string[] PopulateStudentMenuOptions()
{
    return new string[]
    {
        "See a full list",
        "Search for a student"
    };
}

void EndApplication()
{
    Console.Clear();
    Console.WriteLine("Press any key to exit the application.");
    Console.ReadKey();
    Environment.Exit(0);
}

bool DetermineWhetherToContinue()
{
    Console.WriteLine("Enter MORE if you'd like to see another student.");
    Console.WriteLine("Any other input will end the application");
    string input = Console.ReadLine().Trim().ToLower();
    return input == "more";
}

int GetValidIndexSelectionFromUser(string topic, string[] collection)
{
    bool isValidInput = false;
    string userInput = "";
    while (isValidInput == false)
    {
        Console.WriteLine($"Enter the number associated with the {topic}: ");
        userInput = Console.ReadLine();
        isValidInput = PerformNumberValidationWithResponse(1, students.Length, userInput);
    }

    return int.Parse(userInput)-1;
}

bool PerformNumberValidationWithResponse(int minValue, int maxValue, string input)
{
    if (ValidateNumber(minValue, maxValue, input) == -1)
    {
        Console.WriteLine("The number you have entered is invalid.");
        Console.WriteLine("It is either out of range or not a valid integer.");
        Console.WriteLine("Let's try again");
        return false;
    }
    return true;
}

int ValidateNumber(int minValue, int maxValue, string input)
{
    int returnValue;
    try
    {
        returnValue = int.Parse(input);
    }
    catch (FormatException)
    {
        return -1;
    }

    if (returnValue < minValue || returnValue > maxValue)
    {
        return -1;
    }

    return returnValue;
}

#endregion
