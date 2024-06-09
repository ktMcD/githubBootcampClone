using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper
{
    public class Turtle : Animal
    {
        public string WeaponOfChoice { get; set; }

        public Turtle()
        {
            BloodCategoryType = BloodCategory.ColdBlooded;
        }

        public override string  Speak()
        {
            return "Cowabunga";
        }
    }
}
