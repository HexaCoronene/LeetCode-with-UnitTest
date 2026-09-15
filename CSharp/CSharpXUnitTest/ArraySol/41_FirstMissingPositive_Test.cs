namespace LeetCode.UnitTest.ArraySol;

public class Solution41_FirstMissingPositive_Test
{
    [Theory]
    [InlineData(new int[] { 1, 2, 0 }, 3)]
    [InlineData(new int[] { 3, 4, -1, 1 }, 2)]
    [InlineData(new int[] { 7, 8, 9, 11, 12 }, 1)]
    public void FirstMissingPositive_InputNotSortedIntArray_ReturnInt(int[] nums, int expected)
    {
        Assert.Equal(expected, FirstMissingPositiveSolution.FirstMissingPositive(nums));
    }
}
