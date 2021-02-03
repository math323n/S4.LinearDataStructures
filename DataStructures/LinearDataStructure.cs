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
            T[] newArray = new T[array.Length + 1];
            for(int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            newArray[index] = item;
            for(int i = index + 1; i < newArray.Length; i++)
            {
                newArray[i] = array[i - 1];
            }
            array = newArray;
            length++;
        }

        public virtual void Remove(int index)
        {
            T[] newArray = new T[array.Length - 1];
            int j = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(i != index)
                {
                    newArray[j] = array[i];
                    j++;
                }
                else if(i == index && index == 0)
                {
                    newArray[j] = array[i + 1];
                    j++;
                    i++;
                }
            }
            length--;
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

        public virtual T[] Items
        {
            get
            {
                return array;
            }
            set
            {
                array = value;
            }
        }

    }
}