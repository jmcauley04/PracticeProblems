namespace PracticeProblems.Arrays;

/// <summary>
/// Given two non-empty arrays of integers, write a function that determines
/// whether the second array is a subsequence of the first one.
/// <br />
/// <br />
/// A subsequence of an array is a set of numbers that aren't necessarily adjacent
/// in the array but that are in the same order as they appear in the array.For
/// instance, the numbers [1, 3, 4] form a subsequence of the array
/// [1, 2, 3, 4], and so do the numbers [2, 4]. Note
/// that a single number in an array and the array itself are both valid
/// subsequences of the array.
/// </summary>
public class P04_ValidateSubsequence
{
    #region Solution

    public static bool Solution(List<int> array, List<int> sequence)
    {
        var i = 0;

        for (int j = 0; j < array.Count; j++)
        {
            if (sequence[i] == array[j])
            {
                i++;
                if (i == sequence.Count)
                    return true;
            }
        }

        return false;
    }

    #endregion
}
