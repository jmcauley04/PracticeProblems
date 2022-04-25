using System.Text;

namespace PracticeProblems.Arrays;

/// <summary>
/// Write a function that takes a compressed string decompresses it (ie. "ab3c" => "abbbc").
/// </summary>
public class P03_Decompress
{

    #region Solution

    public static string Solution(string input)
    {
        var result = new StringBuilder();

        int i = 0;
        while (i < input.Length)
        {
            var next = i + 1;
            var qty = 1;
            var qtyString = string.Empty;

            while (next < input.Length && int.TryParse(input[next].ToString(), out int _))
            {
                qtyString += input[next];
                next++;
            }

            if (qtyString.Length > 0)
                qty = int.Parse(qtyString);

            for (int k = 0; k < qty; k++)
                result.Append(input[i]);

            i += qtyString.Length + 1;
        }

        return result.ToString();
    }

    #endregion

}
