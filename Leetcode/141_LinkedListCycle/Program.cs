ListNode headWithCycle = new ListNode(3);
ListNode node2 = new ListNode(2);
ListNode node0 = new ListNode(0);
ListNode node4 = new ListNode(-4);

headWithCycle.next = node2;
node2.next = node0;
node0.next = node4;
node4.next = node2;

Console.WriteLine(HasCycle(headWithCycle));



//определить, является ли список цикличным
//пример реализации паттерна fast & slow pointer
bool HasCycle(ListNode head)
{
    ListNode slow = head;
    ListNode fast = head;
    
    while (fast != null && fast.next != null)
    {
        fast = fast.next.next; 
        slow = slow.next;     

        if (slow == fast)
        {
            return true;
        }
    }

    return false;
}

//связанный список
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}