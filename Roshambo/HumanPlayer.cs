using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public class HumanPlayer : Player
    {

        public Communication speakWithUser = new Communication();
        public Validation checkDataEntry = new Validation();
        public UserDecision humanPreference = new UserDecision();
        /* properties */
        public override string Name { get; set; }
        public override string RoshamboValue { get; set; }

        public HumanPlayer(string name)
        {
            Name = name;
            RoshamboValue = "";
        }

        /* methods */
        public override string GenerateRoshambo()
        {
            string playerThrow = "";
            bool validThrow = false;
            bool keepTrying = true;
            while (keepTrying)
            {
                keepTrying = false;
                speakWithUser.TalkToUser("What is your Roshambo throw?");
                speakWithUser.TalkToUser("Please select \"r\" for Rock, \"p\" for Paper or \"s\" for Scissors");
                playerThrow = speakWithUser.ListenToUser().ToLower();
                validThrow = checkDataEntry.ValidateHumanThrow(playerThrow, out playerThrow);
                if (!validThrow)
                {
                    keepTrying = humanPreference.TryAgain("invalid throw");
                    if (!keepTrying)
                    {
                        humanPreference.ThankYouForPlaying();
                    }
                }
            }
            RoshamboValue = playerThrow;
            return RoshamboValue;
        }
    }
}
