namespace LeetCode.UnitTest.ArraySol;

public class Solution118_PascalTriangle_Test
{
    public static IEnumerable<object[]> MatrixEnumerator
    {
        get =>
            [
                [5, new int[][] { [1], [1, 1], [1, 2, 1], [1, 3, 3, 1], [1, 4, 6, 4, 1] }],
                [1, new int[][] { [1] }],
            ];
    }

    [Theory]
    [MemberData(nameof(MatrixEnumerator))]
    public void PascalTriangleGenerate_Input_Return(int rows, int[][] expected)
    {
        var triangle = PascalTriangleSolution.Generate(rows);
        Assert.Equal(expected.Length, triangle.Count);
        foreach ((var exp, var tri) in expected.Zip(triangle))
        {
            Assert.True(exp.SequenceEqual(tri));
        }
    }
}
