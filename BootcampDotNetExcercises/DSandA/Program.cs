// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int counter = 0;

bool PalidromeCheck(string text)
{
    // Turn the string into an array
    char[] array = text.ToCharArray();
    // If we are done to a single character return true
    if (array.Length == 0 || array.Length == 1)
    {
        return true;
    }
    // Remove the first character
    char first = array[0];
    // Remove the last character
    char last = array[array.Length - 1];
    // If the characters match continue the recursion
    if (first == last)
    {
        string newString = new string(array);
        // convert the array minus the two characters back into a string
        return PalidromeCheck(newString.Substring(1, newString.Length - 2));
    }
    // If the characters don't match, return false and end the recursion
    return false;
}
Console.WriteLine(PalidromeCheck("raCecar"));


Console.ReadKey();

void SelectionSort(int[] inputArray)
{

    int itemCount = inputArray.Length; // How many times do we loop

    for (int currentIndex = 0; currentIndex < itemCount; currentIndex++)
    {
        int smallestElementIndex = currentIndex;

        // Loop through all of the elements to the right of the current index
        // Anything to left should already be in the right order
        for ( int innerLoopIndex = currentIndex + 1; innerLoopIndex < itemCount; innerLoopIndex++)
        {
            // Check to see if smallestElementIndex still holds the smallest number
            if (inputArray[innerLoopIndex] < inputArray[smallestElementIndex])
            {
                // If not, update the smallestElementIndex
                smallestElementIndex = innerLoopIndex;
            }
        }
        // At the end of the inner loop, smallestElementIndex will hold the location of the smallest value
        // If the currentIndex does not match the smallestIndex we need to swap the two elements
        if (smallestElementIndex != currentIndex)
        {
            SwapItems(inputArray, currentIndex, smallestElementIndex);
        }
    }
}

int[] inputArray = new[] { 3, 43, 6, 1, 14, 5, 2, 456, 12, 3 };
SelectionSort(inputArray);

foreach (int number in inputArray)
{
    Console.WriteLine(number);
}

Console.ReadKey();


void SwapItems(int[] items, int leftIndex, int rightIndex)
{
    int temp = items[leftIndex];
    items[leftIndex] = items[rightIndex];
    items[rightIndex] = temp;
}

int[] list = new int[] { 5, 7, 8, 10, 11, 12, 14, 17, 19, 20, 25, 29 };
SwapItems(list, 5, 10);
foreach (int number in list)
{
    Console.WriteLine(number);
}


Console.ReadKey();

int BinarySearch(int[] list, int itemToFind, out int counterValue)
{
    int lowIndex = 0;
    int highIndex = list.Length - 1;
    while (lowIndex <= highIndex)
    {
        counter++;
        // Get the index of the element halfway between the low and the high
        int middleIndex = (int)Math.Floor((double)(lowIndex + highIndex) / 2); //Math.floor will round down
        // Get the value that is in the element with the middle index
        int itemWithMiddleIndex = list[middleIndex];
        if (itemWithMiddleIndex == itemToFind)
        {
            // We found the element location
            counterValue = counter;
            return middleIndex;
        }
        if (itemWithMiddleIndex > itemToFind)
        {
            // Disregard all elements greater than the middle element
            highIndex = middleIndex - 1;
        }
        if (itemWithMiddleIndex < itemToFind)
        {
            // Disregard all elements less than the middle element
            lowIndex = middleIndex + 1;
        }
    }
    // We looped through the entire array and did not find the element
    counterValue = counter;
    return -1;
};

int LinearSearch(int[] list, int itemToFind, out int counterValue)
{
    int counter = 0;
    for (int x = 0; x < list.Length; x++)
    {
        counter += 1;
        if (list[x] == itemToFind)
        {
            counterValue = counter;
            return x;
        }
    }
    counterValue = counter;
    return -1;
};


int[] numberList = new int[] { 5, 7, 8, 10, 11, 12, 14, 17, 19, 20, 25, 29 };
Console.WriteLine($"Index of the value we are looking for: { BinarySearch(numberList, 25, out counter)}");
Console.WriteLine($"Number of steps to find it: { counter}");

Console.ReadKey();


void guessTheNumber(int max)
{
    Random random = new Random();
    int numberToGuess = random.Next(1, max + 1);

    for (int x = 1; x <= max; x++)
    {
        if (x == numberToGuess)
        {
            Console.WriteLine("Correct");
            break;
        }
        else
        {
            Console.WriteLine("Wrong");
        }
    }
}

guessTheNumber(100);
guessTheNumber(1000);
guessTheNumber(10000);


Console.ReadKey();
