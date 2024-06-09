using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUnitTest
{
    public class Arithmetic
    {
        public int Sum(int valueOne, int valueTwo)
        {
            return valueOne + valueTwo;
        }

        public int Sum(int[] values)
            { return values.Sum(); }

        public int Divide(int valueOne, int valueTwo)
        {
            try
            {
                return valueOne / valueTwo;
            }
            catch (Exception)
            {

                return -1;
            }        
        }

    }
}
