namespace LeetCode.UnitTest.ArraySol;

public class Solution118_PascalTriangle_Test
{
    public static IEnumerable<TheoryDataRow<int, int[][]>> MatrixEnumerator =
    [
        new(
            5,
            [
                [1],
                [1, 1],
                [1, 2, 1],
                [1, 3, 3, 1],
                [1, 4, 6, 4, 1],
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
    [MemberData(nameof(MatrixEnumerator))]
    public void PascalTriangleGenerate_Input_Return(int rows, int[][] expected)
    {
        var triangle = PascalTriangleSolution.Generate(rows);
        Assert.Equal(expected.Length, triangle.Count);
        foreach ((var exp, var tri) in expected.Zip(triangle))
        {
            Assert.Equal(exp, tri);
        }
    }
}
