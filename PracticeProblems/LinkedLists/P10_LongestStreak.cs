namespace PracticeProblems.LinkedLists;

/// <summary>
/// Write a function that when given a linked list will return the length of the longest increasing subsequence (LIS)
/// <br /> LIS does not have to be adjacent.  A linked list starting with 1 and ending with 2 will create a subsequence of length 2 regardless of what is in the middle.
/// </summary>
public class P10_LongestStreak
{
    #region Solution

    public static int Solution<T>(Node<T>? node)
        where T : IComparable<T>
    {
        bool IsGreaterThan(T a, T b) => a.CompareTo(b) > 0;

        List<List<T>> subsequences = new List<List<T>>();

        while (node != null)
        {
            var appended = false;

            foreach (var sequence in subsequences)
            {
                if (IsGreaterThan(node.Value, sequence[sequence.Count - 1]))
                {
                    sequence.Add(node.Value);
                    appended = true;
                }
            }

            if (!appended)
                subsequences.Add(new List<T> { node.Value });

            node = node.Next;
        }

        var longestLength = 0;

        foreach (var sequence in subsequences)
            longestLength = Math.Max(longestLength, sequence.Count);

        return longestLength;
    }

    #endregion
}
