// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void ExitApplication()
{
    Console.WriteLine("Hit any key to exit");
    Environment.Exit(0);
}

void PauseApplication()
{
    Console.WriteLine("Hit any key to continue");
    Console.ReadKey();
}