using System.Collections.Generic;

namespace Util
{
    public class Interval
    {
        private readonly List<Tuple> _list;

        ///
        ///<summary>A constructor of <see cref="Interval"/> class which creates a new <see cref="List"/> list.</summary>
        ///
        public Interval()
        {
            _list = new List<Tuple>();
        }

        ///
        ///<summary>The add method adds a new <see cref="Tuple"/> with given inputs to the list.</summary>
        ///
        ///<param name="start">first element of <see cref="Tuple"/>.</param>
        ///<param name="end">  second element of <see cref="Tuple"/>.</param>
        ///
        public void Add(int start, int end)
        {
            _list.Add(new Tuple(start, end));
        }

        ///
        ///<summary>The getFirst method returns the first element at the list <see cref="List"/>'s given index.</summary>
        ///
        ///<param name="index">to use at getting tuple from <see cref="List"/>.</param>
        ///<returns>the first element at the list <see cref="List"/>'s given index.</returns>
        ///
        public int GetFirst(int index)
        {
            return _list[index].GetFirst();
        }

        ///
        ///<summary>The getLast method returns the last element at the list <see cref="List"/>'s given index.</summary>
        ///
        ///<param name="index">to use at getting tuple from <see cref="List"/>.</param>
        ///<returns>the last element at the list <see cref="List"/>'s given index.</returns>
        ///
        public int GetLast(int index)
        {
            return _list[index].GetLast();
        }

        ///
        ///<summary>The size method returns the size of the list <see cref="List"/>.</summary>
        ///
        ///<returns>size of the list <see cref="List"/>.</returns>
        ///
        public int Size()
        {
            return _list.Count;
        }
    }
}