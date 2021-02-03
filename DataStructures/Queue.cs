using System;

namespace DataStructures
{
    public class Queue<T> : LinearDataStructure<T>
    {
        public Queue(int initialLength) : base(initialLength: initialLength)
        {
            length = initialLength;
        }

        public virtual void Add(T item)
        {
            Insert(item, Count);
        }

        public virtual T Pop()
        {
            T poppedItem = Items[0];
            Remove(0);
            return poppedItem;
        }

        public virtual void Inverse()
        {
            int i = 0;
            int j = Count - 1;
            while(j > i)
            {
                (Items[i], Items[j]) = (Items[j], Items[i]);
                i++;
                j--;
            }
        }
    }
}