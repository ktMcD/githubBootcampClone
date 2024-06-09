using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public class Stats
    {
        public Communication speakWithUser = new Communication();
        public int HumanScore { get; set; }
        public int Draws { get; set; }
        public int RockyScore { get; set; }
        public int RandyScore { get; set; }
        public int TotalGames { get; set; }

        public void UpdateStats(string winner)
        {
            TotalGames+= 1;
            switch (winner)
            {
                case "rocky":
                    RockyScore += 1;
                    break;
                case "randy":
                    RandyScore += 1;
                    break;
                case "draw":
                    Draws += 1;
                    break;
                default:
                    HumanScore += 1;
                    break;
            }

        }

        public void ReportStats()
        {
            speakWithUser.TalkToUser("Here are your stats for this session:");
            speakWithUser.TalkToUser("Games you won: ",  HumanScore.ToString());
            speakWithUser.TalkToUser("Games Rocky won: ", RockyScore.ToString());
            speakWithUser.TalkToUser("Games Randy won: ", RandyScore.ToString());
            speakWithUser.TalkToUser("Total Draw: ", Draws.ToString());
            speakWithUser.TalkToUser("Total games played: ", TotalGames.ToString());
        }
    }
}
