using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper
{
    public class Zebra : Animal
    {
        public Zebra()
        {
            SpeciesInfo.ScientificName = "Gumchewopinatorio";
        }
        public override string Speak()
        {
            return "Do you want fruit stripe gum?";
        }
    }
}
