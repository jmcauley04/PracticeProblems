namespace PracticeProblems.LinkedLists;

/// <summary>
/// Write a function that takes two linked lists and returns the head of a linked list where the values of each respective index are added together.
/// </summary>
public class P14_Add
{
    #region Solution

    public static Node<int>? Solution(Node<int>? a, Node<int>? b)
    {
        if (a == null || b == null)
            return a ?? b;

        var head = a;

        while (b != null)
        {
            a.Value += b.Value;

            if (a.Next == null)
            {
                a.Next = b.Next;
                break;
            }

            a = a.Next;
            b = b.Next;
        }

        return head;
    }

    #endregion
}
