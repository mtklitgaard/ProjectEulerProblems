using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem1
    {
        public int GetSumOfMultiples(int naturalNumber)
        {
            var multiples = new List<int>();

            for (int index = 1; index < naturalNumber; index++)
            {
                if (index%3 == 0 || index%5 == 0)
                {
                    multiples.Add(index);
                }
            }

            return multiples.Sum();
        }
    }
}
