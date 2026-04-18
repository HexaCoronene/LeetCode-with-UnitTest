namespace LeetCode.UnitTest.ArraySol;

using LeetCode.Solution.ArraySol.ElementCount;
public class Solution697_FindShortestSubArray_Test
{
    [Theory]
    [InlineData(new int[] { 1, 2, 2, 3, 1 }, 2)]
    [InlineData(new int[] { 1, 2, 2, 3, 1, 4, 2 }, 6)]
    public void FindErrorNums_Input_Output(int[] nums, int expected)
    {
        Assert.Equal(expected, FindShortestSubArraySolution.FindShortestSubArray(nums));
    }
}
