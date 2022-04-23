namespace PracticeProblems.LinkedLists;

/// <summary>
/// Write a method that when given two linked lists will return the head of a linked list such that all original data is represented
/// and the next node is greater than or equal to the previous node.
/// </summary>
public class P1_SortingLinkedList
{

    #region Solution

    public class Node
    {
        public Node(int data)
        {
            Data = data;
        }

        public Node(params int[] ints)
        {
            var current = this;
            current.Data = ints[0];

            for (int i = 1; i < ints.Length; i++)
            {
                current.Next = new Node(ints[i]);
                current = current.Next;
            }
        }

        public int Data;
        public Node? Next;
    }

    /// <summary>
    /// n is the len(a) + len(b)
    /// <br />Time: O(n)
    /// <br />Space: O(1)
    /// </summary>
    public static Node? Solution(Node? a, Node? b)
    {
        // check for nulls
        if (a == null)
            return b;

        if (b == null)
            return a;

        // initialize the head and tail
        Node head;
        Node? tail;

        if (a.Data < b.Data)
        {
            head = tail = a;
            a = a.Next;
        }
        else
        {
            head = tail = b;
            b = b.Next;
        }

        // iterate through the options
        while (a != null || b != null)
        {
            if (b == null || (a!.Data < b.Data))
            {
                tail!.Next = a;
                a = a!.Next;
            }
            else
            {
                tail!.Next = b;
                b = b!.Next;
            }

            tail = tail.Next;
        }

        return head;
    }

    #endregion
}
