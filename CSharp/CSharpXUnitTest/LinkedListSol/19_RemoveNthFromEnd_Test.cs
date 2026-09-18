namespace LeetCode.UnitTest.LinkedListSol;

public class Solution19_RemoveNthFromEnd_Test
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 3, 5 })]
    [InlineData(new int[] { 1 }, 1, new int[] { })]
    [InlineData(new int[] { 1, 2 }, 1, new int[] { 1 })]
    public void RemoveNthFromEnd_Input_Return(int[] nodes, int n, int[] expected)
    {
        ListNode head = new(nodes);
        Assert.True(n >= 1);
        Assert.True(
            expected.SequenceEqual(RemoveNthFromEndSolution.RemoveNthFromEnd(head, n).ToArray())
        );
    }
}
