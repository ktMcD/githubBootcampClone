using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoShamBo
{
    public abstract class Player
    {
        public string Name { get; set; }
        public RoshamboOption Decision { get; set; }
        public virtual RoshamboOption GenerateRoshambo()
        {
            return RoshamboOption.Rock;
        }
    }
}
