namespace LeetCode.UnitTest.ArraySol;

public class Solution414_ThirdMax_Test
{
    [Theory]
    [InlineData(new int[] { 2, 2, 3, 1 }, 1)]
    [InlineData(new int[] { 3, 2, 1 }, 1)]
    [InlineData(new int[] { 1, 2 }, 2)]
    public void ThirdMax_Input_Output(int[] nums, int expected)
    {
        Assert.Equal(expected, ThirdMaxSolution.ThirdMax(nums));
    }
}
