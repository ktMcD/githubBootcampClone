using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public class UserDecision
    {
        public Communication speakWithUser = new Communication();
         
        public bool TryAgain(string errorMessage)
        {
            string messageToUser = "";
            switch (errorMessage)
            {
                case "invalid opponent":
                    messageToUser = "You have entered an invalid opponent";
                    break;
                case "invalid throw":
                    messageToUser = "Your throw selection is invalid.\n" +
                                    "Please only select Rock (\"r\"), Paper (\"p\") or Scissors (\"s\")";
                    break;
            }
            speakWithUser.TalkToUser(messageToUser);
            speakWithUser.TalkToUser("If you quit now, your stats might now be accurate");
            return WannaPlayAgain();
        }

        public bool WannaPlayAgain()
        {
            string humanPlayerResponse;
            speakWithUser.TalkToUser("Would you like to give it another whirl? \"y\" or \"yes\" to continue");
            speakWithUser.TalkToUser("Anything else to quit");
            humanPlayerResponse = speakWithUser.ListenToUser().Trim().ToLower();
            if (humanPlayerResponse != "y" && humanPlayerResponse != "yes")
            {
                return false;
            }
            return true;
        }

        public void ThankYouForPlaying()
        {
            speakWithUser.TalkToUser("Great to play with you. Come back soon.");
            speakWithUser.TalkToUser("So long!");
            Console.ReadKey();
            Environment.Exit(0);

        }
    }
}
