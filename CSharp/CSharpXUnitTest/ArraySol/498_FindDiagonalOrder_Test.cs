namespace LeetCode.UnitTest.ArraySol;

public class Solution498_FindDiagonalOrder_Test
{
    public static IEnumerable<TheoryDataRow<int[][], int[]>> MatThrough =
    [
        new(
            [
                [1, 2, 3],
                [4, 5, 6],
                [7, 8, 9],
            ],
            [1, 2, 4, 7, 5, 3, 6, 8, 9]
        ),
        new(
            [
                [1, 2],
                [3, 4],
            ],
            [1, 2, 3, 4]
        ),
    ];

    [Theory]
    [MemberData(nameof(MatThrough))]
    public void FindDiagonalOrder_Input_Return(int[][] mat, int[] expected)
    {
        Assert.Equal(expected, FindDiagonalOrderSolution.FindDiagonalOrder(mat));
    }
}
