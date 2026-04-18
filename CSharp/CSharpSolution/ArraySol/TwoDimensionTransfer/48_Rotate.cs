namespace LeetCode.Solution;

public class RotateImageSolution
{
    public static void Rotate(ref int[][] matrix)
    {
        var d = matrix.Length;
        var k = matrix.Length;
        for (int i = 0; i < d / 2 + d % 2; i++)
        {
            for (int j = 0; j < k - 1; j++)
            {
                (matrix[i][j + i], matrix[j + i][d - 1 - i]) = (matrix[j + i][d - 1 - i], matrix[i][j + i]);
                (matrix[i][j + i], matrix[d - 1 - j - i][i]) = (matrix[d - 1 - j - i][i], matrix[i][j + i]);
                (matrix[d - 1 - i][d - 1 - j - i], matrix[d - 1 - j - i][i]) = (matrix[d - 1 - j - i][i], matrix[d - 1 - i][d - 1 - j - i]);
            }
            k -= 2;
        }
    }
}