using System.Collections.Generic;

namespace Util
{
    public class Interval
    {
        private List<Tuple> _list;

        ///
        ///<summary>A constructor of {@link Interval} class which creates a new {@link ArrayList} list.</summary>
        ///
        public Interval()
        {
            _list = new List<Tuple>();
        }

        ///
        ///<summary>The add method adds a new {@link Tuple} with given inputs to the list.</summary>
        ///
        ///<param name="start">first element of {@link Tuple}.</param>
        ///<param name="end">  second element of {@link Tuple}.</param>
        ///
        public void Add(int start, int end)
        {
            _list.Add(new Tuple(start, end));
        }

        ///
        ///<summary>The getFirst method returns the first element at the list {@link ArrayList}'s given index.</summary>
        ///
        ///<param name="index">to use at getting tuple from {@link ArrayList}.</param>
        ///<returns>the first element at the list {@link ArrayList}'s given index.</returns>
        ///
        public int GetFirst(int index)
        {
            return _list[index].GetFirst();
        }

        ///
        ///<summary>The getLast method returns the last element at the list {@link ArrayList}'s given index.</summary>
        ///
        ///<param name="index">to use at getting tuple from {@link ArrayList}.</param>
        ///<returns>the last element at the list {@link ArrayList}'s given index.</returns>
        ///
        public int GetLast(int index)
        {
            return _list[index].GetLast();
        }

        ///
        ///<summary>The size method returns the size of the list {@link ArrayList}.</summary>
        ///
        ///<returns>size of the list {@link ArrayList}.</returns>
        ///
        public int Size()
        {
            return _list.Count;
        }
    }
}