namespace LeetCode.Solution.LinkedListSol.Remove;

public class RemoveNthFromEndSolution
{
    public static ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode? fast = head, slow = head;
        for (int i = 0; i < n; i++)
        {
            fast = fast?.next;
        }

        if (fast is null)
        {
            return head.next;
        }

        while (fast.next is not null)
        {
            fast = fast.next;
            slow = slow!.next;
        }

        slow!.next = slow.next!.next;

        return head;
    }
}