namespace LeetCode.UnitTest.ArraySol;

public class Solution495_FindPoisonedDuration_Test
{
    [Theory]
    [InlineData(new int[] { 1, 4 }, 2, 4)]
    public void FindPoisonedDuration_Input_Output(int[] timeSeries, int duration, int expected)
    {
        Assert.Equal(expected, FindPoisonedDurationSolution.FindPoisonedDuration(timeSeries, duration));
    }
}
