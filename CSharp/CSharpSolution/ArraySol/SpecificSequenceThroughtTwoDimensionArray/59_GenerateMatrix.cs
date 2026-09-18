namespace LeetCode.Solution.ArraySol.SpecificSequenceThroughtTwoDimensionArray;

public class GenerateMatrixSolution
{
    public static int[][] GenerateMatrix(int n)
    {
        var ans = Enumerable.Range(0, n).Select(_ => new int[n]).ToArray();
        // 确定上下左右四条边的位置
        int up = 0, down = n - 1, left = 0, right = n - 1;
        int v = 1;
        while (true)
        {
            // →
            for (int i = left; i <= right; i++) ans[up][i] = v++;
            if (++up > down) break;
            // ↓
            for (int i = up; i <= down; i++) ans[i][right] = v++;
            if (--right < left) break;
            // ←
            for (int i = right; i >= left; i--) ans[down][i] = v++;
            if (--down < up) break;
            // ↑
            for (int i = down; i >= up; i--) ans[i][left] = v++;
            if (++left > right) break;
        }
        return ans;
    }
}