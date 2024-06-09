using Roshambo;

namespace Roshambo
{
    public class Program
    {
        public UserDecision humanPreference = new UserDecision();
        public Communication speakWithUser = new Communication();
        public Validation checkDataEntry = new Validation();
        public Stats stats = new Stats();
        HumanPlayer human = new HumanPlayer("friend");

        private static void Main(string[] args)
        {
            Program driver = new Program();
            driver.PlayRoshambo();
        }

        private void PlayRoshambo()
        {
            bool playAgain = true;
            string opponent;
            string opponentMove;
            string humanThrow;
            string winner;
            // ask the human player for their name
            AssignHumanPlayerName();
            while (playAgain)
            {
                playAgain = false;
                // give the human player a choice of opponents
                opponent = SelectOpponent();
                // call method to activate selected opponent
                opponentMove = MoveOpponent(opponent);
                // ask human player for their throw
                // humanThrow = GetHumanPlayerThrow();
                humanThrow = human.GenerateRoshambo();
                // figure out and announce winner
                winner = FindTheWinner(humanThrow, opponent, opponentMove);
                speakWithUser.TalkToUser("The winner for this round is: ", winner);
                // increment total games and add one to the winner's score variable
                stats.UpdateStats(winner);
                // ask Human Player if they'd like to play again
                playAgain = humanPreference.WannaPlayAgain();
                if (!playAgain)
                {
                    // display the overall results of the sesh, total games played and who won what
                    // end the process
                    stats.ReportStats();
                    humanPreference.ThankYouForPlaying();
                }
            }
        }

        private void AssignHumanPlayerName()
        {
            string humanPlayerResponse;
            speakWithUser.TalkToUser("Greetings! What's your name?");
            humanPlayerResponse = speakWithUser.ListenToUser();
            speakWithUser.TalkToUser(humanPlayerResponse);
            // human.Name defaults to "friend" if user response is null or ""
            // so we'll only update if we have a non-blank/null value 
            if (humanPlayerResponse != "" && humanPlayerResponse != null)
            {
                human.Name = humanPlayerResponse;
            }
        }

        private string SelectOpponent()
        {
            string selectedOpponent = "";
            bool validOpponent = false;
            bool tryAgain = false;
            do
            {
                speakWithUser.TalkToUser("With whom would you like to play?");
                speakWithUser.TalkToUser("Type \"r\" for Randy Random or \"o\" for Rocky Rock");
                selectedOpponent = speakWithUser.ListenToUser().Trim().ToLower();
                validOpponent = checkDataEntry.ValidateOpponent(selectedOpponent);
                if (!validOpponent)
                {
                    tryAgain = humanPreference.TryAgain("invalid opponent");
                    if (!tryAgain)
                    {
                        stats.ReportStats();
                        humanPreference.ThankYouForPlaying();
                    }
                }
            } while (tryAgain);
            // we've validated the opponent or exited here
            switch (selectedOpponent)
            {
                case "r":
                    selectedOpponent = "randy";
                    break;
                case "o":
                    selectedOpponent = "rocky";
                    break;
                default:
                    selectedOpponent = "nobody"; // we should never ever ever get here (LMAO!)
                    break;
            }
            return selectedOpponent;
        }

        private string MoveOpponent(string opponent)
        {
            string opponentMove = "";
            switch (opponent)
            {
                case "rocky":
                    RockPlayer rocky = new RockPlayer();
                    opponentMove = rocky.RoshamboValue; // always gonna be rock
                    break;
                case "randy":
                    RandomPlayer randy = new RandomPlayer();
                    opponentMove = randy.RoshamboValue;
                    break;
                default: // this should never happen since we validate before getting here; but just in case...
                    opponentMove = "woopsy! something bad happened";
                    break;
            }
            return opponentMove;
        }
        private string FindTheWinner(string humanThrow, string opponent, string opponentThrow)
        {
            string theWinner = "";
            speakWithUser.TalkToUser($"Great! You chose {humanThrow}.");
            speakWithUser.TalkToUser($"{opponent} chose {opponentThrow}.");
            switch (humanThrow)
            {
                case "rock":
                    switch (opponentThrow)
                    {
                        case "rock":
                            theWinner = "draw";
                            break;
                        case "paper":
                            theWinner = human.Name;
                            break;
                        case "scissors":
                            theWinner = opponent;
                            break;
                    }
                    break;
                case "paper":
                    switch (opponentThrow)
                    {
                        case "rock":
                            theWinner = human.Name;
                            break;
                        case "paper":
                            theWinner = "draw";
                            break;
                        case "scissors":
                            theWinner = opponent;
                            break;
                    }
                    break;
                case "scissors":
                    switch (opponentThrow)
                    {
                        case "rock":
                            theWinner = opponent;
                            break;
                        case "paper":
                            theWinner = human.Name;
                            break;
                        case "scissors":
                            theWinner = "draw";
                            break;
                    }
                    break;
                default:
                    theWinner = "";
                    break;

            }
            return theWinner;
        }
    }
}