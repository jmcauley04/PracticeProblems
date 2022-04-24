namespace PracticeProblems.LinkedLists
{
    public class Node<T>
    {
        public T Value;
        public Node<T>? Next;
        public int Length;

        public Node(T value)
        {
            Value = value;
            Length = 1;
        }

        public Node(T value, Node<T> next) : this(value)
        {
            Next = next;
            Length += next.Length;
        }

        public Node(params T[] values)
        {
            Value = values[0];
            Length = values.Length;

            if (values.Length > 1)
                Next = new Node<T>(values[1..]);
        }
    }
}
