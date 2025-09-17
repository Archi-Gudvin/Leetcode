
// list1 = [1,2,2,1]
ListNode list1 = new ListNode(1)
{
    next = new ListNode(2)
    {
        next = new ListNode(2)
        {
            next = new ListNode(1)
        }
    }
};


Console.WriteLine(IsPalindrome(list1));


bool IsPalindrome(ListNode head)
{
    Stack<ListNode> stack = new Stack<ListNode>();

    ListNode tempHead = head;

    while (tempHead != null)
    {
        stack.Push(tempHead);
        tempHead = tempHead.next;
    }

    while (stack.Count > 0 && head != null)
    {
        var temp = stack.Pop();

        if (temp.val != head.val)
        {
            return false;
        }

        head = head.next;
    }

    return true;
}


//связанный список
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}