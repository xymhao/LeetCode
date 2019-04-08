namespace LeetCode.Objects
{
    public class Merge_Two_Sorted_Lists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode root = new ListNode(0);
            ListNode currunt = new ListNode(0);
            if (l1 == null && l2 != null)
                return l2;
            if (l1 != null && l2 == null)
                return l1;
            if (l1 == null && l2 == null)
                return null;

            if (l1.val > l2.val)
            {
                currunt = l2;
                l2 = l2.next;
            }
            else
            {
                currunt = l1;
                l1 = l1.next;
            }
            root.next = currunt;

            while (l1 != null || l2 != null)
            {
                if (l1 == null && l2 != null)
                {
                    currunt.next = l2;
                    return root;
                }

                if (l1 != null && l2 == null)
                {
                    currunt.next = l1;
                    return root;
                }

                var pre = currunt.next;
                if (l1.val > l2.val)
                {
                    currunt.next = new ListNode(l2.val);
                    l2 = l2.next;
                }
                else
                {
                    currunt.next = new ListNode(l1.val);
                    l1 = l1.next;
                }
                currunt = currunt.next;
            }
            return root;
        }
    }
}
