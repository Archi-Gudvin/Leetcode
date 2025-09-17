ListNode headWithCycle = new ListNode(3);
ListNode node2 = new ListNode(2);
ListNode node0 = new ListNode(0);
ListNode node4 = new ListNode(-4);

headWithCycle.next = node2;
node2.next = node0;
node0.next = node4;

var res = ReverseList(headWithCycle);


ListNode ReverseList(ListNode head)
{
    ListNode current = head;
    ListNode next = null;
    ListNode prev = null;

    while (current != null)
    {
        next = current.next;

        current.next = prev;

        prev = current;

        current = next;
    }

    return prev;
}


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
