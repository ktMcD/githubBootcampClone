using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class BaseballCard : ICollectable
    {
        public string Name { get; set; }
        public double InitialCost { get; set; }
        public double CurrentValue { get; set; }

        public int BattingAverage { get; set; }

        public double CalculateProfit()
        {
            return CurrentValue - InitialCost;
        }

        public void TradeCard()
        {

        }
    }
}
