namespace LeetCode.UnitTest.ArraySol;

public class Solution442_FindDuplicates_Test
{
    [Theory]
    [InlineData(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new int[] { 2, 3 })]
    [InlineData(new int[] { 1, 1, 2 }, new int[] { 1 })]
    [InlineData(new int[] { }, new int[] { })]
    public void FindDuplicates_InputIntArray_ReturnAllDuplicateIntegers(int[] nums, int[] expected)
    {
        Assert.True(expected.ElementEqual(FindDuplicatesSolution.FindDuplicates(nums).ToArray()));
    }
}
