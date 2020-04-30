using System;

namespace Util
{
    public class Subset
    {
        protected int[] set;
        private readonly int _rangeEnd;
        protected int elementCount;

        ///
        /// <summary>The constructor of <see cref="Subset"/> class which takes 3 integer inputs; rangeStart, rangeEnd, and
        /// elementCount. It initializes variables rangeEnd and elementCount with given inputs, creates 2 arrays; set
        /// and multiset with the size of given elementCount and multisetCount, which is derived from elementCount,
        /// respectively. Then, it assigns rangeStart+i to each ith element of set
        /// array.</summary>
        /// 
        /// <param name="rangeStart">  integer input defining start range.</param>
        /// <param name="rangeEnd">    integer input defining ending range.</param>
        /// <param name="elementCount">integer input element count.</param>
        ///
        public Subset(int rangeStart, int rangeEnd, int elementCount)
        {
            int i;
            _rangeEnd = rangeEnd;
            this.elementCount = elementCount;
            var multisetCount = (elementCount + 2) * (elementCount + 1) / 2;
            set = new int[elementCount];
            for (i = 0; i < elementCount; i++)
                set[i] = rangeStart + i;
        }

        ///
        /// <summary>An empty constructor of <see cref="Subset"/> class.</summary>
        ///
        public Subset()
        {
        }

        ///
        /// <summary>Getter for the set array.</summary>
        /// 
        /// <returns>the set array.</returns>
        ///
        public int[] Get()
        {
            return set;
        }
        
        ///
        /// <summary>The next method generates the next subset.</summary>
        /// 
        /// <returns>true if next subset generation is possible, false otherwise.</returns>
        ///
        public bool Next()
        {
            int i, j;
            for (i = elementCount - 1; i > -1; i--)
            {
                set[i]++;
                if (set[i] <= _rangeEnd - elementCount + i + 1)
                    break;
            }

            if (i == -1)
                return false;
            for (j = i + 1; j < elementCount; j++)
                set[j] = set[j - 1] + 1;
            return true;
        }

        ///
        /// <summary>The print method prints elements of set array.</summary>
        ///
        public void Print()
        {
            int i;
            for (i = 0; i < elementCount; i++)
            {
                Console.WriteLine(set[i] + " ");
            }

            Console.WriteLine();
        }
    }
}