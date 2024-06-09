using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public abstract class Player
    {
        /* properties */
        public abstract string Name { get; set; }
        public abstract string RoshamboValue{ get; set; }

        /* methods */
        public abstract string GenerateRoshambo();
    }
}
