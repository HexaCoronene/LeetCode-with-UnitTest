namespace LeetCode.UnitTest.ArraySol;

public class Solution665_CheckPossibility_Test
{
    [Theory]
    [InlineData(new int[] { 4, 2, 3 }, true)]
    [InlineData(new int[] { 4, 2, 1 }, false)]
    public void CheckPossibility_Input_Return(int[] nums, bool expected)
    {
        Assert.Equal(expected, CheckPossibilitySolution.CheckPossibility(nums));
    }
}
