namespace PracticeProblems.LinkedLists;

/// <summary>
/// Write a function that when given an array of items will return the head of a linked list of each item in the array and where the order is the same as the array.
/// </summary>
public class P13_Create
{
    #region Solution

    public static Node<T> Solution<T>(T[] items)
    {
        var head = new Node<T>(items[0]);

        var current = head;

        for (int i = 1; i < items.Length; i++)
        {
            current.Next = new Node<T>(items[i]);
            current = current.Next;
        }

        return head;
    }

    #endregion
}
