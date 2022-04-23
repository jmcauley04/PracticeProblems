namespace PracticeProblems.Arrays;

/// <summary>
/// Write a function, maxValue, that takes in array of numbers as an argument. 
/// The function should return the largest number in the array.
/// </summary>
public class P1_MaxValueArray
{

    #region Solution

    /// <summary>
    /// n is the length of the array
    /// <br />Time: O(n)
    /// <br />Space: O(1)
    /// </summary>
    public static int? Solution(int[] numbers)
    {
        if (numbers.Length == 0)
            return null;

        int maxValue = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
            maxValue = numbers[i] > maxValue ? numbers[i] : maxValue;

        return maxValue;
    }

    #endregion

}
