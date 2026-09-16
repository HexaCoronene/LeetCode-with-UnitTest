namespace LeetCode.Solution.ArraySol.TwoDimensionArray;

public class ImageSmootherSolution
{
    public static int[][] ImageSmoother(int[][] img)
    {
        int m = img.Length, n = img[0].Length;
        int[,] sum = new int[m + 10, n + 10];
        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                sum[i, j] = sum[i - 1, j] + sum[i, j - 1] - sum[i - 1, j - 1] + img[i - 1][j - 1];
            }
        }
        int[][] ans = new int[m][];
        for (int i = 0; i < m; i++)
        {
            ans[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                int a = Math.Max(0, i - 1), b = Math.Max(0, j - 1);
                int c = Math.Min(m - 1, i + 1), d = Math.Min(n - 1, j + 1);
                int cnt = (c - a + 1) * (d - b + 1);
                int tot = sum[c + 1, d + 1] - sum[a, d + 1] - sum[c + 1, b] + sum[a, b];
                ans[i][j] = tot / cnt;
            }
        }
        return ans;
    }
}
