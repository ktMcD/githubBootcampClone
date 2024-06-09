using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public interface ICollectable
    {
        string Name { get; set; }
        double InitialCost { get; set; }
        double CurrentValue { get; set; }
        double CalculateProfit();

    }
}
