using System;

namespace DataStructures
{
    public class LinkedList<T> : LinearDataStructure<Node<T>>
    {
        private bool isEmpty;

        public LinkedList(int initialLength) : base(initialLength: initialLength)
        {
            length = initialLength;
        }

        public override void Insert(Node<T> node, int index)
        {
            base.Insert(node, index);
            if(index + 1 < Items.Length - 1)
            {
                node.Next = Items[index + 1];
            }
            if(index - 1 >= 0)
            {
                Items[index - 1].Next = node;
            }
        }

        public override void Remove(int index)
        {
            base.Remove(index);
            if(index > 0)
            {
                Items[index - 1].Next = Items[index];
            }
        }

        public virtual void ReplaceFirst(Node<T> newNode)
        {
            if(IsEmpty)
            {

            }
            else
            {
                Items[0] = newNode;
                if(Items.Length > 1)
                {
                    newNode.Next = Items[1];
                }
            }
        }

        public virtual void ReplaceRest(LinkedList<T> newList)
        {
            if(IsEmpty)
            {

            }
            else
            {
                int j = 0;
                for(int i = 1; i < Count; i++)
                {
                    Items[i] = newList.Items[j];
                }
                Items[0].Next = Items[1];
            }
        }

        public virtual string PrintAll()
        {
            if(IsEmpty)
            {
                return "";
            }
            else
            {
                string toReturn = "";
                foreach(Node<T> node in Items)
                {
                    toReturn += $"{node} \n";
                }
                return toReturn;
            }
        }

        public virtual bool IsEmpty
        {
            get
            {
                return Count == 0;
            }
            set
            {
                isEmpty = value;
            }
        }
    }
}