using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper
{
    public class Rat: Animal
    {
        public int TailLength { get; set; }


        public void TrainNinjaTurtles()
        {
            // Training Logic
        }

        public void TrainNinjaTurtles(string turtleName)
        {
            // Train Turtle
        }

        public void TrainNinjaTurtles(Turtle turtle)
        {

        }
        public override string Speak()
        {
            return "munch munch munch";
        }
    }
}
