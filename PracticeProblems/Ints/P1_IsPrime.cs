namespace PracticeProblems.Ints;

/// <summary>
/// Write a function, isPrime, that takes in a number as an argument. 
/// The function should return a boolean indicating whether or not the given number is prime.
/// </summary>
public class P1_IsPrime
{

    #region Solution

    /// <summary>
    /// n is the value of the integer
    /// <br />Time: O(n^(1/2))
    /// <br />Space: O(1)
    /// </summary>
    public static bool IsPrime(int n)
    {
        if (n <= 0)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;

        return true;
    }

    #endregion
}
