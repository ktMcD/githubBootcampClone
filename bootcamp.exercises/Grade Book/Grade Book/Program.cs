int[] grades = new int[10];
string studentName;
int gradeTotal = 0;
double gradeAverage = 0;
Console.WriteLine("Hi! Gimme the student's name right now!");
studentName = Console.ReadLine().Trim();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hi! Gimme grade {i} dammit!");
    grades[i] = int.Parse(Console.ReadLine().Trim());
}

foreach (int grade in grades)
{
    gradeTotal = gradeTotal + grade;
}

gradeAverage = gradeTotal / grades.Length;

if (gradeAverage >= 60)
{
    Console.WriteLine($"{studentName}'s average grade is: {gradeAverage}, which is a passing grade.");
}
else
{ 
    Console.WriteLine($"{studentName}'s average grade is: {gradeAverage}, which is not a passing grade.");
}