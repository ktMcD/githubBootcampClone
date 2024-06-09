using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public interface IEdible
    {
        int Calories { get; set; }
        int DaysBeforeExpiration { get; set; }
        DateTime PurchaseDate { get; set; }
        bool IsExpired();

    }
}
