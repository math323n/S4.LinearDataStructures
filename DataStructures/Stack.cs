using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Stack<T> : LinearDataStructure<T>
    {
        private T[] array;

        public Stack(int initialLength) : base(initialLength: initialLength)
        {
            length = initialLength;
            array = new T[length];
        }

        public void Push(Stack<T> stack, T item)
        {
            T[] newArray = new T[stack.length + 1];
            newArray[0] = item;
            for(int i = 0; i < stack.length; i++)
            {
                newArray[i + 1] = stack.array[i];
            }
            length++;
            stack.array = newArray;
        }

        public virtual void Pop(Stack<T> stack)
        {
            T[] newArray = new T[stack.length - 1];
            for(int i = 1; i < stack.length; i++)
            {
                newArray[i - 1] = stack.array[i];
            }
            length--;
            stack.array = newArray;
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
