namespace PracticeProblems.LinkedLists;

/// <summary>
/// Write a function that when given a linked list will return a boolean representing whether the values in the linked list are unique.
/// </summary>
public class P9_IsUnivalue
{
    #region Solution

    public static bool Solution<T>(Node<T>? node)
    {
        var hashSet = new HashSet<T>();

        while (node is not null)
        {
            if (hashSet.Contains(node.Value))
                return false;

            hashSet.Add(node.Value);
            node = node?.Next;
        }

        return true;
    }

    #endregion
}
