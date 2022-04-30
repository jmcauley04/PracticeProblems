namespace PracticeProblems.Arrays;


/// <summary>
/// Write a function that returns the size of the smallest island given a matrix of 0s and 1s where 0 is land and 1 is water.
/// </summary>
public class P06_SmallestIsland
{

    #region Solution

    public static int? Solution(int[,] matrix)
    {
        int? smallestSize = null;
        List<(int, int)> visited = new List<(int, int)>();
        // iterate through the matrix
        // if the spot is land, find the size of the land and mark all of the land as visited
        // if the size of the land is smaller, replace the smallest size

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (!visited.Contains((i, j)) && IsLand((i, j), matrix))
                {
                    visited.Add((i, j));

                    var size = UnvisitedConnectedSize(matrix, (i, j), visited);

                    if (size < smallestSize || smallestSize is null)
                        smallestSize = size;
                }
            }
        }

        return smallestSize;
    }

    static int UnvisitedConnectedSize(int[,] matrix, (int, int) loc, List<(int, int)> visited)
    {
        var size = 1;

        void TryWalk(int x, int y)
        {
            var target = (loc.Item1 + x, loc.Item2 + y);
            if (!visited.Contains(target) && IsLand(target, matrix))
            {
                visited.Add(target);
                size += UnvisitedConnectedSize(matrix, target, visited);
            }
        }

        TryWalk(-1, 0);
        TryWalk(1, 0);
        TryWalk(0, 1);
        TryWalk(0, -1);

        return size;
    }
    static bool IsLand((int, int) loc, int[,] matrix)
    {

        if (loc.Item1 >= matrix.GetLength(0) || loc.Item1 < 0)
            return false;

        if (loc.Item2 >= matrix.GetLength(1) || loc.Item2 < 0)
            return false;

        return matrix[loc.Item1, loc.Item2] == 0;
    }

    #endregion

}
