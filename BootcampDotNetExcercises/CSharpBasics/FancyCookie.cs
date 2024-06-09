using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class FancyCookie : ICollectable , IEdible
    {
        public int Calories { get; set; }
        public int DaysBeforeExpiration { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Name { get; set; }
        public double InitialCost { get; set; }
        public double CurrentValue { get; set; }

        public bool IsExpired()
        {
            DateTime expirationDate = PurchaseDate.AddDays(DaysBeforeExpiration);
            if (DateTime.Now > expirationDate)
            {
                return true;
            }
            return false;
        }

        public double CalculateProfit()
        {
            return (CurrentValue - InitialCost);
        }
    }
}
