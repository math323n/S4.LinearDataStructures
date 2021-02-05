namespace DataStructures
{
    public class Node<T>
    {
        protected T _data;
        protected Node<T> next;

        public Node(T data)
        {
            _data = data;
            next = null;
        }

        public virtual Node<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }

        public override string ToString()
        {
            return _data.ToString();
        }
    }
}