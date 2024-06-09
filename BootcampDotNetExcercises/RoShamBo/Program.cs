using RoShamBo;

Console.WriteLine("Welcome to RO SHAM BO!");
Console.Write("What is your name? ");
string userName = Console.ReadLine();
HumanPlayer player = new HumanPlayer(userName);
GameManager game = new GameManager();

while (true)
{
    Console.Clear();
    Player opponent = GetOpponent(userName);
 
    while (true)
    {
        Console.Clear();
        player.Decision = GetUserThrow(player);
        opponent.Decision = opponent.GenerateRoshambo();
        Console.WriteLine($"You have thrown {player.Decision}, your opponent has thrown {opponent.Decision}");

        if (player.Decision == opponent.Decision)
        {
            Console.WriteLine("You have tied. You will have to throw again");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            continue;
        };
        break;
    }

    if (DidPlayerWin(player.Decision,opponent.Decision))
    {
        Console.WriteLine("You have won this round.");
        game.Wins++;
    }
    else
    {
        Console.WriteLine("You have lost this round.");
        game.Losses++;
    }
    Console.WriteLine(game.GetStatString());

    if (GetPlayAgain(userName) == false)
    {
        break;
    } 
}

Console.WriteLine($"It was great playing with you, {userName}.");
Console.WriteLine("Press any key to exit the application.");
Console.ReadKey();

bool DidPlayerWin(RoshamboOption playerThrow, RoshamboOption opponentThrow)
{
    switch (playerThrow)
    {
        case RoshamboOption.Rock:
            if (opponentThrow == RoshamboOption.Scissors)
            {
                return true;
            }
            else
            {
                return false;
            }
        case RoshamboOption.Paper:
            if (opponentThrow == RoshamboOption.Rock)
            {
                return true;
            }
            else
            {
                return false;
            }
        case RoshamboOption.Scissors:
            if (opponentThrow == RoshamboOption.Paper)
            {
                return true;
            }
            else
            {
                return false;
            }
        default:
            return false;
    }
}

Player GetOpponent(string userName)
{
    while (true)
    {
        try
        {
            Console.WriteLine($"{userName}, what type of opponent would you like to play against?");
            Console.WriteLine("Someone who always throws \"rock\" or a random generator (Type ROCK or RANDOM)");
            return Validator.GetOtherPlayer(Console.ReadLine());
        }
        catch (InvalidDataException)
        {
            Console.WriteLine("You have entered invalid. Let's try again.");
        }
    }
}

RoshamboOption GetUserThrow(HumanPlayer user)
{
    while (true)
    {
        try
        {
            Console.WriteLine($"{user.Name}, what value would you like to throw?");
            Console.WriteLine("ROCK (r), PAPER (p), SCISSORS (s)");
            return user.GenerateRoshambo(Console.ReadLine());
        }
        catch (InvalidDataException)
        {
            Console.WriteLine("You have entered invalid. Let's try again.");
        }
    }
}

bool GetPlayAgain(string userName)
{
    while (true)
    {
        try
        {
            Console.WriteLine($"That was fun, {userName}, would you like to play again (yes/no)?");
            string answer =  Validator.GetYN(Console.ReadLine());
            return answer == "Y";
        }
        catch (InvalidDataException)
        {
            Console.WriteLine("You have entered invalid. Let's try again.");
        }
    }
}