namespace Util
{
    public class Permutation
    {
        private int[] _a;
        private int _n;

        /**
         * <summary>A constructor of {@link Permutation} class which creates a new {@link java.lang.reflect.Array} and assigns integer
         * numbers starting from 0 to given input n.</summary>
         *
         * <param name="n">integer input.</param>
         */
        public Permutation(int n)
        {
            _n = n;
            _a = new int[n];
            for (int i = 0; i < n; i++)
            {
                _a[i] = i;
            }
        }

        /**
         * <summary>The get method returns the {@link java.lang.reflect.Array} a.</summary>
         *
         * <returns>Array a.</returns>
         */
        public int[] Get()
        {
            return _a;
        }

        /**
         * <summary>The next method generates next permutation for the {@link java.lang.reflect.Array} a.</summary>
         *
         * <returns>true if next permutation is possible, false otherwise.</returns>
         */
        public bool Next()
        {
            var i = _n - 2;
            while (i >= 0 && _a[i] >= _a[i + 1]) {
                i--;
            }
            if (i == -1) {
                return false;
            }
            var j = _n - 1;
            while (_a[i] >= _a[j]) {
                j--;
            }
            var tmp = _a[i];
            _a[i] = _a[j];
            _a[j] = tmp;
            var k = i + 1;
            j = _n - 1;
            while (k < j) {
                tmp = _a[k];
                _a[k] = _a[j];
                _a[j] = tmp;
                k++;
                j--;
            }
            return true;
        }
    }
}