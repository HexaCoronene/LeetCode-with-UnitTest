namespace LeetCode.UnitTest.ArraySol;

public class Solution396_MaxRotateFunction_Test
{
    [Theory]
    [InlineData(new int[] { 4, 3, 2, 6 }, 26)]
    [InlineData(new int[] { 100 }, 0)]
    public void MaxRotateFunction_Input_Return(int[] nums, int expected)
    {
        Assert.Equal(expected, MaxRotateFunctionSolution.MaxRotateFunction(nums));
    }
}
