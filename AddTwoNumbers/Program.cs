public class ListNode
{
      public int val;
      public ListNode next;
public ListNode(int val = 0, ListNode next = null)
{
        this.val = val;
        this.next = next;
}
 }

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        l1.val += l2.val;
        l2.next = l1;
        return l1;
    }
}