namespace LeetCode.Solution.ArraySol.TwoDimensionArray;

public class CountBattleshipsSolution
{
    public static int CountBattleships(char[][] board)
    {
        int m = board.Length, n = board[0].Length;
        int ans = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i > 0 && board[i - 1][j] == 'X') continue;
                if (j > 0 && board[i][j - 1] == 'X') continue;
                if (board[i][j] == 'X') ans++;
            }
        }
        return ans;
    }
}