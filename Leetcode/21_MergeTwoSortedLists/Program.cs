// list1 = [1,2,4]
ListNode list1 = new ListNode(1)
{
    next = new ListNode(2)
    {
        next = new ListNode(4)
    }
};

// list2 = [1,3,4]
ListNode list2 = new ListNode(1)
{
    next = new ListNode(3)
    {
        next = new ListNode(4)
    }
};

var res = MergeTwoLists(list1, list2);


ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    ListNode result = new ListNode(-1);

    ListNode curr = result;

    while (list1 != null && list2 != null)
    {
        if (list1.val <= list2.val)
        {
            curr.next = list1;
            list1 = list1.next;
        }
        else
        {
            curr.next = list2;
            list2 = list2.next;
        }

        curr = curr.next;
    }

    if (list1 != null) curr.next = list1;
    if (list2 != null) curr.next = list2;

    return result.next;
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