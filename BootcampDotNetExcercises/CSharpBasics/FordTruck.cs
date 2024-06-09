using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public sealed class FordTruck : Truck , IFlyable
    {
        public int MaxHeight { get; set; }
        public int DaysSinceLastBreakdown { get; set; }

        public void TakeOff()
        {

        }
        public void Land()
        {

        }
    }
}
