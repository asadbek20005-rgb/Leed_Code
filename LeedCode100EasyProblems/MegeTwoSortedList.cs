namespace LeedCode100EasyProblems;

public class MegeTwoSortedList
{

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var result = new ListNode();
        while (list1 != null && list2 != null)
        {

            if (list1.val <= list2.val)
            {
                result.val = list1.val;
                result.next = new ListNode();
                result = result.next;
                list1 = list1.next;
            }
            else
            {
                result.val = list2.val;
                result.next = new ListNode();
                result = result.next;
                list2 = list2.next;
            }
        }

        return result;
    }


    public ListNode MergeTwoLists2(ListNode l1, ListNode l2)
    {
        if (l1 == null) return l2;
        if (l2 == null) return l1;
        if (l1.val <= l2.val)
        {
            l1.next = MergeTwoLists(l1.next, l2);
            return l1;
        }
        else
        {
            l2.next = MergeTwoLists(l1, l2.next);
            return l2;
        }
    }


    public ListNode MergeTwoList3(ListNode l1, ListNode l2)
    {
        if(l1 == null) return l2;
        if (l2 == null) return l1;

        if(l1.val <= l2.val)
        {
            l1.next = MergeTwoList3(l1.next, l2);
            return l1;
        }
        else
        {
            l2.next = MergeTwoList3(l1, l2.next);
            return l2;
        }
    }
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
