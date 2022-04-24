namespace PracticeProblems.LinkedLists;

/// <summary>
/// Write a method that when given the head of a linked list and an index will remove the node at the given index from the linked list.
/// </summary>
public class P11_RemoveNode
{
    #region Solution

    public static Node<T>? Solution<T>(Node<T> node, int index)
    {
        int currentIndex = 0;
        var head = node;
        var tail = node;

        if (index == 0)
            return head.Next;

        while (tail != null && currentIndex <= index)
        {
            if (index - 1 == currentIndex)
            {
                tail.Next = tail.Next?.Next;
                return head;
            }
            tail = tail.Next;
            currentIndex++;
        }

        return head;
    }

    #endregion
}
