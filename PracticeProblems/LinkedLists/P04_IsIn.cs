namespace PracticeProblems.LinkedLists
{
    /// <summary>
    /// Write a function that takes in the head of a linked list and a target value. 
    /// The function should return a boolean indicating whether or not the linked list
    /// </summary>
    public class P04_IsIn
    {

        #region Solution

        public static bool Solution<T>(Node<T>? node, T? value)
        {
            while (node != null)
            {
                if (node.Value?.Equals(value) ?? false)
                    return true;

                node = node.Next;
            }

            return false;
        }

        #endregion

    }
}
