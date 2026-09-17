namespace LeetCode.Solution.LinkedListSol.Remove;

public class DeleteNodeSolution
{ 
    public static void DeleteNode(ListNode node)
    {
        // 不可能给到最后一个Node
        node.val = node.next!.val;
        ListNode? temp = node.next;
        node.next = node.next.next;
        temp = null;
    }
}