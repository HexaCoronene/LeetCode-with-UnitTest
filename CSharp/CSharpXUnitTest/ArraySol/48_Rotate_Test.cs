namespace LeetCode.UnitTest.ArraySol;

public class Solution48_Rotate_Test
{
    public static IEnumerable<object[]> MatrixEnumerator
    {
        get => [
        [
            new int[][] { [1, 2, 3], [4, 5, 6], [7, 8, 9] },
            new int[][] { [7, 4, 1], [8, 5, 2], [9, 6, 3] } ],
        [
            new int[][] { [5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16] },
            new int[][] { [15, 13, 2, 5], [14, 3, 4, 1], [12, 6, 8, 9], [16, 7, 10, 11] } ],
        ];
    }

    [Theory]
    [MemberData(nameof(MatrixEnumerator))]
    public void RotateImage_Input2DimensionArrayMatrix_ModifyArray(int[][] matrix, int[][] expected)
    {
        RotateImageSolution.Rotate(ref matrix);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.True(expected[i].SequenceEqual(matrix[i]));
        }
    }
}
