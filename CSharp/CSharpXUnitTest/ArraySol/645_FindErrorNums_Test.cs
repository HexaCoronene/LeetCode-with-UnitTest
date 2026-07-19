namespace LeetCode.UnitTest.ArraySol;

public class Solution645_FindErrorNums_Test
{
    [Theory]
    [InlineData(new int[] { 1, 2, 2, 4 }, new int[] { 2, 3 })]
    [InlineData(new int[] { 1, 1 }, new int[] { 1, 2 })]
    public void FindErrorNums_InputNumsIntArray_OutputIntArray(int[] nums, int[] expected)
    {
        Assert.True(expected.SequenceEqual(FindErrorNumsSolution.FindErrorNums(nums)));
    }
}
