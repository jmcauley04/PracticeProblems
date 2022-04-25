using System.Text;

namespace PracticeProblems.Arrays;

/// <summary>
/// Write a function that takes a string and returns a compressed string by shortening every sequence of the 
/// same character to that character followed by the number of repetitions (if any).
/// </summary>
public class P02_Compress
{

    #region Solution

    public static string Solution(string input)
    {
        var result = new StringBuilder();

        var i = 0;
        while (i < input.Length)
        {
            var next = i + 1;
            while (next < input.Length && input[i] == input[next])
                next++;

            var qty = next - i;
            if (qty > 1)
                result.Append($"{input[i]}{qty}");
            else
                result.Append(input[i]);

            i = next;
        }

        return result.ToString();
    }

    #endregion

}
