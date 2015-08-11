using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem2
    {
        public int GetFibonacciSequence(int topNumber)
        {
            var firstSequence = 1;
            var secondSequence = 2;
            int nextSequence; 

            var numbers = new List<int> { secondSequence};
            do
            {
                nextSequence = firstSequence + secondSequence;
                if (nextSequence%2 == 0)
                {
                    numbers.Add(nextSequence);
                }
                firstSequence = secondSequence;
                secondSequence = nextSequence;

            } while (nextSequence < topNumber);

            return numbers.Sum();
        }
    }
}
