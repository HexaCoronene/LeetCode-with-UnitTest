namespace LeetCode.UnitTest.ArraySol;

public class Solution283_MoveZeroes_Test
{
    [Theory]
    [InlineData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
    [InlineData(new int[] { 0 }, new int[] { 0 })]
    public void MoveZeroes_Input_Return(int[] nums, int[] expected)
    {
        // 原地对数组进行操作
        MoveZeroesSolution.MoveZeroes(nums);
        // 同时保持非零元素的相对顺序
        Assert.True(expected.SequenceEqual(nums));
    }
}
