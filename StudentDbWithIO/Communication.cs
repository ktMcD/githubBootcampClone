using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDbWithIO
{
    public class Communication
    {
        // Console.WriteLine with fields
        public void TalkToUser(string theText, string theFieldValue)
        {
            Console.WriteLine($"{theText} {theFieldValue}");
        }

        // Console.WriteLine with no field values
        public void TalkToUser(string theText)
        {
            Console.WriteLine($"{theText}");
        }

        // Console.ReadLine 
        public string ListenToUser()
        {
            return Console.ReadLine().Trim();
        }

    }
}
