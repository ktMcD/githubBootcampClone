using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public class Validation
    {
        public bool ValidateHumanThrow(string textIn, out string roshamboThrow) // validate against the enum
        {
            switch (textIn)
            {
                case "r":
                    roshamboThrow = "rock";
                    break;
                case "p":
                    roshamboThrow = "paper";
                    break;
                case "s":
                    roshamboThrow = "scissors";
                    break;
                default:
                    roshamboThrow = "invalid";
                    break;
            }
            try
            {
                Enum.Parse<Roshambo>(roshamboThrow, true); // too easy OMG you should see the googs on this crazy!
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool ValidateOpponent(string textIn)
        {
            if (textIn == "r" || textIn == "o")
            {
                return true;
            }
            return false;
        }
    }
}
