namespace LeetCode.UnitTest;


public class Solution1_TwoSum_Test
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TwoSum_InputArrayTarget_ReturnArray(int[] nums, int target, int[] expected)
    {
        var ans = TwoSumSolution.TwoSum(nums, target);
        Array.Sort(ans);
        Array.Sort(expected);
        Assert.True(expected.SequenceEqual(ans));
    }
}
