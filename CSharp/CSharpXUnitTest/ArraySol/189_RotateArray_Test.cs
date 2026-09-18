namespace LeetCode.UnitTest.ArraySol;

public class Solution189_RotateArray_Test
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
    [InlineData(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
    [InlineData(new int[] { -1 }, 2, new int[] { -1 })]
    public void Rotate_InputNumsAndK_ChangeNums(int[] nums, int k, int[] expectedNums)
    {
        RotateArraySolution.Rotate(nums, k);
        Assert.True(expectedNums.SequenceEqual(nums));
    }
}
