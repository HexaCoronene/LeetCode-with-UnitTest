namespace LeetCode.UnitTest.ArraySol;

using LeetCode.Solution.ArraySol.ThroughoutArray;
public class Solution628_MaximumProduct_Test
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 6)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 24)]
    [InlineData(new int[] { -1, -2, -3 }, -6)]
    public void FindErrorNums_Input_Output(int[] nums, int expected)
    {
        Assert.Equal(expected, MaximumProductSolution.MaximumProduct(nums));
    }
}
