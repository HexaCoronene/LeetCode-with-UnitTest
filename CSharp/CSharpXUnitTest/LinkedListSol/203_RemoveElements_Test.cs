namespace LeetCode.UnitTest.LinkedListSol;

public class Solution203_RemoveElements_Test
{
    [Theory]
    [InlineData(new int[] { 1, 2, 6, 3, 4, 5, 6 }, 6, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { }, 1, new int[] { })]
    [InlineData(new int[] { 7, 7, 7, 7 }, 7, new int[] { })]
    public void RemoveElements_Input_Return(int[] nodes, int val, int[] expected)
    {
        ListNode? head = ListNode.Create(nodes);
        Assert.Equal(expected, RemoveElementsSolution.RemoveElements(head, val).ToArray());
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 6, 3, 4, 5, 6 }, 6, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { }, 1, new int[] { })]
    [InlineData(new int[] { 7, 7, 7, 7 }, 7, new int[] { })]
    public void RemoveElements2_Input_Return(int[] nodes, int val, int[] expected)
    {
        ListNode? head = ListNode.Create(nodes);
        Assert.Equal(expected, RemoveElementsSolution.RemoveElements2(head, val).ToArray());
    }
}
