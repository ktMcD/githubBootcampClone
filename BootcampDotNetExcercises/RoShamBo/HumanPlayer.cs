using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoShamBo
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name)
        {
            Name = name;
        }

        public RoshamboOption GenerateRoshambo(string option)
        {
           return Validator.GetRoshambo(option);
        }
    }
}
