namespace PracticeProblems.Arrays;

/// <summary>
/// You're given a two-dimensional array (a matrix) of potentially unequal height and width containing only 0s and 1s. Each 0 represents land, and each 1 represents part of a
/// river. A river consists of any number of 1s that are either horizontally or vertically adjacent(but not diagonally adjacent). The number of adjacent 1s forming a river determine its size.
///<br /> - Note that a river can twist. In other words, it doesn't have to be a straight vertical line or a straight horizontal line; it can be L-shaped, for example.
///<br /> - Write a function that returns an array of the sizes of all rivers represented in the input matrix.The sizes don't need to be in any particular order.
/// </summary>
public class P05_LongestRiver
{

    #region Solution

    // find a water that isn't already explored
    // try to go right or down on the first check
    // if adjacent with water on one side, start a river and trace it
    public static List<int> Solution(int[,] matrix)
    {
        // iterate through the matrix
        // at each spot,
        // [check spot method]
        //  record as visited
        //  if not visited
        //  check if the spot is a river spot and 
        //  if so, set size = 1, record as visited, and 
        //  size += [check spot method] adjacent spots for another river spot
        //  return size
        // 
        var width = matrix.GetLength(0);
        var height = matrix.GetLength(1);
        var visited = new bool[width, height];// these will be false by default I think
        var result = new List<int>();

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (!visited[i, j])
                {
                    visited[i, j] = true;
                    if (matrix[i, j] == 1)
                    {
                        var size = 1;
                        foreach (var neighbor in GetUnvisitedNeighbors(i, j, matrix, visited))
                        {
                            size += CheckSpot(neighbor, matrix, visited);
                        }
                        result.Add(size);
                    }
                }
            }
        }

        return result;
    }

    static List<(int, int)> GetUnvisitedNeighbors(int i, int j, int[,] matrix, bool[,] visited)
    {
        var neighbors = new List<(int, int)>();
        var width = matrix.GetLength(0);
        var height = matrix.GetLength(1);

        if (i - 1 >= 0 && !visited[i - 1, j])
            neighbors.Add((i - 1, j));
        if (i + 1 < width && !visited[i + 1, j])
            neighbors.Add((i + 1, j));

        if (j - 1 >= 0 && !visited[i, j - 1])
            neighbors.Add((i, j - 1));
        if (j + 1 < height && !visited[i, j + 1])
            neighbors.Add((i, j + 1));

        return neighbors;
    }

    static int CheckSpot((int, int) target, int[,] matrix, bool[,] visited)
    {
        if (!visited[target.Item1, target.Item2])
        {
            visited[target.Item1, target.Item2] = true;
            if (matrix[target.Item1, target.Item2] == 1)
            {
                var size = 1;
                foreach (var neighbor in GetUnvisitedNeighbors(target.Item1, target.Item2, matrix, visited))
                {
                    size += CheckSpot(neighbor, matrix, visited);
                }
                return size;
            }
        }
        return 0;
    }

    #endregion

}
