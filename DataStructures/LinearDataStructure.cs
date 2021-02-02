using System;

namespace DataStructures
{
    public abstract class LinearDataStructure<T>
    {
        private T[] array;
        protected int length;
        protected int count;

        protected LinearDataStructure(int initialLength)
        {
            length = initialLength;
            array = new T[length];
        }

        public virtual void Insert(T item, int index)
        {
            array[index] = item;
        }

        public virtual void Remove(int index)
        {
            array[index] = default;
            T[] newArray = new T[array.Length - 1];
            for(int i = 0; i < array.Length - 1; i++)
            {
                if(i != index)
                {
                    int j = 0;
                    newArray[i] = array[j];
                    j++;
                }
            }
            array = newArray;
        }

        public virtual void ResizeTo(int newLength)
        {
            length = newLength;
            T[] newArray = new T[length];
            for(int i = 0; i < newArray.Length - 1; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        public virtual int Count
        {
            get
            {
                return length;
            }
            set
            {
                count = value;
            }
        }
    }
}