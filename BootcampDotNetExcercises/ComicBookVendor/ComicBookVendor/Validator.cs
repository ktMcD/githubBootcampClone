using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookVendor
{
    public static class Validator
    {
        public static int IntegerValidator(string input, int minValue, int maxValue)
        {
            int returnValue = -999;
            try
            {
                returnValue = int.Parse(input);
            }
            catch (FormatException)
            {

                return returnValue;
            }

            if (returnValue < minValue && returnValue > maxValue)
            {
                return -999;
            }

            return returnValue;
        }
    }
}
