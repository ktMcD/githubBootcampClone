using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class Tank : Vehicle
    {
        public string GunType { get; set; }

        public string FireGun()
        {
            return "BANG!!!";
        }

    }
}
