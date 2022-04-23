namespace PracticeProblems.LinkedLists
{
    public class Node<T>
    {
        public T Value;
        public Node<T>? Next;

        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, Node<T> next) : this(value)
        {
            Next = next;
        }

        public Node(params T[] values)
        {
            Value = values[0];

            if (values.Length > 1)
                Next = new Node<T>(values[1..]);
        }
    }
}
