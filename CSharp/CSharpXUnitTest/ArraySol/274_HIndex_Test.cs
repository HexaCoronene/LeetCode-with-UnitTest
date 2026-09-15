namespace LeetCode.UnitTest.ArraySol;

public class Solution274_HIndex_Test
{
    [Theory]
    [InlineData(new int[] { 3, 0, 6, 1, 5 }, 3)]
    [InlineData(new int[] { 1, 3, 1 }, 1)]
    public void HIndex_Input_Return(int[] citations, int expected)
    {
        Assert.Equal(expected, HIndexSolution.HIndex(citations));
    }
}
