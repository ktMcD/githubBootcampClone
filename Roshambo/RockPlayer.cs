using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public class RockPlayer : Player
    {
        public override string Name { get; set; }
        public override string RoshamboValue { get; set; }

        public RockPlayer()
        {
            Name = "Rocky";
            RoshamboValue = GenerateRoshambo();
        }

        public override string GenerateRoshambo()
        {
            return "rock";
        }
    }
}
