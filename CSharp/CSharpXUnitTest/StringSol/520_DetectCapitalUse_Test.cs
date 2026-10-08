namespace LeetCode.UnitTest.StringSol;

public class Solution520_DetectCapitalUse_Test
{
    [Theory]
    [InlineData("USA", true)]
    [InlineData("FlaG", false)]
    public void DetectCapitalUse_Input_Return(string word, bool expected)
    {
        Assert.Equal(expected, DetectCapitalUseSolution.DetectCapitalUse(word));
    }
}
