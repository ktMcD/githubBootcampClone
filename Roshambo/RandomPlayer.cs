using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public class RandomPlayer : Player
    {
        public override string Name { get; set; }
        public override string RoshamboValue { get; set; }

        public RandomPlayer()
        {
            Name = "Randy";
            RoshamboValue = GenerateRoshambo();
        }

        public override string GenerateRoshambo()
        {
            return GetRandomEnum<Roshambo>();
        }

        public string GetRandomEnum<Roshambo>()
        {
            Random randomFromEnum = new Random();
            string[] rockPaperScissors = Enum.GetNames(typeof(Roshambo));
            string randomThrow = rockPaperScissors[randomFromEnum.Next(0, rockPaperScissors.Length)];
            return randomThrow;
        }

    }
}
