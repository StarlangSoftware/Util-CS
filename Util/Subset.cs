using System;

namespace Util
{
    public class Subset
    {
        protected int[] Set;
        private readonly int _rangeEnd;
        protected int ElementCount;

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
            this.ElementCount = elementCount;
            Set = new int[elementCount];
            for (i = 0; i < elementCount; i++)
                Set[i] = rangeStart + i;
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
            return Set;
        }
        
        ///
        /// <summary>The next method generates the next subset.</summary>
        /// 
        /// <returns>true if next subset generation is possible, false otherwise.</returns>
        ///
        public bool Next()
        {
            int i, j;
            for (i = ElementCount - 1; i > -1; i--)
            {
                Set[i]++;
                if (Set[i] <= _rangeEnd - ElementCount + i + 1)
                    break;
            }

            if (i == -1)
                return false;
            for (j = i + 1; j < ElementCount; j++)
                Set[j] = Set[j - 1] + 1;
            return true;
        }

        ///
        /// <summary>The print method prints elements of set array.</summary>
        ///
        public void Print()
        {
            int i;
            for (i = 0; i < ElementCount; i++)
            {
                Console.WriteLine(Set[i] + " ");
            }

            Console.WriteLine();
        }
    }
}