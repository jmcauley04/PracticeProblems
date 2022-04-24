namespace PracticeProblems.LinkedLists;

/// <summary>
/// Write a function that takes in the head of a linked list as an argument. 
/// The function should reverse the order of the nodes in the linked list in-place and return the new head of the reversed linked list.
/// </summary>
public class P07_Reverse
{
    #region Solution

    public static Node<T>? Solution<T>(Node<T>? node)
    {
        if (node == null)
            return null;

        var nodes = new List<Node<T>>();

        while (node != null)
        {
            nodes.Add(node);
            node = node.Next;
        }

        for (int i = nodes.Count - 1; i >= 0; i--)
            nodes[i].Next = i == 0 ? null : nodes[i - 1];

        return nodes[nodes.Count - 1];
    }

    #endregion
}
