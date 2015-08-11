using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem3
    {
        public long CalculatePrimeNumbers(long topNumber)
        {
            long largestFactor = 0;
            long counter = 2;
            long newNumber = topNumber;

            while (counter * counter <= newNumber)
            {
                if (newNumber % counter == 0)
                {
                    newNumber = newNumber / counter;
                    largestFactor = newNumber;
                }
                else
                {
                    counter++;
                }
            }

            if (newNumber > largestFactor)
            {
                largestFactor = newNumber;
            }

            return largestFactor;
        }
    }
}
