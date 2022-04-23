namespace PracticeProblems.LinkedLists;

/// <summary>
/// Write a method that when given two linked lists will return the head of a linked list such that all original data is represented
/// and the next node is greater than or equal to the previous node.
/// </summary>
public class P1_SortingLinkedList
{

    #region Solution

    /// <summary>
    /// n is the len(a) + len(b)
    /// <br />Time: O(n)
    /// <br />Space: O(1)
    /// </summary>
    public static Node<int>? Solution(Node<int>? a, Node<int>? b)
    {
        // check for nulls
        if (a == null)
            return b;

        if (b == null)
            return a;

        // initialize the head and tail
        Node<int> head;
        Node<int>? tail;

        if (a.Value < b.Value)
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
            if (b == null || (a!.Value < b.Value))
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
