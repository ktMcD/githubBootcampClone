namespace RoShamBo
{
    public static class Validator
    {
        public static string GetYN(string input)
        {
            switch (input.ToLower())
            {
                case "y":
                case "yes":
                case "yeah":
                    return "Y";
                case "n":
                case "no":
                case "nope":
                    return "N";
                default:
                    throw new InvalidDataException("Invalid answer was provided");
            }
        }

        public static Player GetOtherPlayer(string input)
        {
            switch (input.ToLower())
            {
                case "rock":
                    return new RockPlayer();
                case "random":
                    return new RandomPlayer();
                default:
                    throw new InvalidDataException("Invalid answer was provided");
            }
        }

        public static RoshamboOption GetRoshambo(string input)
        {
            switch (input.ToLower())
            {
                case "rock":
                case "r":
                    return RoshamboOption.Rock;
                case "paper":
                case "p":
                    return RoshamboOption.Paper;
                case "scissors":
                case "s":
                    return RoshamboOption.Scissors;
                default:
                    throw new InvalidDataException("Invalid answer was provided");
            }
        }

    }
}
