namespace LeetCode.UnitTest;

public class Solution793_PreimageSizeFZF_Test
{
    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, 0)]
    [InlineData(3, 5)]
    public void PreimageSizeFZF_InputK_ReturnCount(int k, int expected)
    {
        Assert.Equal(expected, PreimageSizeFZFSolution.PreimageSizeFZF(k));
    }
}
