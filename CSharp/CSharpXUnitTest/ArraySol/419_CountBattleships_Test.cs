namespace LeetCode.UnitTest.ArraySol;

public class Solution419_CountBattleships_Test
{
    public static IEnumerable<object[]> BattleshipMatrix
    {
        get =>
            [
                [
                    new char[][]
                    {
                        ['X', '.', '.', 'X'],
                        ['.', '.', '.', 'X'],
                        ['.', '.', '.', 'X'],
                    },
                    2,
                ],
                [new char[][] { ['.'] }, 0],
            ];
    }

    [Theory]
    [MemberData(nameof(BattleshipMatrix))]
    public void CountBattleships_Input_Return(char[][] board, int expected)
    {
        Assert.Equal(expected, CountBattleshipsSolution.CountBattleships(board));
    }
}
