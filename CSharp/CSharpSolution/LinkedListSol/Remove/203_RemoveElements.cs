namespace LeetCode.Solution.LinkedListSol.Remove;

public class RemoveElementsSolution
{
    public static ListNode? RemoveElements(ListNode? head, int val)
    {
        ListNode? p = head, q = head?.next;
        while (q is not null)
        {
            if (q.val == val)
            {
                q = q.next;
                p!.next = q;
            }
            else
            {
                p = q;
                q = q?.next;
            }
        }

        return head?.val == val ? head.next : head;
    }

    public static ListNode? RemoveElements2(ListNode? head, int val)
    {
        ListNode p = new();
        p.next = head;
        ListNode q = p;
        while (p!.next is not null)
        {
            if (p.next.val == val)
                p.next = p.next.next;
            else
                p = p.next;
        }

        return q.next;
    }
}