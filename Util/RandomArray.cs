using System;
using System.Collections.Generic;

namespace Util
{
    public class RandomArray
    {

        /**
         * <summary>The constructor of <see cref="NormalizedArray"/> class gets an integer itemCount as an input. Creates an array of
         * size itemCount and loops through each element of the array and initializes them with a random number by using Math.random().
         * Then, accumulates each element of the array and at the end divides each element with the resulting sum.</summary>
         *
         * <returns>itemCount</returns>
         */
        public static double[] NormalizedArray(int itemCount) {
            int i;
            var sum = 0.0;
            var array = new double[itemCount];
            var rand = new Random();
            for (i = 0; i < itemCount; i++) {
                array[i] = rand.NextDouble();
                sum += array[i];
            }
            for (i = 0; i < itemCount; i++) {
                array[i] /= sum;
            }
            return array;
        }

        public static List<int> IndexArray(int itemCount, Random random)
        {
            var indexList = new List<int>();
            for (var i = 0; i < itemCount; i++)
            {
                indexList.Add(i);
            }
            var n = indexList.Count;  
            while (n > 1) {  
                n--;  
                var k = random.Next(n + 1);  
                var value = indexList[k];  
                indexList[k] = indexList[n];  
                indexList[n] = value;  
            }

            return indexList;
        }

    }
}