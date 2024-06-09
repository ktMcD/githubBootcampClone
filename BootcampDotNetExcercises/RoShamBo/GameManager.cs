using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoShamBo
{
    public class GameManager
    {
        public int Wins { get; set; }
        public int Losses { get; set; }

        public string GetStatString()
        {
            return $"You currently have {Wins} wins and {Losses} losses.";
        }
    }
}
