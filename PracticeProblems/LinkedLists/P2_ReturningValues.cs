namespace PracticeProblems.LinkedLists;

/// <summary>
/// Write a function that takes in the head of a linked list as an argument. 
/// The function should return a collection containing all values of the nodes in the linked list.
/// </summary>
public class P2_ReturningValues
{

    #region Solution

    /// <summary>
    /// n is the length of the node
    /// <br />Time: O(n)
    /// <br />Space: O(1)
    /// <br />The list use is an array in the background and I think it's O(1) space but it wouldn't hurt to verify w/ a reference
    /// </summary>
    public static IEnumerable<T> Solution<T>(Node<T>? node)
    {
        var collection = new List<T>();

        while (node != null)
        {
            collection.Add(node.Value);
            node = node.Next;
        }

        return collection;
    }

    #endregion

}
