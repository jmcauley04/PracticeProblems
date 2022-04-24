namespace PracticeProblems.LinkedLists
{
    /// <summary>
    /// Write a function that takes in the head of a linked list and an index. 
    /// The function should return the value of the linked list at the specified index.
    /// </summary>
    public class P05_Get
    {

        #region Solution

        public static Node<T>? Solution<T>(Node<T>? node, int index)
        {
            int currentIndex = 0;
            while (node != null)
            {
                if (currentIndex == index)
                    return node;

                currentIndex++;
                node = node.Next;
            }

            return null;
        }

        #endregion

    }
}
