namespace LeetCode.UnitTest.ArraySol;

public class Solution485_FindMaxConsecutiveOnes_Test
{
    [Theory]
    [InlineData(new int[] { 1, 1, 0, 1, 1, 1 }, 3)]
    public void FindMaxConsecutiveOnes_Input_Output(int[] nums, int expected)
    {
        Assert.Equal(expected, FindMaxConsecutiveOnesSolution.FindMaxConsecutiveOnes(nums));
    }
}
