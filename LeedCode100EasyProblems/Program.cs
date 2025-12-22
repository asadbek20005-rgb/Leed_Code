using LeedCode100EasyProblems;

ListNode list1 = new ListNode(1,
                    new ListNode(2,
                        new ListNode(3)));



ListNode list2 = new ListNode(4,
                    new ListNode(5,
                        new ListNode(6)));


var s = new MegeTwoSortedList();
var re = s.MergeTwoLists(list1, list2);

while (re != null)
{

    if (re.next != null)
    {
        Console.WriteLine(re.val);

    }

    re = re.next;
}

