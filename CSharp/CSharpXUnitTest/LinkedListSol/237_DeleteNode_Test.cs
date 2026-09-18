namespace LeetCode.UnitTest.LinkedListSol;

public class Solution237_DeleteNode_Test
{
    [Theory]
    [InlineData(new int[] { 4, 5, 1, 9 }, 5, new int[] { 4, 1, 9 })]
    public void DeleteNode_Input_Return(int[] list, int node_val, int[] expected)
    {
        Assert.InRange(list.Length, 2, 1000);
        Assert.True(list.All(val => -1000 <= val && val <= 1000));
        Assert.Equal(list.Distinct().Count(), list.Length);
        Assert.Contains(node_val, list);
        ListNode head = ListNode.Create(list)!;
        var node = head;
        while (node!.val != node_val)
        {
            node = node.next;
        }
        DeleteNodeSolution.DeleteNode(node);
        Assert.True(expected.SequenceEqual(head.ToArray()));
    }
}
