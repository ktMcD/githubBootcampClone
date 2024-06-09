using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    
    public class VendingItem
    {
        public string Name { get; set; }
        public double Cost { get; protected set; }

        //Constructor for the Base Class
        public VendingItem(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        protected VendingItem(string name)
        {  
            Name = name;
        }

    }
}
