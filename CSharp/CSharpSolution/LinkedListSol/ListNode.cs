namespace LeetCode.Solution.LinkedListSol;

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public ListNode(int[] vals)
    {
        if (vals.Length < 1)
            throw new ArgumentException("list can not be empty");

        ListNode p = this;
        p.val = vals[0];
        for (int i = 1; i < vals.Length; i++)
        {
            p.next = new ListNode();
            p = p.next;
            p.val = vals[i];
        }
    }

    public static ListNode? Create(int[]? vals)
    {
        if (vals is null || vals.Length == 0) return null;
        ListNode p = new(vals[0]), head = p;
        for (int i = 1; i < vals.Length; i++)
        {
            p.next = new ListNode();
            p = p.next;
            p.val = vals[i];
        }
        return head;
    }
}

public static class ListNodeExtension
{
    public static int[] ToArray(this ListNode? node)
    {
        if (node is null) return Array.Empty<int>();
        var p = node;
        List<int> ret = new();
        while (p is not null)
        {
            ret.Add(p.val);
            p = p.next;
        }
        return ret.ToArray();
    }
}