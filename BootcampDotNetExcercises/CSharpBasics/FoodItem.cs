using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class FoodItem : VendingItem
    {
        public int Calories { get; set; }

        //public FoodItem(string name,double cost, int calories): base(name,cost)
        //{
        //    Calories = calories;
        //}

        public FoodItem(string name, int calories) : base(name)
        {
            Calories = calories;
        }   

        public void IncreaseCost (double amount)
        {
            Cost += amount;
        }
    }
}
