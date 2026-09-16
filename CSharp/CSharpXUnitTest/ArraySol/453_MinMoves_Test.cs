namespace LeetCode.UnitTest.ArraySol;

public class Solution453_MinMoves_Test
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 3)]
    [InlineData(new int[] { 1, 1, 1 }, 0)]
    public void MinMoves_Input_Return(int[] nums, int expected)
    {
        Assert.Equal(expected, MinMovesSolution.MinMoves(nums));
    }
}
