using System;

namespace Util
{
    public class RandomNormalizedArray
    {
        private readonly double[] _array;

        /**
         * <summary>The constructor of <see cref="RandomNormalizedArray"/> class gets an integer itemCount as an input. Creates an array of
         * size itemCount and loops through each element of the array and initializes them with a random number by using Math.random().
         * Then, accumulates each element of the array and at the end divides each element with the resulting sum.</summary>
         *
         * <returns>itemCount</returns>
         */
        public RandomNormalizedArray(int itemCount) {
            int i;
            var sum = 0.0;
            _array = new double[itemCount];
            var rand = new Random();
            for (i = 0; i < itemCount; i++) {
                _array[i] = rand.NextDouble();
                sum += _array[i];
            }
            for (i = 0; i < itemCount; i++) {
                _array[i] /= sum;
            }
        }

        /**
         * Getter for the double array.
         *
         * <returns>the double array.</returns>
         */
        public double[] Get() {
            return _array;
        }
        
    }
}