int[] someNumbers1 = new int[5];
int[] someNumbers2 = new int[5];
Console.WriteLine("Please give me five numbers");
for (int i = 0; i < someNumbers1.Length; i++)
{
    Console.WriteLine($"Number {i} is: ");
    someNumbers1[i] = int.Parse(Console.ReadLine().Trim());
    Console.WriteLine($"You entered {someNumbers1[i]}");
}

for (int i = 0; i < someNumbers1.Length; i++)
{
    someNumbers2[i] = someNumbers1[i];
    Console.WriteLine($"The second array at index {i} is {someNumbers2[i]}");
}
