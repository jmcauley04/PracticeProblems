namespace PracticeProblems.LinkedLists;

/// <summary>
/// Write a function that takes in the head of a linked list and an index. 
/// The function should return the value of the linked list at the specified index.
/// </summary>
public class P6_GetValue
{

    #region Solution

    public static T? Solution<T>(Node<T>? node, int index)
    {
        var counter = 0;

        while (node is not null)
        {
            if (counter++ == index)
                return node.Value;

            node = node.Next;
        }

        return default;
    }

    #endregion
}
