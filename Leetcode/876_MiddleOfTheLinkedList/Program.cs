
ListNode headWithCycle = new ListNode(1);
ListNode node2 = new ListNode(2);
ListNode node3 = new ListNode(3);
ListNode node4 = new ListNode(4);
ListNode node5 = new ListNode(5);

headWithCycle.next = node2;
node2.next = node3;
node3.next = node4;
node4.next = node5;

MiddleNode(headWithCycle);

 
ListNode MiddleNode(ListNode head)
{
    ListNode slow=head;
    ListNode fast=head;
    while(fast!=null&&fast.next!=null){
        fast=fast.next.next;
        slow=slow.next;
    }
    return slow;
}

public class ListNode { 
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}