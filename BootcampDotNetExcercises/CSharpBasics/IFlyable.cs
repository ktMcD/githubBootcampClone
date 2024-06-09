using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal interface IFlyable
    {
        int MaxHeight { get; set; }

        void TakeOff();
        void Land();
    }
}
