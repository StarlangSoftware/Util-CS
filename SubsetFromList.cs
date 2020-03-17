namespace Util
{
    public class SubsetFromList : Subset
    {
        private readonly int[] _elementList;
        private readonly int[] _indexList;
        
        /**
         * <summary>A constructor of {@link SubsetFromList} class takes an integer list and an integer elementCount as inputs. It initializes
         * elementList and elementCount variables with given inputs, then creates 3 arrays; set,indexList, and multiset with the
         * size of given elementCount and multisetCount, which is derived from elementCount, respectively. Then, it assigns
         * i to each ith element of indexList {@link java.lang.reflect.Array} and use this index to point at elementList and
         * assigns to set {@link java.lang.reflect.Array}.</summary>
         *
         * <param name="list">        {@link java.lang.reflect.Array} type input.</param>
         * <param name="elementCount">integer input element count.</param>
         */
        public SubsetFromList(int[] list, int elementCount) {
            int i;
            _elementList = list;
            this.elementCount = elementCount;
            var multisetCount = (elementCount + 2) * (elementCount + 1) / 2;
            set = new int[elementCount];
            _indexList = new int[elementCount];
            multiset = new int[multisetCount];
            for (i = 0; i < elementCount; i++) {
                _indexList[i] = i;
                set[i] = _elementList[_indexList[i]];
            }
        }

        /**
         * <summary>The next method generates the next subset from list.</summary>
         *
         * <returns>true if next subset generation from list is possible, false otherwise.</returns>
         */
        public bool Next() {
            int i, j;
            for (i = elementCount - 1; i > -1; i--) {
                _indexList[i]++;
                if (_indexList[i] < _elementList.Length - elementCount + i + 1)
                    break;
            }
            if (i == -1)
                return false;
            set[i] = _elementList[_indexList[i]];
            for (j = i + 1; j < elementCount; j++) {
                _indexList[j] = _indexList[j - 1] + 1;
                set[j] = _elementList[_indexList[j]];
            }
            return true;
        }
        
    }
}