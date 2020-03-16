namespace Util
{
    public class Tuple
    {
        private readonly int _first;
        private readonly int _last;

        /**
         * The constructor of {@link Tuple} class which takes two integer inputs and initializes first and last variables
         * with given inputs.
         *
         * @param first integer input.
         * @param last  integer input.
         */
        public Tuple(int first, int last)
        {
            this._first = first;
            this._last = last;
        }

        /**
         * Getter for the first item at {@link Tuple}.
         *
         * @return the first item.
         */
        public int GetFirst()
        {
            return _first;
        }

        /**
         * Getter for the last item at {@link Tuple}.
         *
         * @return the last item.
         */
        public int GetLast()
        {
            return _last;
        }
    }
}