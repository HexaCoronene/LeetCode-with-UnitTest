namespace LeetCode.Solution.ArraySol.SpecificSequenceThroughtTwoDimensionArray;

public class SpiralOrderSolution
{
    public static IList<int> SpiralOrder(int[][] matrix)
    {
        if (matrix.Length == 0 || matrix[0].Length == 0) return new List<int>();
        List<int> ans = new();
        int m = matrix.Length, n = matrix[0].Length;
        // 确定上下左右四条边的位置
        int up = 0, down = m - 1, left = 0, right = n - 1;
        while (true)
        {
            // →
            for (int i = left; i <= right; i++) ans.Add(matrix[up][i]);
            if (++up > down) break;
            // ↓
            for (int i = up; i <= down; i++) ans.Add(matrix[i][right]);
            if (--right < left) break;
            // ←
            for (int i = right; i >= left; i--) ans.Add(matrix[down][i]);
            if (--down < up) break;
            // ↑
            for (int i = down; i >= up; i--) ans.Add(matrix[i][left]);
            if (++left > right) break;
        }
        return ans;
    }
}