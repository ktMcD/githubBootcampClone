using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper
{
    public abstract class Animal
    {
        public double Weight { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public BloodCategory BloodCategoryType { get; set; }

        public Species SpeciesInfo { get; set; }
        

        // ABSTRACT forces you to override it
        public abstract string Speak();


        // VIRTUAL gives permissing to override, but DOES NOT FORCE IT
        public virtual double AddWeight(double weight)
        {
            Weight += weight;
            return Weight;
        }

        // This method is the ONLY way to display animal info
        public string DisplayAnimalInfo()
        {
            return $"{Name} belongs to the {SpeciesInfo.ScientificName} family and weighs {Weight} pounds.";
        }


    }
}
