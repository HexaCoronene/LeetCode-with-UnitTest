namespace LeetCode.UnitTest.ArraySol;

public class Solution119_PascalTriangle2_Test
{
    [Theory]
    [InlineData(3, new int[] { 1, 3, 3, 1 })]
    [InlineData(0, new int[] { 1 })]
    [InlineData(1, new int[] { 1, 1 })]
    public void PascalTriangleGenerate_Input_Return(int rowIndex, int[] expected)
    {
        Assert.True(expected.SequenceEqual(PascalTriangleIISolution.GetRow(rowIndex)));
    }
}
