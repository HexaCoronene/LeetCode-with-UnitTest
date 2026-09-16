namespace LeetCode.UnitTest;

public class Solution598_MaxCount_Test
{
    public static IEnumerable<object[]> MatrixEnumerator
    {
        get =>
            [
                [3, 3, new int[][] { [2, 2], [3, 3] }, 4],
                [
                    3,
                    3,
                    new int[][]
                    {
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
                    },
                    4,
                ],
                [3, 3, Array.Empty<int[]>(), 9],
            ];
    }

    [Theory]
    [MemberData(nameof(MatrixEnumerator))]
    public void MaxCount_Input_Return(int m, int n, int[][] ops, int expected)
    {
        Assert.Equal(expected, MaxCountSolution.MaxCount(m, n, ops));
    }
}
