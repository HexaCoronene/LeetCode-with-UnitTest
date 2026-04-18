namespace LeetCode.UnitTest.ArraySol;

public class Solution448_FindDisappearedNumbers_Test
{
    [Theory]
    [InlineData(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new int[] { 5, 6 })]
    [InlineData(new int[] { 1, 1 }, new int[] { 2 })]
    public void FindDisappearedNumbers_Test(int[] nums, int[] expected)
    {
        Assert.True(expected.SequenceEqual(FindDisappearedNumbersSolution.FindDisappearedNumbers(nums)));
    }
}