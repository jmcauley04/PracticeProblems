namespace PracticeProblems.Arrays;

/// <summary>
/// Write a function that when given a list of daily stock prices and maximum transaction number (a transaction is one buy and then sell interaction) returns the maximum possible profit.
/// </summary>
public class P07_MaxProfitKTransactions
{

    #region Solution

    public static int Solution(int[] prices, int transactions)
    {
        // track the max profit (goal)
        var maxProfit = 0;

        // iterate through the prices
        var index = 0;
        while (index < prices.Length)
        {
            // recursively calculate the max profit that can
            // be obtained from this iteration
            var profit = MaxIncomeAfter(index, prices, transactions);

            // if the profit found is greater than the current max, set it to the current max
            if (profit > maxProfit)
                maxProfit = profit;

            index++;
        }

        return maxProfit;
    }

    static int MaxIncomeAfter(int index, int[] prices, int remainingDepth)
    {

        // if we have reached our transaction max, 
        // we must return no possible profit
        if (remainingDepth == 0)
            return 0;

        // track the max (local) profit from the current index
        var maxProfit = 0;
        // initialize the length of the transaction being considered
        var length = 1;


        while (index < prices.Length)
        {
            while (index + length < prices.Length)
            {
                // calculate the profit if we sell the stock after {length} iterations
                var profit = prices[index + length] - prices[index];

                // it should never make sense to do a transaction that's at a loss
                // instead we would do nothing at all
                if (profit <= 0)
                {
                    length++;
                    continue;
                }

                // recursively calculate the max profit that can
                // be obtained from after this iteration and decrease the depth remaining
                profit += MaxIncomeAfter(index + length + 1, prices, remainingDepth - 1);

                // if the profit found is greater than the current max, set it to the current (local) max				
                if (profit > maxProfit)
                    maxProfit = profit;

                length++;
            }

            // re-initialize the length of the transaction being considered
            length = 1;
            index++;
        }

        return maxProfit;
    }

    #endregion

}
