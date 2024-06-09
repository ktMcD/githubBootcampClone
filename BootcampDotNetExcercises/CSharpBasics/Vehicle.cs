using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class Vehicle
    {
        public double TopSpeed { get; set; }
        public double CurrentSpeed { get; set; }
        public int PassengerCount { get; set; }

        public void Drive()
        {
            if(CurrentSpeed == 0)
            {
                CurrentSpeed = 1;
            }
        }
    }
}
