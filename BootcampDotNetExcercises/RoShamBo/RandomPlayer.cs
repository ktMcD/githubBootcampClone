using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoShamBo
{
    public class RandomPlayer : Player
    {
        public override RoshamboOption GenerateRoshambo()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            return (RoshamboOption)randomNumber;
        }
    }
}
