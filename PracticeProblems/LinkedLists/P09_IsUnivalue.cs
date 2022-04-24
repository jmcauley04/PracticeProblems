namespace PracticeProblems.LinkedLists;

/// <summary>
/// Write a function that when given a linked list will return whether the linked list is univalue.
/// <br /> A univalue linked list contains only one value.  
/// </summary>
public class P09_IsUnivalue
{
    #region Solution

    public static bool Solution<T>(Node<T>? node)
    {
        while (node is not null && node.Next is not null)
        {
            if (!node.Value!.Equals(node.Next.Value))
                return false;

            node = node?.Next;
        }

        return true;
    }

    #endregion
}
