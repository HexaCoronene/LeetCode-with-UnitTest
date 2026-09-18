namespace LeetCode.Solution.ArraySol.SpecificSequenceThroughtTwoDimensionArray;

public class FindDiagonalOrderSolution
{
    public static int[] FindDiagonalOrder(int[][] mat)
    {
        (int X, int Y) start = (0, 0);
        int m = mat.Length, n = mat[0].Length;
        List<int> ans = new();
        int i = 0;
        while (true)
        {
            var begin = start;
            List<int> temp = new();
            while (begin.X <= m - 1 && begin.Y >= 0)
                temp.Add(mat[begin.X++][begin.Y--]);
            if (i++ % 2 != 0)
                ans.AddRange(temp);
            else
            {
                temp.Reverse();
                ans.AddRange(temp);
            }

            if (start.Y < n - 1)
                start.Y++;
            else if (start.X < m - 1)
                start.X++;
            else
                break;
        }

        return ans.ToArray();
    }
}