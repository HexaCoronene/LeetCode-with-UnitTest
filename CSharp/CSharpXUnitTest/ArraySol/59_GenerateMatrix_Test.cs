namespace LeetCode.UnitTest.ArraySol;

public class Solution59_GenerateMatrix_Test
{
    public static IEnumerable<TheoryDataRow<int, int[][]>> SpiralMatrix2 =
    [
        new(
            3,
            [
                [1, 2, 3],
                [8, 9, 4],
                [7, 6, 5],
            ]
        ),
        new(
            1,
            [
                [1],
            ]
        ),
    ];

    [Theory]
    [MemberData(nameof(SpiralMatrix2))]
    public void GenerateMatrix_Input_Return(int n, int[][] expected)
    {
        var ans = GenerateMatrixSolution.GenerateMatrix(n);
        Assert.Equal(expected.Length, ans.Length);
        foreach ((var ex, var an) in expected.Zip(ans))
        {
            // 可以直接equal un-managed type array
            Assert.Equal(ex, an);
        }
    }
}
