using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class List<T> : LinearDataStructure<T>
    {
        private T[] array;

        public List(int initialLength) : base(initialLength: initialLength)
        {
            array = new T[length];
        }
    }
}