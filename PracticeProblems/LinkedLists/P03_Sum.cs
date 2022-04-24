namespace PracticeProblems.LinkedLists;

/// <summary>
/// Write a function that takes in the head of a linked list containing numbers as an argument. 
/// The function should return the total sum of all values in the linked list.
/// </summary>
public class P03_Sum
{

    #region Solution

    public static int Solution(Node<int>? node)
    {
        int sum = 0;

        while (node != null)
        {
            sum += node.Value;
            node = node.Next;
        }

        return sum;
    }

    #endregion

}
