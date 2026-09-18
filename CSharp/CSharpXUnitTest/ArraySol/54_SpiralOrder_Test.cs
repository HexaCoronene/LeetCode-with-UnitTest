namespace LeetCode.UnitTest.ArraySol;

public class Solution54_SpiralOrder_Test
{
    public static IEnumerable<TheoryDataRow<int[][], int[]>> SpiralAnsPair2 =
    [
        new(
            [
                [1, 2, 3],
                [4, 5, 6],
                [7, 8, 9],
            ],
            [1, 2, 3, 6, 9, 8, 7, 4, 5]
        ),
    ];

    [Theory]
    [MemberData(nameof(SpiralAnsPair2))]
    public void SpiralOrder_Input_Return(int[][] matrix, int[] expected)
    {
        Assert.Equal(expected, SpiralOrderSolution.SpiralOrder(matrix).ToArray());
    }
}
