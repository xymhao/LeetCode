namespace LeetCode.Objects
{
    public class Merge_Two_Sorted_Lists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode root = new ListNode(0);
            ListNode current;
            if (l1 == null && l2 != null)
                return l2;
            if (l1 != null && l2 == null)
                return l1;
            if (l1 == null)
                return null;

            if (l1.val > l2.val)
            {
                current = l2;
                l2 = l2.next;
            }
            else
            {
                current = l1;
                l1 = l1.next;
            }
            root.next = current;

            while (true)
            {
                if (l1 == null)
                {
                    current.next = l2;
                    return root;
                }

                if (l2 == null)
                {
                    current.next = l1;
                    return root;
                }

                var pre = current.next;
                if (l1.val > l2.val)
                {
                    current.next = new ListNode(l2.val);
                    l2 = l2.next;
                }
                else
                {
                    current.next = new ListNode(l1.val);
                    l1 = l1.next;
                }
                current = current.next;
            }
        }
    }
}
