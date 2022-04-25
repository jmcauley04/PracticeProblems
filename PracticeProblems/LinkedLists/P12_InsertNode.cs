namespace PracticeProblems.LinkedLists;

/// <summary>
/// Write a function that when given a node, an additional node, and an index, will insert the additional node into the first node at the given index. 
/// If the given node does not include the requested index, the addition can be appended to the back.
/// </summary>
public class P12_InsertNode
{
    #region Solution

    public static Node<T>? Solution<T>(Node<T>? node, Node<T>? addition, int index)
    {
        int currentIndex = index;
        var head = node;

        if (node == null)
            return addition;

        if (addition == null)
            return node;

        while (currentIndex < index)
        {
            if (node!.Next is null)
                break;

            node = node?.Next;
            currentIndex++;
        }

        var next = node?.Next;
        node!.Next = addition;

        while (addition!.Next is not null)
        {
            addition = addition?.Next;
        }

        addition.Next = next;

        return head;
    }

    #endregion
}
