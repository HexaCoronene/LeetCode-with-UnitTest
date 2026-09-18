namespace LeetCode.UnitTest.ArraySol;

public class Solution598_MaxCount_Test
{
    public static IEnumerable<TheoryDataRow<int, int, int[][], int>> MatrixEnumerator =
    [
        new(
            3,
            3,
            [
                [2, 2],
                [3, 3],
            ],
            4
        ),
        new(
            3,
            3,
            [
                [2, 2],
                [3, 3],
                [3, 3],
                [3, 3],
                [2, 2],
                [3, 3],
                [3, 3],
                [3, 3],
                [2, 2],
                [3, 3],
                [3, 3],
                [3, 3],
            ],
            4
        ),
        new(3, 3, [], 9),
    ];

    [Theory]
    [MemberData(nameof(MatrixEnumerator))]
    public void MaxCount_Input_Return(int m, int n, int[][] ops, int expected)
    {
        Assert.Equal(expected, MaxCountSolution.MaxCount(m, n, ops));
    }
}
