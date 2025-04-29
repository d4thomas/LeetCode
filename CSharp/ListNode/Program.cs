
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public override string ToString()
    {
        var result = new System.Text.StringBuilder();
        result.Append("[");
        var current = this;
        while (current != null)
        {
            result.Append(current.val);
            if (current.next != null)
            {
                result.Append(", ");
            }
            current = current.next;
        }
        result.Append("]");
        return result.ToString();
    }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var dummy = new ListNode(-1);
        var current = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        current.next = list1 ?? list2;

        return dummy.next;
    }
}

public class Program
{
    public static void Main()
    {
        var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        Console.WriteLine(new Solution().MergeTwoLists(list1, list2));
    }
}