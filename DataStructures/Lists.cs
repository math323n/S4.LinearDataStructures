using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class List<T> : LinearDataStructure<T>
    {
       

        public List(int initialLength) : base(initialLength: initialLength)
        {
            array = new T[length];
        }
    }
}