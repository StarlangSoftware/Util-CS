namespace Util
{
    public class Tuple
    {
        private readonly int _first;
        private readonly int _last;

        /**
         * <summary>The constructor of {@link Tuple} class which takes two integer inputs and initializes first and last variables
         * with given inputs.</summary>
         *
         * <param name="first">integer input.</param>
         * <param name="last"> integer input.</param>
         */
        public Tuple(int first, int last)
        {
            this._first = first;
            this._last = last;
        }

        /**
         * <summary>Getter for the first item at {@link Tuple}.</summary>
         *
         * <returns>the first item.</returns>
         */
        public int GetFirst()
        {
            return _first;
        }

        /**
         * <summary>Getter for the last item at {@link Tuple}.</summary>
         *
         * <returns>the last item.</returns>
         */
        public int GetLast()
        {
            return _last;
        }
    }
}