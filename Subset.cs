using System;

namespace Util
{
    public class Subset
    {
        protected int[] set;
        protected int[] multiset;
        private readonly int _rangeEnd;
        protected int elementCount;

        ///
        /// <summary>The constructor of {@link Subset} class which takes 3 integer inputs; rangeStart, rangeEnd, and
        /// elementCount. It initializes variables rangeEnd and elementCount with given inputs, creates 2 arrays; set
        /// and multiset with the size of given elementCount and multisetCount, which is derived from elementCount,
        /// respectively. Then, it assigns rangeStart+i to each ith element of set
        /// {@link java.lang.reflect.Array}.</summary>
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
            multiset = new int[multisetCount];
            for (i = 0; i < elementCount; i++)
                set[i] = rangeStart + i;
        }

        ///
        /// <summary>An empty constructor of {@link Subset} class.</summary>
        ///
        public Subset()
        {
        }

        ///
        /// <summary>Getter for the set {@link java.lang.reflect.Array}.</summary>
        /// 
        /// <returns>the set {@link java.lang.reflect.Array}.</returns>
        ///
        public int[] Get()
        {
            return set;
        }

        
        /// <summary>The getX method takes an integer M as an input. Creates a new array X size of elementCount+2 and
        /// assigns 0 to its first element. Starting from the second index, it assigns set
        /// {@link java.lang.reflect.Array}'s elements to newly created {@link java.lang.reflect.Array} X. Then, assigns
        /// M to the last element of X.</summary>
        /// 
        /// <param name="m">integer input.</param> 
        /// <returns>Array size of elementCount+2.</returns>
        public int[] GetX(int m)
        {
            int i;
            var x = new int[elementCount + 2];
            x[0] = 0;
            for (i = 0; i < elementCount; i++)
            {
                x[i + 1] = set[i];
            }
            x[elementCount + 1] = m;
            return x;
        }

        ///
        /// <summary>Getter for the multiset {@link java.lang.reflect.Array}.</summary>
        /// 
        /// <returns>the multiset {@link java.lang.reflect.Array}.</returns>
        ///
        public int[] Getmultiset()
        {
            return multiset;
        }

        ///
        /// <summary>The multiset method takes an integer M as an input. Assigns ith element of set
        /// {@link java.lang.reflect.Array} to even numbered indices of multiset {@link java.lang.reflect.Array} and
        /// M - ith element of set {@link java.lang.reflect.Array} to odd numbered indices of multiset
        /// {@link java.lang.reflect.Array}, and i is between 0 and elementCount. Then, assigns M to jth index of
        /// multiset {@link java.lang.reflect.Array}. At the end, fill up the rest of the multiset
        /// {@link java.lang.reflect.Array} via different indices of set {@link java.lang.reflect.Array} and sort the
        /// multiset {@link java.lang.reflect.Array}.</summary>
        /// 
        /// <param name="m">integer input.</param>
        ///
        public void Getmultiset(int m)
        {
            int i, k;
            var j = 0;
            for (i = 0; i < elementCount; i++)
            {
                multiset[j] = set[i];
                j++;
                multiset[j] = m - set[i];
                j++;
            }
            multiset[j] = m;
            j++;
            for (i = elementCount - 1; i > 0; i--)
            for (k = i - 1; k >= 0; k--)
            {
                multiset[j] = set[i] - set[k];
                j++;
            }
            Array.Sort(multiset);
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
        /// <summary>The print method prints elements of set {@link java.lang.reflect.Array}.</summary>
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